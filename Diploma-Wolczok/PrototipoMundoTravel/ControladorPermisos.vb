Imports BLL
Imports EE
Public Class ControladorPermisos
    Public Shared Sub CargarPermisos(ByRef Tree As TreeView, Optional Permisos As BE_GrupoPermiso = Nothing)
        Try
            If Tree.GetNodeCount(True) = 0 Then
                Dim gestorpermisos As BLL_GestorPermiso = New BLL_GestorPermiso
                If IsNothing(Permisos) Then

                    Dim lista = gestorpermisos.ListarPermisos()
                    ArmarArbol(lista, Nothing, Tree)
                    Tree.CollapseAll()
                Else
                    ArmarArbol(Permisos.Hijos, Nothing, Tree)
                    Tree.CollapseAll()
                End If

            Else
                If IsNothing(Permisos) Then
                    Tree.Nodes.Clear()
                    CargarPermisos(Tree)
                Else
                    Tree.Nodes.Clear()
                    CargarPermisos(Tree, Permisos)
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub CargarPermisos(ByRef Combo As ComboBox)
        Try
            Combo.Items.Clear()
            Dim gestorpermisos As BLL_GestorPermiso = New BLL_GestorPermiso
            Dim lista = gestorpermisos.ListarFamilias(True)
            For Each Perfil In lista
                Combo.Items.Add(Perfil)
            Next
            Combo.Text = ""
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Shared Sub ArmarArbol(lista As List(Of BE_PermisoBase), ByRef arbol As TreeNode, ByRef Tree As TreeView)
        If IsNothing(arbol) Then
            For Each Permiso In lista
                Dim nodo As TreeNode = New TreeNode With {.Name = Permiso.Nombre, .Text = Permiso.Nombre, .Tag = Permiso}
                Tree.Nodes.Add(nodo)
                If Permiso.tieneHijos Then
                    Dim GrupoPermiso = DirectCast(Permiso, BE_GrupoPermiso)
                    ArmarArbol(GrupoPermiso.Hijos, nodo, Tree)
                End If
            Next
        Else
            For Each Permiso2 In lista
                Dim nodosegundo = New TreeNode With {.Name = Permiso2.Nombre, .Text = Permiso2.Nombre, .Tag = Permiso2}
                arbol.Nodes.Add(nodosegundo)
                If Permiso2.tieneHijos Then
                    Dim GrupoPermiso = DirectCast(Permiso2, BE_GrupoPermiso)
                    ArmarArbol(GrupoPermiso.Hijos, nodosegundo, Tree)
                End If
            Next
        End If
    End Sub

    Public Shared Sub CheckChildNodes(ByVal iNode As TreeNode)
        Try
            UnCheckParentNodes(iNode)
            For Each sNode As TreeNode In iNode.Nodes
                sNode.Checked = iNode.Checked
                CheckChildNodes(sNode)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Shared Sub UnCheckParentNodes(ByVal iNode As TreeNode)
        Try
            If iNode.Checked = False AndAlso iNode.Parent IsNot Nothing Then
                iNode.Parent.Checked = False
                UnCheckParentNodes(iNode.Parent)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Shared Function Estagrupo(ByRef permisobase As BE_GrupoPermiso, ByRef listaretorno As List(Of BE_PermisoBase)) As Boolean
        For Each permiso In listaretorno
            If permiso.Nombre = permisobase.Nombre Then
                Return False
            Else
                Dim grpo As BE_GrupoPermiso
                If permiso.tieneHijos Then
                    grpo = DirectCast(permiso, BE_GrupoPermiso)
                    If Not IsNothing(grpo.Hijos) Then
                        If Estagrupo(permisobase, grpo.Hijos) = False Then
                            Return False
                        End If
                    End If
                Else
                    If Not IsNothing(permisobase.Hijos) Then
                        If EstaComun(permiso, permisobase.Hijos) = False Then
                            Return False
                        End If
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Private Shared Function EstaComun(ByRef permisobase As BE_Permiso, ByRef listaretorno As List(Of BE_PermisoBase)) As Boolean
        For Each permiso In listaretorno
            If permiso.Nombre = permisobase.Nombre Then
                Return False
            Else
                If permiso.tieneHijos Then
                    Dim grpo = DirectCast(permiso, BE_GrupoPermiso)
                    If EstaComun(permisobase, grpo.Hijos) = False Then
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Public Shared Function RecorrerArbol(ByRef arbol As TreeNode, ByRef Compuesto As BE_GrupoPermiso, ByRef Tree As TreeView) As BE_GrupoPermiso
        If IsNothing(arbol) Then
            For Each nodo As TreeNode In Tree.Nodes
                If nodo.Checked = True Then
                    Dim Permiso As BE_PermisoBase
                    Permiso = TryCast(nodo.Tag, BE_GrupoPermiso)
                    If IsNothing(Permiso) Then
                        Permiso = TryCast(nodo.Tag, BE_Permiso)
                    End If

                    If Permiso.tieneHijos = False Then
                        Compuesto.agregarHijo(Permiso)
                    Else

                        Dim Grupo As BE_GrupoPermiso = Permiso
                        If Not Grupo.esValido(Compuesto.Nombre) Then
                            AgregarHijos(nodo, Grupo.Hijos, True, Compuesto)
                            Compuesto.agregarHijo(Grupo)
                        Else
                            Grupo.BorrarHijos()
                        End If
                    End If
                Else
                    RecorrerArbol(nodo, Compuesto, Tree)
                End If
            Next
        Else
            For Each nodo2 As TreeNode In arbol.Nodes
                If nodo2.Checked = True Then
                    If nodo2.Nodes.Count <> 0 Then
                        Dim Grupo As BE_GrupoPermiso = (DirectCast(nodo2.Tag, BE_GrupoPermiso))
                        Grupo.BorrarHijos()
                        AgregarHijos(nodo2, Grupo.Hijos, True, Compuesto)
                        Compuesto.agregarHijo(Grupo)
                    Else
                        Dim Permiso As BE_Permiso = (DirectCast(nodo2.Tag, BE_Permiso))
                        Compuesto.agregarHijo(Permiso)


                    End If
                Else
                    If nodo2.Nodes.Count <> 0 Then
                        RecorrerArbol(nodo2, Compuesto, Tree)
                    End If
                End If
            Next

        End If
        Return Compuesto
    End Function

    Private Shared Function AgregarHijos(ByRef arbol As TreeNode, ByRef lista As List(Of BE_PermisoBase), ByVal filtro As Boolean, ByVal Compuesto As BE_GrupoPermiso) As List(Of BE_PermisoBase)
        For Each nodo As TreeNode In arbol.Nodes
            If nodo.Checked = filtro Then
                If nodo.Nodes.Count <> 0 Then
                    Dim grupo As BE_GrupoPermiso = (DirectCast(nodo.Tag, BE_GrupoPermiso))
                    If Not grupo.esValido(Compuesto.Nombre) Then
                        grupo.Nombre = nodo.Text
                        AgregarHijos(nodo, grupo.Hijos, filtro, Compuesto)
                        lista.Add(grupo)
                    End If
                Else
                    Dim Permiso As BE_Permiso = (DirectCast(nodo.Tag, BE_Permiso))
                    Permiso.Nombre = nodo.Text
                    lista.Add(Permiso)

                End If
            End If
        Next
        Return lista
    End Function
End Class
