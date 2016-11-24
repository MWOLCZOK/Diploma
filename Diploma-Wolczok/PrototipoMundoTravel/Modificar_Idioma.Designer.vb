<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modificar_Idioma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Idioma))
        Me.CbxCultura = New System.Windows.Forms.ComboBox()
        Me.lblcultura = New System.Windows.Forms.Label()
        Me.DgVIdioma = New System.Windows.Forms.DataGridView()
        Me.ID_Control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Palabra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Traduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxCultura
        '
        Me.CbxCultura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCultura.FormattingEnabled = True
        Me.CbxCultura.Location = New System.Drawing.Point(235, 58)
        Me.CbxCultura.Name = "CbxCultura"
        Me.CbxCultura.Size = New System.Drawing.Size(183, 21)
        Me.CbxCultura.TabIndex = 24
        '
        'lblcultura
        '
        Me.lblcultura.AutoSize = True
        Me.lblcultura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcultura.ForeColor = System.Drawing.Color.White
        Me.lblcultura.Location = New System.Drawing.Point(232, 33)
        Me.lblcultura.Name = "lblcultura"
        Me.lblcultura.Size = New System.Drawing.Size(53, 15)
        Me.lblcultura.TabIndex = 23
        Me.lblcultura.Text = "Cultura"
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
        Me.DgVIdioma.Location = New System.Drawing.Point(25, 101)
        Me.DgVIdioma.MultiSelect = False
        Me.DgVIdioma.Name = "DgVIdioma"
        Me.DgVIdioma.RowHeadersVisible = False
        Me.DgVIdioma.Size = New System.Drawing.Size(603, 363)
        Me.DgVIdioma.TabIndex = 22
        '
        'ID_Control
        '
        Me.ID_Control.HeaderText = "ID_Control"
        Me.ID_Control.Name = "ID_Control"
        '
        'Codigo
        '
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
        'CbxIdioma
        '
        Me.CbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(25, 58)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(183, 21)
        Me.CbxIdioma.TabIndex = 20
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidioma.ForeColor = System.Drawing.Color.White
        Me.lblidioma.Location = New System.Drawing.Point(22, 33)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(51, 15)
        Me.lblidioma.TabIndex = 18
        Me.lblidioma.Text = "Idioma"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(445, 58)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 20)
        Me.TxtNombre.TabIndex = 17
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.White
        Me.lblnombre.Location = New System.Drawing.Point(442, 33)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 15)
        Me.lblnombre.TabIndex = 16
        Me.lblnombre.Text = "Nombre"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(147, 481)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.TabIndex = 62
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Modificar_Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 532)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CbxCultura)
        Me.Controls.Add(Me.lblcultura)
        Me.Controls.Add(Me.DgVIdioma)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Idioma"
        Me.Text = "Modificar_Idioma"
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxCultura As ComboBox
    Friend WithEvents lblcultura As Label
    Friend WithEvents DgVIdioma As DataGridView
    Friend WithEvents ID_Control As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Palabra As DataGridViewTextBoxColumn
    Friend WithEvents Traduccion As DataGridViewTextBoxColumn
    Friend WithEvents CbxIdioma As ComboBox
    Friend WithEvents lblidioma As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents Button1 As Button
End Class
