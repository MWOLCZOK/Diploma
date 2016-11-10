Imports EE
Imports BLL



Public Class Agregar_Pago

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Agregar_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarcombos()
        ocultar()
    End Sub

    Public Sub Cargarcombos()
        Try
            Dim oListareservaviaje As New List(Of BE_ReservaViaje)
            Dim bllReservaviaje As New BLL_Reserva
            oListareservaviaje = bllReservaviaje.consultarReservaViaje
            For Each miReserva As BE_ReservaViaje In oListareservaviaje
                Me.Cbxreserva.Items.Add(miReserva)
                Cbxreserva.DisplayMember = "Numeroreserva"
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


    Private Sub Btn_agregarpais_Click(sender As Object, e As EventArgs) Handles Btn_agregarpais.Click
        Try
            Dim oPagoviaje As New BE_PagoViaje
            Dim bllPagoviaje As New BLL_PagoViaje
            oPagoviaje.ID_Metodopago = DirectCast(Cbxmediopago.SelectedItem, BE_Metodopago)
            oPagoviaje.Fecha = Me.DateTimePicker1.Value
            oPagoviaje.Monto = Me.Txtmontopago.Text
            oPagoviaje.Finpago = Me.CheckBox1.Checked
            oPagoviaje.Descripcion = Me.Txtdescripcion.Text
            oPagoviaje.ID_Reservaviaje = DirectCast(Cbxreserva.SelectedItem, BE_ReservaViaje)
            bllPagoviaje.altapagoviaje(oPagoviaje)
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
End Class