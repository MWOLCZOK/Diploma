Imports System.ComponentModel
Imports BLL
Imports EE

Public Class Modificar_Localidad

    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
            cargarcombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub iniciar()
        Try
            Cbxloc.SelectedItem = Nothing
            Cbxloc.Items.Clear()
            Me.NumericUpDown1.Value = 0
            Me.txtHabitantes.Text = 0
            Dim GestorLoc As New BLL_Localidad
            Dim Listaloc = GestorLoc.consultarLocalidades()
            For Each local In Listaloc
                Cbxloc.Items.Add(local)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Public Sub cargarcombos()
        Try
            Dim Listaprov As New List(Of BE_Provincia)
            Dim bllListaprov As New BLL_Provincia
            Listaprov = bllListaprov.Consultarprovincias
            For Each miprov As BE_Provincia In Listaprov
                Me.Cbxprov.Items.Add(miprov)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub

    Private Sub Cbxloc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxloc.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxloc.SelectedItem) Then
                Dim Nuevaloc As BE_Localidad = New BE_Localidad
                Nuevaloc = DirectCast(Cbxloc.SelectedItem, BE_Localidad)
                Me.NumericUpDown1.Value = Nuevaloc.CantidadBarrios
                Me.txtHabitantes.Text = Nuevaloc.Habitantes
                For Each miProv As BE_Provincia In Cbxprov.Items
                    If miProv.ID = Nuevaloc.Provincia.ID Then
                        Cbxprov.SelectedItem = miProv
                    End If
                Next
            End If
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function validarFormulario() As Boolean
        If Me.Cbxloc.SelectedItem Is Nothing Then Return False
        Return True
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim GestorLoc As New BLL_Localidad
        Dim Locmodificar As New BE_Localidad
        Try
            If validarFormulario = True Then
                If Not IsNothing(Cbxloc.SelectedItem) Then
                    Locmodificar = DirectCast(Cbxloc.SelectedItem, BE_Localidad)
                    Locmodificar.ID = DirectCast(Cbxloc.SelectedItem, BE_Localidad).ID
                    Locmodificar.CantidadBarrios = NumericUpDown1.Value
                    Locmodificar.Habitantes = Me.txtHabitantes.Text
                    GestorLoc.modificarLocalidad(Locmodificar)
                    iniciar()
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_118"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw New CamposIncompletosException
                End If
            Else
                Throw New CamposIncorrectosException
            End If
        Catch ex As CamposIncorrectosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnEditException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Localidad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Localidad")
    End Sub
End Class