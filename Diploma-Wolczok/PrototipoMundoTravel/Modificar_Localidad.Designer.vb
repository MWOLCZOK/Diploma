<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Localidad
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
        Me.Txtdestino = New System.Windows.Forms.TextBox()
        Me.Txthabitantes = New System.Windows.Forms.TextBox()
        Me.Txtcantidadbarrios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lblnuevonombreusuario = New System.Windows.Forms.Label()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.Cbxloc = New System.Windows.Forms.ComboBox()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txtdestino
        '
        Me.Txtdestino.Location = New System.Drawing.Point(35, 263)
        Me.Txtdestino.Name = "Txtdestino"
        Me.Txtdestino.Size = New System.Drawing.Size(254, 20)
        Me.Txtdestino.TabIndex = 75
        '
        'Txthabitantes
        '
        Me.Txthabitantes.Location = New System.Drawing.Point(35, 208)
        Me.Txthabitantes.Name = "Txthabitantes"
        Me.Txthabitantes.Size = New System.Drawing.Size(254, 20)
        Me.Txthabitantes.TabIndex = 74
        '
        'Txtcantidadbarrios
        '
        Me.Txtcantidadbarrios.Location = New System.Drawing.Point(35, 159)
        Me.Txtcantidadbarrios.Name = "Txtcantidadbarrios"
        Me.Txtcantidadbarrios.Size = New System.Drawing.Size(254, 20)
        Me.Txtcantidadbarrios.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Cantidad de Barrios"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(168, 308)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 25)
        Me.btnsalir.TabIndex = 70
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(58, 308)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 25)
        Me.btnmodificar.TabIndex = 69
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(35, 106)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(254, 20)
        Me.Txtdescripcion.TabIndex = 68
        '
        'lblnuevonombreusuario
        '
        Me.lblnuevonombreusuario.AutoSize = True
        Me.lblnuevonombreusuario.Location = New System.Drawing.Point(32, 89)
        Me.lblnuevonombreusuario.Name = "lblnuevonombreusuario"
        Me.lblnuevonombreusuario.Size = New System.Drawing.Size(63, 13)
        Me.lblnuevonombreusuario.TabIndex = 67
        Me.lblnuevonombreusuario.Text = "Descripcion"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(32, 247)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(43, 13)
        Me.lblperfil.TabIndex = 66
        Me.lblperfil.Text = "Destino"
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(32, 192)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(58, 13)
        Me.lblidioma.TabIndex = 65
        Me.lblidioma.Text = "Habitantes"
        '
        'Cbxloc
        '
        Me.Cbxloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxloc.FormattingEnabled = True
        Me.Cbxloc.Location = New System.Drawing.Point(40, 41)
        Me.Cbxloc.Name = "Cbxloc"
        Me.Cbxloc.Size = New System.Drawing.Size(254, 21)
        Me.Cbxloc.TabIndex = 64
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Location = New System.Drawing.Point(105, 25)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(112, 13)
        Me.lblpais.TabIndex = 63
        Me.lblpais.Text = "Seleccionar Localidad"
        '
        'Modificar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 365)
        Me.Controls.Add(Me.Txtdestino)
        Me.Controls.Add(Me.Txthabitantes)
        Me.Controls.Add(Me.Txtcantidadbarrios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.lblnuevonombreusuario)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.Cbxloc)
        Me.Controls.Add(Me.lblpais)
        Me.Name = "Modificar_Localidad"
        Me.Text = "Modificar_Localidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdestino As System.Windows.Forms.TextBox
    Friend WithEvents Txthabitantes As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidadbarrios As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblnuevonombreusuario As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents Cbxloc As System.Windows.Forms.ComboBox
    Friend WithEvents lblpais As System.Windows.Forms.Label
End Class
