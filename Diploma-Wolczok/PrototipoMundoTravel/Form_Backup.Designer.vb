<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Backup
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnRealizarBackup = New System.Windows.Forms.Button()
        Me.Lbldirectorio = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnRealizarBackup
        '
        Me.BtnRealizarBackup.Location = New System.Drawing.Point(190, 107)
        Me.BtnRealizarBackup.Name = "BtnRealizarBackup"
        Me.BtnRealizarBackup.Size = New System.Drawing.Size(154, 29)
        Me.BtnRealizarBackup.TabIndex = 22
        Me.BtnRealizarBackup.Text = "Realizar Backup"
        Me.BtnRealizarBackup.UseVisualStyleBackColor = True
        '
        'Lbldirectorio
        '
        Me.Lbldirectorio.AutoSize = True
        Me.Lbldirectorio.Location = New System.Drawing.Point(13, 74)
        Me.Lbldirectorio.Name = "Lbldirectorio"
        Me.Lbldirectorio.Size = New System.Drawing.Size(52, 13)
        Me.Lbldirectorio.TabIndex = 21
        Me.Lbldirectorio.Text = "Directorio"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(82, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(385, 20)
        Me.TextBox3.TabIndex = 20
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(473, 69)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 23)
        Me.BtnBuscar.TabIndex = 19
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(13, 48)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 18
        Me.LblDescripcion.Text = "Descripcion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(450, 20)
        Me.TextBox2.TabIndex = 17
        '
        'Form_Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 185)
        Me.Controls.Add(Me.BtnRealizarBackup)
        Me.Controls.Add(Me.Lbldirectorio)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "Form_Backup"
        Me.Text = "Módulo Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnRealizarBackup As System.Windows.Forms.Button
    Friend WithEvents Lbldirectorio As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
