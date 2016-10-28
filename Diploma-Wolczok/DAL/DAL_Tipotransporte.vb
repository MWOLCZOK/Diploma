Imports DAL
Imports EE
Imports System.Data.SqlClient

Public Class DAL_Tipotransporte

    Implements Master




    Public Sub alta(paramobjeto As Object) Implements Master.alta

    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function


    Public Function consultarTipotransportes(ByVal oTipotransporte As BE_TipoTransporte) As List(Of BE_TipoTransporte)
        Try
            Dim consulta As String = ("Select * from Empresatransporte where BL=@BL")
            Dim milistaAsiento As New List(Of BE_TipoTransporte)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oTipotransporte.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaAsiento.Add(Me.formatearTipotransporte(drow))
            Next
            Return milistaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearTipotransporte(ByVal paramDataRow As DataRow) As BE_TipoTransporte
        Dim oTipotransporte As New BE_TipoTransporte
        oTipotransporte.ID = paramDataRow.Item("ID")
        oTipotransporte.Descripcion = paramDataRow.Item("Descripcion")
        Return oTipotransporte
    End Function

    Public Function consultarTipotransporte(ByVal oTipotransporte As BE_TipoTransporte) As BE_TipoTransporte
        Try
            Dim consulta As String = ("Select * from Asiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oTipotransporte.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearTipotransporte(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
