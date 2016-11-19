Public Class Eliminar_Permiso

    Private Sub EliminarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControladorPermisos.CargarPermisos(ComboBox1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))
    End Sub




    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(ComboBox1.SelectedItem) Then
                Dim Perfil As EE.BE_GrupoPermiso = DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso)
                Dim GestorPermisos As New BLL.BLL_GestorPermiso

                GestorPermisos.Baja(Perfil.ID)
                ControladorPermisos.CargarPermisos(ComboBox1)
                Tree.Nodes.Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class