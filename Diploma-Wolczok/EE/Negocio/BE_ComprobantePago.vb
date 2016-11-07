Public Class BE_ComprobantePago

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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

    Private _formadepago As String
    Public Property FormadePago() As String
        Get
            Return _formadepago
        End Get
        Set(ByVal value As String)
            _formadepago = value
        End Set
    End Property

    Private _importe As Integer
    Public Property Importe() As Integer
        Get
            Return _importe
        End Get
        Set(ByVal value As Integer)
            _importe = value
        End Set
    End Property


    Private _Impuestos As Double
    Public Property Impuestos() As Double
        Get
            Return _Impuestos
        End Get
        Set(ByVal value As Double)
            _Impuestos = value
        End Set
    End Property


    Private _nrocomprobante As Double
    Public Property NroComprobante() As Double
        Get
            Return _nrocomprobante
        End Get
        Set(ByVal value As Double)
            _nrocomprobante = value
        End Set
    End Property


    Private _pago As BE_PagoViaje
    Public Property Pago() As BE_PagoViaje
        Get
            Return _pago
        End Get
        Set(ByVal value As BE_PagoViaje)
            _pago = value
        End Set
    End Property














End Class
