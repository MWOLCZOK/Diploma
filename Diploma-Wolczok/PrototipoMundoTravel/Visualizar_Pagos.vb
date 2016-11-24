Imports EE
Imports BLL



Public Class Visualizar_Pagos


    Implements BLL.BLL_Iobservador

    Private Sub Visualizar_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Nothing

        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub


    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Try
            If TextBox9.Text.Length >= 3 Then
                Dim oPasajero As New BE_Pasajero
                Dim oReservaviaje As New BE_ReservaViaje
                Dim oPagoviaje As New BE_Pago
                oPasajero.DNI = Me.TextBox9.Text
                oReservaviaje.Pasajero = oPasajero


                Dim bllPagoViaje As New BLL_PagoViaje
                Dim oListapago As New List(Of BE_Pago)
                oListapago = bllPagoViaje.consultarPagosViajes(oReservaviaje)


                Dim listColumns As New List(Of String)
                listColumns.Add("Reserva")
                listColumns.Add("TipoReserva")
                listColumns.Add("Fecha")
                listColumns.Add("Metodopago")
                listColumns.Add("Monto")
                listColumns.Add("Numerotarjeta")
                LlenarTabla(DataGridView1, listColumns)




                Me.DataGridView1.DataSource = oListapago
                DataGridView1.ReadOnly = True
                'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells




            End If
        Catch ex As Exception

        End Try

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
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class