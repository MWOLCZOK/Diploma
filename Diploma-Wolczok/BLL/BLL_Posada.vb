Imports DAL
Imports EE

Public Class BLL_Posada
    Dim _dalPosada As New DAL_Posada

    Public Sub altaPosada(ByVal paramPosada As BE_Posada)
        Try
            _dalPosada.alta(paramPosada)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminarPosada(ByVal paramPosada As BE_Posada)
        Try
            _dalPosada.eliminar(paramPosada)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarPosada(ByVal paramPosada As BE_Posada) As Boolean
        Try
            Return _dalPosada.modificar(paramPosada)
        Catch ex As Exception

        End Try
    End Function
End Class
