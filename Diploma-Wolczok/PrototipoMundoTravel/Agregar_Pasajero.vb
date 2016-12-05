Imports BLL
Imports EE

Public Class Agregar_Pasajero
    Implements BLL_Iobservador

    Private Sub Agregar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As Exception

        End Try
    End Sub

    Private Function validarformulario() As Boolean
        Try
            If String.IsNullOrWhiteSpace(Me.Txtnombre.Text) Or String.IsNullOrWhiteSpace(Me.Txtapellido.Text) Or String.IsNullOrWhiteSpace(Me.Txttelefono.Text) Or String.IsNullOrWhiteSpace(Me.Txtdomicilio.Text) Or String.IsNullOrWhiteSpace(Me.Txtcorreo.Text) Or String.IsNullOrWhiteSpace(Me.Txtdni.Text) Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarformulario() = True Then
                Dim oPasajero As New BE_Pasajero
                Dim bllPasajero As New BLL_Pasajero
                oPasajero.Nombre = Txtnombre.Text
                oPasajero.Apellido = Txtapellido.Text
                oPasajero.CorreoElectronico = Txtcorreo.Text
                oPasajero.DNI = Txtdni.Text
                oPasajero.Domicilio = Txtdomicilio.Text
                oPasajero.Telefono = Txttelefono.Text
                bllPasajero.Altapasajero(oPasajero)
                MsgBox("Se ha agregado el pasajero correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Pasajero_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Pasajero")
    End Sub

    Private Sub Txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtapellido.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdni.KeyPress
        e.Handled = validacionTextBox.SoloNumeros(e)
    End Sub

    Private Sub Txtdomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdomicilio.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnombre.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub Txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txttelefono.KeyPress
        e.Handled = validacionTextBox.SoloNumeros(e)
    End Sub
End Class