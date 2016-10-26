Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL
Public Class DAL_Alojamiento

    Public Function consultarAlojamiento(ByVal paramDestino As EE.BE_Destino, ByVal paramFechaInicio As Date, ByVal paramFechaFin As Date)
        Try
            Dim milistaAlojamiento As New List(Of EE.BE_Alojamiento)
            Try
                Dim consulta As String = ("Select * from Alojamiento where ID_Destino=@Destino")
                Dim Command As SqlCommand = Acceso.MiComando(consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@Destino", paramDestino.ID))
                End With
                Dim dt As DataTable = Acceso.Lectura(Command)
                For Each drow As DataRow In dt.Rows
                    milistaAlojamiento.Add(Me.formatearAlojamiento(drow))
                Next
                'ACA TENGO QUE HACER EL FILTRO
                For Each miAlojamiento As BE_Alojamiento In milistaAlojamiento
                    Dim NuevaListaHabitacion As New List(Of EE.BE_Habitacion)
                    For Each paramHabitacion As EE.BE_Habitacion In miAlojamiento.ListaHabitaciones
                        Dim consulta2 As String = ("Select * from Habitacion where ID=@ID_Habitacion and not exists (select * from reservaAlojamiento where (FechaInicio<@FechaInicio and FechaInicio<@FechaFin) or (FechaFin>@FechaInicio and FechaFin>@FechaFin))")
                        Dim Command2 As SqlCommand = Acceso.MiComando(consulta2)
                        With Command2.Parameters
                            .Add(New SqlParameter("@ID_Habitacion", paramHabitacion.ID))
                            .Add(New SqlParameter("@FechaInicio", paramFechaInicio))
                            .Add(New SqlParameter("@FechaFin", paramFechaFin))
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

    Private Function formatearAlojamiento(ByVal paramDataRow As DataRow) As BE_Alojamiento
        Dim oAlojamiento As New BE_Alojamiento
        oAlojamiento.ID = paramDataRow.Item("ID")
        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_Destino")
        oAlojamiento.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento.ID = paramDataRow.Item("ID_TipoAlojamiento")
        oAlojamiento.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
        oAlojamiento.Descripcion = paramDataRow.Item("Descripcion")
        oAlojamiento.Piscina = paramDataRow.Item("Piscina")
        oAlojamiento.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
        oAlojamiento.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
        oAlojamiento.Desayuno = paramDataRow.Item("ServicioDesayuno")
        oAlojamiento.ServicioTV = paramDataRow.Item("ServicioTV")
        oAlojamiento.TipoAlojamiento = paramDataRow.Item("TipoAlojamiento")
        oAlojamiento.Ubicacion = paramDataRow.Item("Ubicacion")
        oAlojamiento.Nombre = paramDataRow.Item("Nombre")
        Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
        oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oAlojamiento)
        oAlojamiento.ListaHabitaciones = oListaHabitaciones
        If oAlojamiento.TipoAlojamiento.ID = 1 Then
            Dim oHostel As New BE_Hostel
            oHostel = DirectCast(oAlojamiento, BE_Hostel)
            oHostel.Cocina = paramDataRow.Item("Cocina")
            oHostel.HabitacionPrivada = paramDataRow.Item("HabitacionPrivada")
            Return oHostel
        ElseIf oAlojamiento.TipoAlojamiento.ID = 2 Then
            Dim oHotel As New BE_Hotel
            oHotel = DirectCast(oAlojamiento, BE_Hotel)
            oHotel.Gimnasio = paramDataRow.Item("Gimnasio")
            oHotel.Mascota = paramDataRow.Item("Mascotas")
            oHotel.Sauna = paramDataRow.Item("Sauna")
            oHotel.Cochera = paramDataRow.Item("Cochera")
            Return oHotel
        ElseIf oAlojamiento.TipoAlojamiento.ID = 3 Then
            Dim oDepartamento As New BE_Departamento
            oDepartamento = DirectCast(oAlojamiento, BE_Departamento)
            oDepartamento.Mascota = paramDataRow.Item("Mascotas")
            oDepartamento.Cochera = paramDataRow.Item("Cochera")
            oDepartamento.Cocina = paramDataRow.Item("Cocina")
            oDepartamento.Amoblado = paramDataRow.Item("Amoblado")
            Return oDepartamento
        ElseIf oAlojamiento.TipoAlojamiento.ID = 4 Then
            Dim oPosada As New BE_Posada
            oPosada = DirectCast(oAlojamiento, BE_Posada)
            oPosada.Mascota = paramDataRow.Item("Mascotas")
            Return oPosada
        End If
        Return oAlojamiento
    End Function

End Class
