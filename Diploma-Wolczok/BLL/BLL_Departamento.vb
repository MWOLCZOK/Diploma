Imports DAL
Imports EE

Public Class BLL_Departamento


    Dim _daldepar As New DAL_Departamento

    Public Sub altadep(ByVal paramdep As BE_Departamento)
        Try
            _daldepar.alta(paramdep)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminardep(ByVal paramdep As BE_Departamento)
        Try
            _daldepar.eliminar(paramdep)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificardep(ByVal paramdep As BE_Departamento) As Boolean
        Return _daldepar.modificar(paramdep)
    End Function

    'Public Function consultardep() As List(Of BE_Departamento)
    '    Return _daldepar.consultarDepartamentos
    'End Function




End Class
