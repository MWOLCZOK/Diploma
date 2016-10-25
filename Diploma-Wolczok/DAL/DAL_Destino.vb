Imports DAL
Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Destino
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramDestino As BE_Destino = DirectCast(paramobjeto, BE_Destino)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Destino values (@ID, @ID_Localidad, @Aeropuerto,  @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID_destino", "Destino")))
                .Add(New SqlParameter("@ID_Localidad", paramDestino.Localidad.ID))
                .Add(New SqlParameter("@Aeropuerto", paramDestino.TieneAeropuerto))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramDestino As BE_Destino = DirectCast(paramobjeto, BE_Destino)
            Dim command As SqlCommand = Acceso.MiComando("Update Destino set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramDestino.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramDestino As BE_Destino = DirectCast(paramobjeto, BE_Destino)
            Dim command As SqlCommand = Acceso.MiComando("Update Hostel set ID_Localidad=@ID_Localidad,TieneAeropuerto=@Aeropuerto where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID_destino", "Destino")))
                .Add(New SqlParameter("@ID_Localidad", paramDestino.Localidad.ID))
                .Add(New SqlParameter("@Aeropuerto", paramDestino.TieneAeropuerto))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarDestinos() As List(Of BE_Destino)
        Try
            Dim consulta As String = ("Select * from Destino where BL=@BL")
            Dim milistaDestino As New List(Of BE_Destino)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaDestino.Add(Me.formatearDestino(drow))
            Next
            Return milistaDestino
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarDestino(ByVal oDestino As EE.BE_Destino) As EE.BE_Destino
        Try
            Dim consulta As String = ("Select * from Destino where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oDestino.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearDestino(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearDestino(ByVal paramDataRow As DataRow) As BE_Destino
        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_destino")
        oDestino.TieneAeropuerto = paramDataRow.Item("Aeropuerto")
        Dim oLocalidad As New BE_Localidad
        oLocalidad.ID = CInt(paramDataRow.Item("ID_Localidad"))
        oDestino.Localidad = (New DAL.DAL_Localidad).consultarLocalidad(oLocalidad)
        Return oDestino
    End Function

End Class
