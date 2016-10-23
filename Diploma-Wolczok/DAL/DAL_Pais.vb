Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Pais

    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim parampais As BE_Pais = DirectCast(paramobjeto, BE_Pais)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Pais values (@ID, @Descripcion, @Idioma, @PoblacionTotal, @ZonaHoraria, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Pais")))
                .Add(New SqlParameter("@Descripcion", parampais.Descripcion))
                .Add(New SqlParameter("@Idioma", parampais.Idioma))
                .Add(New SqlParameter("@PoblacionTotal", parampais.Poblacion_total))
                .Add(New SqlParameter("@ZonaHoraria", parampais.Zonahoraria))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim parampais As BE_Pais = DirectCast(paramobjeto, BE_Pais)
            Dim command As SqlCommand = Acceso.MiComando("Update Pais set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", parampais.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Function formatearPais(ByVal paramDataRow As DataRow) As BE_Pais
        Dim oPais As New BE_Pais
        oPais.ID = paramDataRow.Item("ID")
        oPais.Descripcion = paramDataRow.Item("Descripcion")
        oPais.Idioma = paramDataRow.Item("Idioma")
        oPais.Poblacion_total = paramDataRow.Item("Poblaciontotal")
        oPais.Zonahoraria = paramDataRow.Item("Zonahoraria")
        Return oPais
    End Function

    Public Function consultarPaises() As List(Of EE.BE_Pais)
        Try
            Dim consulta As String = ("Select * from Pais where BL=@BL")
            Dim miListaPais As New List(Of EE.BE_Pais)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaPais.Add(Me.formatearPais(drow))
            Next
            Return miListaPais
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarPais(ByVal oPais As EE.BE_Pais) As EE.BE_Pais
        Try
            Dim consulta As String = ("Select * from Pais where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oPais.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearPais(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim parampais As BE_Pais = DirectCast(paramobjeto, BE_Pais)
            Dim command As SqlCommand = Acceso.MiComando("Update Pais set Descripcion=@Descripcion, Idioma=@Idioma, Poblaciontotal=@PoblacionTotal, Zonahoraria=@ZonaHoraria, Provincia=@Provincia where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", parampais.ID))
                .Add(New SqlParameter("@Descripcion", parampais.Descripcion))
                .Add(New SqlParameter("@Idioma", parampais.Idioma))
                .Add(New SqlParameter("@PoblacionTotal", parampais.Poblacion_total))
                .Add(New SqlParameter("@ZonaHoraria", parampais.Zonahoraria))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
