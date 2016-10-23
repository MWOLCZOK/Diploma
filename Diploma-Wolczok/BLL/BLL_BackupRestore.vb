Public Class BLL_BackupRestore
    Dim DAL_BR As New DAL.DAL_BackupRestore

    Public Function RealizarBackup(ByVal paramBackup As EE.BE_BackupRestore) As Boolean
        Try
            Return DAL_BR.realizarBackup(paramBackup)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RealizarRestore(ByVal paramBackup As EE.BE_BackupRestore) As Boolean
        Try
            Return DAL_BR.realizarRestore(paramBackup)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
