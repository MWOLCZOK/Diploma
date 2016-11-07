Public Class BE_PagoViaje

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _idreserva As BE_ReservaViaje
    Public Property ID_Reservaviaje() As BE_ReservaViaje
        Get
            Return _idreserva
        End Get
        Set(ByVal value As BE_ReservaViaje)
            _idreserva = value
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

    Private _idmetodopago As BE_Metodopago
    Public Property ID_Metodopago() As BE_Metodopago
        Get
            Return _idmetodopago
        End Get
        Set(ByVal value As BE_Metodopago)
            _idmetodopago = value
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
    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property




End Class
