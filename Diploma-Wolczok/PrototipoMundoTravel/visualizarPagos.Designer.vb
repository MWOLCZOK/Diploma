﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visualizarPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visualizarPagos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblSeleccionarPasajero = New System.Windows.Forms.Label()
        Me.Cbxpasajero = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarReserva = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(646, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(265, 402)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblSeleccionarPasajero
        '
        Me.lblSeleccionarPasajero.AutoSize = True
        Me.lblSeleccionarPasajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarPasajero.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarPasajero.Location = New System.Drawing.Point(15, 22)
        Me.lblSeleccionarPasajero.Name = "lblSeleccionarPasajero"
        Me.lblSeleccionarPasajero.Size = New System.Drawing.Size(144, 15)
        Me.lblSeleccionarPasajero.TabIndex = 52
        Me.lblSeleccionarPasajero.Text = "Seleccionar Pasajero"
        '
        'Cbxpasajero
        '
        Me.Cbxpasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpasajero.FormattingEnabled = True
        Me.Cbxpasajero.Location = New System.Drawing.Point(18, 49)
        Me.Cbxpasajero.Name = "Cbxpasajero"
        Me.Cbxpasajero.Size = New System.Drawing.Size(212, 21)
        Me.Cbxpasajero.TabIndex = 51
        '
        'lblSeleccionarReserva
        '
        Me.lblSeleccionarReserva.AutoSize = True
        Me.lblSeleccionarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarReserva.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarReserva.Location = New System.Drawing.Point(262, 22)
        Me.lblSeleccionarReserva.Name = "lblSeleccionarReserva"
        Me.lblSeleccionarReserva.Size = New System.Drawing.Size(139, 15)
        Me.lblSeleccionarReserva.TabIndex = 54
        Me.lblSeleccionarReserva.Text = "Seleccionar Reserva"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(265, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox2.TabIndex = 53
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(514, 43)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(150, 30)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Visualizar_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 468)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblSeleccionarReserva)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblSeleccionarPasajero)
        Me.Controls.Add(Me.Cbxpasajero)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Visualizar_Pagos"
        Me.Text = "Visualizar_Pagos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblSeleccionarPasajero As Label
    Friend WithEvents Cbxpasajero As ComboBox
    Friend WithEvents lblSeleccionarReserva As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnBuscar As Button
End Class
