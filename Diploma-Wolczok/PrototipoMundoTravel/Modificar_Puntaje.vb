Imports BLL
Imports EE

Public Class Modificar_Puntaje
    Implements BLL.BLL_Iobservador

    Private Sub Modificar_Puntaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Iniciar()
            SessionBLL.SesionActual.agregarForm(Me)
            SessionBLL.SesionActual.notificarCambiodeIdioma()
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
            Throw New errorObtencionDeDatosException
        End Try
    End Sub


    Private Sub Cbxpuntaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbxpuntaje.SelectedIndexChanged
        Try
            If Not IsNothing(Cbxpuntaje.SelectedItem) Then
                Dim Nuevopuntaje As BE_Puntaje = New BE_Puntaje
                Nuevopuntaje = DirectCast(Cbxpuntaje.SelectedItem, BE_Puntaje)
                Me.Txtdescripcion.Text = Nuevopuntaje.Descripcion
                Me.Txtpuntaje.Text = Nuevopuntaje.Coeficiente
            End If
        Catch ex As errorObtencionDeDatosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
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


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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
                    MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_122"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim listColumns As New List(Of String)
                    listColumns.Add("Descripcion")
                    listColumns.Add("Coeficiente")
                    LlenarTabla(DataGridView1, listColumns)
                    DataGridView1.DataSource = Gestorpuntaje.consultarPuntaje()
                    'Iniciar()
                Else
                    Throw New CamposIncompletosException
                End If
            Else
                Throw New CamposIncorrectosException
            End If
        Catch ex As CamposIncorrectosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As CamposIncompletosException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As errorEnEditException
            MessageBox.Show(ex.Mensaje, ex.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))
    End Sub

    Private Sub Modificar_Puntaje_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Modificar Puntaje")
    End Sub
End Class