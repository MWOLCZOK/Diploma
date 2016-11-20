
Public Class visualizarBitacora

    Private Sub visualizarBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        Dim gestorbitacora As New BLL.BLL_Bitacora
        Me.dgvBitacora.DataSource = Nothing
        Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora
        EstablecerGrid()
    End Sub

    Private Sub llenarCombos()
        Dim gestorusuario As New BLL.BLL_Usuario
        Dim Listausuarios = gestorusuario.consultarUsuarios
        For Each Usuario In Listausuarios
            ComboBox1.Items.Add(Usuario)
        Next
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Alta)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Baja)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Modificación)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Errores)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Login)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Backup)
        ComboBox2.Items.Add(EE.BE_TipoBitacora.Restore)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub EstablecerGrid()
        Me.dgvBitacora.Columns.Remove("ID_Bitacora")
        Me.dgvBitacora.Columns("Codigo").Name = "Column_Codigo"
        Me.dgvBitacora.Columns("Fecha").Name = "Column_Fecha"
        Me.dgvBitacora.Columns("Usuario").Name = "Column_Usuario"
        Me.dgvBitacora.Columns("Detalle").Name = "Column_Detalle"
        '    Me.dgvBitacora.Columns("Column_Codigo").HeaderText = ControladorTraductor.TraducirMensaje("Column_Codigo")
        '   Me.dgvBitacora.Columns("Column_Fecha").HeaderText = ControladorTraductor.TraducirMensaje("Column_Fecha")
        '  Me.dgvBitacora.Columns("Column_Usuario").HeaderText = ControladorTraductor.TraducirMensaje("Column_Usuario")
        '  Me.dgvBitacora.Columns("Column_Detalle").HeaderText = ControladorTraductor.TraducirMensaje("Column_Detalle")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim gestorbitacora As New BLL.BLL_Bitacora
        If IsNothing(ComboBox1.SelectedItem) Then
            If IsNothing(ComboBox2.SelectedItem) Then
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(, , DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            Else
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(, DirectCast(ComboBox2.SelectedItem, EE.BE_TipoBitacora), DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            End If
        Else
            If IsNothing(ComboBox2.SelectedItem) Then
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(DirectCast(ComboBox1.SelectedItem, EE.BE_Usuario), , DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            Else
                Me.dgvBitacora.DataSource = Nothing
                Me.dgvBitacora.DataSource = gestorbitacora.ConsultarBitacora(DirectCast(ComboBox1.SelectedItem, EE.BE_Usuario), DirectCast(ComboBox2.SelectedItem, EE.BE_TipoBitacora), DateTimePicker1.Value, DateTimePicker2.Value)
                EstablecerGrid()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Try
            worksheet = workbook.ActiveSheet
            worksheet.Name = "Bitacora MundoTravel"
            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1
            'Loop through each row and read value from each column.
            For i As Integer = 0 To dgvBitacora.Rows.Count - 2
                For j As Integer = 0 To dgvBitacora.Columns.Count - 1
                    ' Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                    If cellRowIndex = 1 Then
                        worksheet.Cells(cellRowIndex, cellColumnIndex) = dgvBitacora.Columns(j).HeaderText
                    Else
                        worksheet.Cells(cellRowIndex, cellColumnIndex) = dgvBitacora.Rows(i).Cells(j).Value.ToString()
                    End If
                    cellColumnIndex += 1
                Next
                cellColumnIndex = 1
                cellRowIndex += 1
            Next
            'Getting the location and file name of the excel to save from user.
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 2

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(saveDialog.FileName)
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try

    End Sub
End Class