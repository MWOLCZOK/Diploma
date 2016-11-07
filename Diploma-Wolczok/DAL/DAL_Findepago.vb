Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Findepago

    Public Function consultarfinpago() As List(Of BE_Finpago)
        Try
            Dim consulta As String = ("Select * from Findepago where BL=@BL")
            Dim miListafinpago As New List(Of BE_Finpago)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListafinpago.Add(Me.formatearfinpago(drow))
            Next
            Return miListafinpago
        Catch ex As Exception
            Throw ex
        End Try

    End Function



    Private Function formatearfinpago(ByVal paramDataRow As DataRow) As BE_Finpago
        Dim oFinpago As New BE_Finpago
        oFinpago.ID = paramDataRow.Item("ID")
        oFinpago.Descripcion = paramDataRow.Item("Descripcion")
        Return oFinpago
    End Function

End Class
