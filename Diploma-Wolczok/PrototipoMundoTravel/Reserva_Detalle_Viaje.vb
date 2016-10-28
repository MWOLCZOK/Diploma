Imports EE

Public Class Reserva_Detalle_Viaje

    Protected Friend viaje As EE.BE_Viaje
    Protected Friend reservaViaje As EE.BE_ReservaViaje
    Protected Friend reservaDestino As EE.BE_Destino
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
        iniciar()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub iniciar()
        Me.Txtdestino.Text = reservaDestino.NombreCompleto
        Me.Txtempresatrans.Text = viaje.Transporte.Empresa.Nombre
        Me.Txtfechaviaje.Text = viaje.FechaHoraSalida
        Me.Txttipotrans.Text = reservaTransporte.TipoTransporte.ToString
        Me.Txtorigen.Text = reservaOrigen.NombreCompleto
        Me.TextBox1.Text = reservaViaje.Asiento.NumeroAsiento
    End Sub

    Private Sub Reserva_Detalle_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formulariobuscarviaje As New Reserva_Buscar_Viaje()
        formulariobuscarviaje.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class