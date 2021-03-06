﻿Imports DAL
Imports EE

Public Class BLL_Destino

    Dim _dalDestino As New DAL_Destino

    Public Sub altaDestino(ByVal paramDes As BE_Destino)
        Try
            _dalDestino.alta(paramDes)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub eliminarDestino(ByVal paramDes As BE_Destino)
        Try
            _dalDestino.eliminar(paramDes)
        Catch ex As Exception
            Throw New errorEnDeleteException
        End Try
    End Sub

    Public Function consultarDestinos() As List(Of BE_Destino)
        Try
            Return _dalDestino.consultarDestinos()

        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Function

    Public Function modificarDestino(ByVal paramDes As BE_Localidad) As Boolean
        Try
            Return _dalDestino.modificar(paramDes)
        Catch ex As Exception
            Throw New errorEnEditException
        End Try

    End Function

End Class
