<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Idioma
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
        Me.DgVIdioma = New System.Windows.Forms.DataGridView()
        Me.ID_Control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Palabra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Traduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.CbxIdioma = New System.Windows.Forms.ComboBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblmodificaridioma = New System.Windows.Forms.Label()
        CType(Me.DgVIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxCultura
        '
        Me.CbxCultura.FormattingEnabled = True
        Me.CbxCultura.Location = New System.Drawing.Point(291, 77)
        Me.CbxCultura.Name = "CbxCultura"
        Me.CbxCultura.Size = New System.Drawing.Size(173, 21)
        Me.CbxCultura.TabIndex = 24
        '
        'lblcultura
        '
        Me.lblcultura.AutoSize = True
        Me.lblcultura.Location = New System.Drawing.Point(360, 62)
        Me.lblcultura.Name = "lblcultura"
        Me.lblcultura.Size = New System.Drawing.Size(40, 13)
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
        Me.DgVIdioma.Location = New System.Drawing.Point(20, 105)
        Me.DgVIdioma.MultiSelect = False
        Me.DgVIdioma.Name = "DgVIdioma"
        Me.DgVIdioma.RowHeadersVisible = False
        Me.DgVIdioma.Size = New System.Drawing.Size(714, 363)
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
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(249, 474)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 32)
        Me.btnmodificar.TabIndex = 21
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'CbxIdioma
        '
        Me.CbxIdioma.FormattingEnabled = True
        Me.CbxIdioma.Location = New System.Drawing.Point(20, 77)
        Me.CbxIdioma.Name = "CbxIdioma"
        Me.CbxIdioma.Size = New System.Drawing.Size(260, 21)
        Me.CbxIdioma.TabIndex = 20
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(417, 474)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 32)
        Me.btnsalir.TabIndex = 19
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lblidioma
        '
        Me.lblidioma.AutoSize = True
        Me.lblidioma.Location = New System.Drawing.Point(128, 61)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(38, 13)
        Me.lblidioma.TabIndex = 18
        Me.lblidioma.Text = "Idioma"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(474, 78)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(260, 20)
        Me.TxtNombre.TabIndex = 17
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(579, 62)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 16
        Me.lblnombre.Text = "Nombre"
        '
        'lblmodificaridioma
        '
        Me.lblmodificaridioma.AutoSize = True
        Me.lblmodificaridioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificaridioma.Location = New System.Drawing.Point(295, 33)
        Me.lblmodificaridioma.Name = "lblmodificaridioma"
        Me.lblmodificaridioma.Size = New System.Drawing.Size(169, 25)
        Me.lblmodificaridioma.TabIndex = 15
        Me.lblmodificaridioma.Text = "Modificar Idioma"
        '
        'Modificar_Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 532)
        Me.Controls.Add(Me.CbxCultura)
        Me.Controls.Add(Me.lblcultura)
        Me.Controls.Add(Me.DgVIdioma)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.CbxIdioma)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblmodificaridioma)
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
    Friend WithEvents btnmodificar As Button
    Friend WithEvents CbxIdioma As ComboBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents lblidioma As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblmodificaridioma As Label
End Class
