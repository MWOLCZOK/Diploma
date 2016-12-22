Imports EE
Imports BLL

Public Class Reserva_Buscar_Asientos
    Implements BLL.BLL_Iobservador


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
        Try
            Me.Txtdestino.Text = reservaDestino.NombreCompleto
            Me.Txtorigen.Text = reservaOrigen.NombreCompleto
            Me.Txtempresatrans.Text = viaje.Transporte.Empresa.Nombre
            Me.Txtfechaviaje.Text = viaje.FechaHoraSalida.Date
            Me.Txttipotrans.Text = viaje.Transporte.TipoTransporte.Descripcion
            Dim oListaAsiento As New List(Of EE.BE_Asiento)
            Dim bllAsiento As New BLL.BLL_Asiento
            oListaAsiento = bllAsiento.consultarAsientos(viaje)
            DataGridView1.DataSource = Nothing
            'DataGridView1.DataSource = oListaAsiento
            DataGridView1.ReadOnly = True

            Dim listColumns As New List(Of String)
            listColumns.Add("ID")
            listColumns.Add("Transporte")
            listColumns.Add("Fila")
            listColumns.Add("NumeroAsiento")
            listColumns.Add("CategoriaAsiento")
            LlenarTabla(DataGridView1, listColumns)
            Me.DataGridView1.DataSource = oListaAsiento



            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Reserva_Buscar_Asientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
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

    Private Sub btnSalir_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles btnSalir.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Vuelos")
    End Sub

    Private Sub Txtdestino_TextChanged(sender As Object, e As EventArgs) Handles Txtdestino.TextChanged

    End Sub

    Shared Sub LlenarTabla(dvg As DataGridView, list As List(Of String))
        Dim cantidad As Integer = list.Count
        Dim i = 0
        dvg.ColumnCount = cantidad
        dvg.AutoGenerateColumns = False

        For Each item In list
            dvg.Columns(i).Name = item
            dvg.Columns(i).DataPropertyName = item
            dvg.Columns(i).HeaderText = item
            i = i + 1
        Next
        dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub







End Class