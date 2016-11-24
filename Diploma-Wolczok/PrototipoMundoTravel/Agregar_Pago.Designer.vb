<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Pago))
        Me.lblMontoPago = New System.Windows.Forms.Label()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.lblNumeroTarjeta = New System.Windows.Forms.Label()
        Me.Txtmontopago = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Cbxmediopago = New System.Windows.Forms.ComboBox()
        Me.Cbxreserva = New System.Windows.Forms.ComboBox()
        Me.lblNumeroReserva = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMontoPago
        '
        Me.lblMontoPago.AutoSize = True
        Me.lblMontoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoPago.ForeColor = System.Drawing.Color.White
        Me.lblMontoPago.Location = New System.Drawing.Point(295, 61)
        Me.lblMontoPago.Name = "lblMontoPago"
        Me.lblMontoPago.Size = New System.Drawing.Size(104, 15)
        Me.lblMontoPago.TabIndex = 23
        Me.lblMontoPago.Text = "Monto de Pago"
        '
        'lblMedioPago
        '
        Me.lblMedioPago.AutoSize = True
        Me.lblMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.ForeColor = System.Drawing.Color.White
        Me.lblMedioPago.Location = New System.Drawing.Point(29, 57)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.Size = New System.Drawing.Size(104, 15)
        Me.lblMedioPago.TabIndex = 22
        Me.lblMedioPago.Text = "Medio de Pago"
        '
        'lblNumeroTarjeta
        '
        Me.lblNumeroTarjeta.AutoSize = True
        Me.lblNumeroTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroTarjeta.ForeColor = System.Drawing.Color.White
        Me.lblNumeroTarjeta.Location = New System.Drawing.Point(295, 130)
        Me.lblNumeroTarjeta.Name = "lblNumeroTarjeta"
        Me.lblNumeroTarjeta.Size = New System.Drawing.Size(177, 15)
        Me.lblNumeroTarjeta.TabIndex = 20
        Me.lblNumeroTarjeta.Text = "Numero Tarjeta de Credito"
        '
        'Txtmontopago
        '
        Me.Txtmontopago.Location = New System.Drawing.Point(298, 84)
        Me.Txtmontopago.Name = "Txtmontopago"
        Me.Txtmontopago.Size = New System.Drawing.Size(219, 20)
        Me.Txtmontopago.TabIndex = 19
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(298, 154)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(219, 20)
        Me.Txtdescripcion.TabIndex = 16
        '
        'Cbxmediopago
        '
        Me.Cbxmediopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxmediopago.FormattingEnabled = True
        Me.Cbxmediopago.Location = New System.Drawing.Point(31, 84)
        Me.Cbxmediopago.Name = "Cbxmediopago"
        Me.Cbxmediopago.Size = New System.Drawing.Size(221, 21)
        Me.Cbxmediopago.TabIndex = 27
        '
        'Cbxreserva
        '
        Me.Cbxreserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxreserva.FormattingEnabled = True
        Me.Cbxreserva.Location = New System.Drawing.Point(30, 153)
        Me.Cbxreserva.Name = "Cbxreserva"
        Me.Cbxreserva.Size = New System.Drawing.Size(222, 21)
        Me.Cbxreserva.TabIndex = 31
        '
        'lblNumeroReserva
        '
        Me.lblNumeroReserva.AutoSize = True
        Me.lblNumeroReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroReserva.ForeColor = System.Drawing.Color.White
        Me.lblNumeroReserva.Location = New System.Drawing.Point(29, 130)
        Me.lblNumeroReserva.Name = "lblNumeroReserva"
        Me.lblNumeroReserva.Size = New System.Drawing.Size(114, 15)
        Me.lblNumeroReserva.TabIndex = 30
        Me.lblNumeroReserva.Text = "Numero Reserva"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(310, 227)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(82, 227)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 49
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Agregar_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 310)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Cbxreserva)
        Me.Controls.Add(Me.lblNumeroReserva)
        Me.Controls.Add(Me.Cbxmediopago)
        Me.Controls.Add(Me.lblMontoPago)
        Me.Controls.Add(Me.lblMedioPago)
        Me.Controls.Add(Me.lblNumeroTarjeta)
        Me.Controls.Add(Me.Txtmontopago)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Pago"
        Me.Text = "Agregar_Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMontoPago As System.Windows.Forms.Label
    Friend WithEvents lblMedioPago As System.Windows.Forms.Label
    Friend WithEvents lblNumeroTarjeta As System.Windows.Forms.Label
    Friend WithEvents Txtmontopago As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Cbxmediopago As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxreserva As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumeroReserva As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
