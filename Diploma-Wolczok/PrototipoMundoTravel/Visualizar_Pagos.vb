﻿Imports EE
Imports BLL



Public Class Visualizar_Pagos

    Private Sub Visualizar_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Try
            If TextBox9.Text.Length >= 3 Then
                Dim oPasajero As New BE_Pasajero
                Dim oReservaviaje As New BE_ReservaViaje
                Dim oPagoviaje As New BE_PagoViaje
                oPasajero.DNI = Me.TextBox9.Text
                oReservaviaje.Pasajero = oPasajero
                '             oReservaviaje. la puta madre.
                Dim oListapagoviaje As New List(Of BE_PagoViaje)
                Dim bllPagoviaje As New BLL_PagoViaje
                oListapagoviaje = bllPagoviaje.consultarPagosViajes(oPagoviaje)
                Me.DataGridView1.DataSource = Nothing
                Me.DataGridView1.DataSource = oListapagoviaje
                DataGridView1.ReadOnly = True
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class