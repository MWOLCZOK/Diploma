Public Class BLL_CategoriaAsiento


    Dim dalCategoriaAsiento As New DAL.DAL_CategoriaAsiento

    Public Sub altaCategoriaAsiento(ByVal oCategoriaAsiento As EE.BE_CategoriaAsiento)
        Try
            dalCategoriaAsiento.alta(oCategoriaAsiento)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarCategoriaAsiento(ByVal oCategoriaAsiento As EE.BE_CategoriaAsiento)
        Try
            dalCategoriaAsiento.eliminar(oCategoriaAsiento)
        Catch ex As Exception

        End Try
    End Sub


    Public Function consultarCategoriaAsientos() As List(Of EE.BE_CategoriaAsiento)
        Return dalCategoriaAsiento.consultarCategoriaAsientos()
    End Function



    Public Function consultarCategoriaAsiento(ByVal oCategoriaAsiento As EE.BE_CategoriaAsiento) As EE.BE_CategoriaAsiento
        Return dalCategoriaAsiento.consultarCategoriaAsiento(oCategoriaAsiento)
    End Function

    Public Function modificarCategoriaAsiento(ByVal oCategoriaAsiento As EE.BE_CategoriaAsiento) As Boolean
        Try
            Return dalCategoriaAsiento.modificar(oCategoriaAsiento)
        Catch ex As Exception
        End Try

    End Function




End Class
