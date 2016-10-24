Imports EE
Imports BLL


Public Class Agregar_Departamento

    Private Sub Agregar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Function validarFormulario() As Boolean
        Try
            If Me.Txtnombre.Text = "" Or Me.Txtcantidadamb.Text = "" Or Me.Txtcantidadbañ.Text = "" Or Me.Txtcochera.Text = "" Or Me.Txttipoedif.Text = "" Or Me.Txtcategoria.Text = "" Or Me.Txtconectividadwifi.Text = "" Or Me.Txtdescrip.Text = "" Or Me.Txtgimnasio.Text = "" Or Me.Txtmascotas.Text = "" Or Me.Txtpiscina.Text = "" Or Me.Txtprecioalquiler.Text = "" Or Me.Txtsauna.Text = "" Or Me.Txtservicioaireacond.Text = "" Or Me.Txtdesayuno.Text = "" Or Me.Txtserviciotv.Text = "" Or Me.Txttipoaloj.Text = "" Or Me.Txttipocama.Text = "" Or Me.Txttipohab.Text = "" Or Me.Txtubic.Text = "" Then Return False
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
                odep.Cochera = Me.Txtcochera.Text
                odep.TipoEdificio = Me.Txttipoedif.Text
                odep.Categoria = Me.Txtcategoria.Text
                odep.ConectividadWIFI = Me.Txtconectividadwifi.Text
                odep.Descripcion = Me.Txtdescrip.Text
                odep.Gimnasio = Me.Txtgimnasio.Text
                odep.Mascota = Me.Txtmascotas.Text
                odep.Piscina = Me.Txtpiscina.Text
                odep.PrecioAlquiler = Me.Txtprecioalquiler.Text
                odep.Sauna = Me.Txtsauna.Text
                odep.ServicioAireAcond = Me.Txtservicioaireacond.Text
                odep.Desayuno = Me.Txtdesayuno.Text
                odep.ServicioTV = Me.Txtserviciotv.Text
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

End Class