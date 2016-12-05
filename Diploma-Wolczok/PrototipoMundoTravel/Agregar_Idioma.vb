Imports System.Globalization
Imports BLL
Imports EE

Public Class Agregar_Idioma
    Implements BLL_Iobservador

    Private Sub Agregar_Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            iniciar()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub iniciar()
        Try
            CbxCultura.SelectedItem = Nothing
            CbxCultura.Items.Clear()
            DgVIdioma.Rows.Clear()
            Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
            For Each Cultura In CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
                CbxCultura.Items.Add(Cultura.NativeName)
            Next
            DgVIdioma.Rows.Clear()
            For Each Frase As EE.BE_Palabras In GestorIdioma.ConsultarPorID(1).Palabras
                DgVIdioma.Rows.Add(Frase.ID_Control, Frase.Codigo, Frase.Traduccion, "")
            Next
            TxtNombre.Text = ""
        Catch ex As Exception
            Throw New errorObtencionDeDatosException
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not String.IsNullOrWhiteSpace(TxtNombre.Text) Then
                If Not IsNothing(CbxCultura.SelectedItem) Then
                    Dim IdiomaNuevo As EE.BE_Idioma = New EE.BE_Idioma
                    Dim GestorIdioma As BLL.BLL_Idioma = New BLL.BLL_Idioma
                    If GestorIdioma.ConsultarNombre(TxtNombre.Text) = True Then
                        IdiomaNuevo.Nombre = TxtNombre.Text
                        For Each Cultura In CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
                            If CbxCultura.SelectedItem = Cultura.NativeName Then
                                IdiomaNuevo.Cultura = Cultura
                            End If
                        Next
                        IdiomaNuevo.editable = True
                        Dim Palabras As List(Of EE.BE_Palabras) = New List(Of EE.BE_Palabras)
                        For Each Pala As DataGridViewRow In DgVIdioma.Rows
                            Dim frase As EE.BE_Palabras = New EE.BE_Palabras
                            frase.ID_Control = Pala.Cells(0).Value
                            If Not String.IsNullOrWhiteSpace(Pala.Cells(3).Value) Then
                                frase.Traduccion = Pala.Cells(3).Value
                                Palabras.Add(frase)
                            Else
                                frase.Traduccion = Pala.Cells(2).Value
                                Palabras.Add(frase)
                            End If
                        Next
                        IdiomaNuevo.Palabras = Palabras
                        GestorIdioma.altaIdioma(IdiomaNuevo)
                        iniciar()
                    Else
                    End If
                    MsgBox("Se ha generado el campo correctamente.", MsgBoxStyle.Information, "Accion Correcta")
                Else
                    Throw New CamposIncompletosException
                End If
            Else
            End If
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

    Private Sub Agregar_Idioma_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Administracion")
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        e.Handled = validacionTextBox.TextoyNumeros(e)

    End Sub
End Class