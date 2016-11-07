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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtmontopago = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Btn_agregarpais = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Cbxmediopago = New System.Windows.Forms.ComboBox()
        Me.Cbxreserva = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 36)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Monto de Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Medio de Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Numero Tarjeta de Credito"
        '
        'Txtmontopago
        '
        Me.Txtmontopago.Location = New System.Drawing.Point(197, 141)
        Me.Txtmontopago.Name = "Txtmontopago"
        Me.Txtmontopago.Size = New System.Drawing.Size(139, 20)
        Me.Txtmontopago.TabIndex = 19
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(21, 225)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(139, 20)
        Me.Txtdescripcion.TabIndex = 16
        '
        'Btn_agregarpais
        '
        Me.Btn_agregarpais.Location = New System.Drawing.Point(45, 279)
        Me.Btn_agregarpais.Name = "Btn_agregarpais"
        Me.Btn_agregarpais.Size = New System.Drawing.Size(87, 36)
        Me.Btn_agregarpais.TabIndex = 15
        Me.Btn_agregarpais.Text = "Confirmar Pago"
        Me.Btn_agregarpais.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Fecha de Pago"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(197, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Cbxmediopago
        '
        Me.Cbxmediopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxmediopago.FormattingEnabled = True
        Me.Cbxmediopago.Location = New System.Drawing.Point(20, 72)
        Me.Cbxmediopago.Name = "Cbxmediopago"
        Me.Cbxmediopago.Size = New System.Drawing.Size(121, 21)
        Me.Cbxmediopago.TabIndex = 27
        '
        'Cbxreserva
        '
        Me.Cbxreserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxreserva.FormattingEnabled = True
        Me.Cbxreserva.Location = New System.Drawing.Point(19, 141)
        Me.Cbxreserva.Name = "Cbxreserva"
        Me.Cbxreserva.Size = New System.Drawing.Size(121, 21)
        Me.Cbxreserva.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Numero Reserva"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(197, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Fin de Pago"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Agregar_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 361)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Cbxreserva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbxmediopago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtmontopago)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Btn_agregarpais)
        Me.Name = "Agregar_Pago"
        Me.Text = "Agregar_Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtmontopago As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Btn_agregarpais As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbxmediopago As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxreserva As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
