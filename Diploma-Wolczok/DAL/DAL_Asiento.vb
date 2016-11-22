Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Asiento

    Public Function consultarAsientos(ByVal oViaje As BE_Viaje) As List(Of BE_Asiento)
        Try
            Dim consulta As String = ("Select * from Asiento where ID_Transporte=@ID_Transporte and BL=@BL and ID not in (select ID_Asiento from ReservaViaje where ID_Viaje = @ID_Viaje)")
            Dim milistaAsiento As New List(Of BE_Asiento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID_Transporte", oViaje.Transporte.ID))
                .Add(New SqlParameter("@ID_Viaje", oViaje.ID))
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
        Dim oTransporte As New BE_Transporte
        oTransporte.ID = paramDataRow.Item("ID_Transporte")
        oAsiento.Transporte = (New DAL.DAL_Transporte).consultarTransporte(oTransporte)
        Return oAsiento
    End Function

End Class
