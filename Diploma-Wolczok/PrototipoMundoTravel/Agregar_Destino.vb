Imports EE
Imports BLL

Public Class Agregar_Destino
    Implements BLL.BLL_Iobservador

    Private Sub Agregar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarcombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cargarcombos()
        Dim oListaLocalidad As New List(Of BE_Localidad)
        Dim bllLocalidad As New BLL.BLL_Localidad
        oListaLocalidad = bllLocalidad.consultarLocalidades

        For Each miLoc As BE_Localidad In oListaLocalidad
            Me.ComboBox1.Items.Add(miLoc)
            ComboBox1.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim oDestino As New BE_Destino
            Dim bllDestino As New BLL.BLL_Destino
            oDestino.Localidad = DirectCast(Me.ComboBox1.SelectedItem, BE_Localidad)
            oDestino.TieneAeropuerto = Me.CheckBox1.Checked
            bllDestino.altaDestino(oDestino)
        Catch ex As Exception
            MsgBox("Error")
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