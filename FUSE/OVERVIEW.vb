Public Class OVERVIEW
    Private Sub civilbtn_Click(sender As Object, e As EventArgs) Handles civilbtn.Click
        CIVILSTATS.Show()
        Me.Close()
    End Sub

    Private Sub purokbtn_Click(sender As Object, e As EventArgs) Handles purokbtn.Click
        PUROKSTATS.Show()
        Me.Close()
    End Sub

    Private Sub agebtn_Click(sender As Object, e As EventArgs) Handles agebtn.Click
        DEMOGRAPHICS.Show()
        Me.Close()
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub
End Class