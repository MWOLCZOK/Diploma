Imports BLL
Imports EE

Public Class Modificar_Destino
    Private Sub Modificar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcombos()

    End Sub

    Private Sub cargarcombos()
        Dim oListaLocalidad As New List(Of BE_Localidad)
        Dim bllLocalidad As New BLL.BLL_Localidad
        oListaLocalidad = bllLocalidad.consultarLocalidades

        For Each miLoc As BE_Localidad In oListaLocalidad
            Me.ComboBox1.Items.Add(miLoc)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class