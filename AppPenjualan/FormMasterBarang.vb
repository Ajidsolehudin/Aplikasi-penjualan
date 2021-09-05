Imports System.Data.SqlClient
Public Class FormMasterBarang
    Sub Kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New SqlDataAdapter("select kodebarang, namabarang, hargabarang, jumlahbarang, satuanbarang from TBL_BARANG", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_BARANG")
        DataGridView1.DataSource = (Ds.Tables("TBL_BARANG"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("PCS")
        ComboBox1.Items.Add("KG")
        ComboBox1.Items.Add("BUAH")
        ComboBox1.Items.Add("UNIT")

    End Sub

    Private Sub FormMasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 10
        TextBox4.MaxLength = 50
    End Sub
    Sub Siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
        Call munculsatuan()
    End Sub
    Sub munculsatuan()
        Call Koneksi()
        Cmd = New SqlCommand("Select distinct satuanbarang from TBL_BARANG", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item("satuanbarang"))
        Loop
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call Siapisi()
            Call NoOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim simpandata As String = "insert into TBL_BARANG values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
                Cmd = New SqlCommand(simpandata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Horee!! Data berhasil disimpan")
                Call Kondisiawal()
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call Siapisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim EditData As String = "update TBL_BARANG set namabarang ='" & TextBox2.Text & "',hargabarang ='" & TextBox3.Text & "',jumlahbarang ='" & TextBox4.Text & "',satuanbarang ='" & ComboBox1.Text & "' where kodebarang ='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Edit")
                Call Kondisiawal()
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "DELETE"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan Semua Field Diisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete TBL_BARANG where kodebarang ='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Hapus")
                Call Kondisiawal()
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * from TBL_BARANG where kodebarang='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Namabarang")
                TextBox3.Text = Rd.Item("Hargabarang")
                TextBox4.Text = Rd.Item("Jumlahbarang")
                ComboBox1.Text = Rd.Item("Satuanbarang")
            Else
                MsgBox("Maaf, Data Tidak Ada")
            End If
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_BARANG  where Kodebarang in (select max(Kodebarang) from TBL_BARANG)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "BRG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class

