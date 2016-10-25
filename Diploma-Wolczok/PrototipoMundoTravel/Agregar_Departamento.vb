Imports EE
Imports BLL


Public Class Agregar_Departamento

    Private Sub Agregar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Function validarFormulario() As Boolean
        Try
            If Me.Txtnombre.Text = "" Or Me.Txtcantidadamb.Text = "" Or Me.Txtcantidadbañ.Text = "" Or Me.Txttipoedif.Text = "" Or Me.Txtcategoria.Text = "" Or Me.Txtdescrip.Text = "" Or Me.Txtprecioalquiler.Text = "" Or Me.Txttipoaloj.Text = "" Or Me.Txttipocama.Text = "" Or Me.Txttipohab.Text = "" Or Me.Txtubic.Text = "" Then Return False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Private Sub Btn_agregarlocalidad_Click(sender As Object, e As EventArgs) Handles Btn_agregardepto.Click
        Try
            If validarFormulario() = True Then
                Dim odep As New BE_Departamento
                Dim bllDep As New BLL_Departamento
                odep.Nombre = Me.Txtnombre.Text
                odep.CantidadAmbientes = Me.Txtcantidadamb.Text
                odep.CantidadBaños = Me.Txtcantidadbañ.Text
                odep.Cochera = Me.Ckbxcochera.Checked
                odep.TipoEdificio = Me.Txttipoedif.Text
                odep.Categoria = Me.Txtcategoria.Text
                odep.ConectividadWIFI = Me.ckbxwifi.Checked
                odep.Descripcion = Me.Txtdescrip.Text
                odep.Gimnasio = Me.Ckbgym.Checked
                odep.Mascota = Me.ckbxmascotas.Checked
                odep.Piscina = Me.ckbxpiscina.Checked
                odep.PrecioAlquiler = Me.Txtprecioalquiler.Text
                odep.Sauna = Me.Ckboxsauna.Checked
                odep.ServicioAireAcond = Me.Ckbxaireacond.Checked
                odep.Desayuno = Me.ckbxdesayuno.Checked
                odep.ServicioTV = Me.ckbxtv.Checked
                odep.TipoAlojamiento = Me.Txttipoaloj.Text
                odep.TipoCama = Me.Txttipocama.Text
                odep.TipoHabitacion = Me.Txttipohab.Text
                odep.Ubicacion = Me.Txtubic.Text
                bllDep.altadep(odep)
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxdesayuno.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class