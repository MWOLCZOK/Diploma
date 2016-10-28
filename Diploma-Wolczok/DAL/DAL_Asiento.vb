﻿Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Asiento
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta

    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function

    Public Function consultarAsientos(ByVal oTransporte As BE_Transporte) As List(Of BE_Asiento)
        Try
            Dim consulta As String = ("Select * from Asiento where BL=@BL")
            Dim milistaAsiento As New List(Of BE_Asiento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oTransporte.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaAsiento.Add(Me.formatearAsiento(drow))
            Next
            Return milistaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarAsiento(ByVal oAsiento As EE.BE_Asiento) As EE.BE_Asiento
        Try
            Dim consulta As String = ("Select * from Asiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oAsiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearAsiento(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearAsiento(ByVal paramDataRow As DataRow) As BE_Asiento
        Dim oAsiento As New BE_Asiento
        oAsiento.ID = paramDataRow.Item("ID")
        oAsiento.Fila = paramDataRow.Item("Fila")
        oAsiento.NumeroAsiento = paramDataRow.Item("NumeroAsiento")
        Dim oCategoriaAciento As New BE_CategoriaAsiento
        oCategoriaAciento.ID = paramDataRow.Item("ID_CategoriaAsiento")
        oAsiento.CategoriaAsiento = (New DAL.DAL_CategoriaAsiento).consultarCategoriaAsiento(oCategoriaAciento)
        oAsiento.Transporte = paramDataRow.Item("ID_Transporte")
        Return oAsiento
    End Function
End Class
