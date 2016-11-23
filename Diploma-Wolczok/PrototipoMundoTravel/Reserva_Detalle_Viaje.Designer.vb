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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtorigen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txttipotrans = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtdestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtfechaviaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtempresatrans = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGenerarPDF = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFinalizarCompra = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorReserva = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(395, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Origen"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(395, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Tipo Transporte"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Destino"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Fecha Viaje"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Empresa Transporte"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(395, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Numero Asiento"
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(110, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 30)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Volver a Comprar"
        Me.Button3.UseVisualStyleBackColor = False
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Valor Reserva"
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
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtValorReserva)
        Me.Controls.Add(Me.btnGenerarPDF)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnFinalizarCompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtorigen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txttipotrans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtdestino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtfechaviaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtempresatrans)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reserva_Detalle_Viaje"
        Me.Text = "Reserva_Detalle_Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtorigen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txttipotrans As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtdestino As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtfechaviaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtempresatrans As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarPDF As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnFinalizarCompra As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValorReserva As TextBox
End Class
