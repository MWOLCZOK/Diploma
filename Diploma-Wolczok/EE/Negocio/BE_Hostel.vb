Public Class BE_Hostel

    Inherits BE_Alojamiento


    Private _cocina As Boolean
    Public Property Cocina() As Boolean
        Get
            Return _cocina
        End Get
        Set(ByVal value As Boolean)
            _cocina = value
        End Set
    End Property

    Private _habitacionPrivada As Boolean
    Public Property HabitacionPrivada() As Boolean
        Get
            Return _habitacionPrivada
        End Get
        Set(ByVal value As Boolean)
            _habitacionPrivada = value
        End Set
    End Property



End Class
