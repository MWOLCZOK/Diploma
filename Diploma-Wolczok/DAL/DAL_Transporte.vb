﻿Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL
Public Class DAL_Transporte
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramTransporte As BE_Transporte = DirectCast(paramobjeto, BE_Transporte)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Transporte values (@ID, @ID_Empresa, @ID_TipoTransporte, @Modelo, @Descripcion, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Transporte")))
                .Add(New SqlParameter("@ID_Empresa", paramTransporte.Empresa.ID))
                .Add(New SqlParameter("@ID_TipoTransporte", paramTransporte.TipoTransporte.ID))
                .Add(New SqlParameter("@Modelo", paramTransporte.Modelo))
                .Add(New SqlParameter("@Descripcion", paramTransporte.Descripcion))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            For Each oAsiento As BE_Asiento In paramTransporte.Asientos
                Dim command2 As SqlCommand = Acceso.MiComando("Insert into Asiento values (@ID, @ID_Transporte, @Fila, @Numeroasiento, @ID_categoriaasiento, @BL)")
                With command2.Parameters
                    .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Asiento")))
                    .Add(New SqlParameter("@ID_Transporte", Acceso.TraerUltimoID("ID", "Transporte")))
                    .Add(New SqlParameter("@Fila", oAsiento.Fila))
                    .Add(New SqlParameter("@Numeroasiento", oAsiento.NumeroAsiento))
                    .Add(New SqlParameter("@ID_categoriaasiento", oAsiento.CategoriaAsiento.ID))
                    .Add(New SqlParameter("@BL", False))
                End With
                Acceso.Escritura(command2)
                command2.Dispose()
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function

    Public Function consultarTransportes() As List(Of BE_Transporte)
        Try
            Dim consulta As String = ("Select * from Transporte where BL=@BL")
            Dim milistaAsiento As New List(Of BE_Transporte)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaAsiento.Add(Me.formatearTransporte(drow))
            Next
            Return milistaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function consultarTransportes(ByVal oTipoTransporte As BE_TipoTransporte) As List(Of BE_Transporte)
        Try
            Dim consulta As String = ("Select * from Transporte where ID_TipoTransporte=@ID_TipoTransporte and BL=@BL")
            Dim milistaAsiento As New List(Of BE_Transporte)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID_TipoTransporte", oTipoTransporte.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaAsiento.Add(Me.formatearTransporte(drow))
            Next
            Return milistaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarTransporte(ByVal oTransporte As EE.BE_Transporte) As EE.BE_Transporte
        Try
            Dim consulta As String = ("Select * from Transporte where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oTransporte.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearTransporte(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearTransporte(ByVal paramDataRow As DataRow) As BE_Transporte
        Dim oTransporte As New BE_Transporte
        oTransporte.ID = paramDataRow.Item("ID")
        oTransporte.Descripcion = paramDataRow.Item("Descripcion")
        oTransporte.Modelo = paramDataRow.Item("Modelo")
        Dim oEmpresa As New BE_EmpresaTransporte
        oEmpresa.ID = paramDataRow.Item("ID_Empresa")
        oTransporte.Empresa = (New DAL.DAL_Empresatransporte).consultarTransporte(oEmpresa)
        Dim oTipoTransporte As New BE_TipoTransporte
        oTipoTransporte.ID = paramDataRow.Item("ID_TipoTransporte")
        oTransporte.TipoTransporte = (New DAL.dal_TipoTransporte).consultarTipoTransporte(oTipoTransporte)
        Return oTransporte
    End Function
End Class
