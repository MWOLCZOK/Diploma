Imports BLL
Imports EE

Public Class Reserva_Buscar_Alojamiento
    Implements BLL.BLL_Iobservador

    Private Sub BuscarAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function validarFecha() As Boolean
        If Me.DateTimePicker1.Value < Today Then Return False
        If Me.DateTimePicker2.Value <= Me.DateTimePicker1.Value Then Return False
        Return True
    End Function

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


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Not IsNothing(ComboBox1.SelectedItem) Then
                If validarFecha = True Then
                    Dim oListaAlojamiento As New List(Of EE.BE_Alojamiento)
                    Dim bllAlojamiento As New BLL.BLL_Alojamiento
                    oListaAlojamiento = bllAlojamiento.consultarAlojamiento(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Destino), Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
                    DataGridView1.DataSource = Nothing
                    'DataGridView1.DataSource = oListaAlojamiento
                    DataGridView1.ReadOnly = True

                    Dim listColumns As New List(Of String)
                    listColumns.Add("ID")
                    listColumns.Add("Nombre")
                    listColumns.Add("Descripcion")
                    listColumns.Add("Estrellas")
                    listColumns.Add("Ubicacion")
                    listColumns.Add("Ambientes")
                    listColumns.Add("ConectividadWifi")
                    listColumns.Add("Gimnasio")
                    listColumns.Add("Mascotas")
                    listColumns.Add("Piscina")
                    listColumns.Add("Sauna")
                    listColumns.Add("ServicioAireAcond")
                    listColumns.Add("ServicioTV")
                    listColumns.Add("Cochera")
                    listColumns.Add("Amoblado")
                    listColumns.Add("Cocina")
                    listColumns.Add("HabitacionPrivada")

                    LlenarTabla(DataGridView1, listColumns)
                    Me.DataGridView1.DataSource = oListaAlojamiento








                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Else
                    Throw New FechasIngresadasIncorrectasException
                End If
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As FechasIngresadasIncorrectasException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub cargarCombos()
        Try
            Dim oListaDestino As New List(Of EE.BE_Destino)
            Dim bllDestino As New BLL.BLL_Destino
            oListaDestino = bllDestino.consultarDestinos
            For Each miDestino As EE.BE_Destino In oListaDestino
                Me.ComboBox1.Items.Add(miDestino)
                ComboBox1.DisplayMember = "NombreCompleto"
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            Dim oAlojamiento As New EE.BE_Alojamiento
            oAlojamiento = TryCast(Me.DataGridView1.SelectedRows.Item(0).DataBoundItem, BE_Alojamiento)
            Dim bllAlojamiento As New BLL.BLL_Alojamiento

            Dim oReservaAlojamiento As New EE.BE_ReservaAlojamiento
            oReservaAlojamiento.Fecha_Inicio = Me.DateTimePicker1.Value
            oReservaAlojamiento.Fecha_Fin = Me.DateTimePicker2.Value
            Dim oDestino As New BE_Destino
            oDestino = DirectCast(Me.ComboBox1.SelectedItem, BE_Destino)
            Dim formularioSeleccionHabitacion As New Reserva_Buscar_Habitacion(oAlojamiento, oDestino, oReservaAlojamiento)
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

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Reserva_Buscar_Alojamiento_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alojamiento")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class