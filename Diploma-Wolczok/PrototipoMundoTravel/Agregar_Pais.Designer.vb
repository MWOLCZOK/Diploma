<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Pais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Pais))
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Txtidiomapais = New System.Windows.Forms.TextBox()
        Me.Txtzonahorariapais = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.lblPoblacionTotal = New System.Windows.Forms.Label()
        Me.lblZonaHoraria = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Txtpoblacionpais = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(20, 61)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(219, 20)
        Me.Txtdescripcion.TabIndex = 2
        '
        'Txtidiomapais
        '
        Me.Txtidiomapais.Location = New System.Drawing.Point(291, 61)
        Me.Txtidiomapais.Name = "Txtidiomapais"
        Me.Txtidiomapais.Size = New System.Drawing.Size(240, 20)
        Me.Txtidiomapais.TabIndex = 3
        '
        'Txtzonahorariapais
        '
        Me.Txtzonahorariapais.Location = New System.Drawing.Point(291, 135)
        Me.Txtzonahorariapais.Name = "Txtzonahorariapais"
        Me.Txtzonahorariapais.Size = New System.Drawing.Size(240, 20)
        Me.Txtzonahorariapais.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(16, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.ForeColor = System.Drawing.Color.White
        Me.lblIdioma.Location = New System.Drawing.Point(288, 34)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(51, 15)
        Me.lblIdioma.TabIndex = 10
        Me.lblIdioma.Text = "Idioma"
        '
        'lblPoblacionTotal
        '
        Me.lblPoblacionTotal.AutoSize = True
        Me.lblPoblacionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoblacionTotal.ForeColor = System.Drawing.Color.White
        Me.lblPoblacionTotal.Location = New System.Drawing.Point(17, 114)
        Me.lblPoblacionTotal.Name = "lblPoblacionTotal"
        Me.lblPoblacionTotal.Size = New System.Drawing.Size(107, 15)
        Me.lblPoblacionTotal.TabIndex = 11
        Me.lblPoblacionTotal.Text = "Poblacion Total"
        '
        'lblZonaHoraria
        '
        Me.lblZonaHoraria.AutoSize = True
        Me.lblZonaHoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZonaHoraria.ForeColor = System.Drawing.Color.White
        Me.lblZonaHoraria.Location = New System.Drawing.Point(288, 114)
        Me.lblZonaHoraria.Name = "lblZonaHoraria"
        Me.lblZonaHoraria.Size = New System.Drawing.Size(91, 15)
        Me.lblZonaHoraria.TabIndex = 12
        Me.lblZonaHoraria.Text = "Zona Horaria"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(89, 200)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 49
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(291, 200)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Txtpoblacionpais
        '
        Me.Txtpoblacionpais.Location = New System.Drawing.Point(19, 135)
        Me.Txtpoblacionpais.Name = "Txtpoblacionpais"
        Me.Txtpoblacionpais.Size = New System.Drawing.Size(220, 20)
        Me.Txtpoblacionpais.TabIndex = 50
        '
        'Agregar_Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 283)
        Me.Controls.Add(Me.Txtpoblacionpais)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblZonaHoraria)
        Me.Controls.Add(Me.lblPoblacionTotal)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtzonahorariapais)
        Me.Controls.Add(Me.Txtidiomapais)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Pais"
        Me.Text = "Agregar_Pais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Txtidiomapais As System.Windows.Forms.TextBox
    Friend WithEvents Txtzonahorariapais As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblIdioma As System.Windows.Forms.Label
    Friend WithEvents lblPoblacionTotal As System.Windows.Forms.Label
    Friend WithEvents lblZonaHoraria As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Txtpoblacionpais As TextBox
End Class
