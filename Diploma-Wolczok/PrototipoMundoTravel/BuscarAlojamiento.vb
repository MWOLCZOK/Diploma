Public Class BuscarAlojamiento

    Private Sub BuscarAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub

    Private Sub cargarCombos()
        Dim oListaDestino As New List(Of EE.BE_Destino)
        Dim bllDestino As New BLL.BLL_Destino
        oListaDestino = bllDestino.consultarDestinos
        For Each miDestino As EE.BE_Destino In oListaDestino
            Me.ComboBox1.Items.Add(miDestino)
            ComboBox1.DisplayMember = "NombreCompleto"
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oListaAlojamiento As New List(Of EE.BE_Alojamiento)
            Dim bllAlojamiento As New BLL.BLL_Alojamiento
            oListaAlojamiento = bllAlojamiento.consultarAlojamiento(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Destino), Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Catch ex As Exception

        End Try
    End Sub
End Class