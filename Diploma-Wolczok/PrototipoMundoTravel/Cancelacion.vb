Imports EE
Imports BLL

Public Class Cancelacion
    Implements BLL.BLL_Iobservador

    Dim bllCancel As New BLL.BLL_Cancelacion
    Protected Friend paramCancelacion As New BE_Cancelacion
    'Protected Friend paramCancelacion As EE.BE_Cancelacion

    Private Sub Txtdni_TextChanged(sender As Object, e As EventArgs) Handles Txtdni.TextChanged
        Try
            If Txtdni.Text.Length >= 3 Then
                Dim oPasajero As New BE_Pasajero
                Dim oReservaviaje As New BE_ReservaViaje
                oPasajero.DNI = Me.Txtdni.Text
                'oReservaviaje.Pasajero = oPasajero
                Dim bllReservaViaje As New BLL_Reserva
                Dim oListareserva As New List(Of BE_ReservaViaje)
                oListareserva = bllReservaViaje.consultarReservaViajeporDNI(oPasajero)
                DataGridView1.Columns.Clear()
                DataGridView1.Rows.Clear()
                'DataGridView1.DataSource = oListareserva
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.Columns.Add("ID", "Identificador de Reserva")
                DataGridView1.Columns.Add("viaje", "Destino")
                DataGridView1.Columns.Add("asiento", "Numero de Asiento")
                DataGridView1.Columns.Add("NumeroReserva", "Numero de Reserva")
                DataGridView1.Columns.Add("Detalle", "Detalle de Reserva")
                DataGridView1.Columns.Add("Estado", "Estado")
                DataGridView1.Columns.Add("Pasajero", "Pasajero")
                DataGridView1.Columns.Add("Puntaje", "Puntaje Acumulado")
                For Each item In oListareserva
                    DataGridView1.Rows.Add(item.ID, item.viaje, item.Asiento, item.NumeroReserva, item.Detalle, item.Estado, item.Pasajero, item.puntaje)
                Next
            End If
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancelacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Nothing
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnCancelarReserva.Click
        Try
            If Not String.IsNullOrWhiteSpace(Me.Txtdecrmotivo.Text) Then
                If paramCancelacion.MontoDevuelto <> 0 Or paramCancelacion.MontoRetenido <> 0 Or paramCancelacion.MontoTotal <> 0 Then
                    Dim oReserva As New BE_ReservaViaje
                    Dim bllReserva As New BLL_Reserva
                    oReserva.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
                    oReserva = bllReserva.consultarReservaviajeID(oReserva)
                    Dim oCancel As New BE_Cancelacion
                    oCancel.Tiporeserva = oReserva.TipoReserva
                    oCancel.Fechacancelacion = Today
                    oCancel.MontoDevuelto = paramCancelacion.MontoDevuelto
                    oCancel.MontoRetenido = paramCancelacion.MontoRetenido
                    oCancel.MontoTotal = paramCancelacion.MontoTotal
                    oCancel.Reserva = oReserva
                    oCancel.DescripcionMotivoCancelacion = Me.Txtdecrmotivo.Text
                    bllCancel.altaCancelacion(oCancel)
                    MsgBox("Se ha cancelado la reserva correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
                Else
                    Throw New CamposIncompletosException
                End If

            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnInsertException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCalcularPunitorios1.Click
        Try
            Dim bllReserva As New BLL.BLL_Reserva
            Dim oReserva As New BE_ReservaViaje
            oReserva.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            oReserva = bllReserva.consultarReservaviajeID(oReserva)
            Dim oCancel As BE_Cancelacion
            oCancel = bllReserva.calcularPunitorios(oReserva)
            Me.Txtmontoretenido.Text = oCancel.MontoRetenido
            Me.Txtmontodevuelto.Text = oCancel.MontoDevuelto
            Me.Txtmontototal.Text = oCancel.MontoTotal
            paramCancelacion = oCancel
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

    Private Sub Cancelacion_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Cancelaciones")
    End Sub

    Private Sub Txtdecrmotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdecrmotivo.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub
End Class