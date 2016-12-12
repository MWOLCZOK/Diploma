Imports EE
Imports DAL

Public Class BLL_Pais

    Dim _dalPais As New DAL_Pais


    Public Sub AltaPais(ByVal paramPais As BE_Pais)
        Try
            _dalPais.alta(paramPais)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub eliminarPais(ByVal paramPais As BE_Pais)
        Try
            _dalPais.eliminar(paramPais)
        Catch ex As Exception
            Throw New errorEnDeleteException
        End Try
    End Sub


    Public Function modificarPais(ByVal paramPais As BE_Pais) As Boolean
        Try
            Return _dalPais.modificar(paramPais)
        Catch ex As Exception
            Throw New errorEnEditException
        End Try

    End Function

    Public Function ConsultarPaises() As List(Of BE_Pais)
        Return _dalPais.consultarPaises()
    End Function

End Class
