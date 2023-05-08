Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        userbox.Clear()
        passbox.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If String.IsNullOrEmpty(userbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If
        If String.IsNullOrEmpty(passbox.Text) Then
            MessageBox.Show("Please fill the Last Name")
            Return
        End If

        'variavle for counting attempt
        Dim attempt As Integer = 0
        'correct login info
        If (userbox.Text = "fuse" And passbox.Text = "admin") Then
            dashboard.Show()
            Me.Hide()

        ElseIf (userbox.Text IsNot "fuse" And passbox.Text IsNot "admin") Then
            userbox.Clear()
            userbox.Focus()
            passbox.Clear()
            attempt += 1
            MessageBox.Show("WARNING: INVALID INPUT!!!")

            'final attempt before system error
            If attempt = 5 Then
                passbox.Enabled = False
                userbox.Enabled = False
                loginbtn.Enabled = False
                MessageBox.Show("ERROR: TOO MANY ATTEMPS!!")
            End If
        End If
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

End Class
