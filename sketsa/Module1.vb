Imports MySql.Data.MySqlClient
Module Module1

    Public Conn As MySqlConnection
    Dim LokasiDB As String
    Public Sub koneksi()
        LokasiDB = "Server=localhost;Database=sketsa;User Id=root;"
        Conn = New MySqlConnection(LokasiDB)

        Conn.Open()
    End Sub


End Module
