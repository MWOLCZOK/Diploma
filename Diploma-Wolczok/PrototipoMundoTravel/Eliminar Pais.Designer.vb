<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Pais
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.CbxPais = New System.Windows.Forms.ComboBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(155, 148)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 31
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(41, 148)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(81, 23)
        Me.btneliminar.TabIndex = 30
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'CbxPais
        '
        Me.CbxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPais.FormattingEnabled = True
        Me.CbxPais.Location = New System.Drawing.Point(15, 108)
        Me.CbxPais.Name = "CbxPais"
        Me.CbxPais.Size = New System.Drawing.Size(254, 21)
        Me.CbxPais.TabIndex = 29
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(89, 92)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(86, 13)
        Me.lblusuario.TabIndex = 28
        Me.lblusuario.Text = "Seleccionar Pais"
        '
        'Eliminar_Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.CbxPais)
        Me.Controls.Add(Me.lblusuario)
        Me.Name = "Eliminar_Pais"
        Me.Text = "Eliminar_Pais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents CbxPais As System.Windows.Forms.ComboBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
End Class
