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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oHabitacion As New EE.BE_Habitacion
        oHabitacion.CantidadPersonas = Me.NumericUpDown1.Value
        oHabitacion.CantidadCamas = Me.NumericUpDown2.Value
        oHabitacion.Alojamiento = DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Alojamiento)
        Dim bllHabitacion As New BLL.BLL_Habitacion
        bllHabitacion.altaHabitacion(oHabitacion)
    End Sub
End Class