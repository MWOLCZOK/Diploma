Public Class BE_ReservaViaje

    Inherits BE_Reserva

    Private _viaje As BE_Viaje
    Public Property viaje() As BE_Viaje
        Get
            Return _viaje
        End Get
        Set(ByVal value As BE_Viaje)
            _viaje = value
        End Set
    End Property

    Private _asiento As BE_Asiento
    Public Property Asiento() As BE_Asiento
        Get
            Return _asiento
        End Get
        Set(ByVal value As BE_Asiento)
            _asiento = value
        End Set
    End Property

    'Private _pago As BE_PagoViaje
    'Public Property PagoViaje() As BE_PagoViaje
    '    Get
    '        Return _pago
    '    End Get
    '    Set(ByVal value As BE_PagoViaje)
    '        _pago = value
    '    End Set
    'End Property

    Private _Pago As New List(Of BE_PagoViaje)
    Public Property Pagoviaje() As List(Of BE_PagoViaje)
        Get
            Return _pago
        End Get
        Set(ByVal value As List(Of BE_PagoViaje))
            _pago = value
        End Set
    End Property

    




End Class
