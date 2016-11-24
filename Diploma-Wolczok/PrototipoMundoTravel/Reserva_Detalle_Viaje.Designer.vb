<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reserva_Detalle_Viaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reserva_Detalle_Viaje))
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Txtorigen = New System.Windows.Forms.TextBox()
        Me.lblTipoTransporte = New System.Windows.Forms.Label()
        Me.Txttipotrans = New System.Windows.Forms.TextBox()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.Txtdestino = New System.Windows.Forms.TextBox()
        Me.lblFechaViaje = New System.Windows.Forms.Label()
        Me.Txtfechaviaje = New System.Windows.Forms.TextBox()
        Me.lblEmpresaTransporte = New System.Windows.Forms.Label()
        Me.Txtempresatrans = New System.Windows.Forms.TextBox()
        Me.lblNumeroAsiento = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGenerarPDF = New System.Windows.Forms.Button()
        Me.btnVolverComprar = New System.Windows.Forms.Button()
        Me.btnFinalizarCompra = New System.Windows.Forms.Button()
        Me.lblValorReserva = New System.Windows.Forms.Label()
        Me.txtValorReserva = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.ForeColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(395, 88)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(50, 15)
        Me.lblOrigen.TabIndex = 44
        Me.lblOrigen.Text = "Origen"
        '
        'Txtorigen
        '
        Me.Txtorigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Txtorigen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtorigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtorigen.ForeColor = System.Drawing.Color.White
        Me.Txtorigen.Location = New System.Drawing.Point(398, 117)
        Me.Txtorigen.Name = "Txtorigen"
        Me.Txtorigen.Size = New System.Drawing.Size(324, 14)
        Me.Txtorigen.TabIndex = 43
        '
        'lblTipoTransporte
        '
        Me.lblTipoTransporte.AutoSize = True
        Me.lblTipoTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTransporte.ForeColor = System.Drawing.Color.White
        Me.lblTipoTransporte.Location = New System.Drawing.Point(395, 21)
        Me.lblTipoTransporte.Name = "lblTipoTransporte"
        Me.lblTipoTransporte.Size = New System.Drawing.Size(108, 15)
        Me.lblTipoTransporte.TabIndex = 42
        Me.lblTipoTransporte.Text = "Tipo Transporte"
        '
        'Txttipotrans
        '
        Me.Txttipotrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Txttipotrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttipotrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttipotrans.ForeColor = System.Drawing.Color.White
        Me.Txttipotrans.Location = New System.Drawing.Point(398, 49)
        Me.Txttipotrans.Name = "Txttipotrans"
        Me.Txttipotrans.Size = New System.Drawing.Size(324, 14)
        Me.Txttipotrans.TabIndex = 41
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.ForeColor = System.Drawing.Color.White
        Me.lblDestino.Location = New System.Drawing.Point(21, 88)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(56, 15)
        Me.lblDestino.TabIndex = 40
        Me.lblDestino.Text = "Destino"
        '
        'Txtdestino
        '
        Me.Txtdestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Txtdestino.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdestino.ForeColor = System.Drawing.Color.White
        Me.Txtdestino.Location = New System.Drawing.Point(24, 117)
        Me.Txtdestino.Name = "Txtdestino"
        Me.Txtdestino.Size = New System.Drawing.Size(324, 14)
        Me.Txtdestino.TabIndex = 39
        '
        'lblFechaViaje
        '
        Me.lblFechaViaje.AutoSize = True
        Me.lblFechaViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaViaje.ForeColor = System.Drawing.Color.White
        Me.lblFechaViaje.Location = New System.Drawing.Point(21, 163)
        Me.lblFechaViaje.Name = "lblFechaViaje"
        Me.lblFechaViaje.Size = New System.Drawing.Size(82, 15)
        Me.lblFechaViaje.TabIndex = 38
        Me.lblFechaViaje.Text = "Fecha Viaje"
        '
        'Txtfechaviaje
        '
        Me.Txtfechaviaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Txtfechaviaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfechaviaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfechaviaje.ForeColor = System.Drawing.Color.White
        Me.Txtfechaviaje.Location = New System.Drawing.Point(24, 190)
        Me.Txtfechaviaje.Name = "Txtfechaviaje"
        Me.Txtfechaviaje.Size = New System.Drawing.Size(324, 14)
        Me.Txtfechaviaje.TabIndex = 37
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.AutoSize = True
        Me.lblEmpresaTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaTransporte.ForeColor = System.Drawing.Color.White
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(21, 21)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(137, 15)
        Me.lblEmpresaTransporte.TabIndex = 36
        Me.lblEmpresaTransporte.Text = "Empresa Transporte"
        '
        'Txtempresatrans
        '
        Me.Txtempresatrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Txtempresatrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtempresatrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtempresatrans.ForeColor = System.Drawing.Color.White
        Me.Txtempresatrans.Location = New System.Drawing.Point(24, 49)
        Me.Txtempresatrans.Name = "Txtempresatrans"
        Me.Txtempresatrans.Size = New System.Drawing.Size(324, 14)
        Me.Txtempresatrans.TabIndex = 35
        '
        'lblNumeroAsiento
        '
        Me.lblNumeroAsiento.AutoSize = True
        Me.lblNumeroAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroAsiento.ForeColor = System.Drawing.Color.White
        Me.lblNumeroAsiento.Location = New System.Drawing.Point(395, 163)
        Me.lblNumeroAsiento.Name = "lblNumeroAsiento"
        Me.lblNumeroAsiento.Size = New System.Drawing.Size(109, 15)
        Me.lblNumeroAsiento.TabIndex = 46
        Me.lblNumeroAsiento.Text = "Numero Asiento"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(398, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 14)
        Me.TextBox1.TabIndex = 45
        '
        'btnGenerarPDF
        '
        Me.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnGenerarPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarPDF.Location = New System.Drawing.Point(299, 353)
        Me.btnGenerarPDF.Name = "btnGenerarPDF"
        Me.btnGenerarPDF.Size = New System.Drawing.Size(150, 30)
        Me.btnGenerarPDF.TabIndex = 78
        Me.btnGenerarPDF.Text = "Generar PDF"
        Me.btnGenerarPDF.UseVisualStyleBackColor = False
        '
        'btnVolverComprar
        '
        Me.btnVolverComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnVolverComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverComprar.Location = New System.Drawing.Point(110, 353)
        Me.btnVolverComprar.Name = "btnVolverComprar"
        Me.btnVolverComprar.Size = New System.Drawing.Size(150, 30)
        Me.btnVolverComprar.TabIndex = 77
        Me.btnVolverComprar.Text = "Volver a Comprar"
        Me.btnVolverComprar.UseVisualStyleBackColor = False
        '
        'btnFinalizarCompra
        '
        Me.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnFinalizarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarCompra.Location = New System.Drawing.Point(488, 353)
        Me.btnFinalizarCompra.Name = "btnFinalizarCompra"
        Me.btnFinalizarCompra.Size = New System.Drawing.Size(150, 30)
        Me.btnFinalizarCompra.TabIndex = 76
        Me.btnFinalizarCompra.Text = "Finalizar Compra"
        Me.btnFinalizarCompra.UseVisualStyleBackColor = False
        '
        'lblValorReserva
        '
        Me.lblValorReserva.AutoSize = True
        Me.lblValorReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorReserva.ForeColor = System.Drawing.Color.White
        Me.lblValorReserva.Location = New System.Drawing.Point(21, 233)
        Me.lblValorReserva.Name = "lblValorReserva"
        Me.lblValorReserva.Size = New System.Drawing.Size(96, 15)
        Me.lblValorReserva.TabIndex = 80
        Me.lblValorReserva.Text = "Valor Reserva"
        '
        'txtValorReserva
        '
        Me.txtValorReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtValorReserva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorReserva.ForeColor = System.Drawing.Color.White
        Me.txtValorReserva.Location = New System.Drawing.Point(24, 265)
        Me.txtValorReserva.Multiline = True
        Me.txtValorReserva.Name = "txtValorReserva"
        Me.txtValorReserva.Size = New System.Drawing.Size(324, 20)
        Me.txtValorReserva.TabIndex = 79
        '
        'Reserva_Detalle_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 423)
        Me.Controls.Add(Me.lblValorReserva)
        Me.Controls.Add(Me.txtValorReserva)
        Me.Controls.Add(Me.btnGenerarPDF)
        Me.Controls.Add(Me.btnVolverComprar)
        Me.Controls.Add(Me.btnFinalizarCompra)
        Me.Controls.Add(Me.lblNumeroAsiento)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.Txtorigen)
        Me.Controls.Add(Me.lblTipoTransporte)
        Me.Controls.Add(Me.Txttipotrans)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.Txtdestino)
        Me.Controls.Add(Me.lblFechaViaje)
        Me.Controls.Add(Me.Txtfechaviaje)
        Me.Controls.Add(Me.lblEmpresaTransporte)
        Me.Controls.Add(Me.Txtempresatrans)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reserva_Detalle_Viaje"
        Me.Text = "Reserva_Detalle_Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents Txtorigen As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoTransporte As System.Windows.Forms.Label
    Friend WithEvents Txttipotrans As System.Windows.Forms.TextBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents Txtdestino As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaViaje As System.Windows.Forms.Label
    Friend WithEvents Txtfechaviaje As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresaTransporte As System.Windows.Forms.Label
    Friend WithEvents Txtempresatrans As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroAsiento As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarPDF As Button
    Friend WithEvents btnVolverComprar As Button
    Friend WithEvents btnFinalizarCompra As Button
    Friend WithEvents lblValorReserva As Label
    Friend WithEvents txtValorReserva As TextBox
End Class
