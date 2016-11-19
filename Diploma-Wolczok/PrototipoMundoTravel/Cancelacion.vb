Imports EE
Imports BLL

Public Class Cancelacion
    Dim bllCancel As New BLL.BLL_Cancelacion
    Protected Friend paramCancelacion As EE.BE_Cancelacion

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
                DataGridView1.Columns.Clear()
                DataGridView1.Rows.Clear()
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.Columns.Add("viaje", "Destino")
                DataGridView1.Columns.Add("asiento", "Numero de Asiento")
                'DataGridView1.Columns.Add("ID", "Identificador de Reserva")
                DataGridView1.Columns.Add("NumeroReserva", "Numero de Reserva")
                DataGridView1.Columns.Add("Detalle", "Detalle de Reserva")
                DataGridView1.Columns.Add("Estado", "Estado")
                DataGridView1.Columns.Add("Pasajero", "Pasajero")
                DataGridView1.Columns.Add("Puntaje", "Puntaje Acumulado")
                For Each item In oListareserva
                    DataGridView1.Rows.Add(item.viaje, item.Asiento, item.NumeroReserva, item.Detalle, item.Estado, item.Pasajero, item.puntaje)
                Next

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancelacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oCancel As New BE_Cancelacion
            Dim bllReserva As New BLL.BLL_Reserva
            '  oCancel = bllReserva.calcularPunitorios()
            paramCancelacion = oCancel
            'CARGAS LOS TEXTBOX CON LOS VALORES DE LA POSIBLE CANCELACION

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim ocancel As BE_Cancelacion = paramCancelacion
            ocancel.Fechacancelacion = Today
            '        ocancel.DescripcionMotivoCancelacion =
            bllCancel.alta(ocancel)
        Catch ex As Exception

        End Try
    End Sub
End Class