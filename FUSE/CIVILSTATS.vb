Imports System.Data.SqlClient
Public Class CIVILSTATS
    Dim conn As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
    Sub Singlecount()
        conn.Open()
        Dim cmdSingle As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE CIVILSTATUS = 'SINGLE'", conn)
        Dim countSingle = Convert.ToString(cmdSingle.ExecuteScalar)
        Singlecnt.Text = countSingle
        conn.Close()
    End Sub

    Sub Marriedcount()
        conn.Open()
        Dim cmdMarried As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE CIVILSTATUS = 'MARRIED'", conn)
        Dim countMarried = Convert.ToString(cmdMarried.ExecuteScalar)
        Mrdcnt.Text = countMarried
        conn.Close()
    End Sub

    Sub Separatedcount()
        conn.Open()
        Dim cmdSeparated = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE CIVILSTATUS = 'SEPARATED'", conn)
        Dim countSeparated = Convert.ToString(cmdSeparated.ExecuteScalar)
        Sepcnt.Text = countSeparated
        conn.Close()
    End Sub

    Sub Widowedcount()
        conn.Open()
        Dim cmdWidowed = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE CIVILSTATUS = 'WIDOWED'", conn)
        Dim countWidowed = Convert.ToString(cmdWidowed.ExecuteScalar)
        Widcnt.Text = countWidowed
        conn.Close()
    End Sub

    Private Sub Returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub

    Private Sub CIVILSTATS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Singlecount()
        Marriedcount()
        Separatedcount()
        Widowedcount()
    End Sub

    Private Sub agebtn_Click(sender As Object, e As EventArgs) Handles agebtn.Click
        DEMOGRAPHICS.Show()
        Me.Close()
    End Sub

    Private Sub purokbtn_Click(sender As Object, e As EventArgs) Handles purokbtn.Click
        PUROKSTATS.Show()
        Me.Close()
    End Sub

    Private Sub aboutbtn_Click(sender As Object, e As EventArgs) Handles aboutbtn.Click
        OVERVIEW.Show()
        Me.Close()
    End Sub
End Class