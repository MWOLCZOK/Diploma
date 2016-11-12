Imports DAL
Imports EE


Public Class BLL_Cancelacion

    Dim _cancelacion As New DAL_Cancelacion

    Public Sub alta(ByVal paramCancelacion As BE_Cancelacion)
        Try
            _cancelacion.alta(paramCancelacion)
        Catch ex As Exception
        End Try
    End Sub



End Class
