Imports System.Data.SqlClient
Module koneksi
    Public cmd As New SqlCommand
    Public query As String
    Public conn As New SqlConnection
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public rd As SqlDataReader

    Sub jembatan()
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=LAPTOP-CUEFA1LA\SKA2DASQLSERVER;Initial Catalog=dbtest;Integrated Security=True"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Success")
            End If
        Catch ex As Exception
            'MsgBox("Failed")
        End Try
    End Sub
End Module
