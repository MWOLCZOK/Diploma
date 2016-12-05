Imports EE
Imports DAL

Public Class BLL_Localidad

    Dim _dallocalidad As New DAL_Localidad

    Public Sub altalocalidad(ByVal paramloc As BE_Localidad)
        Try
            _dallocalidad.alta(paramloc)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub eliminarlocalidad(ByVal paramloc As BE_Localidad)
        Try
            _dallocalidad.eliminar(paramloc)
        Catch ex As Exception
            Throw New errorEnDeleteException
        End Try
    End Sub

    Public Function consultarLocalidades() As List(Of BE_Localidad)
        Return _dallocalidad.consultarLocalidades()
    End Function

    Public Function modificarLocalidad(ByVal paramloc As BE_Localidad) As Boolean
        Try
            Return _dallocalidad.modificar(paramloc)
        Catch ex As Exception
        End Try

    End Function


End Class
