Imports EE
Imports BLL

Public Class SeleccionarHabitacionReserva

    Sub New(ByVal paramAlojamiento As BE_Alojamiento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MsgBox(paramAlojamiento.ID)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub SeleccionarHabitacionReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class