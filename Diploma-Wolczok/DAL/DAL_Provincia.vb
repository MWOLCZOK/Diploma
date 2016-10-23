Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL

Public Class DAL_Provincia

    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramprovicia As BE_Provincia = DirectCast(paramobjeto, BE_Provincia)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Provincia values (@ID, @Descripcion, @Habitantes, @Region, @Superficieterrestre, @ID_Pais, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Provincia")))
                .Add(New SqlParameter("@Descripcion", paramprovicia.Descripcion))
                .Add(New SqlParameter("@Habitantes", paramprovicia.Habitantes))
                .Add(New SqlParameter("@Region", paramprovicia.Region))
                .Add(New SqlParameter("@Superficieterrestre", paramprovicia.SuperficieTerrestre))
                .Add(New SqlParameter("@ID_Pais", paramprovicia.Pais.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramprovincia As BE_Provincia = DirectCast(paramobjeto, BE_Provincia)
            Dim command As SqlCommand = Acceso.MiComando("Update Provincia set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramprovincia.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramprovincia As BE_Provincia = DirectCast(paramobjeto, BE_Provincia)
            Dim command As SqlCommand = Acceso.MiComando("Update Provincia set Descripcion=@Descripcion, Habitantes=@Habitantes, Region=@Region, Superficieterrestre=@Superficieterrestre, Localidad=@Localidad where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramprovincia.ID))
                .Add(New SqlParameter("@Descripcion", paramprovincia.Descripcion))
                .Add(New SqlParameter("@Habitantes", paramprovincia.Habitantes))
                .Add(New SqlParameter("@Region", paramprovincia.Region))
                .Add(New SqlParameter("@Superficieterrestre", paramprovincia.SuperficieTerrestre))
                .Add(New SqlParameter("@ID_Pais", paramprovincia.Pais.ID))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarProvincias() As List(Of BE_Provincia)
        Try
            Dim consulta As String = ("Select * from Provincia where BL=@BL")
            Dim miListaProv As New List(Of BE_Provincia)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaProv.Add(Me.formatearProvincia(drow))
            Next
            Return miListaProv
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearProvincia(ByVal paramDataRow As DataRow) As BE_Provincia
        Dim oProvincia As New BE_Provincia
        oProvincia.ID = paramDataRow.Item("ID")
        oProvincia.Descripcion = paramDataRow.Item("Descripcion")
        oProvincia.Habitantes = paramDataRow.Item("Habitantes")
        oProvincia.Region = paramDataRow.Item("Region")
        oProvincia.SuperficieTerrestre = paramDataRow.Item("Superficieterrestre")
        Dim oPais As New BE_Pais
        oPais.ID = CInt(paramDataRow.Item("ID_Pais"))
        oProvincia.Pais = (New DAL.DAL_Pais).consultarPais(oPais)
        Return oProvincia
    End Function


End Class
