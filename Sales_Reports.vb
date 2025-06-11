Public Class Sales_Reports
    Public Sub BindGD()
        qr = "Select * from Sales_Record"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Sales_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGD()
    End Sub

    Private Sub btnsearchbybillno_Click(sender As Object, e As EventArgs) Handles btnsearchbybillno.Click
        qr = "Select * from Sales_Record where Bill_no = '" & txtbillno.Text & "'"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        BindGridview()
        txtbillno.Clear()
    End Sub
    Public Sub BindGridview()
        qr = "Select * from Sales_Record"
        ds = SearchData(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not Found", MsgBoxStyle.Critical)
        End If
    End Sub
End Class