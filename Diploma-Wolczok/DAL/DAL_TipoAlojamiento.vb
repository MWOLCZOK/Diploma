Imports System.Text
Imports System.Data.SqlClient
Imports EE


Public Class DAL_TipoAlojamiento
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramTipoAlojamiento As BE_TipoAlojamiento = DirectCast(paramobjeto, BE_TipoAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Insert into TipoAlojamiento values (@ID, @Descripcion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "TipoAlojamiento")))
                .Add(New SqlParameter("@Descripcion", paramTipoAlojamiento.Descripcion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramTipoAlojamiento As BE_TipoAlojamiento = DirectCast(paramobjeto, BE_TipoAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Update TipoAlojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramTipoAlojamiento.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramTipoAlojamiento As BE_TipoAlojamiento = DirectCast(paramobjeto, BE_TipoAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Update TipoAlojamiento set Descripcion=@Descripcion where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Destino")))
                .Add(New SqlParameter("@Descripcion", paramTipoAlojamiento.Descripcion))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function consultarTipoAlojamientos() As List(Of BE_TipoAlojamiento)
        Try
            Dim consulta As String = ("Select * from TipoAlojamiento where BL=@BL")
            Dim miListaTipoAlojamiento As New List(Of BE_TipoAlojamiento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaTipoAlojamiento.Add(Me.formatearTipoAlojamiento(drow))
            Next
            Return miListaTipoAlojamiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarTipoAlojamiento(ByVal paramAlojamiento As EE.BE_TipoAlojamiento) As EE.BE_TipoAlojamiento
        Try
            Dim consulta As String = ("Select * from TipoAlojamiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", paramAlojamiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearTipoAlojamiento(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearTipoAlojamiento(ByVal paramDataRow As DataRow) As BE_TipoAlojamiento
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento.ID = paramDataRow.Item("ID")
        oTipoAlojamiento.Descripcion = paramDataRow.Item("Descripcion")
        Return oTipoAlojamiento
    End Function

End Class
