Public Class BE_ReservaAlojamiento

    Inherits BE_Reserva

    Private _habitacion As EE.BE_Habitacion
    Public Property Habitacion() As EE.BE_Habitacion
        Get
            Return _habitacion
        End Get
        Set(ByVal value As EE.BE_Habitacion)
            _habitacion = value
        End Set
    End Property

    Private _fecha_fin As Date
    Public Property Fecha_Fin() As Date
        Get
            Return _fecha_fin
        End Get
        Set(ByVal value As Date)
            _fecha_fin = value
        End Set
    End Property

    Private _fecha_inicio As Date
    Public Property Fecha_Inicio() As Date
        Get
            Return _fecha_inicio
        End Get
        Set(ByVal value As Date)
            _fecha_inicio = value
        End Set
    End Property


End Class
