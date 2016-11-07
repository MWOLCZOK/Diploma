<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Viaje
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtnombreemp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbxtipotransporte = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbxorigen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbxdestino = New System.Windows.Forms.ComboBox()
        Me.Cbxcena = New System.Windows.Forms.CheckBox()
        Me.Cbxcafeteria = New System.Windows.Forms.CheckBox()
        Me.Cbxalmuerzo = New System.Windows.Forms.CheckBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Btnaceptar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Fechafin = New System.Windows.Forms.DateTimePicker()
        Me.Fechainicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtcuil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Precio"
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(315, 241)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(121, 20)
        Me.Txtprecio.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(164, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Descripcion"
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(163, 241)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(121, 20)
        Me.Txtdescripcion.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nombre Empresa"
        '
        'Txtnombreemp
        '
        Me.Txtnombreemp.Location = New System.Drawing.Point(16, 189)
        Me.Txtnombreemp.Name = "Txtnombreemp"
        Me.Txtnombreemp.Size = New System.Drawing.Size(121, 20)
        Me.Txtnombreemp.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Modelo"
        '
        'Txtmodelo
        '
        Me.Txtmodelo.Location = New System.Drawing.Point(16, 241)
        Me.Txtmodelo.Name = "Txtmodelo"
        Me.Txtmodelo.Size = New System.Drawing.Size(121, 20)
        Me.Txtmodelo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tipo de Transporte"
        '
        'Cbxtipotransporte
        '
        Me.Cbxtipotransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxtipotransporte.FormattingEnabled = True
        Me.Cbxtipotransporte.Location = New System.Drawing.Point(315, 50)
        Me.Cbxtipotransporte.Name = "Cbxtipotransporte"
        Me.Cbxtipotransporte.Size = New System.Drawing.Size(121, 21)
        Me.Cbxtipotransporte.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Origen"
        '
        'Cbxorigen
        '
        Me.Cbxorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxorigen.FormattingEnabled = True
        Me.Cbxorigen.Location = New System.Drawing.Point(12, 50)
        Me.Cbxorigen.Name = "Cbxorigen"
        Me.Cbxorigen.Size = New System.Drawing.Size(121, 21)
        Me.Cbxorigen.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Destino"
        '
        'Cbxdestino
        '
        Me.Cbxdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbxdestino.FormattingEnabled = True
        Me.Cbxdestino.Location = New System.Drawing.Point(159, 50)
        Me.Cbxdestino.Name = "Cbxdestino"
        Me.Cbxdestino.Size = New System.Drawing.Size(121, 21)
        Me.Cbxdestino.TabIndex = 36
        '
        'Cbxcena
        '
        Me.Cbxcena.AutoSize = True
        Me.Cbxcena.Location = New System.Drawing.Point(332, 346)
        Me.Cbxcena.Name = "Cbxcena"
        Me.Cbxcena.Size = New System.Drawing.Size(51, 17)
        Me.Cbxcena.TabIndex = 41
        Me.Cbxcena.Text = "Cena"
        Me.Cbxcena.UseVisualStyleBackColor = True
        '
        'Cbxcafeteria
        '
        Me.Cbxcafeteria.AutoSize = True
        Me.Cbxcafeteria.Location = New System.Drawing.Point(33, 346)
        Me.Cbxcafeteria.Name = "Cbxcafeteria"
        Me.Cbxcafeteria.Size = New System.Drawing.Size(68, 17)
        Me.Cbxcafeteria.TabIndex = 40
        Me.Cbxcafeteria.Text = "Cafeteria"
        Me.Cbxcafeteria.UseVisualStyleBackColor = True
        '
        'Cbxalmuerzo
        '
        Me.Cbxalmuerzo.AutoSize = True
        Me.Cbxalmuerzo.Location = New System.Drawing.Point(180, 346)
        Me.Cbxalmuerzo.Name = "Cbxalmuerzo"
        Me.Cbxalmuerzo.Size = New System.Drawing.Size(69, 17)
        Me.Cbxalmuerzo.TabIndex = 38
        Me.Cbxalmuerzo.Text = "Almuerzo"
        Me.Cbxalmuerzo.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(304, 405)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(74, 37)
        Me.Btnsalir.TabIndex = 43
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Btnaceptar
        '
        Me.Btnaceptar.Location = New System.Drawing.Point(94, 405)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(80, 37)
        Me.Btnaceptar.TabIndex = 42
        Me.Btnaceptar.Text = "Aceptar"
        Me.Btnaceptar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Fecha Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Fecha Inicio"
        '
        'Fechafin
        '
        Me.Fechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fechafin.Location = New System.Drawing.Point(163, 106)
        Me.Fechafin.Name = "Fechafin"
        Me.Fechafin.Size = New System.Drawing.Size(121, 20)
        Me.Fechafin.TabIndex = 45
        '
        'Fechainicio
        '
        Me.Fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fechainicio.Location = New System.Drawing.Point(16, 106)
        Me.Fechainicio.Name = "Fechainicio"
        Me.Fechainicio.Size = New System.Drawing.Size(121, 20)
        Me.Fechainicio.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Telefono"
        '
        'Txttelefono
        '
        Me.Txttelefono.Location = New System.Drawing.Point(315, 300)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(121, 20)
        Me.Txttelefono.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(164, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Mail"
        '
        'Txtmail
        '
        Me.Txtmail.Location = New System.Drawing.Point(163, 300)
        Me.Txtmail.Name = "Txtmail"
        Me.Txtmail.Size = New System.Drawing.Size(121, 20)
        Me.Txtmail.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "CUIL"
        '
        'Txtcuil
        '
        Me.Txtcuil.Location = New System.Drawing.Point(16, 300)
        Me.Txtcuil.Name = "Txtcuil"
        Me.Txtcuil.Size = New System.Drawing.Size(121, 20)
        Me.Txtcuil.TabIndex = 48
        '
        'Agregar_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 453)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txttelefono)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txtcuil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Fechafin)
        Me.Controls.Add(Me.Fechainicio)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnaceptar)
        Me.Controls.Add(Me.Cbxcena)
        Me.Controls.Add(Me.Cbxcafeteria)
        Me.Controls.Add(Me.Cbxalmuerzo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbxdestino)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtnombreemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtmodelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbxtipotransporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbxorigen)
        Me.Name = "Agregar_Viaje"
        Me.Text = "Agregar_Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtnombreemp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cbxtipotransporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cbxorigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cbxdestino As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxcena As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxcafeteria As System.Windows.Forms.CheckBox
    Friend WithEvents Cbxalmuerzo As System.Windows.Forms.CheckBox
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents Btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Fechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtcuil As System.Windows.Forms.TextBox
End Class
