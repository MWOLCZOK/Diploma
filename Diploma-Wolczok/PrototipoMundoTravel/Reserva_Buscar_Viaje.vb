﻿Imports BLL
Imports EE

Public Class Reserva_Buscar_Viaje
    Implements BLL.BLL_Iobservador

    Private Sub Reserva_Buscar_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub


    Private Sub cargarComboTipoTransporte()
        Dim oListatipotrans As New List(Of BE_TipoTransporte)
        Dim blltipotrans As New BLL_TipoTransporte
        oListatipotrans = blltipotrans.consultarTipoTransportes
        For Each mitrans As BE_TipoTransporte In oListatipotrans
            Me.ComboBox1.Items.Add(mitrans)
        Next
    End Sub

    Private Sub iniciar()
        cargarComboTipoTransporte()
        llenarComboDestino()
        llenarComboOrigen()
    End Sub

    Private Sub llenarComboDestino()
        Dim oListaDestinos As New List(Of BE_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.Cbxdestino.Items.Add(miDest)
            Cbxdestino.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub llenarComboOrigen()
        Dim oListaDestinos As New List(Of BE_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.Cbxorigen.Items.Add(miDest)
            Cbxorigen.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim oListaViaje As New List(Of BE_Viaje)
            Dim bllViaje As New BLL.BLL_Viaje
            Dim oOrigen As BE_Destino = DirectCast(Cbxorigen.SelectedItem, BE_Destino)
            Dim oDestino As BE_Destino = DirectCast(Cbxdestino.SelectedItem, BE_Destino)
            Dim oTipoTransrpote As BE_TipoTransporte = DirectCast(ComboBox1.SelectedItem, BE_TipoTransporte)
            oListaViaje = bllViaje.consultarviajes(oOrigen, oDestino, Me.DateTimePicker1.Value.ToShortDateString, oTipoTransrpote)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = oListaViaje
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function validarFecha() As Boolean
        If Me.DateTimePicker1.Value < Today Then Return False
        Return True
    End Function


    Private Sub btnSeleccionar_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            If Not IsNothing(Cbxorigen.SelectedItem) Then
                If Not IsNothing(Cbxdestino.SelectedItem) Then
                    If Not IsNothing(ComboBox1.SelectedItem) Then
                        If validarFecha() = True Then
                            Dim oViaje As New BE_Viaje
                            oViaje.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
                            Dim bllViaje As New BLL.BLL_Viaje
                            oViaje = bllViaje.consultarViaje(oViaje)
                            Dim oReservaViaje As New BE_ReservaViaje
                            oReservaViaje.viaje = oViaje
                            oReservaViaje.Detalle = "Reserva de Viaje - Mundo Travel"
                            Dim oOrigen As New BE_Destino
                            oOrigen = DirectCast(Me.Cbxorigen.SelectedItem, BE_Destino)
                            Dim oDestino As New BE_Destino
                            oDestino = DirectCast(Me.Cbxdestino.SelectedItem, BE_Destino)
                            Dim formularioreservaasientos As New Reserva_Buscar_Asientos(oViaje, oReservaViaje, oOrigen, oDestino)
                            formularioreservaasientos.Show()
                            Me.Close()
                        Else
                            MsgBox("Debe cargar una fecha correcta", MsgBoxStyle.Exclamation, "Error")

                        End If
                    Else
                        MsgBox("Debe cargar un Tipo de Transporte", MsgBoxStyle.Exclamation, "Error")

                    End If
                Else
                    MsgBox("Debe cargar un Destino", MsgBoxStyle.Exclamation, "Error")
                End If

            Else
                MsgBox("Debe cargar un Origen", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox("No se pudo cargar correctamente los datos", MsgBoxStyle.Exclamation, "Error Base de Datos")
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Reserva_Buscar_Viaje_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Vuelos")
    End Sub
End Class