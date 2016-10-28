Public Class BLL_Asiento
    Dim dalAsiento As New DAL.DAL_Asiento

    Public Sub altaAsiento(ByVal oAsiento As EE.BE_Asiento)
        Try
            dalAsiento.alta(oAsiento)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarAsiento(ByVal oAsiento As EE.BE_Asiento)
        Try
            dalAsiento.eliminar(oAsiento)
        Catch ex As Exception

        End Try
    End Sub


    Public Function consultarAsientos(ByVal oTransporte As EE.BE_Transporte) As List(Of EE.BE_Asiento)
        Return dalAsiento.consultarAsientos(oTransporte)
    End Function



    Public Function consultarAsientos(ByVal oAsiento As EE.BE_Asiento) As EE.BE_Asiento
        Return dalAsiento.consultarAsiento(oAsiento)
    End Function

    Public Function modificarDestino(ByVal oAsiento As EE.BE_Asiento) As Boolean
        Try
            Return dalAsiento.modificar(oAsiento)
        Catch ex As Exception
        End Try

    End Function
End Class
