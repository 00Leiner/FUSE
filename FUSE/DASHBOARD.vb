Imports System.Data.SqlClient
Public Class DASHBOARD
    'Database Table Connection
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True; Pooling=False")
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        LOGIN.Show()
        Me.Close()
    End Sub
    Private Sub minlink_Click(sender As Object, e As EventArgs) Handles minlink.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub exitlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles exitlink.LinkClicked
        Application.Exit()
    End Sub

    'Auto count
    Sub familycount()
        con.Open()
        Dim cmdfamiy As New SqlCommand("SELECT COUNT(HOUSEHOLD) FROM INFOS", con)
        Dim countfamily = Convert.ToString(cmdfamiy.ExecuteScalar)
        total_family.Text = countfamily
        con.Close()
    End Sub

    Sub populationcount()
        con.Open()
        Dim cmdpopulation As New SqlCommand("SELECT COUNT(SURNAME) FROM INFOS", con)
        Dim countpopulation = Convert.ToString(cmdpopulation.ExecuteScalar)
        total_popu.Text = countpopulation
        con.Close()
    End Sub

    Sub femalecount()
        con.Open()
        Dim cmdfemale = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE SEX = 'FEMALE'", con)
        Dim countfemale = Convert.ToString(cmdfemale.ExecuteScalar)
        total_female.Text = countfemale
        con.Close()
    End Sub

    Sub malecount()
        con.Open()
        Dim cmdmale = New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE SEX = 'MALE'", con)
        Dim countmale = Convert.ToString(cmdmale.ExecuteScalar)
        total_male.Text = countmale
        con.Close()
    End Sub
    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        familycount()
        populationcount()
        femalecount()
        malecount()
    End Sub

    Private Sub createbtn_Click(sender As Object, e As EventArgs) Handles createbtn.Click
        REGISTRY.Show()
        Me.Close()
    End Sub

    Private Sub residentbtn_Click(sender As Object, e As EventArgs) Handles residentbtn.Click
        RESIDENTS.Show()
        Me.Close()
    End Sub

    Private Sub aboutbtn_Click(sender As Object, e As EventArgs) Handles demobtn.Click
        DEMOGRAPHICS.Show()
        Me.Close()
    End Sub

    Private Sub archbtn_Click(sender As Object, e As EventArgs) Handles archbtn.Click
        ARCHIVED.Show()
        Me.Close()
    End Sub
End Class