Imports EE
Imports DAL

Public Class BLL_Provincia

    Dim _dalprovincia As New DAL_Provincia

    Public Sub altaprovincia(ByVal paramprovincia As BE_Provincia)
        Try
            _dalprovincia.alta(paramprovincia)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub eliminarprovincia(ByVal paramprovincia As BE_Provincia)
        Try
            _dalprovincia.eliminar(paramprovincia)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Consultarprovincias() As List(Of BE_Provincia)
        Return _dalprovincia.consultarProvincias()

    End Function

    Public Function modificarprovincia(ByVal paramprovincia As BE_Provincia) As Boolean
        Try
            Return _dalprovincia.modificar(paramprovincia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function






End Class
