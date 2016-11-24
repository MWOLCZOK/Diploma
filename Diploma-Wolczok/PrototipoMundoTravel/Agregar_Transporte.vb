Imports EE
Imports BLL

Public Class Agregar_Transporte
    Implements BLL_Iobservador


    Private Sub Agregar_Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
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

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Transporte_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Transporte")
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class