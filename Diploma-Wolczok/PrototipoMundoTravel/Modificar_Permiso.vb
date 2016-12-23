Imports BLL

Public Class Modificar_Permiso

    Implements BLL.BLL_Iobservador

    Private Sub ModificarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControladorPermisos.CargarPermisos(ComboBox1)
        ControladorPermisos.CargarPermisos(TreeNuevos)
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lblModificar.Click
        If Not IsNothing(ComboBox1.SelectedItem) Then
            Dim Perfil As EE.BE_GrupoPermiso = DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso)
            Perfil.BorrarHijos()
            Perfil = ControladorPermisos.RecorrerArbol(Nothing, Perfil, TreeNuevos)
            If Perfil.Hijos.Count <> 0 Then
                Dim GestorPermisos As New BLL.BLL_GestorPermiso
                GestorPermisos.Modificar(Perfil)
                'MessageBox.Show("Se Modificó el Perfil de manera satisfactoria.", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))
                ControladorPermisos.CargarPermisos(TreeNuevos)
            Else
                'MessageBox.Show("Debe seleccionar al menos un permiso, que no sea el mismo a modificar, para continuar.", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ControladorPermisos.CargarPermisos(ComboBox1)
                Tree.Nodes.Clear()
                ControladorPermisos.CargarPermisos(TreeNuevos)
            End If
            MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_120"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Permiso_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Perfiles")
    End Sub
End Class