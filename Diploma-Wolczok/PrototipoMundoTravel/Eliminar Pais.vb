Imports EE
Imports BLL

Public Class Eliminar_Pais

    Private Sub Eliminar_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()

    End Sub

    Public Sub iniciar()
        Try
            CbxPais.SelectedItem = Nothing
            CbxPais.Items.Clear()
            CbxPais.Text = ""
            Dim GestorPais As BLL_Pais = New BLL_Pais
            Dim ListaPais = GestorPais.ConsultarPaises()
            For Each Pai In ListaPais
                CbxPais.Items.Add(Pai)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(CbxPais.SelectedItem) Then
                Dim GestorPais As BLL_Pais = New BLL_Pais
                Dim NuevoPais As BE_Pais = New BE_Pais
                NuevoPais = DirectCast(CbxPais.SelectedItem, BE_Pais)
                GestorPais.eliminarPais(NuevoPais)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_30"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_31"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub
End Class