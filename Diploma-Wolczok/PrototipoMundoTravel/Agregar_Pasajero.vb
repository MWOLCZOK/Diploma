Imports BLL
Imports EE

Public Class Agregar_Pasajero

    Private Sub Agregar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function validarformulario() As Boolean
        Try
            If Me.Txtnombre.Text = "" Or Me.Txtapellido.Text = "" Or Me.Txtcorreo.Text = "" Or Me.Txtdni.Text = "" Or Me.Txtdomicilio.Text = "" Or Me.Txtpuntajealoj.Text = "" Or Me.Txtpuntajeviaje.Text = "" Or Me.Txttelefono.Text = "" Or Me.Txtreserva.Text = "" Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function




    Private Sub Btn_agregarpasajero_Click(sender As Object, e As EventArgs) Handles Btn_agregarpasajero.Click
        Try
            If validarformulario() = True Then
                Dim oPasajero As New BE_Pasajero
                Dim bllPasajero As New BLL_Pasajero
                oPasajero.Nombre = Txtnombre.Text
                oPasajero.Apellido = Txtapellido.Text
                oPasajero.CorreoElectronico = Txtcorreo.Text
                oPasajero.DNI = Txtdni.Text
                oPasajero.Domicilio = Txtdomicilio.Text
                oPasajero.PuntajeAlojamiento = Txtpuntajealoj.Text
                oPasajero.PuntajeViaje = Txtpuntajeviaje.Text
                oPasajero.Telefono = Txttelefono.Text
                oPasajero.Reserva = Txtreserva.Text
                bllPasajero.Altapasajero(oPasajero)
                MsgBox("Se ha agregado correctamente el pasajero")
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
End Class