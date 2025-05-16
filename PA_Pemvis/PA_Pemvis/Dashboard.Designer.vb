<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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

    'Deklarasi komponen
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtSearch As TextBox ' Kolom pencarian
    Friend WithEvents lblSearch As Label ' Label pencarian

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.colidMainan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblAddProduct = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("VT323", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(26, -6)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 82)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dashboard"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("VT323", 16.0!)
        Me.txtSearch.Location = New System.Drawing.Point(43, 123)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 22)
        Me.txtSearch.TabIndex = 5
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("VT323", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(40, 97)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(50, 18)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Search:"
        '
        'dgvProducts
        '
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidMainan, Me.colProduct, Me.colPrice, Me.colStock, Me.colKategori, Me.colEdit, Me.colDelete})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.dgvProducts.Location = New System.Drawing.Point(43, 174)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 62
        Me.dgvProducts.Size = New System.Drawing.Size(1153, 163)
        Me.dgvProducts.TabIndex = 8
        '
        'colidMainan
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VT323", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.colidMainan.DefaultCellStyle = DataGridViewCellStyle2
        Me.colidMainan.HeaderText = "ID Mainan"
        Me.colidMainan.MinimumWidth = 8
        Me.colidMainan.Name = "colidMainan"
        Me.colidMainan.ReadOnly = True
        Me.colidMainan.Width = 150
        '
        'colProduct
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VT323", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.colProduct.DefaultCellStyle = DataGridViewCellStyle3
        Me.colProduct.HeaderText = "PRODUCT"
        Me.colProduct.MinimumWidth = 8
        Me.colProduct.Name = "colProduct"
        Me.colProduct.ReadOnly = True
        Me.colProduct.Width = 200
        '
        'colPrice
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("VT323", 14.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPrice.HeaderText = "PRICE"
        Me.colPrice.MinimumWidth = 8
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 150
        '
        'colStock
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("VT323", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.colStock.DefaultCellStyle = DataGridViewCellStyle5
        Me.colStock.HeaderText = "STOCK"
        Me.colStock.MinimumWidth = 8
        Me.colStock.Name = "colStock"
        Me.colStock.ReadOnly = True
        Me.colStock.Width = 150
        '
        'colKategori
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("VT323", 14.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.colKategori.DefaultCellStyle = DataGridViewCellStyle6
        Me.colKategori.HeaderText = "Category"
        Me.colKategori.MinimumWidth = 8
        Me.colKategori.Name = "colKategori"
        Me.colKategori.ReadOnly = True
        Me.colKategori.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colKategori.Width = 200
        '
        'colEdit
        '
        Me.colEdit.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("VT323", 14.0!)
        Me.colEdit.DefaultCellStyle = DataGridViewCellStyle7
        Me.colEdit.HeaderText = "EDIT"
        Me.colEdit.LinkColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.colEdit.MinimumWidth = 8
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForLinkValue = True
        Me.colEdit.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.colEdit.Width = 150
        '
        'colDelete
        '
        Me.colDelete.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("VT323", 14.0!)
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle8
        Me.colDelete.HeaderText = "DELETE"
        Me.colDelete.LinkColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.colDelete.MinimumWidth = 8
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Text = "Delete"
        Me.colDelete.UseColumnTextForLinkValue = True
        Me.colDelete.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.colDelete.Width = 150
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLogOut.Location = New System.Drawing.Point(1089, 44)
        Me.lblLogOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(92, 20)
        Me.lblLogOut.TabIndex = 21
        Me.lblLogOut.Text = "LOG OUT"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.White
        Me.lblDashboard.Location = New System.Drawing.Point(647, 44)
        Me.lblDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(126, 20)
        Me.lblDashboard.TabIndex = 19
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'lblAddProduct
        '
        Me.lblAddProduct.AutoSize = True
        Me.lblAddProduct.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProduct.ForeColor = System.Drawing.Color.White
        Me.lblAddProduct.Location = New System.Drawing.Point(797, 44)
        Me.lblAddProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddProduct.Name = "lblAddProduct"
        Me.lblAddProduct.Size = New System.Drawing.Size(146, 20)
        Me.lblAddProduct.TabIndex = 20
        Me.lblAddProduct.Text = "ADD PRODUCT"
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.Color.White
        Me.lblHistory.Location = New System.Drawing.Point(970, 43)
        Me.lblHistory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(94, 20)
        Me.lblHistory.TabIndex = 22
        Me.lblHistory.Text = "HISTORY"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1215, 406)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.lblAddProduct)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents colidMainan As DataGridViewTextBoxColumn
    Friend WithEvents colProduct As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colStock As DataGridViewTextBoxColumn
    Friend WithEvents colKategori As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewLinkColumn
    Friend WithEvents colDelete As DataGridViewLinkColumn
    Friend WithEvents lblLogOut As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblAddProduct As Label
    Friend WithEvents lblHistory As Label
End Class