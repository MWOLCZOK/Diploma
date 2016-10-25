Imports EE
Imports BLL

Public Class Eliminar_Destino
    Private Sub Eliminar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombos()
    End Sub

    Private Sub llenarcombos()
        Dim oListaDestinos As New List(Of be_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.CbxDestino.Items.Add(miDest)
            CbxDestino.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(CbxDestino.SelectedItem) Then
                Dim bllDestino As New BLL_Destino
                Dim oDestino As BE_Destino = New BE_Destino
                oDestino = DirectCast(CbxDestino.SelectedItem, BE_Destino)
                bllDestino.eliminarDestino(oDestino)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class