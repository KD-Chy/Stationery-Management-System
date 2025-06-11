Imports System.Data.SqlClient

Public Class Change_Password
    Private Sub Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtconfirm_Click(sender As Object, e As EventArgs) Handles txtconfirm.Click
        Dim con As New SqlConnection("Data Source=SUSHILAKARAN;Initial Catalog=stationeryRecordKeepingSystem;Integrated Security=True")
        If txtnewpassword.Text = txtconfirmpassword.Text Then

            Try

                con.Open()
                Dim cmd As New SqlCommand("changePassword", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@newpassword", txtnewpassword.Text)
                    .Parameters.AddWithValue("@oldpassword", txtoldpassword.Text)

                    .ExecuteNonQuery()

                End With
                con.Close()
                MsgBox("Password changed succesfully", vbInformation, vbOK)
                txtoldpassword.Clear()
                txtnewpassword.Clear()
                txtconfirmpassword.Clear()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try

        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            txtoldpassword.UseSystemPasswordChar = False
        Else
            txtoldpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtnewpassword.UseSystemPasswordChar = False
        Else
            txtnewpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            txtconfirmpassword.UseSystemPasswordChar = False
        Else
            txtconfirmpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtcancel_Click(sender As Object, e As EventArgs) Handles txtcancel.Click
        Me.Close()
    End Sub
End Class