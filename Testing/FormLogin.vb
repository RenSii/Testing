Imports System.Data.SqlClient
Public Class FormLogin
    Sub kosong()
        txtusername.Text = ""
        txtpw.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        txtpw.PasswordChar = "*"
    End Sub
    '
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        On Error Resume Next
        If txtusername.Text = "" Or txtpw.Text = "" Then
            MsgBox("Masukkan namamu dan paswordmu")
            Exit Sub
        Else
            jembatan()
            cmd = New SqlCommand("select * from tblogin where username='" & txtusername.Text & "' and password='" & txtpw.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Wellcome  " & txtusername.Text & "!")
                Me.Hide()
                FormMenu.Show()
                BackgroundForm.Hide()
                FormMenu.MasterToolStripMenuItem.Enabled = True
                FormMenu.TransaksiToolStripMenuItem.Enabled = True
                FormMenu.ReportToolStripMenuItem.Enabled = True
                FormMenu.TextHalo.Text = txtusername.Text
                kosong()
            Else
                MsgBox("Username/Password salah")
            End If
        End If



    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        FormRegister.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonForgotPassword_Click(sender As Object, e As EventArgs) Handles ButtonForgotPassword.Click
        FormForgotPassword.Show()
        Me.Hide()
    End Sub
End Class
