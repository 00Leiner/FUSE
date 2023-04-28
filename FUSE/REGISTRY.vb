Imports System.Data.SqlClient

Public Class REGISTRY
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")

    'Sub for clearing text fields
    Sub clearText()
        surnamebox.Text = ""
        firstbox.Text = ""
        middlebox.Text = ""
        addressbox.Text = ""
        suffixbox.Text = ""
        householdbox.Text = ""
        purokbox.Text = ""
        addressbox.Text = ""
        dobpick.Text = ""
        sexbox.Text = ""
        siblingbox.Text = ""
        civilbox.Text = ""
        contactbox.Text = ""
    End Sub
    Private Sub exitlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles exitlink.LinkClicked
        Dim ext As DialogResult
        ext = MessageBox.Show("CLOSE APPLICATION?", "EXIT", MessageBoxButtons.YesNo)
        If ext = DialogResult.No Then

        Else
            Application.Exit()
        End If
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DASHBOARD.Show()
        Me.Close()
    End Sub

    Private Sub minlink_Click(sender As Object, e As EventArgs) Handles minlink.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        clearText()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim SURNAME As String = surnamebox.Text
        Dim FIRSTNAME As String = firstbox.Text
        Dim MIDDLENAME As String = middlebox.Text
        Dim SUFFIX As String = suffixbox.Text
        Dim HOUSEHOLD As String = householdbox.Text
        Dim PUROK As Integer = purokbox.Text
        Dim ADDRESS As String = addressbox.Text
        Dim BIRTHDATE As DateTime = dobpick.Text
        Dim SEX As String = sexbox.SelectedItem
        Dim SIBLING As Integer = siblingbox.Text
        Dim CIVILSTATUS As String = civilbox.Text
        Dim CONTACT As String = contactbox.Text

        Dim insertquery As String = "INSERT INTO INFOS VALUES (@SURNAME, @FIRSTNAME, @MIDDLENAME, @SUFFIX, @HOUSEHOLD, @PUROK, @ADDRESS, @BIRTHDATE, @SEX, @SIBLING, @CIVILSTATUS, @CONTACT)"
        Using con As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=FUSEAPPDATABASE;Integrated Security=True;Pooling=False")
            Using cmdInsert As SqlCommand = New SqlCommand(insertquery, con)

                cmdInsert.Parameters.AddWithValue("@SURNAME", SURNAME)
                cmdInsert.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                cmdInsert.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                cmdInsert.Parameters.AddWithValue("@SUFFIX", SUFFIX)
                cmdInsert.Parameters.AddWithValue("@HOUSEHOLD", HOUSEHOLD)
                cmdInsert.Parameters.AddWithValue("@PUROK", PUROK)
                cmdInsert.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                cmdInsert.Parameters.AddWithValue("@BIRTHDATE", BIRTHDATE)
                cmdInsert.Parameters.AddWithValue("@SEX", SEX)
                cmdInsert.Parameters.AddWithValue("@SIBLING", SIBLING)
                cmdInsert.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)
                cmdInsert.Parameters.AddWithValue("@CONTACT", CONTACT)

                con.Open()
                cmdInsert.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearText()
            End Using
        End Using
    End Sub
End Class