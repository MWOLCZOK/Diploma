Imports EE
Imports BLL

Public Class Reserva_Buscar_Habitacion
    Implements BLL.BLL_Iobservador

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
            Me.TextBox5.Text = DateDiff(DateInterval.Day, paramReservaAlojamiento.Fecha_Inicio.Date, paramReservaAlojamiento.Fecha_Fin.Date)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = paramAlojamiento.ListaHabitaciones
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As FechasIngresadasIncorrectasException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
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
            oReservaAlojamiento.MontoAlquiler = Alojamiento.PrecioAlquiler * CInt(Me.TextBox5.Text)
            oReservaAlojamiento.TipoReserva = TipoReserva.Alojamiento
            Dim formularioSeleccionHabitacion As New Reserva_Buscar_Pasajero(Alojamiento, reservaDestino, oReservaAlojamiento)
            formularioSeleccionHabitacion.Show()
            Me.Close()
        Catch ex As FechasIngresadasIncorrectasException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Reserva_Buscar_Habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Reserva_Buscar_Habitacion_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alojamiento")
    End Sub

End Class