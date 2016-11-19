Public Class Eliminar_Idioma
    Private Sub btneliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub iniciar()
        Try
            CbxIdioma.SelectedItem = Nothing
            CbxIdioma.Items.Clear()
            Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
            Dim Listaidiomas = GestorIdioma.ConsultarIdiomasEditables()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                Dim Idioma As EE.BE_Idioma = DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma)
                Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                GestorIdioma.eliminarIdioma(Idioma)
                iniciar()
            Else
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class