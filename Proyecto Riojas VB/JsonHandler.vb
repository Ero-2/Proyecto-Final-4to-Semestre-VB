Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.IO
Imports System.Xml


Friend Class JsonHandler(Of T)
        Public Sub Save(ByVal filePath As String, ByVal data As List(Of T))
            File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented))
        End Sub

        Public Function Load(ByVal filePath As String) As List(Of T)
            If Not File.Exists(filePath) Then Return New List(Of T)()
            Return JsonConvert.DeserializeObject(Of List(Of T))(File.ReadAllText(filePath))
        End Function
    End Class
End Namespace

