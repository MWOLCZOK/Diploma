<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Pais
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
        Me.Btn_agregarpais = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Txtidiomapais = New System.Windows.Forms.TextBox()
        Me.Txtpoblacionpais = New System.Windows.Forms.TextBox()
        Me.Txtzonahorariapais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_agregarpais
        '
        Me.Btn_agregarpais.Location = New System.Drawing.Point(147, 160)
        Me.Btn_agregarpais.Name = "Btn_agregarpais"
        Me.Btn_agregarpais.Size = New System.Drawing.Size(87, 36)
        Me.Btn_agregarpais.TabIndex = 1
        Me.Btn_agregarpais.Text = "Agregar Pais"
        Me.Btn_agregarpais.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(12, 67)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.Txtdescripcion.TabIndex = 2
        '
        'Txtidiomapais
        '
        Me.Txtidiomapais.Location = New System.Drawing.Point(13, 125)
        Me.Txtidiomapais.Name = "Txtidiomapais"
        Me.Txtidiomapais.Size = New System.Drawing.Size(100, 20)
        Me.Txtidiomapais.TabIndex = 3
        '
        'Txtpoblacionpais
        '
        Me.Txtpoblacionpais.Location = New System.Drawing.Point(13, 189)
        Me.Txtpoblacionpais.Name = "Txtpoblacionpais"
        Me.Txtpoblacionpais.Size = New System.Drawing.Size(100, 20)
        Me.Txtpoblacionpais.TabIndex = 4
        '
        'Txtzonahorariapais
        '
        Me.Txtzonahorariapais.Location = New System.Drawing.Point(12, 246)
        Me.Txtzonahorariapais.Name = "Txtzonahorariapais"
        Me.Txtzonahorariapais.Size = New System.Drawing.Size(100, 20)
        Me.Txtzonahorariapais.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre de Pais"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Idioma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Poblacion Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Zona Horaria"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 36)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Agregar_Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 300)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtzonahorariapais)
        Me.Controls.Add(Me.Txtpoblacionpais)
        Me.Controls.Add(Me.Txtidiomapais)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Btn_agregarpais)
        Me.Name = "Agregar_Pais"
        Me.Text = "Agregar_Pais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_agregarpais As System.Windows.Forms.Button
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Txtidiomapais As System.Windows.Forms.TextBox
    Friend WithEvents Txtpoblacionpais As System.Windows.Forms.TextBox
    Friend WithEvents Txtzonahorariapais As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
