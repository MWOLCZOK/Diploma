Imports EE
Imports DAL

Public Class BLL_Bitacora
    Private _BitacoraDAL As DAL_Bitacora

    Public Shared Sub CrearBitacora(ByVal paramBitacora As BE_Bitacora)
        Try
            Dim oBitacoraDAL As DAL_Bitacora = New DAL_Bitacora
            oBitacoraDAL.GuardarBitacora(paramBitacora)
        Catch FalloConexion As InvalidOperationException
            Throw FalloConexion
        End Try
    End Sub

    Public Function ConsultarBitacora(Optional ByRef Usuario As BE_Usuario = Nothing, Optional ByRef Tipo As BE_TipoBitacora = Nothing, Optional ByVal FechaInicio As DateTime = Nothing, Optional ByVal FechaFin As DateTime = Nothing) As List(Of BE_Bitacora)
        _BitacoraDAL = New DAL_Bitacora
        Dim BitacoraResultado As List(Of BE_Bitacora)
        If IsNothing(Usuario) And Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora()
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If

        ElseIf Not IsNothing(Usuario) And Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(Usuario)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf IsNothing(Usuario) And Not Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(, Tipo)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf Not IsNothing(Usuario) And Not Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(Usuario, Tipo)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf IsNothing(Usuario) And Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(, , FechaInicio, FechaFin)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf Not IsNothing(Usuario) And Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(Usuario, , FechaInicio, FechaFin)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf IsNothing(Usuario) And Not Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(, Tipo, FechaInicio, FechaFin)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception
            End If
        ElseIf Not IsNothing(Usuario) And Not Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
            BitacoraResultado = _BitacoraDAL.ConsultarBitacora(Usuario, Tipo, FechaInicio, FechaFin)
            If BitacoraResultado.Count > 0 Then
                Return BitacoraResultado
            Else
                Return BitacoraResultado
                'Throw New Exception

            End If
        End If
        Throw New Exception
    End Function


    Public Function ConsultarGestorCambios(ByVal paramUsuario As BE_Usuario_Control_Cambios) As List(Of EE.BE_Usuario_Control_Cambios)
        Try
            Dim oBitacoraDAL As DAL_Bitacora = New DAL_Bitacora
            Return oBitacoraDAL.ConsultarGestorCambios(paramUsuario)
        Catch ex As Exception

        End Try
    End Function

    Public Function ConsultarGestorCambios() As List(Of EE.BE_Usuario_Control_Cambios)
        Try
            Dim oBitacoraDAL As DAL_Bitacora = New DAL_Bitacora
            Return oBitacoraDAL.ConsultarGestorCambios()
        Catch ex As Exception

        End Try
    End Function
End Class
