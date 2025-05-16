Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddProduct

    'ketika form di load langsung fokus ke textbox product'
    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProduct.Focus()
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

        If stock <= 0 Then
            MessageBox.Show("Stok harus lebih dari 0.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    'Menampilkan pesan'
    Private Sub ShowMessage(message As String, title As String, icon As MessageBoxIcon)
        MessageBox.Show(message, title, MessageBoxButtons.OK, icon)
    End Sub

    'fungsi menyimpan produk'
    Private Sub SaveProduct(product As String, price As Decimal, stock As Integer, category As String, photo As String)
        Try
            koneksi()

            Dim query As String = "INSERT INTO mainan (nama_mainan, harga, stok, kategori, foto) VALUES (@nama_mainan, @harga, @stok, @kategori, @foto)"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@nama_mainan", product)
            CMD.Parameters.AddWithValue("@harga", price)
            CMD.Parameters.AddWithValue("@stok", stock)
            CMD.Parameters.AddWithValue("@kategori", category)
            CMD.Parameters.AddWithValue("@foto", photo)
            CMD.ExecuteNonQuery()

            ShowMessage("Produk berhasil ditambahkan!", "Sukses", MessageBoxIcon.Information)

        Catch ex As Exception
            ShowMessage("Gagal menyimpan data: " & ex.Message, "Kesalahan", MessageBoxIcon.Error)
        End Try
    End Sub

    'event untuk menambahkan data ke database'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If Not ValidateInputs() Then
            Return
        End If

        Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
        Dim stock As Integer = Convert.ToInt32(txtStock.Text)
        Dim photoFileName As String = Path.GetFileName(picImage.ImageLocation)
        Dim destPath As String = Application.StartupPath & "\Images\" & photoFileName

        If Not Directory.Exists(Application.StartupPath & "\Images") Then
            Directory.CreateDirectory(Application.StartupPath & "\Images")
        End If

        File.Copy(picImage.ImageLocation, destPath, True)

        SaveProduct(txtProduct.Text, price, stock, cbCategory.Text, photoFileName)

        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
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

    Private Sub lblLogOut_Click_1(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lblHistory_Click(sender As Object, e As EventArgs) Handles lblHistory.Click
        Dim historyForm As New History()
        historyForm.Show()
        Me.Hide()
    End Sub
End Class
