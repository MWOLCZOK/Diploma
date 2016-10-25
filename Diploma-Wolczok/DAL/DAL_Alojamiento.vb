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

        End Try
    End Function


    Private Function formatearAlojamiento(ByVal paramDataRow As DataRow) As BE_Hotel
        Dim oAlojamiento As New BE_Hotel
        oAlojamiento.ID = paramDataRow.Item("ID")
        Dim oDestino As New BE_Destino
        oDestino.ID = paramDataRow.Item("ID_Destino")
        oAlojamiento.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
        'falta el tipo de Alojamiento

        'fin
        oAlojamiento.Categoria = paramDataRow.Item("Categoria")
        oAlojamiento.ConectividadWIFI = paramDataRow.Item("ConectividadWIFI")
        oAlojamiento.Descripcion = paramDataRow.Item("Descripcion")
        oAlojamiento.Gimnasio = paramDataRow.Item("Gimnasio")
        oAlojamiento.Mascota = paramDataRow.Item("Mascotas")
        oAlojamiento.Piscina = paramDataRow.Item("Piscina")
        oAlojamiento.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
        oAlojamiento.Sauna = paramDataRow.Item("Sauna")
        oAlojamiento.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
        oAlojamiento.Desayuno = paramDataRow.Item("ServicioDesayuno")
        oAlojamiento.ServicioTV = paramDataRow.Item("ServicioTV")
        oAlojamiento.TipoAlojamiento = paramDataRow.Item("TipoAlojamiento")
        oAlojamiento.TipoCama = paramDataRow.Item("TipoCama")
        oAlojamiento.TipoHabitacion = paramDataRow.Item("TipoHabitacion")
        oAlojamiento.Ubicacion = paramDataRow.Item("Ubicacion")
        oAlojamiento.ActividadesFamiliares = paramDataRow.Item("ActividadesFamiliares")
        oAlojamiento.CantidadEstrellas = paramDataRow.Item("CantidadEstrellas")
        oAlojamiento.Nombre = paramDataRow.Item("Nombre")
        oAlojamiento.TipoHotel = paramDataRow.Item("TipoHotel")
        Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
        oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oAlojamiento)
        oAlojamiento.ListaHabitaciones = oListaHabitaciones
        Return oAlojamiento
    End Function

End Class
