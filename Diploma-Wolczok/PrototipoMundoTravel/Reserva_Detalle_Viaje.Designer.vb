﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Origen"
        '
        'Txtorigen
        '
        Me.Txtorigen.Location = New System.Drawing.Point(12, 161)
        Me.Txtorigen.Name = "Txtorigen"
        Me.Txtorigen.Size = New System.Drawing.Size(428, 20)
        Me.Txtorigen.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Tipo Transporte"
        '
        'Txttipotrans
        '
        Me.Txttipotrans.Location = New System.Drawing.Point(12, 80)
        Me.Txttipotrans.Name = "Txttipotrans"
        Me.Txttipotrans.Size = New System.Drawing.Size(428, 20)
        Me.Txttipotrans.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Destino"
        '
        'Txtdestino
        '
        Me.Txtdestino.Location = New System.Drawing.Point(12, 119)
        Me.Txtdestino.Name = "Txtdestino"
        Me.Txtdestino.Size = New System.Drawing.Size(428, 20)
        Me.Txtdestino.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Fecha Viaje"
        '
        'Txtfechaviaje
        '
        Me.Txtfechaviaje.Location = New System.Drawing.Point(12, 210)
        Me.Txtfechaviaje.Name = "Txtfechaviaje"
        Me.Txtfechaviaje.Size = New System.Drawing.Size(190, 20)
        Me.Txtfechaviaje.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Empresa Transporte"
        '
        'Txtempresatrans
        '
        Me.Txtempresatrans.Location = New System.Drawing.Point(12, 37)
        Me.Txtempresatrans.Name = "Txtempresatrans"
        Me.Txtempresatrans.Size = New System.Drawing.Size(428, 20)
        Me.Txtempresatrans.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Numero Asiento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 258)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 20)
        Me.TextBox1.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 37)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Volver a Compra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 37)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Finalizar Compra"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Reserva_Detalle_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 389)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class