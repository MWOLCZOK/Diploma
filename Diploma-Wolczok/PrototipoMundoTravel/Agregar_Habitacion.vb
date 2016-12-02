Imports EE
Imports BLL

Public Class Agregar_Habitacion
    Implements BLL_Iobservador

    Private Sub Agregar_Habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub llenarCombos()
        Dim oListaAlojamientos As New List(Of BE_Alojamiento)
        Dim bblAlojamiento As New BLL_Alojamiento
        oListaAlojamientos = bblAlojamiento.consultarAlojamientos()
        For Each miAloja As BE_Alojamiento In oListaAlojamientos
            Me.ComboBox1.Items.Add(miAloja)
            ComboBox1.DisplayMember = "Nombre"
        Next
    End Sub

    Private Function validarFormulario() As Boolean
        'Valores Numericos Correctos

        If String.IsNullOrWhiteSpace(Me.TextBox1.Text) Then Return False

        'Combo Box sin Seleccion
        If IsNothing(ComboBox1.SelectedItem) Then Return False

        Return True
    End Function


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If validarFormulario() = True Then
                Dim oHabitacion As New EE.BE_Habitacion
                oHabitacion.Descripcion = Me.TextBox1.Text
                oHabitacion.CantidadCamas = Me.NumericUpDown1.Value
                oHabitacion.CantidadPersonas = Me.NumericUpDown2.Value
                oHabitacion.Alojamiento = DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Alojamiento)
                Dim bllHabitacion As New BLL.BLL_Habitacion
                bllHabitacion.altaHabitacion(oHabitacion)
                MsgBox("Se ha agregado la habitación correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
            Else
                '  MsgBox("Debe seleccionar un alojamiento", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception

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
End Class