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
        Me.Cbxpuntaje = New System.Windows.Forms.ComboBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Txtpuntaje = New System.Windows.Forms.TextBox()
        Me.Btnaceptar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbxpuntaje
        '
        Me.Cbxpuntaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxpuntaje.FormattingEnabled = True
        Me.Cbxpuntaje.Location = New System.Drawing.Point(13, 57)
        Me.Cbxpuntaje.Name = "Cbxpuntaje"
        Me.Cbxpuntaje.Size = New System.Drawing.Size(121, 21)
        Me.Cbxpuntaje.TabIndex = 0
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Txtdescripcion.Location = New System.Drawing.Point(12, 118)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.Txtdescripcion.TabIndex = 1
        '
        'Txtpuntaje
        '
        Me.Txtpuntaje.Location = New System.Drawing.Point(160, 118)
        Me.Txtpuntaje.Name = "Txtpuntaje"
        Me.Txtpuntaje.Size = New System.Drawing.Size(100, 20)
        Me.Txtpuntaje.TabIndex = 2
        '
        'Btnaceptar
        '
        Me.Btnaceptar.Location = New System.Drawing.Point(24, 331)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btnaceptar.TabIndex = 3
        Me.Btnaceptar.Text = "Aceptar"
        Me.Btnaceptar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(185, 331)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 4
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tipo de Puntaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Coeficiente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Selección de Tipo de Puntaje"
        '
        'Modificar_Puntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 366)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnaceptar)
        Me.Controls.Add(Me.Txtpuntaje)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Cbxpuntaje)
        Me.Name = "Modificar_Puntaje"
        Me.Text = "Modificar_Puntaje"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbxpuntaje As System.Windows.Forms.ComboBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Txtpuntaje As System.Windows.Forms.TextBox
    Friend WithEvents Btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
