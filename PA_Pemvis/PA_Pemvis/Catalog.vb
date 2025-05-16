Imports MySql.Data.MySqlClient

Public Class Catalog

    Public Property id_pelanggan As String

    'load katalog ketika form dibuka'
    Private Sub FormCatalogPembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilkan_catalog()
    End Sub

    Private Sub tampilkan_catalog()
        FlowLayoutPanel1.Controls.Clear()

        koneksi()

        Dim query As String = "SELECT * FROM mainan"
        Dim cmd As New MySqlCommand(query, CONN)

        Using dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim panel As New Panel()
                panel.Width = 150
                panel.Height = 230
                panel.Margin = New Padding(10)
                panel.BackColor = Color.Transparent

                Dim pic As New PictureBox()
                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Width = 130
                pic.Height = 100
                pic.Top = 0
                pic.Left = 10
                Try
                    pic.Image = Image.FromFile(Application.StartupPath & "\Images\" & dr("foto").ToString())
                Catch
                    pic.Image = Nothing
                End Try

                Dim lblNama As New Label()
                lblNama.Text = dr("nama_mainan").ToString()
                lblNama.Top = 110
                lblNama.Left = 10
                lblNama.Width = 130
                lblNama.ForeColor = Color.White
                lblNama.Font = New Font("Segoe UI", 9, FontStyle.Bold)

                Dim lblJenis As New Label()
                lblJenis.Text = dr("kategori").ToString()
                lblJenis.Top = 130
                lblJenis.Left = 10
                lblJenis.Width = 130
                lblJenis.ForeColor = Color.White
                lblJenis.Font = New Font("Segoe UI", 8)

                Dim lblHarga As New Label()
                lblHarga.Text = "Rp " & dr("harga").ToString()
                lblHarga.Top = 150
                lblHarga.Left = 10
                lblHarga.Width = 130
                lblHarga.ForeColor = Color.White
                lblHarga.Font = New Font("Segoe UI", 8)

                Dim lblStok As New Label()
                lblStok.Text = "Stok: " & dr("stok").ToString()
                lblStok.Top = 170
                lblStok.Left = 10
                lblStok.Width = 130
                lblStok.ForeColor = Color.White
                lblStok.Font = New Font("Segoe UI", 8)

                Dim btnBuy As New Button()
                btnBuy.Text = "BUY"
                btnBuy.Top = 195
                btnBuy.Left = 10
                btnBuy.Width = 50
                btnBuy.Height = 25
                btnBuy.Tag = dr("id_mainan").ToString()
                btnBuy.BackColor = Color.LimeGreen
                btnBuy.ForeColor = Color.Black
                AddHandler btnBuy.Click, AddressOf beli_produk

                panel.Controls.Add(pic)
                panel.Controls.Add(lblNama)
                panel.Controls.Add(lblJenis)
                panel.Controls.Add(lblHarga)
                panel.Controls.Add(lblStok)
                panel.Controls.Add(btnBuy)

                FlowLayoutPanel1.Controls.Add(panel)
            End While
        End Using
    End Sub

    'fungsi beli produk mainan'
    Private Sub beli_produk(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim id_mainan As String = btn.Tag.ToString()

        Dim inputJumlah As String = InputBox("Masukkan jumlah yang ingin dibeli:", "Input Jumlah").Trim()

        Dim kuantitas As Integer
        If String.IsNullOrEmpty(inputJumlah) OrElse Not Integer.TryParse(inputJumlah, kuantitas) OrElse kuantitas <= 0 Then
            MessageBox.Show("Masukkan hanya angka bulat positif yang valid.")
            Return
        End If

        koneksi()

        ' AMBIL harga dan stok
        Dim harga As Integer = 0
        Dim stok As Integer = 0
        Dim nama_mainan As String = ""

        Using cmd As New MySqlCommand("SELECT harga, stok, nama_mainan FROM mainan WHERE id_mainan = @id", CONN)
            cmd.Parameters.AddWithValue("@id", id_mainan)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    harga = Convert.ToInt32(reader("harga"))
                    stok = Convert.ToInt32(reader("stok"))
                    nama_mainan = reader("nama_mainan").ToString()
                Else
                    MessageBox.Show("Data mainan tidak ditemukan.")
                    Return
                End If
            End Using
        End Using

        ' CEK stok
        If kuantitas > stok Then
            MessageBox.Show("Jumlah melebihi stok yang tersedia. Stok tersedia: " & stok)
            Return
        End If

        Dim total_harga As Integer = harga * kuantitas
        Dim tanggal As DateTime = DateTime.Now

        ' SIMPAN ke transaksi
        Using cmdInsert As New MySqlCommand("INSERT INTO transaksi (tanggal, id_pelanggan, nama_mainan, kuantitas, total_harga) VALUES (@tanggal, @pelanggan, @nama_mainan, @jumlah, @total)", CONN)
            cmdInsert.Parameters.AddWithValue("@tanggal", tanggal)
            cmdInsert.Parameters.AddWithValue("@pelanggan", id_pelanggan)
            cmdInsert.Parameters.AddWithValue("@nama_mainan", nama_mainan)
            cmdInsert.Parameters.AddWithValue("@jumlah", kuantitas)
            cmdInsert.Parameters.AddWithValue("@total", total_harga)
            cmdInsert.ExecuteNonQuery()
        End Using

        ' UPDATE stok
        Using cmdUpdateStok As New MySqlCommand("UPDATE mainan SET stok = stok - @jumlah WHERE id_mainan = @id", CONN)
            cmdUpdateStok.Parameters.AddWithValue("@jumlah", kuantitas)
            cmdUpdateStok.Parameters.AddWithValue("@id", id_mainan)
            cmdUpdateStok.ExecuteNonQuery()
        End Using

        ' AMBIL ID terakhir
        Dim id_transaksi As Integer
        Using cmdLastID As New MySqlCommand("SELECT LAST_INSERT_ID()", CONN)
            id_transaksi = Convert.ToInt32(cmdLastID.ExecuteScalar())
        End Using

        MessageBox.Show("Transaksi berhasil disimpan!", "Sukses")

        Dim struk As New Struk()
        struk.id_transaksi = id_transaksi
        struk.id_pelanggan = Me.id_pelanggan ' <-- ini penting
        struk.Show()
        Me.Hide()
    End Sub

    'keluar dari akun'
    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub
End Class

