Imports System.Data.SqlClient
Public Class FormMenu
    Sub TampilanAwal()
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        ReportToolStripMenuItem.Enabled = False
    End Sub
    Sub kosong()
        TextHalo.Text = ""
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        BackgroundForm.Show()
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        TampilanAwal()
        TextHalo.Text = FormLogin.txtusername.Text
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        TampilanAwal()
        MsgBox("Telah Logout")
        TextHalo.Text = ""
        kosong()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextHalo.TextChanged
        TextHalo.Text = FormLogin.txtusername.Text
    End Sub

    Private Sub ManageMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMemberToolStripMenuItem.Click
        BackgroundForm.Show()
        Me.Hide()
        ManageMemberForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim q As Integer
        q = MsgBox("Yakin Keluar?", vbQuestion + vbYesNo)
        If q = vbYes Then
            Close()
        End If
    End Sub

    Private Sub ManageProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageProductToolStripMenuItem.Click
        BackgroundForm.Show()
        Me.Hide()
        ManageProductForm.Show()
    End Sub

    Private Sub ManagePromoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePromoToolStripMenuItem.Click
        BackgroundForm.Show()
        Me.Hide()
        ManagePromoForm.Show()
    End Sub
End Class