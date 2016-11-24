Imports DAL
Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Voucher

    Implements DAL.Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramVoucher As BE_Voucher = DirectCast(paramobjeto, BE_Voucher)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Voucher values (@ID, @ID_Reserva, @TipoReserva, @FechaEmision, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Voucher")))
                .Add(New SqlParameter("@ID_Reserva", paramVoucher.Reserva.ID))
                .Add(New SqlParameter("@TipoReserva", paramVoucher.TipoReserva))
                .Add(New SqlParameter("@FechaEmision", paramVoucher.FechaEmision))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Throw New NotImplementedException()
    End Function


    Public Function consultarVoucher(ByVal paramVoucher As EE.BE_Voucher) As EE.BE_Voucher
        Try
            Dim consulta As String = ("Select * from Voucher where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", paramVoucher.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearVoucher(dt.Rows(0))
            Else
                Return Nothing
            End If

        Catch ex As Exception

        End Try
    End Function



    Public Function consultarVoucher() As List(Of EE.BE_Voucher)
        Try
            Dim consulta As String = ("Select * from Voucher where BL=@BL")
            Dim milistaVoucher As New List(Of BE_Voucher)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaVoucher.Add(Me.formatearVoucher(drow))
            Next
            Return milistaVoucher
        Catch ex As Exception

        End Try
    End Function


    Public Sub cancelarVoucher(ByVal paramReserva As BE_Reserva)
        Try
            Dim command As SqlCommand = Acceso.MiComando("Update Voucher set BL=@BL where ID_Reserva=@ID_Reserva")
            With command.Parameters
                .Add(New SqlParameter("@ID_Reserva", paramReserva.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Function formatearVoucher(ByVal paramDataRow As DataRow) As BE_Voucher
        Dim oVoucher As New BE_Voucher
        oVoucher.ID = paramDataRow.Item("ID")
        Dim oReserva As New BE_Reserva
        oReserva.ID = CInt(paramDataRow.Item("ID_Reserva"))
        oVoucher.Reserva = (New DAL.DAL_ReservaAlojamiento).ConsultarReservaAlojamientoID(oReserva)
        oVoucher.TipoReserva = paramDataRow.Item("TipoReserva")
        oVoucher.FechaEmision = paramDataRow.Item("FechaEmision")
        Return oVoucher
    End Function

End Class
