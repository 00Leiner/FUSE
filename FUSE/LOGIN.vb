Public Class LOGIN
    Dim attempt As Integer = 0
    Private Sub exitlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles exitlink.LinkClicked
        Application.Exit()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        'correct login info
        If (userbox.Text = "fuse" And passbox.Text = "admin") Then
            DASHBOARD.Show()
            Me.Hide()
            passbox.Text = ""
            userbox.Text = ""

        ElseIf (userbox.Text IsNot "fuse" And passbox.Text IsNot "admin") Then
            passbox.Text = ""
            userbox.Text = ""
            userbox.Clear()
            userbox.Focus()
            attempt += 1
            MessageBox.Show("WARNING: INVALID INPUT!!!")

            'final attempt before system error
            If attempt = 5 Then
                passbox.Text = ""
                passbox.Enabled = False
                userbox.Enabled = False
                loginbtn.Enabled = False
                MessageBox.Show("ERROR: TOO MANY ATTEMPS!!")
            End If
        End If
    End Sub
End Class
