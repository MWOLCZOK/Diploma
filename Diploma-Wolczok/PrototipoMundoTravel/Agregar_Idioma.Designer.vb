<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Idioma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Idioma))
        Me.CbxCultura = New System.Windows.Forms.ComboBox()
        Me.lblcultura = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.DgVIdioma = New System.Windows.Forms.DataGridView()
        Me.ID_Control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Palabra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Traduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxCultura
        '
        Me.CbxCultura.FormattingEnabled = True
        Me.CbxCultura.Location = New System.Drawing.Point(431, 42)
        Me.CbxCultura.Name = "CbxCultura"
        Me.CbxCultura.Size = New System.Drawing.Size(234, 21)
        Me.CbxCultura.TabIndex = 14
        '
        'lblcultura
        '
        Me.lblcultura.AutoSize = True
        Me.lblcultura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcultura.ForeColor = System.Drawing.Color.White
        Me.lblcultura.Location = New System.Drawing.Point(428, 24)
        Me.lblcultura.Name = "lblcultura"
        Me.lblcultura.Size = New System.Drawing.Size(53, 15)
        Me.lblcultura.TabIndex = 13
        Me.lblcultura.Text = "Cultura"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(18, 42)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(234, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.White
        Me.lblnombre.Location = New System.Drawing.Point(15, 24)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 15)
        Me.lblnombre.TabIndex = 11
        Me.lblnombre.Text = "Nombre"
        '
        'DgVIdioma
        '
        Me.DgVIdioma.AllowUserToAddRows = False
        Me.DgVIdioma.AllowUserToDeleteRows = False
        Me.DgVIdioma.AllowUserToResizeColumns = False
        Me.DgVIdioma.AllowUserToResizeRows = False
        Me.DgVIdioma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgVIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVIdioma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Control, Me.Codigo, Me.Palabra, Me.Traduccion})
        Me.DgVIdioma.Location = New System.Drawing.Point(18, 99)
        Me.DgVIdioma.MultiSelect = False
        Me.DgVIdioma.Name = "DgVIdioma"
        Me.DgVIdioma.RowHeadersVisible = False
        Me.DgVIdioma.Size = New System.Drawing.Size(647, 310)
        Me.DgVIdioma.TabIndex = 8
        '
        'ID_Control
        '
        Me.ID_Control.FillWeight = 30.0!
        Me.ID_Control.HeaderText = "ID_Control"
        Me.ID_Control.Name = "ID_Control"
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 50.0!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Palabra
        '
        Me.Palabra.HeaderText = "Palabra"
        Me.Palabra.Name = "Palabra"
        '
        'Traduccion
        '
        Me.Traduccion.HeaderText = "Traduccion"
        Me.Traduccion.Name = "Traduccion"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(399, 431)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 30)
        Me.btnSalir.TabIndex = 46
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(129, 431)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 30)
        Me.btnAgregar.TabIndex = 47
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Agregar_Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 500)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CbxCultura)
        Me.Controls.Add(Me.lblcultura)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.DgVIdioma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Idioma"
        Me.Text = "Agregar_Idioma"
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxCultura As ComboBox
    Friend WithEvents lblcultura As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents DgVIdioma As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ID_Control As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Palabra As DataGridViewTextBoxColumn
    Friend WithEvents Traduccion As DataGridViewTextBoxColumn
End Class
