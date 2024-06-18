Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PROYECTO_RIOJAS
    Friend Class DataBaseHandler
        Private ReadOnly connectionString As String

        Public Sub New(ByVal connectionString As String)
            Me.connectionString = connectionString
        End Sub

        Public Function GetAllData() As List(Of YourDataClass)
            Dim data As List(Of YourDataClass) = New List(Of YourDataClass)()

            Using connection As SqlConnection = New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM YourTable"
                Dim command As SqlCommand = New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    
                    // Fill the YourDataClass object with data from the reader
                    YourDataClass item = New YourDataClass
                    {
                        // Property1 = reader["Column1"].ToString(),
                        // Property2 = Convert.ToInt32(reader["Column2"]),
                        // etc.
                    };

                    data.Add(item)
                End While
            End Using

            Return data
        End Function

        Public Sub InsertData(ByVal data As YourDataClass)
            Using connection As SqlConnection = New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO YourTable (Column1, Column2, etc) VALUES (@value1, @value2, etc)"
                Dim command As SqlCommand = New SqlCommand(query, connection)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Sub
    End Class
End Namespace

