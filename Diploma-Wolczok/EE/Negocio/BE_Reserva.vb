Public Class BE_Reserva

    Inherits BE_Master
    Private _nro_reserva As Integer
    Public Property NumeroReserva() As Integer
        Get
            Return _nro_reserva
        End Get
        Set(ByVal value As Integer)
            _nro_reserva = value
        End Set
    End Property


    Private _detalle As String
    Public Property Detalle() As String
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

    Private _pasajero As EE.BE_Pasajero
    Public Property Pasajero() As EE.BE_Pasajero
        Get
            Return _pasajero
        End Get
        Set(ByVal value As EE.BE_Pasajero)
            _pasajero = value
        End Set
    End Property

    Private _puntaje As Double
    Public Property puntaje() As Double
        Get
            Return _puntaje
        End Get
        Set(ByVal value As Double)
            _puntaje = value
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


    Private _Pago As New List(Of BE_Pago)
    Public Property Pagoviaje() As List(Of BE_Pago)
        Get
            Return _pago
        End Get
        Set(ByVal value As List(Of BE_Pago))
            _pago = value
        End Set
    End Property

    Private _montoReserva As Double
    Public Property MontoReserva() As Double
        Get
            Return _montoReserva
        End Get
        Set(ByVal value As Double)
            _montoReserva = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.ID
    End Function

End Class

Public Enum TipoReserva
    Viaje = 1
    Alojamiento = 2
End Enum