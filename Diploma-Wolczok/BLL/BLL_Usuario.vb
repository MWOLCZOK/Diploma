Public Class BLL_Usuario

    Private dUsuario As New DAL.DAL_Usuario

    Public Sub altaUsuario(ByVal oUsuario As EE.BE_Usuario)
        Try
            dUsuario.altaUsuario(oUsuario)
            Dim bllGestorPermiso As New BLL_GestorPermiso
            Dim idUsuario As Integer
            idUsuario = dUsuario.retornarUltimoID()
            oUsuario.ID = idUsuario
            bllGestorPermiso.AltaPermisosUsuario(oUsuario)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Function login(ByVal oUsuario As EE.BE_Usuario) As EE.BE_Usuario
        oUsuario.Password = Encriptadora.EncriptarPass(oUsuario.Password) ' Se encripta la contraseña por MD5 (Internet)
        If Me.chequearUsuario(oUsuario) = False Then
            Throw New usuarioInexistenteException
        Else
            If Me.chequearBloqueado(oUsuario) = True Then
                Throw New UsuarioBloqueadoException
            Else
                If Me.chequearPassword(oUsuario) = False Then
                    Throw New PasswordIncorrectoException
                Else
                    oUsuario = consultarUsuario(oUsuario)
                    Me.resetearIntentos(oUsuario)
                    Return oUsuario
                End If
            End If
        End If
    End Function

    Public Function chequearUsuario(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Return dUsuario.chequearUsuario(oUsuario)
    End Function

    Public Function chequearBloqueado(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Return dUsuario.chequearBloqueado(oUsuario)
    End Function

    Public Function chequearPassword(ByVal oUsuario As EE.BE_Usuario) As Boolean
        If dUsuario.chequearPassword(oUsuario) = True Then
            Return True
        Else
            Me.actualizarIntentos(oUsuario)
            Return False
        End If
    End Function

    Public Sub resetearIntentos(ByVal oUsuario As EE.BE_Usuario)
        oUsuario.Intentos = 0
        dUsuario.actualizarIntentos(oUsuario)
    End Sub

    Public Function consultarUsuarios() As List(Of EE.BE_Usuario)
        Return dUsuario.consultarUsuarios()
    End Function


    Public Function consultarUsuario(ByVal oUsuario As EE.BE_Usuario) As EE.BE_Usuario
        Return dUsuario.consultarUsuario(oUsuario)
    End Function

    Public Sub actualizarIntentos(ByVal oUsuario As EE.BE_Usuario)
        Dim paramUsuario As EE.BE_Usuario = consultarUsuario(oUsuario)
        paramUsuario.Intentos += 1
        If paramUsuario.Intentos >= 3 Then
            Me.BloquearUsuario(paramUsuario)
        End If
        dUsuario.actualizarIntentos(paramUsuario)
    End Sub

    Public Sub BloquearUsuario(ByVal oUsuario As EE.BE_Usuario)
        dUsuario.BloquearUsuario(oUsuario)
    End Sub

    Public Sub eliminarUsuario(ByVal paramUsuario As EE.BE_Usuario)
        Try
            dUsuario.Eliminar(paramUsuario)
        Catch ex As Exception
            Throw New errorEnDeleteException
        End Try
    End Sub


    Public Function Modificar(ByVal Usuario As EE.BE_Usuario) As Boolean
        Try
            dUsuario.Modificar(Usuario)
            Dim bllGestorPermiso As New BLL_GestorPermiso
            bllGestorPermiso.ModificarPermisosUsuario(Usuario)
        Catch ex As Exception
            Throw New errorEnEditException
        End Try

    End Function

    Public Function retornarUltimoID() As Integer
        Try
            Return dUsuario.retornarUltimoID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub gestionarCambio(ByVal oUsuario As EE.BE_Usuario, ByVal vTipoValor As EE.tipoValor, ByVal vTipoCambio As EE.tipoCambio)
        Try
            dUsuario.gestionarCambio(oUsuario, vTipoValor, vTipoCambio)
        Catch ex As Exception

        End Try
    End Sub


    Public Sub modificarPassword(ByVal oUsuario As EE.BE_Usuario)
        Try
            dUsuario.modificarPassword(oUsuario)
        Catch ex As Exception

        End Try
    End Sub

End Class
