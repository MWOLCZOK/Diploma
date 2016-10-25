Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Hotel

    Implements Master



    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Hotel values (@ID, @ID_Destino, @Categoria,@ConectividadWifi,@Descripcion,@Gimnasio,@Mascotas,@Piscina,@PrecioAlquiler,@Sauna, @ServicioAireAcond, @ServicioDesayuno, @ServicioTV,@TipoAlojamiento,@TipoCama,@TipoHabitacion,@Ubicacion,@ActividadesFamiliares,@CantidadEstrellas,@Nombre, @TipoHotel, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Hostel")))
                .Add(New SqlParameter("@ID_Destino", paramHotel.Destino.ID))
                .Add(New SqlParameter("@Categoria", paramHotel.Categoria))
                .Add(New SqlParameter("@ConectividadWifi", paramHotel.ConectividadWIFI))
                .Add(New SqlParameter("@Descripcion", paramHotel.Descripcion))
                .Add(New SqlParameter("@Gimnasio", paramHotel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHotel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHotel.Piscina))
                .Add(New SqlParameter("@PrecioAlquiler", paramHotel.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramHotel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHotel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHotel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHotel.ServicioTV))
                .Add(New SqlParameter("@TipoAlojamiento", paramHotel.TipoAlojamiento))
                .Add(New SqlParameter("@TipoCama", paramHotel.TipoCama))
                .Add(New SqlParameter("@TipoHabitacion", paramHotel.TipoHabitacion))
                .Add(New SqlParameter("@Ubicacion", paramHotel.Ubicacion))
                .Add(New SqlParameter("@ActividadesFamiliares", paramHotel.ActividadesFamiliares))
                .Add(New SqlParameter("@CantidadEstrellas", paramHotel.CantidadEstrellas))
                .Add(New SqlParameter("@Nombre", paramHotel.Nombre))
                .Add(New SqlParameter("@TipoHotel", paramHotel.TipoHotel))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Update Hotel set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHotel.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Update Hotel set ID_Destino=@ID_Destino,Descripcion=@Descripcion,Categoria=@Categoria,ConectividadWifi=@ConectividadWifi,Descripcion=@Descripcion,Gimnasio=@Gimnasio,Mascotas=@Mascotas,Piscina=@Piscina,PrecioAlquiler=@PrecioAlquiler,Sauna=@Sauna,ServicioAireAcond=@ServicioAireAcond,ServicioDesayuno=@ServicioDesayuno,ServicioTV=@ServicioTV,TipoAlojamiento=@TipoAlojamiento,TipoCama=@TipoCama,TipoHabitacion=@TipoHabitacion,Ubicacion=@Ubicacion,ActividadesFamiliares=@ActividadesFamiliares,CantidadEstrellas=@CantidadEstrellas,Nombre=@Nombre,TipoHotel=@TipoHotel where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHotel.ID))
                .Add(New SqlParameter("@ID_Destino", paramHotel.Destino.ID))
                .Add(New SqlParameter("@Categoria", paramHotel.Categoria))
                .Add(New SqlParameter("@ConectividadWifi", paramHotel.ConectividadWIFI))
                .Add(New SqlParameter("@Descripcion", paramHotel.Descripcion))
                .Add(New SqlParameter("@Gimnasio", paramHotel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHotel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHotel.Piscina))
                .Add(New SqlParameter("@PrecioAlquiler", paramHotel.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramHotel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHotel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHotel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHotel.ServicioTV))
                .Add(New SqlParameter("@TipoAlojamiento", paramHotel.TipoAlojamiento))
                .Add(New SqlParameter("@TipoCama", paramHotel.TipoCama))
                .Add(New SqlParameter("@TipoHabitacion", paramHotel.TipoHabitacion))
                .Add(New SqlParameter("@Ubicacion", paramHotel.Ubicacion))
                .Add(New SqlParameter("@ActividadesFamiliares", paramHotel.ActividadesFamiliares))
                .Add(New SqlParameter("@CantidadEstrellas", paramHotel.CantidadEstrellas))
                .Add(New SqlParameter("@Nombre", paramHotel.Nombre))
                .Add(New SqlParameter("@TipoHotel", paramHotel.TipoHotel))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarHosteles() As List(Of BE_Hotel)
        Try
            Dim consulta As String = ("Select * from Hotel where BL=@BL")
            Dim milistaHoteles As New List(Of BE_Hotel)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaHoteles.Add(Me.formatearHotel(drow))
            Next
            Return milistaHoteles
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearHotel(ByVal paramDataRow As DataRow) As BE_Hotel
        Dim oHotel As New BE_Hotel
        oHotel.ID = paramDataRow.Item("ID")
        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_Destino")
        oHotel.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
        oHotel.Categoria = paramDataRow.Item("Categoria")
        oHotel.ConectividadWIFI = paramDataRow.Item("ConectividadWIFI")
        oHotel.Descripcion = paramDataRow.Item("Descripcion")
        oHotel.Gimnasio = paramDataRow.Item("Gimnasio")
        oHotel.Mascota = paramDataRow.Item("Mascotas")
        oHotel.Piscina = paramDataRow.Item("Piscina")
        oHotel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
        oHotel.Sauna = paramDataRow.Item("Sauna")
        oHotel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
        oHotel.Desayuno = paramDataRow.Item("Desayuno")
        oHotel.ServicioTV = paramDataRow.Item("ServicioTV")
        oHotel.TipoAlojamiento = paramDataRow.Item("TipoAlojamiento")
        oHotel.TipoCama = paramDataRow.Item("TipoCama")
        oHotel.TipoHabitacion = paramDataRow.Item("TipoHabitacion")
        oHotel.Ubicacion = paramDataRow.Item("Ubicacion")
        oHotel.ActividadesFamiliares = paramDataRow.Item("ActividadesFamiliares")
        oHotel.CantidadEstrellas = paramDataRow.Item("CantidadEstrellas")
        oHotel.Nombre = paramDataRow.Item("Nombre")
        oHotel.TipoHotel = paramDataRow.Item("TipoHotel")
        Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
        oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oHotel)
        oHotel.ListaHabitaciones = oListaHabitaciones
        Return oHotel
    End Function
End Class
