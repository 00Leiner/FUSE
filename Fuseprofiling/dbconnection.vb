Imports System.Data.OleDb

Module dbconnection

    'if The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine. try to download Microsoft Access Database Engine 2010 Redistributable here: https://www.microsoft.com/en-us/download/details.aspx?id=13255 
    Public Class DatabaseConnection
        Public Shared Function GetConnection() As OleDbConnection
            ' database connection and setting up
            Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\fusedata.accdb"
            Dim conn As New OleDbConnection(connStr)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
            Return conn
        End Function
    End Class
End Module