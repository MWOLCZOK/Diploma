﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Usuario))
        Me.CbxUsuario = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionarUsuario = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbxUsuario
        '
        Me.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUsuario.FormattingEnabled = True
        Me.CbxUsuario.Location = New System.Drawing.Point(47, 105)
        Me.CbxUsuario.Name = "CbxUsuario"
        Me.CbxUsuario.Size = New System.Drawing.Size(344, 21)
        Me.CbxUsuario.TabIndex = 25
        '
        'lblSeleccionarUsuario
        '
        Me.lblSeleccionarUsuario.AutoSize = True
        Me.lblSeleccionarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarUsuario.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionarUsuario.Location = New System.Drawing.Point(44, 82)
        Me.lblSeleccionarUsuario.Name = "lblSeleccionarUsuario"
        Me.lblSeleccionarUsuario.Size = New System.Drawing.Size(137, 15)
        Me.lblSeleccionarUsuario.TabIndex = 24
        Me.lblSeleccionarUsuario.Text = "Seleccionar Usuario"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(47, 173)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 30)
        Me.btnEliminar.TabIndex = 73
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(241, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 72
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Eliminar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(444, 262)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CbxUsuario)
        Me.Controls.Add(Me.lblSeleccionarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Eliminar_Usuario"
        Me.Text = "Eliminar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionarUsuario As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
End Class
