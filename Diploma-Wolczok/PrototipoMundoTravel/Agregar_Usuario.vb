Public Class Agregar_Usuario

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Function validarFormulario() As Boolean
        Try
            If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then Return False
            If Me.TextBox2.Text <> Me.TextBox3.Text Then Return False
            If Me.ComboBox1.SelectedItem Is Nothing Then Return False
            If Me.ComboBox2.SelectedItem Is Nothing Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub agregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class