Imports System.Data.SqlClient
Public Class FormCariProduct
    Sub tampil()
        On Error Resume Next
        ds = New DataSet
        query = "select * from tbproduct"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ManagePromoForm.TextProductID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        ManagePromoForm.TextProductName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub FormCariProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        jembatan()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundForm.Hide()
        Me.Hide()
        BackgroundForm.Show()
        ManagePromoForm.Show()
    End Sub
End Class