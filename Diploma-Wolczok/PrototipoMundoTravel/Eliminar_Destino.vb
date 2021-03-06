﻿Imports EE
Imports BLL

Public Class Eliminar_Destino
    Implements BLL.BLL_Iobservador

    Private Sub Eliminar_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarcombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llenarcombos()
        Try
            Dim oListaDestinos As New List(Of BE_Destino)
            Dim bllDestino As New BLL_Destino
            oListaDestinos = bllDestino.consultarDestinos
            For Each miDest As BE_Destino In oListaDestinos
                Me.CbxDestino.Items.Add(miDest)
                CbxDestino.DisplayMember = "NombreCompleto"
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(CbxDestino.SelectedItem) Then
                Dim bllDestino As New BLL_Destino
                Dim oDestino As BE_Destino = New BE_Destino
                oDestino = DirectCast(CbxDestino.SelectedItem, BE_Destino)
                bllDestino.eliminarDestino(oDestino)
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_113"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnDeleteException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Eliminar_Destino_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested

        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Eliminar Destino")
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub
End Class