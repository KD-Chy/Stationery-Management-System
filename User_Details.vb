Public Class User_Details
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If (IsFormvalid()) Then
            qr = "Insert into userLogin values('" & txtfullname.Text & " ','" & txtgender.Text & "','" & txtaddress.Text & "','" & txtphoneno.Text & " ','" & txtusername.Text & "','" & txtpassword.Text & "','" & txtusertype.Text & "','" & txtemail.Text & "','" & DateTime.Now & "')"
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
    Public Sub BindGridview()
        qr = "Select * from userLogin"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function IsFormvalid() As Boolean
        If (txtusername.Text.Trim() = String.Empty) Then
            MsgBox("User Name is Required", MsgBoxStyle.Critical)

            txtusername.Clear()


            Return False
        End If
        Return True
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        If (i >= 0) Then
            Me.txtuserid.Text = DataGridView1.Item(0, i).Value
            Me.txtfullname.Text = DataGridView1.Item(1, i).Value
            Me.txtgender.Text = DataGridView1.Item(2, i).Value
            Me.txtaddress.Text = DataGridView1.Item(3, i).Value
            Me.txtphoneno.Text = DataGridView1.Item(4, i).Value
            Me.txtusername.Text = DataGridView1.Item(5, i).Value
            Me.txtpassword.Text = DataGridView1.Item(6, i).Value
            Me.txtusertype.Text = DataGridView1.Item(7, i).Value
            Me.txtemail.Text = DataGridView1.Item(8, i).Value
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If (IsFormvalid()) Then
            qr = "Update userLogin set Fullname='" & txtfullname.Text & "',Gender='" & txtgender.Text & "', Address='" & txtaddress.Text & "', Phone_no='" & txtphoneno.Text & "', username='" & txtusername.Text & "', password='" & txtpassword.Text & "', userType='" & txtusertype.Text & "', Email='" & txtemail.Text & "'where userID='" & Convert.ToInt32(txtuserid.Text) & "'"
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
                qr = "Delete from userLogin where userID= '" & Convert.ToInt32(txtuserid.Text) & " '"
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
        If (txtuserid.Text.Trim() = String.Empty) Then
            MsgBox("User_ID is Required", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtuserid.Clear()
        txtfullname.Clear()
        txtgender.Clear()
        txtaddress.Clear()
        txtphoneno.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtusertype.Clear()
        txtemail.Clear()
        BindGridview()
    End Sub
    Public Sub clr()
        BindGridview()
        txtuserid.Clear()
        txtfullname.Clear()
        txtgender.Clear()
        txtaddress.Clear()
        txtphoneno.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtusertype.Clear()
        txtemail.Clear()
    End Sub

    Private Sub User_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGridview()
    End Sub
End Class