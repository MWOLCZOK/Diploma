Imports EE
Imports BLL

Public Class Cancelacion

    Private Sub Txtdni_TextChanged(sender As Object, e As EventArgs) Handles Txtdni.TextChanged
        Try
            If Txtdni.Text.Length >= 3 Then
                Dim oPasajero As New BE_Pasajero
                Dim oReservaviaje As New BE_ReservaViaje
                oPasajero.DNI = Me.Txtdni.Text
                'oReservaviaje.Pasajero = oPasajero
                Dim bllReservaViaje As New BLL_Reserva
                Dim oListareserva As New List(Of BE_ReservaViaje)
                oListareserva = bllReservaViaje.consultarReservaViajeporDNI(oPasajero)
                Me.DataGridView1.DataSource = Nothing
                Me.DataGridView1.DataSource = oListareserva
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancelacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Nothing
    End Sub
End Class