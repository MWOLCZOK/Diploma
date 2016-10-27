Imports DAL
Imports EE
Imports System.Data.SqlClient
Imports System.Configuration


Public Class DAL_Puntaje

    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramPuntaje As BE_Puntaje = DirectCast(paramobjeto, BE_Puntaje)
            Dim command As SqlCommand = Acceso.MiComando("Update Puntaje set Descripcion=@Descripcion, Coeficiente=@Coeficiente where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramPuntaje.ID))
                .Add(New SqlParameter("@Descripcion", paramPuntaje.Descripcion))
                .Add(New SqlParameter("@Coeficiente", paramPuntaje.Coeficiente))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarPuntaje() As List(Of BE_Puntaje)
        Try
            Dim consulta As String = ("Select * from Puntaje where BL=@BL")
            Dim miListapuntaje As New List(Of BE_Puntaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With

            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListapuntaje.Add(Me.formatearPuntaje(drow))
            Next
            Return miListapuntaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearPuntaje(ByVal paramDataRow As DataRow) As BE_Puntaje
        Dim oPuntaje As New BE_Puntaje
        oPuntaje.ID = paramDataRow.Item("ID")
        oPuntaje.Descripcion = paramDataRow.Item("Descripcion")
        oPuntaje.Coeficiente = paramDataRow.Item("Coeficiente")

        Return oPuntaje
    End Function



End Class
