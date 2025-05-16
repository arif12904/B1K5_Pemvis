Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Struk
    Public Property id_transaksi As String
    Public Property id_pelanggan As String
    Public Property TanggalTransaksi As Date
    Public Property NamaPelanggan As String
    Public Property NamaProduk As String
    Public Property HargaSatuan As Decimal
    Public Property Jumlah As Integer
    Public Property TotalHarga As Decimal

    'Load data'
    Private Sub Struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmbilDetailTransaksi(id_transaksi)

        TotalHarga = HargaSatuan * Jumlah

        lblIDTransaksi.Text = "ID Transaksi: " & id_transaksi
        lblTanggal.Text = "Tanggal: " & TanggalTransaksi.ToString("dd/MM/yyyy")
        lblNamaPelanggan.Text = "Nama Pelanggan: " & NamaPelanggan
        lblTotal.Text = "Total: Rp " & TotalHarga.ToString("N0")
    End Sub

    ' Fungsi ambil data transaksi di database '
    Private Sub AmbilDetailTransaksi(id_transaksi As String)
        Try
            koneksi()

            Dim query As String = "SELECT t.nama_mainan, t.total_harga, t.kuantitas, p.nama, t.tanggal 
                       FROM transaksi t
                       JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan
                       WHERE t.id_transaksi = @id_transaksi"

            Using cmd As New MySqlCommand(query, CONN)
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        NamaProduk = reader("nama_mainan").ToString()
                        TotalHarga = Convert.ToDecimal(reader("total_harga"))
                        Jumlah = Convert.ToInt32(reader("kuantitas"))
                        NamaPelanggan = reader("nama").ToString()
                        TanggalTransaksi = Convert.ToDateTime(reader("tanggal"))
                        HargaSatuan = TotalHarga / Jumlah
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    'event untuk button preview'
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim ukuranStruk As New PaperSize("Struk Kecil", 320, 320)
        PrintDocument1.DefaultPageSettings.PaperSize = ukuranStruk
        PrintDocument1.DefaultPageSettings.Margins = New Margins(10, 10, 10, 10)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    'Print Struk'
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim font As New Font("VT323", 10)
        Dim boldFont As New Font("VT323", 10, FontStyle.Bold)
        Dim titleFont As New Font("VT323", 12, FontStyle.Bold)


        Dim paddingX As Integer = 20
        Dim paddingY As Integer = 20
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim pageHeight As Integer = e.PageBounds.Height


        Dim bgColor As Brush = New SolidBrush(Color.FromArgb(10, 25, 50))
        g.FillRectangle(bgColor, 0, 0, pageWidth, pageHeight)


        Dim y As Integer = paddingY

        Dim title As String = "PixPlay - Struk Pembelian"
        Dim titleSize As SizeF = g.MeasureString(title, titleFont)
        Dim centerX As Single = (pageWidth - titleSize.Width) / 2
        g.DrawString(title, titleFont, New SolidBrush(Color.FromArgb(191, 251, 79)), centerX, y)
        y += 30

        g.DrawString("ID Transaksi: " & id_transaksi, font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 20
        g.DrawString("Tanggal: " & TanggalTransaksi.ToString("dd/MM/yyyy"), font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 20
        g.DrawString("Nama Pelanggan: " & NamaPelanggan, font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 30

        g.DrawString("===================================================", font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 20

        Dim namaProdukX As Integer = paddingX
        Dim qtyX As Integer = 150
        Dim totalX As Integer = pageWidth - 90

        g.DrawString("Produk", font, New SolidBrush(Color.FromArgb(191, 251, 79)), namaProdukX, y)
        g.DrawString("Qty", font, New SolidBrush(Color.FromArgb(191, 251, 79)), qtyX, y)
        g.DrawString("Total", font, New SolidBrush(Color.FromArgb(191, 251, 79)), totalX, y)
        y += 15
        g.DrawString("---------------------------------------------------", font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 20

        g.DrawString(NamaProduk, font, New SolidBrush(Color.FromArgb(191, 251, 79)), namaProdukX, y)
        g.DrawString(Jumlah.ToString(), font, New SolidBrush(Color.FromArgb(191, 251, 79)), qtyX, y)
        g.DrawString("Rp " & (HargaSatuan * Jumlah).ToString("N0"), font, New SolidBrush(Color.FromArgb(191, 251, 79)), totalX, y)
        y += 25

        g.DrawString("===================================================", font, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 20

        g.DrawString("Total: Rp " & TotalHarga.ToString("N0"), boldFont, New SolidBrush(Color.FromArgb(191, 251, 79)), paddingX, y)
        y += 40

        Dim footerText1 As String = "Terima kasih telah berbelanja!"
        Dim footerText2 As String = "Simpan struk ini dan lakukan pembayaran ke toko"

        Dim footerSize1 As SizeF = g.MeasureString(footerText1, font)
        Dim footerX1 As Single = (pageWidth - footerSize1.Width) / 2
        Dim y1 As Single = y ' 

        Dim footerSize2 As SizeF = g.MeasureString(footerText2, font)
        Dim footerX2 As Single = (pageWidth - footerSize2.Width) / 2
        Dim y2 As Single = y1 + footerSize1.Height + 5

        g.DrawString(footerText1, font, New SolidBrush(Color.FromArgb(191, 251, 79)), footerX1, y1)

        g.DrawString(footerText2, font, New SolidBrush(Color.FromArgb(191, 251, 79)), footerX2, y2)

    End Sub

    'event untuk kembali ke halaman katalog'
    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Dim catalog As New Catalog()
        catalog.id_pelanggan = Me.id_pelanggan
        catalog.Show()
        Me.Hide()
    End Sub

End Class
