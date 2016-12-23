Imports BLL
Imports EE


Public Class Cambiar_Password
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If validarPasswordRepetido() = True Then
                If validarLongitudPassword() = True Then
                    comprobarPassword()
                Else
                    Throw New PasswordCortoException
                End If
            Else
                Throw New CamposIncorrectosException
            End If
        Catch ex As PasswordIncorrectoException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As PasswordnoCoincidenException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As PasswordCortoException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function comprobarPassword()
        Dim oUsuario As New BE_Usuario
        oUsuario = SessionBLL.SesionActual.ObtenerUsuarioActual
        If oUsuario.Password = Encriptadora.EncriptarPass(Me.TextBox2.Text) Then
            oUsuario.Password = Encriptadora.EncriptarPass(Me.TextBox1.Text)
            Dim bllUsuario As New BLL_Usuario
            bllUsuario.modificarPassword(oUsuario)
            MsgBox("Se ha modificado el password correctamente.", MsgBoxStyle.Information, "Accion Correcta")

        Else
            Throw New PasswordIncorrectoException
        End If
    End Function

    Private Function validarLongitudPassword()
        Try
            If Len(Me.TextBox3.Text) < 6 Then Return False
            Return True
        Catch ex As Exception
            Throw New PasswordCortoException
        End Try
    End Function

    Private Function validarPasswordRepetido()
        Try
            If Me.TextBox1.Text <> Me.TextBox3.Text Then Return False
            Return True
        Catch ex As Exception
            Throw New PasswordnoCoincidenException
        End Try
    End Function
End Class