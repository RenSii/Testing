Imports System.Data.SqlClient
Public Class ManageMemberForm
    Sub tampilanawal()
        TextMemberID.Text = ""
        TextMemberName.Text = ""
        TextMemberEmail.Text = ""
        TextMemberHandphone.Text = ""
    End Sub
    Sub tampil()
        ds = New DataSet
        query = "select * from tbmember"
        da = New SqlDataAdapter(query, conn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub ManageMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jembatan()
        tampilanawal()
        tampil()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim q As Integer
        q = MsgBox("Yakin Keluar?", vbQuestion + vbYesNo)
        If q = vbYes Then
            FormMenu.Show()
            Me.Close()
            BackgroundForm.Hide()
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        On Error Resume Next
        If ButtonSave.Text = "ADD" Then
            ButtonSave.Text = "SAVE"
            jembatan()

            cmd = New SqlCommand("select * from tbmember where member_id in(select max(member_id) from tbmember)", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            Dim urutankode As String
            Dim hitung As Long

            If rd.HasRows = 0 Then
                urutankode = "MEM-" + "0001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 4) + 1
                urutankode = "MEM-" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
            TextMemberID.Text = urutankode
            TextMemberName.Focus()

            TextMemberName.Text = ""
            TextMemberEmail.Text = ""
            TextMemberHandphone.Text = ""
        Else
            If TextMemberID.Text = "" Or TextMemberName.Text = "" Or TextMemberEmail.Text = "" Or TextMemberHandphone.Text = "" Then
                MsgBox("Masukkan Data Terlebih Dahulu")
                Exit Sub
            Else
                jembatan()
                cmd = New SqlCommand("select * from tbmember where member_id='" & TextMemberID.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = 0 Then
                    jembatan()
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = "insert into tbmember values('" & TextMemberID.Text & "','" & TextMemberName.Text & "','" & TextMemberEmail.Text & "','" & TextMemberHandphone.Text & "','" & DateTimePicker1.Value & "' )"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    tampil()
                    MsgBox("Tersimpan")
                    tampilanawal()
                    ButtonSave.Text = "ADD"
                Else
                    MsgBox("Gagal")
                End If
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextMemberID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextMemberName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextMemberEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextMemberHandphone.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        On Error Resume Next
        If TextMemberName.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            jembatan()
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "delete tbmember where member_id='" & TextMemberID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terhapus")
            tampilanawal()
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        On Error Resume Next
        If TextMemberID.Text = "" Or TextMemberName.Text = "" Or TextMemberEmail.Text = "" Or TextMemberHandphone.Text = "" Then
            MsgBox("pilih data terlebih dahulu")
            Exit Sub
        ElseIf MessageBox.Show("Yakin mau diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "update tbmember set member_name='" & TextMemberName.Text & "', member_email='" & TextMemberEmail.Text & "', member_handphone='" & TextMemberHandphone.Text & "', expired_date='" & DateTimePicker1.Text & "' where member_id='" & TextMemberID.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            tampil()
            MsgBox("Terupdate")
            tampilanawal()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        tampilanawal()
    End Sub
End Class