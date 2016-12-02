Imports BLL
Imports EE

Public Class Agregar_Pasajero
    Implements BLL_Iobservador

    Private Sub Agregar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Function validarformulario() As Boolean
        Try
            If String.IsNullOrWhiteSpace(Me.Txtnombre.Text) Or String.IsNullOrWhiteSpace(Me.Txtapellido.Text) Or String.IsNullOrWhiteSpace(Me.Txttelefono.Text) Or String.IsNullOrWhiteSpace(Me.Txtdomicilio.Text) Or String.IsNullOrWhiteSpace(Me.Txtcorreo.Text) Or String.IsNullOrWhiteSpace(Me.Txtdni.Text) Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function




    Private Sub Btn_agregarpasajero_Click(sender As Object, e As EventArgs)

    End Sub


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
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("Error")
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
End Class