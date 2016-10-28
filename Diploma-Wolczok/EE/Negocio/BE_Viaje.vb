Public Class BE_Viaje

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _transporte As BE_Transporte
    Public Property Transporte() As BE_Transporte
        Get
            Return _transporte
        End Get
        Set(ByVal value As BE_Transporte)
            _transporte = value
        End Set
    End Property

    Private _fechaHoraLlegada As DateTime
    Public Property FechaHoraLlegada() As DateTime
        Get
            Return _fechaHoraLlegada
        End Get
        Set(ByVal value As DateTime)
            _fechaHoraLlegada = value
        End Set
    End Property

    Private _fechaHoraSalida As DateTime
    Public Property FechaHoraSalida() As DateTime
        Get
            Return _fechaHoraSalida
        End Get
        Set(ByVal value As DateTime)
            _fechaHoraSalida = value
        End Set
    End Property

    Private _precio As Double
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    Private _origen As BE_Destino
    Public Property Origen() As BE_Destino
        Get
            Return _origen
        End Get
        Set(ByVal value As BE_Destino)
            _origen = value
        End Set
    End Property

    Private _destino As BE_Destino
    Public Property Destino() As BE_Destino
        Get
            Return _destino
        End Get
        Set(ByVal value As BE_Destino)
            _destino = value
        End Set
    End Property

End Class
