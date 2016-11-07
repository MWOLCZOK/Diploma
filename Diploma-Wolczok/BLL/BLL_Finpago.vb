Imports EE
Imports DAL

Public Class BLL_Finpago

    Dim _dalfinpago As New DAL_Findepago

    Public Function consultarfinpago() As List(Of BE_Finpago)
        Try
            Return _dalfinpago.consultarfinpago()
        Catch ex As Exception

        End Try
    End Function

End Class
