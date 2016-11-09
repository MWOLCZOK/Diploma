Imports EE
Imports BLL

Public Class Agregar_Localidad

    Private Sub Agregar_Localidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()

    End Sub


    Private Sub cargarCombos()
        Dim oListaProvincia As New List(Of EE.BE_Provincia)
        Dim bllProvincia As New BLL.BLL_Provincia
        oListaProvincia = bllProvincia.Consultarprovincias
        For Each miProv As EE.BE_Provincia In oListaProvincia
            Me.ComboBox1.Items.Add(miProv)
        Next

    End Sub



    Private Function validarFormulario() As Boolean
        Try
            If Me.Txtdescripcion.Text = "" Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If validarFormulario() = True Then
                Dim oLoc As New BE_Localidad
                Dim bllLoc As New BLL_Localidad
                oLoc.Descripcion = Me.Txtdescripcion.Text
                oLoc.CantidadBarrios = Me.NumericUpDown1.Value
                oLoc.Habitantes = Me.NumericUpDown2.Value
                Dim oProvincia As New BE_Provincia
                oProvincia.ID = DirectCast(ComboBox1.SelectedItem, BE_Provincia).ID
                oLoc.Provincia = oProvincia
                bllLoc.altalocalidad(oLoc)
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class