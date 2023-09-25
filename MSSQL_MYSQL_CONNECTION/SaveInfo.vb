Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class SaveInfo
    Dim connectionStringmysql As String = "server=localhost;userid=root;password='masterkey';database=test"

    Dim connectionString As String = "data source = WMR\SQLEXPRESS;database=registration;integrated security = true;"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using connection As New MySqlConnection(connectionStringmysql)
            connection.Open()

            Dim insertQuery As String = "INSERT INTO registration (ID, FirstName, MiddleName, LastName) VALUES (@ID, @FirstName, @MiddleName, @LastName)"
            Using insertCommand As New MySqlCommand(insertQuery, connection)

                insertCommand.Parameters.AddWithValue("@ID", idtxt.Text)
                insertCommand.Parameters.AddWithValue("@FirstName", fnametxt.Text)
                insertCommand.Parameters.AddWithValue("@MiddleName", mnametxt.Text)
                insertCommand.Parameters.AddWithValue("@LastName", lnametxt.Text)

                ' Execute the INSERT command
                insertCommand.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("Data inserted in MYSQL successfully.")

                ' Clear the input fields
                idtxt.Clear()
                fnametxt.Clear()
                mnametxt.Clear()
                lnametxt.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Integer.Parse(idtxt.Text)
        Dim firstName As String = fnametxt.Text
        Dim middleName As String = mnametxt.Text
        Dim lastName As String = lnametxt.Text

        Dim insertQuery As String = "INSERT INTO registration (ID, FirstName, MiddleName, LastName) VALUES (@ID, @FirstName, @MiddleName, @LastName)"

        Using connection As New SqlConnection(connectionString)
            Using insertCommand As New SqlCommand(insertQuery, connection)
                Try
                    insertCommand.Parameters.AddWithValue("@ID", id)
                    insertCommand.Parameters.AddWithValue("@FirstName", firstName)
                    insertCommand.Parameters.AddWithValue("@MiddleName", middleName)
                    insertCommand.Parameters.AddWithValue("@LastName", lastName)

                    connection.Open()

                    insertCommand.ExecuteNonQuery()
                    MessageBox.Show("Data inserted in MSSQL successfully.")

                    ' Clear the input fields
                    idtxt.Clear()
                    fnametxt.Clear()
                    mnametxt.Clear()
                    lnametxt.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error inserting data: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub
End Class
