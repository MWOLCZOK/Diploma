Imports BLL
Imports EE

Public Class Agregar_Usuario
    Implements BLL_Iobservador

    Private Function validarFormulario() As Boolean
        Try
            If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then Return False
            If Me.TextBox2.Text <> Me.TextBox3.Text Then Return False
            If Len(Me.TextBox2.Text) < 6 Then Return False
            If Me.ComboBox1.SelectedItem Is Nothing Then Return False
            If Me.ComboBox2.SelectedItem Is Nothing Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub agregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub


    Private Sub llenarCombos()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox2.Items.Clear()
        Dim milistaIdioma As New List(Of EE.BE_Idioma)
        Dim bllIdioma As New BLL.BLL_Idioma
        Dim bllPerfil As New BLL.BLL_GestorPermiso
        milistaIdioma = bllIdioma.consultarIdiomas
        ControladorPermisos.CargarPermisos(Me.ComboBox2)
        For Each Idioma In milistaIdioma
            Me.ComboBox1.Items.Add(Idioma)
        Next
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarFormulario() = True Then
                Dim oUsuario As New EE.BE_Usuario
                Dim bllUsuario As New BLL.BLL_Usuario
                oUsuario.NombreUsuario = Me.TextBox1.Text
                oUsuario.Password = BLL.Encriptadora.EncriptarPass(Me.TextBox2.Text)
                oUsuario.Nombre = Me.TextBox4.Text
                oUsuario.Apellido = Me.TextBox5.Text
                Dim oIdioma As New EE.BE_Idioma
                Dim bllIdioma As New BLL.BLL_Idioma
                bllIdioma.consultarIdiomas()
                oIdioma = bllIdioma.consultarIdiomas(CInt(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Idioma).id_idioma))
                oUsuario.idioma = oIdioma
                Dim oPerfil As New EE.BE_GrupoPermiso
                Dim bllPerfil As New BLL.BLL_GestorPermiso
                oPerfil = bllPerfil.ConsultarporID(CInt(DirectCast(Me.ComboBox2.SelectedItem, EE.BE_GrupoPermiso).ID))
                oUsuario.Perfil = oPerfil
                bllUsuario.altaUsuario(oUsuario)
                MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Usuario_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Usuario")
    End Sub
End Class