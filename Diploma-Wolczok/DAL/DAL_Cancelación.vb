Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Cancelación

    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramCancelacion As BE_Pais = DirectCast(paramobjeto, BE_Pais)
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

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function
End Class
