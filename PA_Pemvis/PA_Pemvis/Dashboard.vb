Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvProducts)
    End Sub


    'Fungsi Load data dari database'
    Private Sub LoadData(dgv As DataGridView)
        Try

            koneksi()
            dgv.Rows.Clear()
            CMD = New MySqlCommand("SELECT id_mainan, nama_mainan, harga, stok, kategori FROM mainan", CONN)
            RD = CMD.ExecuteReader()

            While RD.Read()
                dgv.Rows.Add(
                    RD("id_mainan").ToString(),
                    RD("nama_mainan").ToString(),
                    "Rp " & RD("harga").ToString(),
                    RD("stok").ToString(),
                    RD("kategori").ToString()
                    )
            End While

            RD.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Fungsi Delete data dari database
    Private Sub DeleteData(id_mainan As Integer)
        Try
            koneksi()
            CMD = New MySqlCommand("DELETE FROM mainan WHERE id_mainan = @id_mainan", CONN)
            CMD.Parameters.AddWithValue("@id_mainan", id_mainan)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message)
        End Try
    End Sub

    ' Handle delete data dari UI'
    Private Sub HandleDelete(rowIndex As Integer)
        Dim id_mainan As Integer = CInt(dgvProducts.Rows(rowIndex).Cells("colidMainan").Value)
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            DeleteData(id_mainan)
            LoadData(dgvProducts)
        End If
    End Sub

    ' Handle edit data dari UI;
    Private Sub HandleEdit(rowIndex As Integer)
        Dim id_mainan As Integer = CInt(dgvProducts.Rows(rowIndex).Cells("colidMainan").Value)
        Dim editForm As New EditProduct() ' 
        editForm.id_mainan = id_mainan
        editForm.Show()
        Me.Hide()
    End Sub

    ' Event klik pada dgv edit/delete'
    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        If e.RowIndex >= 0 Then
            If dgvProducts.Columns(e.ColumnIndex).Name = "colEdit" Then
                HandleEdit(e.RowIndex)
            ElseIf dgvProducts.Columns(e.ColumnIndex).Name = "colDelete" Then
                HandleDelete(e.RowIndex)
            End If
        End If
    End Sub

    'fungsi pencarian produk'
    Private Sub SearchProducts(keyword As String)
        Try
            koneksi()
            dgvProducts.Rows.Clear()

            If String.IsNullOrWhiteSpace(keyword) Then
                LoadData(dgvProducts)
                Return
            End If

            Dim searchText As String = "%" & keyword & "%"
            CMD = New MySqlCommand("SELECT id_mainan, nama_mainan, harga, stok, kategori FROM mainan WHERE nama_mainan LIKE @search", CONN)
            CMD.Parameters.AddWithValue("@search", searchText)
            RD = CMD.ExecuteReader()

            While RD.Read()
                dgvProducts.Rows.Add(
                RD("id_mainan").ToString(),
                RD("nama_mainan").ToString(),
                "Rp " & RD("harga").ToString(),
                RD("stok").ToString(),
                RD("kategori").ToString()
            )
            End While

            RD.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat pencarian: " & ex.Message)
        End Try
    End Sub

    'event ketika text search berubah'
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProducts(txtSearch.Text)
    End Sub

    'event untuk pindah halaman tambah data'
    Private Sub lblAddProduct_Click(sender As Object, e As EventArgs) Handles lblAddProduct.Click
        Dim add_product As New AddProduct()
        add_product.Show()
        Me.Hide()
    End Sub

    Private Sub lblHistory_Click(sender As Object, e As EventArgs) Handles lblHistory.Click
        Dim historyForm As New History()
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogOut_Click_(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

End Class