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
        chkMascotas.Hide()
        chkCochera.Hide()
        chkAmoblado.Hide()
        chkCocina.Hide()
        chkPrivada.Hide()
        chkGimnasio.Hide()
        chkSauna.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        If oTipoAlojamiento.ID = 1 Then
            chkPrivada.Show()
            chkCocina.Show()
            chkMascotas.Hide()
            chkCochera.Hide()
            chkAmoblado.Hide()
            chkGimnasio.Hide()
            chkMascotas.Hide()
            chkSauna.Hide()
        ElseIf oTipoAlojamiento.ID = 2 Then
            chkGimnasio.Show()
            chkMascotas.Show()
            chkSauna.Show()
            chkCochera.Show()
            chkAmoblado.Hide()
            chkCocina.Hide()
        ElseIf oTipoAlojamiento.ID = 3 Then
            chkMascotas.Show()
            chkCochera.Show()
            chkAmoblado.Show()
            chkCocina.Show()
            chkPrivada.Hide()
            chkGimnasio.Hide()
            chkSauna.Hide()
        ElseIf oTipoAlojamiento.ID = 4 Then
            chkMascotas.Show()
            chkCochera.Hide()
            chkAmoblado.Hide()
            chkCocina.Hide()
            chkPrivada.Hide()
            chkGimnasio.Hide()
            chkSauna.Hide()
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
                    oHostel.ConectividadWifi = Me.chkWIFI.Checked
                    oHostel.Piscina = Me.chkPiscina.Checked
                    oHostel.ServicioAireAcond = Me.chkAire.Checked
                    oHostel.Desayuno = Me.chkDesayuno.Checked
                    oHostel.ServicioTV = Me.chkTV.Checked
                    oHostel.Cocina = Me.chkCocina.Checked
                    oHostel.HabitacionPrivada = Me.chkPrivada.Checked
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
                    oHotel.ConectividadWifi = Me.chkWIFI.Checked
                    oHotel.Piscina = Me.chkPiscina.Checked
                    oHotel.ServicioAireAcond = Me.chkAire.Checked
                    oHotel.Desayuno = Me.chkDesayuno.Checked
                    oHotel.ServicioTV = Me.chkTV.Checked
                    oHotel.Gimnasio = Me.chkGimnasio.Checked
                    oHotel.Mascota = Me.chkMascotas.Checked
                    oHotel.Sauna = Me.chkSauna.Checked
                    oHotel.Cochera = Me.chkCochera.Checked
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
                    oDepartamento.ConectividadWifi = Me.chkWIFI.Checked
                    oDepartamento.Piscina = Me.chkPiscina.Checked
                    oDepartamento.ServicioAireAcond = Me.chkAire.Checked
                    oDepartamento.Desayuno = Me.chkDesayuno.Checked
                    oDepartamento.ServicioTV = Me.chkTV.Checked
                    Dim bllDepartamento As New BLL_Departamento
                    oDepartamento.Mascota = Me.chkMascotas.Checked
                    oDepartamento.Cochera = Me.chkCochera.Checked
                    oDepartamento.Cocina = Me.chkCocina.Checked
                    oDepartamento.Amoblado = Me.chkAmoblado.Checked
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
                    oPosada.ConectividadWifi = Me.chkWIFI.Checked
                    oPosada.Piscina = Me.chkPiscina.Checked
                    oPosada.ServicioAireAcond = Me.chkAire.Checked
                    oPosada.Desayuno = Me.chkDesayuno.Checked
                    oPosada.ServicioTV = Me.chkTV.Checked
                    Dim bllPosada As New BLL_Posada
                    oPosada.Mascota = Me.chkMascotas.Checked
                    bllPosada.altaPosada(oPosada)
                End If
                MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
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
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Alojamiento")
    End Sub
End Class