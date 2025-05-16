Imports MySql.Data.MySqlClient

Public Class Registrasi
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtNama.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek apakah username "admin"
        If txtNama.Text.Trim.ToLower() = "admin" Then
            MessageBox.Show("Username 'admin' tidak boleh digunakan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Call koneksi()

        ' Cek Username di database
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE nama=@nama", CONN)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        RD = CMD.ExecuteReader()

        If RD.HasRows Then
            RD.Close()
            MessageBox.Show("Username sudah terdaftar, gunakan nama lain.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        RD.Close()

        ' Insert data pelanggan baru
        CMD = New MySqlCommand("INSERT INTO pelanggan (nama, kata_sandi) VALUES (@nama, @sandi)", CONN)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@sandi", txtPassword.Text)

        Try
            CMD.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Login.Show()
        Catch ex As Exception
            MessageBox.Show("Registrasi gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CONN.Close()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub lblLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblLogin.MouseEnter
        lblLogin.ForeColor = Color.Lime
        lblLogin.Font = New Font(lblLogin.Font, FontStyle.Underline Or FontStyle.Bold)
        Cursor = Cursors.Hand
    End Sub

    Private Sub lblLogin_MouseLeave(sender As Object, e As EventArgs) Handles lblLogin.MouseLeave
        lblLogin.ForeColor = Color.Chartreuse
        lblLogin.Font = New Font(lblLogin.Font, FontStyle.Bold)
        Cursor = Cursors.Default
    End Sub
End Class