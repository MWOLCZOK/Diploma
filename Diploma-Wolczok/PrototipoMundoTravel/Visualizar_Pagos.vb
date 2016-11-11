Imports EE
Imports BLL



Public Class Visualizar_Pagos

    Private Sub Visualizar_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Nothing
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Try
            If TextBox9.Text.Length >= 3 Then
                Dim oPasajero As New BE_Pasajero
                Dim oReservaviaje As New BE_ReservaViaje
                Dim oPagoviaje As New BE_PagoViaje
                oPasajero.DNI = Me.TextBox9.Text
                oReservaviaje.Pasajero = oPasajero


                Dim bllPagoViaje As New BLL_PagoViaje
                Dim oListapago As New List(Of BE_PagoViaje)
                oListapago = bllPagoViaje.consultarPagosViajes(oReservaviaje)

              
                Dim listColumns As New List(Of String)
                listColumns.Add("Fecha")
                listColumns.Add("Metodopago")
                listColumns.Add("Monto")
                listColumns.Add("Numerotarjeta")
                LlenarTabla(DataGridView1, listColumns)
                'DataGridView1.DataSource = oListaAlojamiento
                Me.DataGridView1.DataSource = oListapago
                DataGridView1.ReadOnly = True
                'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells




            End If
        Catch ex As Exception

        End Try

    End Sub


    Shared Sub LlenarTabla(dvg As DataGridView, list As List(Of String))
        Dim cantidad As Integer = list.Count
        Dim i = 0
        dvg.ColumnCount = cantidad
        dvg.AutoGenerateColumns = False

        For Each item In list
            dvg.Columns(i).Name = item
            dvg.Columns(i).DataPropertyName = item
            dvg.Columns(i).HeaderText = item
            i = i + 1
        Next
        dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


End Class