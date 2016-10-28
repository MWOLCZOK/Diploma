Imports EE
Imports BLL

Public Class Reserva_Buscar_Asientos
    Protected Friend viaje As BE_Viaje
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
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cargarGrid()
    End Sub

    Private Sub cargarGrid()
        Me.Txtdestino.Text = reservaDestino.NombreCompleto
        Me.Txtorigen.Text = reservaOrigen.NombreCompleto
        Me.Txtempresatrans.Text = viaje.Transporte.Empresa.Nombre
        Me.Txtfechaviaje.Text = viaje.FechaHoraSalida.Date
        Me.Txttipotrans.Text = viaje.Transporte.TipoTransporte.Descripcion
        Dim oListaAsiento As New List(Of EE.BE_Asiento)
        Dim bllAsiento As New BLL.BLL_Asiento
        oListaAsiento = bllAsiento.consultarAsientos(reservaTransporte)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = oListaAsiento
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub Reserva_Buscar_Asientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        Try
            Dim oReservaViaje As New BE_ReservaViaje
            oReservaViaje = reservaViaje
            Dim oAsiento As New BE_Asiento
            oAsiento.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            Dim bllAsiento As New BLL.BLL_Asiento

            oReservaViaje.Asiento = bllAsiento.consultarAsientos(oAsiento)
            Dim formularioreservaasientos As New Reserva_Buscar_Pasajero(viaje, oReservaViaje, reservaOrigen, reservaDestino)
            formularioreservaasientos.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class