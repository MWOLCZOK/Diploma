Imports EE
Imports BLL

Public Class Agregar_Alojamiento

    Private Sub Agregar_Alojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()

    End Sub

    Private Sub cargarCombos()
        Dim oListaDestinos As New List(Of BE_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.ComboBox1.Items.Add(miDest)
            ComboBox1.DisplayMember = "NombreCompleto"
        Next

        Dim oListaTipoAlojamiento As New List(Of BE_TipoAlojamiento)
        Dim bllTipoAlojamiento As New BLL.BLL_TipoAlojamiento
        oListaTipoAlojamiento = bllTipoAlojamiento.consultarTipoAlojamientos
        For Each miTipoAloja As BE_TipoAlojamiento In oListaTipoAlojamiento
            Me.ComboBox2.Items.Add(miTipoAloja)
            ComboBox2.DisplayMember = "Descripcion"
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oAlojamiento As New BE_Alojamiento
        oAlojamiento.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
        oAlojamiento.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        oAlojamiento.Nombre = TextBox1.Text
        oAlojamiento.Descripcion = Me.TextBox3.Text
        oAlojamiento.Estrellas = Me.TextBox4.Text
        oAlojamiento.Ubicacion = Me.TextBox5.Text
        oAlojamiento.Ambientes = Me.TextBox6.Text
        oAlojamiento.PrecioAlquiler = Me.TextBox7.Text
        oAlojamiento.ConectividadWifi = Me.CheckBox2.Checked
        oAlojamiento.Piscina = Me.CheckBox4.Checked
        oAlojamiento.ServicioAireAcond = Me.CheckBox8.Checked
        oAlojamiento.Desayuno = Me.CheckBox6.Checked
        oAlojamiento.ServicioTV = Me.CheckBox5.Checked
        If oAlojamiento.TipoAlojamiento.ID = 1 Then
            Dim oHostel As New BE_Hostel
            oHostel = DirectCast(oAlojamiento, BE_Hostel)
            Dim bllHostel As New BLL_Hostel
            oHostel.Cocina = Me.CheckBox9.Checked
            oHostel.HabitacionPrivada = Me.CheckBox13.Checked
            bllHostel.altaHostel(oHostel)
        ElseIf oAlojamiento.TipoAlojamiento.ID = 2 Then
            Dim oHotel As New BE_Hotel
            oHotel = DirectCast(oAlojamiento, BE_Hotel)
            Dim bllHotel As New BLL_Hotel
            oHotel.Gimnasio = Me.CheckBox1.Checked
            oHotel.Mascota = Me.CheckBox3.Checked
            oHotel.Sauna = Me.CheckBox7.Checked
            oHotel.Cochera = Me.CheckBox12.Checked
            bllHotel.altaHotel(oHotel)
        ElseIf oAlojamiento.TipoAlojamiento.ID = 3 Then
            Dim oDepartamento As New BE_Departamento
            oDepartamento = DirectCast(oAlojamiento, BE_Departamento)
            Dim bllDepartamento As New BLL_Departamento
            oDepartamento.Mascota = Me.CheckBox3.Checked
            oDepartamento.Cochera = Me.CheckBox12.Checked
            oDepartamento.Cocina = Me.CheckBox9.Checked
            oDepartamento.Amoblado = Me.CheckBox11.Checked
            bllDepartamento.altadep(oDepartamento)
        ElseIf oAlojamiento.TipoAlojamiento.ID = 4 Then
            Dim oPosada As New BE_Posada
            oPosada = DirectCast(oAlojamiento, BE_Posada)
            Dim bllPosada As New BLL_Posada
            oPosada.Mascota = Me.CheckBox3.Checked

        End If
    End Sub
End Class