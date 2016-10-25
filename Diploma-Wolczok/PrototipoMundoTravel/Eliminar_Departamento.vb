Imports BLL
Imports EE


Public Class Eliminar_Departamento

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()

    End Sub

    Public Sub iniciar()
        Try
            Cbxdepto.SelectedItem = Nothing
            Cbxdepto.Items.Clear()
            Cbxdepto.Text = ""
            Dim Gestordepto As BLL_Departamento = New BLL_Departamento
            Dim Listadepto = Gestordepto.consultardep
            For Each depto In Listadepto
                Cbxdepto.Items.Add(depto)
                Cbxdepto.DisplayMember = "Nombre"
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If Not IsNothing(Cbxdepto.SelectedItem) Then
                Dim Gestordepto As BLL_Departamento = New BLL_Departamento
                Dim NuevoDepto As BE_Departamento = New BE_Departamento
                NuevoDepto = DirectCast(Cbxdepto.SelectedItem, BE_Departamento)
                Gestordepto.eliminardep(NuevoDepto)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_36"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_37"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class