Public Class BE_VoucherViaje

    Inherits BE_Voucher

    Private _claseviaje As String
    Public Property ClaseViaje() As String
        Get
            Return _claseviaje
        End Get
        Set(ByVal value As String)
            _claseviaje = value
        End Set
    End Property

    Private _duracionviaje As DateTime
    Public Property DuracionViaje() As DateTime
        Get
            Return _duracionviaje
        End Get
        Set(ByVal value As DateTime)
            _duracionviaje = value
        End Set
    End Property

    Private _estadoviaje As String
    Public Property EstadoViaje() As String
        Get
            Return _estadoviaje
        End Get
        Set(ByVal value As String)
            _estadoviaje = value
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

    Private _fechavuelta As Date
    Public Property FechaVuelta() As Date
        Get
            Return _fechavuelta
        End Get
        Set(ByVal value As Date)
            _fechavuelta = value
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

    Private _horariosalida As DateTime
    Public Property HorarioSalida() As DateTime
        Get
            Return _horariosalida
        End Get
        Set(ByVal value As DateTime)
            _horariosalida = value
        End Set
    End Property

    Private _terminal As String
    Public Property Terminal() As String
        Get
            Return _terminal
        End Get
        Set(ByVal value As String)
            _terminal = value
        End Set
    End Property

End Class
