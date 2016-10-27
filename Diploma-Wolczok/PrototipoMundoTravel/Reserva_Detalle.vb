Imports EE
Imports BLL

Public Class Reserva_Detalle


    Protected Friend reservaAlojamiento As EE.BE_ReservaAlojamiento
    Protected Friend reservaDestino As EE.BE_Destino
    Protected Friend Alojamiento As EE.BE_Alojamiento


    Sub New(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        iniciar(paramAlojamiento, paramDestino, paramReservaAlojamiento)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub iniciar(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)
        reservaAlojamiento = paramReservaAlojamiento
        reservaDestino = paramDestino
        Alojamiento = paramAlojamiento
        Me.TextBox1.Text = paramAlojamiento.Nombre
        Me.TextBox2.Text = paramReservaAlojamiento.Fecha_Inicio.Date
        Me.TextBox3.Text = paramReservaAlojamiento.Fecha_Fin.Date
        Me.TextBox4.Text = paramDestino.NombreCompleto
    End Sub

    Private Sub Reserva_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class