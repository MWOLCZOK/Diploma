Imports DAL
Imports EE

Public Class BLL_Hostel
    Dim _dalHostel As New DAL_Hostel

    Public Sub altaHostel(ByVal paramHostel As BE_Hostel)
        Try
            _dalHostel.alta(paramHostel)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminarHostel(ByVal paramHostel As BE_Hostel)
        Try
            _dalHostel.eliminar(paramHostel)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarHostel(ByVal paramHostel As BE_Hostel) As Boolean
        Try
            Return _dalHostel.modificar(paramHostel)
        Catch ex As Exception
        End Try

    End Function

End Class
