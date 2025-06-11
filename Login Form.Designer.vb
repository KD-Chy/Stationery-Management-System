<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.forgetPasswordBtn = New System.Windows.Forms.Button()
        Me.smsTxt = New System.Windows.Forms.TextBox()
        Me.Panelmain = New System.Windows.Forms.Panel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.idPass = New System.Windows.Forms.PictureBox()
        Me.idPic = New System.Windows.Forms.PictureBox()
        Me.Panelmain.SuspendLayout()
        CType(Me.idPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(118, 130)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(345, 30)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SeaShell
        Me.btnLogin.Location = New System.Drawing.Point(118, 282)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 52)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'forgetPasswordBtn
        '
        Me.forgetPasswordBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.forgetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgetPasswordBtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetPasswordBtn.ForeColor = System.Drawing.Color.SeaShell
        Me.forgetPasswordBtn.Location = New System.Drawing.Point(241, 282)
        Me.forgetPasswordBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forgetPasswordBtn.Name = "forgetPasswordBtn"
        Me.forgetPasswordBtn.Size = New System.Drawing.Size(210, 52)
        Me.forgetPasswordBtn.TabIndex = 3
        Me.forgetPasswordBtn.Text = "Forget Password?"
        Me.forgetPasswordBtn.UseVisualStyleBackColor = False
        '
        'smsTxt
        '
        Me.smsTxt.BackColor = System.Drawing.Color.MediumVioletRed
        Me.smsTxt.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smsTxt.ForeColor = System.Drawing.Color.SeaShell
        Me.smsTxt.Location = New System.Drawing.Point(13, 32)
        Me.smsTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.smsTxt.Name = "smsTxt"
        Me.smsTxt.Size = New System.Drawing.Size(621, 44)
        Me.smsTxt.TabIndex = 0
        Me.smsTxt.Text = "Stationery Record Keeping System"
        Me.smsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panelmain
        '
        Me.Panelmain.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panelmain.Controls.Add(Me.txtpassword)
        Me.Panelmain.Controls.Add(Me.CheckBox1)
        Me.Panelmain.Controls.Add(Me.idPass)
        Me.Panelmain.Controls.Add(Me.idPic)
        Me.Panelmain.Controls.Add(Me.forgetPasswordBtn)
        Me.Panelmain.Controls.Add(Me.btnLogin)
        Me.Panelmain.Controls.Add(Me.smsTxt)
        Me.Panelmain.Controls.Add(Me.txtusername)
        Me.Panelmain.Location = New System.Drawing.Point(27, 39)
        Me.Panelmain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panelmain.Name = "Panelmain"
        Me.Panelmain.Size = New System.Drawing.Size(668, 373)
        Me.Panelmain.TabIndex = 5
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(119, 203)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(344, 30)
        Me.txtpassword.TabIndex = 8
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(481, 209)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'idPass
        '
        Me.idPass.BackgroundImage = CType(resources.GetObject("idPass.BackgroundImage"), System.Drawing.Image)
        Me.idPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.idPass.Location = New System.Drawing.Point(43, 195)
        Me.idPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idPass.Name = "idPass"
        Me.idPass.Size = New System.Drawing.Size(47, 51)
        Me.idPass.TabIndex = 6
        Me.idPass.TabStop = False
        '
        'idPic
        '
        Me.idPic.BackgroundImage = CType(resources.GetObject("idPic.BackgroundImage"), System.Drawing.Image)
        Me.idPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.idPic.Location = New System.Drawing.Point(43, 118)
        Me.idPic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idPic.Name = "idPic"
        Me.idPic.Size = New System.Drawing.Size(47, 51)
        Me.idPic.TabIndex = 6
        Me.idPic.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(773, 447)
        Me.Controls.Add(Me.Panelmain)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.Panelmain.ResumeLayout(False)
        Me.Panelmain.PerformLayout()
        CType(Me.idPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents forgetPasswordBtn As Button
    Friend WithEvents smsTxt As TextBox
    Friend WithEvents Panelmain As Panel
    Friend WithEvents idPic As PictureBox
    Friend WithEvents idPass As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtpassword As TextBox
End Class
