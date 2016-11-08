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
            Dim bllTransporte As New BLL_Transporte
            oTransporte.Asientos = obtenerAsientos()
            bllTransporte.altaTransporte(oTransporte)
        Catch ex As Exception

        End Try
    End Sub

    Private Function obtenerAsientos() As List(Of EE.BE_Asiento)
        Dim NumeroAsiento As Integer = 0
        Dim cantidadEjecutiva As Integer = 0
        Dim cantidadPremium As Integer = 0
        Dim cantidadPrimera As Integer = 0
        Dim cantidadTurista As Integer = 0
        cantidadEjecutiva = Me.NumericUpDown1.Value
        cantidadPremium = Me.NumericUpDown2.Value
        cantidadPrimera = Me.NumericUpDown3.Value
        cantidadTurista = Me.NumericUpDown4.Value
        Dim listaAsientos As New List(Of EE.BE_Asiento)
        'CARGO LOS EJECUTIVOS
        For i = 0 To cantidadEjecutiva
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 1
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS PREMIUM
        For i = 0 To cantidadPremium
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 2
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS DE PRIMERA
        For i = 0 To cantidadPrimera
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 3
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS TURISTA
        For i = 0 To cantidadTurista
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 4
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            listaAsientos.Add(oAsiento)
        Next
        Return listaAsientos

    End Function
End Class