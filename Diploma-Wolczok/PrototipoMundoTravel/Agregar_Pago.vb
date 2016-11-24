Imports EE
Imports BLL



Public Class Agregar_Pago
    Implements BLL_Iobservador

    Private Sub Agregar_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
            Cargarcombos()
            ocultar()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Cargarcombos()
        Try
            Dim oListareservaviaje As New List(Of BE_ReservaViaje)
            Dim bllReservaviaje As New BLL_Reserva
            oListareservaviaje = bllReservaviaje.consultarReservaViaje
            For Each miReserva As BE_ReservaViaje In oListareservaviaje
                Me.Cbxreserva.Items.Add(miReserva)
                Cbxreserva.DisplayMember = "ID"
            Next
            Dim oListaReservaAloja As New List(Of BE_ReservaAlojamiento)
            oListaReservaAloja = bllReservaviaje.consultarReservaAlojamiento()
            For Each miReserva As BE_ReservaAlojamiento In oListaReservaAloja
                Me.Cbxreserva.Items.Add(miReserva)
                Cbxreserva.DisplayMember = "ID"
            Next
            Dim oListametodopago As New List(Of BE_Metodopago)
            Dim bllMetodopago As New BLL_Metodopago
            oListametodopago = bllMetodopago.consultarmetodospagos
            For Each mimetodopago As BE_Metodopago In oListametodopago
                Me.Cbxmediopago.Items.Add(mimetodopago)
                Cbxmediopago.DisplayMember = "Descripcion"
            Next
            'Dim oListafinpago As New List(Of BE_Finpago)
            'Dim bllFinpago As New BLL_Finpago
            'oListafinpago = bllFinpago.consultarfinpago
            'For Each mifinpago As BE_Finpago In oListafinpago
            '    Me.Cbxfinpago.Items.Add(mifinpago)
            '    Cbxfinpago.DisplayMember = "Descripcion"
            'Next

        Catch ex As Exception
        End Try
    End Sub


    Public Sub ocultar()
        Txtdescripcion.Hide()
        Label2.Hide()
    End Sub



    Private Sub Cbxmediopago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxmediopago.SelectedIndexChanged

        Dim oMediodepago As New BE_Metodopago
        oMediodepago = DirectCast(Cbxmediopago.SelectedItem, BE_Metodopago)
        If oMediodepago.ID = 1 Then
            Txtdescripcion.Hide()
            Label2.Hide()
        ElseIf oMediodepago.ID = 2 Then
            Txtdescripcion.Show()
            Label2.Show()
        ElseIf oMediodepago.ID = 3 Then
            Txtdescripcion.Show()
            Label2.Show()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim oPagoviaje As New BE_Pago
            Dim bllPagoviaje As New BLL_PagoViaje
            oPagoviaje.Metodopago = DirectCast(Cbxmediopago.SelectedItem, BE_Metodopago)
            oPagoviaje.Fecha = Today.Date
            oPagoviaje.Monto = Me.Txtmontopago.Text
            oPagoviaje.NumeroTarjeta = Me.Txtdescripcion.Text

            Dim oreserva As EE.BE_Reserva = DirectCast(Cbxreserva.SelectedItem, BE_Reserva)
            If oreserva.TipoReserva = TipoReserva.Alojamiento Then
                oPagoviaje.Reserva = DirectCast(Cbxreserva.SelectedItem, BE_ReservaAlojamiento)
            Else
                oPagoviaje.Reserva = DirectCast(Cbxreserva.SelectedItem, BE_ReservaViaje)
            End If

            If bllPagoviaje.validarPago(oPagoviaje) = True Then
                bllPagoviaje.altapagoviaje(oPagoviaje)
            Else
                MsgBox("el pago excede el monto de la reserva", MsgBoxStyle.Exclamation, "Error")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Pago_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Pago")
    End Sub
End Class