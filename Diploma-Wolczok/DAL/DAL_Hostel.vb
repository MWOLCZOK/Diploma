Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Hostel
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramHostel As BE_Hostel = DirectCast(paramobjeto, BE_Hostel)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Alojamiento values (@ID, @ID_Destino, @ID_TipoAlojamiento, @Nombre, @Descripcion, @Estrellas, @Ubicacion, @Ambientes, @PrecioAlquiler, @ConectividadWifi, @Gimnasio, @Mascotas, @Piscina, @Sauna, @ServicioAireAcond, @ServicioDesayuno, @ServicioTV, @Cochera, @Amoblado, @Cocina,@HabitacionPrivada, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Alojamiento")))
                .Add(New SqlParameter("@ID_Destino", paramHostel.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramHostel.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramHostel.Nombre))
                .Add(New SqlParameter("@Descripcion", paramHostel.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramHostel.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramHostel.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramHostel.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramHostel.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramHostel.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", DBNull.Value))
                .Add(New SqlParameter("@Piscina", paramHostel.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramHostel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHostel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHostel.ServicioTV))
                .Add(New SqlParameter("@Cochera", DBNull.Value))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", DBNull.Value))
                .Add(New SqlParameter("@HabitacionPrivada", paramHostel.HabitacionPrivada))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramHostel As BE_Hostel = DirectCast(paramobjeto, BE_Hostel)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHostel.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramHostel As BE_Hostel = DirectCast(paramobjeto, BE_Hostel)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set ID_Destino=@ID_Destino, ID_TipoAlojamiento=@ID_TipoAlojamiento, Nombre=@Nombre, Descripcion=@Descripcion, Estrellas=@Estrellas, Ubicacion=@Ubicacion, Ambientes=@Ambientes, PrecioAlquiler=@PrecioAlquiler, ConectividadWifi=@ConectividadWifi, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Sauna@Sauna, ServicioAireAcond=@ServicioAireAcond, ServicioDesayuno=@ServicioDesayuno, ServicioTV=@ServicioTV, Cochera=@Cochera, Amoblado=@Amoblado, Cocina=@Cocina, HabitacionPrivada=@HabitacionPrivada where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Alojamiento")))
                .Add(New SqlParameter("@ID_Destino", paramHostel.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramHostel.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramHostel.Nombre))
                .Add(New SqlParameter("@Descripcion", paramHostel.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramHostel.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramHostel.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramHostel.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramHostel.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramHostel.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", DBNull.Value))
                .Add(New SqlParameter("@Piscina", paramHostel.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramHostel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHostel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHostel.ServicioTV))
                .Add(New SqlParameter("@Cochera", DBNull.Value))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", DBNull.Value))
                .Add(New SqlParameter("@HabitacionPrivada", paramHostel.HabitacionPrivada))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function consultarHostels() As List(Of BE_Hostel)
    '    Try
    '        Dim consulta As String = ("Select * from Hostel where BL=@BL")
    '        Dim milistaHostels As New List(Of BE_Hostel)
    '        Dim Command As SqlCommand = Acceso.MiComando(consulta)
    '        With Command.Parameters
    '            .Add(New SqlParameter("@BL", False))
    '        End With
    '        Dim dt As DataTable = Acceso.Lectura(Command)
    '        For Each drow As DataRow In dt.Rows
    '            milistaHostels.Add(Me.formatearHostel(drow))
    '        Next
    '        Return milistaHostels
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function formatearHostel(ByVal paramDataRow As DataRow) As BE_Hostel
    '    Dim oHostel As New BE_Hostel
    '    oHostel.ID = paramDataRow.Item("ID")
    '    Dim oDestino As New BE_Destino
    '    oDestino.ID = paramDataRow.Item("ID_Destino")
    '    oHostel.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
    '    Dim oTipoAlojamiento As New BE_TipoAlojamiento
    '    oTipoAlojamiento.ID = paramDataRow.Item("ID_TipoAlojamiento")
    '    oHostel.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
    '    oHostel.Nombre = paramDataRow.Item("Nombre")
    '    oHostel.Descripcion = paramDataRow.Item("Descripcion")
    '    oHostel.Estrellas = paramDataRow.Item("Estrellas")
    '    oHostel.Ubicacion = paramDataRow.Item("Ubicacion")
    '    oHostel.Ambientes = paramDataRow.Item("Ambientes")
    '    oHostel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
    '    oHostel.ConectividadWifi = paramDataRow.Item("ConectividadWifi")
    '    oHostel.Gimnasio = paramDataRow.Item("Gimnasio")
    '    oHostel.Mascota = paramDataRow.Item("Mascotas")
    '    oHostel.Piscina = paramDataRow.Item("Piscina")
    '    oHostel.Sauna = paramDataRow.Item("Sauna")
    '    oHostel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
    '    oHostel.Desayuno = paramDataRow.Item("Desayuno")
    '    oHostel.ServicioTV = paramDataRow.Item("ServicioTV")
    '    oHostel.Cochera = paramDataRow.Item("Cochera")
    '    Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
    '    oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oHotel)
    '    oHostel.ListaHabitaciones = oListaHabitaciones
    '    Return oHostel
    'End Function

End Class
