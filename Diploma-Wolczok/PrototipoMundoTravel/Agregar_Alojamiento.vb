Imports EE
Imports BLL

Public Class Agregar_Alojamiento
    Implements BLL_Iobservador

    Private Sub Agregar_Alojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
            cargarCombos()

            ocultar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargarCombos()
        Try

            Dim oListaDestinos As New List(Of BE_Destino)
            Dim bllDestino As New BLL_Destino
            oListaDestinos = bllDestino.consultarDestinos
            For Each miDest As BE_Destino In oListaDestinos
                Me.ComboBox1.Items.Add(miDest)
                ComboBox1.DisplayMember = "NombreCompleto"
            Next

            Dim oListaTipoAlojamiento As New List(Of BE_TipoAlojamiento)
            Dim bllTipoAlojamiento As New BLL.BLL_TipoAlojamiento
            oListaTipoAlojamiento = bllTipoAlojamiento.consultarTipoAlojamientos
            For Each miTipoAloja As BE_TipoAlojamiento In oListaTipoAlojamiento
                Me.ComboBox2.Items.Add(miTipoAloja)
                ComboBox2.DisplayMember = "Descripcion"
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub ocultar()
        CheckBox3.Hide()
        CheckBox12.Hide()
        CheckBox11.Hide()
        CheckBox9.Hide()
        CheckBox13.Hide()
        CheckBox1.Hide()
        CheckBox7.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        If oTipoAlojamiento.ID = 1 Then
            CheckBox13.Show()
            CheckBox9.Show()
            CheckBox3.Hide()
            CheckBox12.Hide()
            CheckBox11.Hide()
            CheckBox1.Hide()
            CheckBox3.Hide()
            CheckBox7.Hide()
        ElseIf oTipoAlojamiento.ID = 2 Then
            CheckBox1.Show()
            CheckBox3.Show()
            CheckBox7.Show()
            CheckBox12.Show()
            CheckBox11.Hide()
            CheckBox9.Hide()
        ElseIf oTipoAlojamiento.ID = 3 Then
            CheckBox3.Show()
            CheckBox12.Show()
            CheckBox11.Show()
            CheckBox9.Show()
            CheckBox13.Hide()
            CheckBox1.Hide()
            CheckBox7.Hide()
        ElseIf oTipoAlojamiento.ID = 4 Then
            CheckBox3.Show()
            CheckBox12.Hide()
            CheckBox11.Hide()
            CheckBox9.Hide()
            CheckBox13.Hide()
            CheckBox1.Hide()
            CheckBox7.Hide()
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Function validarFormulario() As Boolean
        If NumericUpDown1.Value < 0 Or NumericUpDown1.Value > 4 Then Return False
        Return True
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If validarFormulario() Then
                Dim oTipoAlojamiento As New BE_TipoAlojamiento
                oTipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
                If oTipoAlojamiento.ID = 1 Then
                    Dim oHostel As New BE_Hostel
                    oHostel.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
                    oHostel.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
                    oHostel.Nombre = TextBox1.Text
                    oHostel.Descripcion = Me.TextBox3.Text
                    oHostel.Estrellas = Me.NumericUpDown1.Value
                    oHostel.Ubicacion = Me.TextBox5.Text
                    oHostel.Ambientes = Me.NumericUpDown2.Value
                    oHostel.PrecioAlquiler = Me.TextBox7.Text
                    oHostel.ConectividadWifi = Me.CheckBox2.Checked
                    oHostel.Piscina = Me.CheckBox4.Checked
                    oHostel.ServicioAireAcond = Me.CheckBox8.Checked
                    oHostel.Desayuno = Me.CheckBox6.Checked
                    oHostel.ServicioTV = Me.CheckBox5.Checked
                    oHostel.Cocina = Me.CheckBox9.Checked
                    oHostel.HabitacionPrivada = Me.CheckBox13.Checked
                    Dim bllHostel As New BLL_Hostel
                    bllHostel.altaHostel(oHostel)
                ElseIf oTipoAlojamiento.ID = 2 Then
                    Dim oHotel As New BE_Hotel
                    oHotel.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
                    oHotel.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
                    oHotel.Nombre = TextBox1.Text
                    oHotel.Descripcion = Me.TextBox3.Text
                    oHotel.Estrellas = Me.NumericUpDown1.Value
                    oHotel.Ubicacion = Me.TextBox5.Text
                    oHotel.Ambientes = Me.NumericUpDown2.Value
                    oHotel.PrecioAlquiler = Me.TextBox7.Text
                    oHotel.ConectividadWifi = Me.CheckBox2.Checked
                    oHotel.Piscina = Me.CheckBox4.Checked
                    oHotel.ServicioAireAcond = Me.CheckBox8.Checked
                    oHotel.Desayuno = Me.CheckBox6.Checked
                    oHotel.ServicioTV = Me.CheckBox5.Checked
                    oHotel.Gimnasio = Me.CheckBox1.Checked
                    oHotel.Mascota = Me.CheckBox3.Checked
                    oHotel.Sauna = Me.CheckBox7.Checked
                    oHotel.Cochera = Me.CheckBox12.Checked
                    Dim bllHotel As New BLL_Hotel
                    bllHotel.altaHotel(oHotel)
                ElseIf oTipoAlojamiento.ID = 3 Then
                    Dim oDepartamento As New BE_Departamento
                    oDepartamento.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
                    oDepartamento.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
                    oDepartamento.Nombre = TextBox1.Text
                    oDepartamento.Descripcion = Me.TextBox3.Text
                    oDepartamento.Estrellas = Me.NumericUpDown1.Value
                    oDepartamento.Ubicacion = Me.TextBox5.Text
                    oDepartamento.Ambientes = Me.NumericUpDown2.Value
                    oDepartamento.PrecioAlquiler = Me.TextBox7.Text
                    oDepartamento.ConectividadWifi = Me.CheckBox2.Checked
                    oDepartamento.Piscina = Me.CheckBox4.Checked
                    oDepartamento.ServicioAireAcond = Me.CheckBox8.Checked
                    oDepartamento.Desayuno = Me.CheckBox6.Checked
                    oDepartamento.ServicioTV = Me.CheckBox5.Checked
                    Dim bllDepartamento As New BLL_Departamento
                    oDepartamento.Mascota = Me.CheckBox3.Checked
                    oDepartamento.Cochera = Me.CheckBox12.Checked
                    oDepartamento.Cocina = Me.CheckBox9.Checked
                    oDepartamento.Amoblado = Me.CheckBox11.Checked
                    bllDepartamento.altadep(oDepartamento)
                ElseIf oTipoAlojamiento.ID = 4 Then
                    Dim oPosada As New BE_Posada
                    oPosada.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
                    oPosada.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
                    oPosada.Nombre = TextBox1.Text
                    oPosada.Descripcion = Me.TextBox3.Text
                    oPosada.Estrellas = Me.NumericUpDown1.Value
                    oPosada.Ubicacion = Me.TextBox5.Text
                    oPosada.Ambientes = Me.NumericUpDown2.Value
                    oPosada.PrecioAlquiler = Me.TextBox7.Text
                    oPosada.ConectividadWifi = Me.CheckBox2.Checked
                    oPosada.Piscina = Me.CheckBox4.Checked
                    oPosada.ServicioAireAcond = Me.CheckBox8.Checked
                    oPosada.Desayuno = Me.CheckBox6.Checked
                    oPosada.ServicioTV = Me.CheckBox5.Checked
                    Dim bllPosada As New BLL_Posada
                    oPosada.Mascota = Me.CheckBox3.Checked
                    bllPosada.altaPosada(oPosada)
                End If
            Else
                'ACA EL MENSAJE DE ERROR
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Agregar_Alojamiento_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class