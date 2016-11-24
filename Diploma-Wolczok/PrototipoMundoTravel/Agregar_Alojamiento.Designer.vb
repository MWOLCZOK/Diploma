<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Alojamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Alojamiento))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTipoAlojamiento = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblEstrellas = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblPrecioAlquiler = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ChkFrigobar = New System.Windows.Forms.CheckBox()
        Me.chkAmoblado = New System.Windows.Forms.CheckBox()
        Me.chkCochera = New System.Windows.Forms.CheckBox()
        Me.chkTV = New System.Windows.Forms.CheckBox()
        Me.chkDesayuno = New System.Windows.Forms.CheckBox()
        Me.chkSauna = New System.Windows.Forms.CheckBox()
        Me.chkAire = New System.Windows.Forms.CheckBox()
        Me.chkPiscina = New System.Windows.Forms.CheckBox()
        Me.chkMascotas = New System.Windows.Forms.CheckBox()
        Me.chkWIFI = New System.Windows.Forms.CheckBox()
        Me.chkGimnasio = New System.Windows.Forms.CheckBox()
        Me.chkCocina = New System.Windows.Forms.CheckBox()
        Me.chkPrivada = New System.Windows.Forms.CheckBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblAmbientes = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(204, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'lblTipoAlojamiento
        '
        Me.lblTipoAlojamiento.AutoSize = True
        Me.lblTipoAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAlojamiento.ForeColor = System.Drawing.Color.White
        Me.lblTipoAlojamiento.Location = New System.Drawing.Point(390, 99)
        Me.lblTipoAlojamiento.Name = "lblTipoAlojamiento"
        Me.lblTipoAlojamiento.Size = New System.Drawing.Size(135, 15)
        Me.lblTipoAlojamiento.TabIndex = 3
        Me.lblTipoAlojamiento.Text = "Tipo de Alojamiento"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(393, 119)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(14, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(201, 159)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(83, 15)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripcion"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(204, 177)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(355, 20)
        Me.TextBox3.TabIndex = 8
        '
        'lblEstrellas
        '
        Me.lblEstrellas.AutoSize = True
        Me.lblEstrellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstrellas.ForeColor = System.Drawing.Color.White
        Me.lblEstrellas.Location = New System.Drawing.Point(12, 99)
        Me.lblEstrellas.Name = "lblEstrellas"
        Me.lblEstrellas.Size = New System.Drawing.Size(63, 15)
        Me.lblEstrellas.TabIndex = 11
        Me.lblEstrellas.Text = "Estrellas"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(17, 177)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(166, 20)
        Me.TextBox5.TabIndex = 14
        '
        'lblPrecioAlquiler
        '
        Me.lblPrecioAlquiler.AutoSize = True
        Me.lblPrecioAlquiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioAlquiler.ForeColor = System.Drawing.Color.White
        Me.lblPrecioAlquiler.Location = New System.Drawing.Point(201, 102)
        Me.lblPrecioAlquiler.Name = "lblPrecioAlquiler"
        Me.lblPrecioAlquiler.Size = New System.Drawing.Size(144, 15)
        Me.lblPrecioAlquiler.TabIndex = 19
        Me.lblPrecioAlquiler.Text = "Precio Alquiler Diario"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(204, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(166, 20)
        Me.TextBox7.TabIndex = 18
        '
        'ChkFrigobar
        '
        Me.ChkFrigobar.AutoSize = True
        Me.ChkFrigobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFrigobar.ForeColor = System.Drawing.Color.White
        Me.ChkFrigobar.Location = New System.Drawing.Point(393, 243)
        Me.ChkFrigobar.Name = "ChkFrigobar"
        Me.ChkFrigobar.Size = New System.Drawing.Size(80, 19)
        Me.ChkFrigobar.TabIndex = 35
        Me.ChkFrigobar.Text = "Frigobar"
        Me.ChkFrigobar.UseVisualStyleBackColor = True
        '
        'chkAmoblado
        '
        Me.chkAmoblado.AutoSize = True
        Me.chkAmoblado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAmoblado.ForeColor = System.Drawing.Color.White
        Me.chkAmoblado.Location = New System.Drawing.Point(204, 303)
        Me.chkAmoblado.Name = "chkAmoblado"
        Me.chkAmoblado.Size = New System.Drawing.Size(90, 19)
        Me.chkAmoblado.TabIndex = 34
        Me.chkAmoblado.Text = "Amoblado"
        Me.chkAmoblado.UseVisualStyleBackColor = True
        '
        'chkCochera
        '
        Me.chkCochera.AutoSize = True
        Me.chkCochera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCochera.ForeColor = System.Drawing.Color.White
        Me.chkCochera.Location = New System.Drawing.Point(16, 332)
        Me.chkCochera.Name = "chkCochera"
        Me.chkCochera.Size = New System.Drawing.Size(79, 19)
        Me.chkCochera.TabIndex = 33
        Me.chkCochera.Text = "Cochera"
        Me.chkCochera.UseVisualStyleBackColor = True
        '
        'chkTV
        '
        Me.chkTV.AutoSize = True
        Me.chkTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTV.ForeColor = System.Drawing.Color.White
        Me.chkTV.Location = New System.Drawing.Point(393, 272)
        Me.chkTV.Name = "chkTV"
        Me.chkTV.Size = New System.Drawing.Size(117, 19)
        Me.chkTV.TabIndex = 32
        Me.chkTV.Text = "Servicio de TV"
        Me.chkTV.UseVisualStyleBackColor = True
        '
        'chkDesayuno
        '
        Me.chkDesayuno.AutoSize = True
        Me.chkDesayuno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesayuno.ForeColor = System.Drawing.Color.White
        Me.chkDesayuno.Location = New System.Drawing.Point(204, 275)
        Me.chkDesayuno.Name = "chkDesayuno"
        Me.chkDesayuno.Size = New System.Drawing.Size(89, 19)
        Me.chkDesayuno.TabIndex = 31
        Me.chkDesayuno.Text = "Desayuno"
        Me.chkDesayuno.UseVisualStyleBackColor = True
        '
        'chkSauna
        '
        Me.chkSauna.AutoSize = True
        Me.chkSauna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSauna.ForeColor = System.Drawing.Color.White
        Me.chkSauna.Location = New System.Drawing.Point(16, 366)
        Me.chkSauna.Name = "chkSauna"
        Me.chkSauna.Size = New System.Drawing.Size(67, 19)
        Me.chkSauna.TabIndex = 30
        Me.chkSauna.Text = "Sauna"
        Me.chkSauna.UseVisualStyleBackColor = True
        '
        'chkAire
        '
        Me.chkAire.AutoSize = True
        Me.chkAire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAire.ForeColor = System.Drawing.Color.White
        Me.chkAire.Location = New System.Drawing.Point(204, 243)
        Me.chkAire.Name = "chkAire"
        Me.chkAire.Size = New System.Drawing.Size(149, 19)
        Me.chkAire.TabIndex = 29
        Me.chkAire.Text = "Aire Acondicionado"
        Me.chkAire.UseVisualStyleBackColor = True
        '
        'chkPiscina
        '
        Me.chkPiscina.AutoSize = True
        Me.chkPiscina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPiscina.ForeColor = System.Drawing.Color.White
        Me.chkPiscina.Location = New System.Drawing.Point(17, 272)
        Me.chkPiscina.Name = "chkPiscina"
        Me.chkPiscina.Size = New System.Drawing.Size(73, 19)
        Me.chkPiscina.TabIndex = 28
        Me.chkPiscina.Text = "Piscina"
        Me.chkPiscina.UseVisualStyleBackColor = True
        '
        'chkMascotas
        '
        Me.chkMascotas.AutoSize = True
        Me.chkMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMascotas.ForeColor = System.Drawing.Color.White
        Me.chkMascotas.Location = New System.Drawing.Point(16, 300)
        Me.chkMascotas.Name = "chkMascotas"
        Me.chkMascotas.Size = New System.Drawing.Size(134, 19)
        Me.chkMascotas.TabIndex = 27
        Me.chkMascotas.Text = "Acepta Mascotas"
        Me.chkMascotas.UseVisualStyleBackColor = True
        '
        'chkWIFI
        '
        Me.chkWIFI.AutoSize = True
        Me.chkWIFI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWIFI.ForeColor = System.Drawing.Color.White
        Me.chkWIFI.Location = New System.Drawing.Point(17, 243)
        Me.chkWIFI.Name = "chkWIFI"
        Me.chkWIFI.Size = New System.Drawing.Size(140, 19)
        Me.chkWIFI.TabIndex = 26
        Me.chkWIFI.Text = "Conectividad WIFI"
        Me.chkWIFI.UseVisualStyleBackColor = True
        '
        'chkGimnasio
        '
        Me.chkGimnasio.AutoSize = True
        Me.chkGimnasio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGimnasio.ForeColor = System.Drawing.Color.White
        Me.chkGimnasio.Location = New System.Drawing.Point(393, 332)
        Me.chkGimnasio.Name = "chkGimnasio"
        Me.chkGimnasio.Size = New System.Drawing.Size(87, 19)
        Me.chkGimnasio.TabIndex = 25
        Me.chkGimnasio.Text = "Gimnasio"
        Me.chkGimnasio.UseVisualStyleBackColor = True
        '
        'chkCocina
        '
        Me.chkCocina.AutoSize = True
        Me.chkCocina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCocina.ForeColor = System.Drawing.Color.White
        Me.chkCocina.Location = New System.Drawing.Point(204, 335)
        Me.chkCocina.Name = "chkCocina"
        Me.chkCocina.Size = New System.Drawing.Size(70, 19)
        Me.chkCocina.TabIndex = 36
        Me.chkCocina.Text = "Cocina"
        Me.chkCocina.UseVisualStyleBackColor = True
        '
        'chkPrivada
        '
        Me.chkPrivada.AutoSize = True
        Me.chkPrivada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrivada.ForeColor = System.Drawing.Color.White
        Me.chkPrivada.Location = New System.Drawing.Point(393, 300)
        Me.chkPrivada.Name = "chkPrivada"
        Me.chkPrivada.Size = New System.Drawing.Size(147, 19)
        Me.chkPrivada.TabIndex = 38
        Me.chkPrivada.Text = "Habitacion Privada"
        Me.chkPrivada.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.Location = New System.Drawing.Point(323, 424)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(150, 30)
        Me.Btnsalir.TabIndex = 41
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(107, 424)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(150, 30)
        Me.BtnAceptar.TabIndex = 40
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.ForeColor = System.Drawing.Color.White
        Me.lblDestino.Location = New System.Drawing.Point(201, 38)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(56, 15)
        Me.lblDestino.TabIndex = 42
        Me.lblDestino.Text = "Destino"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.ForeColor = System.Drawing.Color.White
        Me.lblUbicacion.Location = New System.Drawing.Point(14, 159)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(71, 15)
        Me.lblUbicacion.TabIndex = 43
        Me.lblUbicacion.Text = "Ubicacion"
        '
        'lblAmbientes
        '
        Me.lblAmbientes.AutoSize = True
        Me.lblAmbientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmbientes.ForeColor = System.Drawing.Color.White
        Me.lblAmbientes.Location = New System.Drawing.Point(390, 38)
        Me.lblAmbientes.Name = "lblAmbientes"
        Me.lblAmbientes.Size = New System.Drawing.Size(74, 15)
        Me.lblAmbientes.TabIndex = 44
        Me.lblAmbientes.Text = "Ambientes"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(393, 58)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(166, 20)
        Me.NumericUpDown1.TabIndex = 45
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(17, 120)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(166, 20)
        Me.NumericUpDown2.TabIndex = 46
        '
        'Agregar_Alojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 499)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblAmbientes)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.chkPrivada)
        Me.Controls.Add(Me.chkCocina)
        Me.Controls.Add(Me.ChkFrigobar)
        Me.Controls.Add(Me.chkAmoblado)
        Me.Controls.Add(Me.chkCochera)
        Me.Controls.Add(Me.chkTV)
        Me.Controls.Add(Me.chkDesayuno)
        Me.Controls.Add(Me.chkSauna)
        Me.Controls.Add(Me.chkAire)
        Me.Controls.Add(Me.chkPiscina)
        Me.Controls.Add(Me.chkMascotas)
        Me.Controls.Add(Me.chkWIFI)
        Me.Controls.Add(Me.chkGimnasio)
        Me.Controls.Add(Me.lblPrecioAlquiler)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.lblEstrellas)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTipoAlojamiento)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Alojamiento"
        Me.Text = "Agregar_Alojamiento"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoAlojamiento As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblEstrellas As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioAlquiler As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ChkFrigobar As System.Windows.Forms.CheckBox
    Friend WithEvents chkAmoblado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCochera As System.Windows.Forms.CheckBox
    Friend WithEvents chkTV As System.Windows.Forms.CheckBox
    Friend WithEvents chkDesayuno As System.Windows.Forms.CheckBox
    Friend WithEvents chkSauna As System.Windows.Forms.CheckBox
    Friend WithEvents chkAire As System.Windows.Forms.CheckBox
    Friend WithEvents chkPiscina As System.Windows.Forms.CheckBox
    Friend WithEvents chkMascotas As System.Windows.Forms.CheckBox
    Friend WithEvents chkWIFI As System.Windows.Forms.CheckBox
    Friend WithEvents chkGimnasio As System.Windows.Forms.CheckBox
    Friend WithEvents chkCocina As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrivada As System.Windows.Forms.CheckBox
    Friend WithEvents Btnsalir As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents lblDestino As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblAmbientes As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
