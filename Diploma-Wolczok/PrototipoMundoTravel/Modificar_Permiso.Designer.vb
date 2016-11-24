<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modificar_Permiso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Permiso))
        Me.lblnuevospermisos = New System.Windows.Forms.Label()
        Me.TreeNuevos = New System.Windows.Forms.TreeView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblpermisosactuales = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnuevospermisos
        '
        Me.lblnuevospermisos.AutoSize = True
        Me.lblnuevospermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevospermisos.ForeColor = System.Drawing.Color.White
        Me.lblnuevospermisos.Location = New System.Drawing.Point(306, 85)
        Me.lblnuevospermisos.Name = "lblnuevospermisos"
        Me.lblnuevospermisos.Size = New System.Drawing.Size(118, 15)
        Me.lblnuevospermisos.TabIndex = 26
        Me.lblnuevospermisos.Text = "Nuevos Permisos"
        '
        'TreeNuevos
        '
        Me.TreeNuevos.CheckBoxes = True
        Me.TreeNuevos.Location = New System.Drawing.Point(309, 109)
        Me.TreeNuevos.Name = "TreeNuevos"
        Me.TreeNuevos.Size = New System.Drawing.Size(239, 319)
        Me.TreeNuevos.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(27, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'lblpermisosactuales
        '
        Me.lblpermisosactuales.AutoSize = True
        Me.lblpermisosactuales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpermisosactuales.ForeColor = System.Drawing.Color.White
        Me.lblpermisosactuales.Location = New System.Drawing.Point(24, 85)
        Me.lblpermisosactuales.Name = "lblpermisosactuales"
        Me.lblpermisosactuales.Size = New System.Drawing.Size(125, 15)
        Me.lblpermisosactuales.TabIndex = 23
        Me.lblpermisosactuales.Text = "Permisos Actuales"
        '
        'Tree
        '
        Me.Tree.Location = New System.Drawing.Point(26, 109)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(240, 319)
        Me.Tree.TabIndex = 22
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperfil.ForeColor = System.Drawing.Color.White
        Me.lblperfil.Location = New System.Drawing.Point(24, 20)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(41, 15)
        Me.lblperfil.TabIndex = 21
        Me.lblperfil.Text = "Perfil"
        '
        'lblModificar
        '
        Me.lblModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificar.Location = New System.Drawing.Point(109, 453)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(150, 30)
        Me.lblModificar.TabIndex = 85
        Me.lblModificar.Text = "Modificar"
        Me.lblModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(324, 453)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 84
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Modificar_Permiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 521)
        Me.Controls.Add(Me.lblModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblnuevospermisos)
        Me.Controls.Add(Me.TreeNuevos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblpermisosactuales)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.lblperfil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Permiso"
        Me.Text = "ModificarPermiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnuevospermisos As System.Windows.Forms.Label
    Friend WithEvents TreeNuevos As System.Windows.Forms.TreeView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblpermisosactuales As System.Windows.Forms.Label
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblModificar As Button
    Friend WithEvents btnSalir As Button
End Class
