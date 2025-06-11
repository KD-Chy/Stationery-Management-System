Public Class Stock_Reports

    Public Sub BindGD()
        qr = "Select * from Stock_Availability_Record"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnsearchbyproductname_Click(sender As Object, e As EventArgs) Handles btnsearchbyproductname.Click
        qr = "Select * from Stock_Availability_Record where Product_Name = '" & txtproductname.Text & "'"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Stock_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGD()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        BindGridview()
        txtproductname.Clear()

    End Sub
    Public Sub BindGridview()
        qr = "Select * from Stock_Availability_Record"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

End Class