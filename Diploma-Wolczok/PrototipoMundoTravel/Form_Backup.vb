Imports BLL

Public Class Form_Backup

    Implements BLL_Iobservador

    Private Sub Form_Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox3.Text = FolderBrowserDialog1.SelectedPath


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub




    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Dim oBack As New EE.BE_BackupRestore(TextBox3.Text, TextBox2.Text)
            Dim bBack As New BLL.BLL_BackupRestore()
            If bBack.RealizarBackup(oBack) = True Then
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_26"), ControladorTraductor.TraducirMensaje("Titulo_06"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_25"), ControladorTraductor.TraducirMensaje("Titulo_05"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class