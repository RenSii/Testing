Imports System.Data.SqlClient
Public Class ManagePromoForm
    Sub TampilanAwal()
        TextPromoID.Text = ""
        TextProductID.Text = ""
        TextProductName.Text = ""
        TextBuyQty.Text = ""
        ComboPromo.Text = ""
        TextPromoReward.Text = ""
    End Sub
    Sub tampil()
        ds = New DataSet
        query = "select * from tbpromo"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub ManagePromoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        TampilanAwal()
        tampil()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextPromoID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextProductID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextProductName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBuyQty.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ComboPromo.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextPromoReward.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        StartDate.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        EndDate.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub
    Private Sub ButtonSave_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
        On Error Resume Next
        If ButtonSave.Text = "ADD" Then
            ButtonSave.Text = "SAVE"
            jembatan()

            cmd = New SqlCommand("select * from tbpromo where promo_id in (select max (promo_id) from tbpromo)", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            Dim urutankode As String
            Dim hitung As Long

            If rd.HasRows = 0 Then
                urutankode = "PRO-" + "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 4) + 1
                urutankode = "PRO-" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
            TextPromoID.Text = urutankode
            TextProductName.Focus()

            TextBuyQty.Text = ""
            TextPromoReward.Text = ""
        Else
            If TextPromoID.Text = "" Or TextProductID.Text = "" Then
                MsgBox("Isi dlu")
                Exit Sub
            Else
                jembatan()
                cmd = New SqlCommand("select * from tbpromo where promo_id='" & TextPromoID.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = 0 Then
                    jembatan()
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = "insert into tbpromo values('" & TextPromoID.Text & "','" & TextProductID.Text & "','" & TextProductName.Text & "','" & TextBuyQty.Text & "','" & ComboPromo.Text & "','" & TextPromoReward.Text & "','" & StartDate.Text & "','" & EndDate.Text & "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    tampil()
                    MsgBox("Tersimpan")
                    TampilanAwal()
                    ButtonSave.Text = "ADD"
                End If
            End If
        End If
    End Sub

    Private Sub ButtonCariProductID_Click(sender As Object, e As EventArgs) Handles ButtonCariProductID.Click
        BackgroundForm.Show()
        Me.Hide()
        FormCariProduct.Show()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        On Error Resume Next
        If TextPromoID.Text = "" Then
            MsgBox("Pilih dlu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin mau dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            jembatan()
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "delete tbpromo where promo_id='" & TextPromoID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terhapus")
            TampilanAwal()
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TextProductID.Text = "" Then
            MsgBox("Pilih dlu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin mau diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            jembatan()
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "update tbpromo set product_id='" & TextProductID.Text & "', product_name='" & TextProductName.Text & "', buy_qty='" & TextBuyQty.Text & "', promo_type='" & ComboPromo.Text & "', promo_reward='" & TextPromoReward.Text & "', start_date='" & StartDate.Text & "', end_date='" & EndDate.Text & "' where promo_id='" & TextPromoID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terupdate")
            TampilanAwal()
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        TampilanAwal()
        ButtonSave.Text = "ADD"
        BackgroundForm.Hide()
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class