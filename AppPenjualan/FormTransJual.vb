Imports System.Data.SqlClient
Public Class FormTransJual
    Sub kondisiawal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLKembali.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        LBLHargaBarang.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        LBLItem.Text = ""
        TextBox1.Text = ""
        Call munculkodepelanggan()
        Call NoOtomatis()
        Call buatkolom()
        LBLTotal.Text = "0"
        TextBox2.MaxLength = 6
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox1.Enabled = False
        ComboBox1.Enabled = True
        LBLStok.Text = ""
        LBLStokIsi.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Private Sub FormTransJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub munculkodepelanggan()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand("select * from TBL_Pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("select * from TBL_Pelanggan where kodepelanggan ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaPlg.Text = Rd!namapelanggan
            LBLAlamat.Text = Rd!alamatpelanggan
            LBLTelepon.Text = Rd!telppelanggan
            TextBox2.Enabled = True
            TextBox3.Enabled = True

        End If
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_JUAL  where NoJual in (select max(NoJual) from TBL_JUAL)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoJual.Text = UrutanKode
    End Sub
    Sub buatkolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("subtotal", "Subtotal")
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * from TBL_BARANG where kodebarang='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Kodebarang")
                LBLNamaBarang.Text = Rd.Item("Namabarang")
                LBLHargaBarang.Text = Rd.Item("Hargabarang")
                'ComboBox1.Text = Rd.Item("Satuanbarang")
                LBLStok.Text = "Stok Brg."
                LBLStokIsi.Text = Rd.Item("jumlahbarang")
                TextBox3.Enabled = True
                TextBox3.Focus()
            Else
                MsgBox("Maaf, Kode Barang Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Then
            MsgBox("Maaf, Silahkan masukkan Kode Pelanggan terlebih dahulu")
        ElseIf LBLNamaBarang.Text = "" Then
            MsgBox("Dear User, Silahkan Masukan Kode Barang Lalu Tekan ENTER!")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Silahkan masukan jumlah terlebih dahulu")
        ElseIf TextBox3.Text <= 0 Then
            MsgBox("Maaf, Jumlah Barang Minimal 1")
        ElseIf TextBox3.Text > 10 Then
            MsgBox("Maaf, Jumlah Barang Maksimal 10")
        ElseIf TextBox3.Text > LBLStokIsi.Text Then
            MsgBox("Mohon Perhatikan Stok Barang Yang Tersedia")
        Else
            DataGridView1.Rows.Add(New String() {TextBox2.Text, LBLNamaBarang.Text, LBLHargaBarang.Text, TextBox3.Text, Val(LBLHargaBarang.Text) * Val(TextBox3.Text)})
            Call rumussubtotal()
            'Call kondisiawal()
            TextBox2.Text = ""
            LBLNamaBarang.Text = ""
            LBLHargaBarang.Text = ""
            TextBox3.Text = ""
            LBLStokIsi.Text = ""
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
            TextBox1.Enabled = True
            Call rumuscariitem()
        End If
    End Sub
    Sub rumussubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            LBLTotal.Text = hitung
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(LBLTotal.Text) Then
                MsgBox("Maaf, Pembayaran Kurang")
            ElseIf Val(TextBox1.Text) = Val(LBLTotal.Text) Then
                LBLKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(LBLTotal.Text) Then
                LBLKembali.Text = Val(TextBox1.Text) - Val(LBLTotal.Text)
                Button1.Focus()
            End If
        End If
    End Sub
    Sub rumuscariitem()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(3).Value
            LBLItem.Text = hitung
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LBLKembali.Text = "" Then
            MsgBox("Maaf, Transaksi Tidak Ada")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim simpanjual As String = "Insert into tbl_jual values('" & LBLNoJual.Text & "','" & tglsql & "','" & LBLJam.Text & "','" & LBLItem.Text & "','" & LBLTotal.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','" & ComboBox1.Text & "','" & FormMenuUtama.STLabel2.Text & "')"
            Cmd = New SqlCommand(simpanjual, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim simpandetail As String = "insert into tbl_detailjual values('" & LBLNoJual.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New SqlCommand(simpandetail, Conn)
                Cmd.ExecuteNonQuery()

                Call Koneksi()
                Cmd = New SqlCommand("Select * from TBL_BARANG where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                Call Koneksi()
                Dim kurangistok As String = "Update TBL_BARANG set jumlahbarang = '" & Rd.Item("jumlahbarang") - DataGridView1.Rows(Baris).Cells(3).Value & "' where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(kurangistok, Conn)
                Cmd.ExecuteNonQuery()
            Next

            If MessageBox.Show("Apakah ingin cetak nota...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AxCrystalReport1.SelectionFormula = "totext({tbl_Jual.NoJual})='" & LBLNoJual.Text & "'"
                AxCrystalReport1.ReportFileName = "NotaJual.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
                Call kondisiawal()
                Call kondisiawal()
                'MsgBox("Horee!!, Transaksi Berhasil Disimpan")
            Else
                Call kondisiawal()
                MsgBox("Horee!!, Transaksi Berhasil Disimpan")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call kondisiawal()
    End Sub

End Class