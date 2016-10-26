Imports DAL
Imports EE

Public Class BLL_Hotel

    Dim _dalHotel As New DAL_Hotel

    Public Sub altaHotel(ByVal paramHotel As BE_Hotel)
        Try
            _dalHotel.alta(paramHotel)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminarHotel(ByVal paramHostel As BE_Hotel)
        Try
            _dalHotel.eliminar(paramHostel)
        Catch ex As Exception

        End Try
    End Sub

    'Public Function consultarHoteles() As List(Of BE_Hotel)
    '    Return _dalHotel.consultarHosteles()
    'End Function

    Public Function modificarHotel(ByVal paramHotel As BE_Hotel) As Boolean
        Try
            Return _dalHotel.modificar(paramHotel)
        Catch ex As Exception
        End Try

    End Function

End Class
