Imports EE
Imports BLL

Public Class Agregar_Alojamiento

    Private Sub Agregar_Alojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCombos()
            ocultar()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub cargarCombos()
        Try

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
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        If oTipoAlojamiento.ID = 1 Then
            Dim oHostel As New BE_Hostel
            oHostel.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
            oHostel.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
            oHostel.Nombre = TextBox1.Text
            oHostel.Descripcion = Me.TextBox3.Text
            oHostel.Estrellas = Me.TextBox4.Text
            oHostel.Ubicacion = Me.TextBox5.Text
            oHostel.Ambientes = Me.TextBox6.Text
            oHostel.PrecioAlquiler = Me.TextBox7.Text
            oHostel.ConectividadWifi = Me.CheckBox2.Checked
            oHostel.Piscina = Me.CheckBox4.Checked
            oHostel.ServicioAireAcond = Me.CheckBox8.Checked
            oHostel.Desayuno = Me.CheckBox6.Checked
            oHostel.ServicioTV = Me.CheckBox5.Checked
            oHostel.Cocina = Me.CheckBox9.Checked
            oHostel.HabitacionPrivada = Me.CheckBox13.Checked
            Dim bllHostel As New BLL_Hostel
            bllHostel.altaHostel(oHostel)
        ElseIf otipoAlojamiento.ID = 2 Then
            Dim oHotel As New BE_Hotel
            oHotel.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
            oHotel.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
            oHotel.Nombre = TextBox1.Text
            oHotel.Descripcion = Me.TextBox3.Text
            oHotel.Estrellas = Me.TextBox4.Text
            oHotel.Ubicacion = Me.TextBox5.Text
            oHotel.Ambientes = Me.TextBox6.Text
            oHotel.PrecioAlquiler = Me.TextBox7.Text
            oHotel.ConectividadWifi = Me.CheckBox2.Checked
            oHotel.Piscina = Me.CheckBox4.Checked
            oHotel.ServicioAireAcond = Me.CheckBox8.Checked
            oHotel.Desayuno = Me.CheckBox6.Checked
            oHotel.ServicioTV = Me.CheckBox5.Checked
            oHotel.Gimnasio = Me.CheckBox1.Checked
            oHotel.Mascota = Me.CheckBox3.Checked
            oHotel.Sauna = Me.CheckBox7.Checked
            oHotel.Cochera = Me.CheckBox12.Checked
            Dim bllHotel As New BLL_Hotel
            bllHotel.altaHotel(oHotel)
        ElseIf oTipoAlojamiento.ID = 3 Then
            Dim oDepartamento As New BE_Departamento
            oDepartamento.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
            oDepartamento.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
            oDepartamento.Nombre = TextBox1.Text
            oDepartamento.Descripcion = Me.TextBox3.Text
            oDepartamento.Estrellas = Me.TextBox4.Text
            oDepartamento.Ubicacion = Me.TextBox5.Text
            oDepartamento.Ambientes = Me.TextBox6.Text
            oDepartamento.PrecioAlquiler = Me.TextBox7.Text
            oDepartamento.ConectividadWifi = Me.CheckBox2.Checked
            oDepartamento.Piscina = Me.CheckBox4.Checked
            oDepartamento.ServicioAireAcond = Me.CheckBox8.Checked
            oDepartamento.Desayuno = Me.CheckBox6.Checked
            oDepartamento.ServicioTV = Me.CheckBox5.Checked
            Dim bllDepartamento As New BLL_Departamento
            oDepartamento.Mascota = Me.CheckBox3.Checked
            oDepartamento.Cochera = Me.CheckBox12.Checked
            oDepartamento.Cocina = Me.CheckBox9.Checked
            oDepartamento.Amoblado = Me.CheckBox11.Checked
            bllDepartamento.altadep(oDepartamento)
        ElseIf oTipoAlojamiento.ID = 4 Then
            Dim oPosada As New BE_Posada
            oPosada.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
            oPosada.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
            oPosada.Nombre = TextBox1.Text
            oPosada.Descripcion = Me.TextBox3.Text
            oPosada.Estrellas = Me.TextBox4.Text
            oPosada.Ubicacion = Me.TextBox5.Text
            oPosada.Ambientes = Me.TextBox6.Text
            oPosada.PrecioAlquiler = Me.TextBox7.Text
            oPosada.ConectividadWifi = Me.CheckBox2.Checked
            oPosada.Piscina = Me.CheckBox4.Checked
            oPosada.ServicioAireAcond = Me.CheckBox8.Checked
            oPosada.Desayuno = Me.CheckBox6.Checked
            oPosada.ServicioTV = Me.CheckBox5.Checked
            Dim bllPosada As New BLL_Posada
            oPosada.Mascota = Me.CheckBox3.Checked
            bllPosada.altaPosada(oPosada)
        Else
            'Dim oAlojamiento As New BE_Alojamiento
            'oAlojamiento.Destino = DirectCast(ComboBox1.SelectedItem, BE_Destino)
            'oAlojamiento.TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
            'oAlojamiento.Nombre = TextBox1.Text
            'oAlojamiento.Descripcion = Me.TextBox3.Text
            'oAlojamiento.Estrellas = Me.TextBox4.Text
            'oAlojamiento.Ubicacion = Me.TextBox5.Text
            'oAlojamiento.Ambientes = Me.TextBox6.Text
            'oAlojamiento.PrecioAlquiler = Me.TextBox7.Text
            'oAlojamiento.ConectividadWifi = Me.CheckBox2.Checked
            'oAlojamiento.Piscina = Me.CheckBox4.Checked
            'oAlojamiento.ServicioAireAcond = Me.CheckBox8.Checked
            'oAlojamiento.Desayuno = Me.CheckBox6.Checked
            'oAlojamiento.ServicioTV = Me.CheckBox5.Checked

        End If
    End Sub

    Public Sub ocultar()
        CheckBox3.Hide()
        CheckBox12.Hide()
        CheckBox11.Hide()
        CheckBox9.Hide()
        CheckBox13.Hide()
        CheckBox1.Hide()
        CheckBox7.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim oTipoAlojamiento As New BE_TipoAlojamiento
        oTipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        If oTipoAlojamiento.ID = 1 Then

            CheckBox13.Show()
            CheckBox9.Show()

            CheckBox3.Hide()
            CheckBox12.Hide()
            CheckBox11.Hide()
            CheckBox1.Hide()
            CheckBox3.Hide()
            CheckBox7.Hide()




        ElseIf oTipoAlojamiento.ID = 2 Then

            CheckBox1.Show()
            CheckBox3.Show()
            CheckBox7.Show()
            CheckBox12.Show()


            CheckBox11.Hide()
            CheckBox9.Hide()






        ElseIf oTipoAlojamiento.ID = 3 Then
            CheckBox3.Show()
            CheckBox12.Show()
            CheckBox11.Show()
            CheckBox9.Show()


            CheckBox13.Hide()


            CheckBox1.Hide()
            CheckBox7.Hide()


        ElseIf oTipoAlojamiento.ID = 4 Then
            CheckBox3.Show()

            CheckBox12.Hide()
            CheckBox11.Hide()
            CheckBox9.Hide()
            CheckBox13.Hide()
            CheckBox1.Hide()
            CheckBox7.Hide()


        End If




        'Dim opcion As Integer = 4

        'Select Case opcion

        '    Case 1
        '        Dim posada As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '        'posada.ID = "4"
        '        CheckBox3.Show()

        '    Case 2
        '        Dim depart As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '        depart.ID = "3"
        '        CheckBox3.Show()
        '        CheckBox12.Show()
        '        CheckBox11.Show()
        '        CheckBox9.Show()

        '    Case 3
        '        Dim hotel As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '        hotel.ID = "2"
        '        CheckBox1.Show()
        '        CheckBox3.Show()
        '        CheckBox7.Show()
        '        CheckBox12.Show()

        '    Case Else
        '        Dim hostel As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '        hostel.ID = "1"
        '        CheckBox3.Show()
        '        CheckBox12.Show()
        '        CheckBox11.Show()
        '        CheckBox9.Show()
        'End Select



        'If 
        '    Dim posada As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '    posada.ID = "4"
        '    CheckBox3.Show()

        'ElseIf 

        '    Dim depart As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '    depart.ID = "3"
        '    CheckBox3.Show()
        '    CheckBox12.Show()
        '    CheckBox11.Show()
        '    CheckBox9.Show()

        'ElseIf 
        '    Dim hotel As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '    hotel.ID = "2"
        '    CheckBox1.Show()
        '    CheckBox3.Show()
        '    CheckBox7.Show()
        '    CheckBox12.Show()

        'ElseIf 

        '    Dim hostel As BE_TipoAlojamiento = DirectCast(ComboBox2.SelectedItem, BE_TipoAlojamiento)
        '    hostel.ID = "1"
        '    CheckBox3.Show()
        '    CheckBox12.Show()
        '    CheckBox11.Show()
        '    CheckBox9.Show()


        'End If


    End Sub
End Class