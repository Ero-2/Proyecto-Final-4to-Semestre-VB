Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports CsvHelper
Public Class CsvHandler


    Friend Class CsvHandler(Of T)
        Public Sub Save(ByVal filePath As String, ByVal data As List(Of T))
            Using writer = New StreamWriter(filePath)

                Using csv = New CsvWriter(writer, CultureInfo.InvariantCulture)
                    csv.WriteRecords(data)
                End Using
            End Using
        End Sub

        Public Function Load(ByVal filePath As String) As List(Of T)
            If Not File.Exists(filePath) Then Return New List(Of T)()

            Using reader = New StreamReader(filePath)

                Using csv = New CsvReader(reader, CultureInfo.InvariantCulture)
                    Return New List(Of T)(csv.GetRecords(Of T)())
                End Using
            End Using
        End Function
    End Class


End Class
