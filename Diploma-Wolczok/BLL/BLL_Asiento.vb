Public Class BLL_Asiento
    Dim dalAsiento As New DAL.DAL_Asiento



    Public Function consultarAsientos(ByVal oTransporte As EE.BE_Transporte) As List(Of EE.BE_Asiento)
        Return dalAsiento.consultarAsientos(oTransporte)
    End Function



    Public Function consultarAsientos(ByVal oAsiento As EE.BE_Asiento) As EE.BE_Asiento
        Return dalAsiento.consultarAsiento(oAsiento)
    End Function

End Class
