Imports BLL
Imports EE

Public Class Eliminar_Localidad
    Implements BLL.BLL_Iobservador

    Private Sub Eliminar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub


    Public Sub iniciar()
        Try
            CbxLoc.SelectedItem = Nothing
            CbxLoc.Items.Clear()
            CbxLoc.Text = ""
            Dim GestorLoc As BLL_Localidad = New BLL_Localidad
            Dim ListaLoc = GestorLoc.consultarLocalidades()
            For Each local In ListaLoc
                CbxLoc.Items.Add(local)
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            If Not IsNothing(CbxLoc.SelectedItem) Then
                Dim GestorLoc As New BLL_Localidad
                Dim NuevaLoc As New BE_Localidad
                NuevaLoc = DirectCast(CbxLoc.SelectedItem, BE_Localidad)
                GestorLoc.eliminarlocalidad(NuevaLoc)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_30"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_31"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma

        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Eliminar_Localidad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class