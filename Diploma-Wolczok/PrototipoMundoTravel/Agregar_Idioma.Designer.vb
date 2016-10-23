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
        Me.CbxCultura = New System.Windows.Forms.ComboBox()
        Me.lblcultura = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.DgVIdioma = New System.Windows.Forms.DataGridView()
        Me.ID_Control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Palabra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Traduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxCultura
        '
        Me.CbxCultura.FormattingEnabled = True
        Me.CbxCultura.Location = New System.Drawing.Point(339, 39)
        Me.CbxCultura.Name = "CbxCultura"
        Me.CbxCultura.Size = New System.Drawing.Size(173, 21)
        Me.CbxCultura.TabIndex = 14
        '
        'lblcultura
        '
        Me.lblcultura.AutoSize = True
        Me.lblcultura.Location = New System.Drawing.Point(408, 24)
        Me.lblcultura.Name = "lblcultura"
        Me.lblcultura.Size = New System.Drawing.Size(40, 13)
        Me.lblcultura.TabIndex = 13
        Me.lblcultura.Text = "Cultura"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(128, 40)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(202, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(208, 24)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 11
        Me.lblnombre.Text = "Nombre"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(393, 444)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 32)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncrear
        '
        Me.btncrear.Location = New System.Drawing.Point(229, 444)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(75, 32)
        Me.btncrear.TabIndex = 9
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = True
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
        Me.DgVIdioma.Location = New System.Drawing.Point(-6, 71)
        Me.DgVIdioma.MultiSelect = False
        Me.DgVIdioma.Name = "DgVIdioma"
        Me.DgVIdioma.RowHeadersVisible = False
        Me.DgVIdioma.Size = New System.Drawing.Size(714, 363)
        Me.DgVIdioma.TabIndex = 8
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
        'Agregar_Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 500)
        Me.Controls.Add(Me.CbxCultura)
        Me.Controls.Add(Me.lblcultura)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.DgVIdioma)
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
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents DgVIdioma As DataGridView
    Friend WithEvents ID_Control As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Palabra As DataGridViewTextBoxColumn
    Friend WithEvents Traduccion As DataGridViewTextBoxColumn
End Class
