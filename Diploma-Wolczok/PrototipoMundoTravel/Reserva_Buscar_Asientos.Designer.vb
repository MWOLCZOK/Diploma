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
        Me.Label4.Location = New System.Drawing.Point(9, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Destino"
        '
        'Txtdestino
        '
        Me.Txtdestino.Location = New System.Drawing.Point(12, 122)
        Me.Txtdestino.Name = "Txtdestino"
        Me.Txtdestino.Size = New System.Drawing.Size(428, 20)
        Me.Txtdestino.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha Viaje"
        '
        'Txtfechaviaje
        '
        Me.Txtfechaviaje.Location = New System.Drawing.Point(12, 213)
        Me.Txtfechaviaje.Name = "Txtfechaviaje"
        Me.Txtfechaviaje.Size = New System.Drawing.Size(190, 20)
        Me.Txtfechaviaje.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Empresa Transporte"
        '
        'Txtempresatrans
        '
        Me.Txtempresatrans.Location = New System.Drawing.Point(12, 40)
        Me.Txtempresatrans.Name = "Txtempresatrans"
        Me.Txtempresatrans.Size = New System.Drawing.Size(428, 20)
        Me.Txtempresatrans.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tipo Transporte"
        '
        'Txttipotrans
        '
        Me.Txttipotrans.Location = New System.Drawing.Point(12, 83)
        Me.Txttipotrans.Name = "Txttipotrans"
        Me.Txttipotrans.Size = New System.Drawing.Size(428, 20)
        Me.Txttipotrans.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Origen"
        '
        'Txtorigen
        '
        Me.Txtorigen.Location = New System.Drawing.Point(12, 164)
        Me.Txtorigen.Name = "Txtorigen"
        Me.Txtorigen.Size = New System.Drawing.Size(428, 20)
        Me.Txtorigen.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btnaceptar
        '
        Me.Btnaceptar.Location = New System.Drawing.Point(290, 538)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(100, 39)
        Me.Btnaceptar.TabIndex = 36
        Me.Btnaceptar.Text = "Seleccionar"
        Me.Btnaceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(428, 256)
        Me.DataGridView1.TabIndex = 35
        '
        'Reserva_Buscar_Asientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 619)
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
        Me.Text = "Reserva_Buscar_Asientos"
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
