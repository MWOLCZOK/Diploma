Imports EE
Imports BLL

Public Class FormMenu
    Implements BLL_Iobservador

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oUsuario As EE.BE_Usuario = SessionBLL.SesionActual.ObtenerUsuarioActual
        Me.Label1.Text = oUsuario.Apellido & ", " & oUsuario.Nombre
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Public Sub RecibirPermisos(ByRef PermComp As EE.BE_GrupoPermiso)
        For Each MiMenuItem As ToolStripMenuItem In Me.MenuStrip1.Items
            For Each SegundoNivel As ToolStripMenuItem In MiMenuItem.DropDownItems
                If SegundoNivel.Name = "CerrarSesiónToolStripMenuItem" Or SegundoNivel.Name = "SeleccionarIdioma" Or SegundoNivel.Name = "CambiarPassword" Then
                    SegundoNivel.Visible = True
                Else
                    SegundoNivel.Visible = False
                End If

                If SegundoNivel.HasDropDown Then
                    For Each TercerNivel As ToolStripMenuItem In SegundoNivel.DropDownItems
                        TercerNivel.Visible = False
                    Next
                End If
            Next
            If Not MiMenuItem.Text = "Opciones" Then
                MiMenuItem.Visible = False
            End If

        Next
        ChequearMenu(PermComp, Nothing)
    End Sub

    Private Sub ChequearMenu(ByRef Permiso As BE_PermisoBase, ByRef Mimenu As ToolStripMenuItem)
        If Permiso.tieneHijos Then
            For Each Perm As BE_PermisoBase In DirectCast(Permiso, BE_GrupoPermiso).Hijos
                If IsNothing(Mimenu) Then
                    If Perm.tieneHijos Then
                        ChequearMenu(Perm, Nothing)
                    Else
                        HabilitacionMenu(Perm, Nothing)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitacionMenu(ByRef PermisoSimple As BE_Permiso, ByRef Mimenu As ToolStripMenuItem)
        If IsNothing(Mimenu) Then
            For Each Ventana As ToolStripMenuItem In MenuStrip1.Items
                If Not IsNothing(Ventana.DropDownItems) Then
                    HabilitacionMenu(PermisoSimple, Ventana)
                Else
                    If Ventana.Text = PermisoSimple.Nombre Then
                        Ventana.Visible = True
                        HabilitacionPadres(Ventana)
                    End If
                End If
            Next
        Else
            For Each Ventana2 As ToolStripMenuItem In Mimenu.DropDownItems
                If (Ventana2.HasDropDown) Then
                    HabilitacionMenu(PermisoSimple, Ventana2)
                Else
                    If Ventana2.Text = PermisoSimple.Nombre Then
                        Ventana2.Visible = True
                        HabilitacionPadres(Ventana2)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitacionPadres(ByRef Ventana As ToolStripMenuItem)
        If Not IsNothing(Ventana.OwnerItem) Then
            Ventana.OwnerItem.Visible = True
            HabilitacionPadres(Ventana.OwnerItem)
        End If
    End Sub

    Private Sub FormMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.Visible = True Then
            Try
                If MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_24"), ControladorTraductor.TraducirMensaje("Titulo_03"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SessionBLL.SesionActual.CerrarSession()
                    Me.Owner.Show()
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Catch ex As Exception
                Me.Owner.Show()
                e.Cancel = False
            End Try
        Else
            Me.Owner.Show()
            SessionBLL.SesionActual.CerrarSession()
            e.Cancel = False
        End If

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub CancelacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelacionesToolStripMenuItem.Click

    End Sub

    Private Sub SeleccionarIdioma_Click(sender As Object, e As EventArgs) Handles SeleccionarIdioma.Click
        Dim SeleccionarIdioma As FormSeleccionar_Idioma = New FormSeleccionar_Idioma
        AbrirForm(SeleccionarIdioma)
    End Sub

    Private Sub AbrirForm(ByRef Formulario As Form)
        If Me.OwnedForms.Length = 0 Then
            AddOwnedForm(Formulario)
            Formulario.Show()
        Else
            For Each Formu As Form In Me.OwnedForms()
                Formu.Close()
            Next
            AddOwnedForm(Formulario)
            Formulario.Show()
        End If
    End Sub

    Private Sub RealizarBackupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RealizarBackupToolStripMenuItem1.Click
        Dim RealizarBackup As Form_Backup = New Form_Backup
        AbrirForm(RealizarBackup)
    End Sub

    Private Sub RealizarRestoreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RealizarRestoreToolStripMenuItem1.Click
        Dim RealizarRestore As Form_Restore = New Form_Restore
        AbrirForm(RealizarRestore)
    End Sub


    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        Dim agregarUsuario As Agregar_Usuario = New Agregar_Usuario
        AbrirForm(agregarUsuario)
    End Sub

    Private Sub VisualizarBitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarBitToolStripMenuItem.Click
        Dim bitacora As visualizarBitacora = New visualizarBitacora
        AbrirForm(bitacora)
    End Sub

    Private Sub AgregarPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPerfilToolStripMenuItem.Click
        Dim formPermiso As Agregar_Permisos = New Agregar_Permisos
        AbrirForm(formPermiso)
    End Sub

    Private Sub ModificarPerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPerfilesToolStripMenuItem.Click
        Dim formPermiso As Modificar_Permiso = New Modificar_Permiso
        AbrirForm(formPermiso)
    End Sub

    Private Sub EliminarPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPermisoToolStripMenuItem.Click
        Dim formPermiso As Eliminar_Permiso = New Eliminar_Permiso
        AbrirForm(formPermiso)
    End Sub


    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        Dim formUsuario As Eliminar_Usuario = New Eliminar_Usuario
        AbrirForm(formUsuario)
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click

    End Sub

    Private Sub ViajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem.Click
     
    End Sub

    Private Sub AltaDePaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDePaisToolStripMenuItem.Click
        Dim formpais As Agregar_Pais = New Agregar_Pais
        AbrirForm(formpais)
    End Sub
   
  
    Private Sub EliminarPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPaisToolStripMenuItem.Click
        Dim formpais As Eliminar_Pais = New Eliminar_Pais
        AbrirForm(formpais)
    End Sub

    Private Sub ModificarPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPaisToolStripMenuItem.Click
        Dim formpais As Modificar_Pais = New Modificar_Pais
        AbrirForm(formpais)
    End Sub

    Private Sub ModificarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuariosToolStripMenuItem.Click
        Dim formusu As Modificar_Usuario = New Modificar_Usuario
        AbrirForm(formusu)
    End Sub

    Private Sub AltaDeProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeProvinciaToolStripMenuItem.Click
        Dim formprovi As Agregar_Provincia = New Agregar_Provincia
        AbrirForm(formprovi)
    End Sub

    Private Sub EliminarProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProvinciaToolStripMenuItem.Click
        Dim formprovi As Eliminar_Provincia = New Eliminar_Provincia
        AbrirForm(formprovi)
    End Sub

    Private Sub ModificarProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProvinciaToolStripMenuItem.Click
        Dim formprov As Modificar_Provincia = New Modificar_Provincia
        AbrirForm(formprov)
    End Sub

    Private Sub AltaDeLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeLocalidadToolStripMenuItem.Click
        Dim formloc As New Agregar_Localidad
        AbrirForm(formloc)
    End Sub

    Private Sub EliminarLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarLocalidadToolStripMenuItem.Click
        Dim formloc As New Eliminar_Localidad
        AbrirForm(formloc)
    End Sub

    Private Sub ModificarLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarLocalidadToolStripMenuItem.Click
        Dim formloc As New Modificar_Localidad
        AbrirForm(formloc)
    End Sub

    Private Sub AgregarPasajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPasajeroToolStripMenuItem.Click
        Dim formpas As New Agregar_Pasajero
        AbrirForm(formpas)
    End Sub

    Private Sub ModificarPasajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPasajeroToolStripMenuItem.Click
        Dim formpas As New Modificar_Pasajero
        AbrirForm(formpas)
    End Sub

    Private Sub EliminarPasajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPasajeroToolStripMenuItem.Click
        Dim formpas As New Eliminar_Pasajero
        AbrirForm(formpas)
    End Sub


    Private Sub EliminarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDepartamentoToolStripMenuItem.Click
        Dim formHabi As New Agregar_Habitacion
        AbrirForm(formHabi)
    End Sub

    Private Sub AgregarDestinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDestinoToolStripMenuItem.Click
        Dim formdestino As New Agregar_Destino
        AbrirForm(formdestino)
    End Sub

    Private Sub EliminarDestinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDestinoToolStripMenuItem.Click
        Dim formdestino As New Eliminar_Destino
        AbrirForm(formdestino)
    End Sub

    Private Sub BusquedaDeAlojamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaDeAlojamientoToolStripMenuItem.Click
        Dim formalojamiento As New Reserva_Buscar_Alojamiento
        AbrirForm(formalojamiento)
    End Sub

    Private Sub AltaDeDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeDepartamentoToolStripMenuItem.Click
        Dim forHot As New Agregar_Alojamiento
        AbrirForm(forHot)
    End Sub

    Private Sub ModificarPuntajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPuntajeToolStripMenuItem.Click
        Dim formpuntaje As New Modificar_Puntaje
        AbrirForm(formpuntaje)
    End Sub

    Private Sub ReservaBuscarViajeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim formreservaviaje As New Reserva_Buscar_Viaje
        AbrirForm(formreservaviaje)
    End Sub

    Private Sub BusquedaDeViajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaDeViajesToolStripMenuItem.Click
        Dim formreservaviaje As New Reserva_Buscar_Viaje
        AbrirForm(formreservaviaje)
    End Sub

    Private Sub AgregarViajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarViajeToolStripMenuItem.Click
        Dim formnuevoviaje As New Agregar_Transporte
        AbrirForm(formnuevoviaje)
    End Sub

    Private Sub AgregarPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPagoToolStripMenuItem.Click
        Dim formpago As New Agregar_Pago
        AbrirForm(formpago)
    End Sub

    Private Sub VisualizarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarPagosToolStripMenuItem.Click
        Dim formvisualizarpagos As New visualizarPagos
        AbrirForm(formvisualizarpagos)
    End Sub


    Private Sub CancelarReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarReservaToolStripMenuItem.Click
        Dim formCancelacion As New Cancelacion
        AbrirForm(formCancelacion)
    End Sub

    Private Sub AgregarViajeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarViajeToolStripMenuItem1.Click
        Dim formViaje As New Agregar_Viaje
        AbrirForm(formViaje)
    End Sub

    Private Sub VisualizarPasajerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarPasajerosToolStripMenuItem.Click
        Dim vPasajeros As New visualizarPasajeros
        AbrirForm(vPasajeros)
    End Sub

    Private Sub EliminarIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarIdiomaToolStripMenuItem.Click
        Dim vEliminarIdioma As New Eliminar_Idioma
        AbrirForm(vEliminarIdioma)
    End Sub

    Private Sub ControlDeCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeCambiosToolStripMenuItem.Click
        Dim vVisualizar As New visualizarControlCambios
        AbrirForm(vVisualizar)
    End Sub


    Private Sub Login_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Pantalla Principal")
    End Sub

    Private Sub CambiarPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarPassword.Click
        Dim vVisualizar As New Cambiar_Password
        AbrirForm(vVisualizar)
    End Sub
End Class