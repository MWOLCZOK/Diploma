Public Class BE_Pago

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



    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _metodopago As BE_Metodopago
    Public Property Metodopago() As BE_Metodopago
        Get
            Return _metodopago
        End Get
        Set(ByVal value As BE_Metodopago)
            _metodopago = value
        End Set
    End Property


    Private _monto As Integer
    Public Property Monto() As Integer
        Get
            Return _monto
        End Get
        Set(ByVal value As Integer)
            _monto = value
        End Set
    End Property



    Private _finpago As Boolean
    Public Property Finpago() As Boolean
        Get
            Return _finpago
        End Get
        Set(ByVal value As Boolean)
            _finpago = value
        End Set
    End Property

    Private _detalle As String
    Public Property NumeroTarjeta() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property

    Private _estado As Boolean
    Public Property Estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return Me.NumeroTarjeta

    End Function


End Class
