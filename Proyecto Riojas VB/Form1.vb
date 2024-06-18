Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Proyecto_Riojas_VB.CsvHandler


Partial Public Class Form1
        Inherits Form

        Private databaseHandler As DataBaseHandler
        Private jsonHandler As JsonHandler(Of YourDataClass)
        Private xmlHandler As XmlHandler(Of YourDataClass)
        Private csvHandler As CsvHandler(Of YourDataClass)

        Public Sub New()
            InitializeComponent()
            Dim connectionString As String = "server=(localdb)\ErickGarcia; database=Erick; integrated security=true"
            databaseHandler = New DataBaseHandler(connectionString)
            jsonHandler = New JsonHandler(Of YourDataClass)()
            xmlHandler = New XmlHandler(Of YourDataClass)()
            csvHandler = New CsvHandler(Of YourDataClass)()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub LoadDataButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = databaseHandler.GetAllData()
            dataGridView1.DataSource = data
        End Sub

        Private Sub SaveJsonButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = CType(dataGridView1.DataSource, List(Of YourDataClass))
            jsonHandler.Save("data.json", data)
        End Sub

        Private Sub LoadJsonButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = jsonHandler.Load("data.json")
            dataGridView1.DataSource = data
        End Sub

        Private Sub SaveXmlButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = CType(dataGridView1.DataSource, List(Of YourDataClass))
            xmlHandler.Save("data.xml", data)
        End Sub

        Private Sub LoadXmlButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = xmlHandler.Load("data.xml")
            dataGridView1.DataSource = data
        End Sub

        Private Sub SaveCsvButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = CType(dataGridView1.DataSource, List(Of YourDataClass))
            csvHandler.Save("data.csv", data)
        End Sub

        Private Sub LoadCsvButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim data = csvHandler.Load("data.csv")
            dataGridView1.DataSource = data
        End Sub
    End Class
End Namespace
