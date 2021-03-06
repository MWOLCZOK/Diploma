﻿Imports System.Data.SqlClient
Imports EE
Imports DAL
Public Class DAL_GestorPermiso

    Public Function chequearNombre(ByVal paramPerfil As BE_GrupoPermiso) As Boolean
        Try
            Dim consulta As String = "Select * from Permiso where Nombre=@Nombre"
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@Nombre", paramPerfil.Nombre))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function retornarUltimoID() As Integer
        Try
            Return Acceso.TraerUltimoID("ID_Permiso", "Permiso")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function ListarFamilias(ByVal filtro As Boolean) As List(Of BE_PermisoBase)
        Try
            Dim _listaFamilias As New List(Of BE_PermisoBase)
            Dim Command As SqlCommand
            Command = Acceso.MiComando("Select * from Permiso where esAccion= @accion and ID_Permiso <> @PerfilEliminado order by esAccion asc, ID_Permiso asc")

            If filtro = True Then
                Command.Parameters.Add(New SqlParameter("@accion", 0))
                Command.Parameters.Add(New SqlParameter("@PerfilEliminado", 0))
            Else
                Command.Parameters.Add(New SqlParameter("@accion", 1))
                Command.Parameters.Add(New SqlParameter("@PerfilEliminado", 0))
            End If

            Dim _dt As DataTable = Acceso.Lectura(Command)
            For Each _dr As DataRow In _dt.Rows
                Dim _per As BE_PermisoBase = ConvertirDataRowEnPermiso(_dr)
                _listaFamilias.Add(_per)
            Next
            Return _listaFamilias
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ConsultarporIDporUsuario(ByVal ID As Integer) As BE_GrupoPermiso
        Try
            Try
                Dim Command As SqlCommand = Acceso.MiComando("Select * from Permiso_Usuario where ID_Permiso=@ID_Permiso")
                Command.Parameters.Add(New SqlParameter("@ID_Permiso", ID))
                Dim _dt As DataTable = Acceso.Lectura(Command)
                If _dt.Rows.Count = 1 Then
                    Dim Command2 As SqlCommand = Acceso.MiComando("Select * from Permiso where ID_Permiso=@IDPermiso")
                    Command2.Parameters.Add(New SqlParameter("@IDPermiso", _dt.Rows(0)("ID_Permiso")))
                    Dim _dt2 As DataTable = Acceso.Lectura(Command2)
                    If _dt2.Rows.Count = 1 Then
                        Return ConvertirDataRowEnPermiso(_dt2.Rows(0))
                    Else
                        Return Nothing
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ConsultarporID(ByVal ID As Integer) As BE_GrupoPermiso
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Permiso where ID_Permiso=@IDPermiso")
            Command.Parameters.Add(New SqlParameter("@IDPermiso", ID))
            Dim _dt As DataTable = Acceso.Lectura(Command)
            If _dt.Rows.Count = 1 Then
                Return ConvertirDataRowEnPermiso(_dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPermisos() As List(Of BE_PermisoBase)

        Try
            Dim _listaPermisos As New List(Of BE_PermisoBase)
            Dim Command As SqlCommand
            Command = Acceso.MiComando("Select * from Permiso where ID_Permiso <> 0 order by esAccion asc, ID_Permiso asc")
            Dim _dt As DataTable = Acceso.Lectura(Command)
            For Each _dr As DataRow In _dt.Rows
                Dim _permiso As BE_PermisoBase = ConvertirDataRowEnPermiso(_dr)
                _listaPermisos.Add(_permiso)
            Next
            Return _listaPermisos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNombre(ByVal Nombre As String) As Boolean

        Try
            Dim Command As SqlCommand = Acceso.MiComando("select Nombre from Permiso where Nombre=@Nombre")
            Command.Parameters.Add(New SqlParameter("@Nombre", Nombre))
            Dim Datatabla = Acceso.Lectura(Command)
            If Datatabla.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarporUsuario(ByVal paramUsuario As BE_Usuario) As BE_GrupoPermiso
        Try
            Dim _grupoPermiso As New BE_GrupoPermiso
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Permiso_Usuario where ID_Usuario=@ID_Usuario")
            Command.Parameters.Add(New SqlParameter("@ID_Usuario", paramUsuario.ID))
            Dim _dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In _dt.Rows
                Dim Command2 As SqlCommand = Acceso.MiComando("Select * from Permiso where ID_Permiso=@IDPermiso")
                Command2.Parameters.Add(New SqlParameter("@IDPermiso", drow("ID_Permiso")))
                Dim _dt2 As DataTable = Acceso.Lectura(Command2)
                If _dt2.Rows.Count = 1 Then
                    _grupoPermiso.agregarHijo(ConvertirDataRowEnPermiso(_dt2.Rows(0)))
                Else
                    Return Nothing
                End If
            Next
            Return _grupoPermiso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ConvertirDataRowEnPermiso(_dr As DataRow) As BE_PermisoBase
        Try
            Dim _permiso As BE_PermisoBase
            If Not _dr.Item("esAccion") Is DBNull.Value AndAlso Convert.ToBoolean(_dr.Item("esAccion")) Then
                _permiso = New BE_Permiso
            Else
                _permiso = New BE_GrupoPermiso
            End If
            _permiso.ID = CInt(_dr.Item("ID_Permiso"))
            _permiso.Nombre = Convert.ToString(_dr.Item("Nombre"))
            If _permiso.tieneHijos Then
                Dim ListaHijos As List(Of BE_PermisoBase) = Me.ListarHijos(_permiso.ID)
                For Each hijo As BE_PermisoBase In ListaHijos
                    _permiso.agregarHijo(hijo)
                Next
            End If
            Return _permiso
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ListarHijos(ByVal _id As Integer) As List(Of BE_PermisoBase)
        Try
            Dim lista As List(Of BE_PermisoBase) = New List(Of BE_PermisoBase)
            Dim Command As SqlClient.SqlCommand = Acceso.MiComando("SELECT P.ID_Permiso,Nombre,esAccion FROM Permiso as P LEFT JOIN Permiso_Permiso as PP ON (PP.ID_Hijo=P.ID_Permiso) WHERE PP.ID_Padre = @IDPadre  ORDER BY P.ID_Permiso ASC")
            Command.Parameters.Add(New SqlParameter("@IDPadre", _id))
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each row As DataRow In dt.Rows
                Dim MiPermiso As BE_PermisoBase = Me.ConvertirDataRowEnPermiso(row)
                lista.Add(MiPermiso)
            Next
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Alta(ByVal paramPermiso As EE.BE_GrupoPermiso)
        Try
            Dim MiID As Integer = Acceso.TraerID("ID_Permiso", "Permiso")

            If paramPermiso.tieneHijos = True Then
                'Es un Perfil
                Dim Command As SqlCommand = Acceso.MiComando("insert into Permiso values(@ID_Permiso, @Nombre, @esAccion)")
                With Command.Parameters
                    .Add(New SqlParameter("@ID_Permiso", MiID))
                    .Add(New SqlParameter("@Nombre", paramPermiso.Nombre))
                    .Add(New SqlParameter("@esAccion", 0))
                End With
                Acceso.Escritura(Command)

                For Each MiPermiso As EE.BE_PermisoBase In paramPermiso.obtenerHijos
                    Command = Acceso.MiComando("insert into Permiso_Permiso values (@ID_Padre, @ID_Hijo)")
                    With Command.Parameters
                        .Add(New SqlParameter("@ID_Padre", MiID))
                        .Add(New SqlParameter("@ID_Hijo", MiPermiso.ID))
                    End With
                    Acceso.Escritura(Command)
                Next
            Else
                'Es un Permiso
                Dim Command As SqlCommand = Acceso.MiComando("insert into Permiso values(@ID_Permiso, @Nombre, @esAccion)")
                With Command.Parameters
                    .Add(New SqlParameter("@ID_Permiso", MiID))
                    .Add(New SqlParameter("@Nombre", paramPermiso.Nombre))
                    .Add(New SqlParameter("@esAccion", 1))
                End With
                Acceso.Escritura(Command)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AltaPermisosUsuario(ByVal paramUsuario As EE.BE_Usuario)
        Try
            For Each paramPermiso As BE_PermisoBase In paramUsuario.Perfil.Hijos
                Dim Command As SqlCommand = Acceso.MiComando("insert into Permiso_Usuario values(@ID_Usuario, @ID_Permiso)")
                With Command.Parameters
                    .Add(New SqlParameter("@ID_Usuario", paramUsuario.ID))
                    .Add(New SqlParameter("@ID_Permiso", paramPermiso.ID))
                End With
                Acceso.Escritura(Command)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub ModificarPermisosUsuario(ByVal paramUsuario As EE.BE_Usuario)
        Try
            Dim CommandEliminar As SqlCommand = Acceso.MiComando("delete from Permiso_Usuario where ID_Usuario=@ID_Usuario")
            With CommandEliminar.Parameters
                .Add(New SqlParameter("@ID_Usuario", paramUsuario.ID))
            End With
            Acceso.Escritura(CommandEliminar)
            CommandEliminar.Dispose()
            For Each paramPermiso As BE_PermisoBase In paramUsuario.Perfil.Hijos
                Dim Command As SqlCommand = Acceso.MiComando("insert into Permiso_Usuario values(@ID_Usuario, @ID_Permiso)")
                With Command.Parameters
                    .Add(New SqlParameter("@ID_Usuario", paramUsuario.ID))
                    .Add(New SqlParameter("@ID_Permiso", paramPermiso.ID))
                End With
                Acceso.Escritura(Command)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Baja(ByVal ID As Integer)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Update Usuario set ID_Perfil=@PerfilEliminado where ID_Perfil=@ID_Padre")
            With Command.Parameters
                .Add(New SqlParameter("@PerfilEliminado", 0))
                .Add(New SqlParameter("@ID_Padre", ID))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()

            Command = Acceso.MiComando("delete from Permiso_Permiso where ID_Padre=@ID_Padre")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Padre", ID))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()
            Command = Acceso.MiComando("delete from Permiso_Permiso where ID_Hijo=@ID_Padre")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Padre", ID))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()

            Command = Acceso.MiComando("delete from Permiso where ID_Permiso=@IDPermiso")
            With Command.Parameters
                .Add(New SqlParameter("@IDPermiso", ID))
            End With
            Acceso.Escritura(Command)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(ByVal paramPermiso As EE.BE_GrupoPermiso)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("delete from permiso_permiso where ID_Padre=@ID_Padre")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Padre", paramPermiso.ID))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()
            For Each MiPermiso As EE.BE_PermisoBase In paramPermiso.obtenerHijos
                Command = Acceso.MiComando("insert into permiso_permiso values (@ID_Padre, @ID_Hijo)")
                With Command.Parameters
                    .Add(New SqlParameter("@ID_Padre", paramPermiso.ID))
                    .Add(New SqlParameter("@ID_Hijo", MiPermiso.ID))
                End With
                If Not paramPermiso.ID = MiPermiso.ID Then
                    Acceso.Escritura(Command)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
