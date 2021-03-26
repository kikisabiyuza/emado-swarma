<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_gaji = New System.Windows.Forms.TextBox()
        Me.txt_tunjangan = New System.Windows.Forms.TextBox()
        Me.txt_lokasi = New System.Windows.Forms.TextBox()
        Me.txt_bpjs = New System.Windows.Forms.TextBox()
        Me.txt_npwp = New System.Windows.Forms.TextBox()
        Me.txt_norek = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_golongan = New System.Windows.Forms.ComboBox()
        Me.cb_jabatan = New System.Windows.Forms.ComboBox()
        Me.pb_profil = New System.Windows.Forms.PictureBox()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.golongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tunjangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_lahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_rek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_npwp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_bpjs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_row_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.txt_departemen = New System.Windows.Forms.TextBox()
        Me.cb_jk = New System.Windows.Forms.ComboBox()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.dt_tgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.uploadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_cari = New System.Windows.Forms.Label()
        Me.btn_reset_form = New System.Windows.Forms.Button()
        Me.test_btn = New System.Windows.Forms.Button()
        CType(Me.pb_profil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(24, 248)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 14
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(105, 248)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 15
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(99, 25)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(121, 20)
        Me.txt_nama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'txt_gaji
        '
        Me.txt_gaji.Location = New System.Drawing.Point(99, 130)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.Size = New System.Drawing.Size(121, 20)
        Me.txt_gaji.TabIndex = 5
        '
        'txt_tunjangan
        '
        Me.txt_tunjangan.Location = New System.Drawing.Point(99, 157)
        Me.txt_tunjangan.Name = "txt_tunjangan"
        Me.txt_tunjangan.Size = New System.Drawing.Size(121, 20)
        Me.txt_tunjangan.TabIndex = 6
        '
        'txt_lokasi
        '
        Me.txt_lokasi.Location = New System.Drawing.Point(405, 179)
        Me.txt_lokasi.Name = "txt_lokasi"
        Me.txt_lokasi.Size = New System.Drawing.Size(121, 20)
        Me.txt_lokasi.TabIndex = 13
        '
        'txt_bpjs
        '
        Me.txt_bpjs.Location = New System.Drawing.Point(405, 150)
        Me.txt_bpjs.Name = "txt_bpjs"
        Me.txt_bpjs.Size = New System.Drawing.Size(121, 20)
        Me.txt_bpjs.TabIndex = 12
        '
        'txt_npwp
        '
        Me.txt_npwp.Location = New System.Drawing.Point(405, 114)
        Me.txt_npwp.Name = "txt_npwp"
        Me.txt_npwp.Size = New System.Drawing.Size(121, 20)
        Me.txt_npwp.TabIndex = 11
        '
        'txt_norek
        '
        Me.txt_norek.Location = New System.Drawing.Point(405, 81)
        Me.txt_norek.Name = "txt_norek"
        Me.txt_norek.Size = New System.Drawing.Size(121, 20)
        Me.txt_norek.TabIndex = 10
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(405, 51)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(121, 20)
        Me.txt_alamat.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Golongan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Departemen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Gaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tunjangan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "No.Rekening"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "No.NPWP"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "No.BPJS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(317, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Lokasi"
        '
        'cb_golongan
        '
        Me.cb_golongan.FormattingEnabled = True
        Me.cb_golongan.Location = New System.Drawing.Point(99, 50)
        Me.cb_golongan.Name = "cb_golongan"
        Me.cb_golongan.Size = New System.Drawing.Size(121, 21)
        Me.cb_golongan.TabIndex = 2
        '
        'cb_jabatan
        '
        Me.cb_jabatan.FormattingEnabled = True
        Me.cb_jabatan.Location = New System.Drawing.Point(99, 79)
        Me.cb_jabatan.Name = "cb_jabatan"
        Me.cb_jabatan.Size = New System.Drawing.Size(121, 21)
        Me.cb_jabatan.TabIndex = 3
        '
        'pb_profil
        '
        Me.pb_profil.Location = New System.Drawing.Point(562, 20)
        Me.pb_profil.Name = "pb_profil"
        Me.pb_profil.Size = New System.Drawing.Size(184, 184)
        Me.pb_profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_profil.TabIndex = 34
        Me.pb_profil.TabStop = False
        '
        'btn_photo
        '
        Me.btn_photo.Location = New System.Drawing.Point(582, 210)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(136, 23)
        Me.btn_photo.TabIndex = 35
        Me.btn_photo.Text = "Tambah/Update Foto"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama, Me.golongan, Me.jabatan, Me.departement, Me.gaji, Me.tunjangan, Me.tgl_lahir, Me.jenis_kelamin, Me.alamat, Me.no_rek, Me.no_npwp, Me.no_bpjs, Me.lokasi, Me.btn_row_delete})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 460)
        Me.DataGridView1.TabIndex = 36
        '
        'nama
        '
        Me.nama.DataPropertyName = "username"
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'golongan
        '
        Me.golongan.DataPropertyName = "golongan"
        Me.golongan.HeaderText = "Golongan"
        Me.golongan.Name = "golongan"
        Me.golongan.ReadOnly = True
        '
        'jabatan
        '
        Me.jabatan.DataPropertyName = "jabatan"
        Me.jabatan.HeaderText = "Jabatan"
        Me.jabatan.Name = "jabatan"
        Me.jabatan.ReadOnly = True
        '
        'departement
        '
        Me.departement.DataPropertyName = "department"
        Me.departement.HeaderText = "Departemen"
        Me.departement.Name = "departement"
        Me.departement.ReadOnly = True
        '
        'gaji
        '
        Me.gaji.DataPropertyName = "gaji"
        Me.gaji.HeaderText = "Gaji"
        Me.gaji.Name = "gaji"
        Me.gaji.ReadOnly = True
        '
        'tunjangan
        '
        Me.tunjangan.DataPropertyName = "tunjangan"
        Me.tunjangan.HeaderText = "Tunjangan"
        Me.tunjangan.Name = "tunjangan"
        Me.tunjangan.ReadOnly = True
        '
        'tgl_lahir
        '
        Me.tgl_lahir.DataPropertyName = "tgl_lahir"
        Me.tgl_lahir.HeaderText = "Tanggal Lahir"
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.ReadOnly = True
        '
        'jenis_kelamin
        '
        Me.jenis_kelamin.DataPropertyName = "jenis_kelamin"
        Me.jenis_kelamin.HeaderText = "Jenis Kelamin"
        Me.jenis_kelamin.Name = "jenis_kelamin"
        Me.jenis_kelamin.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'no_rek
        '
        Me.no_rek.DataPropertyName = "no_rek"
        Me.no_rek.HeaderText = "No Rekening"
        Me.no_rek.Name = "no_rek"
        Me.no_rek.ReadOnly = True
        '
        'no_npwp
        '
        Me.no_npwp.DataPropertyName = "no_npwp"
        Me.no_npwp.HeaderText = "NPWP"
        Me.no_npwp.Name = "no_npwp"
        Me.no_npwp.ReadOnly = True
        '
        'no_bpjs
        '
        Me.no_bpjs.DataPropertyName = "no_bpjs"
        Me.no_bpjs.HeaderText = "No. BPJS"
        Me.no_bpjs.Name = "no_bpjs"
        Me.no_bpjs.ReadOnly = True
        '
        'lokasi
        '
        Me.lokasi.DataPropertyName = "lokasi"
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.Name = "lokasi"
        Me.lokasi.ReadOnly = True
        '
        'btn_row_delete
        '
        Me.btn_row_delete.HeaderText = "Delete"
        Me.btn_row_delete.Name = "btn_row_delete"
        Me.btn_row_delete.ReadOnly = True
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(405, 248)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(161, 20)
        Me.txt_cari.TabIndex = 37
        '
        'txt_departemen
        '
        Me.txt_departemen.Location = New System.Drawing.Point(99, 106)
        Me.txt_departemen.Name = "txt_departemen"
        Me.txt_departemen.Size = New System.Drawing.Size(121, 20)
        Me.txt_departemen.TabIndex = 4
        '
        'cb_jk
        '
        Me.cb_jk.AutoCompleteCustomSource.AddRange(New String() {"Pria", "Wanita"})
        Me.cb_jk.FormattingEnabled = True
        Me.cb_jk.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cb_jk.Location = New System.Drawing.Point(405, 20)
        Me.cb_jk.Name = "cb_jk"
        Me.cb_jk.Size = New System.Drawing.Size(121, 21)
        Me.cb_jk.TabIndex = 8
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(186, 248)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 16
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'dt_tgl_lahir
        '
        Me.dt_tgl_lahir.Location = New System.Drawing.Point(99, 183)
        Me.dt_tgl_lahir.Name = "dt_tgl_lahir"
        Me.dt_tgl_lahir.Size = New System.Drawing.Size(200, 20)
        Me.dt_tgl_lahir.TabIndex = 7
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(1283, 245)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 52
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'uploadDialog
        '
        Me.uploadDialog.FileName = "OpenFileDialog1"
        '
        'lbl_cari
        '
        Me.lbl_cari.AutoSize = True
        Me.lbl_cari.Location = New System.Drawing.Point(405, 229)
        Me.lbl_cari.Name = "lbl_cari"
        Me.lbl_cari.Size = New System.Drawing.Size(122, 13)
        Me.lbl_cari.TabIndex = 53
        Me.lbl_cari.Text = "Cari berdasarkan nama :"
        '
        'btn_reset_form
        '
        Me.btn_reset_form.Location = New System.Drawing.Point(267, 248)
        Me.btn_reset_form.Name = "btn_reset_form"
        Me.btn_reset_form.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset_form.TabIndex = 54
        Me.btn_reset_form.Text = "Reset Form"
        Me.btn_reset_form.UseVisualStyleBackColor = True
        '
        'test_btn
        '
        Me.test_btn.Location = New System.Drawing.Point(640, 248)
        Me.test_btn.Name = "test_btn"
        Me.test_btn.Size = New System.Drawing.Size(75, 23)
        Me.test_btn.TabIndex = 55
        Me.test_btn.Text = "Test"
        Me.test_btn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.test_btn)
        Me.Controls.Add(Me.btn_reset_form)
        Me.Controls.Add(Me.lbl_cari)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.dt_tgl_lahir)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.cb_jk)
        Me.Controls.Add(Me.txt_departemen)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_photo)
        Me.Controls.Add(Me.pb_profil)
        Me.Controls.Add(Me.cb_jabatan)
        Me.Controls.Add(Me.cb_golongan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_norek)
        Me.Controls.Add(Me.txt_npwp)
        Me.Controls.Add(Me.txt_bpjs)
        Me.Controls.Add(Me.txt_lokasi)
        Me.Controls.Add(Me.txt_tunjangan)
        Me.Controls.Add(Me.txt_gaji)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_tambah)
        Me.Name = "Form2"
        Me.Text = "EMADOS HRIS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pb_profil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_gaji As TextBox
    Friend WithEvents txt_tunjangan As TextBox
    Friend WithEvents txt_lokasi As TextBox
    Friend WithEvents txt_bpjs As TextBox
    Friend WithEvents txt_npwp As TextBox
    Friend WithEvents txt_norek As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cb_golongan As ComboBox
    Friend WithEvents cb_jabatan As ComboBox
    Friend WithEvents pb_profil As PictureBox
    Friend WithEvents btn_photo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents txt_departemen As TextBox
    Friend WithEvents cb_jk As ComboBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents dt_tgl_lahir As DateTimePicker
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents golongan As DataGridViewTextBoxColumn
    Friend WithEvents jabatan As DataGridViewTextBoxColumn
    Friend WithEvents departement As DataGridViewTextBoxColumn
    Friend WithEvents gaji As DataGridViewTextBoxColumn
    Friend WithEvents tunjangan As DataGridViewTextBoxColumn
    Friend WithEvents tgl_lahir As DataGridViewTextBoxColumn
    Friend WithEvents jenis_kelamin As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents no_rek As DataGridViewTextBoxColumn
    Friend WithEvents no_npwp As DataGridViewTextBoxColumn
    Friend WithEvents no_bpjs As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents btn_row_delete As DataGridViewButtonColumn
    Friend WithEvents btn_refresh As Button
    Friend WithEvents uploadDialog As OpenFileDialog
    Friend WithEvents lbl_cari As Label
    Friend WithEvents btn_reset_form As Button
    Friend WithEvents test_btn As Button
End Class
