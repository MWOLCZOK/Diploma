Public Class BE_Pago

    Private _formadepago As String
    Public Property FormadePago() As String
        Get
            Return _formadepago
        End Get
        Set(ByVal value As String)
            _formadepago = value
        End Set
    End Property

    Private _importetotal As Double
    Public Property ImporteTotal() As Double
        Get
            Return _importetotal
        End Get
        Set(ByVal value As Double)
            _importetotal = value
        End Set
    End Property

    Private _impuestos As Double
    Public Property Impuestos() As Double
        Get
            Return _impuestos
        End Get
        Set(ByVal value As Double)
            _impuestos = value
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
