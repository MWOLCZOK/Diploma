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
        Me.lblSeleccionarUsuario = New System.Windows.Forms.Label()
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblnuevospermisos = New System.Windows.Forms.Label()
        Me.lblpermisosactuales = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(35, 48)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(191, 21)
        Me.CbxUsuario.TabIndex = 21
        '
        'lblSeleccionarUsuario
        '
        Me.lblSeleccionarUsuario.AutoSize = True
        Me.lblSeleccionarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarUsuario.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarUsuario.Location = New System.Drawing.Point(32, 24)
        Me.lblSeleccionarUsuario.Name = "lblSeleccionarUsuario"
        Me.lblSeleccionarUsuario.Size = New System.Drawing.Size(137, 15)
        Me.lblSeleccionarUsuario.TabIndex = 20
        Me.lblSeleccionarUsuario.Text = "Seleccionar Usuario"
        '
        'CbxIdioma
        '
        Me.CbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(35, 316)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(191, 21)
        Me.CbxIdioma.TabIndex = 45
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.ForeColor = System.Drawing.Color.White
        Me.lblIdioma.Location = New System.Drawing.Point(32, 290)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(131, 15)
        Me.lblIdioma.TabIndex = 44
        Me.lblIdioma.Text = "Seleccionar Idioma"
        '
        'TxtApe
        '
        Me.TxtApe.Location = New System.Drawing.Point(35, 249)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(191, 20)
        Me.TxtApe.TabIndex = 5
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(32, 225)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(59, 15)
        Me.lblApellido.TabIndex = 42
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 186)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(191, 20)
        Me.txtNombre.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(32, 163)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'Txtnombreusuario
        '
        Me.Txtnombreusuario.Location = New System.Drawing.Point(35, 120)
        Me.Txtnombreusuario.Name = "Txtnombreusuario"
        Me.Txtnombreusuario.ReadOnly = True
        Me.Txtnombreusuario.Size = New System.Drawing.Size(191, 20)
        Me.Txtnombreusuario.TabIndex = 1
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(32, 97)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(112, 15)
        Me.lblNombreUsuario.TabIndex = 34
        Me.lblNombreUsuario.Text = "Nombre Usuario"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(214, 419)
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
        Me.btnSalir.Location = New System.Drawing.Point(501, 419)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblnuevospermisos
        '
        Me.lblnuevospermisos.AutoSize = True
        Me.lblnuevospermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevospermisos.ForeColor = System.Drawing.Color.White
        Me.lblnuevospermisos.Location = New System.Drawing.Point(552, 24)
        Me.lblnuevospermisos.Name = "lblnuevospermisos"
        Me.lblnuevospermisos.Size = New System.Drawing.Size(118, 15)
        Me.lblnuevospermisos.TabIndex = 91
        Me.lblnuevospermisos.Text = "Nuevos Permisos"
        '
        'lblpermisosactuales
        '
        Me.lblpermisosactuales.AutoSize = True
        Me.lblpermisosactuales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpermisosactuales.ForeColor = System.Drawing.Color.White
        Me.lblpermisosactuales.Location = New System.Drawing.Point(269, 24)
        Me.lblpermisosactuales.Name = "lblpermisosactuales"
        Me.lblpermisosactuales.Size = New System.Drawing.Size(125, 15)
        Me.lblpermisosactuales.TabIndex = 89
        Me.lblpermisosactuales.Text = "Permisos Actuales"
        '
        'Tree
        '
        Me.Tree.Location = New System.Drawing.Point(272, 48)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(240, 336)
        Me.Tree.TabIndex = 88
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(555, 48)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(242, 340)
        Me.TreeView1.TabIndex = 92
        '
        'Modificar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 469)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.lblnuevospermisos)
        Me.Controls.Add(Me.lblpermisosactuales)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.TxtApe)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtnombreusuario)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.CbxUsuario)
        Me.Controls.Add(Me.lblSeleccionarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Usuario"
        Me.Text = "Modificar_Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarUsuario As System.Windows.Forms.Label
    Friend WithEvents CbxIdioma As ComboBox
    Friend WithEvents lblIdioma As Label
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents Txtnombreusuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblnuevospermisos As Label
    Friend WithEvents lblpermisosactuales As Label
    Friend WithEvents Tree As TreeView
    Friend WithEvents TreeView1 As TreeView
End Class
