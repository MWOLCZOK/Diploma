Imports EE
Imports DAL


Public Class BLL_Metodopago

    Dim _dalmetodopago As New DAL_Metodopago


    Public Function consultarmetodospagos() As List(Of BE_Metodopago)
        Try
            Return _dalmetodopago.consultarMetodosPagos()
        Catch ex As Exception

        End Try
    End Function



End Class
