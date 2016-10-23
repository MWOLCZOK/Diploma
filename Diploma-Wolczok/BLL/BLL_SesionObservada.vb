Imports System.Threading
Public Class BLL_SesionObservada

    Private vListaForm As New List(Of BLL_Iobservador)

    Public ReadOnly Property ListaForm() As List(Of BLL_Iobservador)
        Get
            Return vListaForm
        End Get
    End Property

    Public Sub agregarForm(ByVal paramObservador As BLL_Iobservador)
        Me.vListaForm.Add(paramObservador)
    End Sub

    Public Sub quitarForm(ByVal paramObservador As BLL_Iobservador)
        Me.vListaForm.Add(paramObservador)
    End Sub

    Public Sub limpiarForm()
        Me.vListaForm.Clear()
    End Sub

    Public Sub notificarCambiodeIdioma()
        Thread.CurrentThread.CurrentCulture = SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Cultura
        Thread.CurrentThread.CurrentUICulture = SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Cultura
        Dim i As Integer = 0
        For Each miObservador As BLL_Iobservador In vListaForm
            miObservador.actualizarIdioma(Me)
            i += 1
            If i = vListaForm.Count Then
                Exit For
            End If
        Next
    End Sub
End Class
