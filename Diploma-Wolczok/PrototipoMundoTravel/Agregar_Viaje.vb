Imports EE
Imports BLL

Public Class Agregar_Viaje

    Private Sub Agregar_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
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
            Dim oListatipotrans As New List(Of BE_TipoTransporte)
            Dim blltipotrans As New BLL_TipoTransporte
            oListatipotrans = blltipotrans.consultarTipoTransportes
            For Each tipotrans As BE_TipoTransporte In oListatipotrans
                Me.Cbxtipotransporte.Items.Add(tipotrans)
                Cbxtipotransporte.DisplayMember = "Descripcion"
            Next

        Catch ex As Exception

        End Try
    End Sub






    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
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

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
End Class