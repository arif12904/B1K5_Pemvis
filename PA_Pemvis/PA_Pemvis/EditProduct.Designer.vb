<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProduct
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
    Friend WithEvents btnEditProduct As System.Windows.Forms.Button
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
        Me.btnEditProduct = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
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
        Me.lblTitle.Location = New System.Drawing.Point(17, -14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(359, 82)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Product"
        '
        'lblInputProduct
        '
        Me.lblInputProduct.AutoSize = True
        Me.lblInputProduct.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputProduct.ForeColor = System.Drawing.Color.White
        Me.lblInputProduct.Location = New System.Drawing.Point(28, 96)
        Me.lblInputProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputProduct.Name = "lblInputProduct"
        Me.lblInputProduct.Size = New System.Drawing.Size(244, 20)
        Me.lblInputProduct.TabIndex = 3
        Me.lblInputProduct.Text = "UPDATE YOUR PRODUCT"
        '
        'txtProduct
        '
        Me.txtProduct.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(31, 124)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(645, 26)
        Me.txtProduct.TabIndex = 4
        '
        'lblInputPrice
        '
        Me.lblInputPrice.AutoSize = True
        Me.lblInputPrice.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputPrice.ForeColor = System.Drawing.Color.White
        Me.lblInputPrice.Location = New System.Drawing.Point(28, 168)
        Me.lblInputPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputPrice.Name = "lblInputPrice"
        Me.lblInputPrice.Size = New System.Drawing.Size(212, 20)
        Me.lblInputPrice.TabIndex = 5
        Me.lblInputPrice.Text = "UPDATE YOUR PRICE"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(31, 196)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(645, 26)
        Me.txtPrice.TabIndex = 6
        '
        'lblInputStock
        '
        Me.lblInputStock.AutoSize = True
        Me.lblInputStock.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputStock.ForeColor = System.Drawing.Color.White
        Me.lblInputStock.Location = New System.Drawing.Point(28, 239)
        Me.lblInputStock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputStock.Name = "lblInputStock"
        Me.lblInputStock.Size = New System.Drawing.Size(218, 20)
        Me.lblInputStock.TabIndex = 7
        Me.lblInputStock.Text = "UPDATE YOUR STOCK"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(31, 265)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(645, 26)
        Me.txtStock.TabIndex = 8
        '
        'btnEditProduct
        '
        Me.btnEditProduct.AllowDrop = True
        Me.btnEditProduct.AutoEllipsis = True
        Me.btnEditProduct.BackColor = System.Drawing.Color.Chartreuse
        Me.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProduct.Font = New System.Drawing.Font("VT323", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduct.Location = New System.Drawing.Point(31, 397)
        Me.btnEditProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(643, 34)
        Me.btnEditProduct.TabIndex = 9
        Me.btnEditProduct.Text = "Edit Product"
        Me.btnEditProduct.UseVisualStyleBackColor = False
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(717, 107)
        Me.picImage.Margin = New System.Windows.Forms.Padding(2)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(200, 195)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 10
        Me.picImage.TabStop = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.AllowDrop = True
        Me.btnBrowseImage.AutoEllipsis = True
        Me.btnBrowseImage.BackColor = System.Drawing.Color.Chartreuse
        Me.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseImage.Font = New System.Drawing.Font("VT323", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseImage.Location = New System.Drawing.Point(717, 325)
        Me.btnBrowseImage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(200, 34)
        Me.btnBrowseImage.TabIndex = 19
        Me.btnBrowseImage.Text = "Edit Photo"
        Me.btnBrowseImage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 305)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CATEGORY"
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("VT323", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Game", "Action Figure", "Puzzle"})
        Me.cbCategory.Location = New System.Drawing.Point(31, 334)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(645, 33)
        Me.cbCategory.TabIndex = 20
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.Color.White
        Me.lblHistory.Location = New System.Drawing.Point(718, 26)
        Me.lblHistory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(94, 20)
        Me.lblHistory.TabIndex = 30
        Me.lblHistory.Text = "HISTORY"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLogOut.Location = New System.Drawing.Point(837, 27)
        Me.lblLogOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(92, 20)
        Me.lblLogOut.TabIndex = 29
        Me.lblLogOut.Text = "LOG OUT"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.White
        Me.lblDashboard.Location = New System.Drawing.Point(395, 27)
        Me.lblDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(126, 20)
        Me.lblDashboard.TabIndex = 27
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'lblAddProduct
        '
        Me.lblAddProduct.AutoSize = True
        Me.lblAddProduct.Font = New System.Drawing.Font("Silkscreen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProduct.ForeColor = System.Drawing.Color.White
        Me.lblAddProduct.Location = New System.Drawing.Point(545, 27)
        Me.lblAddProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddProduct.Name = "lblAddProduct"
        Me.lblAddProduct.Size = New System.Drawing.Size(146, 20)
        Me.lblAddProduct.TabIndex = 28
        Me.lblAddProduct.Text = "ADD PRODUCT"
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 460)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.lblAddProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnEditProduct)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblInputStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblInputPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblInputProduct)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditProduct"
        Me.Text = "Edit Product"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowseImage As Button
    Private WithEvents Label1 As Label
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblAddProduct As Label
End Class