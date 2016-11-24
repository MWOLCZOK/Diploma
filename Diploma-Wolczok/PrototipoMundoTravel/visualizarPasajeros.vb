Imports System.IO
Imports BLL

Public Class visualizarPasajeros

    Implements BLL.BLL_Iobservador

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub visualizarPasajeros_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Try
            Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
            Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub visualizarPasajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub iniciar()
        Try
            Dim _bllPasajero As New BLL.BLL_Pasajero
            Dim listaPasajeros As New List(Of EE.BE_Pasajero)
            listaPasajeros = _bllPasajero.consultarPasajeros()
            Me.dgvBitacora.DataSource = listaPasajeros
            EstablecerGrid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EstablecerGrid()
        Me.dgvBitacora.Columns.Remove("ID_")
        Me.dgvBitacora.Columns("NombreCompleto").Name = "Column_NombreCompleto"
        Me.dgvBitacora.Columns("DNI").Name = "Column_DNI"
        Me.dgvBitacora.Columns("Telefono").Name = "Column_Telefono"
        Me.dgvBitacora.Columns("CorreoElectronico").Name = "Column_MAIL"
    End Sub

    Private Sub btn_exportar_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Dim _bllPasajero As New BLL.BLL_Pasajero
        Dim Pasajeros As New List(Of EE.BE_Pasajero)
        Pasajeros = _bllPasajero.consultarPasajeros()
        Dim Jsonarray As BLL.SerializadorJSON(Of List(Of EE.BE_Pasajero)) = New BLL.SerializadorJSON(Of List(Of EE.BE_Pasajero))
        If File.Exists("Pasajeros" & Now.Date.Month & "-" & Now.Date.Year & ".JSON") Then
            File.Delete("Pasajeros" & Now.Date.Month & "-" & Now.Date.Year & ".JSON")
            Dim mistream = File.Open("Pasajeros" & Now.Date.Month & "-" & Now.Date.Year & ".JSON", FileMode.Create)
            Dim p As New List(Of EE.BE_Pasajero)
            p = Pasajeros
            mistream.Close()
            Jsonarray.Serializar(p)
        Else
            Dim mistream = File.Open("Pasajeros" & Now.Date.Month & "-" & Now.Date.Year & ".JSON", FileMode.Create)
            Dim p As New List(Of EE.BE_Pasajero)
            p = Pasajeros
            mistream.Close()
            Jsonarray.Serializar(p)
        End If
        MessageBox.Show("Se ha generado un archivo con los pasajeros.")
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub
End Class