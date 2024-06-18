<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoadCsvButton = New System.Windows.Forms.Button()
        Me.SaveCsvButton = New System.Windows.Forms.Button()
        Me.LoadXmlButton = New System.Windows.Forms.Button()
        Me.SaveXmlButton = New System.Windows.Forms.Button()
        Me.LoadJsonButton = New System.Windows.Forms.Button()
        Me.SaveJsonButton = New System.Windows.Forms.Button()
        Me.LoadDataButton = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadCsvButton
        '
        Me.LoadCsvButton.Location = New System.Drawing.Point(625, 342)
        Me.LoadCsvButton.Name = "LoadCsvButton"
        Me.LoadCsvButton.Size = New System.Drawing.Size(122, 23)
        Me.LoadCsvButton.TabIndex = 15
        Me.LoadCsvButton.Text = "CARGAR CSV"
        Me.LoadCsvButton.UseVisualStyleBackColor = True
        '
        'SaveCsvButton
        '
        Me.SaveCsvButton.Location = New System.Drawing.Point(649, 293)
        Me.SaveCsvButton.Name = "SaveCsvButton"
        Me.SaveCsvButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveCsvButton.TabIndex = 14
        Me.SaveCsvButton.Text = "CSV"
        Me.SaveCsvButton.UseVisualStyleBackColor = True
        '
        'LoadXmlButton
        '
        Me.LoadXmlButton.Location = New System.Drawing.Point(632, 237)
        Me.LoadXmlButton.Name = "LoadXmlButton"
        Me.LoadXmlButton.Size = New System.Drawing.Size(115, 23)
        Me.LoadXmlButton.TabIndex = 13
        Me.LoadXmlButton.Text = "CARGAR XML"
        Me.LoadXmlButton.UseVisualStyleBackColor = True
        '
        'SaveXmlButton
        '
        Me.SaveXmlButton.Location = New System.Drawing.Point(649, 196)
        Me.SaveXmlButton.Name = "SaveXmlButton"
        Me.SaveXmlButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveXmlButton.TabIndex = 12
        Me.SaveXmlButton.Text = "XML"
        Me.SaveXmlButton.UseVisualStyleBackColor = True
        '
        'LoadJsonButton
        '
        Me.LoadJsonButton.Location = New System.Drawing.Point(615, 127)
        Me.LoadJsonButton.Name = "LoadJsonButton"
        Me.LoadJsonButton.Size = New System.Drawing.Size(132, 23)
        Me.LoadJsonButton.TabIndex = 11
        Me.LoadJsonButton.Text = "CARGAR JSON"
        Me.LoadJsonButton.UseVisualStyleBackColor = True
        '
        'SaveJsonButton
        '
        Me.SaveJsonButton.Location = New System.Drawing.Point(649, 86)
        Me.SaveJsonButton.Name = "SaveJsonButton"
        Me.SaveJsonButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveJsonButton.TabIndex = 10
        Me.SaveJsonButton.Text = "JSON"
        Me.SaveJsonButton.UseVisualStyleBackColor = True
        '
        'LoadDataButton
        '
        Me.LoadDataButton.Location = New System.Drawing.Point(485, 86)
        Me.LoadDataButton.Name = "LoadDataButton"
        Me.LoadDataButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadDataButton.TabIndex = 9
        Me.LoadDataButton.Text = "CargarData"
        Me.LoadDataButton.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(54, 127)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.dataGridView1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoadCsvButton)
        Me.Controls.Add(Me.SaveCsvButton)
        Me.Controls.Add(Me.LoadXmlButton)
        Me.Controls.Add(Me.SaveXmlButton)
        Me.Controls.Add(Me.LoadJsonButton)
        Me.Controls.Add(Me.SaveJsonButton)
        Me.Controls.Add(Me.LoadDataButton)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents LoadCsvButton As Button
    Private WithEvents SaveCsvButton As Button
    Private WithEvents LoadXmlButton As Button
    Private WithEvents SaveXmlButton As Button
    Private WithEvents LoadJsonButton As Button
    Private WithEvents SaveJsonButton As Button
    Private WithEvents LoadDataButton As Button
    Private WithEvents dataGridView1 As DataGridView
End Class
