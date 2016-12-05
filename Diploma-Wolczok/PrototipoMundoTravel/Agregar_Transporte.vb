Imports EE
Imports BLL

Public Class Agregar_Transporte
    Implements BLL_Iobservador


    Private Sub Agregar_Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub iniciar()
        Try
            cargarComboTipoTransporte()
            cargarComboEmpresas()
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
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


    Private Function validarFormulario() As Boolean
        Try
            If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then Return False
            If Me.ComboBox1.SelectedItem Is Nothing Then Return False
            If Me.Cbxtipotransporte.SelectedItem Is Nothing Then Return False
            If Me.NumericUpDown5.Value <= 0 Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarformulario = True Then
                Dim oTransporte As New BE_Transporte
                oTransporte.TipoTransporte = DirectCast(Cbxtipotransporte.SelectedItem, BE_TipoTransporte)
                oTransporte.Empresa = DirectCast(ComboBox1.SelectedItem, BE_EmpresaTransporte)
                oTransporte.Descripcion = Me.TextBox1.Text
                oTransporte.Modelo = Me.TextBox2.Text
                Dim bllTransporte As New BLL_Transporte
                oTransporte.Asientos = bllTransporte.obtenerAsientos(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value, Me.NumericUpDown4.Value, Me.NumericUpDown5.Value)
                bllTransporte.altaTransporte(oTransporte)
                MsgBox("Se ha agregado el transporte correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnInsertException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub
End Class