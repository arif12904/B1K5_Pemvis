Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EditProduct
    Public Property id_mainan As Integer
    Private stokLama As Integer

    'ketika form di load langsung fokus ke textbox product dan menampilkan data mainan yang di edit'
    Private Sub EditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProduct.Focus()
        loadData()
    End Sub

    'menampilkan data dari database'
    Private Sub loadData()
        Try
            koneksi()

            CMD = New MySqlCommand("SELECT * FROM mainan WHERE id_mainan = @id_mainan", CONN)
            CMD.Parameters.AddWithValue("@id_mainan", id_mainan)
            RD = CMD.ExecuteReader()

            If RD.Read() Then
                txtProduct.Text = RD("nama_mainan").ToString()
                txtPrice.Text = RD("harga").ToString()
                txtStock.Text = "0"
                cbCategory.Text = RD("kategori").ToString()
                stokLama = Convert.ToInt32(RD("stok"))
                Dim photoPath As String = RD("foto").ToString()
                picImage.ImageLocation = Application.StartupPath & "\Images\" & photoPath
            Else
                MessageBox.Show("Data tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Error saat mengambil data: " & ex.Message)
        End Try
    End Sub

    'fungsi validasi inputan'
    Private Function ValidateInputs() As Boolean
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtStock.Text = "" Or cbCategory.Text = "" Or picImage.ImageLocation = "" Then
            MessageBox.Show("Lengkapi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim price As Decimal
        Dim stock As Integer

        If Not Decimal.TryParse(txtPrice.Text, price) OrElse Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Harga dan stok harus berupa angka yang valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If price <= 0 Then
            MessageBox.Show("Harga harus lebih dari 0.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If stock < 0 Then
            MessageBox.Show("Tambahan stok tidak boleh negatif.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    'Menampilkan pesan'
    Private Sub ShowMessage(message As String, title As String, icon As MessageBoxIcon)
        MessageBox.Show(message, title, MessageBoxButtons.OK, icon)
    End Sub

    'Fungsi update data produk ke database'
    Private Sub UpdateProduct(product As String, price As Decimal, stock As Integer, category As String, photo As String)
        Try
            koneksi()

            Dim query As String = "UPDATE mainan SET nama_mainan = @nama_mainan, harga = @harga, stok = @stok, kategori = @kategori, foto = @foto WHERE id_mainan = @id_mainan"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@nama_mainan", product)
            CMD.Parameters.AddWithValue("@harga", price)
            CMD.Parameters.AddWithValue("@stok", stock)
            CMD.Parameters.AddWithValue("@kategori", category)
            CMD.Parameters.AddWithValue("@foto", photo)
            CMD.Parameters.AddWithValue("@id_mainan", id_mainan)

            Dim result As Integer = CMD.ExecuteNonQuery()

            If result > 0 Then
                ShowMessage("Produk berhasil diperbarui!", "Sukses", MessageBoxIcon.Information)
                Dim dashboard As New Dashboard()
                dashboard.Show()
                Me.Close()
            Else
                ShowMessage("Produk gagal diperbarui!", "Gagal", MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ShowMessage("Terjadi kesalahan saat update: " & ex.Message, "Kesalahan", MessageBoxIcon.Error)
        End Try
    End Sub

    'event button untuk edit data'
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        If Not ValidateInputs() Then Return

        Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
        Dim tambahanStok As Integer = Convert.ToInt32(txtStock.Text)
        Dim totalStok As Integer = stokLama + tambahanStok
        Dim photoFileName As String = Path.GetFileName(picImage.ImageLocation)
        Dim destPath As String = Application.StartupPath & "\Images\" & photoFileName

        If Not Directory.Exists(Application.StartupPath & "\Images") Then
            Directory.CreateDirectory(Application.StartupPath & "\Images")
        End If

        If Not File.Exists(destPath) Then
            File.Copy(picImage.ImageLocation, destPath, True)
        End If

        UpdateProduct(txtProduct.Text, price, totalStok, cbCategory.Text, photoFileName)
    End Sub

    'fungsi untuk input image ke picture box'
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Title = "Pilih Gambar"
        openFileDialog.Filter = "File Gambar (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picImage.ImageLocation = openFileDialog.FileName
        End If
    End Sub

    'event untuk pindah halaman dashboard'
    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    'event untuk pindah halaman tambah data'
    Private Sub lblAddProduct_Click(sender As Object, e As EventArgs) Handles lblAddProduct.Click
        Dim add_product As New AddProduct()
        add_product.Show()
        Me.Hide()
    End Sub

    'logout menggunakan label'
    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    'pindah halaman ke histori'
    Private Sub lblHistory_Click(sender As Object, e As EventArgs) Handles lblHistory.Click
        Dim historyForm As New History()
        historyForm.Show()
        Me.Hide()
    End Sub
End Class
