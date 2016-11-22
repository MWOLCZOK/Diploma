﻿Imports EE
Imports BLL

Public Class Reserva_Buscar_Pasajero
    Protected Friend flag As Boolean
    Protected Friend reservaAlojamiento As EE.BE_ReservaAlojamiento
    Protected Friend reservaDestino As EE.BE_Destino
    Protected Friend Alojamiento As EE.BE_Alojamiento
    Protected Friend viaje As BE_Viaje
    Protected Friend reservaViaje As EE.BE_ReservaViaje
    Protected Friend reservaOrigen As EE.BE_Destino
    Protected Friend reservaTransporte As EE.BE_Transporte

    Sub New(ByVal oViaje As BE_Viaje, ByVal oReservaViaje As BE_ReservaViaje, ByVal oOrigen As BE_Destino, ByVal oDestino As BE_Destino)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        viaje = oViaje
        reservaViaje = oReservaViaje
        reservaDestino = oDestino
        reservaOrigen = oOrigen
        reservaTransporte = oViaje.Transporte
        flag = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        iniciarAlojamiento(paramAlojamiento, paramDestino, paramReservaAlojamiento)
        flag = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub iniciarAlojamiento(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)
        reservaAlojamiento = paramReservaAlojamiento
        reservaDestino = paramDestino
        Alojamiento = paramAlojamiento
    End Sub


    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Try
            If TextBox9.Text.Length >= 3 Then
                Dim oPasajero As New EE.BE_Pasajero
                oPasajero.DNI = Me.TextBox9.Text
                Dim _bllPasajero As New BLL.BLL_Pasajero
                Dim listaPAsajeros As New List(Of EE.BE_Pasajero)
                listaPAsajeros = _bllPasajero.consultarPasajeroporDNI(oPasajero)
                Me.DataGridView2.DataSource = Nothing
                Me.DataGridView2.DataSource = listaPAsajeros
                DataGridView2.ReadOnly = True
                DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception

        End Try


    End Sub





    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click


        Try
            If flag = True Then
                Dim oPasajero As New EE.BE_Pasajero
                oPasajero.ID = CInt(Me.DataGridView2.SelectedRows.Item(0).Cells(0).Value)
                Dim bblPäsajero As New BLL.BLL_Pasajero
                oPasajero = bblPäsajero.consultarPasajero(oPasajero)
                reservaViaje.Pasajero = oPasajero
                Dim bllReserva As New BLL_Reserva
                bllReserva.altaReserva(reservaViaje)
                Dim formularioViajeFINAL As New Reserva_Detalle_Viaje(viaje, reservaViaje, reservaOrigen, reservaDestino)
                formularioViajeFINAL.Show()
                Me.Close()
            Else
                Dim oPasajero As New EE.BE_Pasajero
                oPasajero.ID = CInt(Me.DataGridView2.SelectedRows.Item(0).Cells(0).Value)
                Dim bblPäsajero As New BLL.BLL_Pasajero
                oPasajero = bblPäsajero.consultarPasajero(oPasajero)
                reservaAlojamiento.Pasajero = oPasajero
                Dim bllReserva As New BLL_Reserva
                reservaAlojamiento.ID = bllReserva.altaReserva(reservaAlojamiento)
                Dim formularioSeleccionHabitacion As New Reserva_Detalle(Alojamiento, reservaDestino, reservaAlojamiento)
                formularioSeleccionHabitacion.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("No se pudo cargar correctamente los datos", MsgBoxStyle.Exclamation, "Error Base de Datos")
        End Try
    End Sub


    Private Sub Reserva_Buscar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class