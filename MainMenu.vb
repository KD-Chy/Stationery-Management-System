Public Class Main_Menu
    Sub switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        switchpanel(Sales)
    End Sub

    Private Sub btnpurchase_Click(sender As Object, e As EventArgs) Handles btnpurchase.Click
        switchpanel(Purchases)
    End Sub

    Private Sub btnstockinventory_Click(sender As Object, e As EventArgs) Handles btnstockinventory.Click
        switchpanel(Stock_Info)
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnsalesreport.Click
        switchpanel(Sales_Reports)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchpanel(Change_Password)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchpanel(Stock_Reports)
    End Sub

    Private Sub txtuserdetail_Click(sender As Object, e As EventArgs) Handles txtuserdetail.Click
        switchpanel(User_Details)
    End Sub

    Private Sub btnstationerydetails_Click(sender As Object, e As EventArgs) Handles btnstationerydetails.Click
        switchpanel(Stationery_Details)
    End Sub
End Class