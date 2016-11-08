<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reserva_Buscar_Asientos
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtdestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtfechaviaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtempresatrans = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txttipotrans = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtorigen = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btnaceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Destino"
        '
        'Txtdestino
        '
        Me.Txtdestino.BackColor = System.Drawing.SystemColors.Control
        Me.Txtdestino.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdestino.Location = New System.Drawing.Point(275, 40)
        Me.Txtdestino.Multiline = True
        Me.Txtdestino.Name = "Txtdestino"
        Me.Txtdestino.Size = New System.Drawing.Size(222, 20)
        Me.Txtdestino.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha Viaje"
        '
        'Txtfechaviaje
        '
        Me.Txtfechaviaje.BackColor = System.Drawing.SystemColors.Control
        Me.Txtfechaviaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfechaviaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfechaviaje.Location = New System.Drawing.Point(275, 83)
        Me.Txtfechaviaje.Multiline = True
        Me.Txtfechaviaje.Name = "Txtfechaviaje"
        Me.Txtfechaviaje.Size = New System.Drawing.Size(222, 20)
        Me.Txtfechaviaje.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Empresa Transporte"
        '
        'Txtempresatrans
        '
        Me.Txtempresatrans.BackColor = System.Drawing.SystemColors.Control
        Me.Txtempresatrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtempresatrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtempresatrans.Location = New System.Drawing.Point(18, 83)
        Me.Txtempresatrans.Multiline = True
        Me.Txtempresatrans.Name = "Txtempresatrans"
        Me.Txtempresatrans.Size = New System.Drawing.Size(222, 20)
        Me.Txtempresatrans.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tipo Transporte"
        '
        'Txttipotrans
        '
        Me.Txttipotrans.BackColor = System.Drawing.SystemColors.Control
        Me.Txttipotrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttipotrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttipotrans.Location = New System.Drawing.Point(18, 125)
        Me.Txttipotrans.Multiline = True
        Me.Txttipotrans.Name = "Txttipotrans"
        Me.Txttipotrans.Size = New System.Drawing.Size(222, 20)
        Me.Txttipotrans.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Origen"
        '
        'Txtorigen
        '
        Me.Txtorigen.BackColor = System.Drawing.SystemColors.Control
        Me.Txtorigen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtorigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtorigen.Location = New System.Drawing.Point(18, 40)
        Me.Txtorigen.Multiline = True
        Me.Txtorigen.Name = "Txtorigen"
        Me.Txtorigen.Size = New System.Drawing.Size(222, 20)
        Me.Txtorigen.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btnaceptar
        '
        Me.Btnaceptar.Location = New System.Drawing.Point(322, 461)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(100, 39)
        Me.Btnaceptar.TabIndex = 36
        Me.Btnaceptar.Text = "Seleccionar"
        Me.Btnaceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(479, 256)
        Me.DataGridView1.TabIndex = 35
        '
        'Reserva_Buscar_Asientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btnaceptar)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "Reserva_Buscar_Asientos"
        Me.Text = "s"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtdestino As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtfechaviaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtempresatrans As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txttipotrans As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtorigen As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btnaceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
