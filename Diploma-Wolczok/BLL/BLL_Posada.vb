Imports DAL
Imports EE

Public Class BLL_Posada
    Dim _dalPosada As New DAL_Posada

    Public Sub altaHostel(ByVal paramPosada As BE_Posada)
        Try
            _dalPosada.alta(paramPosada)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminarHostel(ByVal paramPosada As BE_Posada)
        Try
            _dalPosada.eliminar(paramPosada)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarHostel(ByVal paramPosada As BE_Posada) As Boolean
        Try
            Return _dalPosada.modificar(paramPosada)
        Catch ex As Exception

        End Try
    End Function
End Class
