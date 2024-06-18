Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Serialization

Namespace PROYECTO_RIOJAS
    Friend Class XmlHandler(Of T)
        Public Sub Save(ByVal filePath As String, ByVal data As List(Of T))
            Dim serializer = New XmlSerializer(GetType(List(Of T)))

            Using writer = New StreamWriter(filePath)
                serializer.Serialize(writer, data)
            End Using
        End Sub

        Public Function Load(ByVal filePath As String) As List(Of T)
            If Not File.Exists(filePath) Then Return New List(Of T)()
            Dim serializer = New XmlSerializer(GetType(List(Of T)))

            Using reader = New StreamReader(filePath)
                Return CType(serializer.Deserialize(reader), List(Of T))
            End Using
        End Function
    End Class
End Namespace

