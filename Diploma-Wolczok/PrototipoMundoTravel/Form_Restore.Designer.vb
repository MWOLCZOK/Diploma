<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Restore
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
        Me.BtnRealizarRestore = New System.Windows.Forms.Button()
        Me.Lbldirectorio = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'BtnRealizarRestore
        '
        Me.BtnRealizarRestore.Location = New System.Drawing.Point(189, 111)
        Me.BtnRealizarRestore.Name = "BtnRealizarRestore"
        Me.BtnRealizarRestore.Size = New System.Drawing.Size(154, 29)
        Me.BtnRealizarRestore.TabIndex = 20
        Me.BtnRealizarRestore.Text = "Realizar Restore"
        Me.BtnRealizarRestore.UseVisualStyleBackColor = True
        '
        'Lbldirectorio
        '
        Me.Lbldirectorio.AutoSize = True
        Me.Lbldirectorio.Location = New System.Drawing.Point(12, 76)
        Me.Lbldirectorio.Name = "Lbldirectorio"
        Me.Lbldirectorio.Size = New System.Drawing.Size(52, 13)
        Me.Lbldirectorio.TabIndex = 19
        Me.Lbldirectorio.Text = "Directorio"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(78, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(385, 20)
        Me.TextBox4.TabIndex = 18
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(469, 71)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(59, 23)
        Me.Btnbuscar.TabIndex = 17
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form_Restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 185)
        Me.Controls.Add(Me.BtnRealizarRestore)
        Me.Controls.Add(Me.Lbldirectorio)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Name = "Form_Restore"
        Me.Text = "Módulo Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRealizarRestore As System.Windows.Forms.Button
    Friend WithEvents Lbldirectorio As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
