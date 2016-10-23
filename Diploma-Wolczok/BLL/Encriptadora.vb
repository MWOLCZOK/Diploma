Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.ComponentModel

Public Class Encriptadora
    Public Shared Function EncriptarPass(ByVal Texto As String) As String
        Try
            Dim MiMD5 As MD5 = MD5CryptoServiceProvider.Create()
            Dim MiData As Byte() = MiMD5.ComputeHash(Encoding.Default.GetBytes(Texto))
            Dim MiStringBuilder As StringBuilder = New StringBuilder()
            For i As Integer = 0 To MiData.Length - 1
                MiStringBuilder.AppendFormat("{0:x2}", MiData(i))
            Next
            Return MiStringBuilder.ToString.ToUpper
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
