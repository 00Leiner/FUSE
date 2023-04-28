Imports System.Data.SqlClient

Public Class RESIDENTS
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")

    Private CurrentID As Integer = -1
    Public Property recordview2 As Object

    Public Sub LoadInDataGridView()
        Dim query As String = "SELECT * FROM INFOS"
        Using con As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
            Using cmdInsert As SqlCommand = New SqlCommand(query, con)
                Using fuseda As New SqlDataAdapter()
                    fuseda.SelectCommand = cmdInsert
                    Using fusedt As New DataTable()
                        fuseda.Fill(fusedt)
                        recordview.DataSource = fusedt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub exitlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles exitlink.LinkClicked
        Dim ext As DialogResult
        ext = MessageBox.Show("CLOSE APPLICATION?", "EXIT", MessageBoxButtons.YesNo)
        If ext = DialogResult.No Then

        Else
            Application.Exit()
        End If
    End Sub

    Private Sub maxlink_Click(sender As Object, e As EventArgs) Handles maxlink.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub minlink_Click(sender As Object, e As EventArgs) Handles minlink.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub
    Private Sub viewbtn_Click(sender As Object, e As EventArgs) Handles viewbtn.Click
        LoadInDataGridView()

    End Sub
    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Dim query As String = "SELECT * FROM INFOS WHERE SURNAME = '" & searchbox.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
            Using cmdsave As SqlCommand = New SqlCommand(query, con)
                Using fuseda As New SqlDataAdapter()
                    fuseda.SelectCommand = cmdsave
                    Using fusedt As New DataTable()
                        fuseda.Fill(fusedt)
                        If fusedt.Rows.Count > 0 Then
                            recordview.DataSource = fusedt
                        Else

                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If CurrentID >= 0 Then ' If a row is selected
            Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
            Dim cmd As New SqlCommand("DELETE FROM INFOS WHERE ID = @ID", con)
            cmd.Parameters.AddWithValue("@ID", CurrentID)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            ' Refresh the DataGridView1 control to show the updated data
            recordview.DataSource = Nothing
            recordview.Rows.Clear()
            Dim adapter As New SqlDataAdapter("SELECT * FROM INFOS", con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            recordview.DataSource = dt

            ' Reset the currentid variable
            CurrentID = -1
        End If
    End Sub

    Private Sub archbtn_Click(sender As Object, e As EventArgs) 
        Dim dtb2 As New DataTable
        For Each row As DataGridViewRow In recordview.Rows
            If (recordview.Rows.Count - 0) Then
                recordview2.Rows.Add(recordview.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(A) A.Value).ToArray)
                recordview.Rows.Remove(recordview.SelectedRows(0))
            End If
        Next
        ARCHIVED.recordview2.DataSource = dtb2
    End Sub

    Private Sub recordview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles recordview.CellClick
        If e.RowIndex >= 0 Then
            CurrentID = Convert.ToInt32(recordview.Rows(e.RowIndex).Cells(0).Value)
        Else
            CurrentID = -1
        End If
    End Sub
End Class