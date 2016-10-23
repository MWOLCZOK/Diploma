Imports System.Text
Imports System.Data.SqlClient
Public Class DAL_BackupRestore
    Public Function realizarBackup(ByVal backupEntidad As EE.BE_BackupRestore) As Boolean
        Dim ruta As String = ""
        If backupEntidad.Directorio.Length <> 3 Then
            ruta = backupEntidad.Directorio & "\" & backupEntidad.Nombre & ".bak"
        Else
            ruta = backupEntidad.Directorio & backupEntidad.Nombre & ".bak"
        End If
        Using MiConectionMaster = Acceso.MiConexionMaster()
            Try
                Dim MiStringBuilder As New StringBuilder
                MiStringBuilder.Append("BACKUP DATABASE [MundoTravel] TO DISK = '" & ruta & "' ")
                MiStringBuilder.Append("WITH DESCRIPTION = 'Backup MundoTravel', NOFORMAT, NOINIT, ")
                MiStringBuilder.Append("NAME = '" & backupEntidad.Nombre & "', SKIP, NOREWIND, NOUNLOAD, STATS = 10")
                Dim MiComando As New SqlCommand(MiStringBuilder.ToString, MiConectionMaster)
                MiConectionMaster.Open()
                MiComando.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Throw ex
            Finally
                MiConectionMaster.Dispose()
                MiConectionMaster.Close()
            End Try
        End Using
    End Function
    Public Function realizarRestore(ByVal backupEntidad As EE.BE_BackupRestore) As Boolean
        Dim MiConectionMaster As New SqlConnection
        Try
            MiConectionMaster = Acceso.MiConexionMaster
            Dim Strcomando As String = " ALTER DATABASE  [MundoTravel] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [MundoTravel] FROM DISK = '" & BackupEntidad.Directorio & "'  With Replace ALTER DATABASE [MundoTravel] SET MULTI_USER "
            Dim MiComando As New SqlCommand(Strcomando, MiConectionMaster)
            MiConectionMaster.Open()
            MiComando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            MiConectionMaster.Dispose()
            MiConectionMaster.Close()
        End Try
    End Function
End Class
