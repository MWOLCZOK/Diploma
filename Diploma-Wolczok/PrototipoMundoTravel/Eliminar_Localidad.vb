Imports BLL
Imports EE

Public Class Eliminar_Localidad

    Private Sub CbxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxLoc.SelectedIndexChanged

    End Sub

    Private Sub Eliminar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub


    Public Sub iniciar()
        Try
            CbxLoc.SelectedItem = Nothing
            CbxLoc.Items.Clear()
            CbxLoc.Text = ""
            Dim GestorLoc As BLL_Localidad = New BLL_Localidad
            Dim ListaLoc = GestorLoc.consultarLocalidades()
            For Each local In ListaLoc
                CbxLoc.Items.Add(local)
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            If Not IsNothing(CbxLoc.SelectedItem) Then
                Dim GestorLoc As New BLL_Localidad
                Dim NuevaLoc As New BE_Localidad
                NuevaLoc = DirectCast(CbxLoc.SelectedItem, BE_Localidad)
                GestorLoc.eliminarlocalidad(NuevaLoc)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_30"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_31"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class