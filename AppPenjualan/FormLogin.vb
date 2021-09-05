Imports System.Data.SqlClient
Public Class FormLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem.Enabled = True
    End Sub
    Sub kondisiawal()
        TextBox1.Text = "ADM001"
        TextBox2.Text = "ADMIN"
        TextBox2.PasswordChar = "X"
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Dear User, Kode admin dan Password tidak boleh kosong seperti hati mu :)")
        Else
            Call Koneksi()
            Cmd = New SqlCommand("Select * from tbl_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!kodeadmin
                FormMenuUtama.STLabel4.Text = Rd!namaadmin
                FormMenuUtama.STLabel6.Text = Rd!leveladmin
                If FormMenuUtama.STLabel6.Text = "USER" Then
                    FormMenuUtama.AdminToolStripMenuItem.Enabled = False
                End If
            Else
                MsgBox("Maaf, Kode admin atau Password salah !")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 8
    End Sub
End Class