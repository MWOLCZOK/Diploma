Imports BLL
Imports EE


Public Class Modificar_Provincia
    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        cargarCombos()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub


    Private Sub cargarCombos()
        Dim oListaPaises As New List(Of EE.BE_Pais)
        Dim bllPais As New BLL.BLL_Pais
        oListaPaises = bllPais.ConsultarPaises()
        For Each mipais As EE.BE_Pais In oListaPaises
            Me.ComboBox1.Items.Add(mipais)
        Next

    End Sub



    Public Sub iniciar()
        Try
            Cbxprov.SelectedItem = Nothing
            Cbxprov.Items.Clear()
            txtNombre.Text = ""
            NumericUpDown1.Value = 0
            txtRegion.Text = ""
            txtSuperficieTerrestre.Text = ""
            Dim GestorProv As New BLL_Provincia
            Dim Listaprov = GestorProv.Consultarprovincias()
            For Each prov In Listaprov
                Cbxprov.Items.Add(prov)
            Next
        Catch ex As Exception
        End Try
    End Sub



    Private Sub Cbxprov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxprov.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxprov.SelectedItem) Then
                Dim Nuevaprov As BE_Provincia = New BE_Provincia
                Nuevaprov = DirectCast(Cbxprov.SelectedItem, BE_Provincia)
                Me.txtNombre.Text = Nuevaprov.Descripcion
                Me.NumericUpDown1.Value = Nuevaprov.Habitantes
                Me.txtRegion.Text = Nuevaprov.Region
                Me.txtSuperficieTerrestre.Text = Nuevaprov.SuperficieTerrestre

                For Each miPais As BE_Pais In ComboBox1.Items
                    If miPais.ID = Nuevaprov.Pais.ID Then
                        ComboBox1.SelectedItem = miPais
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim GestorProv As New BLL_Provincia
        Dim Provmodificar As New BE_Provincia
        Try
            If Not IsNothing(Cbxprov.SelectedItem) Then
                Provmodificar = DirectCast(Cbxprov.SelectedItem, BE_Provincia)
                Provmodificar.ID = DirectCast(Cbxprov.SelectedItem, BE_Provincia).ID
                Provmodificar.Descripcion = txtNombre.Text
                Provmodificar.Habitantes = NumericUpDown1.Value
                Provmodificar.Region = txtRegion.Text
                Provmodificar.SuperficieTerrestre = txtSuperficieTerrestre.Text
                GestorProv.modificarprovincia(Provmodificar)
                iniciar()
                MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
            End If
        Catch ex As Exception

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