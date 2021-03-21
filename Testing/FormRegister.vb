Imports System.Data.SqlClient
Public Class FormRegister
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        txtpw.PasswordChar = "*"
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        On Error Resume Next
        If txtpw.Text = "" Or txtusername.Text = "" Then
            MsgBox("masukkan username dan password")
            Exit Sub
        Else
            jembatan()
            cmd = New SqlCommand("select * from tbregister where username='" & txtusername.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = 0 Then
                Call jembatan()
                cmd = New SqlCommand
                cmd.Connection = conn
                query = "insert into tblogin values('" & txtusername.Text & "','" & txtpw.Text & "')"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("Saved")

            End If
        End If
    End Sub
End Class