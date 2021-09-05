Imports System.Data.SqlClient
Module Module1
    Public Conn As New SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "data source=LAPTOP-J35ML5I0;initial catalog=db_penjualan;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
