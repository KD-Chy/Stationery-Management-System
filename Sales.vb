Imports System.Drawing.Printing

Public Class Sales
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If (IsFormvalid()) Then
            qr = "Insert into Sales values('" & txtcustomername.Text & " ','" & txtcustomeraddress.Text & " ','" & txtcustomerphone.Text & " ','" & txtproductid.Text & "','" & txtproductname.Text & "','" & txtrate.Text & " ','" & txtunit.Text & "','" & txttotalprice.Text & "','" & txtavailableqty.Text & "','" & DateTime.Now & "','" & txtcashreceived.Text & " ','" & txtchange.Text & " ','" & ComboBox1.Text & " ','" & txtdiscountamt.Text & "','" & txtgrandtotal.Text & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(Insertdata(qr))
            If (logincorrect) Then

                MsgBox("Saved Succesfully..", MsgBoxStyle.Information)
                BindGridview()
                updatestock()

                BindGD()


                clr()
            Else
                MsgBox("Error! record not saved", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Function IsFormvalid() As Boolean
        If (txtcustomername.Text.Trim() = String.Empty) Then
            MsgBox("Customer Name is Required", MsgBoxStyle.Critical)

            txtcustomername.Clear()


            Return False
        End If

        If (txtcustomeraddress.Text.Trim() = String.Empty) Then
            MsgBox("Customer Address is Required", MsgBoxStyle.Critical)
            txtcustomeraddress.Text = ""

            Return False
        End If
        If (txtcustomerphone.Text.Trim() = String.Empty) Then
            MsgBox("Customer Phone is Required", MsgBoxStyle.Critical)

            txtcustomerphone.Clear()


            Return False
        End If

        If (txtproductid.Text.Trim() = String.Empty) Then
            MsgBox("Product ID is Required", MsgBoxStyle.Critical)
            txtproductid.Text = ""

            Return False
        End If
        If (txtproductname.Text.Trim() = String.Empty) Then
            MsgBox("Product Name is Required", MsgBoxStyle.Critical)

            txtproductname.Clear()


            Return False
        End If

        If (txtrate.Text.Trim() = String.Empty) Then
            MsgBox("Rate is Required", MsgBoxStyle.Critical)
            txtrate.Text = ""

            Return False
        End If
        If (txtunit.Text.Trim() = String.Empty) Then
            MsgBox("Quantity is Required", MsgBoxStyle.Critical)

            txtunit.Clear()


            Return False
        End If

        If (txttotalprice.Text.Trim() = String.Empty) Then
            MsgBox("Total Amount is Required", MsgBoxStyle.Critical)
            txttotalprice.Text = ""

            Return False
        End If
        If (txtavailableqty.Text.Trim() = String.Empty) Then
            MsgBox("Available Quantity is Required", MsgBoxStyle.Critical)

            txtavailableqty.Clear()


            Return False
        End If



        Return True
    End Function

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If (IsFormvalid()) Then
            qr = "Update Sales set Customer_name =  '" & txtcustomername.Text & " ',Customer_address ='" & txtcustomeraddress.Text & " ',Customer_phone = '" & txtcustomerphone.Text & " ',Product_id = '" & txtproductid.Text & "',Product_name = '" & txtproductname.Text & "',Rate = '" & txtrate.Text & " ',Quantity = '" & txtunit.Text & "',Total_price = '" & txttotalprice.Text & "',Available_Qty = '" & txtavailableqty.Text & "',cash_Received = '" & txtcashreceived.Text & " ',changed = '" & txtchange.Text & " ',discount_Percent = '" & ComboBox1.Text & " ',discount_Amt = '" & txtdiscountamt.Text & "',grand_Total = '" & txtgrandtotal.Text & "' where Bill_no = '" & Convert.ToInt32(txtbillno.Text) & " ' "
            Dim isUpdatetrue As Boolean = Convert.ToBoolean(Insertdata(qr))
            If (isUpdatetrue) Then
                BindGridview()
                MsgBox("Update Succesfully..", MsgBoxStyle.Information)
                BindGD()
                clr()
            Else
                MsgBox("Error! record not Updated", MsgBoxStyle.Critical)
                clr()
            End If
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As Integer = MsgBox("Do you really want to Delete record..?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If (IsFormvalid2()) Then
                qr = "Delete from Sales where Bill_no= '" & Convert.ToInt32(txtbillno.Text) & " '"
                Dim WantToDelete As Boolean = Convert.ToBoolean(Insertdata(qr))
                If (WantToDelete) Then

                    MsgBox("Delete Succesfully..", MsgBoxStyle.Information)
                    BindGD()
                    clr()
                Else
                    MsgBox("Error! record not Deleted", MsgBoxStyle.Critical)
                    clr()
                End If
            End If
        End If
    End Sub

    Private Function IsFormvalid2() As Boolean
        If (txtbillno.Text.Trim() = String.Empty) Then
            MsgBox("Bill no. is Required", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        BindGD()
        clr()

    End Sub
    '..............................................................................................................for searching stock.......................................
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        qr = "Select * from Stock_Availability where Product_Name = '" & txtsearchbyproductname.Text & " '"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
            'BindGridview()

        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtproductid.Text = DataGridView1.Item(0, i).Value
            Me.txtproductname.Text = DataGridView1.Item(1, i).Value
            Me.txtrate.Text = DataGridView1.Item(2, i).Value
            Me.txtavailableqty.Text = DataGridView1.Item(5, i).Value
            BindGD()
        End If

    End Sub
    Public Sub BindGridview()
        qr = "Select * from Stock_Availability"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
    '................................................................................................................................................................................
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BindGridview()

        BindGD()
    End Sub


    Public Sub BindGD()
        qr = "Select * from Sales"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        qr = "Select * from Sales where Bill_no = '" & txtsearchbybillno.Text & " '"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtbillno.Text = DataGridView1.Item(0, i).Value
            Me.txtcustomername.Text = DataGridView1.Item(1, i).Value
            Me.txtcustomeraddress.Text = DataGridView1.Item(2, i).Value
            Me.txtcustomerphone.Text = DataGridView1.Item(3, i).Value
            Me.txtproductid.Text = DataGridView1.Item(4, i).Value
            Me.txtproductname.Text = DataGridView1.Item(5, i).Value
            Me.txtrate.Text = DataGridView1.Item(6, i).Value
            Me.txtunit.Text = DataGridView1.Item(7, i).Value
            Me.txttotalprice.Text = DataGridView1.Item(8, i).Value
            Me.txtavailableqty.Text = DataGridView1.Item(9, i).Value
            Me.txtcashreceived.Text = DataGridView1.Item(11, i).Value
            Me.txtchange.Text = DataGridView1.Item(12, i).Value
            Me.ComboBox1.Text = DataGridView1.Item(13, i).Value
            Me.txtdiscountamt.Text = DataGridView1.Item(14, i).Value
            Me.txtgrandtotal.Text = DataGridView1.Item(15, i).Value
        End If
    End Sub
    Public Sub clr()
        txtbillno.Clear()
        txtcustomername.Clear()
        txtcustomeraddress.Clear()
        txtcustomerphone.Clear()
        txtproductid.Clear()
        txtproductname.Clear()
        txtrate.Clear()
        txtunit.Clear()
        txttotalprice.Clear()
        txtavailableqty.Clear()
        txtsearchbybillno.Clear()
        txtcashreceived.Clear()
        txtchange.Clear()
        ComboBox1.Text = ""
        txtdiscountamt.Clear()
        txtgrandtotal.Clear()
        txtstationeryname.Clear()
        txtstationeryaddress.Clear()
        txtstationerygmail.Clear()
        txtstationeryphone.Clear()
        txtstationeryid.Clear()
    End Sub
    Private Sub txttotalprice_TextChanged(sender As Object, e As EventArgs) Handles txttotalprice.TextChanged
        If txttotalprice.Text.Trim() = "" Then

        Else
            txttotalprice.Text = Val(txtrate.Text) * Val(txtunit.Text)

        End If
    End Sub
    Private Sub txtgrandtotal_TextChanged_1(sender As Object, e As EventArgs) Handles txtgrandtotal.TextChanged
        txtgrandtotal.Text = Val(txttotalprice.Text) - Val(txtdiscountamt.Text)
    End Sub
    'Private Sub txtcashreceived_KeyUp(sender As Object, e As KeyEventArgs)
    '    Dim tot, rcash, num As Integer
    '    tot = Val(txtgrandtotal.Text)
    '    rcash = Val(txtcashreceived.Text)
    '    If rcash = tot Then
    '        txtchange.Text = 0
    '    ElseIf rcash > tot Then
    '        num = rcash - tot
    '        'MsgBox ("Not Enough Cash.....")
    '        txtchange.Text = num.ToString
    '    ElseIf rcash < tot Then
    '        num = rcash - tot
    '        txtchange.Text = num.ToString
    '    End If
    'End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("" + txtstationeryname.Text, New Font("Times New Roman", 30, FontStyle.Bold), Brushes.Black, New Point(300, 20))
        e.Graphics.DrawString("" + txtstationeryaddress.Text, New Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, New Point(250, 60))
        e.Graphics.DrawString("" + txtstationerygmail.Text, New Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, New Point(280, 100))
        e.Graphics.DrawString("Phone number: " + txtstationeryphone.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(300, 135))
        e.Graphics.DrawString("Date: " + DateTime.Now, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 165))
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------", New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 180))

        e.Graphics.DrawString("Bill_no: " + txtbillno.Text, New Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, New Point(20, 20))
        e.Graphics.DrawString("Customer_name: " + txtcustomername.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 200))
        e.Graphics.DrawString("Customer_address: " + txtcustomeraddress.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 240))
        e.Graphics.DrawString("Customer_phone: " + txtcustomerphone.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 280))
        e.Graphics.DrawString("Product_name: " + txtproductname.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 320))
        e.Graphics.DrawString("Rate: " + txtrate.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 360))
        e.Graphics.DrawString("Unit: " + txtunit.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 400))
        e.Graphics.DrawString("Discount_amount: " + txtdiscountamt.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 440))
        e.Graphics.DrawString("Cash_received: " + txtcashreceived.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 480))

        e.Graphics.DrawString("Change: " + txtchange.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 520))
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------", New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 560))

        e.Graphics.DrawString("Total Price: " + txttotalprice.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, New Point(20, 575))
    End Sub


    Private Sub btnbillpreview_Click(sender As Object, e As EventArgs) Handles btnbillpreview.Click
        If (txtstationeryname.Text = " ") Then
            MsgBox("Stationery Name is Required", MsgBoxStyle.Critical)

            txtstationeryname.Focus()



        End If

        If (txtstationeryaddress.Text = " ") Then
            MsgBox("Stationery Address is Required", MsgBoxStyle.Critical)
            txtstationeryaddress.Focus()


        End If
        If (txtstationeryphone.Text = " ") Then
            MsgBox("Stationery Phone is Required", MsgBoxStyle.Critical)

            txtstationeryphone.Focus()



        End If

        If (txtstationerygmail.Text = " ") Then
            MsgBox("Stationery gmail is Required", MsgBoxStyle.Critical)
            txtstationerygmail.Focus()

        Else

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub




    Public Sub updatestock()
        Dim a As String
        a = Val(txtavailableqty.Text) - Val(txtunit.Text)
        qr = "Update Stock_Availability set Available_Qty='" & a & "'where Product_Name = '" & txtproductname.Text & " '"
        Dim isUpdatetrue As Boolean = Convert.ToBoolean(Insertdata(qr))
        If (isUpdatetrue) Then
            MsgBox("Update Succesfully..", MsgBoxStyle.Information)
            BindGD()
        Else
            MsgBox("Error! record not Updated", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtbillno.Text = DataGridView1.Item(0, i).Value
            Me.txtcustomername.Text = DataGridView1.Item(1, i).Value
            Me.txtcustomeraddress.Text = DataGridView1.Item(2, i).Value
            Me.txtcustomerphone.Text = DataGridView1.Item(3, i).Value
            Me.txtproductid.Text = DataGridView1.Item(4, i).Value
            Me.txtproductname.Text = DataGridView1.Item(5, i).Value
            Me.txtrate.Text = DataGridView1.Item(6, i).Value
            Me.txtunit.Text = DataGridView1.Item(7, i).Value
            Me.txttotalprice.Text = DataGridView1.Item(8, i).Value
            Me.txtavailableqty.Text = DataGridView1.Item(9, i).Value
            Me.txtcashreceived.Text = DataGridView1.Item(11, i).Value
            Me.txtchange.Text = DataGridView1.Item(12, i).Value
            Me.ComboBox1.Text = DataGridView1.Item(13, i).Value
            Me.txtdiscountamt.Text = DataGridView1.Item(14, i).Value
            Me.txtgrandtotal.Text = DataGridView1.Item(15, i).Value

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dispercent As Double
        If ComboBox1.Text > 0 Then
            dispercent = Convert.ToDouble(Val(txttotalprice.Text) * Val(ComboBox1.Text) / 100)

            txttotalprice.Text = Val(txttotalprice.Text) - dispercent.ToString()
            txtdiscountamt.Text = dispercent.ToString()


        Else
            txttotalprice.Text = Val(txtrate.Text) * Val(txtunit.Text).ToString()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub txtchange_TextChanged(sender As Object, e As EventArgs) Handles txtchange.TextChanged
        txtchange.Text = Val(txtcashreceived.Text) - Val(txtgrandtotal.Text)
    End Sub

    Public Sub BindGridview2()
        qr = "Select * from Stationery"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnsearchbystationeryid_Click(sender As Object, e As EventArgs) Handles btnsearchbystationeryid.Click
        qr = "Select * from Stationery where Stationery_ID = '" & txtstationeryid.Text & " '"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
            'BindGridview()

        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtstationeryname.Text = DataGridView1.Item(1, i).Value
            Me.txtstationeryaddress.Text = DataGridView1.Item(2, i).Value
            Me.txtstationerygmail.Text = DataGridView1.Item(3, i).Value
            Me.txtstationeryphone.Text = DataGridView1.Item(4, i).Value
            BindGD()
        End If

    End Sub
End Class