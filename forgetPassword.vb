Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Web.UI.WebControls

Public Class forgetPassword
    Dim con As New SqlConnection("Data Source=SUSHILAKARAN;Initial Catalog=stationeryRecordKeepingSystem;Integrated Security=True")
    Dim verificationcode As String = "asdfgh"
    Dim username As String = "kdchy12515@gmail.com"
    Dim password As String = "xqcl kagd vews akme"
    Dim emailhold As String
    Private Sub emailbox_Enter(sender As Object, e As EventArgs) Handles emailbox.Enter
        If emailbox.Text = "kdchy12515@gmail.com" Then
            emailbox.ForeColor = Color.Black
            emailbox.Text = ""
        End If
    End Sub

    Private Sub emailbox_Leave(sender As Object, e As EventArgs) Handles emailbox.Leave
        If emailbox.Text = "" Then
            emailbox.ForeColor = Color.DarkGray
            emailbox.Text = "kdchy12515@gmail.com"
        End If
    End Sub
    Private Sub getcodebtn_Click(sender As Object, e As EventArgs) Handles getcodebtn.Click
        Try

            con.Open()
            Dim cmd As New SqlCommand("forgetPassword", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@email", emailbox.Text)

                .Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                .ExecuteScalar()

                If CInt(.Parameters("@result").Value = 1) Then
                    emailhold = emailbox.Text

                    Dim rand As New Random()
                    verificationcode = rand.Next(1000000).ToString("D6")
                    Try


                        Dim fromaddress As New MailAddress("noreply@biratsoftware.com", "Birat Software")
                        Dim toaddress As New MailAddress(emailbox.Text)
                        Dim subject As String = "Verify your email address to change the password"
                        Dim body As String = String.Format("Please use the following code to verify your email: {0} for more contact at kdchy12515@gmail.com", verificationcode)

                        Dim smtp As New SmtpClient()
                        smtp.Host = "smtp.gmail.com"
                        smtp.Port = 587
                        smtp.EnableSsl = True
                        smtp.Credentials = New NetworkCredential(username, password)
                        Dim message As New MailMessage(fromaddress, toaddress)
                        message.Subject = subject
                        message.Body = body
                        smtp.Send(message)
                        MsgBox("OTP sent successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                        otpbox1.Focus()

                    Catch ex As Exception
                        MsgBox("failed to send the verrification email: " & ex.Message)

                    End Try


                Else
                    MsgBox("please enter the registered email", vbCritical, MsgBoxStyle.OkOnly)
                    emailbox.ForeColor = Color.DarkGray
                    emailbox.Text = "Email_Address"
                End If

            End With
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub verifyotpbtn_Click(sender As Object, e As EventArgs) Handles verifyotpbtn.Click
        Dim code As String = verificationcode
        If code = otpbox1.Text + otpbox2.Text + otpbox3.Text + otpbox4.Text + otpbox5.Text + otpbox6.Text Then
            verificationcode = "asdfgh"

            otpbox1.ResetText()
            otpbox2.ResetText()
            otpbox3.ResetText()
            otpbox4.ResetText()
            otpbox5.ResetText()
            otpbox6.ResetText()
            forgetpassmainpanel.Hide()

            changepasswordpanel.Show()

        Else

            MsgBox("please enter the valid code", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub confirmpassbtn_Click(sender As Object, e As EventArgs) Handles confirmpassbtn.Click
        If changepassbox.Text = confirmnewpasschange.Text Then

            Try

                con.Open()
                cmd = New SqlCommand("resetPassword", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@password", confirmnewpasschange.Text)
                    .Parameters.AddWithValue("@email", emailbox.Text)

                    .ExecuteNonQuery()

                End With
                con.Close()
                MsgBox("Password changed succesfully", vbInformation, vbOK)
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try

        End If
    End Sub


    Private Sub otpbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox3.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox3.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox4.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox3.Text = ""
            otpbox2.Focus()
        End If
    End Sub


    Private Sub otpbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox4.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox4.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox5.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox4.Text = ""
            otpbox3.Focus()
        End If
    End Sub


    Private Sub otpbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox5.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox5.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox6.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox5.Text = ""
            otpbox4.Focus()
        End If
    End Sub


    Private Sub otpbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox6.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox6.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox6.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox6.Text = ""
            otpbox5.Focus()
        End If
    End Sub

    Private Sub cancelpasschangebtn_Click(sender As Object, e As EventArgs) Handles cancelpasschangebtn.Click
        loginForm.Show()
        Me.Close()
    End Sub



    Private Sub backtologinbtn_Click(sender As Object, e As EventArgs)
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub forgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changepasswordpanel.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            changepassbox.UseSystemPasswordChar = False
        Else
            changepassbox.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked Then
            confirmnewpasschange.UseSystemPasswordChar = False
        Else
            confirmnewpasschange.UseSystemPasswordChar = True
        End If

    End Sub
End Class