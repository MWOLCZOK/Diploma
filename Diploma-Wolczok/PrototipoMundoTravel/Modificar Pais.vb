Imports BLL
Imports EE


Public Class Modificar_Pais

    Private Sub Modificar_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Public Sub Iniciar()
        Try
            Cbxpais.SelectedItem = Nothing
            Cbxpais.Items.Clear()
            Txtdescripcion.Text = ""
            Txtidioma.Text = ""
            Txtpoblacion.Text = ""
            Txtzonahoraria.Text = ""
            Txtprovincia.Text = ""

            Dim GestorPais As New BLL_Pais
            Dim Listapaises = GestorPais.ConsultarPaises()
            For Each pai In Listapaises
                Cbxpais.Items.Add(pai)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cbxpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpais.SelectedIndexChanged
        If Not IsNothing(Cbxpais.SelectedItem) Then
            Dim NuevoPais As BE_Pais = New BE_Pais
            NuevoPais = DirectCast(Cbxpais.SelectedItem, BE_Pais)
            Me.Txtdescripcion.Text = NuevoPais.Descripcion
            Me.Txtidioma.Text = NuevoPais.Idioma
            Me.Txtpoblacion.Text = NuevoPais.Poblacion_total
            Me.Txtzonahoraria.Text = NuevoPais.Zonahoraria
            '       Me.Txtprovincia.Text = NuevoPais.Provincia
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim Gestorpais As BLL_Pais = New BLL_Pais
        Dim Paismodificar As BE_Pais = Nothing

        Try
            If Not IsNothing(Cbxpais.SelectedItem) Then
                If Not IsNothing(Cbxpais.SelectedItem) And Not String.IsNullOrWhiteSpace(Txtdescripcion.Text) And Not String.IsNullOrWhiteSpace(Txtidioma.Text) And Not String.IsNullOrWhiteSpace(Txtpoblacion.Text) And Not String.IsNullOrWhiteSpace(Txtzonahoraria.Text) And Not String.IsNullOrWhiteSpace(Txtprovincia.Text) Then
                    Paismodificar = DirectCast(Cbxpais.SelectedItem, BE_Pais)
                    Paismodificar.ID = DirectCast(Cbxpais.SelectedItem, BE_Pais).ID
                    Paismodificar.Descripcion = Txtdescripcion.Text
                    Paismodificar.Idioma = Txtidioma.Text
                    Paismodificar.Poblacion_total = Txtpoblacion.Text
                    Paismodificar.Zonahoraria = Txtzonahoraria.Text
                    '             Paismodificar.Provincia = Txtprovincia.Text
                    Gestorpais.modificarPais(Paismodificar)
                    Iniciar()
                    MessageBox.Show("Se ha modificado el pais de manera satisfactoria")
                    'MessageBox.Show("No se ha logrado modificadr el pais")
                End If
            End If
            'End If

        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class