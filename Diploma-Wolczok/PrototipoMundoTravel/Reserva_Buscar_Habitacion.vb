Imports EE
Imports BLL

Public Class Reserva_Buscar_Habitacion

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
        Try
            reservaAlojamiento = paramReservaAlojamiento
            reservaDestino = paramDestino
            Alojamiento = paramAlojamiento
            Me.TextBox1.Text = paramAlojamiento.Nombre
            Me.TextBox2.Text = paramReservaAlojamiento.Fecha_Inicio.Date
            Me.TextBox3.Text = paramReservaAlojamiento.Fecha_Fin.Date
            Me.TextBox4.Text = paramDestino.NombreCompleto
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = paramAlojamiento.ListaHabitaciones
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox("No se pudo cargar correctamente los datos", MsgBoxStyle.Exclamation, "Error Base de Datos")
        End Try
    End Sub

    Private Sub SeleccionarHabitacionReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim oHabitacion As New EE.BE_Habitacion
            oHabitacion.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            Dim bllHabitacion As New BLL.BLL_Habitacion
            oHabitacion = bllHabitacion.ConsultarHabitacion(oHabitacion)
            Dim oReservaAlojamiento As New EE.BE_ReservaAlojamiento
            oReservaAlojamiento = reservaAlojamiento
            oReservaAlojamiento.Estado = True
            oReservaAlojamiento.Habitacion = oHabitacion
            oReservaAlojamiento.Detalle = "Prueba"
            Dim formularioSeleccionHabitacion As New Reserva_Buscar_Pasajero(Alojamiento, reservaDestino, oReservaAlojamiento)
            formularioSeleccionHabitacion.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar correctamente los datos", MsgBoxStyle.Exclamation, "Error Base de Datos")
        End Try
       
    End Sub
End Class