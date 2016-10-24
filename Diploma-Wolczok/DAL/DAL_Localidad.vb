Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Localidad

    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramloc As BE_Localidad = DirectCast(paramobjeto, BE_Localidad)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Localidad values (@ID, @Descripcion, @Cantidadbarrios, @Habitantes, @ID_Provincia, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Localidad")))
                .Add(New SqlParameter("@Descripcion", paramloc.Descripcion))
                .Add(New SqlParameter("@Cantidadbarrios", paramloc.CantidadBarrios))
                .Add(New SqlParameter("@Habitantes", paramloc.Habitantes))
                .Add(New SqlParameter("@ID_Provincia", paramloc.Provincia.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramloc As BE_Localidad = DirectCast(paramobjeto, BE_Localidad)
            Dim command As SqlCommand = Acceso.MiComando("Update Localidad set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramloc.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramloc As BE_Localidad = DirectCast(paramobjeto, BE_Localidad)
            Dim command As SqlCommand = Acceso.MiComando("Update Localidad set Descripcion=@Descripcion, Cantidadbarrios=@Cantidadbarrios, Habitantes=@Habitantes, ID_Provincia=@ID_Provincia where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramloc.ID))
                .Add(New SqlParameter("@Descripcion", paramloc.Descripcion))
                .Add(New SqlParameter("@Cantidadbarrios", paramloc.CantidadBarrios))
                .Add(New SqlParameter("@Habitantes", paramloc.Habitantes))
                .Add(New SqlParameter("@ID_Provincia", paramloc.Provincia.ID))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function formatearLocalidad(ByVal paramDataRow As DataRow) As BE_Localidad
        Dim oLocalidad As New BE_Localidad
        oLocalidad.ID = paramDataRow.Item("ID")
        oLocalidad.Descripcion = paramDataRow.Item("Descripcion")
        oLocalidad.CantidadBarrios = paramDataRow.Item("Cantidadbarrios")
        oLocalidad.Habitantes = paramDataRow.Item("Habitantes")
        Dim oProvincia As New BE_Provincia
        oProvincia.ID = CInt(paramDataRow.Item("ID_Provincia"))
        oLocalidad.Provincia = (New DAL.DAL_Provincia).consultarProvincia(oProvincia)
        Return oLocalidad
    End Function

    Public Function consultarLocalidades() As List(Of BE_Localidad)
        Try
            Dim consulta As String = ("Select * from Localidad where BL=@BL")
            Dim miListaLocalidad As New List(Of BE_Localidad)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaLocalidad.Add(Me.formatearLocalidad(drow))
            Next
            Return miListaLocalidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarLocalidad(ByVal oLocalidad As EE.BE_Localidad) As EE.BE_Localidad
        Try
            Dim consulta As String = ("Select * from Localidad where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oLocalidad.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearLocalidad(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
