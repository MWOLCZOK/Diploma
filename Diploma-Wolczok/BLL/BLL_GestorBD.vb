Imports DAL
Imports System.Configuration

Public Class BLL_GestorBD
    Dim _dalGestor As New DAL.GestorBD

    Public Sub gestorBD(ByVal paramUsuario As EE.BE_Usuario)
        Try
            Dim usuarioAdmin As String
            Dim passAdmin As String
            usuarioAdmin = ConfigurationManager.AppSettings("user")
            passAdmin = ConfigurationManager.AppSettings("password")
            If paramUsuario.NombreUsuario = usuarioAdmin And Encriptadora.EncriptarPass(paramUsuario.Password) = passAdmin Then
                _dalGestor.CrearBD()
            Else
                Throw New usuarioAdministradorIncorrectoException
            End If
        Catch ex As Exception
            Throw New errorEnGenerarDB
        End Try

    End Sub

    Public Function existeBD() As Boolean

        Return _dalGestor.existeBD()
    End Function


End Class
