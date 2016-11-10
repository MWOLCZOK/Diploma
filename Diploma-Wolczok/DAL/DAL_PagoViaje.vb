Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_PagoViaje

    Implements Master



    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim parampago As BE_PagoViaje = DirectCast(paramobjeto, BE_PagoViaje)
            Dim command As SqlCommand = Acceso.MiComando("Insert into PagoViaje values (@ID, @ID_Reserva, @Fecha, @ID_Metodopago, @Monto,@finpago, @Descripcion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "PagoViaje")))
                .Add(New SqlParameter("@ID_Reserva", parampago.ID_Reservaviaje.ID))
                .Add(New SqlParameter("@Fecha", parampago.Fecha))
                .Add(New SqlParameter("@ID_Metodopago", parampago.ID_Metodopago.ID))
                .Add(New SqlParameter("@Monto", parampago.Monto))
                .Add(New SqlParameter("@finpago", parampago.Finpago))
                .Add(New SqlParameter("@Descripcion", parampago.Descripcion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramPagoviaje As BE_PagoViaje = DirectCast(paramobjeto, BE_PagoViaje)
            Dim command As SqlCommand = Acceso.MiComando("Update PagoViaje set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramPagoviaje.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim parampago As BE_PagoViaje = DirectCast(paramobjeto, BE_PagoViaje)
            Dim command As SqlCommand = Acceso.MiComando("Update PagoViaje set ID=@ID, ID_Reserva=@ID_Reserva, Fecha=@Fecha, ID_Metodopago=@ID_Metodopago, Monto=@Monto, finpago=@finpago,Descripcion=@Descripcion where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Pago")))
                .Add(New SqlParameter("@ID_Reserva", parampago.ID_Reservaviaje.ID))
                .Add(New SqlParameter("@Fecha", parampago.Fecha))
                .Add(New SqlParameter("@ID_Metodopago", parampago.ID_Metodopago.ID))
                .Add(New SqlParameter("@Monto", parampago.Monto))
                .Add(New SqlParameter("@finpago", parampago.Finpago))
                .Add(New SqlParameter("@Descripcion", parampago.Descripcion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Function


    Private Function formatearPagoviaje(ByVal paramDataRow As DataRow) As BE_PagoViaje
        Try
            Dim oPagoviaje As New BE_PagoViaje
            oPagoviaje.ID = paramDataRow.Item("ID")
            Dim oReservaViaje As New BE_ReservaViaje
            oReservaViaje.ID = CInt(paramDataRow.Item("ID_Reserva"))
            oPagoviaje.Fecha = paramDataRow.Item("Fecha")
            Dim oMetodopago As New BE_Metodopago
            oMetodopago.ID = paramDataRow.Item("ID_Metodopago")
            oMetodopago.Descripcion = paramDataRow.Item("Descripcion")
            oPagoviaje.Monto = paramDataRow.Item("Monto")
            oPagoviaje.Finpago = paramDataRow.Item("Finpago")
            oPagoviaje.Descripcion = paramDataRow.Item("Descripcion")
            Return oPagoviaje
        Catch ex As Exception

        End Try
       
    End Function


    Public Function consultarPagosviajes(ByVal oReservaviaje As BE_ReservaViaje) As List(Of BE_PagoViaje)
        Try
            Dim consulta As String = ("Select * from PagoViaje where BL=@BL")
            Dim miListaPagosviajes As New List(Of BE_PagoViaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaPagosviajes.Add(Me.formatearPagoviaje(drow))
            Next
            Return miListaPagosviajes
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarPagoviaje(ByVal oPagoviaje As BE_PagoViaje) As BE_PagoViaje
        Try
            Dim consulta As String = ("Select * from PagoViaje where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oPagoviaje.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearPagoviaje(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
