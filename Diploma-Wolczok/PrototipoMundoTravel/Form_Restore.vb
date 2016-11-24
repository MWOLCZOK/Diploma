Imports BLL

Public Class Form_Restore
    Implements BLL_Iobservador

    Private Sub Form_Restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.OpenFileDialog1.ShowDialog()
        TextBox4.Text = Me.OpenFileDialog1.FileName
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            Dim oBack As New EE.BE_BackupRestore(TextBox4.Text)
            Dim bBack As New BLL.BLL_BackupRestore()
            If bBack.RealizarRestore(oBack) = True Then
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_27"), ControladorTraductor.TraducirMensaje("Titulo_06"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Owner.Hide()
                Me.Owner.Close()
                Me.Close()
            Else
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_25"), ControladorTraductor.TraducirMensaje("Titulo_05"), MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex)


        End Try

    End Sub

    Private Sub Form_Restore_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Realizar Restore")
    End Sub
End Class