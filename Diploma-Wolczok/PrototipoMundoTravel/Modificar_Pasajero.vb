Imports BLL
Imports EE

Public Class Modificar_Pasajero
    Implements BLL.BLL_Iobservador

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Modificar_Pasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()

        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()


    End Sub

    Public Sub Iniciar()
        Try
            Cbxpasajero.SelectedItem = Nothing
            Cbxpasajero.Items.Clear()
            txtNombre.Text = ""
            Txtapellido.Text = ""
            txtMail.Text = ""
            txtDNI.Text = ""
            txtDomicilio.Text = ""
            txtTelefono.Text = ""
            Dim Gestorpas As New BLL_Pasajero
            Dim Listapas = Gestorpas.consultarPasajeros()
            For Each pas In Listapas
                Cbxpasajero.Items.Add(pas)
                Cbxpasajero.DisplayMember = "NombreApellido"

            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Cbxpasajero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpasajero.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxpasajero.SelectedItem) Then
                Dim NuevoPas As BE_Pasajero = New BE_Pasajero
                NuevoPas = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
                Me.txtNombre.Text = NuevoPas.Nombre
                Me.Txtapellido.Text = NuevoPas.Apellido
                Me.txtMail.Text = NuevoPas.CorreoElectronico
                Me.txtDNI.Text = NuevoPas.DNI
                Me.txtDomicilio.Text = NuevoPas.Domicilio
                Me.txtTelefono.Text = NuevoPas.Telefono
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim GestorPas As New BLL_Pasajero
        Dim pasmodificar As New BE_Pasajero
        Try
            If Not IsNothing(Cbxpasajero.SelectedItem) Then
                If Not IsNothing(Cbxpasajero.SelectedItem) And Not String.IsNullOrWhiteSpace(txtNombre.Text) And Not String.IsNullOrWhiteSpace(Txtapellido.Text) And Not String.IsNullOrWhiteSpace(txtMail.Text) And Not String.IsNullOrWhiteSpace(txtDNI.Text) And Not String.IsNullOrWhiteSpace(txtDomicilio.Text) And Not String.IsNullOrWhiteSpace(txtTelefono.Text) Then
                    pasmodificar = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero)
                    pasmodificar.ID = DirectCast(Cbxpasajero.SelectedItem, BE_Pasajero).ID
                    pasmodificar.Nombre = txtNombre.Text
                    pasmodificar.Apellido = Txtapellido.Text
                    pasmodificar.CorreoElectronico = txtMail.Text
                    pasmodificar.DNI = txtDNI.Text
                    pasmodificar.Domicilio = txtDomicilio.Text
                    pasmodificar.Telefono = txtTelefono.Text
                    GestorPas.modificarPasajero(pasmodificar)
                    Iniciar()
                    MsgBox("Se ha modificado el pasajero correctamente", MsgBoxStyle.Information, "Mundo Travel SA")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Pasajero_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Pasajero")
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class