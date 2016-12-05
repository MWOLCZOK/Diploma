Imports BLL
Imports EE


Public Class Agregar_Provincia
    Implements BLL_Iobservador

    Private Sub Agregar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cargarCombos()
        Try
            Dim oListaPaises As New List(Of EE.BE_Pais)
            Dim bllPais As New BLL.BLL_Pais
            oListaPaises = bllPais.ConsultarPaises()
            For Each mipais As EE.BE_Pais In oListaPaises
                Me.ComboBox1.Items.Add(mipais)
            Next

        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub


    Private Function validarformulario() As Boolean
        Try
            If String.IsNullOrWhiteSpace(Me.Txtdescripcion.Text) Or String.IsNullOrWhiteSpace(Me.Txtregion.Text) Or String.IsNullOrWhiteSpace(Me.txtHabitantes.Text) Or String.IsNullOrWhiteSpace(Me.Txtsuperficieterrestre.Text) Then Return False
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
                oProvincia.Habitantes = txtHabitantes.Text
                oProvincia.Region = Txtregion.Text
                oProvincia.SuperficieTerrestre = Txtsuperficieterrestre.Text
                Dim oPais As New BE_Pais
                oPais.ID = DirectCast(ComboBox1.SelectedItem, BE_Pais).ID
                oProvincia.Pais = oPais
                bllProvincia.altaprovincia(oProvincia)
                MsgBox("Se ha agregado la provincia correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
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

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Agregar_Provincia_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Provincia")
    End Sub

    Private Sub Txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdescripcion.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub txtHabitantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHabitantes.KeyPress
        e.Handled = validacionTextBox.SoloNumeros(e)
    End Sub

    Private Sub Txtregion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtregion.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txtsuperficieterrestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtsuperficieterrestre.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub
End Class