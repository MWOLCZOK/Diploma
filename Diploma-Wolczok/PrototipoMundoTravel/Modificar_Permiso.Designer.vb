<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Permiso
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
        Me.lblnuevospermisos = New System.Windows.Forms.Label()
        Me.TreeNuevos = New System.Windows.Forms.TreeView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblpermisosactuales = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnuevospermisos
        '
        Me.lblnuevospermisos.AutoSize = True
        Me.lblnuevospermisos.Location = New System.Drawing.Point(308, 69)
        Me.lblnuevospermisos.Name = "lblnuevospermisos"
        Me.lblnuevospermisos.Size = New System.Drawing.Size(89, 13)
        Me.lblnuevospermisos.TabIndex = 26
        Me.lblnuevospermisos.Text = "Nuevos Permisos"
        '
        'TreeNuevos
        '
        Me.TreeNuevos.CheckBoxes = True
        Me.TreeNuevos.Location = New System.Drawing.Point(311, 85)
        Me.TreeNuevos.Name = "TreeNuevos"
        Me.TreeNuevos.Size = New System.Drawing.Size(258, 319)
        Me.TreeNuevos.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'lblpermisosactuales
        '
        Me.lblpermisosactuales.AutoSize = True
        Me.lblpermisosactuales.Location = New System.Drawing.Point(24, 69)
        Me.lblpermisosactuales.Name = "lblpermisosactuales"
        Me.lblpermisosactuales.Size = New System.Drawing.Size(93, 13)
        Me.lblpermisosactuales.TabIndex = 23
        Me.lblpermisosactuales.Text = "Permisos Actuales"
        '
        'Tree
        '
        Me.Tree.Location = New System.Drawing.Point(27, 85)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(258, 319)
        Me.Tree.TabIndex = 22
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(275, 20)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(30, 13)
        Me.lblperfil.TabIndex = 21
        Me.lblperfil.Text = "Perfil"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(322, 434)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 37)
        Me.btnsalir.TabIndex = 28
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(174, 434)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 37)
        Me.btnmodificar.TabIndex = 27
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'ModificarPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 572)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblnuevospermisos)
        Me.Controls.Add(Me.TreeNuevos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblpermisosactuales)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.lblperfil)
        Me.Name = "ModificarPermiso"
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
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
End Class
