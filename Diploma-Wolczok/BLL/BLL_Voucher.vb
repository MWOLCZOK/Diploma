Public Class BLL_Voucher
    Dim _dalVoucher As New DAL.DAL_Voucher

    Public Sub altaVoucher(ByVal paramVoucher As EE.BE_Voucher)
        Try
            _dalVoucher.alta(paramVoucher)
        Catch ex As Exception

        End Try
    End Sub

    Public Function consultarVoucher(ByVal paramVoucher As EE.BE_Voucher) As EE.BE_Voucher
        Try

            Return _dalVoucher.consultarVoucher(paramVoucher)
        Catch ex As Exception

        End Try
    End Function



    Public Function consultarVoucher() As List(Of EE.BE_Voucher)
        Try
            Return _dalVoucher.consultarVoucher()
        Catch ex As Exception

        End Try
    End Function

End Class
