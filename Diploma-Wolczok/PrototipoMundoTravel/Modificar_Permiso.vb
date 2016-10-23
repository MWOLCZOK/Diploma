Public Class Modificar_Permiso

    Private Sub ModificarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControladorPermisos.CargarPermisos(ComboBox1)
        ControladorPermisos.CargarPermisos(TreeNuevos)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If Not IsNothing(ComboBox1.SelectedItem) Then
            Dim Perfil As EE.BE_GrupoPermiso = DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso)
            Perfil.BorrarHijos()
            Perfil = ControladorPermisos.RecorrerArbol(Nothing, Perfil, TreeNuevos)
            If Perfil.Hijos.Count <> 0 Then
                Dim GestorPermisos As New BLL.BLL_GestorPermiso
                GestorPermisos.Modificar(Perfil)
                'MessageBox.Show("Se Modificó el Perfil de manera satisfactoria.", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ControladorPermisos.CargarPermisos(Tree, DirectCast(ComboBox1.SelectedItem, EE.BE_GrupoPermiso))
                ControladorPermisos.CargarPermisos(TreeNuevos)
            Else
                'MessageBox.Show("Debe seleccionar al menos un permiso, que no sea el mismo a modificar, para continuar.", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ControladorPermisos.CargarPermisos(ComboBox1)
                Tree.Nodes.Clear()
                ControladorPermisos.CargarPermisos(TreeNuevos)
            End If
        End If
    End Sub
End Class