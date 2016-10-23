Imports EE

Public Class Agregar_Hotel

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oHotel As New BE_Hotel
        oHotel.ConectividadWIFI = Me.chkConectividadWifi.Checked
        MsgBox(oHotel.ConectividadWIFI)
    End Sub
End Class