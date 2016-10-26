Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL
Public Class DAL_Alojamiento

    Public Function consultarAlojamiento(ByVal paramDestino As EE.BE_Destino, ByVal paramFechaInicio As Date, ByVal paramFechaFin As Date)
        Try
            Dim milistaAlojamiento As New List(Of EE.BE_Alojamiento)
            Try
                Dim consulta As String = ("Select * from Alojamiento where ID_Destino=@Destino and BL=@BL")
                Dim Command As SqlCommand = Acceso.MiComando(consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@Destino", paramDestino.ID))
                    .Add(New SqlParameter("@BL", False))
                End With
                Dim dt As DataTable = Acceso.Lectura(Command)
                For Each drow As DataRow In dt.Rows
                    milistaAlojamiento.Add(Me.formatearAlojamiento(drow))
                Next
                'ACA TENGO QUE HACER EL FILTRO
                For Each miAlojamiento As BE_Alojamiento In milistaAlojamiento
                    Dim NuevaListaHabitacion As New List(Of EE.BE_Habitacion)
                    For Each paramHabitacion As EE.BE_Habitacion In miAlojamiento.ListaHabitaciones
                        Dim consulta2 As String = ("Select * from Habitacion where ID=@ID_Habitacion and BL=@BL and not exists (select * from reservaAlojamiento where (FechaInicio<@FechaInicio and FechaInicio<@FechaFin) or (FechaFin>@FechaInicio and FechaFin>@FechaFin))")
                        Dim Command2 As SqlCommand = Acceso.MiComando(consulta2)
                        With Command2.Parameters
                            .Add(New SqlParameter("@ID_Habitacion", paramHabitacion.ID))
                            .Add(New SqlParameter("@FechaInicio", paramFechaInicio))
                            .Add(New SqlParameter("@FechaFin", paramFechaFin))
                            .Add(New SqlParameter("@BL", False))
                        End With
                        Dim dt2 As DataTable = Acceso.Lectura(Command2)
                        For Each drow2 As DataRow In dt2.Rows
                            NuevaListaHabitacion.Add((New DAL.DAL_Habitacion).formatearHabitacion(drow2))
                        Next
                    Next
                    miAlojamiento.ListaHabitaciones = NuevaListaHabitacion
                Next
                'FIN FILTRO
                Return milistaAlojamiento
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarAlojamientos() As List(Of BE_Alojamiento)
        Try
            Dim milistaAlojamiento As New List(Of EE.BE_Alojamiento)
            Try
                Dim consulta As String = ("Select * from Alojamiento where BL=@BL")
                Dim Command As SqlCommand = Acceso.MiComando(consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@BL", False))
                End With
                Dim dt As DataTable = Acceso.Lectura(Command)
                For Each drow As DataRow In dt.Rows
                    milistaAlojamiento.Add(Me.formatearAlojamiento(drow))
                Next
                Return milistaAlojamiento
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function consultarAlojamiento(ByVal paramAlojamiento As EE.BE_Alojamiento) As BE_Alojamiento
        Try
            Dim consulta As String = ("Select * from Alojamiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", paramAlojamiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearAlojamiento(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearAlojamiento(ByVal paramDataRow As DataRow) As BE_Alojamiento
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento.ID = paramDataRow.Item("ID_TipoAlojamiento")
        If oTipoAlojamiento.ID = 1 Then
            Dim oHostel As New BE_Hostel
            oHostel.ID = paramDataRow.Item("ID")
            Dim oDestino As New BE_Destino
            oDestino.ID = paramDataRow.Item("ID_Destino")
            oHostel.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
            oHostel.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
            oHostel.Descripcion = paramDataRow.Item("Descripcion")
            oHostel.Piscina = paramDataRow.Item("Piscina")
            oHostel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
            oHostel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
            oHostel.Desayuno = paramDataRow.Item("ServicioDesayuno")
            oHostel.ServicioTV = paramDataRow.Item("ServicioTV")
            oHostel.Ubicacion = paramDataRow.Item("Ubicacion")
            oHostel.Nombre = paramDataRow.Item("Nombre")
            oHostel.Estrellas = paramDataRow.Item("Estrellas")
            Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
            oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oHostel)
            oHostel.ListaHabitaciones = oListaHabitaciones
            oHostel.Cocina = paramDataRow.Item("Cocina")
            oHostel.HabitacionPrivada = paramDataRow.Item("HabitacionPrivada")
            Return oHostel
        ElseIf oTipoAlojamiento.ID = 2 Then
            Dim oHotel As New BE_Hotel
            oHotel.ID = paramDataRow.Item("ID")
            Dim oDestino As New BE_Destino
            oDestino.ID = paramDataRow.Item("ID_Destino")
            oHotel.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
            oHotel.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
            oHotel.Descripcion = paramDataRow.Item("Descripcion")
            oHotel.Piscina = paramDataRow.Item("Piscina")
            oHotel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
            oHotel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
            oHotel.Desayuno = paramDataRow.Item("ServicioDesayuno")
            oHotel.ServicioTV = paramDataRow.Item("ServicioTV")
            oHotel.Ubicacion = paramDataRow.Item("Ubicacion")
            oHotel.Nombre = paramDataRow.Item("Nombre")
            oHotel.Estrellas = paramDataRow.Item("Estrellas")
            Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
            oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oHotel)
            oHotel.ListaHabitaciones = oListaHabitaciones
            oHotel.Gimnasio = paramDataRow.Item("Gimnasio")
            oHotel.Mascota = paramDataRow.Item("Mascotas")
            oHotel.Sauna = paramDataRow.Item("Sauna")
            oHotel.Cochera = paramDataRow.Item("Cochera")
            Return oHotel
        ElseIf oTipoAlojamiento.ID = 3 Then
            Dim oDepartamento As New BE_Departamento
            oDepartamento.ID = paramDataRow.Item("ID")
            Dim oDestino As New BE_Destino
            oDestino.ID = paramDataRow.Item("ID_Destino")
            oDepartamento.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
            oDepartamento.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
            oDepartamento.Descripcion = paramDataRow.Item("Descripcion")
            oDepartamento.Piscina = paramDataRow.Item("Piscina")
            oDepartamento.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
            oDepartamento.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
            oDepartamento.Desayuno = paramDataRow.Item("ServicioDesayuno")
            oDepartamento.ServicioTV = paramDataRow.Item("ServicioTV")
            oDepartamento.Ubicacion = paramDataRow.Item("Ubicacion")
            oDepartamento.Nombre = paramDataRow.Item("Nombre")
            oDepartamento.Estrellas = paramDataRow.Item("Estrellas")
            Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
            oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oDepartamento)
            oDepartamento.ListaHabitaciones = oListaHabitaciones
            oDepartamento.Mascota = paramDataRow.Item("Mascotas")
            oDepartamento.Cochera = paramDataRow.Item("Cochera")
            oDepartamento.Cocina = paramDataRow.Item("Cocina")
            oDepartamento.Amoblado = paramDataRow.Item("Amoblado")
            Return oDepartamento
        ElseIf oTipoAlojamiento.ID = 4 Then
            Dim oPosada As New BE_Posada
            oPosada.ID = paramDataRow.Item("ID")
            Dim oDestino As New BE_Destino
            oDestino.ID = paramDataRow.Item("ID_Destino")
            oPosada.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
            oPosada.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
            oPosada.Descripcion = paramDataRow.Item("Descripcion")
            oPosada.Piscina = paramDataRow.Item("Piscina")
            oPosada.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
            oPosada.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
            oPosada.Desayuno = paramDataRow.Item("ServicioDesayuno")
            oPosada.ServicioTV = paramDataRow.Item("ServicioTV")
            oPosada.Ubicacion = paramDataRow.Item("Ubicacion")
            oPosada.Nombre = paramDataRow.Item("Nombre")
            oPosada.Estrellas = paramDataRow.Item("Estrellas")
            Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
            oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oPosada)
            oPosada.ListaHabitaciones = oListaHabitaciones
            oPosada.Mascota = paramDataRow.Item("Mascotas")
            Return oPosada
        Else
            Dim oAlojamiento As New EE.BE_Alojamiento
            oAlojamiento.ID = paramDataRow.Item("ID")
            Dim oDestino As New BE_Destino
            oDestino.ID = paramDataRow.Item("ID_Destino")
            oAlojamiento.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
            oAlojamiento.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
            oAlojamiento.Descripcion = paramDataRow.Item("Descripcion")
            oAlojamiento.Piscina = paramDataRow.Item("Piscina")
            oAlojamiento.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
            oAlojamiento.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
            oAlojamiento.Desayuno = paramDataRow.Item("ServicioDesayuno")
            oAlojamiento.ServicioTV = paramDataRow.Item("ServicioTV")
            oAlojamiento.Ubicacion = paramDataRow.Item("Ubicacion")
            oAlojamiento.Nombre = paramDataRow.Item("Nombre")
            oAlojamiento.Estrellas = paramDataRow.Item("Estrellas")
            Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
            oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oAlojamiento)
            oAlojamiento.ListaHabitaciones = oListaHabitaciones
            Return oAlojamiento
        End If
    End Function

End Class
