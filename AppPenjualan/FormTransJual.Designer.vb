<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransJual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLNoJual = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.LBLTotal1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLItem = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.LBLStokIsi = New System.Windows.Forms.Label()
        Me.LBLStok = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Jual"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'LBLNoJual
        '
        Me.LBLNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoJual.Location = New System.Drawing.Point(171, 31)
        Me.LBLNoJual.Name = "LBLNoJual"
        Me.LBLNoJual.Size = New System.Drawing.Size(183, 28)
        Me.LBLNoJual.TabIndex = 5
        Me.LBLNoJual.Text = "LBLNoJual"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaPlg.Location = New System.Drawing.Point(171, 86)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(406, 28)
        Me.LBLNamaPlg.TabIndex = 7
        Me.LBLNamaPlg.Text = "LBLNamaPlg"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAlamat.Location = New System.Drawing.Point(171, 114)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(406, 28)
        Me.LBLAlamat.TabIndex = 8
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTelepon.Location = New System.Drawing.Point(171, 143)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(183, 28)
        Me.LBLTelepon.TabIndex = 9
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(601, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 28)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tanggal"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(601, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 28)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Jam"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(601, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 28)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Admin"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggal.Location = New System.Drawing.Point(700, 86)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(146, 28)
        Me.LBLTanggal.TabIndex = 13
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJam.Location = New System.Drawing.Point(700, 114)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(146, 28)
        Me.LBLJam.TabIndex = 14
        Me.LBLJam.Text = "LBLJam"
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAdmin.Location = New System.Drawing.Point(700, 142)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(146, 28)
        Me.LBLAdmin.TabIndex = 15
        Me.LBLAdmin.Text = "LBLAdmin"
        '
        'LBLTotal
        '
        Me.LBLTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LBLTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(560, 31)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(286, 39)
        Me.LBLTotal.TabIndex = 16
        Me.LBLTotal.Text = "LBLTotal"
        '
        'LBLTotal1
        '
        Me.LBLTotal1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LBLTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal1.Location = New System.Drawing.Point(422, 31)
        Me.LBLTotal1.Name = "LBLTotal1"
        Me.LBLTotal1.Size = New System.Drawing.Size(138, 39)
        Me.LBLTotal1.TabIndex = 17
        Me.LBLTotal1.Text = "TOTAL :  Rp."
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(820, 173)
        Me.DataGridView1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(580, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Kembali   Rp."
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(580, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Di Bayar  Rp."
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(700, 423)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.TextBox1.TabIndex = 5
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKembali.Location = New System.Drawing.Point(700, 450)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(146, 28)
        Me.LBLKembali.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 436)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 39)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "TUTUP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 28)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Kode Brg."
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(117, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 26)
        Me.TextBox2.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(234, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 28)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nama"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaBarang.Location = New System.Drawing.Point(290, 183)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(183, 28)
        Me.LBLNamaBarang.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(479, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 28)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Harga"
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHargaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHargaBarang.Location = New System.Drawing.Point(536, 183)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(104, 28)
        Me.LBLHargaBarang.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(646, 183)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 28)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Jml"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(684, 183)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 26)
        Me.TextBox3.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(742, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "INSERT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(444, 423)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 28)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Item"
        '
        'LBLItem
        '
        Me.LBLItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLItem.Location = New System.Drawing.Point(488, 423)
        Me.LBLItem.Name = "LBLItem"
        Me.LBLItem.Size = New System.Drawing.Size(72, 28)
        Me.LBLItem.TabIndex = 36
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(360, 145)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 37
        '
        'LBLStokIsi
        '
        Me.LBLStokIsi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLStokIsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStokIsi.Location = New System.Drawing.Point(117, 211)
        Me.LBLStokIsi.Name = "LBLStokIsi"
        Me.LBLStokIsi.Size = New System.Drawing.Size(51, 28)
        Me.LBLStokIsi.TabIndex = 38
        '
        'LBLStok
        '
        Me.LBLStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStok.Location = New System.Drawing.Point(36, 211)
        Me.LBLStok.Name = "LBLStok"
        Me.LBLStok.Size = New System.Drawing.Size(75, 28)
        Me.LBLStok.TabIndex = 39
        '
        'FormTransJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(876, 566)
        Me.Controls.Add(Me.LBLStok)
        Me.Controls.Add(Me.LBLStokIsi)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.LBLItem)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBLTotal1)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLNamaPlg)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LBLNoJual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLNoJual As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLNamaPlg As System.Windows.Forms.Label
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents LBLTotal As System.Windows.Forms.Label
    Friend WithEvents LBLTotal1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLKembali As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaBarang As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LBLItem As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents LBLStokIsi As Label
    Friend WithEvents LBLStok As Label
End Class
