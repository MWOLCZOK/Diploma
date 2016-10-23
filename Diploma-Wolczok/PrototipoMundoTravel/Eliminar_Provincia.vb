Imports BLL
Imports EE



Public Class Eliminar_Provincia

    Private Sub Eliminar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()

    End Sub

    Public Sub iniciar()
        Try
            CbxProvincia.SelectedItem = Nothing
            CbxProvincia.Items.Clear()
            CbxProvincia.Text = ""
            Dim GestorProvincia As BLL_Provincia = New BLL_Provincia
            Dim Listaprov = GestorProvincia.Consultarprovincias
            For Each prov In Listaprov
                CbxProvincia.Items.Add(prov)
            Next
        Catch ex As Exception
        End Try
    End Sub



    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(CbxProvincia.SelectedItem) Then
                Dim GestorProv As BLL_Provincia = New BLL_Provincia
                Dim NuevaProv As BE_Provincia = New BE_Provincia
                NuevaProv = DirectCast(CbxProvincia.SelectedItem, BE_Provincia)
                GestorProv.eliminarprovincia(NuevaProv)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_33"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_32"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub
End Class