<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Provincia
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
        Me.Txtsuperficieterrestre = New System.Windows.Forms.TextBox()
        Me.Txtregion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txthabitantes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lblnuevonombreusuario = New System.Windows.Forms.Label()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.Cbxprov = New System.Windows.Forms.ComboBox()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Txtsuperficieterrestre
        '
        Me.Txtsuperficieterrestre.Location = New System.Drawing.Point(42, 243)
        Me.Txtsuperficieterrestre.Name = "Txtsuperficieterrestre"
        Me.Txtsuperficieterrestre.Size = New System.Drawing.Size(254, 20)
        Me.Txtsuperficieterrestre.TabIndex = 61
        '
        'Txtregion
        '
        Me.Txtregion.Location = New System.Drawing.Point(42, 188)
        Me.Txtregion.Name = "Txtregion"
        Me.Txtregion.Size = New System.Drawing.Size(254, 20)
        Me.Txtregion.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Pais"
        '
        'Txthabitantes
        '
        Me.Txthabitantes.Location = New System.Drawing.Point(42, 139)
        Me.Txthabitantes.Name = "Txthabitantes"
        Me.Txthabitantes.Size = New System.Drawing.Size(254, 20)
        Me.Txthabitantes.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Habitantes"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(177, 348)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 56
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(67, 348)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 55
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(42, 86)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(254, 20)
        Me.Txtdescripcion.TabIndex = 54
        '
        'lblnuevonombreusuario
        '
        Me.lblnuevonombreusuario.AutoSize = True
        Me.lblnuevonombreusuario.Location = New System.Drawing.Point(39, 69)
        Me.lblnuevonombreusuario.Name = "lblnuevonombreusuario"
        Me.lblnuevonombreusuario.Size = New System.Drawing.Size(63, 13)
        Me.lblnuevonombreusuario.TabIndex = 53
        Me.lblnuevonombreusuario.Text = "Descripcion"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(39, 227)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(99, 13)
        Me.lblperfil.TabIndex = 52
        Me.lblperfil.Text = "Superficie Terrestre"
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(39, 172)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(41, 13)
        Me.lblidioma.TabIndex = 51
        Me.lblidioma.Text = "Region"
        '
        'Cbxprov
        '
        Me.Cbxprov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxprov.FormattingEnabled = True
        Me.Cbxprov.Location = New System.Drawing.Point(42, 34)
        Me.Cbxprov.Name = "Cbxprov"
        Me.Cbxprov.Size = New System.Drawing.Size(254, 21)
        Me.Cbxprov.TabIndex = 50
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Location = New System.Drawing.Point(114, 18)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(110, 13)
        Me.lblpais.TabIndex = 49
        Me.lblpais.Text = "Seleccionar Provincia"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(42, 300)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(254, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'Modificar_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 389)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txtsuperficieterrestre)
        Me.Controls.Add(Me.Txtregion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txthabitantes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.lblnuevonombreusuario)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.Cbxprov)
        Me.Controls.Add(Me.lblpais)
        Me.Name = "Modificar_Provincia"
        Me.Text = "Modificar_Provincia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtsuperficieterrestre As System.Windows.Forms.TextBox
    Friend WithEvents Txtregion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txthabitantes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblnuevonombreusuario As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents Cbxprov As System.Windows.Forms.ComboBox
    Friend WithEvents lblpais As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
