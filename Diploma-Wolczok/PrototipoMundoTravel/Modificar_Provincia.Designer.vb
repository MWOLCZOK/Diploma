<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Provincia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Provincia))
        Me.Cbxprov = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarProvincia = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblSuperficieTerrestre = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblHabitantes = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtSuperficieTerrestre = New System.Windows.Forms.TextBox()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtHabitantes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cbxprov
        '
        Me.Cbxprov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxprov.FormattingEnabled = True
        Me.Cbxprov.Location = New System.Drawing.Point(40, 63)
        Me.Cbxprov.Name = "Cbxprov"
        Me.Cbxprov.Size = New System.Drawing.Size(526, 21)
        Me.Cbxprov.TabIndex = 50
        '
        'lblSeleccionarProvincia
        '
        Me.lblSeleccionarProvincia.AutoSize = True
        Me.lblSeleccionarProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarProvincia.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarProvincia.Location = New System.Drawing.Point(37, 38)
        Me.lblSeleccionarProvincia.Name = "lblSeleccionarProvincia"
        Me.lblSeleccionarProvincia.Size = New System.Drawing.Size(146, 15)
        Me.lblSeleccionarProvincia.TabIndex = 49
        Me.lblSeleccionarProvincia.Text = "Seleccionar Provincia"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(333, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 21)
        Me.ComboBox1.TabIndex = 71
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.ForeColor = System.Drawing.Color.White
        Me.lblPais.Location = New System.Drawing.Point(330, 159)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(35, 15)
        Me.lblPais.TabIndex = 70
        Me.lblPais.Text = "Pais"
        '
        'lblSuperficieTerrestre
        '
        Me.lblSuperficieTerrestre.AutoSize = True
        Me.lblSuperficieTerrestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficieTerrestre.ForeColor = System.Drawing.Color.White
        Me.lblSuperficieTerrestre.Location = New System.Drawing.Point(330, 102)
        Me.lblSuperficieTerrestre.Name = "lblSuperficieTerrestre"
        Me.lblSuperficieTerrestre.Size = New System.Drawing.Size(134, 15)
        Me.lblSuperficieTerrestre.TabIndex = 69
        Me.lblSuperficieTerrestre.Text = "Superficie Terrestre"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.White
        Me.lblRegion.Location = New System.Drawing.Point(37, 218)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(53, 15)
        Me.lblRegion.TabIndex = 68
        Me.lblRegion.Text = "Region"
        '
        'lblHabitantes
        '
        Me.lblHabitantes.AutoSize = True
        Me.lblHabitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitantes.ForeColor = System.Drawing.Color.White
        Me.lblHabitantes.Location = New System.Drawing.Point(37, 159)
        Me.lblHabitantes.Name = "lblHabitantes"
        Me.lblHabitantes.Size = New System.Drawing.Size(76, 15)
        Me.lblHabitantes.TabIndex = 67
        Me.lblHabitantes.Text = "Habitantes"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(37, 102)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 66
        Me.lblNombre.Text = "Nombre"
        '
        'txtSuperficieTerrestre
        '
        Me.txtSuperficieTerrestre.Location = New System.Drawing.Point(333, 120)
        Me.txtSuperficieTerrestre.Name = "txtSuperficieTerrestre"
        Me.txtSuperficieTerrestre.Size = New System.Drawing.Size(233, 20)
        Me.txtSuperficieTerrestre.TabIndex = 65
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(40, 236)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(236, 20)
        Me.txtRegion.TabIndex = 64
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(40, 120)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 20)
        Me.txtNombre.TabIndex = 63
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(112, 302)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 85
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(355, 302)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 84
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtHabitantes
        '
        Me.txtHabitantes.Location = New System.Drawing.Point(40, 177)
        Me.txtHabitantes.Name = "txtHabitantes"
        Me.txtHabitantes.Size = New System.Drawing.Size(236, 20)
        Me.txtHabitantes.TabIndex = 86
        '
        'Modificar_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 360)
        Me.Controls.Add(Me.txtHabitantes)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblSuperficieTerrestre)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblHabitantes)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtSuperficieTerrestre)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Cbxprov)
        Me.Controls.Add(Me.lblSeleccionarProvincia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Provincia"
        Me.Text = "Modificar_Provincia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbxprov As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarProvincia As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblPais As Label
    Friend WithEvents lblSuperficieTerrestre As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblHabitantes As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtSuperficieTerrestre As TextBox
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtHabitantes As TextBox
End Class
