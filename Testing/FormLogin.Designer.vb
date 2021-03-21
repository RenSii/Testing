<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonForgotPassword = New System.Windows.Forms.Button()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(264, 113)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(179, 26)
        Me.txtusername.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(264, 210)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(179, 26)
        Me.txtpw.TabIndex = 5
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Location = New System.Drawing.Point(167, 296)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(153, 59)
        Me.ButtonLogin.TabIndex = 6
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.ButtonForgotPassword)
        Me.Panel1.Controls.Add(Me.ButtonRegister)
        Me.Panel1.Controls.Add(Me.ButtonLogin)
        Me.Panel1.Controls.Add(Me.txtpw)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 483)
        Me.Panel1.TabIndex = 2
        '
        'ButtonForgotPassword
        '
        Me.ButtonForgotPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonForgotPassword.FlatAppearance.BorderSize = 0
        Me.ButtonForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonForgotPassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonForgotPassword.Location = New System.Drawing.Point(290, 361)
        Me.ButtonForgotPassword.Name = "ButtonForgotPassword"
        Me.ButtonForgotPassword.Size = New System.Drawing.Size(153, 59)
        Me.ButtonForgotPassword.TabIndex = 8
        Me.ButtonForgotPassword.Text = "FORGOT PASSWORD?"
        Me.ButtonForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonForgotPassword.UseVisualStyleBackColor = False
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonRegister.FlatAppearance.BorderSize = 0
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonRegister.Location = New System.Drawing.Point(45, 361)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(153, 38)
        Me.ButtonRegister.TabIndex = 7
        Me.ButtonRegister.Text = "REGISTER"
        Me.ButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpw As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonForgotPassword As Button
    Friend WithEvents ButtonRegister As Button
End Class
