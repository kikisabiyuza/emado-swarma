Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = ""
        txt_password.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = txt_username.Text
        Dim password = txt_password.Text
        If username = "" Or password = "" Then
            MsgBox("Username atau password tidak boleh kosong !")
        Else

            If password <> "admin" Then
                MsgBox("Username atau Password tidak valid !")
            Else
                Me.Hide()
                Call koneksi()

                If Conn.State = ConnectionState.Open Then
                    Form2.Show()
                Else
                    MsgBox("Koneksi ke database gagal !")
                End If

            End If
        End If
    End Sub
End Class
