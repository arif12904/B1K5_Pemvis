Imports MySql.Data.MySqlClient

Public Class History

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_transaksi()
    End Sub

    Private Sub tampilkan_transaksi()
        koneksi()

        Dim query As String = "
            SELECT 
                t.id_transaksi, 
                t.tanggal, 
                p.nama AS nama_pelanggan, 
                t.nama_mainan, 
                t.kuantitas, 
                t.total_harga,
                t.status
            FROM transaksi t
            JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan
            ORDER BY t.tanggal DESC
        "

        Dim da As New MySqlDataAdapter(query, CONN)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgvTransaksi.Columns.Clear()
        dgvTransaksi.DataSource = dt
        dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Header kolom
        dgvTransaksi.Columns(0).HeaderText = "ID Transaksi"
        dgvTransaksi.Columns(1).HeaderText = "Tanggal"
        dgvTransaksi.Columns(2).HeaderText = "Pelanggan"
        dgvTransaksi.Columns(3).HeaderText = "Nama Mainan"
        dgvTransaksi.Columns(4).HeaderText = "Jumlah"
        dgvTransaksi.Columns(5).HeaderText = "Total Harga (Rp)"

        Dim comboCol As New DataGridViewComboBoxColumn()
        comboCol.HeaderText = "Status"
        comboCol.Name = "Status"
        comboCol.DataPropertyName = "status"
        comboCol.Items.AddRange("Unpaid", "Paid", "Cancelled")

        dgvTransaksi.Columns.Remove("status")
        dgvTransaksi.Columns.Insert(6, comboCol)

        ' Lock baris jika status bukan "Unpaid"
        For Each row As DataGridViewRow In dgvTransaksi.Rows
            If row.Cells("Status").Value?.ToString() <> "Unpaid" Then
                row.Cells("Status").ReadOnly = True
            End If
        Next
    End Sub

    ' Simpan ke database saat status diganti
    Private Sub dgvTransaksi_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellValueChanged
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
            Dim row = dgvTransaksi.Rows(e.RowIndex)
            Dim idTransaksi = row.Cells(0).Value.ToString()
            Dim statusBaru = row.Cells(6).Value.ToString()
            simpan_status_ke_database(idTransaksi, statusBaru)
        End If
    End Sub

    ' Commit nilai ComboBox saat diubah
    Private Sub dgvTransaksi_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvTransaksi.CurrentCellDirtyStateChanged
        If dgvTransaksi.IsCurrentCellDirty Then
            dgvTransaksi.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    ' Simpan status ke database
    Private Sub simpan_status_ke_database(idTransaksi As String, statusBaru As String)
        Try
            koneksi()

            ' Ambil data transaksi yang akan diupdate
            Dim cmdSelect As New MySqlCommand("SELECT nama_mainan, kuantitas, status FROM transaksi WHERE id_transaksi = @id", CONN)
            cmdSelect.Parameters.AddWithValue("@id", idTransaksi)
            Dim reader = cmdSelect.ExecuteReader()

            Dim namaMainan As String = ""
            Dim kuantitas As Integer = 0
            Dim statusLama As String = ""

            If reader.Read() Then
                namaMainan = reader("nama_mainan").ToString()
                kuantitas = Convert.ToInt32(reader("kuantitas"))
                statusLama = reader("status").ToString()
            End If
            reader.Close()

            ' Update status transaksi
            Dim cmdUpdate As New MySqlCommand("UPDATE transaksi SET status = @status WHERE id_transaksi = @id", CONN)
            cmdUpdate.Parameters.AddWithValue("@status", statusBaru)
            cmdUpdate.Parameters.AddWithValue("@id", idTransaksi)
            cmdUpdate.ExecuteNonQuery()

            ' Jika status diubah ke Cancelled dan status sebelumnya bukan Cancelled, update stok mainan
            If statusBaru = "Cancelled" And statusLama <> "Cancelled" Then
                Dim cmdUpdateStok As New MySqlCommand("UPDATE mainan SET stok = stok + @qty WHERE nama_mainan = @nama", CONN)
                cmdUpdateStok.Parameters.AddWithValue("@qty", kuantitas)
                cmdUpdateStok.Parameters.AddWithValue("@nama", namaMainan)
                cmdUpdateStok.ExecuteNonQuery()
            End If

            tampilkan_transaksi()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Class
