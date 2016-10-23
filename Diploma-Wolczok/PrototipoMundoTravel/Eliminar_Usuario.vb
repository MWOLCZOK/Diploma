Public Class Eliminar_Usuario

    Private Sub Eliminar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Public Sub iniciar()
        CbxUsuario.SelectedItem = Nothing
        CbxUsuario.Items.Clear()
        Try

            Dim GestorUsuario As New BLL.BLL_Usuario
            Dim ListaUsuarios = GestorUsuario.consultarUsuarios()
            For Each Usu In ListaUsuarios
                If Not Usu.ID = BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.ID Then
                    CbxUsuario.Items.Add(Usu)
                End If
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Not IsNothing(CbxUsuario.SelectedItem) Then
            Dim GestorUsuario As New BLL.BLL_Usuario
            Dim NuevoUsuario As New EE.BE_Usuario
            NuevoUsuario = DirectCast(CbxUsuario.SelectedItem, EE.BE_Usuario)
            GestorUsuario.eliminarUsuario(NuevoUsuario)
            If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_28"), ControladorTraductor.TraducirMensaje("Titulo_07"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                iniciar()
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_29"), ControladorTraductor.TraducirMensaje("Titulo_07"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub CbxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxUsuario.SelectedIndexChanged

    End Sub
End Class
