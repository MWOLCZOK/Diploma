Imports BLL
Imports EE

Public Class Modificar_Pasajero

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Modificar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Public Sub Iniciar()
        Try
            Cbxpasajero.SelectedItem = Nothing
            Cbxpasajero.Items.Clear()
            Txtnombre.Text = ""
            Txapellido.Text = ""
            Txtcorreo.Text = ""
            Txtdni.Text = ""
            Txtdomicilio.Text = ""
            Txtpuntajealoj.Text = ""
            Txtpuntajeviaje.Text = ""
            Txttelefono.Text = ""
            Txtreserva.Text = ""
            Dim Gestorpas As New BLL_Pasajero
            Dim Listapas = Gestorpas.consultarPasajeros()
            For Each pas In Listapas
                Cbxpasajero.Items.Add(pas)
                Cbxpasajero.DisplayMember = "NombreApellido"

            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Cbxpasajero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpasajero.SelectedIndexChanged

        If Not IsNothing(Cbxpasajero.SelectedItem) Then
            Dim NuevoPas As BE_Pasajero = New BE_Pasajero
            NuevoPas = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
            Me.Txtnombre.Text = NuevoPas.Nombre
            Me.Txapellido.Text = NuevoPas.Apellido
            Me.Txtcorreo.Text = NuevoPas.CorreoElectronico
            Me.Txtdni.Text = NuevoPas.DNI
            Me.Txtdomicilio.Text = NuevoPas.Domicilio
            Me.Txtpuntajealoj.Text = NuevoPas.PuntajeAlojamiento
            Me.Txtpuntajeviaje.Text = NuevoPas.PuntajeViaje
            Me.Txttelefono.Text = NuevoPas.Telefono
            Me.Txtreserva.Text = NuevoPas.Reserva
        End If

    End Sub


    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim GestorPas As New BLL_Pasajero
        Dim pasmodificar As New BE_Pasajero
        Try
            If Not IsNothing(Cbxpasajero.SelectedItem) Then
                If Not IsNothing(Cbxpasajero.SelectedItem) And Not String.IsNullOrWhiteSpace(Txtnombre.Text) And Not String.IsNullOrWhiteSpace(Txapellido.Text) And Not String.IsNullOrWhiteSpace(Txtcorreo.Text) And Not String.IsNullOrWhiteSpace(Txtdni.Text) And Not String.IsNullOrWhiteSpace(Txtdomicilio.Text) And Not String.IsNullOrWhiteSpace(Txtpuntajealoj.Text) And Not String.IsNullOrWhiteSpace(Txtpuntajeviaje.Text) And Not String.IsNullOrWhiteSpace(Txttelefono.Text) And Not String.IsNullOrWhiteSpace(Txtreserva.Text) Then
                    pasmodificar = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
                    pasmodificar.ID = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero).ID
                    pasmodificar.Nombre = Txtnombre.Text
                    pasmodificar.Apellido = Txapellido.Text
                    pasmodificar.CorreoElectronico = Txtcorreo.Text
                    pasmodificar.DNI = Txtdni.Text
                    pasmodificar.Domicilio = Txtdomicilio.Text
                    pasmodificar.PuntajeAlojamiento = Txtpuntajealoj.Text
                    pasmodificar.PuntajeViaje = Txtpuntajeviaje.Text
                    pasmodificar.Telefono = Txttelefono.Text
                    pasmodificar.Reserva = Txtreserva.Text
                    GestorPas.modificarPasajero(pasmodificar)
                    Iniciar()
                    MessageBox.Show("Se ha modificado el pasajero de manera satisfactoria")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class