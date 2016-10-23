<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Provincia
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtsuperficieterrestre = New System.Windows.Forms.TextBox()
        Me.Txtregion = New System.Windows.Forms.TextBox()
        Me.Txthabitantes = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Btn_agregarprovincia = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Pais"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Superficie Terrestre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Region"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Habitantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre de Provincia"
        '
        'Txtsuperficieterrestre
        '
        Me.Txtsuperficieterrestre.Location = New System.Drawing.Point(12, 246)
        Me.Txtsuperficieterrestre.Name = "Txtsuperficieterrestre"
        Me.Txtsuperficieterrestre.Size = New System.Drawing.Size(100, 20)
        Me.Txtsuperficieterrestre.TabIndex = 19
        '
        'Txtregion
        '
        Me.Txtregion.Location = New System.Drawing.Point(13, 189)
        Me.Txtregion.Name = "Txtregion"
        Me.Txtregion.Size = New System.Drawing.Size(100, 20)
        Me.Txtregion.TabIndex = 18
        '
        'Txthabitantes
        '
        Me.Txthabitantes.Location = New System.Drawing.Point(13, 125)
        Me.Txthabitantes.Name = "Txthabitantes"
        Me.Txthabitantes.Size = New System.Drawing.Size(100, 20)
        Me.Txthabitantes.TabIndex = 17
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(12, 67)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.Txtdescripcion.TabIndex = 16
        '
        'Btn_agregarprovincia
        '
        Me.Btn_agregarprovincia.Location = New System.Drawing.Point(153, 209)
        Me.Btn_agregarprovincia.Name = "Btn_agregarprovincia"
        Me.Btn_agregarprovincia.Size = New System.Drawing.Size(87, 36)
        Me.Btn_agregarprovincia.TabIndex = 15
        Me.Btn_agregarprovincia.Text = "Agregar Provincia"
        Me.Btn_agregarprovincia.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 295)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Agregar_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 369)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtsuperficieterrestre)
        Me.Controls.Add(Me.Txtregion)
        Me.Controls.Add(Me.Txthabitantes)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Btn_agregarprovincia)
        Me.Name = "Agregar_Provincia"
        Me.Text = "Agregar_Provincia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtsuperficieterrestre As System.Windows.Forms.TextBox
    Friend WithEvents Txtregion As System.Windows.Forms.TextBox
    Friend WithEvents Txthabitantes As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Btn_agregarprovincia As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
