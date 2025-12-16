Imports System.Data.OleDB
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Public Str As String

    Public Sub Koneksi()
        Try
            Str = "Provider=Microsoft.Jet.OLEDB.4.0;data source=EkaSalon.mdb;"
            Conn = New OleDbConnection(Str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                MsgBox("Koneksi Database Berhasil")

            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal - Cek Databasenya")
        End Try
    End Sub
End Module
