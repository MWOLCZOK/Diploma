<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Permiso
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
        Me.lblpermisosactuales = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpermisosactuales
        '
        Me.lblpermisosactuales.AutoSize = True
        Me.lblpermisosactuales.Location = New System.Drawing.Point(9, 56)
        Me.lblpermisosactuales.Name = "lblpermisosactuales"
        Me.lblpermisosactuales.Size = New System.Drawing.Size(93, 13)
        Me.lblpermisosactuales.TabIndex = 26
        Me.lblpermisosactuales.Text = "Permisos Actuales"
        '
        'Tree
        '
        Me.Tree.Location = New System.Drawing.Point(12, 72)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(258, 319)
        Me.Tree.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(118, 12)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(30, 13)
        Me.lblperfil.TabIndex = 23
        Me.lblperfil.Text = "Perfil"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(152, 411)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 37)
        Me.btnsalir.TabIndex = 28
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(48, 411)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 37)
        Me.btneliminar.TabIndex = 27
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'EliminarPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 464)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.lblpermisosactuales)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblperfil)
        Me.Name = "EliminarPermiso"
        Me.Text = "EliminarPermiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpermisosactuales As System.Windows.Forms.Label
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
End Class
