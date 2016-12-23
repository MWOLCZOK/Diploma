Imports EE
Imports BLL

Public Class Agregar_Localidad
    Implements BLL_Iobservador


    Private Sub Agregar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cargarCombos()
        Try
            Dim oListaProvincia As New List(Of EE.BE_Provincia)
            Dim bllProvincia As New BLL.BLL_Provincia
            oListaProvincia = bllProvincia.Consultarprovincias
            For Each miProv As EE.BE_Provincia In oListaProvincia
                Me.ComboBox1.Items.Add(miProv)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Private Function validarFormulario() As Boolean
        Try
            If String.IsNullOrWhiteSpace(Me.txtHabitantes.Text) Or String.IsNullOrWhiteSpace(Me.Txtdescripcion.Text) Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarFormulario() = True Then
                Dim oLoc As New BE_Localidad
                Dim bllLoc As New BLL_Localidad
                oLoc.Descripcion = Me.Txtdescripcion.Text
                oLoc.CantidadBarrios = Me.NumericUpDown1.Value
                oLoc.Habitantes = Me.txtHabitantes.Text
                Dim oProvincia As New BE_Provincia
                oProvincia.ID = DirectCast(ComboBox1.SelectedItem, BE_Provincia).ID
                oLoc.Provincia = oProvincia
                bllLoc.altalocalidad(oLoc)
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_102"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Throw New CamposIncompletosException
            End If
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

    Private Sub Agregar_Localidad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alta de Localidad")
    End Sub

    Private Sub Txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdescripcion.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)
    End Sub

    Private Sub txtHabitantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHabitantes.KeyPress
        e.Handled = validacionTextBox.SoloNumeros(e)
    End Sub
End Class