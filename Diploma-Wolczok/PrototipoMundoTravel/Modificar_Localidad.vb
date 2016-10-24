Imports BLL
Imports EE

Public Class Modificar_Localidad

    Private Sub Modificar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        cargarcombos()

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Public Sub iniciar()
        Try
            Cbxloc.SelectedItem = Nothing
            Cbxloc.Items.Clear()
            Txtdescripcion.Text = ""
            Txtcantidadbarrios.Text = ""
            Txthabitantes.Text = ""
            'Txtdestino.Text = ""

            Dim GestorLoc As New BLL_Localidad
            Dim Listaloc = GestorLoc.consultarLocalidades()
            For Each local In Listaloc
                Cbxloc.Items.Add(local)

            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub cargarcombos()
        Dim Listaprov As New List(Of BE_Provincia)
        Dim bllListaprov As New BLL_Provincia
        Listaprov = bllListaprov.Consultarprovincias
        For Each miprov As BE_Provincia In Listaprov
            Me.Cbxprov.Items.Add(miprov)
        Next

    End Sub

    Private Sub Cbxloc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxloc.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxloc.SelectedItem) Then
                Dim Nuevaloc As BE_Localidad = New BE_Localidad
                Nuevaloc = DirectCast(Cbxloc.SelectedItem, BE_Localidad)
                Me.Txtdescripcion.Text = Nuevaloc.Descripcion
                Me.Txtcantidadbarrios.Text = Nuevaloc.CantidadBarrios
                Me.Txthabitantes.Text = Nuevaloc.Habitantes
                '            Me.Txtdestino.Text = Nuevaloc.Destino
                For Each miProv As BE_Provincia In Cbxprov.Items
                    If miProv.ID = Nuevaloc.Provincia.ID Then
                        Cbxprov.SelectedItem = miProv
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub






    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim GestorLoc As New BLL_Localidad
        Dim Locmodificar As New BE_Localidad

        Try
            If Not IsNothing(Cbxloc.SelectedItem) Then
                Locmodificar = DirectCast(Cbxloc.SelectedItem, BE_Localidad)
                Locmodificar.ID = DirectCast(Cbxloc.SelectedItem, BE_Localidad).ID
                Locmodificar.Descripcion = Txtdescripcion.Text
                Locmodificar.CantidadBarrios = Txtcantidadbarrios.Text
                Locmodificar.Habitantes = Txthabitantes.Text
                '   Locmodificar.Destino = Txtdestino.Text
                GestorLoc.modificarLocalidad(Locmodificar)
                iniciar()
                MessageBox.Show("Se ha modificado la Localidad de manera satisfactoria")
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class