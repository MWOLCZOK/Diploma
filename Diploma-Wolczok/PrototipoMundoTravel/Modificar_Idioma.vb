Imports System.Globalization
Imports BLL

Public Class Modificar_Idioma

    Implements BLL.BLL_Iobservador

    Public Sub iniciar()
        Try
            CbxCultura.SelectedItem = Nothing
            TxtNombre.Text = ""
            Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
            Dim Listaidiomas = GestorIdioma.ConsultarIdiomasEditables()
            For Each Cultura In CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
                CbxCultura.Items.Add(Cultura.NativeName)
            Next
            DgVIdioma.Rows.Clear()
            CbxIdioma.SelectedItem = Nothing
            CbxIdioma.Items.Clear()
            For Each Idioma In Listaidiomas
                CbxIdioma.Items.Add(Idioma)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Modificar_Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()

        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()

    End Sub

    Private Sub CbxIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxIdioma.SelectedIndexChanged
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                TxtNombre.Text = CbxIdioma.Text
                Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                DgVIdioma.Rows.Clear()
                For Each Frase As EE.BE_Palabras In GestorIdioma.ConsultarPorID(1).Palabras
                    DgVIdioma.Rows.Add(Frase.ID_Control, Frase.Codigo, Frase.Traduccion, "")
                Next

                Dim IdiomaSeleccionado As EE.BE_Idioma = GestorIdioma.ConsultarPorID(DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma).id_idioma)

                For Each cultura In CbxCultura.Items
                    If cultura = IdiomaSeleccionado.Cultura.NativeName Then
                        CbxCultura.SelectedItem = cultura
                    End If
                Next

                For Each row As DataGridViewRow In DgVIdioma.Rows
                    For Each Pala As EE.BE_Palabras In IdiomaSeleccionado.Palabras
                        If String.IsNullOrWhiteSpace(row.Cells(3).Value) Then
                            If row.Cells(0).Value = Pala.ID_Control Then
                                row.Cells(3).Value = Pala.Traduccion
                            End If
                        End If
                    Next
                Next
                DgVIdioma.Columns(0).Visible = False
                DgVIdioma.Columns(1).Visible = False
                DgVIdioma.Columns(2).ReadOnly = True
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If Not IsNothing(CbxIdioma.SelectedItem) Then
                If Not IsNothing(CbxCultura.SelectedItem) Then
                    If Not String.IsNullOrWhiteSpace(TxtNombre.Text) Then
                        Dim IdiomaNuevo As EE.BE_Idioma = New EE.BE_Idioma
                        IdiomaNuevo = DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma)
                        Dim NombreIdioma As String = DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma).Nombre
                        For Each Cultura In CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
                            If CbxCultura.SelectedItem = Cultura.NativeName Then
                                IdiomaNuevo.Cultura = Cultura
                            End If
                        Next
                        Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                        If DirectCast(CbxIdioma.SelectedItem, EE.BE_Idioma).Nombre = TxtNombre.Text Or GestorIdioma.ConsultarNombre(TxtNombre.Text) Then
                            IdiomaNuevo.Nombre = TxtNombre.Text
                            Dim Palabras As List(Of EE.BE_Palabras) = New List(Of EE.BE_Palabras)
                            For Each Pala As DataGridViewRow In DgVIdioma.Rows
                                If Not String.IsNullOrWhiteSpace(Pala.Cells(3).Value) Then
                                    Dim frase As EE.BE_Palabras = New EE.BE_Palabras
                                    frase.ID_Control = Pala.Cells(0).Value
                                    frase.Traduccion = Pala.Cells(3).Value
                                    Palabras.Add(frase)
                                End If
                            Next
                            IdiomaNuevo.Palabras = Palabras
                            GestorIdioma.modificarIdioma(IdiomaNuevo)
                            iniciar()
                        Else
                        End If
                    Else
                    End If
                Else
                End If
            Else
            End If

        Catch ex As Exception
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Idioma_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Idioma")
    End Sub
End Class