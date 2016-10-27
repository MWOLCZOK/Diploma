Imports BLL
Imports EE

Public Class Modificar_Puntaje

    Private Sub Modificar_Puntaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciar()

    End Sub

    Public Sub Iniciar()
        Try
            Cbxpuntaje.SelectedItem = Nothing
            Cbxpuntaje.Items.Clear()
            Txtdescripcion.Text = ""
            Txtpuntaje.Text = ""
            Dim Gestorpuntaje As New BLL_Puntaje
            Dim Listapunt = Gestorpuntaje.consultarPuntaje
            For Each pun In Listapunt
                Cbxpuntaje.Items.Add(pun)
                'Cbxpuntaje.DisplayMember = "Descripcion"

            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Cbxpuntaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpuntaje.SelectedIndexChanged

        If Not IsNothing(Cbxpuntaje.SelectedItem) Then
            Dim Nuevopuntaje As BE_Puntaje = New BE_Puntaje
            Nuevopuntaje = DirectCast(Cbxpuntaje.SelectedItem, BE_Puntaje)
            Me.Txtdescripcion.Text = Nuevopuntaje.Descripcion
            Me.Txtpuntaje.Text = Nuevopuntaje.Coeficiente
        End If

    End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        Dim Gestorpuntaje As New BLL_Puntaje
        Dim puntajemodif As New BE_Puntaje
        Try
            If Not IsNothing(Cbxpuntaje.SelectedItem) Then
                If Not IsNothing(Cbxpuntaje.SelectedItem) And Not String.IsNullOrWhiteSpace(Txtpuntaje.Text) Then
                    puntajemodif = DirectCast(Cbxpuntaje.SelectedItem, BE_Puntaje)
                    puntajemodif.ID = DirectCast(Cbxpuntaje.SelectedItem, BE_Puntaje).ID
                    puntajemodif.Coeficiente = Me.Txtpuntaje.Text
                    Gestorpuntaje.modificarPuntaje(puntajemodif)
                    DataGridView1.DataSource = Nothing
                    MessageBox.Show("Se ha modificado el Puntaje de manera satisfactoria")
                    Dim listColumns As New List(Of String)
                    listColumns.Add("Descripcion")
                    listColumns.Add("Coeficiente")
                    LlenarTabla(DataGridView1, listColumns)
                    DataGridView1.DataSource = Gestorpuntaje.consultarPuntaje()
                    'Iniciar()

                End If
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