Public Class BE_Reserva

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

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

End Class
