Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Hostel
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramHostel As BE_Hostel = DirectCast(paramobjeto, BE_Hostel)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Hostel values (@ID, @Categoria,@ConectividadWifi,@Descripcion,@Gimnasio,@Mascotas,@Piscina,@PrecioAlquiler,@Sauna, @ServicioAireAcond, @ServicioDesayuno, @ServicioTV,@TipoAlojamiento,@TipoCama,@TipoHabitacion,@Ubicacion,@Amoblado,@CantidadPersonas,@HabitacionPrivada, @Lockers, @Nombre, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Hostel")))
                .Add(New SqlParameter("@Categoria", paramHostel.Categoria))
                .Add(New SqlParameter("@ConectividadWifi", paramHostel.ConectividadWIFI))
                .Add(New SqlParameter("@Descripcion", paramHostel.Descripcion))
                .Add(New SqlParameter("@Gimnasio", paramHostel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHostel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHostel.Piscina))
                .Add(New SqlParameter("@PrecioAlquiler", paramHostel.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramHostel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHostel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHostel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHostel.ServicioTV))
                .Add(New SqlParameter("@TipoAlojamiento", paramHostel.TipoAlojamiento))
                .Add(New SqlParameter("@TipoCama", paramHostel.TipoCama))
                .Add(New SqlParameter("@TipoHabitacion", paramHostel.TipoHabitacion))
                .Add(New SqlParameter("@Ubicacion", paramHostel.Ubicacion))
                .Add(New SqlParameter("@Amoblado", paramHostel.Amoblado))
                .Add(New SqlParameter("@CantidadPersonas", paramHostel.CantidadPersonas))
                .Add(New SqlParameter("@HabitacionPrivada", paramHostel.HabitacionPrivada))
                .Add(New SqlParameter("@Lockers", paramHostel.Lockers))
                .Add(New SqlParameter("@Nombre", paramHostel.Nombre))
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
            Dim command As SqlCommand = Acceso.MiComando("Update Hostel set BL=@BL where ID=@ID")
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
            Dim command As SqlCommand = Acceso.MiComando("Update Hostel set Descripcion=@Descripcion,Categoria=@Categoria,ConectividadWifi=@ConectividadWifi,Descripcion=@Descripcion,Gimnasio=@Gimnasio,Mascotas=@Mascotas,Piscina=@Piscina,PrecioAlquiler=@PrecioAlquiler,Sauna=@Sauna,ServicioAireAcond=@ServicioAireAcond,ServicioDesayuno=@ServicioDesayuno,ServicioTV=@ServicioTV,TipoAlojamiento=@TipoAlojamiento,TipoCama=@TipoCama,TipoHabitacion=@TipoHabitacion,Ubicacion=@Ubicacion,Amoblado=@Amoblado,CantidadPersonas=@CantidadPersonas,HabitacionPrivada=@HabitacionPrivada,Lockers=@Lockers,Nombre=@Nombre where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHostel.ID))
                .Add(New SqlParameter("@Categoria", paramHostel.Categoria))
                .Add(New SqlParameter("@ConectividadWifi", paramHostel.ConectividadWIFI))
                .Add(New SqlParameter("@Descripcion", paramHostel.Descripcion))
                .Add(New SqlParameter("@Gimnasio", paramHostel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHostel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHostel.Piscina))
                .Add(New SqlParameter("@PrecioAlquiler", paramHostel.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramHostel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHostel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHostel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHostel.ServicioTV))
                .Add(New SqlParameter("@TipoAlojamiento", paramHostel.TipoAlojamiento))
                .Add(New SqlParameter("@TipoCama", paramHostel.TipoCama))
                .Add(New SqlParameter("@TipoHabitacion", paramHostel.TipoHabitacion))
                .Add(New SqlParameter("@Ubicacion", paramHostel.Ubicacion))
                .Add(New SqlParameter("@Amoblado", paramHostel.Amoblado))
                .Add(New SqlParameter("@CantidadPersonas", paramHostel.CantidadPersonas))
                .Add(New SqlParameter("@HabitacionPrivada", paramHostel.HabitacionPrivada))
                .Add(New SqlParameter("@Lockers", paramHostel.Lockers))
                .Add(New SqlParameter("@Nombre", paramHostel.Nombre))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarHostels() As List(Of BE_Hostel)
        Try
            Dim consulta As String = ("Select * from Hostel where BL=@BL")
            Dim milistaHostels As New List(Of BE_Hostel)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaHostels.Add(Me.formatearHostel(drow))
            Next
            Return milistaHostels
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearHostel(ByVal paramDataRow As DataRow) As BE_Hostel
        Dim oHostel As New BE_Hostel
        oHostel.ID = paramDataRow.Item("ID")
        oHostel.Categoria = paramDataRow.Item("Categoria")
        oHostel.ConectividadWIFI = paramDataRow.Item("ConectividadWIFI")
        oHostel.Descripcion = paramDataRow.Item("Descripcion")
        oHostel.Gimnasio = paramDataRow.Item("Gimnasio")
        oHostel.Mascota = paramDataRow.Item("Mascotas")
        oHostel.Piscina = paramDataRow.Item("Piscina")
        oHostel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
        oHostel.Sauna = paramDataRow.Item("Sauna")
        oHostel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
        oHostel.Desayuno = paramDataRow.Item("Desayuno")
        oHostel.ServicioTV = paramDataRow.Item("ServicioTV")
        oHostel.TipoAlojamiento = paramDataRow.Item("TipoAlojamiento")
        oHostel.TipoCama = paramDataRow.Item("TipoCama")
        oHostel.TipoHabitacion = paramDataRow.Item("TipoHabitacion")
        oHostel.Ubicacion = paramDataRow.Item("Ubicacion")
        oHostel.Amoblado = paramDataRow.Item("Amoblado")
        oHostel.CantidadPersonas = paramDataRow.Item("CantidadPersonas")
        oHostel.HabitacionPrivada = paramDataRow.Item("HabitacionPrivada")
        oHostel.Lockers = paramDataRow.Item("Lockers")
        oHostel.Nombre = paramDataRow.Item("Nombre")
        Return oHostel
    End Function
End Class
