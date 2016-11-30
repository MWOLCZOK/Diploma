<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Localidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Localidad))
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.Cbxloc = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarLocalidad = New System.Windows.Forms.Label()
        Me.Cbxprov = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblHabitantes = New System.Windows.Forms.Label()
        Me.lblCantidadBarrios = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtHabitantes = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.ForeColor = System.Drawing.Color.White
        Me.lblProvincia.Location = New System.Drawing.Point(272, 38)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(66, 15)
        Me.lblProvincia.TabIndex = 66
        Me.lblProvincia.Text = "Provincia"
        '
        'Cbxloc
        '
        Me.Cbxloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxloc.FormattingEnabled = True
        Me.Cbxloc.Location = New System.Drawing.Point(33, 66)
        Me.Cbxloc.Name = "Cbxloc"
        Me.Cbxloc.Size = New System.Drawing.Size(203, 21)
        Me.Cbxloc.TabIndex = 64
        '
        'lblSeleccionarLocalidad
        '
        Me.lblSeleccionarLocalidad.AutoSize = True
        Me.lblSeleccionarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarLocalidad.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarLocalidad.Location = New System.Drawing.Point(32, 38)
        Me.lblSeleccionarLocalidad.Name = "lblSeleccionarLocalidad"
        Me.lblSeleccionarLocalidad.Size = New System.Drawing.Size(150, 15)
        Me.lblSeleccionarLocalidad.TabIndex = 63
        Me.lblSeleccionarLocalidad.Text = "Seleccionar Localidad"
        '
        'Cbxprov
        '
        Me.Cbxprov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxprov.FormattingEnabled = True
        Me.Cbxprov.Location = New System.Drawing.Point(275, 66)
        Me.Cbxprov.Name = "Cbxprov"
        Me.Cbxprov.Size = New System.Drawing.Size(204, 21)
        Me.Cbxprov.TabIndex = 75
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(35, 135)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(204, 20)
        Me.NumericUpDown1.TabIndex = 78
        '
        'lblHabitantes
        '
        Me.lblHabitantes.AutoSize = True
        Me.lblHabitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitantes.ForeColor = System.Drawing.Color.White
        Me.lblHabitantes.Location = New System.Drawing.Point(272, 105)
        Me.lblHabitantes.Name = "lblHabitantes"
        Me.lblHabitantes.Size = New System.Drawing.Size(76, 15)
        Me.lblHabitantes.TabIndex = 77
        Me.lblHabitantes.Text = "Habitantes"
        '
        'lblCantidadBarrios
        '
        Me.lblCantidadBarrios.AutoSize = True
        Me.lblCantidadBarrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadBarrios.ForeColor = System.Drawing.Color.White
        Me.lblCantidadBarrios.Location = New System.Drawing.Point(32, 105)
        Me.lblCantidadBarrios.Name = "lblCantidadBarrios"
        Me.lblCantidadBarrios.Size = New System.Drawing.Size(114, 15)
        Me.lblCantidadBarrios.TabIndex = 76
        Me.lblCantidadBarrios.Text = "Cantidad Barrios"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(75, 215)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 81
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(290, 215)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 80
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtHabitantes
        '
        Me.txtHabitantes.Location = New System.Drawing.Point(275, 134)
        Me.txtHabitantes.Name = "txtHabitantes"
        Me.txtHabitantes.Size = New System.Drawing.Size(204, 20)
        Me.txtHabitantes.TabIndex = 82
        '
        'Modificar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 289)
        Me.Controls.Add(Me.txtHabitantes)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblHabitantes)
        Me.Controls.Add(Me.lblCantidadBarrios)
        Me.Controls.Add(Me.Cbxprov)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.Cbxloc)
        Me.Controls.Add(Me.lblSeleccionarLocalidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Localidad"
        Me.Text = "Modificar_Localidad"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents Cbxloc As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarLocalidad As System.Windows.Forms.Label
    Friend WithEvents Cbxprov As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblHabitantes As Label
    Friend WithEvents lblCantidadBarrios As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtHabitantes As TextBox
End Class
