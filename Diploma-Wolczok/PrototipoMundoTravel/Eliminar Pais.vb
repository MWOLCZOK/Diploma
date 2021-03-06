﻿Imports EE
Imports BLL

Public Class Eliminar_Pais
    Implements BLL.BLL_Iobservador

    Private Sub Eliminar_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub iniciar()
        Try
            CbxPais.SelectedItem = Nothing
            CbxPais.Items.Clear()
            CbxPais.Text = ""
            Dim GestorPais As BLL_Pais = New BLL_Pais
            Dim ListaPais = GestorPais.ConsultarPaises()
            For Each Pai In ListaPais
                CbxPais.Items.Add(Pai)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not IsNothing(CbxPais.SelectedItem) Then
                Dim GestorPais As BLL_Pais = New BLL_Pais
                Dim NuevoPais As BE_Pais = New BE_Pais
                NuevoPais = DirectCast(CbxPais.SelectedItem, BE_Pais)
                GestorPais.eliminarPais(NuevoPais)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_30"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_31"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Throw New errorEnDeleteException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnDeleteException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Eliminar_Pais_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested

        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Eliminar País")
    End Sub
End Class