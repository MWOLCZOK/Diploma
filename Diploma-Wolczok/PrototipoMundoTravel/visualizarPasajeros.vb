Public Class visualizarPasajeros
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub visualizarPasajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Public Sub iniciar()
        Try
            Dim _bllPasajero As New BLL.BLL_Pasajero
            Dim listaPasajeros As New List(Of EE.BE_Pasajero)
            listaPasajeros = _bllPasajero.consultarPasajeros()
            Me.dgvBitacora.DataSource = listaPasajeros
            EstablecerGrid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EstablecerGrid()
        Me.dgvBitacora.Columns.Remove("ID_")
        Me.dgvBitacora.Columns("NombreCompleto").Name = "Column_NombreCompleto"
        Me.dgvBitacora.Columns("DNI").Name = "Column_DNI"
        Me.dgvBitacora.Columns("Telefono").Name = "Column_Telefono"
        Me.dgvBitacora.Columns("CorreoElectronico").Name = "Column_MAIL"
    End Sub

End Class