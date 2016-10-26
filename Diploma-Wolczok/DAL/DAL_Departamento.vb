Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Departamento

    Implements Master
    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramDepartamento As BE_Departamento = DirectCast(paramobjeto, BE_Departamento)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Alojamiento values (@ID, @ID_Destino, @ID_TipoAlojamiento, @Nombre, @Descripcion, @Estrellas, @Ubicacion, @Ambientes, @PrecioAlquiler, @ConectividadWifi, @Gimnasio, @Mascotas, @Piscina, @Sauna, @ServicioAireAcond, @ServicioDesayuno, @ServicioTV, @Cochera, @Amoblado, @Cocina,@HabitacionPrivada, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Hotel")))
                .Add(New SqlParameter("@ID_Destino", paramDepartamento.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramDepartamento.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramDepartamento.Nombre))
                .Add(New SqlParameter("@Descripcion", paramDepartamento.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramDepartamento.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramDepartamento.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramDepartamento.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramDepartamento.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramDepartamento.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", paramDepartamento.Mascota))
                .Add(New SqlParameter("@Piscina", paramDepartamento.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramDepartamento.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramDepartamento.ServicioTV))
                .Add(New SqlParameter("@Cochera", paramDepartamento.Cochera))
                .Add(New SqlParameter("@Amoblado", paramDepartamento.Amoblado))
                .Add(New SqlParameter("@Cocina", paramDepartamento.Cochera))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub



    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramDepartamento As BE_Departamento = DirectCast(paramobjeto, BE_Departamento)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramDepartamento.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramDepartamento As BE_Departamento = DirectCast(paramobjeto, BE_Departamento)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set ID_Destino=@ID_Destino, ID_TipoAlojamiento=@ID_TipoAlojamiento, Nombre=@Nombre, Descripcion=@Descripcion, Estrellas=@Estrellas, Ubicacion=@Ubicacion, Ambientes=@Ambientes, PrecioAlquiler=@PrecioAlquiler, ConectividadWifi=@ConectividadWifi, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Sauna@Sauna, ServicioAireAcond=@ServicioAireAcond, ServicioDesayuno=@ServicioDesayuno, ServicioTV=@ServicioTV, Cochera=@Cochera, Amoblado=@Amoblado, Cocina=@Cocina, HabitacionPrivada=@HabitacionPrivada where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Hotel")))
                .Add(New SqlParameter("@ID_Destino", paramDepartamento.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramDepartamento.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramDepartamento.Nombre))
                .Add(New SqlParameter("@Descripcion", paramDepartamento.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramDepartamento.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramDepartamento.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramDepartamento.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramDepartamento.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramDepartamento.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", paramDepartamento.Mascota))
                .Add(New SqlParameter("@Piscina", paramDepartamento.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramDepartamento.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramDepartamento.ServicioTV))
                .Add(New SqlParameter("@Cochera", paramDepartamento.Cochera))
                .Add(New SqlParameter("@Amoblado", paramDepartamento.Amoblado))
                .Add(New SqlParameter("@Cocina", paramDepartamento.Cochera))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
        End Try

    End Function

    'Private Function formatearDepartamento(ByVal paramDataRow As DataRow) As BE_Departamento
    '    Dim oDepa As New BE_Departamento
    '    oDepa.ID = paramDataRow.Item("ID")
    '    Dim oDestino As New BE_Destino
    '    oDestino.ID = paramDataRow.Item("ID_Destino")
    '    oDepa.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
    '    oDepa.Nombre = paramDataRow.Item("Nombre")
    '    oDepa.CantidadAmbientes = paramDataRow.Item("Cantidadhambientes")
    '    oDepa.CantidadBaños = paramDataRow.Item("Cantidadbaños")
    '    oDepa.Cochera = paramDataRow.Item("Cochera")
    '    oDepa.TipoEdificio = paramDataRow.Item("Tipoedificio")
    '    oDepa.Categoria = paramDataRow.Item("Categoria")
    '    oDepa.Descripcion = paramDataRow.Item("Descripcion")
    '    oDepa.Gimnasio = paramDataRow.Item("Gimnasio")
    '    oDepa.Mascota = paramDataRow.Item("Mascotas")
    '    oDepa.Piscina = paramDataRow.Item("Piscina")
    '    oDepa.PrecioAlquiler = paramDataRow.Item("Precioalquiler")
    '    oDepa.Sauna = paramDataRow.Item("Sauna")
    '    oDepa.ServicioAireAcond = paramDataRow.Item("Servicioaireacond")
    '    oDepa.Desayuno = paramDataRow.Item("Serviciodesayuno")
    '    oDepa.ServicioTV = paramDataRow.Item("Serviciotv")
    '    oDepa.TipoAlojamiento = paramDataRow.Item("Tipoalojamiento")

    '    oDepa.Ubicacion = paramDataRow.Item("Ubicacion")
    '    Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
    '    oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oDepa)
    '    oDepa.ListaHabitaciones = oListaHabitaciones
    '    Return oDepa
    'End Function



    'Public Function consultarDepartamentos() As List(Of BE_Departamento)
    '    Try
    '        Dim consulta As String = ("Select * from Departamento where BL=@BL")
    '        Dim miListadepa As New List(Of BE_Departamento)
    '        Dim Command As SqlCommand = Acceso.MiComando(consulta)
    '        With Command.Parameters
    '            .Add(New SqlParameter("@BL", False))
    '        End With
    '        Dim dt As DataTable = Acceso.Lectura(Command)
    '        For Each drow As DataRow In dt.Rows
    '            miListadepa.Add(Me.formatearDepartamento(drow))
    '        Next
    '        Return miListadepa
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function




End Class
