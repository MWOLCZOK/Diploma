<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancelacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancelacion))
        Me.Txtdni = New System.Windows.Forms.TextBox()
        Me.lblBusquedaDNI = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMontoDevuelto = New System.Windows.Forms.Label()
        Me.Txtmontodevuelto = New System.Windows.Forms.TextBox()
        Me.lblMontoRetenido = New System.Windows.Forms.Label()
        Me.Txtmontoretenido = New System.Windows.Forms.TextBox()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.Txtmontototal = New System.Windows.Forms.TextBox()
        Me.lblMotivoCancelacion = New System.Windows.Forms.Label()
        Me.Txtdecrmotivo = New System.Windows.Forms.TextBox()
        Me.btnCancelarReserva = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcularPunitorios1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtdni
        '
        Me.Txtdni.Location = New System.Drawing.Point(12, 51)
        Me.Txtdni.Name = "Txtdni"
        Me.Txtdni.Size = New System.Drawing.Size(212, 20)
        Me.Txtdni.TabIndex = 0
        '
        'lblBusquedaDNI
        '
        Me.lblBusquedaDNI.AutoSize = True
        Me.lblBusquedaDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusquedaDNI.ForeColor = System.Drawing.Color.White
        Me.lblBusquedaDNI.Location = New System.Drawing.Point(12, 26)
        Me.lblBusquedaDNI.Name = "lblBusquedaDNI"
        Me.lblBusquedaDNI.Size = New System.Drawing.Size(124, 15)
        Me.lblBusquedaDNI.TabIndex = 1
        Me.lblBusquedaDNI.Text = "Busqueda por DNI"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(263, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(586, 292)
        Me.DataGridView1.TabIndex = 2
        '
        'lblMontoDevuelto
        '
        Me.lblMontoDevuelto.AutoSize = True
        Me.lblMontoDevuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoDevuelto.ForeColor = System.Drawing.Color.White
        Me.lblMontoDevuelto.Location = New System.Drawing.Point(12, 89)
        Me.lblMontoDevuelto.Name = "lblMontoDevuelto"
        Me.lblMontoDevuelto.Size = New System.Drawing.Size(107, 15)
        Me.lblMontoDevuelto.TabIndex = 7
        Me.lblMontoDevuelto.Text = "Monto Devuelto"
        '
        'Txtmontodevuelto
        '
        Me.Txtmontodevuelto.Enabled = False
        Me.Txtmontodevuelto.Location = New System.Drawing.Point(12, 114)
        Me.Txtmontodevuelto.Name = "Txtmontodevuelto"
        Me.Txtmontodevuelto.Size = New System.Drawing.Size(212, 20)
        Me.Txtmontodevuelto.TabIndex = 6
        '
        'lblMontoRetenido
        '
        Me.lblMontoRetenido.AutoSize = True
        Me.lblMontoRetenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoRetenido.ForeColor = System.Drawing.Color.White
        Me.lblMontoRetenido.Location = New System.Drawing.Point(12, 148)
        Me.lblMontoRetenido.Name = "lblMontoRetenido"
        Me.lblMontoRetenido.Size = New System.Drawing.Size(109, 15)
        Me.lblMontoRetenido.TabIndex = 9
        Me.lblMontoRetenido.Text = "Monto Retenido"
        '
        'Txtmontoretenido
        '
        Me.Txtmontoretenido.Enabled = False
        Me.Txtmontoretenido.Location = New System.Drawing.Point(12, 173)
        Me.Txtmontoretenido.Name = "Txtmontoretenido"
        Me.Txtmontoretenido.Size = New System.Drawing.Size(212, 20)
        Me.Txtmontoretenido.TabIndex = 8
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTotal.ForeColor = System.Drawing.Color.White
        Me.lblMontoTotal.Location = New System.Drawing.Point(12, 209)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(83, 15)
        Me.lblMontoTotal.TabIndex = 11
        Me.lblMontoTotal.Text = "Monto Total"
        '
        'Txtmontototal
        '
        Me.Txtmontototal.Enabled = False
        Me.Txtmontototal.Location = New System.Drawing.Point(12, 234)
        Me.Txtmontototal.Name = "Txtmontototal"
        Me.Txtmontototal.Size = New System.Drawing.Size(212, 20)
        Me.Txtmontototal.TabIndex = 10
        '
        'lblMotivoCancelacion
        '
        Me.lblMotivoCancelacion.AutoSize = True
        Me.lblMotivoCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoCancelacion.ForeColor = System.Drawing.Color.White
        Me.lblMotivoCancelacion.Location = New System.Drawing.Point(12, 269)
        Me.lblMotivoCancelacion.Name = "lblMotivoCancelacion"
        Me.lblMotivoCancelacion.Size = New System.Drawing.Size(212, 15)
        Me.lblMotivoCancelacion.TabIndex = 13
        Me.lblMotivoCancelacion.Text = "Descripcion Motivo Cancelacion"
        '
        'Txtdecrmotivo
        '
        Me.Txtdecrmotivo.Location = New System.Drawing.Point(12, 294)
        Me.Txtdecrmotivo.Multiline = True
        Me.Txtdecrmotivo.Name = "Txtdecrmotivo"
        Me.Txtdecrmotivo.Size = New System.Drawing.Size(212, 104)
        Me.Txtdecrmotivo.TabIndex = 12
        '
        'btnCancelarReserva
        '
        Me.btnCancelarReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCancelarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarReserva.Location = New System.Drawing.Point(486, 353)
        Me.btnCancelarReserva.Name = "btnCancelarReserva"
        Me.btnCancelarReserva.Size = New System.Drawing.Size(150, 30)
        Me.btnCancelarReserva.TabIndex = 63
        Me.btnCancelarReserva.Text = "Cancelar Reserva"
        Me.btnCancelarReserva.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(699, 353)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 62
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCalcularPunitorios1
        '
        Me.btnCalcularPunitorios1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCalcularPunitorios1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularPunitorios1.Location = New System.Drawing.Point(263, 353)
        Me.btnCalcularPunitorios1.Name = "btnCalcularPunitorios1"
        Me.btnCalcularPunitorios1.Size = New System.Drawing.Size(150, 30)
        Me.btnCalcularPunitorios1.TabIndex = 64
        Me.btnCalcularPunitorios1.Text = "Calcular Punitorios"
        Me.btnCalcularPunitorios1.UseVisualStyleBackColor = False
        '
        'Cancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 427)
        Me.Controls.Add(Me.btnCalcularPunitorios1)
        Me.Controls.Add(Me.btnCancelarReserva)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMotivoCancelacion)
        Me.Controls.Add(Me.Txtdecrmotivo)
        Me.Controls.Add(Me.lblMontoTotal)
        Me.Controls.Add(Me.Txtmontototal)
        Me.Controls.Add(Me.lblMontoRetenido)
        Me.Controls.Add(Me.Txtmontoretenido)
        Me.Controls.Add(Me.lblMontoDevuelto)
        Me.Controls.Add(Me.Txtmontodevuelto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblBusquedaDNI)
        Me.Controls.Add(Me.Txtdni)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cancelacion"
        Me.Text = "Cancelacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdni As System.Windows.Forms.TextBox
    Friend WithEvents lblBusquedaDNI As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMontoDevuelto As System.Windows.Forms.Label
    Friend WithEvents Txtmontodevuelto As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoRetenido As System.Windows.Forms.Label
    Friend WithEvents Txtmontoretenido As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoTotal As System.Windows.Forms.Label
    Friend WithEvents Txtmontototal As System.Windows.Forms.TextBox
    Friend WithEvents lblMotivoCancelacion As System.Windows.Forms.Label
    Friend WithEvents Txtdecrmotivo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarReserva As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcularPunitorios1 As Button
End Class
