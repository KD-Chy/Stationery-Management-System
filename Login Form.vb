
Imports System.Data.SqlClient

Public Class loginForm



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (IsFormvalid()) Then
            qr = "Select * from userlogin where username='" & txtusername.Text & "' and password ='" & txtpassword.Text & " ' "
            ds = SearchData(qr)
            If (ds.Tables(0).Rows.Count > 0) Then
                MsgBox("Login Successfully", MsgBoxStyle.Information)
                Main_Menu.Show()
                txtusername.Clear()
                txtpassword.Clear()


                Me.Hide()
            Else
                MsgBox("Please check your credentials", MsgBoxStyle.Critical)
                txtusername.Clear()
                txtpassword.Clear()
            End If

        End If

    End Sub

    Private Function IsFormvalid() As Boolean
        If (txtusername.Text.Trim() = String.Empty) Then
            MsgBox("Username is Required", MsgBoxStyle.Critical)
            txtusername.Clear()
            txtpassword.Clear()

            Return False
        End If
        If (txtpassword.Text.Trim() = String.Empty) Then
            MsgBox("Password is Required", MsgBoxStyle.Critical)
            txtusername.Clear()
            txtpassword.Clear()

            Return False
        End If
        Return True

    End Function
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub forgetPasswordBtn_Click(sender As Object, e As EventArgs) Handles forgetPasswordBtn.Click
        forgetPassword.Show()
    End Sub




End Class
