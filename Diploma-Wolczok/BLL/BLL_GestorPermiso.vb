Imports EE
Imports DAL
Public Class BLL_GestorPermiso

    Private PermisosDAL As DAL_GestorPermiso
    Public Function ListarFamilias(ByVal filtro As Boolean) As List(Of BE_PermisoBase)
        Try
            Dim Permisos As List(Of BE_PermisoBase) = New List(Of BE_PermisoBase)
            Permisos = (New DAL_GestorPermiso).ListarFamilias(filtro)
            If Permisos.Count > 0 Then
                Return Permisos
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function chequearNombre(ByVal paramPerfil As BE_GrupoPermiso) As Boolean
        Try
            Dim permisodal As New DAL.DAL_GestorPermiso
            Return permisodal.chequearNombre(paramPerfil)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConsultarporID(ByVal ID As Integer) As BE_GrupoPermiso
        Try
            Dim Permisos As BE_GrupoPermiso = New BE_GrupoPermiso
            Permisos = (New DAL_GestorPermiso).ConsultarporID(ID)
            If Not IsNothing(Permisos) Then
                If Permisos.ID = 0 And IsNothing(SessionBLL.SesionActual.ObtenerUsuarioActual) Then
                    Throw New Exception
                End If
                Return Permisos
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPermisos() As List(Of BE_PermisoBase)
        Try
            PermisosDAL = New DAL_GestorPermiso
            Return PermisosDAL.ListarPermisos()
        Catch FalloConexion As InvalidOperationException
            Throw FalloConexion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNombre(ByVal nombrepermiso As String) As Boolean
        Try
            PermisosDAL = New DAL_GestorPermiso
            Return PermisosDAL.ValidarNombre(nombrepermiso)
        Catch FalloConexion As InvalidOperationException
            Throw FalloConexion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Alta(ByVal paramPermiso As EE.BE_GrupoPermiso)
        Try
            If ValidarNombre(paramPermiso.Nombre) Then
                PermisosDAL.Alta(paramPermiso)
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub Baja(ByVal paramPermisoID As Integer)
        Try
            PermisosDAL = New DAL.DAL_GestorPermiso
            PermisosDAL.Baja(paramPermisoID)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Modificar(ByVal paramPermiso As EE.BE_GrupoPermiso)
        Try
            PermisosDAL = New DAL.DAL_GestorPermiso
            PermisosDAL.Modificar(paramPermiso)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
