Imports BLL
Imports EE


Public Class Modificar_Provincia
    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
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
            Dim oListaPaises As New List(Of EE.BE_Pais)
            Dim bllPais As New BLL.BLL_Pais
            oListaPaises = bllPais.ConsultarPaises()
            For Each mipais As EE.BE_Pais In oListaPaises
                Me.ComboBox1.Items.Add(mipais)
            Next

        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub



    Public Sub iniciar()
        Try
            Cbxprov.SelectedItem = Nothing
            Cbxprov.Items.Clear()
            txtNombre.Text = ""
            txtHabitantes.Text = 0
            txtRegion.Text = ""
            txtSuperficieTerrestre.Text = ""
            Dim GestorProv As New BLL_Provincia
            Dim Listaprov = GestorProv.Consultarprovincias()
            For Each prov In Listaprov
                Cbxprov.Items.Add(prov)
            Next
        Catch ex As Exception
            Throw New errorObtencionDeDatosException

        End Try
    End Sub

    Private Function validarCampos() As Boolean
        If Not String.IsNullOrWhiteSpace(txtNombre.Text) Or Not String.IsNullOrWhiteSpace(txtHabitantes.Text) Or Not String.IsNullOrWhiteSpace(txtRegion.Text) Or Not String.IsNullOrWhiteSpace(txtSuperficieTerrestre.Text) Then Return False
        Return True
    End Function

    Private Sub Cbxprov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxprov.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxprov.SelectedItem) Then
                Dim Nuevaprov As BE_Provincia = New BE_Provincia
                Nuevaprov = DirectCast(Cbxprov.SelectedItem, BE_Provincia)
                Me.txtNombre.Text = Nuevaprov.Descripcion
                Me.txtHabitantes.Text = Nuevaprov.Habitantes
                Me.txtRegion.Text = Nuevaprov.Region
                Me.txtSuperficieTerrestre.Text = Nuevaprov.SuperficieTerrestre
                For Each miPais As BE_Pais In ComboBox1.Items
                    If miPais.ID = Nuevaprov.Pais.ID Then
                        ComboBox1.SelectedItem = miPais
                    End If
                Next
            Else
                Throw New CamposIncompletosException
            End If
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
    Private Function validarFormulario() As Boolean
        If Me.Cbxprov.SelectedItem Is Nothing Then Return False
        If String.IsNullOrWhiteSpace(Me.txtNombre.Text) Or String.IsNullOrWhiteSpace(Me.txtHabitantes.Text) Or String.IsNullOrWhiteSpace(Me.txtRegion.Text) Or String.IsNullOrWhiteSpace(Me.txtSuperficieTerrestre.Text) Then Return False
        Return True
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim GestorProv As New BLL_Provincia
        Dim Provmodificar As New BE_Provincia
        Try
            If validarFormulario() = True Then
                Provmodificar = DirectCast(Cbxprov.SelectedItem, BE_Provincia)
                Provmodificar.ID = DirectCast(Cbxprov.SelectedItem, BE_Provincia).ID
                Provmodificar.Descripcion = txtNombre.Text
                Provmodificar.Habitantes = txtHabitantes.Text
                Provmodificar.Region = txtRegion.Text
                Provmodificar.SuperficieTerrestre = txtSuperficieTerrestre.Text
                GestorProv.modificarprovincia(Provmodificar)
                iniciar()
                MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_121"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Throw New CamposIncompletosException
            End If
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

    Private Sub Modificar_Provincia_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Provincia")
    End Sub
End Class