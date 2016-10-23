Imports BLL
Imports EE
Public Class SessionBLL
    Inherits BLL_SesionObservada

    Private Shared ReadOnly _instancia As SessionBLL = New SessionBLL

    Public Shared Function SesionActual() As SessionBLL
        Return _instancia
    End Function

    Private Sub New()

    End Sub

    Private _usuario As BE_Usuario
    Public Sub EstablecerUsuarioActual(usuario As EE.BE_Usuario)
        Me._usuario = usuario
    End Sub


    Public Function ObtenerUsuarioActual() As EE.BE_Usuario
        Return Me._usuario
    End Function

    Public Sub CerrarSession()

    End Sub

    Public Sub ActualizarIdiomaUsuario(ByVal paramIdiomaEntidad As EE.BE_Idioma)
        Me._usuario.idioma = paramIdiomaEntidad
        notificarCambiodeIdioma()
    End Sub


End Class
