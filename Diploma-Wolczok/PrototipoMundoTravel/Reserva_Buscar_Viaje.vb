Imports BLL
Imports EE

Public Class Reserva_Buscar_Viaje

    Private Sub Reserva_Buscar_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
        llenarcombosdestino()
        llenarcombosorigen()

    End Sub


    Private Sub cargarCombos()

        Dim oListatipotrans As New List(Of BE_TipoTransporte)
        Dim blltipotrans As New BLL_TipoTransporte
        oListatipotrans = blltipotrans.consultarTipoTransportes

        For Each mitrans As BE_TipoTransporte In oListatipotrans
            Me.ComboBox1.Items.Add(mitrans)

        Next
    End Sub

    Private Sub llenarcombosdestino()
        Dim oListaDestinos As New List(Of BE_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.Cbxdestino.Items.Add(miDest)
            Cbxdestino.DisplayMember = "NombreCompleto"
        Next
    End Sub

    Private Sub llenarcombosorigen()
        Dim oListaDestinos As New List(Of BE_Destino)
        Dim bllDestino As New BLL_Destino
        oListaDestinos = bllDestino.consultarDestinos
        For Each miDest As BE_Destino In oListaDestinos
            Me.Cbxorigen.Items.Add(miDest)
            Cbxorigen.DisplayMember = "NombreCompleto"
        Next
    End Sub




    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Try
            Dim oListaViaje As New List(Of BE_Viaje)
            Dim bllViaje As New BLL.BLL_Viaje
            Dim oOrigen As BE_Destino = DirectCast(Cbxorigen.SelectedItem, BE_Destino)
            Dim oDestino As BE_Destino = DirectCast(Cbxdestino.SelectedItem, BE_Destino)
            Dim oTipoTransrpote As BE_TipoTransporte = DirectCast(ComboBox1.SelectedItem, BE_TipoTransporte)
            oListaViaje = bllViaje.consultarviajes(oOrigen, oDestino, Me.DateTimePicker1.Value, oTipoTransrpote)


            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = oListaViaje
            DataGridView1.ReadOnly = True
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Btnseleccionar_Click(sender As Object, e As EventArgs) Handles Btnseleccionar.Click
        Try

            Dim oViaje As New BE_Viaje
            oViaje.ID = CInt(Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            Dim bllViaje As New BLL.BLL_Viaje
            oViaje = bllViaje.consultarviaje(oViaje)
            Dim oReservaViaje As New BE_ReservaViaje
            oReservaViaje.viaje = oViaje
            oReservaViaje.Detalle = "Prueba"
            Dim oOrigen As New BE_Destino
            oOrigen = DirectCast(Me.Cbxorigen.SelectedItem, BE_Destino)
            Dim oDestino As New BE_Destino
            oDestino = DirectCast(Me.Cbxdestino.SelectedItem, BE_Destino)
            Dim formularioreservaasientos As New Reserva_Buscar_Asientos(oViaje, oReservaViaje, oOrigen, oDestino)
            formularioreservaasientos.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("No se pudo cargar correctamente los datos", MsgBoxStyle.Exclamation, "Error Base de Datos")
        End Try

    End Sub
End Class