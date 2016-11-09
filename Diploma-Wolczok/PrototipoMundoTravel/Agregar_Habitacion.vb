Imports EE
Imports BLL

Public Class Agregar_Habitacion
    Private Sub Agregar_Habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
    End Sub

    Private Sub llenarCombos()
        Dim oListaAlojamientos As New List(Of BE_Alojamiento)
        Dim bblAlojamiento As New BLL_Alojamiento
        oListaAlojamientos = bblAlojamiento.consultarAlojamientos()
        For Each miAloja As BE_Alojamiento In oListaAlojamientos
            Me.ComboBox1.Items.Add(miAloja)
            ComboBox1.DisplayMember = "Nombre"
        Next
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim oHabitacion As New EE.BE_Habitacion
            oHabitacion.Descripcion = Me.TextBox1.Text
            oHabitacion.CantidadCamas = Me.NumericUpDown1.Value
            oHabitacion.CantidadPersonas = Me.NumericUpDown2.Value
            oHabitacion.Alojamiento = DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Alojamiento)
            Dim bllHabitacion As New BLL.BLL_Habitacion
            bllHabitacion.altaHabitacion(oHabitacion)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class