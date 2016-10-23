<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Localidad
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txthabitantes = New System.Windows.Forms.TextBox()
        Me.Txtcantidadbarrios = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Btn_agregarlocalidad = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Provincia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Habitantes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cantidad Barrios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre Localidad"
        '
        'Txthabitantes
        '
        Me.Txthabitantes.Location = New System.Drawing.Point(14, 183)
        Me.Txthabitantes.Name = "Txthabitantes"
        Me.Txthabitantes.Size = New System.Drawing.Size(100, 20)
        Me.Txthabitantes.TabIndex = 19
        '
        'Txtcantidadbarrios
        '
        Me.Txtcantidadbarrios.Location = New System.Drawing.Point(15, 126)
        Me.Txtcantidadbarrios.Name = "Txtcantidadbarrios"
        Me.Txtcantidadbarrios.Size = New System.Drawing.Size(100, 20)
        Me.Txtcantidadbarrios.TabIndex = 18
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(15, 62)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.Txtdescripcion.TabIndex = 17
        '
        'Btn_agregarlocalidad
        '
        Me.Btn_agregarlocalidad.Location = New System.Drawing.Point(155, 146)
        Me.Btn_agregarlocalidad.Name = "Btn_agregarlocalidad"
        Me.Btn_agregarlocalidad.Size = New System.Drawing.Size(87, 36)
        Me.Btn_agregarlocalidad.TabIndex = 15
        Me.Btn_agregarlocalidad.Text = "Agregar Localidad"
        Me.Btn_agregarlocalidad.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 241)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Agregar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 298)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txthabitantes)
        Me.Controls.Add(Me.Txtcantidadbarrios)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Btn_agregarlocalidad)
        Me.Name = "Agregar_Localidad"
        Me.Text = "Agregar_Localidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txthabitantes As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidadbarrios As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Btn_agregarlocalidad As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
