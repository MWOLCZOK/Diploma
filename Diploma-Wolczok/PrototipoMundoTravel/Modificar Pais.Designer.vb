<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Pais
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
        Me.Txtidioma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lblnuevonombreusuario = New System.Windows.Forms.Label()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.Cbxpais = New System.Windows.Forms.ComboBox()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtpoblacion = New System.Windows.Forms.TextBox()
        Me.Txtzonahoraria = New System.Windows.Forms.TextBox()
        Me.Txtprovincia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txtidioma
        '
        Me.Txtidioma.Location = New System.Drawing.Point(34, 147)
        Me.Txtidioma.Name = "Txtidioma"
        Me.Txtidioma.Size = New System.Drawing.Size(254, 20)
        Me.Txtidioma.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Idioma"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(169, 356)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 41
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(59, 356)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 40
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(34, 94)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(254, 20)
        Me.Txtdescripcion.TabIndex = 39
        '
        'lblnuevonombreusuario
        '
        Me.lblnuevonombreusuario.AutoSize = True
        Me.lblnuevonombreusuario.Location = New System.Drawing.Point(31, 77)
        Me.lblnuevonombreusuario.Name = "lblnuevonombreusuario"
        Me.lblnuevonombreusuario.Size = New System.Drawing.Size(63, 13)
        Me.lblnuevonombreusuario.TabIndex = 38
        Me.lblnuevonombreusuario.Text = "Descripcion"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(31, 235)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(69, 13)
        Me.lblperfil.TabIndex = 35
        Me.lblperfil.Text = "Zona Horaria"
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(31, 180)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(81, 13)
        Me.lblidioma.TabIndex = 34
        Me.lblidioma.Text = "Poblacion Total"
        '
        'Cbxpais
        '
        Me.Cbxpais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpais.FormattingEnabled = True
        Me.Cbxpais.Location = New System.Drawing.Point(34, 42)
        Me.Cbxpais.Name = "Cbxpais"
        Me.Cbxpais.Size = New System.Drawing.Size(254, 21)
        Me.Cbxpais.TabIndex = 33
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Location = New System.Drawing.Point(114, 26)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(86, 13)
        Me.lblpais.TabIndex = 32
        Me.lblpais.Text = "Seleccionar Pais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Provincia"
        '
        'Txtpoblacion
        '
        Me.Txtpoblacion.Location = New System.Drawing.Point(34, 196)
        Me.Txtpoblacion.Name = "Txtpoblacion"
        Me.Txtpoblacion.Size = New System.Drawing.Size(254, 20)
        Me.Txtpoblacion.TabIndex = 46
        '
        'Txtzonahoraria
        '
        Me.Txtzonahoraria.Location = New System.Drawing.Point(34, 251)
        Me.Txtzonahoraria.Name = "Txtzonahoraria"
        Me.Txtzonahoraria.Size = New System.Drawing.Size(254, 20)
        Me.Txtzonahoraria.TabIndex = 47
        '
        'Txtprovincia
        '
        Me.Txtprovincia.Location = New System.Drawing.Point(34, 306)
        Me.Txtprovincia.Name = "Txtprovincia"
        Me.Txtprovincia.Size = New System.Drawing.Size(254, 20)
        Me.Txtprovincia.TabIndex = 48
        '
        'Modificar_Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 401)
        Me.Controls.Add(Me.Txtprovincia)
        Me.Controls.Add(Me.Txtzonahoraria)
        Me.Controls.Add(Me.Txtpoblacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtidioma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.lblnuevonombreusuario)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.Cbxpais)
        Me.Controls.Add(Me.lblpais)
        Me.Name = "Modificar_Pais"
        Me.Text = "Modificar_Pais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtidioma As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblnuevonombreusuario As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents Cbxpais As System.Windows.Forms.ComboBox
    Friend WithEvents lblpais As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtpoblacion As System.Windows.Forms.TextBox
    Friend WithEvents Txtzonahoraria As System.Windows.Forms.TextBox
    Friend WithEvents Txtprovincia As System.Windows.Forms.TextBox
End Class
