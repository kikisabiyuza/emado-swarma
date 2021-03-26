Imports MySql.Data.MySqlClient
Public Class Form2


    Dim adapterShowKaryawan As New MySqlDataAdapter("SELECT * FROM tbl_karyawan", Conn)
    Dim table As New DataTable
    Dim usernameSebelum As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pada saat load pertama kali, isi tampilkan langsung isi tabel
        adapterShowKaryawan.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim username = txt_nama.Text
        Dim golongan = cb_golongan.Text
        Dim jabatan = cb_jabatan.Text
        Dim departemen = txt_departemen.Text
        Dim gaji = txt_gaji.Text
        Dim tunjangan = txt_tunjangan.Text
        Dim tglLahir = dt_tgl_lahir.Value.Year &
                        "-" & dt_tgl_lahir.Value.Month &
                        "-" & dt_tgl_lahir.Value.Day

        Dim jenisKelamin = cb_jk.Text
        Dim alamat = txt_alamat.Text
        Dim norek = txt_norek.Text
        Dim npwp = txt_npwp.Text
        Dim bpjs = txt_bpjs.Text
        Dim lokasi = txt_lokasi.Text
        Dim url_photo = pb_profil.ImageLocation

        Dim query = $"INSERT INTO tbl_karyawan VALUES (NULL," &
                            $"'{username}'," &
                            "'" & "admin" & "'," &
                            $"'{golongan}'," &
                            $"'{jabatan}'," &
                            $"'{departemen}'," &
                                  $"{gaji}," &
                                  $"{tunjangan}," &
                            $"'{tglLahir}'," &
                            $"'{jenisKelamin}'," &
                            $"'{alamat}'," &
                            $"'{norek}'," &
                            $"'{npwp}'," &
                            $"'{bpjs}'," &
                            $"'{lokasi}'," &
                            $"'{url_photo}')"

        Call koneksi()
        If Conn.State <> ConnectionState.Open Then
            MsgBox("aplikasi tidak terkoneksi database. karyawan tidak ditambahkan !")
            Return
        End If

        Dim CmdCheck As New MySqlCommand($"SELECT username FROM tbl_karyawan WHERE username = '{username}'", Conn)

        Dim usernameTable = CmdCheck.ExecuteScalar()

        If usernameTable <> "" Then
            MsgBox($"Username {username} sudah ada")
            Return
        End If

        Dim Cmd As New MySqlCommand(query, Conn)
        Cmd.ExecuteNonQuery()
        txt_cari.Text = ""
        RefreshTableAfterModify()
        ResetForm()


        MsgBox("User " & username & " tersimpan")
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            DataGridView1.ClearSelection()
            Return
        End If
        Call PopulateForm(e.RowIndex)
        txt_cari.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Or e.RowIndex = DataGridView1.Rows.Count - 1 Then
            DataGridView1.ClearSelection()
            Return
        End If
        DataGridView1.Rows.Item(e.RowIndex).Selected = True
        Call PopulateForm(e.RowIndex)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_nama.Text = "" Then
            MsgBox("Form tidak boleh kosong !")
            Return
        End If

        Dim username = txt_nama.Text
        Dim golongan = cb_golongan.Text
        Dim jabatan = cb_jabatan.Text
        Dim departemen = txt_departemen.Text
        Dim gaji = txt_gaji.Text
        Dim tunjangan = txt_tunjangan.Text
        Dim tglLahir = dt_tgl_lahir.Value.Year &
                        "-" & dt_tgl_lahir.Value.Month &
                        "-" & dt_tgl_lahir.Value.Day

        Dim jenisKelamin = cb_jk.Text
        Dim alamat = txt_alamat.Text
        Dim norek = txt_norek.Text
        Dim npwp = txt_npwp.Text
        Dim bpjs = txt_bpjs.Text
        Dim lokasi = txt_lokasi.Text
        Dim url_photo = pb_profil.ImageLocation.Replace("\", "\\")

        Dim query = "UPDATE tbl_karyawan SET " &
                    $"username='{username}'," &
                    $"golongan='{golongan}'," &
                    $"jabatan='{jabatan}'," &
                    $"department='{gaji}'," &
                    $"gaji={gaji}," &
                    $"tunjangan={tunjangan}," &
                    $"tgl_lahir='{tglLahir}'," &
                    $"jenis_kelamin='{jenisKelamin}'," &
                    $"alamat='{alamat}'," &
                    $"no_rek='{norek}'," &
                    $"no_npwp='{npwp}'," &
                    $"no_bpjs='{bpjs}'," &
                    $"lokasi='{lokasi}'," &
                    $"url_foto='{url_photo}' WHERE username = '{usernameSebelum}'"

        Call koneksi()

        If Conn.State <> ConnectionState.Open Then
            MsgBox("aplikasi tidak terkoneksi database. karyawan tidak modifikasi !")
            Return
        End If

        Dim CmdCheck As New MySqlCommand($"SELECT username FROM tbl_karyawan WHERE username = '{username}'", Conn)

        Dim usernameTable = CmdCheck.ExecuteScalar()

        If usernameTable = "" Then
            MsgBox($"Username {username} tidak ada")
            Return
        End If

        Dim Cmd As New MySqlCommand(query, Conn)
        Cmd.ExecuteNonQuery()
        txt_cari.Text = ""
        RefreshTableAfterModify()
        ResetForm()
        MsgBox("Berhasil Update !",)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        txt_cari.Text = ""
        RefreshTableAfterModify()
        ResetForm()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim username = txt_nama.Text
        If username = "" Then
            MsgBox("username tidak bisa kosong !")
            Return
        End If

        Dim Cmd As New MySqlCommand($"DELETE FROM tbl_karyawan WHERE username = '{username}'", Conn)
        Dim CmdCheck As New MySqlCommand($"SELECT username FROM tbl_karyawan WHERE username = '{username}'", Conn)

        If Conn.State <> ConnectionState.Open Then
            MsgBox("aplikasi tidak terkoneksi database. karyawan tidak ditambahkan !")
            Return
        End If

        Dim usernameTable = CmdCheck.ExecuteScalar()

        If usernameTable = "" Then
            MsgBox($"Username {username} tidak ada")
            Return
        End If

        Cmd.ExecuteNonQuery()
        txt_cari.Text = ""
        RefreshTableAfterModify()
        ResetForm()
        MsgBox($"Berhasil menghapus username {username}")
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        If txt_cari.Text = "" Then
            RefreshTableAfterModify()
        Else
            RefreshTableAfterSearch()
        End If

    End Sub

    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click

        'filter untuk file yang bisa di upload cuma JPEG, JPG, dll
        uploadDialog.Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
        uploadDialog.ShowDialog()

        ' jangan tampilkan foto jika user tidak memilih foto apa-apa
        If uploadDialog.FileName <> "" Then
            Dim filename = uploadDialog.FileName.Replace("\", "\\")

            Try
                pb_profil.ImageLocation = filename
            Catch ex As Exception
                pb_profil.ImageLocation = ""
            End Try
        End If
    End Sub

    Private Sub txt_cari_Enter(sender As Object, e As EventArgs) Handles txt_cari.Enter
        ResetForm()
    End Sub

    'isi form dengan data dari record yang di select
    Private Sub PopulateForm(RowIdx As Integer)
        usernameSebelum = txt_nama.Text
        txt_nama.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("nama").Value
        cb_golongan.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("golongan").Value
        cb_jabatan.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("jabatan").Value
        txt_departemen.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("departement").Value
        txt_gaji.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("gaji").Value
        txt_tunjangan.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("tunjangan").Value
        dt_tgl_lahir.Value = DataGridView1.Rows.Item(RowIdx).Cells.Item("tgl_lahir").Value
        cb_jk.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("jenis_kelamin").Value
        txt_alamat.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("alamat").Value
        txt_norek.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("no_rek").Value
        txt_npwp.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("no_npwp").Value
        txt_bpjs.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("no_bpjs").Value
        txt_lokasi.Text = DataGridView1.Rows.Item(RowIdx).Cells.Item("lokasi").Value

        Dim Cmd As New MySqlCommand($"SELECT url_foto FROM tbl_karyawan WHERE username = '{usernameSebelum}'", Conn)

        If Conn.State <> ConnectionState.Open Then
            MsgBox("aplikasi tidak terkoneksi database. karyawan tidak ditambahkan !")
            Return
        End If

        Dim url_foto As String = Cmd.ExecuteScalar()

        If url_foto <> "" Then
            Try
                pb_profil.ImageLocation = url_foto
            Catch ex As Exception
                pb_profil.ImageLocation = ""
            End Try
        End If
    End Sub

    'kosongkan form
    Private Sub ResetForm()
        txt_nama.Clear()
        cb_golongan.ResetText()
        cb_jabatan.ResetText()
        txt_departemen.Clear()
        txt_gaji.Clear()
        txt_tunjangan.Clear()
        dt_tgl_lahir.ResetText()
        cb_jk.ResetText()
        txt_alamat.Clear()
        txt_norek.Clear()
        txt_npwp.Clear()
        txt_bpjs.Clear()
        txt_lokasi.Clear()
        pb_profil.ImageLocation = ""
    End Sub

    'refresh tabel setalh melakukan modifikasi data (insert, update, delete)
    Private Sub RefreshTableAfterModify()

        table.Clear()
        adapterShowKaryawan.Fill(table)

    End Sub

    'refresh tabel setelah pencarian karyawan
    Private Sub RefreshTableAfterSearch()
        Dim username = txt_cari.Text

        table.Clear()

        Dim adapterSearchKaryawan As New MySqlDataAdapter($"SELECT * FROM tbl_karyawan WHERE username LIKE '%{username}%'", Conn)

        If Conn.State <> ConnectionState.Open Then
            MsgBox("aplikasi tidak terkoneksi database. karyawan tidak ditambahkan !")
            Return
        End If

        adapterSearchKaryawan.Fill(table)
        adapterSearchKaryawan.Dispose()
    End Sub

    Private Sub btn_reset_form_Click(sender As Object, e As EventArgs) Handles btn_reset_form.Click
        ResetForm()
    End Sub

    Private Sub test_btn_Click(sender As Object, e As EventArgs) Handles test_btn.Click
        MsgBox(DataGridView1.Rows.Count)
    End Sub
End Class