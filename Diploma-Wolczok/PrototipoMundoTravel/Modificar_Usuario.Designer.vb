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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Usuario))
        Me.CbxUsuario = New System.Windows.Forms.ComboBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.CbxPerfil = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblRepetirContraseñaUsuario = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(35, 48)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(435, 21)
        Me.CbxUsuario.TabIndex = 21
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.White
        Me.lblusuario.Location = New System.Drawing.Point(32, 24)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(137, 15)
        Me.lblusuario.TabIndex = 20
        Me.lblusuario.Text = "Seleccionar Usuario"
        '
        'CbxPerfil
        '
        Me.CbxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPerfil.FormattingEnabled = True
        Me.CbxPerfil.Location = New System.Drawing.Point(279, 259)
        Me.CbxPerfil.Name = "CbxPerfil"
        Me.CbxPerfil.Size = New System.Drawing.Size(191, 21)
        Me.CbxPerfil.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(276, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Seleccionar Perfil"
        '
        'CbxIdioma
        '
        Me.CbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(279, 184)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(191, 21)
        Me.CbxIdioma.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(276, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Seleccionar Idioma"
        '
        'TxtApe
        '
        Me.TxtApe.Location = New System.Drawing.Point(279, 116)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(191, 20)
        Me.TxtApe.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(276, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 333)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(191, 20)
        Me.txtNombre.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombre"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(35, 259)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(191, 20)
        Me.TextBox3.TabIndex = 39
        '
        'lblRepetirContraseñaUsuario
        '
        Me.lblRepetirContraseñaUsuario.AutoSize = True
        Me.lblRepetirContraseñaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepetirContraseñaUsuario.ForeColor = System.Drawing.Color.White
        Me.lblRepetirContraseñaUsuario.Location = New System.Drawing.Point(32, 232)
        Me.lblRepetirContraseñaUsuario.Name = "lblRepetirContraseñaUsuario"
        Me.lblRepetirContraseñaUsuario.Size = New System.Drawing.Size(185, 15)
        Me.lblRepetirContraseñaUsuario.TabIndex = 38
        Me.lblRepetirContraseñaUsuario.Text = "Repetir Contraseña Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(35, 184)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(191, 20)
        Me.TextBox2.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(32, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Contraseña Usuario"
        '
        'Txtnombreusuario
        '
        Me.Txtnombreusuario.Location = New System.Drawing.Point(35, 116)
        Me.Txtnombreusuario.Name = "Txtnombreusuario"
        Me.Txtnombreusuario.Size = New System.Drawing.Size(191, 20)
        Me.Txtnombreusuario.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(32, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nombre Usuario"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(73, 415)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 87
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(288, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Modificar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 490)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CbxPerfil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtApe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblRepetirContraseñaUsuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txtnombreusuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbxUsuario)
        Me.Controls.Add(Me.lblusuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Usuario"
        Me.Text = "Modificar_Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents CbxPerfil As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbxIdioma As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblRepetirContraseñaUsuario As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtnombreusuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
End Class
