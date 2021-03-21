<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextSellPrice = New System.Windows.Forms.TextBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBuyPrice = New System.Windows.Forms.TextBox()
        Me.TextSpecification = New System.Windows.Forms.TextBox()
        Me.TextProductName = New System.Windows.Forms.TextBox()
        Me.TextProductID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 701)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.TextSellPrice)
        Me.Panel2.Controls.Add(Me.ButtonBack)
        Me.Panel2.Controls.Add(Me.ButtonCancel)
        Me.Panel2.Controls.Add(Me.ButtonDelete)
        Me.Panel2.Controls.Add(Me.ButtonUpdate)
        Me.Panel2.Controls.Add(Me.ButtonSave)
        Me.Panel2.Controls.Add(Me.TextBuyPrice)
        Me.Panel2.Controls.Add(Me.TextSpecification)
        Me.Panel2.Controls.Add(Me.TextProductName)
        Me.Panel2.Controls.Add(Me.TextProductID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(896, 701)
        Me.Panel2.TabIndex = 1
        '
        'TextSellPrice
        '
        Me.TextSellPrice.Location = New System.Drawing.Point(604, 274)
        Me.TextSellPrice.Name = "TextSellPrice"
        Me.TextSellPrice.Size = New System.Drawing.Size(246, 26)
        Me.TextSellPrice.TabIndex = 17
        '
        'ButtonBack
        '
        Me.ButtonBack.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Location = New System.Drawing.Point(658, 412)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(228, 37)
        Me.ButtonBack.TabIndex = 16
        Me.ButtonBack.Text = "back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(401, 412)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(227, 37)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(744, 369)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(142, 37)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(573, 369)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(142, 37)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(400, 369)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(142, 37)
        Me.ButtonSave.TabIndex = 12
        Me.ButtonSave.Text = "ADD"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBuyPrice
        '
        Me.TextBuyPrice.Location = New System.Drawing.Point(604, 224)
        Me.TextBuyPrice.Name = "TextBuyPrice"
        Me.TextBuyPrice.Size = New System.Drawing.Size(246, 26)
        Me.TextBuyPrice.TabIndex = 10
        '
        'TextSpecification
        '
        Me.TextSpecification.Location = New System.Drawing.Point(604, 180)
        Me.TextSpecification.Name = "TextSpecification"
        Me.TextSpecification.Size = New System.Drawing.Size(246, 26)
        Me.TextSpecification.TabIndex = 9
        '
        'TextProductName
        '
        Me.TextProductName.Location = New System.Drawing.Point(604, 134)
        Me.TextProductName.Name = "TextProductName"
        Me.TextProductName.Size = New System.Drawing.Size(246, 26)
        Me.TextProductName.TabIndex = 8
        '
        'TextProductID
        '
        Me.TextProductID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextProductID.Enabled = False
        Me.TextProductID.Location = New System.Drawing.Point(604, 90)
        Me.TextProductID.Name = "TextProductID"
        Me.TextProductID.Size = New System.Drawing.Size(246, 26)
        Me.TextProductID.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "sell price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "buy price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "specification"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "product name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "product id"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(370, 626)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE product"
        '
        'ManageProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManageProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBuyPrice As TextBox
    Friend WithEvents TextSpecification As TextBox
    Friend WithEvents TextProductName As TextBox
    Friend WithEvents TextProductID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextSellPrice As TextBox
End Class
