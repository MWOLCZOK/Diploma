Imports DAL
Imports EE

Public Class BLL_Puntaje

    Dim _dalpuntaje As New DAL_Puntaje

    Public Function modificarPuntaje(ByVal paramPuntaje As BE_Puntaje) As Boolean
        Try
            Return _dalpuntaje.modificar(paramPuntaje)
        Catch ex As Exception

        End Try

    End Function

    Public Function consultarPuntaje() As List(Of BE_Puntaje)
        Return _dalpuntaje.consultarPuntaje
    End Function

End Class
