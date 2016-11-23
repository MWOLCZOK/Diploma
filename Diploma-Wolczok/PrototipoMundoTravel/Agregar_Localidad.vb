Imports EE
Imports BLL

Public Class Agregar_Localidad
    Implements BLL_Iobservador


    Private Sub Agregar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCombos()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub cargarCombos()
        Dim oListaProvincia As New List(Of EE.BE_Provincia)
        Dim bllProvincia As New BLL.BLL_Provincia
        oListaProvincia = bllProvincia.Consultarprovincias
        For Each miProv As EE.BE_Provincia In oListaProvincia
            Me.ComboBox1.Items.Add(miProv)
        Next

    End Sub



    Private Function validarFormulario() As Boolean
        Try
            If Me.Txtdescripcion.Text = "" Then Return False
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
                oLoc.Habitantes = Me.NumericUpDown2.Value
                Dim oProvincia As New BE_Provincia
                oProvincia.ID = DirectCast(ComboBox1.SelectedItem, BE_Provincia).ID
                oLoc.Provincia = oProvincia
                bllLoc.altalocalidad(oLoc)
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Agregar_Localidad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class