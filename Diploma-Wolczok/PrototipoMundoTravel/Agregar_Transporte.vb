Imports EE
Imports BLL

Public Class Agregar_Transporte


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Agregar_Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub iniciar()
        cargarComboTipoTransporte()
        cargarComboEmpresas()
    End Sub


    Private Sub cargarComboEmpresas()
        Dim oListaEmpresa As New List(Of BE_EmpresaTransporte)
        Dim blltipoEmpresa As New BLL_EmpresaTransporte
        oListaEmpresa = blltipoEmpresa.consultarEmpresastransp()
        For Each mitrans As BE_EmpresaTransporte In oListaEmpresa
            Me.ComboBox1.Items.Add(mitrans)
        Next
    End Sub


    Private Sub cargarComboTipoTransporte()
        Dim oListatipotrans As New List(Of BE_TipoTransporte)
        Dim blltipotrans As New BLL_TipoTransporte
        oListatipotrans = blltipotrans.consultarTipoTransportes
        For Each mitrans As BE_TipoTransporte In oListatipotrans
            Me.Cbxtipotransporte.Items.Add(mitrans)
        Next
    End Sub

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        Try
            Dim oTransporte As New BE_Transporte
            oTransporte.TipoTransporte = DirectCast(Cbxtipotransporte.SelectedItem, BE_TipoTransporte)
            oTransporte.Empresa = DirectCast(ComboBox1.SelectedItem, BE_EmpresaTransporte)
            oTransporte.Descripcion = Me.TextBox1.Text
            oTransporte.Modelo = Me.TextBox2.Text
            Dim bllTransporte As New BLL_Transporte
            oTransporte.Asientos = bllTransporte.obtenerAsientos(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value, Me.NumericUpDown4.Value, Me.NumericUpDown5.Value)
            bllTransporte.altaTransporte(oTransporte)
        Catch ex As Exception

        End Try
    End Sub

End Class