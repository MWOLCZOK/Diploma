<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Pasajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Pasajero))
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Txtdomicilio = New System.Windows.Forms.TextBox()
        Me.Txtdni = New System.Windows.Forms.TextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.ForeColor = System.Drawing.Color.White
        Me.lblDomicilio.Location = New System.Drawing.Point(214, 108)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(68, 15)
        Me.lblDomicilio.TabIndex = 37
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.Color.White
        Me.lblDNI.Location = New System.Drawing.Point(411, 42)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(31, 15)
        Me.lblDNI.TabIndex = 36
        Me.lblDNI.Text = "DNI"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(13, 107)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(126, 15)
        Me.lblMail.TabIndex = 35
        Me.lblMail.Text = "Correo Electronico"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(214, 41)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(59, 15)
        Me.lblApellido.TabIndex = 34
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(14, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 33
        Me.lblNombre.Text = "Nombre"
        '
        'Txtdomicilio
        '
        Me.Txtdomicilio.Location = New System.Drawing.Point(217, 133)
        Me.Txtdomicilio.Name = "Txtdomicilio"
        Me.Txtdomicilio.Size = New System.Drawing.Size(151, 20)
        Me.Txtdomicilio.TabIndex = 32
        '
        'Txtdni
        '
        Me.Txtdni.Location = New System.Drawing.Point(413, 67)
        Me.Txtdni.Name = "Txtdni"
        Me.Txtdni.Size = New System.Drawing.Size(150, 20)
        Me.Txtdni.TabIndex = 31
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(17, 133)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(149, 20)
        Me.Txtcorreo.TabIndex = 30
        '
        'Txtapellido
        '
        Me.Txtapellido.Location = New System.Drawing.Point(217, 67)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(149, 20)
        Me.Txtapellido.TabIndex = 29
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(16, 67)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(150, 20)
        Me.Txtnombre.TabIndex = 28
        '
        'Txttelefono
        '
        Me.Txttelefono.Location = New System.Drawing.Point(414, 133)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(149, 20)
        Me.Txttelefono.TabIndex = 41
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(410, 107)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(63, 15)
        Me.lblTelefono.TabIndex = 45
        Me.lblTelefono.Text = "Telefono"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(121, 196)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 51
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(323, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Agregar_Pasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 275)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.Txttelefono)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Txtdomicilio)
        Me.Controls.Add(Me.Txtdni)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Txtapellido)
        Me.Controls.Add(Me.Txtnombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Pasajero"
        Me.Text = "Agregar_Pasajero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Txtdomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Btn_agregarpasajero As System.Windows.Forms.Button
    Friend WithEvents Txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
