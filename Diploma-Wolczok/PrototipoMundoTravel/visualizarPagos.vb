Imports EE
Imports BLL



Public Class visualizarPagos


    Implements BLL.BLL_Iobservador

    Private Sub Visualizar_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Nothing
        cargarComboPasajeros
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub cargarComboPasajeros()
        Dim Gestorpas As New BLL_Pasajero
        Dim Listapas = Gestorpas.consultarPasajeros()
        For Each pas In Listapas
            Cbxpasajero.Items.Add(pas)
            Cbxpasajero.DisplayMember = "NombreApellido"
        Next
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


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Visualizar_Pagos_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Visualizar Pagos")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpasajero.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Dim Gestorpas As New BLL_Reserva
        Dim oPasajero As New BE_Pasajero
        If Not Me.Cbxpasajero.SelectedItem Is Nothing Then
            oPasajero = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
            Dim ListapasAlojamiento As List(Of BE_ReservaAlojamiento) = Gestorpas.consultarReservaAlojamientoporPasajero(oPasajero)
            For Each pas As BE_Reserva In ListapasAlojamiento
                ComboBox2.Items.Add(pas)
                ComboBox2.DisplayMember = "ID"
            Next
            Dim ListapasViaje As List(Of BE_ReservaViaje) = Gestorpas.consultarReservaViajeporPasajero(oPasajero)
            For Each pas As BE_Reserva In ListapasViaje
                ComboBox2.Items.Add(pas)
                ComboBox2.DisplayMember = "ID"
            Next
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Not Me.Cbxpasajero.SelectedItem Is Nothing Then
                If Not Me.ComboBox2.SelectedItem Is Nothing Then
                    Me.DataGridView1.DataSource = Nothing
                    Dim oPasajero As New BE_Pasajero
                    Dim oReserva As New BE_Reserva
                    Dim oPagoviaje As New BE_Pago
                    oPasajero = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
                    oReserva = DirectCast(ComboBox2.SelectedItem, BE_Reserva)
                    oReserva.Pasajero = oPasajero
                    oPagoviaje.Reserva = oReserva
                    Dim bllPagoViaje As New BLL_PagoViaje
                    Dim oListapago As New List(Of BE_Pago)
                    oListapago = bllPagoViaje.consultarPagosViajes(oReserva)
                    Dim listColumns As New List(Of String)
                    listColumns.Add("ID")
                    listColumns.Add("Reserva")
                    listColumns.Add("TipoReserva")
                    listColumns.Add("Fecha")
                    listColumns.Add("Metodopago")
                    listColumns.Add("Monto")
                    listColumns.Add("Numerotarjeta")
                    LlenarTabla(DataGridView1, listColumns)
                    Me.DataGridView1.DataSource = oListapago
                    DataGridView1.ReadOnly = True
                Else
                    Throw New CamposIncompletosException

                End If
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class