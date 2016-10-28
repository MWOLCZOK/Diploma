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
        'Try
        '    Dim oListatipotrans As New List(Of BE_TipoTransporte)
        '    Dim bllTipotransp As New BLL_TipoTransporte
        '    oListatipotrans = bllTipotransp.consultarTipotransporte(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_TipoTransporte), Cbxdestino, BE_Destino
        '    DataGridView1.DataSource = Nothing
        '    DataGridView1.DataSource = oListatipotrans
        '    DataGridView1.ReadOnly = True
        '    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        'Catch ex As Exception

        'End Try


    End Sub
End Class