<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Change_Password
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
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtoldpassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtconfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.txtcancel = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBox3.Location = New System.Drawing.Point(595, 166)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(152, 24)
        Me.CheckBox3.TabIndex = 95
        Me.CheckBox3.Text = "Show  Password"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 21)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Old Password:"
        '
        'txtoldpassword
        '
        Me.txtoldpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtoldpassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpassword.ForeColor = System.Drawing.Color.Black
        Me.txtoldpassword.Location = New System.Drawing.Point(271, 163)
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.Size = New System.Drawing.Size(316, 29)
        Me.txtoldpassword.TabIndex = 94
        Me.txtoldpassword.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(595, 230)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.CheckBox1.TabIndex = 91
        Me.CheckBox1.Text = "Show  Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBox2.Location = New System.Drawing.Point(595, 293)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(180, 24)
        Me.CheckBox2.TabIndex = 92
        Me.CheckBox2.Text = "Show Password        "
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.Location = New System.Drawing.Point(271, 290)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(316, 29)
        Me.txtconfirmpassword.TabIndex = 90
        Me.txtconfirmpassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "New Password:"
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnewpassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpassword.ForeColor = System.Drawing.Color.Black
        Me.txtnewpassword.Location = New System.Drawing.Point(271, 227)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(316, 29)
        Me.txtnewpassword.TabIndex = 89
        Me.txtnewpassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Confirm Password:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 45)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Change Password"
        '
        'txtconfirm
        '
        Me.txtconfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtconfirm.AutoRoundedCorners = True
        Me.txtconfirm.BorderRadius = 25
        Me.txtconfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txtconfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txtconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtconfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtconfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtconfirm.ForeColor = System.Drawing.Color.Black
        Me.txtconfirm.Location = New System.Drawing.Point(154, 352)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(223, 53)
        Me.txtconfirm.TabIndex = 96
        Me.txtconfirm.Text = "Confirm"
        '
        'txtcancel
        '
        Me.txtcancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcancel.AutoRoundedCorners = True
        Me.txtcancel.BorderRadius = 25
        Me.txtcancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txtcancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txtcancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtcancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtcancel.FillColor = System.Drawing.Color.LimeGreen
        Me.txtcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcancel.ForeColor = System.Drawing.Color.Black
        Me.txtcancel.Location = New System.Drawing.Point(412, 352)
        Me.txtcancel.Name = "txtcancel"
        Me.txtcancel.Size = New System.Drawing.Size(259, 53)
        Me.txtcancel.TabIndex = 97
        Me.txtcancel.Text = "Back"
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 465)
        Me.Controls.Add(Me.txtcancel)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtoldpassword)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Change_Password"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtoldpassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnewpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtconfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtcancel As Guna.UI2.WinForms.Guna2Button
End Class
