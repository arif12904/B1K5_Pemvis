Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Lengkapi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            MessageBox.Show("Login Admin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dashboard.Show()
            Exit Sub
        End If

        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE nama=@username AND kata_sandi=@password", CONN)
        CMD.Parameters.AddWithValue("@username", txtUsername.Text)
        CMD.Parameters.AddWithValue("@password", txtPassword.Text)

        RD = CMD.ExecuteReader()

        If RD.Read() Then

            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim id_pelanggan As String = RD("id_pelanggan").ToString()
            Dim catalogForm As New Catalog()
            catalogForm.id_pelanggan = id_pelanggan
            Me.Hide()
            RD.Close()
            catalogForm.Show()
        Else
            MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'RD.Close()
        CONN.Close()
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        Registrasi.Show()
    End Sub

    Private Sub lblRegister_MouseEnter(sender As Object, e As EventArgs) Handles lblRegister.MouseEnter
        lblRegister.ForeColor = Color.Lime
        lblRegister.Font = New Font(lblRegister.Font, FontStyle.Underline Or FontStyle.Bold)
        Cursor = Cursors.Hand
    End Sub

    Private Sub lblRegister_MouseLeave(sender As Object, e As EventArgs) Handles lblRegister.MouseLeave
        lblRegister.ForeColor = Color.Chartreuse
        lblRegister.Font = New Font(lblRegister.Font, FontStyle.Bold)
        Cursor = Cursors.Default
    End Sub
End Class