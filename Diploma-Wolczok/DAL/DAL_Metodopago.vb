﻿Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Metodopago



    Public Function consultarMetodosPagos() As List(Of BE_Metodopago)
        Try
            Dim consulta As String = ("Select * from MetodoPago where BL=@BL")
            Dim miMetodopago As New List(Of BE_Metodopago)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miMetodopago.Add(Me.formatearMetodoPago(drow))
            Next
            Return miMetodopago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearMetodoPago(ByVal paramDataRow As DataRow) As BE_Metodopago
        Dim oMetodopago As New BE_Metodopago
        oMetodopago.ID = paramDataRow.Item("ID")
        oMetodopago.Descripcion = paramDataRow.Item("Descripcion")
        Return oMetodopago
    End Function




End Class