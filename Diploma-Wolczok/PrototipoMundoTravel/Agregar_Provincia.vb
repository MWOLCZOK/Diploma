Imports BLL
Imports EE


Public Class Agregar_Provincia
    Implements BLL_Iobservador

    Private Sub Agregar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub cargarCombos()
        Dim oListaPaises As New List(Of EE.BE_Pais)
        Dim bllPais As New BLL.BLL_Pais
        oListaPaises = bllPais.ConsultarPaises()
        For Each mipais As EE.BE_Pais In oListaPaises
            Me.ComboBox1.Items.Add(mipais)
        Next

    End Sub


    Private Function validarformulario() As Boolean
        Try
            If Me.Txtdescripcion.Text = "" Or Me.Txtregion.Text = "" Or Me.Txtsuperficieterrestre.Text = "" Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarformulario() = True Then
                Dim oProvincia As New BE_Provincia
                Dim bllProvincia As New BLL_Provincia
                oProvincia.Descripcion = Txtdescripcion.Text
                oProvincia.Habitantes = NumericUpDown1.Value
                oProvincia.Region = Txtregion.Text
                oProvincia.SuperficieTerrestre = Txtsuperficieterrestre.Text
                Dim oPais As New BE_Pais
                oPais.ID = DirectCast(ComboBox1.SelectedItem, BE_Pais).ID
                oProvincia.Pais = oPais
                bllProvincia.altaprovincia(oProvincia)
                MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Provincia_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Provincia")
    End Sub
End Class