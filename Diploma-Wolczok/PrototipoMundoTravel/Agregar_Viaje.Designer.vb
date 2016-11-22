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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbxtipotransporte = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbxorigen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbxdestino = New System.Windows.Forms.ComboBox()
        Me.Cbxcena = New System.Windows.Forms.CheckBox()
        Me.Cbxcafeteria = New System.Windows.Forms.CheckBox()
        Me.Cbxalmuerzo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Fechafin = New System.Windows.Forms.DateTimePicker()
        Me.Fechainicio = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Precio"
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(16, 128)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(180, 20)
        Me.Txtprecio.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(428, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Transporte"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Origen"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(219, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Destino"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(428, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Fecha Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(219, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Fecha Inicio"
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Fechafin)
        Me.Controls.Add(Me.Fechainicio)
        Me.Controls.Add(Me.Cbxcena)
        Me.Controls.Add(Me.Cbxcafeteria)
        Me.Controls.Add(Me.Cbxalmuerzo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbxdestino)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbxtipotransporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbxorigen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Viaje"
        Me.Text = "Agregar_Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cbxtipotransporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cbxorigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cbxdestino As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxcena As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxcafeteria As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxalmuerzo As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Fechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
