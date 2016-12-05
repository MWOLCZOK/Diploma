Imports EE
Imports BLL

Public Class Agregar_Viaje
    Implements BLL_Iobservador

    Private Sub Agregar_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cargarCombos()
        Try
            Dim oListaDestinos As New List(Of BE_Destino)
            Dim bllDestino As New BLL_Destino
            oListaDestinos = bllDestino.consultarDestinos
            For Each miDest As BE_Destino In oListaDestinos
                Me.Cbxorigen.Items.Add(miDest)
                Cbxorigen.DisplayMember = "NombreCompleto"
            Next
            Dim oListaDestinos2 As New List(Of BE_Destino)
            Dim bllDestino2 As New BLL_Destino
            oListaDestinos2 = bllDestino.consultarDestinos
            For Each miDest2 As BE_Destino In oListaDestinos2
                Me.Cbxdestino.Items.Add(miDest2)
                Cbxdestino.DisplayMember = "NombreCompleto"
            Next
            Dim oListatipotrans As New List(Of BE_Transporte)
            Dim blltipotrans As New BLL_Transporte
            oListatipotrans = blltipotrans.consultarTransportes
            For Each tipotrans As BE_Transporte In oListatipotrans
                Me.Cbxtipotransporte.Items.Add(tipotrans)
                Cbxtipotransporte.DisplayMember = "Descripcion"
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Private Function validarFormulario() As Boolean
        If Me.Cbxorigen.SelectedItem Is Nothing Then Return False
        If Me.Cbxdestino.SelectedItem Is Nothing Then Return False
        If Me.Cbxtipotransporte.SelectedItem Is Nothing Then Return False
        Return True
    End Function

    Private Function validaROrigenDestino() As Boolean
        If DirectCast(Me.Cbxorigen.SelectedItem, EE.BE_Destino).ID = DirectCast(Me.Cbxdestino.SelectedItem, BE_Destino).ID Then
            Return False
        End If
        Return True
    End Function

    Private Function validarFechaToday() As Boolean
        If Me.Fechainicio.Value < Today Then Return False
        Return True
    End Function


    Private Function validarFechas() As Boolean
        If Me.Fechafin.Value.ToShortDateString < Me.Fechainicio.Value.ToShortDateString Then Return False
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarFormulario() = True Then
                If validarFechas() = True Then
                    If validarFechaToday() = True Then
                        If validaROrigenDestino() = True Then
                            Dim oViaje As New EE.BE_Viaje
                            Dim oOrigen As New EE.BE_Destino
                            oOrigen = DirectCast(Cbxorigen.SelectedItem, BE_Destino)
                            Dim oDestino As New EE.BE_Destino
                            oDestino = DirectCast(Cbxdestino.SelectedItem, BE_Destino)
                            oViaje.Destino = oDestino
                            oViaje.Origen = oOrigen
                            oViaje.Precio = Txtprecio.Text
                            oViaje.Almuerzo = Cbxalmuerzo.Checked
                            oViaje.Cafeteria = Cbxcafeteria.Checked
                            oViaje.Cena = Cbxcena.Checked
                            oViaje.Transporte = DirectCast(Cbxtipotransporte.SelectedItem, BE_Transporte)
                            oViaje.FechaHoraSalida = Fechainicio.Value
                            oViaje.FechaHoraLlegada = Fechafin.Value
                            Dim bllViaje As New BLL.BLL_Viaje
                            bllViaje.altaViaje(oViaje)
                            MsgBox("Se ha agregado el viaje correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
                        Else
                            Throw New origenydestinoIgualesException
                        End If
                    Else
                        Throw New fechaMayoraHoyException
                    End If
                Else
                    Throw New fechasIngresadasIncorrectasException
                End If
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As FechasIngresadasIncorrectasException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As fechaMayoraHoyException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As origenydestinoIgualesException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnInsertException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Agregar_Viaje_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Vuelos")
    End Sub

    Private Sub Txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtprecio.KeyPress
        e.Handled = validacionTextBox.Monto(e)
    End Sub
End Class