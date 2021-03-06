﻿Imports EE
Imports BLL


Public Class Agregar_Permisos
    Implements BLL_Iobservador

    Private Sub gestionPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControladorPermisos.CargarPermisos(Tree)
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
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
    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtnombre.Text) Then
                Dim Perfil As New EE.BE_GrupoPermiso
                Perfil.Nombre = txtnombre.Text
                Perfil = ControladorPermisos.RecorrerArbol(Nothing, Perfil, Tree)
                If Perfil.Hijos.Count <> 0 Then
                    Dim GestorPermisos As New BLL.BLL_GestorPermiso
                    If GestorPermisos.chequearNombre(Perfil) = False Then
                        GestorPermisos.Alta(Perfil)
                        ControladorPermisos.CargarPermisos(Tree)
                        txtnombre.Text = ""
                        MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_106"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Throw New nombreRepetidoException
                    End If
                Else
                    Throw New CamposIncompletosException
                End If
            Else
            End If
        Catch ex As nombreRepetidoException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnInsertException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Permisos_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Perfil")
    End Sub
End Class