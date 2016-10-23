Imports BLL
Imports EE


Public Class Modificar_Provincia

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        cargarcombos()

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
        Txtdescripcion.Text = ""
            Txthabitantes.Text = ""
        Txtregion.Text = ""
            Txtsuperficieterrestre.Text = ""
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
                Me.Txtdescripcion.Text = Nuevaprov.Descripcion
                Me.Txthabitantes.Text = Nuevaprov.Habitantes
                Me.Txtregion.Text = Nuevaprov.Region
                Me.Txtsuperficieterrestre.Text = Nuevaprov.SuperficieTerrestre

                For Each miPais As BE_Pais In ComboBox1.Items
                    If miPais.ID = Nuevaprov.Pais.ID Then
                        ComboBox1.SelectedItem = miPais
                    End If
                Next

                '       Me.TxtLocalidad.Text = Nuevaprov.Localidad
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim GestorProv As New BLL_Provincia
        Dim Provmodificar As New BE_Provincia
        Try
            If Not IsNothing(Cbxprov.SelectedItem) Then
                Provmodificar = DirectCast(Cbxprov.SelectedItem, BE_Provincia)
                Provmodificar.ID = DirectCast(Cbxprov.SelectedItem, BE_Provincia).ID
                Provmodificar.Descripcion = Txtdescripcion.Text
                Provmodificar.Habitantes = Txthabitantes.Text
                Provmodificar.Region = Txtregion.Text
                Provmodificar.SuperficieTerrestre = Txtsuperficieterrestre.Text
                '        Provmodificar.Localidad = TxtLocalidad.Text
                GestorProv.modificarprovincia(Provmodificar)
                iniciar()
                MessageBox.Show("Se ha modificado la provincia de manera satisfactoria")
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class