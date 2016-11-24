<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Provincia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Provincia))
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblSuperficieTerrestre = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblHabitantes = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Txtsuperficieterrestre = New System.Windows.Forms.TextBox()
        Me.Txtregion = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.ForeColor = System.Drawing.Color.White
        Me.lblPais.Location = New System.Drawing.Point(322, 90)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(35, 15)
        Me.lblPais.TabIndex = 25
        Me.lblPais.Text = "Pais"
        '
        'lblSuperficieTerrestre
        '
        Me.lblSuperficieTerrestre.AutoSize = True
        Me.lblSuperficieTerrestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficieTerrestre.ForeColor = System.Drawing.Color.White
        Me.lblSuperficieTerrestre.Location = New System.Drawing.Point(322, 33)
        Me.lblSuperficieTerrestre.Name = "lblSuperficieTerrestre"
        Me.lblSuperficieTerrestre.Size = New System.Drawing.Size(134, 15)
        Me.lblSuperficieTerrestre.TabIndex = 24
        Me.lblSuperficieTerrestre.Text = "Superficie Terrestre"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.White
        Me.lblRegion.Location = New System.Drawing.Point(29, 149)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(53, 15)
        Me.lblRegion.TabIndex = 23
        Me.lblRegion.Text = "Region"
        '
        'lblHabitantes
        '
        Me.lblHabitantes.AutoSize = True
        Me.lblHabitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitantes.ForeColor = System.Drawing.Color.White
        Me.lblHabitantes.Location = New System.Drawing.Point(29, 90)
        Me.lblHabitantes.Name = "lblHabitantes"
        Me.lblHabitantes.Size = New System.Drawing.Size(76, 15)
        Me.lblHabitantes.TabIndex = 22
        Me.lblHabitantes.Text = "Habitantes"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(29, 33)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre"
        '
        'Txtsuperficieterrestre
        '
        Me.Txtsuperficieterrestre.Location = New System.Drawing.Point(325, 51)
        Me.Txtsuperficieterrestre.Name = "Txtsuperficieterrestre"
        Me.Txtsuperficieterrestre.Size = New System.Drawing.Size(233, 20)
        Me.Txtsuperficieterrestre.TabIndex = 19
        '
        'Txtregion
        '
        Me.Txtregion.Location = New System.Drawing.Point(32, 167)
        Me.Txtregion.Name = "Txtregion"
        Me.Txtregion.Size = New System.Drawing.Size(236, 20)
        Me.Txtregion.TabIndex = 18
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(32, 51)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(236, 20)
        Me.Txtdescripcion.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(325, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(123, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 55
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(325, 216)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(33, 108)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(235, 20)
        Me.NumericUpDown1.TabIndex = 56
        '
        'Agregar_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 290)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblSuperficieTerrestre)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblHabitantes)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtsuperficieterrestre)
        Me.Controls.Add(Me.Txtregion)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Provincia"
        Me.Text = "Agregar_Provincia"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblSuperficieTerrestre As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblHabitantes As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Txtsuperficieterrestre As System.Windows.Forms.TextBox
    Friend WithEvents Txtregion As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
