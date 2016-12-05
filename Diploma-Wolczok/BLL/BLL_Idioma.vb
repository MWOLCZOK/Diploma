Imports EE
Imports DAL

Public Class BLL_Idioma
    Dim _dalIdioma As New DAL.DAL_Idioma



    Public Function SeleccionarIdioma(ByRef Usuario As BE_Usuario, ByRef ID_Idioma As Integer) As BE_Idioma
        Try
            Dim IdiomaSeleccionado = (New DAL_Idioma).SeleccionarIdioma(Usuario, ID_Idioma)
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("El Usuario: " & Usuario.NombreUsuario & " cambió su idioma.", BE_TipoBitacora.Modificación, SessionBLL.SesionActual.ObtenerUsuarioActual))
            Return IdiomaSeleccionado
        Catch FalloConexion As InvalidOperationException
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("No se pudo cambiar el Idioma del usuario: " & Usuario.Nombre & ". Error de Conexion", BE_TipoBitacora.Errores, SessionBLL.SesionActual.ObtenerUsuarioActual))
            Throw FalloConexion
        Catch ex As Exception
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("El Metodo " & ex.TargetSite.ToString & " generó un error. Su mensaje es: " & ex.Message, BE_TipoBitacora.Errores, SessionBLL.SesionActual.ObtenerUsuarioActual))
            Throw ex
        End Try
    End Function


    Public Function consultarIdiomas() As List(Of EE.BE_Idioma)
        Try
            Return _dalIdioma.consultarIdiomas()
        Catch ex As Exception
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("El Metodo " & ex.TargetSite.ToString & " generó un error. Su mensaje es: " & ex.Message, BE_TipoBitacora.Errores, SessionBLL.SesionActual.ObtenerUsuarioActual))
            Throw ex
        End Try
    End Function


    Public Function consultarIdiomas(ByVal idIdioma As Integer) As EE.BE_Idioma
        Try
            Return _dalIdioma.ConsultarPorID(idIdioma)
        Catch ex As Exception
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("El Metodo " & ex.TargetSite.ToString & " generó un error. Su mensaje es: " & ex.Message, BE_TipoBitacora.Errores, SessionBLL.SesionActual.ObtenerUsuarioActual))
            Throw ex
        End Try
    End Function


    Public Function ConsultarPorID(ByVal ID_Idioma As Integer) As EE.BE_Idioma
        Try
            Return _dalIdioma.ConsultarPorID(ID_Idioma)
        Catch ex As Exception

        End Try
    End Function


    Public Function ConsultarNombre(ByVal Idioma As String) As Boolean
        Try
            Return _dalIdioma.ConsultarNombre(Idioma)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub altaIdioma(ByVal paramIdioma As EE.BE_Idioma)
        Try
            _dalIdioma.altaIdioma(paramIdioma)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub modificarIdioma(ByVal paramIdioma As EE.BE_Idioma)
        Try
            _dalIdioma.ModificarIdioma(paramIdioma)
        Catch ex As Exception

        End Try
    End Sub


    Public Sub eliminarIdioma(ByVal paramIdioma As EE.BE_Idioma)
        Try
            _dalIdioma.EliminarIdioma(paramIdioma)
        Catch ex As Exception

        End Try
    End Sub


    Public Function ConsultarIdiomasEditables() As List(Of EE.BE_Idioma)
        Try
            Dim IdiomasEditables As List(Of EE.BE_Idioma) = New List(Of EE.BE_Idioma)
            IdiomasEditables = _dalIdioma.ConsultarIdiomasEditables
            Dim listaretorno As List(Of EE.BE_Idioma) = New List(Of EE.BE_Idioma)
            For Each idioma In IdiomasEditables
                If idioma.id_idioma <> SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.id_idioma Then
                    listaretorno.Add(idioma)
                End If
            Next
            Return listaretorno
        Catch ex As Exception

        End Try
    End Function


End Class
