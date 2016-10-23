Imports BLL
Imports EE


Public Class Agregar_Provincia

    Private Sub Agregar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()

    End Sub

    Private Sub cargarCombos()
        Dim oListaPaises As New List(Of EE.BE_Pais)
        Dim bllPais As New BLL.BLL_Pais
        oListaPaises = bllPais.ConsultarPaises()
        For Each mipais As EE.BE_Pais In oListaPaises
            Me.ComboBox1.Items.Add(mipais)
        Next

    End Sub


    Private Function validarformulario() As Boolean
        Try
            If Me.Txtdescripcion.Text = "" Or Me.Txthabitantes.Text = "" Or Me.Txtregion.Text = "" Or Me.Txtsuperficieterrestre.Text = "" Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Btn_agregarprovincia_Click(sender As Object, e As EventArgs) Handles Btn_agregarprovincia.Click
        Try
            If validarformulario() = True Then
                Dim oProvincia As New BE_Provincia
                Dim bllProvincia As New BLL_Provincia
                oProvincia.Descripcion = Txtdescripcion.Text
                oProvincia.Habitantes = Txthabitantes.Text
                oProvincia.Region = Txtregion.Text
                oProvincia.SuperficieTerrestre = Txtsuperficieterrestre.Text
                Dim oPais As New BE_Pais
                oPais.ID = DirectCast(ComboBox1.SelectedItem, BE_Pais).ID
                oProvincia.Pais = oPais
                bllProvincia.altaprovincia(oProvincia)
                MsgBox("Se ha agregado correctamente la provincia")
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class