Imports DAL
Imports EE


Public Class BLL_Cancelacion

    Dim _cancelacion As New DAL_Cancelacion

    Public Sub alta(ByVal paramCancelacion As BE_Cancelacion)
        Try
            '   LA DESCRIPCION VIENE EN EL OBJETO DESDE EL FORMULARIO

            '   ACTUALIZAR EL ESTADO DE LA RESERVA


            '   ACTUALIZAR EL ESTADO DE LOS PAGOS DE LA RESERVA


            '   AGREGAR DATOS DE LA CANCELACION
            _cancelacion.alta(paramCancelacion)
        Catch ex As Exception
        End Try
    End Sub





End Class
