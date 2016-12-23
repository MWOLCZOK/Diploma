Imports BLL

Public Class Eliminar_Permiso

    Implements BLL.BLL_Iobservador

    Private Sub EliminarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControladorPermisos.CargarPermisos(ComboBox1)
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))
    End Sub




    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(ComboBox1.SelectedItem) Then
                Dim Perfil As EE.BE_GrupoPermiso = DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso)
                Dim GestorPermisos As New BLL.BLL_GestorPermiso

                GestorPermisos.Baja(Perfil.ID)
                ControladorPermisos.CargarPermisos(ComboBox1)
                Tree.Nodes.Clear()
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_116"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Eliminar_Permiso_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Eliminar Permiso")
    End Sub
End Class