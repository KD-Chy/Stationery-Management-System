Public Class Stationery_Details
    Public Sub BindGridview()
        qr = "Select * from Stationery"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If (IsFormvalid()) Then
            qr = "Insert into Stationery values('" & txtstationeryname.Text & " ','" & txtstationeryaddress.Text & "','" & txtstationeryemail.Text & "','" & txtstationeryphone.Text & " ','" & DateTime.Now & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(Insertdata(qr))
            If (logincorrect) Then
                BindGridview()
                MsgBox("Saved Succesfully..", MsgBoxStyle.Information)

                clr()
            Else
                MsgBox("Error! record not saved", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Function IsFormvalid() As Boolean
        If (txtstationeryname.Text.Trim() = String.Empty) Then
            MsgBox("Stationery Name is Required", MsgBoxStyle.Critical)

            txtstationeryname.Clear()


            Return False
        End If
        If (txtstationeryaddress.Text.Trim() = String.Empty) Then
            MsgBox("Stationery Address is Required", MsgBoxStyle.Critical)

            txtstationeryaddress.Clear()


            Return False
        End If
        If (txtstationeryemail.Text.Trim() = String.Empty) Then
            MsgBox("Stationery Email is Required", MsgBoxStyle.Critical)

            txtstationeryemail.Clear()


            Return False
        End If
        If (txtstationeryphone.Text.Trim() = String.Empty) Then
            MsgBox("Stationery Phone number is Required", MsgBoxStyle.Critical)

            txtstationeryphone.Clear()


            Return False
        End If
        Return True
    End Function

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If (IsFormvalid()) Then
            qr = "Update Stationery set Stationery_name='" & txtstationeryname.Text & "',Stationery_address='" & txtstationeryaddress.Text & "', Stationery_email='" & txtstationeryemail.Text & "', Stationery_phone='" & txtstationeryphone.Text & "'where Stationery_ID='" & Convert.ToInt32(txtstationeryid.Text) & " ' "
            Dim isUpdatetrue As Boolean = Convert.ToBoolean(Insertdata(qr))
            If (isUpdatetrue) Then
                BindGridview()
                MsgBox("Updated Succesfully..", MsgBoxStyle.Information)
                clr()
            Else
                MsgBox("Error! record not Edited", MsgBoxStyle.Critical)
                clr()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As Integer = MsgBox("Do you really want to Delete record..?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If (IsFormvalid2()) Then
                qr = "Delete from Stationery where Stationery_ID= '" & Convert.ToInt32(txtstationeryid.Text) & " '"
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
        If (txtstationeryid.Text.Trim() = String.Empty) Then
            MsgBox("Stationery_ID is Required", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtstationeryname.Clear()
        txtstationeryid.Clear()
        txtstationeryaddress.Clear()
        txtstationeryemail.Clear()
        txtstationeryphone.Clear()
        BindGridview()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtstationeryid.Text = DataGridView1.Item(0, i).Value
            Me.txtstationeryname.Text = DataGridView1.Item(1, i).Value
            Me.txtstationeryaddress.Text = DataGridView1.Item(2, i).Value
            Me.txtstationeryemail.Text = DataGridView1.Item(3, i).Value
            Me.txtstationeryphone.Text = DataGridView1.Item(4, i).Value
        End If
    End Sub
    Public Sub clr()

        txtstationeryname.Clear()
        txtstationeryid.Clear()
        txtstationeryaddress.Clear()
        txtstationeryemail.Clear()
        txtstationeryphone.Clear()
        BindGridview()
    End Sub

    Private Sub Stationery_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGridview()
    End Sub
End Class