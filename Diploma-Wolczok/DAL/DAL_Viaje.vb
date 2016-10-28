Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Viaje
    Implements Master

    Public Function consultarviajes(ByVal paramOrigen As EE.BE_Destino, ByVal paramDestino As EE.BE_Destino, ByVal paramFechaSalida As Date, ByVal paramTipoTransporte As EE.BE_TipoTransporte)
        Try
            Dim milistaViajes As New List(Of EE.BE_Viaje)
            Try
                Dim consulta As String = ("select V.*, TT.ID as ID_TipoTransporte from viaje as V, TipoTransporte as TT, Transporte as T where V.ID_Transporte = T.ID and T.ID_TipoTransporte=TT.ID and ID_Transporte=@ID_TipoTransporte and ID_Destino=@Destino and ID_Origen=@Origen and BL=@BL")
                Dim Command As SqlCommand = Acceso.MiComando(consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@Destino", paramDestino.ID))
                    .Add(New SqlParameter("@Origen", paramOrigen.ID))
                    .Add(New SqlParameter("@Fecha", paramFechaSalida))
                    .Add(New SqlParameter("@TipoTransporte", paramTipoTransporte.ID))
                    .Add(New SqlParameter("@BL", False))
                End With
                Dim dt As DataTable = Acceso.Lectura(Command)
                For Each drow As DataRow In dt.Rows
                    milistaViajes.Add(Me.formatearViaje(drow))
                Next
                Return milistaViajes
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarviajes(ByVal paramOrigen As EE.BE_Destino, ByVal paramDestino As EE.BE_Destino, ByVal paramFechaSalida As Date)
        Try
            Dim milistaViajes As New List(Of EE.BE_Viaje)
            Try
                Dim consulta As String = ("Select * from Viaje where ID_Destino=@Destino and ID_Origen=@Origen and Fecha=@Fecha and BL=@BL")
                Dim Command As SqlCommand = Acceso.MiComando(consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@Destino", paramDestino.ID))
                    .Add(New SqlParameter("@Origen", paramOrigen.ID))
                    .Add(New SqlParameter("@Fecha", paramFechaSalida))
                    .Add(New SqlParameter("@BL", False))
                End With
                Dim dt As DataTable = Acceso.Lectura(Command)
                For Each drow As DataRow In dt.Rows
                    milistaViajes.Add(Me.formatearViaje(drow))
                Next
                Return milistaViajes
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramViaje As BE_Viaje = DirectCast(paramobjeto, BE_Viaje)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Viaje values (@ID, @ID_Transporte, @Fechahorallegada, @Fechahorasalida, @Precio, @ID_Origen, @ID_Destino, @Almuerzo, @Cafeteria, @Cena, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Viaje")))
                .Add(New SqlParameter("@ID_Transporte", paramViaje.Transporte.ID))
                .Add(New SqlParameter("@Fechahorallegada", paramViaje.FechaHoraLlegada))
                .Add(New SqlParameter("@Fechahorasalida", paramViaje.FechaHoraSalida))
                .Add(New SqlParameter("@Precio", paramViaje.Precio))
                .Add(New SqlParameter("@ID_Origen", paramViaje.Origen.ID))
                .Add(New SqlParameter("@ID_Destino", paramViaje.Destino.ID))
                .Add(New SqlParameter("@Almuerzo", paramViaje.Almuerzo))
                .Add(New SqlParameter("@Cafeteria", paramViaje.Cafeteria))
                .Add(New SqlParameter("@Cena", paramViaje.cena))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramViaje As BE_Viaje = DirectCast(paramobjeto, BE_Viaje)
            Dim command As SqlCommand = Acceso.MiComando("Update Viaje set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramViaje.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramViaje As BE_Viaje = DirectCast(paramobjeto, BE_Viaje)
            Dim command As SqlCommand = Acceso.MiComando("Update Viaje set ID_Transporte=@ID_Transporte, Fechahorallegada=@Fechahorallegada, Fechahorasalida=@Fechahorasalida, Precio=@Precio, ID_Origen=@ID_Origen, ID_Destino=@ID_Destino, Almuerzo=@Almuerzo, Cafeteria=@Cafeteria, Cena=@Cena where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Viaje")))
                .Add(New SqlParameter("@ID_Transporte", paramViaje.Transporte.ID))
                .Add(New SqlParameter("@Fechahorallegada", paramViaje.FechaHoraLlegada))
                .Add(New SqlParameter("@Fechahorasalida", paramViaje.FechaHoraSalida))
                .Add(New SqlParameter("@Precio", paramViaje.Precio))
                .Add(New SqlParameter("@ID_Origen", paramViaje.Origen.ID))
                .Add(New SqlParameter("@ID_Destino", paramViaje.Destino.ID))
                .Add(New SqlParameter("@Almuerzo", paramViaje.Almuerzo))
                .Add(New SqlParameter("@Cafeteria", paramViaje.Cafeteria))
                .Add(New SqlParameter("@Cena", paramViaje.Cena))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function consultarViajes() As List(Of BE_Viaje)
        Try
            Dim consulta As String = ("Select * from Viaje where BL=@BL")
            Dim milistaViaje As New List(Of BE_Viaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaViaje.Add(Me.formatearViaje(drow))
            Next
            Return milistaViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarViaje(ByVal oViaje As EE.BE_Viaje) As EE.BE_Viaje
        Try
            Dim consulta As String = ("Select * from Viaje where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oViaje.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearViaje(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearViaje(ByVal paramDataRow As DataRow) As BE_Viaje
        Dim oViaje As New BE_Viaje
        oViaje.ID = paramDataRow.Item("ID")
        Dim oTransporte As New BE_Transporte
        oTransporte.ID = paramDataRow.Item("ID_Transporte")
        oViaje.Transporte = (New DAL_Transporte).consultarTransporte(oTransporte)

        oViaje.FechaHoraLlegada = paramDataRow.Item("Fechahorallegada")
        oViaje.FechaHoraSalida = paramDataRow.Item("Fechahorasalida")
        oViaje.Precio = paramDataRow.Item("Precio")

        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_Destino")
        oViaje.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)

        Dim oOrigen As New BE_Destino
        oOrigen.ID = paramDataRow.Item("ID_Origen")
        oViaje.Origen = (New DAL.DAL_Destino).consultarDestino(oOrigen)

        oViaje.Almuerzo = paramDataRow.Item("Almuerzo")
        oViaje.Cafeteria = paramDataRow.Item("Cafeteria")
        oViaje.Cena = paramDataRow.Item("Cena")
        Return oViaje
    End Function

End Class
