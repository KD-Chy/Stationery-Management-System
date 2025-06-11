<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstationeryid = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnsearchbystationeryid = New Guna.UI2.WinForms.Guna2Button()
        Me.txtstationeryaddress = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtstationeryphone = New System.Windows.Forms.TextBox()
        Me.txtstationerygmail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtstationeryname = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcashreceived = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtdiscountamt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnbillpreview = New Guna.UI2.WinForms.Guna2Button()
        Me.txtavailableqty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcustomerphone = New System.Windows.Forms.TextBox()
        Me.txtcustomeraddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsearchbybillno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtsearchbyproductname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btninsert = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.txttotalprice = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtchange)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtcashreceived)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtgrandtotal)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txtdiscountamt)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnbillpreview)
        Me.Panel1.Controls.Add(Me.txtavailableqty)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtcustomername)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtcustomerphone)
        Me.Panel1.Controls.Add(Me.txtcustomeraddress)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsearchbybillno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.txtsearchbyproductname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btninsert)
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.txtrate)
        Me.Panel1.Controls.Add(Me.txtunit)
        Me.Panel1.Controls.Add(Me.txtproductname)
        Me.Panel1.Controls.Add(Me.txtbillno)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.txtproductid)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1587, 674)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtstationeryid)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.btnsearchbystationeryid)
        Me.GroupBox1.Controls.Add(Me.txtstationeryaddress)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtstationeryphone)
        Me.GroupBox1.Controls.Add(Me.txtstationerygmail)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtstationeryname)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(899, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 196)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stationery Info"
        '
        'txtstationeryid
        '
        Me.txtstationeryid.Location = New System.Drawing.Point(250, 23)
        Me.txtstationeryid.Multiline = True
        Me.txtstationeryid.Name = "txtstationeryid"
        Me.txtstationeryid.Size = New System.Drawing.Size(201, 22)
        Me.txtstationeryid.TabIndex = 65
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(16, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(201, 22)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Search By Stationery ID"
        '
        'btnsearchbystationeryid
        '
        Me.btnsearchbystationeryid.AutoRoundedCorners = True
        Me.btnsearchbystationeryid.BorderRadius = 19
        Me.btnsearchbystationeryid.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsearchbystationeryid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsearchbystationeryid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsearchbystationeryid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsearchbystationeryid.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsearchbystationeryid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsearchbystationeryid.ForeColor = System.Drawing.Color.White
        Me.btnsearchbystationeryid.Location = New System.Drawing.Point(477, 15)
        Me.btnsearchbystationeryid.Name = "btnsearchbystationeryid"
        Me.btnsearchbystationeryid.Size = New System.Drawing.Size(160, 41)
        Me.btnsearchbystationeryid.TabIndex = 63
        Me.btnsearchbystationeryid.Text = "Search"
        '
        'txtstationeryaddress
        '
        Me.txtstationeryaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstationeryaddress.Location = New System.Drawing.Point(174, 89)
        Me.txtstationeryaddress.Name = "txtstationeryaddress"
        Me.txtstationeryaddress.Size = New System.Drawing.Size(254, 28)
        Me.txtstationeryaddress.TabIndex = 62
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(9, 92)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(156, 22)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Stationery address"
        '
        'txtstationeryphone
        '
        Me.txtstationeryphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstationeryphone.Location = New System.Drawing.Point(174, 158)
        Me.txtstationeryphone.Name = "txtstationeryphone"
        Me.txtstationeryphone.Size = New System.Drawing.Size(252, 28)
        Me.txtstationeryphone.TabIndex = 59
        '
        'txtstationerygmail
        '
        Me.txtstationerygmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstationerygmail.Location = New System.Drawing.Point(174, 122)
        Me.txtstationerygmail.Name = "txtstationerygmail"
        Me.txtstationerygmail.Size = New System.Drawing.Size(252, 28)
        Me.txtstationerygmail.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(11, 161)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(143, 22)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Stationery Phone"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(11, 125)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 22)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Stationery Gmail"
        '
        'txtstationeryname
        '
        Me.txtstationeryname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstationeryname.Location = New System.Drawing.Point(174, 57)
        Me.txtstationeryname.Name = "txtstationeryname"
        Me.txtstationeryname.Size = New System.Drawing.Size(252, 28)
        Me.txtstationeryname.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(11, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 22)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "Stationery name"
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(636, 274)
        Me.txtchange.Multiline = True
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(201, 22)
        Me.txtchange.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(474, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Change"
        '
        'txtcashreceived
        '
        Me.txtcashreceived.Location = New System.Drawing.Point(636, 243)
        Me.txtcashreceived.Multiline = True
        Me.txtcashreceived.Name = "txtcashreceived"
        Me.txtcashreceived.Size = New System.Drawing.Size(201, 22)
        Me.txtcashreceived.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(474, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 22)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Cash Received"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 430)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1562, 224)
        Me.DataGridView1.TabIndex = 46
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Location = New System.Drawing.Point(637, 215)
        Me.txtgrandtotal.Multiline = True
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(201, 22)
        Me.txtgrandtotal.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(475, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 22)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Grand Total"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0.0", "0.2", "0.15", "0.1", "5", "10", "15", "20", "25", "30", "35", "50"})
        Me.ComboBox1.Location = New System.Drawing.Point(637, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 28)
        Me.ComboBox1.TabIndex = 43
        '
        'txtdiscountamt
        '
        Me.txtdiscountamt.Location = New System.Drawing.Point(637, 187)
        Me.txtdiscountamt.Multiline = True
        Me.txtdiscountamt.Name = "txtdiscountamt"
        Me.txtdiscountamt.Size = New System.Drawing.Size(201, 22)
        Me.txtdiscountamt.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(474, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 22)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Discount Percent"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(474, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 22)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Discount Amt"
        '
        'btnbillpreview
        '
        Me.btnbillpreview.AutoRoundedCorners = True
        Me.btnbillpreview.BorderRadius = 19
        Me.btnbillpreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnbillpreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnbillpreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnbillpreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnbillpreview.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbillpreview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbillpreview.ForeColor = System.Drawing.Color.White
        Me.btnbillpreview.Location = New System.Drawing.Point(616, 366)
        Me.btnbillpreview.Name = "btnbillpreview"
        Me.btnbillpreview.Size = New System.Drawing.Size(160, 41)
        Me.btnbillpreview.TabIndex = 36
        Me.btnbillpreview.Text = "Bill Preview"
        '
        'txtavailableqty
        '
        Me.txtavailableqty.Location = New System.Drawing.Point(637, 59)
        Me.txtavailableqty.Multiline = True
        Me.txtavailableqty.Name = "txtavailableqty"
        Me.txtavailableqty.Size = New System.Drawing.Size(201, 22)
        Me.txtavailableqty.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(473, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 22)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Available Qty"
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(189, 82)
        Me.txtcustomername.Multiline = True
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(254, 22)
        Me.txtcustomername.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(24, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 22)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Customer_Name"
        '
        'txtcustomerphone
        '
        Me.txtcustomerphone.Location = New System.Drawing.Point(189, 140)
        Me.txtcustomerphone.Multiline = True
        Me.txtcustomerphone.Name = "txtcustomerphone"
        Me.txtcustomerphone.Size = New System.Drawing.Size(252, 22)
        Me.txtcustomerphone.TabIndex = 21
        '
        'txtcustomeraddress
        '
        Me.txtcustomeraddress.Location = New System.Drawing.Point(189, 110)
        Me.txtcustomeraddress.Multiline = True
        Me.txtcustomeraddress.Name = "txtcustomeraddress"
        Me.txtcustomeraddress.Size = New System.Drawing.Size(252, 22)
        Me.txtcustomeraddress.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 22)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Customer_Phone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(26, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Customer_Address"
        '
        'txtsearchbybillno
        '
        Me.txtsearchbybillno.Location = New System.Drawing.Point(1124, 332)
        Me.txtsearchbybillno.Multiline = True
        Me.txtsearchbybillno.Name = "txtsearchbybillno"
        Me.txtsearchbybillno.Size = New System.Drawing.Size(201, 22)
        Me.txtsearchbybillno.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(916, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Search By Bill No"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 19
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1345, 327)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(160, 41)
        Me.Guna2Button1.TabIndex = 16
        Me.Guna2Button1.Text = "Search"
        '
        'txtsearchbyproductname
        '
        Me.txtsearchbyproductname.Location = New System.Drawing.Point(1123, 278)
        Me.txtsearchbyproductname.Multiline = True
        Me.txtsearchbyproductname.Name = "txtsearchbyproductname"
        Me.txtsearchbyproductname.Size = New System.Drawing.Size(201, 22)
        Me.txtsearchbyproductname.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(915, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Search By Product Name"
        '
        'btndelete
        '
        Me.btndelete.AutoRoundedCorners = True
        Me.btndelete.BorderRadius = 19
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(420, 366)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(160, 41)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        '
        'btnupdate
        '
        Me.btnupdate.AutoRoundedCorners = True
        Me.btnupdate.BorderRadius = 19
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(236, 366)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(160, 41)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        '
        'btnclear
        '
        Me.btnclear.AutoRoundedCorners = True
        Me.btnclear.BorderRadius = 19
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(815, 366)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(160, 41)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        '
        'btninsert
        '
        Me.btninsert.AutoRoundedCorners = True
        Me.btninsert.BorderRadius = 19
        Me.btninsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btninsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btninsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btninsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btninsert.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btninsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(45, 366)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(160, 41)
        Me.btninsert.TabIndex = 9
        Me.btninsert.Text = "Insert"
        '
        'btnsearch
        '
        Me.btnsearch.AutoRoundedCorners = True
        Me.btnsearch.BorderRadius = 19
        Me.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Location = New System.Drawing.Point(1345, 269)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(160, 41)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(189, 231)
        Me.txtrate.Multiline = True
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(252, 22)
        Me.txtrate.TabIndex = 2
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(637, 93)
        Me.txtunit.Multiline = True
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(201, 22)
        Me.txtunit.TabIndex = 2
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(189, 199)
        Me.txtproductname.Multiline = True
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(252, 22)
        Me.txtproductname.TabIndex = 2
        '
        'txtbillno
        '
        Me.txtbillno.Location = New System.Drawing.Point(189, 54)
        Me.txtbillno.Multiline = True
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(252, 22)
        Me.txtbillno.TabIndex = 2
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(637, 124)
        Me.txttotalprice.Multiline = True
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(201, 22)
        Me.txttotalprice.TabIndex = 2
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(189, 171)
        Me.txtproductid.Multiline = True
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(252, 22)
        Me.txtproductid.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(2, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1582, 42)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "SALES DETAILS"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(474, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(474, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bill No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID"
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
        'PrintDocument1
        '
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents txtunit As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents txttotalprice As TextBox
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btninsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtsearchbyproductname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsearchbybillno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcustomerphone As TextBox
    Friend WithEvents txtcustomeraddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtavailableqty As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnbillpreview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtdiscountamt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcashreceived As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtstationeryaddress As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtstationeryphone As TextBox
    Friend WithEvents txtstationerygmail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtstationeryname As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtstationeryid As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents btnsearchbystationeryid As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
