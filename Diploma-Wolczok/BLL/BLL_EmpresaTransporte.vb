Imports DAL
Imports EE


Public Class BLL_EmpresaTransporte

    Dim _dalempresatrans As New DAL_Empresatransporte

    Public Sub altaempresatransporte(ByVal oEmpresatransp As BE_EmpresaTransporte)
        Try
            _dalempresatrans.alta(oEmpresatransp)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarTipotransporte(ByVal oEmpresatransp As BE_EmpresaTransporte)
        Try
            _dalempresatrans.eliminar(oEmpresatransp)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarTipotransporte(ByVal oEmpresatransp As BE_EmpresaTransporte) As Boolean
        Try
            Return _dalempresatrans.modificar(oEmpresatransp)
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarEmpresatransp(ByVal oEmpresatrans As BE_EmpresaTransporte) As BE_EmpresaTransporte
        Return _dalempresatrans.consultarTransporte(oEmpresatrans)
    End Function


    Public Function consultarEmpresastransp() As List(Of BE_EmpresaTransporte)
        Return _dalempresatrans.consultarTransportes()
    End Function



End Class
