Public Class visualizarBitacora

    Private Sub visualizarBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        Dim gestorbitacora As New BLL.BLL_Bitacora
        Me.dgvBitacora.DataSource = Nothing
        Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora
        EstablecerGrid()
    End Sub

    Private Sub llenarCombos()
        Dim gestorusuario As New BLL.BLL_Usuario
        Dim Listausuarios = gestorusuario.consultarUsuarios
        For Each Usuario In Listausuarios
            ComboBox1.Items.Add(Usuario)
        Next
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Alta)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Baja)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Modificación)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Errores)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Login)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Backup)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Restore)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub EstablecerGrid()
        Me.dgvBitacora.Columns.Remove("ID_Bitacora")
        Me.dgvBitacora.Columns("Codigo").Name = "Column_Codigo"
        Me.dgvBitacora.Columns("Fecha").Name = "Column_Fecha"
        Me.dgvBitacora.Columns("Usuario").Name = "Column_Usuario"
        Me.dgvBitacora.Columns("Detalle").Name = "Column_Detalle"
        '    Me.dgvBitacora.Columns("Column_Codigo").HeaderText = ControladorTraductor.TraducirMensaje("Column_Codigo")
        '   Me.dgvBitacora.Columns("Column_Fecha").HeaderText = ControladorTraductor.TraducirMensaje("Column_Fecha")
        '  Me.dgvBitacora.Columns("Column_Usuario").HeaderText = ControladorTraductor.TraducirMensaje("Column_Usuario")
        '  Me.dgvBitacora.Columns("Column_Detalle").HeaderText = ControladorTraductor.TraducirMensaje("Column_Detalle")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim gestorbitacora As New BLL.BLL_Bitacora
        If IsNothing(ComboBox1.SelectedItem) Then
            If IsNothing(ComboBox2.SelectedItem) Then
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(, , DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            Else
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(, DirectCast(ComboBox2.SelectedItem, EE.BE_TipoBitacora), DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            End If
        Else
            If IsNothing(ComboBox2.SelectedItem) Then
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(DirectCast(ComboBox1.SelectedItem, EE.BE_Usuario), , DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            Else
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(DirectCast(ComboBox1.SelectedItem, EE.BE_Usuario), DirectCast(ComboBox2.SelectedItem, EE.BE_TipoBitacora), DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class