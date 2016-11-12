Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Cancelacion

    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramCancelacion As BE_Cancelacion = DirectCast(paramobjeto, BE_Cancelacion)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Cancelacion values (@ID, @ID_Reserva, @ID_Tiporeserva, @MontoDevuelto, @MontoRetenido,@MontoTotal, @DescripcionMotivoCancelacion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Pais")))
                .Add(New SqlParameter("@ID_Reserva", paramCancelacion.Reserva.ID))
                .Add(New SqlParameter("@ID_Tiporeserva", paramCancelacion.Tiporeserva.ID))
                .Add(New SqlParameter("@Fechacancelacion", paramCancelacion.Fechacancelacion))
                .Add(New SqlParameter("@MontoDevuelto", paramCancelacion.MontoDevuelto))
                .Add(New SqlParameter("@MontoRetenido", paramCancelacion.MontoRetenido))
                .Add(New SqlParameter("@MontoTotal", paramCancelacion.MontoTotal))
                .Add(New SqlParameter("@DescripcionMotivoCancelacion", paramCancelacion.DescripcionMotivoCancelacion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function


End Class
