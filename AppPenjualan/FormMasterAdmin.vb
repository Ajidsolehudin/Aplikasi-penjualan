Imports System.Data.SqlClient
Public Class FormMasterAdmin
    Sub Kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
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
        Da = New SqlDataAdapter("select kodeadmin, namaadmin, leveladmin from TBL_ADMIN", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_ADMIN")
        DataGridView1.DataSource = (Ds.Tables("TBL_ADMIN"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        TextBox3.PasswordChar = "X"
    End Sub

    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 10
    End Sub
    Sub Siapisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim simpandata As String = "insert into TBL_ADMIN values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim EditData As String = "update tbl_admin set namaadmin ='" & TextBox2.Text & "',passwordadmin ='" & TextBox3.Text & "',leveladmin ='" & ComboBox1.Text & "' where kodeadmin ='" & TextBox1.Text & "'"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Dear User, Pastikan Semua Field Diisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete tbl_admin where kodeadmin ='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Hapus")
                Call KondisiAwal()
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
            Cmd = New SqlCommand("Select * from tbl_admin where kodeadmin='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Namaadmin")
                TextBox3.Text = Rd.Item("Passwordadmin")
                ComboBox1.Text = Rd.Item("Leveladmin")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_ADMIN  where Kodeadmin in (select max(Kodeadmin) from TBL_ADMIN)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "ADM" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "ADM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class