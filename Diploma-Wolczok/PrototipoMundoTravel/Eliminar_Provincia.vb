Imports BLL
Imports EE



Public Class Eliminar_Provincia

    Implements BLL.BLL_Iobservador

    Private Sub Eliminar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub iniciar()
        Try
            CbxProvincia.SelectedItem = Nothing
            CbxProvincia.Items.Clear()
            CbxProvincia.Text = ""
            Dim GestorProvincia As BLL_Provincia = New BLL_Provincia
            Dim Listaprov = GestorProvincia.Consultarprovincias
            For Each prov In Listaprov
                CbxProvincia.Items.Add(prov)
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            If Not IsNothing(CbxProvincia.SelectedItem) Then
                Dim GestorProv As BLL_Provincia = New BLL_Provincia
                Dim NuevaProv As BE_Provincia = New BE_Provincia
                NuevaProv = DirectCast(CbxProvincia.SelectedItem, BE_Provincia)
                GestorProv.eliminarprovincia(NuevaProv)

                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_33"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_32"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Eliminar_Provincia_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class