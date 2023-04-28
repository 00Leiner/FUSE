Imports System.Data.SqlClient

Public Class PUROKSTATS
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
    Sub purokuno()
        con.Open()
        Dim cmdUno As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE PUROK = 1", con)
        Dim cmdpUno = Convert.ToString(cmdUno.ExecuteScalar)
        unocnt.Text = cmdpUno
        con.Close()
    End Sub

    Sub purokdos()
        con.Open()
        Dim cmdDos As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE PUROK = 2", con)
        Dim cmdpDos = Convert.ToString(cmdDos.ExecuteScalar)
        doscnt.Text = cmdpDos
        con.Close()
    End Sub
    Sub puroktres()
        con.Open()
        Dim cmdTres As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE PUROK = 3", con)
        Dim cmdpTres = Convert.ToString(cmdTres.ExecuteScalar)
        trescnt.Text = cmdpTres
        con.Close()
    End Sub

    Sub purokfour()
        con.Open()
        Dim cmdFour As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE PUROK = 4", con)
        Dim cmdpFour = Convert.ToString(cmdFour.ExecuteScalar)
        fourcnt.Text = cmdpFour
        con.Close()
    End Sub
    Sub purokfive()
        con.Open()
        Dim cmdFive As New SqlCommand("SELECT COUNT(*) FROM INFOS WHERE PUROK = 5", con)
        Dim cmdpFive = Convert.ToString(cmdFive.ExecuteScalar)
        fivecnt.Text = cmdpFive
        con.Close()
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub

    Private Sub PUROKSTATS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        purokuno()
        purokdos()
        puroktres()
        purokfour()
        purokfive()
    End Sub

    Private Sub agebtn_Click(sender As Object, e As EventArgs) Handles popubtn.Click
        DEMOGRAPHICS.Show()
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
End Class