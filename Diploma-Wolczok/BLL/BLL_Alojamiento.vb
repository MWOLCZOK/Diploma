Public Class BLL_Alojamiento

    Private Function obtenerAlojamientos() As List(Of EE.BE_Alojamiento)
        Try
            Dim olistaAlojamiento As New List(Of EE.BE_Alojamiento)
            Dim olistaHostel As New List(Of EE.BE_Hostel)
            Dim olistaHotel As New List(Of EE.BE_Hotel)
            Dim olistaDepartamento As New List(Of EE.BE_Departamento)
            Dim olistaPosada As New List(Of EE.BE_Posada)

            Dim bllHotel As New BLL.BLL_Hotel
            Dim bllHostel As New BLL.BLL_Hostel
            Dim bllDepartamento As New BLL.BLL_Departamento
            Dim bllPosada As New BLL.BLL_Posada

            olistaHostel = bllHostel.consultarHostels
            olistaHotel = bllHotel.consultarHoteles
            olistaDepartamento = bllDepartamento.consultardep
            '    olistaPosada = bllPosada.consultarPosadas




        Catch ex As Exception

        End Try
    End Function


    Private Sub concatenarLista(ByRef listaAlojamiento As List(Of EE.BE_Alojamiento), ByVal oListaHijos As List(Of EE.BE_Alojamiento))
        For Each hijoAlojamiento As EE.BE_Alojamiento In oListaHijos
            listaAlojamiento.Add(hijoAlojamiento)
        Next
    End Sub

End Class
