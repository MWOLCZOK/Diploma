<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeleccionar_Idioma
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
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.Lblidioma = New System.Windows.Forms.Label()
        Me.Btnseleccionar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbxIdioma
        '
        Me.CbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(28, 43)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(259, 21)
        Me.CbxIdioma.TabIndex = 0
        '
        'Lblidioma
        '
        Me.Lblidioma.AutoSize = True
        Me.Lblidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblidioma.Location = New System.Drawing.Point(128, 24)
        Me.Lblidioma.Name = "Lblidioma"
        Me.Lblidioma.Size = New System.Drawing.Size(49, 16)
        Me.Lblidioma.TabIndex = 1
        Me.Lblidioma.Text = "Idioma"
        '
        'Btnseleccionar
        '
        Me.Btnseleccionar.Location = New System.Drawing.Point(28, 101)
        Me.Btnseleccionar.Name = "Btnseleccionar"
        Me.Btnseleccionar.Size = New System.Drawing.Size(90, 35)
        Me.Btnseleccionar.TabIndex = 2
        Me.Btnseleccionar.Text = "Seleccionar"
        Me.Btnseleccionar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(197, 101)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(90, 35)
        Me.Btnsalir.TabIndex = 3
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'FormSeleccionar_Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 165)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnseleccionar)
        Me.Controls.Add(Me.Lblidioma)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Name = "FormSeleccionar_Idioma"
        Me.Text = "SeleccionarIdioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents Lblidioma As System.Windows.Forms.Label
    Friend WithEvents Btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
End Class
