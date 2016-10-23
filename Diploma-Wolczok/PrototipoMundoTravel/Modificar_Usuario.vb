Imports EE
Imports BLL


Public Class Modificar_Usuario
    Private Sub iniciar()
        Try
            CbxIdioma.SelectedItem = Nothing
            CbxPerfil.SelectedItem = Nothing
            CbxUsuario.SelectedItem = Nothing
            CbxUsuario.Items.Clear()
            CbxIdioma.Items.Clear()
            CbxPerfil.Items.Clear()
            TxtNom.Text = ""
            TxtApe.Text = ""
            Txtnombreusuario.Text = ""
            Dim GestorUsuario As New BLL_Usuario
            Dim ListaUsuarios = GestorUsuario.consultarUsuarios()
            For Each Usu In ListaUsuarios
                Dim GestorIdiom As New BLL_Idioma
                Dim GestorPefil As New BLL_GestorPermiso
                Usu.idioma = GestorIdiom.consultarIdiomas(Usu.idioma.id_idioma)
                Usu.Perfil = GestorPefil.ConsultarporID(Usu.Perfil.ID)
                If Not Usu.ID = BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.ID Then
                    CbxUsuario.Items.Add(Usu)
                End If
            Next
            Dim GestorIdioma As New BLL_Idioma
            Dim Listaidiomas = GestorIdioma.consultarIdiomas()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
            ControladorPermisos.CargarPermisos(CbxPerfil)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Modificar_Usuario_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub CbxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxUsuario.SelectedIndexChanged
        If Not IsNothing(CbxUsuario.SelectedItem) Then
            Dim Usuario As New BE_Usuario
            Usuario = DirectCast(CbxUsuario.SelectedItem, BE_Usuario)
            Me.TxtNom.Text = Usuario.Nombre
            Me.TxtApe.Text = Usuario.Apellido
            Me.Txtnombreusuario.Text = Usuario.NombreUsuario
            For Each Perfil As BE_GrupoPermiso In CbxPerfil.Items
                If Perfil.Nombre = Usuario.Perfil.Nombre Then
                    CbxPerfil.SelectedItem = Perfil
                End If
            Next
            For Each Idioma As BE_Idioma In CbxIdioma.Items
                If Idioma.Nombre = Usuario.idioma.Nombre Then
                    CbxIdioma.SelectedItem = Idioma
                End If
            Next
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim GestorUsuario As New BLL_Usuario
        Dim NuevoUsuario As EE.BE_Usuario = New BE_Usuario
        Try
            If Not IsNothing(CbxUsuario.SelectedItem) Then
                If Not IsNothing(CbxIdioma.SelectedItem) And Not IsNothing(CbxPerfil.SelectedItem) And Not String.IsNullOrWhiteSpace(TxtNom.Text) And Not String.IsNullOrWhiteSpace(TxtApe.Text) Then
                    NuevoUsuario = DirectCast(CbxUsuario.SelectedItem, BE_Usuario)
                    NuevoUsuario.ID = DirectCast(CbxUsuario.SelectedItem, BE_Usuario).ID
                    NuevoUsuario.NombreUsuario = Txtnombreusuario.Text
                    NuevoUsuario.Nombre = TxtNom.Text
                    NuevoUsuario.Apellido = TxtApe.Text
                    NuevoUsuario.idioma = DirectCast(CbxIdioma.SelectedItem, BE_Idioma)
                    NuevoUsuario.Perfil = DirectCast(CbxPerfil.SelectedItem, BE_GrupoPermiso)
                    GestorUsuario.Modificar(NuevoUsuario)
                    MessageBox.Show("Se ha modificado el usuario de manera satisfactoria")
                    iniciar()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class