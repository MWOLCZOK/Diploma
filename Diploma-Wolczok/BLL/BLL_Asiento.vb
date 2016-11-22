Public Class BLL_Asiento
    Dim dalAsiento As New DAL.DAL_Asiento



    Public Function consultarAsientos(ByVal oViaje As EE.BE_Viaje) As List(Of EE.BE_Asiento)
        Return dalAsiento.consultarAsientos(oViaje)
    End Function



    Public Function consultarAsientos(ByVal oAsiento As EE.BE_Asiento) As EE.BE_Asiento
        Return dalAsiento.consultarAsiento(oAsiento)
    End Function

End Class
