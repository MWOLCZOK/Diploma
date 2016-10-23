<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Permisos
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
        Me.lblpermisos = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpermisos
        '
        Me.lblpermisos.AutoSize = True
        Me.lblpermisos.Location = New System.Drawing.Point(20, 77)
        Me.lblpermisos.Name = "lblpermisos"
        Me.lblpermisos.Size = New System.Drawing.Size(49, 13)
        Me.lblpermisos.TabIndex = 13
        Me.lblpermisos.Text = "Permisos"
        '
        'Tree
        '
        Me.Tree.CheckBoxes = True
        Me.Tree.Location = New System.Drawing.Point(23, 93)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(258, 307)
        Me.Tree.TabIndex = 12
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(23, 45)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(257, 20)
        Me.txtnombre.TabIndex = 11
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(20, 29)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 10
        Me.lblnombre.Text = "Nombre"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(206, 422)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 37)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(23, 422)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 37)
        Me.btnCrear.TabIndex = 14
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'gestionPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 504)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.lblpermisos)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Name = "gestionPermisos"
        Me.Text = "gestionPermisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpermisos As System.Windows.Forms.Label
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
End Class
