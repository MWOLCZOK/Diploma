Imports EE
Imports BLL

Public Class Agregar_Habitacion
    Implements BLL_Iobservador

    Private Sub Agregar_Habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llenarCombos()
        Try
            Dim oListaAlojamientos As New List(Of BE_Alojamiento)
            Dim bblAlojamiento As New BLL_Alojamiento
            oListaAlojamientos = bblAlojamiento.consultarAlojamientos()
            For Each miAloja As BE_Alojamiento In oListaAlojamientos
                Me.ComboBox1.Items.Add(miAloja)
                ComboBox1.DisplayMember = "Nombre"
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Private Function validarFormulario() As Boolean
        'Valores Numericos Correctos
        If String.IsNullOrWhiteSpace(Me.TextBox1.Text) Then Return False
        'Combo Box sin Seleccion
        If IsNothing(ComboBox1.SelectedItem) Then Return False
        Return True
    End Function

    Private Function validarCampos() As Boolean
        If Me.NumericUpDown1.Value <= 0 Then Return False
        If Me.NumericUpDown2.Value <= 0 Then Return False
        Return True
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If validarFormulario() = True Then
                If validarCampos() = True Then
                    Dim oHabitacion As New EE.BE_Habitacion
                    oHabitacion.Descripcion = Me.TextBox1.Text
                    oHabitacion.CantidadCamas = Me.NumericUpDown1.Value
                    oHabitacion.CantidadPersonas = Me.NumericUpDown2.Value
                    oHabitacion.Alojamiento = DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Alojamiento)
                    Dim bllHabitacion As New BLL.BLL_Habitacion
                    bllHabitacion.altaHabitacion(oHabitacion)
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_101"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw New CamposIncorrectosException
                End If
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncorrectosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnInsertException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Agregar_Habitacion_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Agregar Habitación")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)

    End Sub
End Class