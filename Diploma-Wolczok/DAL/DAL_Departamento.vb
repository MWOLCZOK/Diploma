Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Departamento

    Implements Master
    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramDepartamento As BE_Departamento = DirectCast(paramobjeto, BE_Departamento)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Departamento values (@ID, @ID_Destino, @Nombre, @Cantidadhambientes, @Cantidadbaños, @Cochera, @Tipoedificio,@Categoria, @Conectividadwifi, @Descripcion, @Gimnasio, @Mascotas, @Piscina, @Precioalquiler, @Sauna, @Servicioaireacond, @Serviciodesayuno, @Serviciotv, @Tipoalojamiento, @Tipocama, @Tipohabitacion, @Ubicacion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Departamento")))
                .Add(New SqlParameter("@ID_Destino", paramDepartamento.Destino.ID))
                .Add(New SqlParameter("@Nombre", paramDepartamento.Nombre))
                .Add(New SqlParameter("@Cantidadhambientes", paramDepartamento.CantidadAmbientes))
                .Add(New SqlParameter("@Cantidadbaños", paramDepartamento.CantidadBaños))
                .Add(New SqlParameter("@Cochera", paramDepartamento.Cochera))
                .Add(New SqlParameter("@Tipoedificio", paramDepartamento.TipoEdificio))
                .Add(New SqlParameter("@Categoria", paramDepartamento.Categoria))
                .Add(New SqlParameter("@Conectividadwifi", paramDepartamento.ConectividadWIFI))
                .Add(New SqlParameter("@Gimnasio", paramDepartamento.Gimnasio))
                .Add(New SqlParameter("@Descripcion", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@Mascotas", paramDepartamento.Mascota))
                .Add(New SqlParameter("@Piscina", paramDepartamento.Piscina))
                .Add(New SqlParameter("@Precioalquiler", paramDepartamento.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramDepartamento.Sauna))
                .Add(New SqlParameter("@Servicioaireacond", paramDepartamento.ServicioAireAcond))
                .Add(New SqlParameter("@Serviciodesayuno", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@Serviciotv", paramDepartamento.ServicioTV))
                .Add(New SqlParameter("@Tipoalojamiento", paramDepartamento.TipoAlojamiento))
                .Add(New SqlParameter("@Tipocama", paramDepartamento.TipoCama))
                .Add(New SqlParameter("@Tipohabitacion", paramDepartamento.TipoCama))
                .Add(New SqlParameter("@Ubicacion", paramDepartamento.TipoCama))
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
            Dim command As SqlCommand = Acceso.MiComando("Update Departamento set BL=@BL where ID=@ID")
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
            Dim command As SqlCommand = Acceso.MiComando("Update Departamento set ID_Destino=@ID_Destino,Nombre=@Nombre, Cantidadhambientes=@Cantidadhambientes, Cantidadbaños=@Cantidadbaños, Cochera=@Cochera, Tipoedificio=@Tipoedificio, Categoria=@Categoria, Conectividadwifi=@Conectividadwifi, Descripcion=@Descripcion, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Precioalquiler=@Precioalquiler, Sauna=@Sauna, Servicioaireacond=@Servicioaireacond, Serviciodesayuno=@Serviciodesayuno, Serviciotv=@Serviciotv, Tipoalojamiento=@Tipoalojamiento, Tipocama=@Tipocama, Tipohabitacion=@Tipohabitacion, Ubicacion=@Ubicacion where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramDepartamento.ID))
                .Add(New SqlParameter("@ID_Destino", paramDepartamento.Destino.ID))
                .Add(New SqlParameter("@Nombre", paramDepartamento.Nombre))
                .Add(New SqlParameter("@Cantidadhambientes", paramDepartamento.CantidadAmbientes))
                .Add(New SqlParameter("@Cantidadbaños", paramDepartamento.CantidadBaños))
                .Add(New SqlParameter("@Cochera", paramDepartamento.Cochera))
                .Add(New SqlParameter("@Tipoedificio", paramDepartamento.TipoEdificio))
                .Add(New SqlParameter("@Categoria", paramDepartamento.Categoria))
                .Add(New SqlParameter("@Conectividadwifi", paramDepartamento.ConectividadWIFI))
                .Add(New SqlParameter("@Gimnasio", paramDepartamento.Gimnasio))
                .Add(New SqlParameter("@Descripcion", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@Mascotas", paramDepartamento.Mascota))
                .Add(New SqlParameter("@Piscina", paramDepartamento.Piscina))
                .Add(New SqlParameter("@Precioalquiler", paramDepartamento.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramDepartamento.Sauna))
                .Add(New SqlParameter("@Servicioaireacond", paramDepartamento.ServicioAireAcond))
                .Add(New SqlParameter("@Serviciodesayuno", paramDepartamento.Desayuno))
                .Add(New SqlParameter("@Serviciotv", paramDepartamento.ServicioTV))
                .Add(New SqlParameter("@Tipoalojamiento", paramDepartamento.TipoAlojamiento))
                .Add(New SqlParameter("@Tipocama", paramDepartamento.TipoCama))
                .Add(New SqlParameter("@Tipohabitacion", paramDepartamento.TipoCama))
                .Add(New SqlParameter("@Ubicacion", paramDepartamento.TipoCama))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
        End Try

    End Function

    Private Function formatearDepartamento(ByVal paramDataRow As DataRow) As BE_Departamento
        Dim oDepa As New BE_Departamento
        oDepa.ID = paramDataRow.Item("ID")
        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_Destino")
        oDepa.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
        oDepa.Nombre = paramDataRow.Item("Nombre")
        oDepa.CantidadAmbientes = paramDataRow.Item("Cantidadhambientes")
        oDepa.CantidadBaños = paramDataRow.Item("Cantidadbaños")
        oDepa.Cochera = paramDataRow.Item("Cochera")
        oDepa.TipoEdificio = paramDataRow.Item("Tipoedificio")
        oDepa.Categoria = paramDataRow.Item("Categoria")
        oDepa.ConectividadWIFI = paramDataRow.Item("Conectividadwifi")
        oDepa.Descripcion = paramDataRow.Item("Descripcion")
        oDepa.Gimnasio = paramDataRow.Item("Gimnasio")
        oDepa.Mascota = paramDataRow.Item("Mascotas")
        oDepa.Piscina = paramDataRow.Item("Piscina")
        oDepa.PrecioAlquiler = paramDataRow.Item("Precioalquiler")
        oDepa.Sauna = paramDataRow.Item("Sauna")
        oDepa.ServicioAireAcond = paramDataRow.Item("Servicioaireacond")
        oDepa.Desayuno = paramDataRow.Item("Serviciodesayuno")
        oDepa.ServicioTV = paramDataRow.Item("Serviciotv")
        oDepa.TipoAlojamiento = paramDataRow.Item("Tipoalojamiento")
        oDepa.TipoCama = paramDataRow.Item("Tipocama")
        oDepa.TipoHabitacion = paramDataRow.Item("Tipohabitacion")
        oDepa.Ubicacion = paramDataRow.Item("Ubicacion")
        Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
        oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oDepa)
        oDepa.ListaHabitaciones = oListaHabitaciones
        Return oDepa
    End Function



    Public Function consultarDepartamentos() As List(Of BE_Departamento)
        Try
            Dim consulta As String = ("Select * from Departamento where BL=@BL")
            Dim miListadepa As New List(Of BE_Departamento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListadepa.Add(Me.formatearDepartamento(drow))
            Next
            Return miListadepa
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
