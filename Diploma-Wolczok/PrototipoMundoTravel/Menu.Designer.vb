﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeViajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarDestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDePaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarViajeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlojamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeAlojamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasajerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPasajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPasajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPasajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarPasajerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarBitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarBackupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestoreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPuntajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CambiarPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesToolStripMenuItem, Me.AlojamientoToolStripMenuItem, Me.PasajerosToolStripMenuItem, Me.CancelacionesToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.PagosToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViajesToolStripMenuItem
        '
        Me.ViajesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaDeViajesToolStripMenuItem, Me.AgregarDestinoToolStripMenuItem, Me.AgregarViajeToolStripMenuItem, Me.EliminarDestinoToolStripMenuItem, Me.AltaDePaisToolStripMenuItem, Me.ModificarPaisToolStripMenuItem, Me.EliminarPaisToolStripMenuItem, Me.AltaDeProvinciaToolStripMenuItem, Me.ModificarProvinciaToolStripMenuItem, Me.EliminarProvinciaToolStripMenuItem, Me.AltaDeLocalidadToolStripMenuItem, Me.ModificarLocalidadToolStripMenuItem, Me.EliminarLocalidadToolStripMenuItem, Me.AgregarViajeToolStripMenuItem1})
        Me.ViajesToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViajesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViajesToolStripMenuItem.Name = "ViajesToolStripMenuItem"
        Me.ViajesToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.ViajesToolStripMenuItem.Text = "Viajes"
        '
        'BusquedaDeViajesToolStripMenuItem
        '
        Me.BusquedaDeViajesToolStripMenuItem.Name = "BusquedaDeViajesToolStripMenuItem"
        Me.BusquedaDeViajesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.BusquedaDeViajesToolStripMenuItem.Text = "Busqueda de Viajes"
        '
        'AgregarDestinoToolStripMenuItem
        '
        Me.AgregarDestinoToolStripMenuItem.Name = "AgregarDestinoToolStripMenuItem"
        Me.AgregarDestinoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AgregarDestinoToolStripMenuItem.Text = "Alta de Destino"
        '
        'AgregarViajeToolStripMenuItem
        '
        Me.AgregarViajeToolStripMenuItem.Name = "AgregarViajeToolStripMenuItem"
        Me.AgregarViajeToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AgregarViajeToolStripMenuItem.Text = "Agregar Transporte"
        '
        'EliminarDestinoToolStripMenuItem
        '
        Me.EliminarDestinoToolStripMenuItem.Name = "EliminarDestinoToolStripMenuItem"
        Me.EliminarDestinoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EliminarDestinoToolStripMenuItem.Text = "Eliminar Destino"
        '
        'AltaDePaisToolStripMenuItem
        '
        Me.AltaDePaisToolStripMenuItem.Name = "AltaDePaisToolStripMenuItem"
        Me.AltaDePaisToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AltaDePaisToolStripMenuItem.Text = "Alta de Pais"
        '
        'ModificarPaisToolStripMenuItem
        '
        Me.ModificarPaisToolStripMenuItem.Name = "ModificarPaisToolStripMenuItem"
        Me.ModificarPaisToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ModificarPaisToolStripMenuItem.Text = "Modificar Pais"
        '
        'EliminarPaisToolStripMenuItem
        '
        Me.EliminarPaisToolStripMenuItem.Name = "EliminarPaisToolStripMenuItem"
        Me.EliminarPaisToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EliminarPaisToolStripMenuItem.Text = "Eliminar Pais"
        '
        'AltaDeProvinciaToolStripMenuItem
        '
        Me.AltaDeProvinciaToolStripMenuItem.Name = "AltaDeProvinciaToolStripMenuItem"
        Me.AltaDeProvinciaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AltaDeProvinciaToolStripMenuItem.Text = "Alta de Provincia"
        '
        'ModificarProvinciaToolStripMenuItem
        '
        Me.ModificarProvinciaToolStripMenuItem.Name = "ModificarProvinciaToolStripMenuItem"
        Me.ModificarProvinciaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ModificarProvinciaToolStripMenuItem.Text = "Modificar Provincia"
        '
        'EliminarProvinciaToolStripMenuItem
        '
        Me.EliminarProvinciaToolStripMenuItem.Name = "EliminarProvinciaToolStripMenuItem"
        Me.EliminarProvinciaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EliminarProvinciaToolStripMenuItem.Text = "Eliminar Provincia"
        '
        'AltaDeLocalidadToolStripMenuItem
        '
        Me.AltaDeLocalidadToolStripMenuItem.Name = "AltaDeLocalidadToolStripMenuItem"
        Me.AltaDeLocalidadToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AltaDeLocalidadToolStripMenuItem.Text = "Alta de Localidad"
        '
        'ModificarLocalidadToolStripMenuItem
        '
        Me.ModificarLocalidadToolStripMenuItem.Name = "ModificarLocalidadToolStripMenuItem"
        Me.ModificarLocalidadToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ModificarLocalidadToolStripMenuItem.Text = "Modificar Localidad"
        '
        'EliminarLocalidadToolStripMenuItem
        '
        Me.EliminarLocalidadToolStripMenuItem.Name = "EliminarLocalidadToolStripMenuItem"
        Me.EliminarLocalidadToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EliminarLocalidadToolStripMenuItem.Text = "Eliminar Localidad"
        '
        'AgregarViajeToolStripMenuItem1
        '
        Me.AgregarViajeToolStripMenuItem1.Name = "AgregarViajeToolStripMenuItem1"
        Me.AgregarViajeToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.AgregarViajeToolStripMenuItem1.Text = "Agregar Viaje"
        '
        'AlojamientoToolStripMenuItem
        '
        Me.AlojamientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaDeAlojamientoToolStripMenuItem, Me.AltaDeDepartamentoToolStripMenuItem, Me.EliminarDepartamentoToolStripMenuItem})
        Me.AlojamientoToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlojamientoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AlojamientoToolStripMenuItem.Name = "AlojamientoToolStripMenuItem"
        Me.AlojamientoToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AlojamientoToolStripMenuItem.Text = "Alojamiento"
        '
        'BusquedaDeAlojamientoToolStripMenuItem
        '
        Me.BusquedaDeAlojamientoToolStripMenuItem.Name = "BusquedaDeAlojamientoToolStripMenuItem"
        Me.BusquedaDeAlojamientoToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.BusquedaDeAlojamientoToolStripMenuItem.Text = "Busqueda de Alojamiento"
        '
        'AltaDeDepartamentoToolStripMenuItem
        '
        Me.AltaDeDepartamentoToolStripMenuItem.Name = "AltaDeDepartamentoToolStripMenuItem"
        Me.AltaDeDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.AltaDeDepartamentoToolStripMenuItem.Text = "Agregar Alojamiento"
        '
        'EliminarDepartamentoToolStripMenuItem
        '
        Me.EliminarDepartamentoToolStripMenuItem.Name = "EliminarDepartamentoToolStripMenuItem"
        Me.EliminarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.EliminarDepartamentoToolStripMenuItem.Text = "Agregar Habitacion"
        '
        'PasajerosToolStripMenuItem
        '
        Me.PasajerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPasajeroToolStripMenuItem, Me.ModificarPasajeroToolStripMenuItem, Me.EliminarPasajeroToolStripMenuItem, Me.VisualizarPasajerosToolStripMenuItem})
        Me.PasajerosToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasajerosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PasajerosToolStripMenuItem.Name = "PasajerosToolStripMenuItem"
        Me.PasajerosToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.PasajerosToolStripMenuItem.Text = "Pasajeros"
        '
        'AgregarPasajeroToolStripMenuItem
        '
        Me.AgregarPasajeroToolStripMenuItem.Name = "AgregarPasajeroToolStripMenuItem"
        Me.AgregarPasajeroToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AgregarPasajeroToolStripMenuItem.Text = "Agregar Pasajero"
        '
        'ModificarPasajeroToolStripMenuItem
        '
        Me.ModificarPasajeroToolStripMenuItem.Name = "ModificarPasajeroToolStripMenuItem"
        Me.ModificarPasajeroToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ModificarPasajeroToolStripMenuItem.Text = "Modificar Pasajero"
        '
        'EliminarPasajeroToolStripMenuItem
        '
        Me.EliminarPasajeroToolStripMenuItem.Name = "EliminarPasajeroToolStripMenuItem"
        Me.EliminarPasajeroToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EliminarPasajeroToolStripMenuItem.Text = "Eliminar Pasajero"
        '
        'VisualizarPasajerosToolStripMenuItem
        '
        Me.VisualizarPasajerosToolStripMenuItem.Name = "VisualizarPasajerosToolStripMenuItem"
        Me.VisualizarPasajerosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VisualizarPasajerosToolStripMenuItem.Text = "Visualizar Pasajeros"
        '
        'CancelacionesToolStripMenuItem
        '
        Me.CancelacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelarReservaToolStripMenuItem})
        Me.CancelacionesToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CancelacionesToolStripMenuItem.Name = "CancelacionesToolStripMenuItem"
        Me.CancelacionesToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CancelacionesToolStripMenuItem.Text = "Cancelaciones"
        '
        'CancelarReservaToolStripMenuItem
        '
        Me.CancelarReservaToolStripMenuItem.Name = "CancelarReservaToolStripMenuItem"
        Me.CancelarReservaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CancelarReservaToolStripMenuItem.Text = "Cancelar Reserva"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ModificarUsuariosToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem, Me.AgregarPerfilToolStripMenuItem, Me.ModificarPerfilesToolStripMenuItem, Me.EliminarPermisoToolStripMenuItem, Me.VisualizarBitToolStripMenuItem, Me.RealizarBackupToolStripMenuItem1, Me.RealizarRestoreToolStripMenuItem1, Me.EliminarIdiomaToolStripMenuItem, Me.ModificarPuntajeToolStripMenuItem, Me.ControlDeCambiosToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministracionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'ModificarUsuariosToolStripMenuItem
        '
        Me.ModificarUsuariosToolStripMenuItem.Name = "ModificarUsuariosToolStripMenuItem"
        Me.ModificarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ModificarUsuariosToolStripMenuItem.Text = "Modificar Usuario"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario"
        '
        'AgregarPerfilToolStripMenuItem
        '
        Me.AgregarPerfilToolStripMenuItem.Name = "AgregarPerfilToolStripMenuItem"
        Me.AgregarPerfilToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AgregarPerfilToolStripMenuItem.Text = "Crear Permiso"
        '
        'ModificarPerfilesToolStripMenuItem
        '
        Me.ModificarPerfilesToolStripMenuItem.Name = "ModificarPerfilesToolStripMenuItem"
        Me.ModificarPerfilesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ModificarPerfilesToolStripMenuItem.Text = "Modificar Permiso"
        '
        'EliminarPermisoToolStripMenuItem
        '
        Me.EliminarPermisoToolStripMenuItem.Name = "EliminarPermisoToolStripMenuItem"
        Me.EliminarPermisoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EliminarPermisoToolStripMenuItem.Text = "Eliminar Permiso"
        '
        'VisualizarBitToolStripMenuItem
        '
        Me.VisualizarBitToolStripMenuItem.Name = "VisualizarBitToolStripMenuItem"
        Me.VisualizarBitToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VisualizarBitToolStripMenuItem.Text = "Visualizar Bitacora"
        '
        'RealizarBackupToolStripMenuItem1
        '
        Me.RealizarBackupToolStripMenuItem1.Name = "RealizarBackupToolStripMenuItem1"
        Me.RealizarBackupToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.RealizarBackupToolStripMenuItem1.Text = "Realizar Backup"
        '
        'RealizarRestoreToolStripMenuItem1
        '
        Me.RealizarRestoreToolStripMenuItem1.Name = "RealizarRestoreToolStripMenuItem1"
        Me.RealizarRestoreToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.RealizarRestoreToolStripMenuItem1.Text = "Realizar Restore"
        '
        'EliminarIdiomaToolStripMenuItem
        '
        Me.EliminarIdiomaToolStripMenuItem.Name = "EliminarIdiomaToolStripMenuItem"
        Me.EliminarIdiomaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EliminarIdiomaToolStripMenuItem.Text = "Eliminar Idioma"
        '
        'ModificarPuntajeToolStripMenuItem
        '
        Me.ModificarPuntajeToolStripMenuItem.Name = "ModificarPuntajeToolStripMenuItem"
        Me.ModificarPuntajeToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ModificarPuntajeToolStripMenuItem.Text = "Modificar Puntaje"
        '
        'ControlDeCambiosToolStripMenuItem
        '
        Me.ControlDeCambiosToolStripMenuItem.Name = "ControlDeCambiosToolStripMenuItem"
        Me.ControlDeCambiosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ControlDeCambiosToolStripMenuItem.Text = "Control de Cambios"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPagoToolStripMenuItem, Me.VisualizarPagosToolStripMenuItem})
        Me.PagosToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'AgregarPagoToolStripMenuItem
        '
        Me.AgregarPagoToolStripMenuItem.Name = "AgregarPagoToolStripMenuItem"
        Me.AgregarPagoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgregarPagoToolStripMenuItem.Text = "Agregar Pago"
        '
        'VisualizarPagosToolStripMenuItem
        '
        Me.VisualizarPagosToolStripMenuItem.Name = "VisualizarPagosToolStripMenuItem"
        Me.VisualizarPagosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VisualizarPagosToolStripMenuItem.Text = "Visualizar Pagos"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarPassword, Me.SeleccionarIdioma, Me.CerrarSesiónToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'SeleccionarIdioma
        '
        Me.SeleccionarIdioma.Name = "SeleccionarIdioma"
        Me.SeleccionarIdioma.Size = New System.Drawing.Size(190, 22)
        Me.SeleccionarIdioma.Text = "Cambiar Idioma"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(867, 423)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'CambiarPassword
        '
        Me.CambiarPassword.Name = "CambiarPassword"
        Me.CambiarPassword.Size = New System.Drawing.Size(190, 22)
        Me.CambiarPassword.Text = "Cambiar Password"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "Mundo Travel SA - Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPerfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPermisoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarBitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ViajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeViajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlojamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeAlojamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasajerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPasajeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPasajeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPasajeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarBackupToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RealizarRestoreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarIdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDePaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarPaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeDepartamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDepartamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarDestinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDestinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarPuntajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarPagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarPagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarViajeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VisualizarPasajerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarPassword As ToolStripMenuItem
End Class
