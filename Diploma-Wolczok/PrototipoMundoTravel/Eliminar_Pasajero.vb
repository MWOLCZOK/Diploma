Imports BLL
Imports EE

Public Class Eliminar_Pasajero

    Private Sub Eliminar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Public Sub iniciar()
        Try
            Cbxpas.SelectedItem = Nothing
            Cbxpas.Items.Clear()
            Cbxpas.Text = ""
            Dim Gestorpas As BLL_Pasajero = New BLL_Pasajero
            Dim Listapas = Gestorpas.consultarPasajeros()
            For Each pas In Listapas
                Cbxpas.Items.Add(pas)
                Cbxpas.DisplayMember = "NombreCompleto"
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(Cbxpas.SelectedItem) Then
                Dim Gestorpas As New BLL_Pasajero
                Dim Nuevopas As New BE_Pasajero
                Nuevopas = DirectCast(Cbxpas.SelectedItem, BE_Pasajero)
                Gestorpas.eliminarPasajero(Nuevopas)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_34"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_35"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cbxpas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpas.SelectedIndexChanged

    End Sub
End Class