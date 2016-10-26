Imports EE
Imports BLL

Public Class DetalleReserva
    Sub New(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        iniciar(paramAlojamiento, paramDestino, paramReservaAlojamiento)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub iniciar(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)
        Me.TextBox1.Text = paramAlojamiento.Nombre
        Me.TextBox2.Text = paramReservaAlojamiento.Fecha_Inicio.Date
        Me.TextBox3.Text = paramReservaAlojamiento.Fecha_Fin.Date
        Me.TextBox4.Text = paramDestino.NombreCompleto
        Me.TextBox5.Text = paramReservaAlojamiento.Habitacion.Descripcion
    End Sub
End Class