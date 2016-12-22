Imports EE
Imports BLL

Public Class Reserva_Buscar_Pasajero
    Implements BLL.BLL_Iobservador

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
                'Me.DataGridView2.DataSource = listaPAsajeros
                DataGridView2.ReadOnly = True


                Dim listColumns As New List(Of String)
                listColumns.Add("ID")
                listColumns.Add("Nombre")
                listColumns.Add("Apellido")
                listColumns.Add("Correoelectronico")
                listColumns.Add("DNI")
                listColumns.Add("Domicilio")
                listColumns.Add("Telefono")


                LlenarTabla(DataGridView2, listColumns)
                Me.DataGridView2.DataSource = listaPAsajeros





                DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As errorObtencionDeDatosException
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



    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            If flag = True Then
                Dim oPasajero As New EE.BE_Pasajero
                oPasajero.ID = CInt(Me.DataGridView2.SelectedRows.Item(0).Cells(0).Value)
                Dim bblPäsajero As New BLL.BLL_Pasajero
                oPasajero = bblPäsajero.consultarPasajero(oPasajero)
                reservaViaje.Pasajero = oPasajero
                Dim bllReserva As New BLL_Reserva
                reservaViaje.ID = bllReserva.altaReserva(reservaViaje)
                reservaViaje.MontoReserva = reservaViaje.viaje.Precio
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
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Reserva_Buscar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Reserva_Buscar_Pasajero_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Pasajeros")
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