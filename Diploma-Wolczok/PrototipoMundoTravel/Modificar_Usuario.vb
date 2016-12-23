Imports EE
Imports BLL


Public Class Modificar_Usuario


    Implements BLL.BLL_Iobservador

    Private Sub iniciar()
        Try
            CbxIdioma.SelectedItem = Nothing
            CbxUsuario.SelectedItem = Nothing
            CbxUsuario.Items.Clear()
            CbxIdioma.Items.Clear()
            Txtnombreusuario.Text = ""
            TxtApe.Text = ""
            Txtnombreusuario.Text = ""
            Dim GestorUsuario As New BLL_Usuario
            Dim ListaUsuarios = GestorUsuario.consultarUsuarios()
            For Each Usu In ListaUsuarios
                Dim GestorIdiom As New BLL_Idioma
                Dim GestorPefil As New BLL_GestorPermiso
                Usu.idioma = GestorIdiom.consultarIdiomas(Usu.idioma.id_idioma)
                If Not Usu.ID = BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.ID Then
                    CbxUsuario.Items.Add(Usu)
                End If
            Next
            Dim GestorIdioma As New BLL_Idioma
            Dim Listaidiomas = GestorIdioma.consultarIdiomas()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
            ControladorPermisos.CargarPermisos(TreeView1)
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub

    Private Sub Modificar_Usuario_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            'MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CbxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxUsuario.SelectedIndexChanged
        Try
            If Not IsNothing(CbxUsuario.SelectedItem) Then
                Dim Usuario As New BE_Usuario
                Usuario = DirectCast(CbxUsuario.SelectedItem, BE_Usuario)
                Me.txtNombre.Text = Usuario.Nombre
                Me.TxtApe.Text = Usuario.Apellido
                Me.Txtnombreusuario.Text = Usuario.NombreUsuario
                For Each Idioma As BE_Idioma In CbxIdioma.Items
                    If Idioma.Nombre = Usuario.idioma.Nombre Then
                        CbxIdioma.SelectedItem = Idioma
                    End If
                Next
                ControladorPermisos.CargarPermisos(Tree, Usuario.Perfil)

            End If
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim usuarioPrevio As New BE_Usuario
        usuarioPrevio = DirectCast(CbxUsuario.SelectedItem, BE_Usuario)
        Dim GestorUsuario As New BLL_Usuario
        GestorUsuario.gestionarCambio(usuarioPrevio, tipoCambio.Modificacion, tipoValor.Anterior)
        Dim NuevoUsuario As EE.BE_Usuario = New BE_Usuario
        Try
            If Not IsNothing(CbxUsuario.SelectedItem) Then
                If Not IsNothing(CbxIdioma.SelectedItem) Or Not String.IsNullOrWhiteSpace(txtNombre.Text) Or Not String.IsNullOrWhiteSpace(TxtApe.Text) Then
                    NuevoUsuario = DirectCast(CbxUsuario.SelectedItem, BE_Usuario)
                    NuevoUsuario.ID = DirectCast(CbxUsuario.SelectedItem, BE_Usuario).ID
                    NuevoUsuario.NombreUsuario = Txtnombreusuario.Text
                    NuevoUsuario.Nombre = txtNombre.Text
                    NuevoUsuario.Apellido = TxtApe.Text
                    NuevoUsuario.idioma = DirectCast(CbxIdioma.SelectedItem, BE_Idioma)
                    Dim oPerfil As New EE.BE_GrupoPermiso
                    oPerfil.Nombre = Txtnombreusuario.Text
                    oPerfil = ControladorPermisos.RecorrerArbol(Nothing, oPerfil, TreeView1)
                    NuevoUsuario.Perfil = oPerfil
                    GestorUsuario.Modificar(NuevoUsuario)
                    GestorUsuario.gestionarCambio(NuevoUsuario, tipoCambio.Modificacion, tipoValor.Posterior)
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_123"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    iniciar()
                Else
                    Throw New PasswordCortoException
                End If
            Else

                Throw New PasswordnoCoincidenException
            End If
        Catch ex As CamposIncorrectosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnEditException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Modificar_Usuario_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Usuario")
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

End Class