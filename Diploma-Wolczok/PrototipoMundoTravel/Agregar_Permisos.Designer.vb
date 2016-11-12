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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Permisos))
        Me.lblpermisos = New System.Windows.Forms.Label()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpermisos
        '
        Me.lblpermisos.AutoSize = True
        Me.lblpermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpermisos.ForeColor = System.Drawing.Color.White
        Me.lblpermisos.Location = New System.Drawing.Point(26, 75)
        Me.lblpermisos.Name = "lblpermisos"
        Me.lblpermisos.Size = New System.Drawing.Size(67, 15)
        Me.lblpermisos.TabIndex = 13
        Me.lblpermisos.Text = "Permisos"
        '
        'Tree
        '
        Me.Tree.CheckBoxes = True
        Me.Tree.Location = New System.Drawing.Point(29, 94)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(352, 307)
        Me.Tree.TabIndex = 12
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(29, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(352, 20)
        Me.txtnombre.TabIndex = 11
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.White
        Me.lblnombre.Location = New System.Drawing.Point(26, 27)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 15)
        Me.lblnombre.TabIndex = 10
        Me.lblnombre.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(29, 426)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 53
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(231, 426)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Agregar_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 493)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblpermisos)
        Me.Controls.Add(Me.Tree)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Permisos"
        Me.Text = "gestionPermisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpermisos As System.Windows.Forms.Label
    Friend WithEvents Tree As System.Windows.Forms.TreeView
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
