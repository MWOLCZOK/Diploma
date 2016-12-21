Public Class BE_Voucher

    Inherits BE_Master

    Private _reserva As BE_Reserva
    Public Property Reserva() As BE_Reserva
        Get
            Return _reserva
        End Get
        Set(ByVal value As BE_Reserva)
            _reserva = value
        End Set
    End Property

    Private _tipoReserva As TipoReserva
    Public Property TipoReserva() As TipoReserva
        Get
            Return _tipoReserva
        End Get
        Set(ByVal value As TipoReserva)
            _tipoReserva = value
        End Set
    End Property

    Private _fechaEmision As Date
    Public Property FechaEmision() As Date
        Get
            Return _fechaEmision
        End Get
        Set(ByVal value As Date)
            _fechaEmision = value
        End Set
    End Property

    Private _BL As Boolean
    Public Property BL() As Boolean
        Get
            Return _BL
        End Get
        Set(ByVal value As Boolean)
            _BL = value
        End Set
    End Property



End Class
