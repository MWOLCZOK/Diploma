Imports System.ComponentModel
Imports BLL
Imports EE

Public Class Modificar_Localidad

    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        cargarcombos()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Public Sub iniciar()
        Try
            Cbxloc.SelectedItem = Nothing
            Cbxloc.Items.Clear()
            Me.NumericUpDown1.Value = 0
            Me.NumericUpDown2.Value = 0
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
                Me.NumericUpDown1.Value = Nuevaloc.CantidadBarrios
                Me.NumericUpDown2.Value = Nuevaloc.Habitantes
                For Each miProv As BE_Provincia In Cbxprov.Items
                    If miProv.ID = Nuevaloc.Provincia.ID Then
                        Cbxprov.SelectedItem = miProv
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GestorLoc As New BLL_Localidad
        Dim Locmodificar As New BE_Localidad

        Try
            If Not IsNothing(Cbxloc.SelectedItem) Then
                Locmodificar = DirectCast(Cbxloc.SelectedItem, BE_Localidad)
                Locmodificar.ID = DirectCast(Cbxloc.SelectedItem, BE_Localidad).ID
                Locmodificar.CantidadBarrios = NumericUpDown1.Value
                Locmodificar.Habitantes = NumericUpDown2.Value
                '   Locmodificar.Destino = Txtdestino.Text
                GestorLoc.modificarLocalidad(Locmodificar)
                iniciar()
                MessageBox.Show("Se ha modificado la Localidad de manera satisfactoria")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Localidad_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
    End Sub
End Class