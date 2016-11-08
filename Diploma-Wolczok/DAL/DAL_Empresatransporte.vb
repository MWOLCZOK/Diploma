Imports DAL
Imports EE
Imports System.Data.SqlClient

Public Class DAL_Empresatransporte
    Implements Master


    Public Sub alta(paramobjeto As Object) Implements Master.alta

    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar

    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar

    End Function


    Public Function consultarTransportes() As List(Of BE_EmpresaTransporte)
        Try
            Dim consulta As String = ("Select * from Empresatransporte where BL=@BL")
            Dim milistaAsiento As New List(Of BE_EmpresaTransporte)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaAsiento.Add(Me.formatearEmpresatransporte(drow))
            Next
            Return milistaAsiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function formatearEmpresatransporte(ByVal paramDataRow As DataRow) As BE_EmpresaTransporte
        Dim oEmpresatransporte As New BE_EmpresaTransporte
        oEmpresatransporte.ID = paramDataRow.Item("ID")
        oEmpresatransporte.Nombre = paramDataRow.Item("Nombre")
        oEmpresatransporte.CUIL = paramDataRow.Item("Cuil")
        oEmpresatransporte.Descripcion = paramDataRow.Item("Descripcion")
        oEmpresatransporte.Mail = paramDataRow.Item("Mail")
        oEmpresatransporte.Telefono = paramDataRow.Item("Telefono")
        Return oEmpresatransporte
    End Function


    Public Function consultarTransporte(ByVal oEmpresatrans As BE_EmpresaTransporte) As BE_EmpresaTransporte
        Try
            Dim consulta As String = ("Select * from EmpresaTransporte where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oEmpresatrans.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearEmpresatransporte(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
