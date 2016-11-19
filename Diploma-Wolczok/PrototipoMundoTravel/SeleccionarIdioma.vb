Imports BLL
Imports EE

Public Class FormSeleccionar_Idioma
    Implements BLL_Iobservador

    Private Sub SeleccionarIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Iniciar()
        Try
            CbxIdioma.Items.Clear()
            CbxIdioma.SelectedItem = Nothing
            Dim GestorIdioma As BLL_Idioma = New BLL_Idioma
            Dim Listaidiomas = New List(Of EE.BE_Idioma)
            Listaidiomas = GestorIdioma.consultarIdiomas()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
        Catch ex As Exception
            MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_22"), ControladorTraductor.TraducirMensaje("Titulo_02"), MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                Dim Idioma As BE_Idioma = DirectCast(CbxIdioma.SelectedItem, BE_Idioma)
                Dim GestorIdioma As BLL_Idioma = New BLL_Idioma

                Idioma = GestorIdioma.SeleccionarIdioma(SessionBLL.SesionActual.ObtenerUsuarioActual, Idioma.id_idioma)
                SessionBLL.SesionActual.ActualizarIdiomaUsuario(Idioma)
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_22"), ControladorTraductor.TraducirMensaje("Titulo_02"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Iniciar()
            Else
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_23"), ControladorTraductor.TraducirMensaje("Titulo_02"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch FalloConexion As InvalidOperationException

        Catch ex As Exception
            MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_35"), ControladorTraductor.TraducirMensaje("Titulo_02"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class