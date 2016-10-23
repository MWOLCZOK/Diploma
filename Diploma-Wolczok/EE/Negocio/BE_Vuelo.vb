Public Class BE_Vuelo

    Private _fechallegada As Date
    Public Property FechaLlegada() As Date
        Get
            Return _fechallegada
        End Get
        Set(ByVal value As Date)
            _fechallegada = value
        End Set
    End Property

    Private _fechapartida As Date
    Public Property FechaPartida() As Date
        Get
            Return _fechapartida
        End Get
        Set(ByVal value As Date)
            _fechapartida = value
        End Set
    End Property


    Private _horariollegada As DateTime
    Public Property HorarioLlegada() As DateTime
        Get
            Return _horariollegada
        End Get
        Set(ByVal value As DateTime)
            _horariollegada = value
        End Set
    End Property

    Private _horariopartida As Date
    Public Property HorarioPartida() As Date
        Get
            Return _horariopartida
        End Get
        Set(ByVal value As Date)
            _horariopartida = value
        End Set
    End Property






End Class
