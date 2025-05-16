<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProduct

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
    Private lblTitle As System.Windows.Forms.Label
    Private lblInputProduct As System.Windows.Forms.Label
    Private txtProduct As System.Windows.Forms.TextBox
    Private lblInputPrice As System.Windows.Forms.Label
    Private txtPrice As System.Windows.Forms.TextBox
    Private lblInputStock As System.Windows.Forms.Label
    Private txtStock As System.Windows.Forms.TextBox
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Private picImage As System.Windows.Forms.PictureBox

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInputProduct = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.lblInputPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblInputStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.lblInputKodeJenis = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblAddProduct = New System.Windows.Forms.Label()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("VT323", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(17, -17)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(332, 82)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add Product"
        '
        'lblInputProduct
        '
        Me.lblInputProduct.AutoSize = True
        Me.lblInputProduct.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputProduct.ForeColor = System.Drawing.Color.White
        Me.lblInputProduct.Location = New System.Drawing.Point(28, 88)
        Me.lblInputProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputProduct.Name = "lblInputProduct"
        Me.lblInputProduct.Size = New System.Drawing.Size(229, 20)
        Me.lblInputProduct.TabIndex = 3
        Me.lblInputProduct.Text = "INPUT YOUR PRODUCT"
        '
        'txtProduct
        '
        Me.txtProduct.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(31, 116)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(645, 26)
        Me.txtProduct.TabIndex = 4
        '
        'lblInputPrice
        '
        Me.lblInputPrice.AutoSize = True
        Me.lblInputPrice.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputPrice.ForeColor = System.Drawing.Color.White
        Me.lblInputPrice.Location = New System.Drawing.Point(28, 160)
        Me.lblInputPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputPrice.Name = "lblInputPrice"
        Me.lblInputPrice.Size = New System.Drawing.Size(197, 20)
        Me.lblInputPrice.TabIndex = 5
        Me.lblInputPrice.Text = "INPUT YOUR PRICE"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(31, 187)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(645, 26)
        Me.txtPrice.TabIndex = 6
        '
        'lblInputStock
        '
        Me.lblInputStock.AutoSize = True
        Me.lblInputStock.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputStock.ForeColor = System.Drawing.Color.White
        Me.lblInputStock.Location = New System.Drawing.Point(28, 230)
        Me.lblInputStock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputStock.Name = "lblInputStock"
        Me.lblInputStock.Size = New System.Drawing.Size(203, 20)
        Me.lblInputStock.TabIndex = 7
        Me.lblInputStock.Text = "INPUT YOUR STOCK"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(31, 257)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(645, 26)
        Me.txtStock.TabIndex = 8
        '
        'btnAddProduct
        '
        Me.btnAddProduct.AllowDrop = True
        Me.btnAddProduct.AutoEllipsis = True
        Me.btnAddProduct.BackColor = System.Drawing.Color.Chartreuse
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("VT323", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(31, 394)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(644, 34)
        Me.btnAddProduct.TabIndex = 9
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'lblInputKodeJenis
        '
        Me.lblInputKodeJenis.AutoSize = True
        Me.lblInputKodeJenis.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputKodeJenis.ForeColor = System.Drawing.Color.White
        Me.lblInputKodeJenis.Location = New System.Drawing.Point(28, 107)
        Me.lblInputKodeJenis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputKodeJenis.Name = "lblInputKodeJenis"
        Me.lblInputKodeJenis.Size = New System.Drawing.Size(0, 20)
        Me.lblInputKodeJenis.TabIndex = 11
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(717, 107)
        Me.picImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(200, 195)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 10
        Me.picImage.TabStop = False
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Game", "Action Figure", "Puzzle"})
        Me.cbCategory.Location = New System.Drawing.Point(31, 333)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(645, 33)
        Me.cbCategory.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 304)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CATEGORY"
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.AllowDrop = True
        Me.btnBrowseImage.AutoEllipsis = True
        Me.btnBrowseImage.BackColor = System.Drawing.Color.Chartreuse
        Me.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseImage.Font = New System.Drawing.Font("VT323", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseImage.Location = New System.Drawing.Point(717, 317)
        Me.btnBrowseImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(200, 34)
        Me.btnBrowseImage.TabIndex = 18
        Me.btnBrowseImage.Text = "Add Photo"
        Me.btnBrowseImage.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.Color.White
        Me.lblHistory.Location = New System.Drawing.Point(706, 24)
        Me.lblHistory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(94, 20)
        Me.lblHistory.TabIndex = 26
        Me.lblHistory.Text = "HISTORY"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLogOut.Location = New System.Drawing.Point(825, 25)
        Me.lblLogOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(92, 20)
        Me.lblLogOut.TabIndex = 25
        Me.lblLogOut.Text = "LOG OUT"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.White
        Me.lblDashboard.Location = New System.Drawing.Point(383, 25)
        Me.lblDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(126, 20)
        Me.lblDashboard.TabIndex = 23
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'lblAddProduct
        '
        Me.lblAddProduct.AutoSize = True
        Me.lblAddProduct.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProduct.ForeColor = System.Drawing.Color.White
        Me.lblAddProduct.Location = New System.Drawing.Point(533, 25)
        Me.lblAddProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddProduct.Name = "lblAddProduct"
        Me.lblAddProduct.Size = New System.Drawing.Size(146, 20)
        Me.lblAddProduct.TabIndex = 24
        Me.lblAddProduct.Text = "ADD PRODUCT"
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 450)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.lblAddProduct)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.lblInputKodeJenis)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblInputStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblInputPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblInputProduct)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AddProduct"
        Me.Text = "Add Product"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblInputKodeJenis As Label
    Friend WithEvents cbCategory As ComboBox
    Private WithEvents Label1 As Label
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblAddProduct As Label
End Class