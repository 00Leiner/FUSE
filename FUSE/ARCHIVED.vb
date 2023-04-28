Imports System.Data.SqlClient

Public Class ARCHIVED
    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub

    Private Sub minlink_Click(sender As Object, e As EventArgs) Handles minlink.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub maxlink_Click(sender As Object, e As EventArgs) Handles maxlink.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub exitlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles exitlink.LinkClicked
        Application.Exit()
    End Sub
    Public Sub LoadInDataGridView()
        Dim query As String = "SELECT * FROM INFOS"
        Using con As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
            Using cmdInsert As SqlCommand = New SqlCommand(query, con)
                Using fuseda As New SqlDataAdapter()
                    fuseda.SelectCommand = cmdInsert
                    Using fusedt As New DataTable()
                        fuseda.Fill(fusedt)
                        recordview2.DataSource = fusedt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub ARCHIVED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FUSEAPPDATABASEDataSetFull.INFOS' table. You can move, or remove it, as needed.
        Me.INFOSTableAdapter.Fill(Me.FUSEAPPDATABASEDataSetFull.INFOS)
        LoadInDataGridView()
    End Sub
End Class