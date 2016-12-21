Public Class BE_Viaje

    Inherits BE_Master
    Private _transporte As BE_Transporte
    Public Property Transporte() As BE_Transporte
        Get
            Return _transporte
        End Get
        Set(ByVal value As BE_Transporte)
            _transporte = value
        End Set
    End Property

    Private _fechaHoraLlegada As Date
    Public Property FechaHoraLlegada() As Date
        Get
            Return _fechaHoraLlegada
        End Get
        Set(ByVal value As Date)
            _fechaHoraLlegada = value
        End Set
    End Property


    Private _fechaHoraSalida As Date
    Public Property FechaHoraSalida() As Date
        Get
            Return _fechaHoraSalida
        End Get
        Set(ByVal value As Date)
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


    Private _cena As Boolean
    Public Property Cena() As Boolean
        Get
            Return _cena
        End Get
        Set(ByVal value As Boolean)
            _cena = value
        End Set
    End Property

    Private _almuerzo As Boolean
    Public Property Almuerzo() As Boolean
        Get
            Return _almuerzo
        End Get
        Set(ByVal value As Boolean)
            _almuerzo = value
        End Set
    End Property

    Private _cafeteria As Boolean
    Public Property Cafeteria() As Boolean
        Get
            Return _cafeteria
        End Get
        Set(ByVal value As Boolean)
            _cafeteria = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Destino.Localidad.NombreCompleto
    End Function

    'Public Overrides Function ToString() As String
    '    Return Me.Origen.Localidad.NombreCompleto
    'End Function



End Class
