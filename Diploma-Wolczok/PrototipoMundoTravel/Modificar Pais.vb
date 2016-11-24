Imports BLL
Imports EE


Public Class Modificar_Pais
    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub Iniciar()
        Try
            Cbxpais.SelectedItem = Nothing
            Cbxpais.Items.Clear()
            txtDescripcion.Text = ""
            Txtidiomapais.Text = ""
            NumericUpDown1.Value = 0
            Txtzonahorariapais.Text = ""

            Dim GestorPais As New BLL_Pais
            Dim Listapaises = GestorPais.ConsultarPaises()
            For Each pai In Listapaises
                Cbxpais.Items.Add(pai)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cbxpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpais.SelectedIndexChanged
        If Not IsNothing(Cbxpais.SelectedItem) Then
            Dim NuevoPais As BE_Pais = New BE_Pais
            NuevoPais = DirectCast(Cbxpais.SelectedItem, BE_Pais)
            Me.txtDescripcion.Text = NuevoPais.Descripcion
            Me.Txtidiomapais.Text = NuevoPais.Idioma
            Me.NumericUpDown1.Value = NuevoPais.Poblacion_total
            Me.Txtzonahorariapais.Text = NuevoPais.Zonahoraria
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Gestorpais As BLL_Pais = New BLL_Pais
        Dim Paismodificar As BE_Pais = Nothing

        Try
            If Not IsNothing(Cbxpais.SelectedItem) Then
                If Not IsNothing(Cbxpais.SelectedItem) And Not String.IsNullOrWhiteSpace(txtDescripcion.Text) And Not String.IsNullOrWhiteSpace(Txtidiomapais.Text) And Not String.IsNullOrWhiteSpace(Txtzonahorariapais.Text) Then
                    Paismodificar = DirectCast(Cbxpais.SelectedItem, BE_Pais)
                    Paismodificar.ID = DirectCast(Cbxpais.SelectedItem, BE_Pais).ID
                    Paismodificar.Descripcion = txtDescripcion.Text
                    Paismodificar.Idioma = txtDescripcion.Text
                    Paismodificar.Poblacion_total = Txtidiomapais.Text
                    Paismodificar.Zonahoraria = Txtzonahorariapais.Text
                    Gestorpais.modificarPais(Paismodificar)
                    Iniciar()
                    MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Pais_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar de País")
    End Sub
End Class