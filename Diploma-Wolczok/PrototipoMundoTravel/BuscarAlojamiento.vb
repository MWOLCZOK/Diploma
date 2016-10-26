﻿Imports BLL
Imports EE

Public Class BuscarAlojamiento

    Private Sub BuscarAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub

    Private Sub cargarCombos()
        Dim oListaDestino As New List(Of EE.BE_Destino)
        Dim bllDestino As New BLL.BLL_Destino
        oListaDestino = bllDestino.consultarDestinos
        For Each miDestino As EE.BE_Destino In oListaDestino
            Me.ComboBox1.Items.Add(miDestino)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oListaAlojamiento As New List(Of EE.BE_Alojamiento)
            Dim bllAlojamiento As New BLL.BLL_Alojamiento
            oListaAlojamiento = bllAlojamiento.consultarAlojamiento(DirectCast(Me.ComboBox1.SelectedItem, EE.BE_Destino), Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = oListaAlojamiento
            DataGridView1.ReadOnly = True

            'Dim listColumns As New List(Of String)
            'listColumns.Add("ID")
            'listColumns.Add("Categoria")
            'listColumns.Add("ConectividadWIFI")
            'LlenarTabla(DataGridView1, listColumns)
            'DataGridView1.DataSource = oListaAlojamiento

        Catch ex As Exception

        End Try
    End Sub

    'Shared Sub LlenarTabla(dvg As DataGridView, list As List(Of String))
    '    Dim cantidad As Integer = list.Count
    '    Dim i = 0
    '    dvg.ColumnCount = cantidad
    '    dvg.AutoGenerateColumns = False

    '    For Each item In list
    '        dvg.Columns(i).Name = item
    '        dvg.Columns(i).DataPropertyName = item
    '        dvg.Columns(i).HeaderText = item
    '        i = i + 1
    '    Next
    '    dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    'End Sub

End Class