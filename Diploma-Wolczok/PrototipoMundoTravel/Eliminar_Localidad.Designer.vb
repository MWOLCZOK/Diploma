<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Localidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Localidad))
        Me.CbxLoc = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarLocalidad = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbxLoc
        '
        Me.CbxLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxLoc.FormattingEnabled = True
        Me.CbxLoc.Location = New System.Drawing.Point(43, 106)
        Me.CbxLoc.Name = "CbxLoc"
        Me.CbxLoc.Size = New System.Drawing.Size(344, 21)
        Me.CbxLoc.TabIndex = 33
        '
        'lblSeleccionarLocalidad
        '
        Me.lblSeleccionarLocalidad.AutoSize = True
        Me.lblSeleccionarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarLocalidad.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarLocalidad.Location = New System.Drawing.Point(40, 79)
        Me.lblSeleccionarLocalidad.Name = "lblSeleccionarLocalidad"
        Me.lblSeleccionarLocalidad.Size = New System.Drawing.Size(150, 15)
        Me.lblSeleccionarLocalidad.TabIndex = 32
        Me.lblSeleccionarLocalidad.Text = "Seleccionar Localidad"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(43, 174)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 30)
        Me.btnEliminar.TabIndex = 67
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(237, 174)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Eliminar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(444, 262)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CbxLoc)
        Me.Controls.Add(Me.lblSeleccionarLocalidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Eliminar_Localidad"
        Me.Text = "Eliminar_Localidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxLoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarLocalidad As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
End Class
