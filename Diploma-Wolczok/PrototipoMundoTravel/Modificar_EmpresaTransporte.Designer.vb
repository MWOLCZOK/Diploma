<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_EmpresaTransporte
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
        Me.Cbxloc = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Cbxloc
        '
        Me.Cbxloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxloc.FormattingEnabled = True
        Me.Cbxloc.Location = New System.Drawing.Point(37, 36)
        Me.Cbxloc.Name = "Cbxloc"
        Me.Cbxloc.Size = New System.Drawing.Size(254, 21)
        Me.Cbxloc.TabIndex = 65
        '
        'Modificar_EmpresaTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 347)
        Me.Controls.Add(Me.Cbxloc)
        Me.Name = "Modificar_EmpresaTransporte"
        Me.Text = "Modificar_EmpresaTransporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cbxloc As System.Windows.Forms.ComboBox
End Class
