Imports BLL
Imports EE

Public Class Agregar_Usuario
    Implements BLL_Iobservador

    Private Function validarFormulario() As Boolean
        Try
            If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then Return False
            If Me.ComboBox1.SelectedItem Is Nothing Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function validarLongitudPassword()
        Try
            If Len(Me.TextBox2.Text) < 6 Then Return False
            Return True
        Catch ex As Exception
            Throw New PasswordCortoException
        End Try
    End Function

    Private Function validarPasswordRepetido()
        Try
            If Me.TextBox2.Text <> Me.TextBox3.Text Then Return False
            Return True
        Catch ex As Exception
            Throw New PasswordnoCoincidenException
        End Try
    End Function

    Private Sub agregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Tree_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles Tree.AfterCheck
        If eventArgs.Action = TreeViewAction.ByKeyboard Or eventArgs.Action = TreeViewAction.ByMouse Then
            Try
                ControladorPermisos.CheckChildNodes(eventArgs.Node)

            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub llenarCombos()
        Try
            ControladorPermisos.CargarPermisos(Tree)
            Me.ComboBox1.Items.Clear()
            Dim milistaIdioma As New List(Of EE.BE_Idioma)
            Dim bllIdioma As New BLL.BLL_Idioma
            Dim bllPerfil As New BLL.BLL_GestorPermiso
            milistaIdioma = bllIdioma.consultarIdiomas
            For Each Idioma In milistaIdioma
                Me.ComboBox1.Items.Add(Idioma)
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
            If validarFormulario() = True Then
                If validarPasswordRepetido() = True Then
                    If validarLongitudPassword() = True Then
                        'Genero un Permiso con el Nombre de Usuario que se esta generando

                        Dim oUsuario As New EE.BE_Usuario
                        Dim bllUsuario As New BLL.BLL_Usuario
                        oUsuario.NombreUsuario = Me.TextBox1.Text
                        oUsuario.Password = BLL.Encriptadora.EncriptarPass(Me.TextBox2.Text)
                        oUsuario.Nombre = Me.TextBox4.Text
                        oUsuario.Apellido = Me.TextBox5.Text
                        If bllUsuario.chequearUsuario(oUsuario) = False Then
                            Dim oIdioma As New EE.BE_Idioma
                            Dim bllIdioma As New BLL.BLL_Idioma
                            bllIdioma.consultarIdiomas()
                            oIdioma = bllIdioma.consultarIdiomas(CInt(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Idioma).id_idioma))
                            oUsuario.idioma = oIdioma
                            Dim oPerfil As New EE.BE_GrupoPermiso
                            oPerfil.Nombre = Me.TextBox1.Text
                            oPerfil = ControladorPermisos.RecorrerArbol(Nothing, oPerfil, Tree)
                            oUsuario.Perfil = oPerfil
                                bllUsuario.altaUsuario(oUsuario)
                            MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_109"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Throw New nombreRepetidoException
                        End If

                    Else
                        Throw New PasswordCortoException
                    End If
                Else
                    Throw New PasswordnoCoincidenException
                End If
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As nombreRepetidoException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As PasswordnoCoincidenException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As PasswordCortoException
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

    Private Sub Agregar_Usuario_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Usuario")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub
End Class