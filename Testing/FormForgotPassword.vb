Imports System.Data.SqlClient
Public Class FormForgotPassword
    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        da = New SqlDataAdapter("select * from tblogin where username like '" & txtusername.Text &
                                "%' or password like '" & txtusername.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class