<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Pasajero
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
        Me.Txtdomicilio = New System.Windows.Forms.TextBox()
        Me.Txtdni = New System.Windows.Forms.TextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txapellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnuevonombreusuario = New System.Windows.Forms.Label()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.Cbxpasajero = New System.Windows.Forms.ComboBox()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txtdomicilio
        '
        Me.Txtdomicilio.Location = New System.Drawing.Point(31, 301)
        Me.Txtdomicilio.Name = "Txtdomicilio"
        Me.Txtdomicilio.Size = New System.Drawing.Size(254, 20)
        Me.Txtdomicilio.TabIndex = 62
        '
        'Txtdni
        '
        Me.Txtdni.Location = New System.Drawing.Point(31, 246)
        Me.Txtdni.Name = "Txtdni"
        Me.Txtdni.Size = New System.Drawing.Size(254, 20)
        Me.Txtdni.TabIndex = 61
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(31, 191)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(254, 20)
        Me.Txtcorreo.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Domicilio"
        '
        'Txapellido
        '
        Me.Txapellido.Location = New System.Drawing.Point(31, 142)
        Me.Txapellido.Name = "Txapellido"
        Me.Txapellido.Size = New System.Drawing.Size(254, 20)
        Me.Txapellido.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Apellido"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(164, 387)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 56
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(54, 387)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 55
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(31, 89)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(254, 20)
        Me.Txtnombre.TabIndex = 54
        '
        'lblnuevonombreusuario
        '
        Me.lblnuevonombreusuario.AutoSize = True
        Me.lblnuevonombreusuario.Location = New System.Drawing.Point(28, 72)
        Me.lblnuevonombreusuario.Name = "lblnuevonombreusuario"
        Me.lblnuevonombreusuario.Size = New System.Drawing.Size(44, 13)
        Me.lblnuevonombreusuario.TabIndex = 53
        Me.lblnuevonombreusuario.Text = "Nombre"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(28, 230)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(26, 13)
        Me.lblperfil.TabIndex = 52
        Me.lblperfil.Text = "DNI"
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(28, 175)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(94, 13)
        Me.lblidioma.TabIndex = 51
        Me.lblidioma.Text = "Correo Electronico"
        '
        'Cbxpasajero
        '
        Me.Cbxpasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpasajero.FormattingEnabled = True
        Me.Cbxpasajero.Location = New System.Drawing.Point(31, 37)
        Me.Cbxpasajero.Name = "Cbxpasajero"
        Me.Cbxpasajero.Size = New System.Drawing.Size(254, 21)
        Me.Cbxpasajero.TabIndex = 50
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Location = New System.Drawing.Point(104, 21)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(107, 13)
        Me.lblpais.TabIndex = 49
        Me.lblpais.Text = "Seleccionar Pasajero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Telefono"
        '
        'Txttelefono
        '
        Me.Txttelefono.Location = New System.Drawing.Point(31, 347)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(254, 20)
        Me.Txttelefono.TabIndex = 67
        '
        'Modificar_Pasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 421)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txttelefono)
        Me.Controls.Add(Me.Txtdomicilio)
        Me.Controls.Add(Me.Txtdni)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txapellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.lblnuevonombreusuario)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.Cbxpasajero)
        Me.Controls.Add(Me.lblpais)
        Me.Name = "Modificar_Pasajero"
        Me.Text = "Modificar_Pasajero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txapellido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnuevonombreusuario As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents Cbxpasajero As System.Windows.Forms.ComboBox
    Friend WithEvents lblpais As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txttelefono As System.Windows.Forms.TextBox
End Class
