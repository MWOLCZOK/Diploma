<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Pais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Pais))
        Me.Cbxpais = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarPais = New System.Windows.Forms.Label()
        Me.lblZonaHoraria = New System.Windows.Forms.Label()
        Me.lblPoblacionTotal = New System.Windows.Forms.Label()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Txtzonahorariapais = New System.Windows.Forms.TextBox()
        Me.Txtidiomapais = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPoblacionTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cbxpais
        '
        Me.Cbxpais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpais.FormattingEnabled = True
        Me.Cbxpais.Location = New System.Drawing.Point(35, 68)
        Me.Cbxpais.Name = "Cbxpais"
        Me.Cbxpais.Size = New System.Drawing.Size(219, 21)
        Me.Cbxpais.TabIndex = 33
        '
        'lblSeleccionarPais
        '
        Me.lblSeleccionarPais.AutoSize = True
        Me.lblSeleccionarPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarPais.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarPais.Location = New System.Drawing.Point(32, 41)
        Me.lblSeleccionarPais.Name = "lblSeleccionarPais"
        Me.lblSeleccionarPais.Size = New System.Drawing.Size(115, 15)
        Me.lblSeleccionarPais.TabIndex = 32
        Me.lblSeleccionarPais.Text = "Seleccionar Pais"
        '
        'lblZonaHoraria
        '
        Me.lblZonaHoraria.AutoSize = True
        Me.lblZonaHoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZonaHoraria.ForeColor = System.Drawing.Color.White
        Me.lblZonaHoraria.Location = New System.Drawing.Point(303, 181)
        Me.lblZonaHoraria.Name = "lblZonaHoraria"
        Me.lblZonaHoraria.Size = New System.Drawing.Size(91, 15)
        Me.lblZonaHoraria.TabIndex = 57
        Me.lblZonaHoraria.Text = "Zona Horaria"
        '
        'lblPoblacionTotal
        '
        Me.lblPoblacionTotal.AutoSize = True
        Me.lblPoblacionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoblacionTotal.ForeColor = System.Drawing.Color.White
        Me.lblPoblacionTotal.Location = New System.Drawing.Point(32, 181)
        Me.lblPoblacionTotal.Name = "lblPoblacionTotal"
        Me.lblPoblacionTotal.Size = New System.Drawing.Size(107, 15)
        Me.lblPoblacionTotal.TabIndex = 56
        Me.lblPoblacionTotal.Text = "Poblacion Total"
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.ForeColor = System.Drawing.Color.White
        Me.lblIdioma.Location = New System.Drawing.Point(303, 109)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(51, 15)
        Me.lblIdioma.TabIndex = 55
        Me.lblIdioma.Text = "Idioma"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(31, 113)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 54
        Me.lblNombre.Text = "Nombre"
        '
        'Txtzonahorariapais
        '
        Me.Txtzonahorariapais.Location = New System.Drawing.Point(306, 202)
        Me.Txtzonahorariapais.Name = "Txtzonahorariapais"
        Me.Txtzonahorariapais.Size = New System.Drawing.Size(220, 20)
        Me.Txtzonahorariapais.TabIndex = 53
        '
        'Txtidiomapais
        '
        Me.Txtidiomapais.Location = New System.Drawing.Point(306, 136)
        Me.Txtidiomapais.Name = "Txtidiomapais"
        Me.Txtidiomapais.Size = New System.Drawing.Size(220, 20)
        Me.Txtidiomapais.TabIndex = 52
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(35, 136)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(219, 20)
        Me.txtDescripcion.TabIndex = 51
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(104, 275)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 60
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPoblacionTotal
        '
        Me.txtPoblacionTotal.Location = New System.Drawing.Point(35, 202)
        Me.txtPoblacionTotal.Name = "txtPoblacionTotal"
        Me.txtPoblacionTotal.Size = New System.Drawing.Size(219, 20)
        Me.txtPoblacionTotal.TabIndex = 61
        '
        'Modificar_Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 359)
        Me.Controls.Add(Me.txtPoblacionTotal)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblZonaHoraria)
        Me.Controls.Add(Me.lblPoblacionTotal)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtzonahorariapais)
        Me.Controls.Add(Me.Txtidiomapais)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Cbxpais)
        Me.Controls.Add(Me.lblSeleccionarPais)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Pais"
        Me.Text = "Modificar_Pais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbxpais As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarPais As System.Windows.Forms.Label
    Friend WithEvents lblZonaHoraria As Label
    Friend WithEvents lblPoblacionTotal As Label
    Friend WithEvents lblIdioma As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Txtzonahorariapais As TextBox
    Friend WithEvents Txtidiomapais As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPoblacionTotal As TextBox
End Class
