Imports BLL

Public Class Login

    Implements BLL_Iobservador

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Try
            validarCampos()
            BLL_DigitoVerificador.Integridad()
            Dim oUsuario As New EE.BE_Usuario
            Dim bUsuario As New BLL.BLL_Usuario
            oUsuario.NombreUsuario = Me.txtUsuario.Text
            oUsuario.Password = Me.txtPassword.Text
            oUsuario = bUsuario.login(oUsuario)
            Dim MiSesion As BLL.SessionBLL = BLL.SessionBLL.SesionActual()
            MiSesion.EstablecerUsuarioActual(oUsuario)
            Dim oBitacora As New EE.BE_Bitacora("Logueo Correcto al Sistema", EE.BE_TipoBitacora.Login, BLL.SessionBLL.SesionActual.ObtenerUsuarioActual)
            BLL.BLL_Bitacora.CrearBitacora(oBitacora)
            MsgBox("Se ha iniciado sesión correctamente", MsgBoxStyle.Information, "Sesión Correcta")
            Dim Menu As FormMenu = New FormMenu
            Menu.RecibirPermisos(oUsuario.Perfil)
            Menu.Show(Me)
            Me.Hide()
        Catch ex As BLL.CamposIncompletosException
            MsgBox("Debe completar los campos para continuar", MsgBoxStyle.Information, "Campos Incompletos")
        Catch ex As BLL.usuarioInexistenteException
            MsgBox("El Usuario ingresado no existe en la Base de Datos", MsgBoxStyle.Exclamation, "Error")
        Catch ex As BLL.UsuarioBloqueadoException
            MsgBox("El Usuario ingresado se encuentra bloqueado", MsgBoxStyle.Exclamation, "Error")
        Catch ex As BLL.PasswordIncorrectoException
            MsgBox("La contraseña ingresada no es correcta. Intente Nuevamente", MsgBoxStyle.Exclamation, "Error")
        Catch ex As Exception
            MsgBox("Se ha producido un error al realizar la acción. Contacte con el Administrador", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub validarCampos()
        If Me.txtPassword.Text = "" Or Me.txtUsuario.Text = "" Then
            Throw New BLL.CamposIncompletosException
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Application.Exit()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Login_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Login")
    End Sub
End Class
