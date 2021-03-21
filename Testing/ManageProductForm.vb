Imports System.Data.SqlClient
Public Class ManageProductForm
    Sub tampilanawal()
        TextProductID.Text = ""
        TextProductName.Text = ""
        TextSpecification.Text = ""
        TextBuyPrice.Text = ""
        TextSellPrice.Text = ""
    End Sub
    Sub tampil()
        ds = New DataSet
        query = "select * from tbproduct"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub ManageProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        tampilanawal()
        tampil()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextProductID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextProductName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextSpecification.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBuyPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextSellPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        On Error Resume Next
        If ButtonSave.Text = "ADD" Then
            ButtonSave.Text = "SAVE"
            jembatan()

            cmd = New SqlCommand("select * from tbproduct where product_id in(select max(product_id)from tbproduct)", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            Dim urutankode As String
            Dim hitung As Long

            If Not rd.HasRows Then
                urutankode = "PR" + "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 2) + 1
                urutankode = "PR" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
            TextProductID.Text = urutankode
            TextProductName.Focus()

            TextProductName.Text = ""
            TextSpecification.Text = ""
            TextBuyPrice.Text = ""
            TextSellPrice.Text = ""
        Else
            If TextProductID.Text = "" Then
                MsgBox("Isi dulu")
                Exit Sub
            Else
                jembatan()
                cmd = New SqlCommand("select * from tbproduct where product_id='" & TextProductID.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = 0 Then
                    jembatan()
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = "insert into tbproduct values('" & TextProductID.Text & "','" & TextProductName.Text & "','" & TextSpecification.Text & "','" & TextBuyPrice.Text & "','" & TextSellPrice.Text & "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    tampil()
                    MsgBox("Saved")
                    tampilanawal()
                    ButtonSave.Text = "ADD"
                End If
            End If
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        MsgBox("Yakin?", vbQuestion + vbYesNo)
        Me.Hide()
        FormMenu.Show()
        BackgroundForm.Hide()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        On Error Resume Next
        If TextProductID.Text = "" Then
            MsgBox("Pilih dlu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            jembatan()
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "update tbproduct set product_name='" & TextProductName.Text & "', specification='" & TextSpecification.Text & "', buy_price='" & TextBuyPrice.Text & "', sell_price='" & TextSellPrice.Text & "' where product_id='" & TextProductID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terupdate")
            tampilanawal()
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        On Error Resume Next
        If TextProductID.Text = "" Then
            MsgBox("Pilih dlu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            jembatan()
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "delete tbproduct where product_id='" & TextProductID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terhapus")
            tampilanawal()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        tampilanawal()
    End Sub
End Class