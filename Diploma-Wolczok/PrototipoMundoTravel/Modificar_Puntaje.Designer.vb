<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Puntaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Puntaje))
        Me.Cbxpuntaje = New System.Windows.Forms.ComboBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Txtpuntaje = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTipoPuntaje = New System.Windows.Forms.Label()
        Me.lblCoeficiente = New System.Windows.Forms.Label()
        Me.lblSeleccionarTipoPuntaje = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbxpuntaje
        '
        Me.Cbxpuntaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpuntaje.FormattingEnabled = True
        Me.Cbxpuntaje.Location = New System.Drawing.Point(34, 51)
        Me.Cbxpuntaje.Name = "Cbxpuntaje"
        Me.Cbxpuntaje.Size = New System.Drawing.Size(180, 21)
        Me.Cbxpuntaje.TabIndex = 0
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Txtdescripcion.Location = New System.Drawing.Point(34, 125)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(180, 20)
        Me.Txtdescripcion.TabIndex = 1
        '
        'Txtpuntaje
        '
        Me.Txtpuntaje.Location = New System.Drawing.Point(247, 125)
        Me.Txtpuntaje.Name = "Txtpuntaje"
        Me.Txtpuntaje.Size = New System.Drawing.Size(180, 20)
        Me.Txtpuntaje.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(393, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'lblTipoPuntaje
        '
        Me.lblTipoPuntaje.AutoSize = True
        Me.lblTipoPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPuntaje.ForeColor = System.Drawing.Color.White
        Me.lblTipoPuntaje.Location = New System.Drawing.Point(31, 95)
        Me.lblTipoPuntaje.Name = "lblTipoPuntaje"
        Me.lblTipoPuntaje.Size = New System.Drawing.Size(108, 15)
        Me.lblTipoPuntaje.TabIndex = 6
        Me.lblTipoPuntaje.Text = "Tipo de Puntaje"
        '
        'lblCoeficiente
        '
        Me.lblCoeficiente.AutoSize = True
        Me.lblCoeficiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoeficiente.ForeColor = System.Drawing.Color.White
        Me.lblCoeficiente.Location = New System.Drawing.Point(244, 95)
        Me.lblCoeficiente.Name = "lblCoeficiente"
        Me.lblCoeficiente.Size = New System.Drawing.Size(79, 15)
        Me.lblCoeficiente.TabIndex = 7
        Me.lblCoeficiente.Text = "Coeficiente"
        '
        'lblSeleccionarTipoPuntaje
        '
        Me.lblSeleccionarTipoPuntaje.AutoSize = True
        Me.lblSeleccionarTipoPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarTipoPuntaje.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarTipoPuntaje.Location = New System.Drawing.Point(31, 28)
        Me.lblSeleccionarTipoPuntaje.Name = "lblSeleccionarTipoPuntaje"
        Me.lblSeleccionarTipoPuntaje.Size = New System.Drawing.Size(195, 15)
        Me.lblSeleccionarTipoPuntaje.TabIndex = 8
        Me.lblSeleccionarTipoPuntaje.Text = "Selección de Tipo de Puntaje"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(34, 366)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 87
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(277, 366)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Modificar_Puntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 464)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblSeleccionarTipoPuntaje)
        Me.Controls.Add(Me.lblCoeficiente)
        Me.Controls.Add(Me.lblTipoPuntaje)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txtpuntaje)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Cbxpuntaje)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Puntaje"
        Me.Text = "Modificar_Puntaje"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbxpuntaje As System.Windows.Forms.ComboBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Txtpuntaje As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblTipoPuntaje As System.Windows.Forms.Label
    Friend WithEvents lblCoeficiente As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionarTipoPuntaje As System.Windows.Forms.Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
End Class
