Imports EE
Imports DAL
Public Class BLL_Transporte
    Dim _dalTransporte As New DAL_Transporte

    Public Sub altaTransporte(ByVal paramTransporte As BE_Transporte)
        Try
            _dalTransporte.alta(paramTransporte)
            Dim _dalAsiento As New DAL_Asiento
            For Each asiento As BE_Asiento In paramTransporte.Asientos
                _dalAsiento.alta(asiento)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarTransporte(ByVal paramTransporte As BE_Transporte)
        Try
            _dalTransporte.eliminar(paramTransporte)
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificarTransporte(ByVal paramTransporte As BE_Transporte) As Boolean
        Try
            _dalTransporte.modificar(paramTransporte)
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarTransportes() As List(Of BE_Transporte)
        Return _dalTransporte.consultarTransportes()
    End Function

    Public Function consultarTransporte(ByVal paramTransporte As BE_Transporte) As List(Of BE_Transporte)
        Return _dalTransporte.consultarTransportes()
    End Function


End Class
