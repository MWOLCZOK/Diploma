Imports BLL

Public Class Eliminar_Idioma
    Implements BLL.BLL_Iobservador

    Public Sub iniciar()
        Try
            CbxIdioma.SelectedItem = Nothing
            CbxIdioma.Items.Clear()
            Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
            Dim Listaidiomas = GestorIdioma.ConsultarIdiomasEditables()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                Dim Idioma As EE.BE_Idioma = DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma)
                Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                GestorIdioma.eliminarIdioma(Idioma)
                MsgBox("Se ha eliminado el idioma correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
                iniciar()
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnDeleteException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Eliminar_Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
            iniciar()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Eliminar_Idioma_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Eliminar Idioma")
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub
End Class