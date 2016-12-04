Imports EE
Imports BLL

Public Class Agregar_Destino
    Implements BLL.BLL_Iobservador

    Private Sub Agregar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarcombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cargarcombos()
        Try
            Dim oListaLocalidad As New List(Of BE_Localidad)
            Dim bllLocalidad As New BLL.BLL_Localidad
            oListaLocalidad = bllLocalidad.consultarLocalidades
            For Each miLoc As BE_Localidad In oListaLocalidad
                Me.ComboBox1.Items.Add(miLoc)
                ComboBox1.DisplayMember = "NombreCompleto"
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try 
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not IsNothing(ComboBox1.SelectedItem) Then
                Dim oDestino As New BE_Destino
                Dim bllDestino As New BLL.BLL_Destino
                oDestino.Localidad = DirectCast(Me.ComboBox1.SelectedItem, BE_Localidad)
                oDestino.TieneAeropuerto = Me.chkTieneAeropuerto.Checked
                bllDestino.altaDestino(oDestino)
                MsgBox("Se ha agregado el destino correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
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

    Public Sub actualizarIdioma(ParamObservador As BLL.BLL_SesionObservada) Implements BLL.BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Agregar_Destino_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alta de Destino")
    End Sub
End Class