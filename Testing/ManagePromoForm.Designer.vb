<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagePromoForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextPromoID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextPromoReward = New System.Windows.Forms.TextBox()
        Me.ComboPromo = New System.Windows.Forms.ComboBox()
        Me.ButtonCariProductID = New System.Windows.Forms.Button()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBuyQty = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(899, 701)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.TextPromoID)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextPromoReward)
        Me.Panel2.Controls.Add(Me.ComboPromo)
        Me.Panel2.Controls.Add(Me.ButtonCariProductID)
        Me.Panel2.Controls.Add(Me.EndDate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.StartDate)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ButtonBack)
        Me.Panel2.Controls.Add(Me.ButtonCancel)
        Me.Panel2.Controls.Add(Me.ButtonDelete)
        Me.Panel2.Controls.Add(Me.ButtonUpdate)
        Me.Panel2.Controls.Add(Me.ButtonSave)
        Me.Panel2.Controls.Add(Me.TextBuyQty)
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
        Me.Panel2.Size = New System.Drawing.Size(899, 701)
        Me.Panel2.TabIndex = 1
        '
        'TextPromoID
        '
        Me.TextPromoID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextPromoID.Enabled = False
        Me.TextPromoID.Location = New System.Drawing.Point(603, 86)
        Me.TextPromoID.Name = "TextPromoID"
        Me.TextPromoID.Size = New System.Drawing.Size(246, 26)
        Me.TextPromoID.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Promo ID"
        '
        'TextPromoReward
        '
        Me.TextPromoReward.Location = New System.Drawing.Point(603, 313)
        Me.TextPromoReward.Name = "TextPromoReward"
        Me.TextPromoReward.Size = New System.Drawing.Size(246, 26)
        Me.TextPromoReward.TabIndex = 23
        '
        'ComboPromo
        '
        Me.ComboPromo.FormattingEnabled = True
        Me.ComboPromo.Items.AddRange(New Object() {"FREE", "DISCOUNT"})
        Me.ComboPromo.Location = New System.Drawing.Point(603, 261)
        Me.ComboPromo.Name = "ComboPromo"
        Me.ComboPromo.Size = New System.Drawing.Size(246, 28)
        Me.ComboPromo.TabIndex = 22
        '
        'ButtonCariProductID
        '
        Me.ButtonCariProductID.Location = New System.Drawing.Point(787, 129)
        Me.ButtonCariProductID.Name = "ButtonCariProductID"
        Me.ButtonCariProductID.Size = New System.Drawing.Size(62, 26)
        Me.ButtonCariProductID.TabIndex = 21
        Me.ButtonCariProductID.Text = "---"
        Me.ButtonCariProductID.UseVisualStyleBackColor = True
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "YYYY-MM-DD"
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDate.Location = New System.Drawing.Point(603, 419)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(246, 26)
        Me.EndDate.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(394, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "end date"
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "YYYY-MM-DD"
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(603, 365)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(246, 26)
        Me.StartDate.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "start date"
        '
        'ButtonBack
        '
        Me.ButtonBack.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Location = New System.Drawing.Point(659, 544)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(228, 37)
        Me.ButtonBack.TabIndex = 16
        Me.ButtonBack.Text = "back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(402, 544)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(227, 37)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(745, 501)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(142, 37)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(574, 501)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(142, 37)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(401, 501)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(142, 37)
        Me.ButtonSave.TabIndex = 12
        Me.ButtonSave.Text = "ADD"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBuyQty
        '
        Me.TextBuyQty.Location = New System.Drawing.Point(603, 219)
        Me.TextBuyQty.Name = "TextBuyQty"
        Me.TextBuyQty.Size = New System.Drawing.Size(246, 26)
        Me.TextBuyQty.TabIndex = 9
        '
        'TextProductName
        '
        Me.TextProductName.Enabled = False
        Me.TextProductName.Location = New System.Drawing.Point(603, 173)
        Me.TextProductName.Name = "TextProductName"
        Me.TextProductName.Size = New System.Drawing.Size(246, 26)
        Me.TextProductName.TabIndex = 8
        '
        'TextProductID
        '
        Me.TextProductID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextProductID.Enabled = False
        Me.TextProductID.Location = New System.Drawing.Point(603, 129)
        Me.TextProductID.Name = "TextProductID"
        Me.TextProductID.Size = New System.Drawing.Size(168, 26)
        Me.TextProductID.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(394, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "reward"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "promo type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "buy qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product ID"
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
        Me.Label1.Size = New System.Drawing.Size(348, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE PROMO"
        '
        'ManagePromoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManagePromoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagePromoForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextPromoID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextPromoReward As TextBox
    Friend WithEvents ComboPromo As ComboBox
    Friend WithEvents ButtonCariProductID As Button
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBuyQty As TextBox
    Friend WithEvents TextProductName As TextBox
    Friend WithEvents TextProductID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
