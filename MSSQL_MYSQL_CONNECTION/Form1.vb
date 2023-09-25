Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='masterkey';database=test"

        Try
            conn.Open()
            Dim result As DialogResult = MessageBox.Show("Connection to MYSQL was successful!!!!", "Message Box Title", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                Dim secondForm As New SaveInfo()
                secondForm.Show()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "data source = WMR\SQLEXPRESS;database=registration;integrated security = true;"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()
            Dim result As DialogResult = MessageBox.Show("Connection to MSSQL was successful!!!!", "Message Box Title", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                Dim secondForm As New SaveInfo()
                secondForm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Connection Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
