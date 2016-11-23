Imports EE
Imports BLL


Public Class Agregar_Pais

    Implements BLL_Iobservador

    Private Function validarFormulario() As Boolean
        Try
            If Me.Txtdescripcion.Text = "" Or Me.Txtidiomapais.Text = "" Or Me.Txtzonahorariapais.Text = "" Then Return False
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
                'oPais.Poblacion_total = Me.Txtpoblacionpais.Text
                oPais.Zonahoraria = Me.Txtzonahorariapais.Text
                bllPais.AltaPais(oPais)
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

    Private Sub Agregar_Pais_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class