<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Struk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Struk))
        Me.lblIDTransaksi = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDTransaksi
        '
        Me.lblIDTransaksi.AutoSize = True
        Me.lblIDTransaksi.Font = New System.Drawing.Font("VT323", 12.0!)
        Me.lblIDTransaksi.ForeColor = System.Drawing.Color.White
        Me.lblIDTransaksi.Location = New System.Drawing.Point(45, 31)
        Me.lblIDTransaksi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDTransaksi.Name = "lblIDTransaksi"
        Me.lblIDTransaksi.Size = New System.Drawing.Size(144, 31)
        Me.lblIDTransaksi.TabIndex = 0
        Me.lblIDTransaksi.Text = "ID Transaksi:"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("VT323", 12.0!)
        Me.lblTanggal.ForeColor = System.Drawing.Color.White
        Me.lblTanggal.Location = New System.Drawing.Point(45, 77)
        Me.lblTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(94, 31)
        Me.lblTanggal.TabIndex = 1
        Me.lblTanggal.Text = "Tanggal:"
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.AutoSize = True
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("VT323", 12.0!)
        Me.lblNamaPelanggan.ForeColor = System.Drawing.Color.White
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(45, 123)
        Me.lblNamaPelanggan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(164, 31)
        Me.lblNamaPelanggan.TabIndex = 2
        Me.lblNamaPelanggan.Text = "Nama Pelanggan:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(45, 523)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 36)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total:"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Chartreuse
        Me.btnPreview.Font = New System.Drawing.Font("VT323", 12.0!)
        Me.btnPreview.Location = New System.Drawing.Point(531, 513)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 46)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("VT323", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(412, 521)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(58, 31)
        Me.lblBack.TabIndex = 7
        Me.lblBack.Text = "Back"
        '
        'Struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 586)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblIDTransaksi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Struk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Struk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDTransaksi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPreview As Button
    Friend WithEvents lblBack As Label
End Class
