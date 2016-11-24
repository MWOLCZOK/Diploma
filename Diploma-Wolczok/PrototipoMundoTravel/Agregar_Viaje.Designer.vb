<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Viaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Viaje))
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.lblTransporte = New System.Windows.Forms.Label()
        Me.Cbxtipotransporte = New System.Windows.Forms.ComboBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Cbxorigen = New System.Windows.Forms.ComboBox()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.Cbxdestino = New System.Windows.Forms.ComboBox()
        Me.Cbxcena = New System.Windows.Forms.CheckBox()
        Me.Cbxcafeteria = New System.Windows.Forms.CheckBox()
        Me.Cbxalmuerzo = New System.Windows.Forms.CheckBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Fechafin = New System.Windows.Forms.DateTimePicker()
        Me.Fechainicio = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.White
        Me.lblPrecio.Location = New System.Drawing.Point(13, 110)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(48, 15)
        Me.lblPrecio.TabIndex = 35
        Me.lblPrecio.Text = "Precio"
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(16, 128)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(180, 20)
        Me.Txtprecio.TabIndex = 34
        '
        'lblTransporte
        '
        Me.lblTransporte.AutoSize = True
        Me.lblTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransporte.ForeColor = System.Drawing.Color.White
        Me.lblTransporte.Location = New System.Drawing.Point(428, 40)
        Me.lblTransporte.Name = "lblTransporte"
        Me.lblTransporte.Size = New System.Drawing.Size(76, 15)
        Me.lblTransporte.TabIndex = 23
        Me.lblTransporte.Text = "Transporte"
        '
        'Cbxtipotransporte
        '
        Me.Cbxtipotransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxtipotransporte.FormattingEnabled = True
        Me.Cbxtipotransporte.Location = New System.Drawing.Point(431, 59)
        Me.Cbxtipotransporte.Name = "Cbxtipotransporte"
        Me.Cbxtipotransporte.Size = New System.Drawing.Size(180, 21)
        Me.Cbxtipotransporte.TabIndex = 22
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.ForeColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(13, 40)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(50, 15)
        Me.lblOrigen.TabIndex = 21
        Me.lblOrigen.Text = "Origen"
        '
        'Cbxorigen
        '
        Me.Cbxorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxorigen.FormattingEnabled = True
        Me.Cbxorigen.Location = New System.Drawing.Point(16, 59)
        Me.Cbxorigen.Name = "Cbxorigen"
        Me.Cbxorigen.Size = New System.Drawing.Size(180, 21)
        Me.Cbxorigen.TabIndex = 20
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.ForeColor = System.Drawing.Color.White
        Me.lblDestino.Location = New System.Drawing.Point(219, 41)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(56, 15)
        Me.lblDestino.TabIndex = 37
        Me.lblDestino.Text = "Destino"
        '
        'Cbxdestino
        '
        Me.Cbxdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxdestino.FormattingEnabled = True
        Me.Cbxdestino.Location = New System.Drawing.Point(222, 59)
        Me.Cbxdestino.Name = "Cbxdestino"
        Me.Cbxdestino.Size = New System.Drawing.Size(180, 21)
        Me.Cbxdestino.TabIndex = 36
        '
        'Cbxcena
        '
        Me.Cbxcena.AutoSize = True
        Me.Cbxcena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxcena.ForeColor = System.Drawing.Color.White
        Me.Cbxcena.Location = New System.Drawing.Point(481, 185)
        Me.Cbxcena.Name = "Cbxcena"
        Me.Cbxcena.Size = New System.Drawing.Size(59, 19)
        Me.Cbxcena.TabIndex = 41
        Me.Cbxcena.Text = "Cena"
        Me.Cbxcena.UseVisualStyleBackColor = True
        '
        'Cbxcafeteria
        '
        Me.Cbxcafeteria.AutoSize = True
        Me.Cbxcafeteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxcafeteria.ForeColor = System.Drawing.Color.White
        Me.Cbxcafeteria.Location = New System.Drawing.Point(66, 185)
        Me.Cbxcafeteria.Name = "Cbxcafeteria"
        Me.Cbxcafeteria.Size = New System.Drawing.Size(84, 19)
        Me.Cbxcafeteria.TabIndex = 40
        Me.Cbxcafeteria.Text = "Cafeteria"
        Me.Cbxcafeteria.UseVisualStyleBackColor = True
        '
        'Cbxalmuerzo
        '
        Me.Cbxalmuerzo.AutoSize = True
        Me.Cbxalmuerzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxalmuerzo.ForeColor = System.Drawing.Color.White
        Me.Cbxalmuerzo.Location = New System.Drawing.Point(272, 185)
        Me.Cbxalmuerzo.Name = "Cbxalmuerzo"
        Me.Cbxalmuerzo.Size = New System.Drawing.Size(86, 19)
        Me.Cbxalmuerzo.TabIndex = 38
        Me.Cbxalmuerzo.Text = "Almuerzo"
        Me.Cbxalmuerzo.UseVisualStyleBackColor = True
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.Color.White
        Me.lblFechaFin.Location = New System.Drawing.Point(428, 108)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 15)
        Me.lblFechaFin.TabIndex = 47
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.Color.White
        Me.lblFechaInicio.Location = New System.Drawing.Point(219, 108)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 15)
        Me.lblFechaInicio.TabIndex = 46
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'Fechafin
        '
        Me.Fechafin.Location = New System.Drawing.Point(431, 128)
        Me.Fechafin.Name = "Fechafin"
        Me.Fechafin.Size = New System.Drawing.Size(180, 20)
        Me.Fechafin.TabIndex = 45
        '
        'Fechainicio
        '
        Me.Fechainicio.Location = New System.Drawing.Point(222, 128)
        Me.Fechainicio.Name = "Fechainicio"
        Me.Fechainicio.Size = New System.Drawing.Size(180, 20)
        Me.Fechainicio.TabIndex = 44
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(109, 241)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 61
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(377, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Agregar_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(643, 304)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.Fechafin)
        Me.Controls.Add(Me.Fechainicio)
        Me.Controls.Add(Me.Cbxcena)
        Me.Controls.Add(Me.Cbxcafeteria)
        Me.Controls.Add(Me.Cbxalmuerzo)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.Cbxdestino)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.lblTransporte)
        Me.Controls.Add(Me.Cbxtipotransporte)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.Cbxorigen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Viaje"
        Me.Text = "Agregar_Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents Txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents lblTransporte As System.Windows.Forms.Label
    Friend WithEvents Cbxtipotransporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents Cbxorigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents Cbxdestino As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxcena As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxcafeteria As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxalmuerzo As System.Windows.Forms.CheckBox
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents Fechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
