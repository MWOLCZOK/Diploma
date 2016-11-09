Imports EE

Public Class Agregar_Destino

    Private Sub Agregar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcombos()
    End Sub

    Private Sub cargarcombos()
        Dim oListaLocalidad As New List(Of BE_Localidad)
        Dim bllLocalidad As New BLL.BLL_Localidad
        oListaLocalidad = bllLocalidad.consultarLocalidades

        For Each miLoc As BE_Localidad In oListaLocalidad
            Me.ComboBox1.Items.Add(miLoc)
            ComboBox1.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim oDestino As New BE_Destino
            Dim bllDestino As New BLL.BLL_Destino
            oDestino.Localidad = DirectCast(Me.ComboBox1.SelectedItem, BE_Localidad)
            oDestino.TieneAeropuerto = Me.CheckBox1.Checked
            bllDestino.altaDestino(oDestino)
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class