Imports EE
Imports BLL

Public Class Reserva_Buscar_Pasajero

    Protected Friend reservaAlojamiento As EE.BE_ReservaAlojamiento
    Protected Friend reservaDestino As EE.BE_Destino
    Protected Friend Alojamiento As EE.BE_Alojamiento


    Sub New(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        iniciar(paramAlojamiento, paramDestino, paramReservaAlojamiento)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub iniciar(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)
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
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oPasajero As New EE.BE_Pasajero
        oPasajero.ID = CInt(Me.DataGridView2.SelectedRows.Item(0).Cells(0).Value)
        Dim bblPäsajero As New BLL.BLL_Pasajero
        oPasajero = bblPäsajero.consultarPasajero(oPasajero)
        reservaAlojamiento.Pasajero = oPasajero
        Dim bllReserva As New BLL_Reserva
        bllReserva.altaReserva(reservaAlojamiento)
        Dim formularioSeleccionHabitacion As New Reserva_Detalle(Alojamiento, reservaDestino, reservaAlojamiento)
        formularioSeleccionHabitacion.Show()
        Me.Close()
    End Sub

    Private Sub Reserva_Buscar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class