Public MustInherit Class BE_Voucher

    Private _apellidopasajero As String
    Public Property ApellidoPasajero() As String
        Get
            Return _apellidopasajero
        End Get
        Set(ByVal value As String)
            _apellidopasajero = value
        End Set
    End Property

    Private _codigoconfirmacion As Integer
    Public Property CodigoConfirmacion() As Integer
        Get
            Return _codigoconfirmacion
        End Get
        Set(ByVal value As Integer)
            _codigoconfirmacion = value
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

    Private _fechaemision As Date
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
        End Set
    End Property


    Private _nombrepasajero As String
    Public Property NombrePasajero() As String
        Get
            Return _nombrepasajero
        End Get
        Set(ByVal value As String)
            _nombrepasajero = value
        End Set
    End Property

    Private _nrovoucher As Integer
    Public Property NroVoucher() As Integer
        Get
            Return _nrovoucher
        End Get
        Set(ByVal value As Integer)
            _nrovoucher = value
        End Set
    End Property


    Private _reserva As BE_Reserva
    Public Property Reserva() As BE_Reserva
        Get
            Return _reserva
        End Get
        Set(ByVal value As BE_Reserva)
            _reserva = value
        End Set
    End Property








End Class
