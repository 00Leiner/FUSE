Imports System.Data.SqlClient

Public Class DEMOGRAPHICS
    Dim conn As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
    Private Sub hmbtn_Click(sender As Object, e As EventArgs) Handles hmbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub

    Private Sub purokbtn_Click(sender As Object, e As EventArgs) Handles purokbtn.Click
        PUROKSTATS.Show()
        Me.Close()
    End Sub
    Private Sub civilbtn_Click(sender As Object, e As EventArgs) Handles civilbtn.Click
        CIVILSTATS.Show()
        Me.Close()
    End Sub
    Private Sub overbtn_Click(sender As Object, e As EventArgs) Handles overbtn.Click
        OVERVIEW.Show()
        Me.Close()
    End Sub

    Sub Childcount()
        conn.Open()
        Dim cmdChild As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE DATEDIFF(YEAR, BIRTHDATE, GETDATE()) >= 0 AND DATEDIFF(YEAR, BIRTHDATE, GETDATE())<=10", conn)
        Dim countChild = Convert.ToString(cmdChild.ExecuteScalar)
        childcnt.Text = countChild
        conn.Close()
    End Sub

    Sub Youthcount()
        conn.Open()
        Dim cmdYouth As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE DATEDIFF(YEAR, BIRTHDATE, GETDATE()) >= 0 AND DATEDIFF(YEAR, BIRTHDATE, GETDATE()) <= 17", conn)
        Dim countYouth = Convert.ToString(cmdYouth.ExecuteScalar)
        adocnt.Text = countYouth
        conn.Close()
    End Sub

    Sub Adultcount()
        conn.Open()
        Dim cmdAdult = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE DATEDIFF(YEAR, BIRTHDATE, GETDATE()) >= 0 AND DATEDIFF(YEAR, BIRTHDATE, GETDATE()) <= 65", conn)
        Dim countAdult = Convert.ToString(cmdAdult.ExecuteScalar)
        adcnt.Text = countAdult
        conn.Close()
    End Sub

    Sub Eldercount()
        conn.Open()
        Dim cmdElder = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE DATEDIFF(YEAR, BIRTHDATE, GETDATE()) >= 0 AND DATEDIFF(YEAR, BIRTHDATE, GETDATE()) > 65", conn)
        Dim countElder = Convert.ToString(cmdElder.ExecuteScalar)
        oldcnt.Text = countElder
        conn.Close()
    End Sub
    Private Sub DEMOGRAPHICS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Childcount()
        Youthcount()
        Adultcount()
        Eldercount()
    End Sub

End Class