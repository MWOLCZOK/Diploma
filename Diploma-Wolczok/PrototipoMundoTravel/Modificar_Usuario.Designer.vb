<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Usuario
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
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.lblnuevonombreusuario = New System.Windows.Forms.Label()
        Me.CbxPerfil = New System.Windows.Forms.ComboBox()
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.CbxUsuario = New System.Windows.Forms.ComboBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(160, 350)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 29
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(50, 350)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(22, 154)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(254, 20)
        Me.TxtNom.TabIndex = 27
        '
        'lblnuevonombreusuario
        '
        Me.lblnuevonombreusuario.AutoSize = True
        Me.lblnuevonombreusuario.Location = New System.Drawing.Point(19, 137)
        Me.lblnuevonombreusuario.Name = "lblnuevonombreusuario"
        Me.lblnuevonombreusuario.Size = New System.Drawing.Size(44, 13)
        Me.lblnuevonombreusuario.TabIndex = 26
        Me.lblnuevonombreusuario.Text = "Nombre"
        '
        'CbxPerfil
        '
        Me.CbxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPerfil.FormattingEnabled = True
        Me.CbxPerfil.Location = New System.Drawing.Point(22, 311)
        Me.CbxPerfil.Name = "CbxPerfil"
        Me.CbxPerfil.Size = New System.Drawing.Size(254, 21)
        Me.CbxPerfil.TabIndex = 25
        '
        'CbxIdioma
        '
        Me.CbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(22, 258)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(254, 21)
        Me.CbxIdioma.TabIndex = 24
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(19, 295)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(30, 13)
        Me.lblperfil.TabIndex = 23
        Me.lblperfil.Text = "Perfil"
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(19, 240)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(38, 13)
        Me.lblidioma.TabIndex = 22
        Me.lblidioma.Text = "Idioma"
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(22, 48)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(254, 21)
        Me.CbxUsuario.TabIndex = 21
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(96, 32)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(102, 13)
        Me.lblusuario.TabIndex = 20
        Me.lblusuario.Text = "Seleccionar Usuario"
        '
        'TxtApe
        '
        Me.TxtApe.Location = New System.Drawing.Point(22, 207)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(254, 20)
        Me.TxtApe.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Apellido"
        '
        'Txtnombreusuario
        '
        Me.Txtnombreusuario.Location = New System.Drawing.Point(22, 106)
        Me.Txtnombreusuario.Name = "Txtnombreusuario"
        Me.Txtnombreusuario.Size = New System.Drawing.Size(254, 20)
        Me.Txtnombreusuario.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre Usuario"
        '
        'Modificar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 396)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnombreusuario)
        Me.Controls.Add(Me.TxtApe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.lblnuevonombreusuario)
        Me.Controls.Add(Me.CbxPerfil)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.CbxUsuario)
        Me.Controls.Add(Me.lblusuario)
        Me.Name = "Modificar_Usuario"
        Me.Text = "Modificar_Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblnuevonombreusuario As System.Windows.Forms.Label
    Friend WithEvents CbxPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents CbxIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents TxtApe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
