Imports EE
Imports BLL

Public Class Agregar_Viaje
    Implements BLL_Iobservador

    Private Sub Agregar_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub cargarCombos()
        Try
            Dim oListaDestinos As New List(Of BE_Destino)
            Dim bllDestino As New BLL_Destino
            oListaDestinos = bllDestino.consultarDestinos
            For Each miDest As BE_Destino In oListaDestinos
                Me.Cbxorigen.Items.Add(miDest)
                Cbxorigen.DisplayMember = "NombreCompleto"
            Next
            Dim oListaDestinos2 As New List(Of BE_Destino)
            Dim bllDestino2 As New BLL_Destino
            oListaDestinos2 = bllDestino.consultarDestinos
            For Each miDest2 As BE_Destino In oListaDestinos2
                Me.Cbxdestino.Items.Add(miDest2)
                Cbxdestino.DisplayMember = "NombreCompleto"
            Next
            Dim oListatipotrans As New List(Of BE_Transporte)
            Dim blltipotrans As New BLL_Transporte
            oListatipotrans = blltipotrans.consultarTransportes
            For Each tipotrans As BE_Transporte In oListatipotrans
                Me.Cbxtipotransporte.Items.Add(tipotrans)
                Cbxtipotransporte.DisplayMember = "Descripcion"
            Next

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Try
        '    Dim oTipotrans As New BE_TipoTransporte
        '    oTipotrans = DirectCast(Cbxtipotransporte.SelectedItem, BE_TipoTransporte)
        '    If oTipotrans.ID = 1 Then
        '        Dim oOrigen As BE_Destino = DirectCast(Cbxorigen.SelectedItem, BE_Destino)
        '        Dim oDestino As BE_Destino = DirectCast(Cbxdestino.SelectedItem, BE_Destino)
        '        Dim oMicro As New BE_Transporte
        '        oMicro.Empresa.Nombre = Me.Txtnombreemp.Text
        '        oMicro.Empresa.Descripcion = Me.Txtdescripcion.Text
        '        oMicro.Empresa.CUIL = Me.Txtcuil.Text
        '        oMicro.Empresa.Mail = Me.Txtmail.Text
        '        oMicro.Empresa.Telefono = Me.Txttelefono.Text
        '        Dim oViaje As New BE_Viaje
        '        oViaje.Cena = Me.Cbxcena.Checked
        '        oViaje.Cafeteria = Me.Cbxcafeteria.Checked
        '        oViaje.Almuerzo = Me.Cbxalmuerzo.Checked
        '        oViaje.FechaHoraSalida = Me.Fechainicio.Value
        '        oViaje.FechaHoraLlegada = Me.Fechafin.Value
        '        oViaje.Precio = Txtprecio.Text
        '        Dim bllviaje As New BLL_Viaje
        '        bllviaje.

    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub
End Class