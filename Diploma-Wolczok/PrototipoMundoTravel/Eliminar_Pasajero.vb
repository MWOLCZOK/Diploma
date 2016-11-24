Imports BLL
Imports EE

Public Class Eliminar_Pasajero
    Implements BLL.BLL_Iobservador


    Private Sub Eliminar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub iniciar()
        Try
            Cbxpas.SelectedItem = Nothing
            Cbxpas.Items.Clear()
            Cbxpas.Text = ""
            Dim Gestorpas As BLL_Pasajero = New BLL_Pasajero
            Dim Listapas = Gestorpas.consultarPasajeros()
            For Each pas In Listapas
                Cbxpas.Items.Add(pas)
                Cbxpas.DisplayMember = "NombreCompleto"
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            If Not IsNothing(Cbxpas.SelectedItem) Then
                Dim Gestorpas As New BLL_Pasajero
                Dim Nuevopas As New BE_Pasajero
                Nuevopas = DirectCast(Cbxpas.SelectedItem, BE_Pasajero)

                Gestorpas.eliminarPasajero(Nuevopas)
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_34"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_35"), ControladorTraductor.TraducirMensaje("Titulo_09"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Eliminar_Pasajero_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Eliminar Pasajero")
    End Sub
End Class