Public Class Purchases

    Public Sub BindGridview()
        qr = "Select * from Stock_Availability"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnpurchase_Click_1(sender As Object, e As EventArgs) Handles btnpurchase.Click

        If (IsFormvalid()) Then
            qr = "Insert into Stock_Availability values('" & txtproductname.Text & " ','" & txtrate.Text & "','" & txtqty.Text & "','" & txttotalprice.Text & "','" & txtavailableqty.Text & "','" & DateTime.Now & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(Insertdata(qr))
            If (logincorrect) Then

                MsgBox("Saved Succesfully..", MsgBoxStyle.Information)
                updatestock()
                BindGridview()

                clr()
            Else
                MsgBox("Error! record not saved", MsgBoxStyle.Critical)
            End If
        End If
    End Sub


    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        BindGridview()
        txtproductid.Clear()
        txtproductname.Clear()
        txtrate.Clear()
        txtqty.Clear()
        txtavailableqty.Clear()
        txttotalprice.Clear()
        txtsearchbyname.Clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        qr = "Select * from Stock_Availability where Product_Name = '" & txtsearchbyname.Text & " '"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub



    Public Sub clr()

        txtproductid.Clear()
        txtproductname.Clear()
        txtrate.Clear()

        txtqty.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As Integer = MsgBox("Do you really want to Delete record..?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If (IsFormvalid2()) Then
                qr = "Delete from Stock_Availability where Product_ID= '" & Convert.ToInt32(txtproductid.Text) & " '"
                Dim WantToDelete As Boolean = Convert.ToBoolean(Insertdata(qr))
                If (WantToDelete) Then
                    BindGridview()
                    MsgBox("Delete Succesfully..", MsgBoxStyle.Information)
                    clr()
                Else
                    MsgBox("Error! record not Deleted", MsgBoxStyle.Critical)
                    clr()
                End If
            End If
        End If
    End Sub

    Private Function IsFormvalid2() As Boolean
        If (txtproductid.Text.Trim() = String.Empty) Then
            MsgBox("Product_ID is Required", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub Stock_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGridview()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtproductid.Text = DataGridView1.Item(0, i).Value
            Me.txtproductname.Text = DataGridView1.Item(1, i).Value
            Me.txtrate.Text = DataGridView1.Item(2, i).Value
            Me.txtqty.Text = DataGridView1.Item(3, i).Value
            Me.txttotalprice.Text = DataGridView1.Item(4, i).Value
            Me.txtavailableqty.Text = DataGridView1.Item(5, i).Value
            BindGridview()
        End If
    End Sub

    Private Sub btnpurchase_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function IsFormvalid() As Boolean
        If (txtproductname.Text.Trim() = String.Empty) Then
            MsgBox("Stock_Availability is Required", MsgBoxStyle.Critical)

            txtproductname.Clear()


            Return False
        End If

        If (txtrate.Text.Trim() = String.Empty) Then
            MsgBox("Rate is Required", MsgBoxStyle.Critical)
            txtrate.Text = ""

            Return False
        End If

        Return True

    End Function
    Public Sub updatestock()
        Dim a As String
        a = Val(txtqty.Text) + Val(txtavailableqty.Text)
        qr = "Update Stock_Availability set Available_Qty='" & a & "'where Product_Name = '" & txtproductname.Text & " '"
        Dim isUpdatetrue As Boolean = Convert.ToBoolean(Insertdata(qr))
        If (isUpdatetrue) Then
            ' BindGridview()
            MsgBox("Update Succesfully..", MsgBoxStyle.Information)
            BindGridview()

        Else
            MsgBox("Error! record not Updated", MsgBoxStyle.Critical)

        End If

    End Sub
    Private Sub txttotalprice_TextChanged(sender As Object, e As EventArgs) Handles txttotalprice.TextChanged
        If txttotalprice.Text.Trim() = "" Then

        Else
            txttotalprice.Text = Val(txtrate.Text) * Val(txtqty.Text)

        End If
    End Sub





End Class