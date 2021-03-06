﻿Imports EE
Imports System.Data.SqlClient
Imports System.Configuration


Public Class DAL_Pasajero

    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim parampasajero As BE_Pasajero = DirectCast(paramobjeto, BE_Pasajero)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Pasajero values (@ID, @Nombre, @Apellido, @Correoelectronico, @Dni, @Domicilio, @Telefono, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Pasajero")))
                .Add(New SqlParameter("@Nombre", parampasajero.Nombre))
                .Add(New SqlParameter("@Apellido", parampasajero.Apellido))
                .Add(New SqlParameter("@Correoelectronico", parampasajero.CorreoElectronico))
                .Add(New SqlParameter("@DNI", parampasajero.DNI))
                .Add(New SqlParameter("@Domicilio", parampasajero.Domicilio))
                '.Add(New SqlParameter("@Puntajealojamiento", parampasajero.PuntajeAlojamiento))
                '.Add(New SqlParameter("@Puntajeviaje", parampasajero.PuntajeViaje))
                .Add(New SqlParameter("@Telefono", parampasajero.Telefono))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try


    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim parampasajero As BE_Pasajero = DirectCast(paramobjeto, BE_Pasajero)
            Dim command As SqlCommand = Acceso.MiComando("Update Pasajero set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", parampasajero.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim parampasajero As BE_Pasajero = DirectCast(paramobjeto, BE_Pasajero)
            Dim command As SqlCommand = Acceso.MiComando("Update Pasajero set Nombre=@Nombre, Apellido=@Apellido, Correoelectronico=@Correoelectronico, DNI=@DNI, Domicilio=@Domicilio,Telefono=@Telefono where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", parampasajero.ID))
                .Add(New SqlParameter("@Nombre", parampasajero.Nombre))
                .Add(New SqlParameter("@Apellido", parampasajero.Apellido))
                .Add(New SqlParameter("@Correoelectronico", parampasajero.CorreoElectronico))
                .Add(New SqlParameter("@DNI", parampasajero.DNI))
                .Add(New SqlParameter("@Domicilio", parampasajero.Domicilio))
                .Add(New SqlParameter("@Telefono", parampasajero.Telefono))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Function consultarPasajero(ByVal parampasajero As BE_Pasajero) As BE_Pasajero
        Try
            Dim consulta As String = ("Select * from Pasajero where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", parampasajero.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearPasajero(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarPasajeros() As List(Of BE_Pasajero)
        Try
            Dim consulta As String = ("Select * from Pasajero where BL=@BL")
            Dim miListaPas As New List(Of BE_Pasajero)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaPas.Add(Me.formatearPasajero(drow))
            Next
            Return miListaPas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarPasajeroporDNI(ByVal paramPasajero As EE.BE_Pasajero) As List(Of BE_Pasajero)
        Try
            Dim consulta As String = ("Select * from Pasajero where DNI like '%" & paramPasajero.DNI & "%' and BL=@BL")
            Dim miListaPas As New List(Of BE_Pasajero)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@DNI", paramPasajero.DNI))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each miRow As DataRow In dt.Rows
                miListaPas.Add(Me.formatearPasajero(miRow))
            Next

            Return miListaPas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearPasajero(ByVal paramDataRow As DataRow) As BE_Pasajero
        Dim oPasajero As New BE_Pasajero
        oPasajero.ID = paramDataRow.Item("ID")
        oPasajero.Nombre = paramDataRow.Item("Nombre")
        oPasajero.Apellido = paramDataRow.Item("Apellido")
        oPasajero.CorreoElectronico = paramDataRow.Item("Correoelectronico")
        oPasajero.DNI = paramDataRow.Item("DNI")
        oPasajero.Domicilio = paramDataRow.Item("Domicilio")
        oPasajero.Telefono = paramDataRow.Item("Telefono")
        Return oPasajero
    End Function


End Class
