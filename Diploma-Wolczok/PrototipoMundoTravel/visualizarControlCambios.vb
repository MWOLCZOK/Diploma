Imports BLL
Imports EE

Public Class visualizarControlCambios
    Implements BLL.BLL_Iobservador

    Private Sub visualizarControlCambios_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Try
            Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
            Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub iniciar()
        Dim bllBitacora As New BLL_Bitacora
        Dim listaControl As New List(Of EE.BE_Usuario_Control_Cambios)
        listaControl = bllBitacora.ConsultarGestorCambios()
        Me.dgvBitacora.DataSource = listaControl
        For Each miDestino As EE.BE_Usuario_Control_Cambios In listaControl
            If comprobarsiesta(miDestino) = False Then
                Me.ComboBox1.Items.Add(miDestino)
            End If

        Next
    End Sub

    Private Function comprobarsiesta(ByVal paramCambio As BE_Usuario_Control_Cambios) As Boolean
        For Each item As Object In ComboBox1.Items
            If DirectCast(item, EE.BE_Usuario_Control_Cambios).ID_Cambio = paramCambio.ID_Cambio Then
                Return True
            End If
        Next
        Return False
    End Function




    Private Sub visualizarControlCambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL.BLL_SesionObservada) Implements BLL.BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not IsNothing(ComboBox1.SelectedItem) Then
            Dim bllBitacora As New BLL_Bitacora
            Dim listaControl As New List(Of EE.BE_Usuario_Control_Cambios)
            Dim beCambio As New BE_Usuario_Control_Cambios
            beCambio = DirectCast(ComboBox1.SelectedItem, BE_Usuario_Control_Cambios)
            listaControl = bllBitacora.ConsultarGestorCambios(beCambio)
            dgvBitacora.DataSource = Nothing
            dgvBitacora.DataSource = listaControl
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class