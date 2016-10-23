Public Class Eliminar_Idioma
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                Dim Idioma As EE.BE_Idioma = DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma)
                Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                GestorIdioma.EliminarIdioma(Idioma)
                Iniciar()
            Else
            End If

        Catch ex As Exception
        End Try
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

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class