Public Class Stock_Info

    Public Sub BindGridview()
        qr = "Select * from Stock_Availability"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        BindGridview()
        txtproductid.Clear()
        txtproductname.Clear()
        txtrate.Clear()
        txtavailableqty.Clear()
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

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        qr = "Update Stock_Availability set Product_Name= '" & txtproductname.Text & " ',Rate='" & txtrate.Text & "',Quantity='" & txtqty.Text & "',total_Price='" & txttotalprice.Text & "',Available_Qty='" & txtavailableqty.Text & "'where Product_ID = '" & Convert.ToInt32(txtproductid.Text) & " ' "
        Dim isUpdatetrue As Boolean = Convert.ToBoolean(Insertdata(qr))
        If (isUpdatetrue) Then

            MsgBox("Update Succesfully..", MsgBoxStyle.Information)
            BindGridview()
            clr()
        Else
            MsgBox("Error! record not Updated", MsgBoxStyle.Critical)
            clr()
        End If


    End Sub
    Public Sub clr()
        txtproductid.Clear()
        txtproductname.Clear()
        txtrate.Clear()
        txtavailableqty.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As Integer = MsgBox("Do you really want to Delete record..?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If (IsFormvalid2()) Then
                qr = "Delete from Stock_Availability where Product_ID= '" & Convert.ToInt32(txtproductid.Text) & " '"
                Dim WantToDelete As Boolean = Convert.ToBoolean(Insertdata(qr))
                If (WantToDelete) Then

                    MsgBox("Delete Succesfully..", MsgBoxStyle.Information)
                    BindGridview()
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

        End If
    End Sub


End Class