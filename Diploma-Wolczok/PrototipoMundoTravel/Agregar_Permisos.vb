Public Class Agregar_Permisos

    Private Sub gestionPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControladorPermisos.CargarPermisos(Tree)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Tree_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles Tree.AfterCheck
        If eventArgs.Action = TreeViewAction.ByKeyboard Or eventArgs.Action = TreeViewAction.ByMouse Then
            Try
                ControladorPermisos.CheckChildNodes(eventArgs.Node)

            Catch ex As Exception
            End Try

        End If
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtnombre.Text) Then
                Dim Perfil As New EE.BE_GrupoPermiso
                Perfil.Nombre = txtnombre.Text
                Perfil = ControladorPermisos.RecorrerArbol(Nothing, Perfil, Tree)
                If Perfil.Hijos.Count <> 0 Then
                    Dim GestorPermisos As New BLL.BLL_GestorPermiso
                    GestorPermisos.Alta(Perfil)
                    ControladorPermisos.CargarPermisos(Tree)
                    txtnombre.Text = ""
                End If
            Else
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class