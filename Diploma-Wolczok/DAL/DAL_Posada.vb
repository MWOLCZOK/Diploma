Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Posada

    Implements Master



    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Posada values (@ID, @Nombre, @Distanciaciudad, @Hectareasverdes,@Categoria, @Conectividadwifi, @Descripcion, @Gimnasio, @Mascotas, @Piscina, @Precioalquiler, @Sauna, @Servicioaireacond, @Serviciodesayuno, @Serviciotv, @Tipoalojamiento, @Tipocama, @Tipohabitacion, @Ubicacion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Posada")))
                .Add(New SqlParameter("@Nombre", paramPosada.Nombre))
                .Add(New SqlParameter("@Cantidadhambientes", paramPosada.DistanciaCiudad))
                .Add(New SqlParameter("@Cantidadbaños", paramPosada.HectareasVerdes))
                .Add(New SqlParameter("@Categoria", paramPosada.Categoria))
                .Add(New SqlParameter("@Conectividadwifi", paramPosada.ConectividadWIFI))
                .Add(New SqlParameter("@Gimnasio", paramPosada.Gimnasio))
                .Add(New SqlParameter("@Descripcion", paramPosada.Desayuno))
                .Add(New SqlParameter("@Mascotas", paramPosada.Mascota))
                .Add(New SqlParameter("@Piscina", paramPosada.Piscina))
                .Add(New SqlParameter("@Precioalquiler", paramPosada.PrecioAlquiler))
                .Add(New SqlParameter("@Sauna", paramPosada.Sauna))
                .Add(New SqlParameter("@Servicioaireacond", paramPosada.ServicioAireAcond))
                .Add(New SqlParameter("@Serviciodesayuno", paramPosada.Desayuno))
                .Add(New SqlParameter("@Serviciotv", paramPosada.ServicioTV))
                .Add(New SqlParameter("@Tipoalojamiento", paramPosada.TipoAlojamiento))
                .Add(New SqlParameter("@Tipocama", paramPosada.TipoCama))
                .Add(New SqlParameter("@Tipohabitacion", paramPosada.TipoHabitacion))
                .Add(New SqlParameter("@Ubicacion", paramPosada.Ubicacion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
            Dim command As SqlCommand = Acceso.MiComando("Update Posada set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramPosada.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        '    Try
        '        Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
        '        Dim command As SqlCommand = Acceso.MiComando("Update Posada set Nombre=@Nombre, Distanciaciudad=@Distanciaciudad, Hectareasverdes=@Hectareasverdes,Categoria=@Categoria, Conectividadwifi=@Conectividadwifi, Descripcion=@Descripcion, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Precioalquiler=@Precioalquiler, Sauna=@Sauna, Servicioaireacond=@Servicioaireacond, Serviciodesayuno=@Serviciodesayuno, Serviciotv=@Serviciotv, Tipoalojamiento=@Tipoalojamiento, Tipocama=@Tipocama, Tipohabitacion=@Tipohabitacion, Ubicacion=@Ubicacion where ID=@ID")
        '        With command.Parameters
        '            .Add(New SqlParameter("@ID", paramDepartamento.ID))
        '            .Add(New SqlParameter("@Nombre", paramDepartamento.Nombre))
        '            .Add(New SqlParameter("@Cantidadhambientes", paramDepartamento.CantidadAmbientes))
        '            .Add(New SqlParameter("@Cantidadbaños", paramDepartamento.CantidadBaños))
        '            .Add(New SqlParameter("@Cochera", paramDepartamento.Cochera))
        '            .Add(New SqlParameter("@Tipoedificio", paramDepartamento.TipoEdificio))
        '            .Add(New SqlParameter("@Categoria", paramDepartamento.Categoria))
        '            .Add(New SqlParameter("@Conectividadwifi", paramDepartamento.ConectividadWIFI))
        '            .Add(New SqlParameter("@Gimnasio", paramDepartamento.Gimnasio))
        '            .Add(New SqlParameter("@Descripcion", paramDepartamento.Desayuno))
        '            .Add(New SqlParameter("@Mascotas", paramDepartamento.Mascota))
        '            .Add(New SqlParameter("@Piscina", paramDepartamento.Piscina))
        '            .Add(New SqlParameter("@Precioalquiler", paramDepartamento.PrecioAlquiler))
        '            .Add(New SqlParameter("@Sauna", paramDepartamento.Sauna))
        '            .Add(New SqlParameter("@Servicioaireacond", paramDepartamento.ServicioAireAcond))
        '            .Add(New SqlParameter("@Serviciodesayuno", paramDepartamento.Desayuno))
        '            .Add(New SqlParameter("@Serviciotv", paramDepartamento.ServicioTV))
        '            .Add(New SqlParameter("@Tipoalojamiento", paramDepartamento.TipoAlojamiento))
        '            .Add(New SqlParameter("@Tipocama", paramDepartamento.TipoCama))
        '            .Add(New SqlParameter("@Tipohabitacion", paramDepartamento.TipoCama))
        '            .Add(New SqlParameter("@Ubicacion", paramDepartamento.TipoCama))
        '        End With
        '        Acceso.Escritura(command)
        '        command.Dispose()
        '        Return True
        '    Catch ex As Exception
        '    End Try
    End Function
End Class
