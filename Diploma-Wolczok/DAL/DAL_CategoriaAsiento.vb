Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_CategoriaAsiento
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta

    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function


    Public Function consultarCategoriaAsientos() As List(Of BE_CategoriaAsiento)
        Try
            Dim consulta As String = ("Select * from CategoriaAsiento where BL=@BL")
            Dim milistaCategoriaAsiento As New List(Of BE_CategoriaAsiento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaCategoriaAsiento.Add(Me.formatearCategoriaAsiento(drow))
            Next
            Return milistaCategoriaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarCategoriaAsiento(ByVal oCategoriaAsiento As EE.BE_CategoriaAsiento) As EE.BE_CategoriaAsiento

        Try
            Dim consulta As String = ("Select * from CategoriaAsiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oCategoriaAsiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearCategoriaAsiento(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearCategoriaAsiento(ByVal paramDataRow As DataRow) As BE_CategoriaAsiento
        Dim oCategoriaAsiento As New BE_CategoriaAsiento
        oCategoriaAsiento.ID = paramDataRow.Item("ID")
        oCategoriaAsiento.Descripcion = paramDataRow.Item("Descripcion")
        Return oCategoriaAsiento
    End Function
End Class
