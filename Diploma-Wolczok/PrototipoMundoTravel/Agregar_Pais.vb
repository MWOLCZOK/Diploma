Imports EE
Imports BLL


Public Class Agregar_Pais

    Implements BLL_Iobservador

    Private Function validarFormulario() As Boolean
        Try
            If String.IsNullOrWhiteSpace(Me.Txtdescripcion.Text) Or String.IsNullOrWhiteSpace(Me.Txtidiomapais.Text) Or String.IsNullOrWhiteSpace(Me.Txtzonahorariapais.Text) Or String.IsNullOrWhiteSpace(Me.Txtpoblacionpais.Text) Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Agregar_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarFormulario() = True Then
                Dim oPais As New BE_Pais
                Dim bllPais As New BLL_Pais
                oPais.Descripcion = Me.Txtdescripcion.Text
                oPais.Idioma = Me.Txtidiomapais.Text
                oPais.Poblacion_total = Me.Txtpoblacionpais.Text
                oPais.Zonahoraria = Me.Txtzonahorariapais.Text
                bllPais.AltaPais(oPais)
                MsgBox("Se ha agregado el pais correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
            Else
                Throw New CamposIncorrectosException
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

    Private Sub Agregar_Pais_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alta de País")
    End Sub

    Private Sub Txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdescripcion.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txtidiomapais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtidiomapais.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txtpoblacionpais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpoblacionpais.KeyPress
        e.Handled = validacionTextBox.SoloNumeros(e)
    End Sub

    Private Sub Txtzonahorariapais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtzonahorariapais.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub
End Class