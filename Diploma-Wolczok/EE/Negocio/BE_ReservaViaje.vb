Public Class BE_ReservaViaje

    Inherits BE_Reserva

    Private _apellidopasajero As String
    Public Property ApellidoPasajero() As String
        Get
            Return _apellidopasajero
        End Get
        Set(ByVal value As String)
            _apellidopasajero = value
        End Set
    End Property

    Private _cantidadmillas As Integer
    Public Property CantidadMillas() As Integer
        Get
            Return _cantidadmillas
        End Get
        Set(ByVal value As Integer)
            _cantidadmillas = value
        End Set
    End Property

    Private _codigo_reserva_transporte As Integer
    Public Property CodigoReservaTransporte() As Integer
        Get
            Return _codigo_reserva_transporte
        End Get
        Set(ByVal value As Integer)
            _codigo_reserva_transporte = value
        End Set
    End Property

    Private _destino As String
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    Private _duracion_viaje As Integer
    Public Property DuracionViaje() As Integer
        Get
            Return _duracion_viaje
        End Get
        Set(ByVal value As Integer)
            _duracion_viaje = value
        End Set
    End Property

    Private _empresatransporte As String
    Public Property EmpresaTransporte() As String
        Get
            Return _empresatransporte
        End Get
        Set(ByVal value As String)
            _empresatransporte = value
        End Set
    End Property

    Private _escala As Boolean
    Public Property Escala() As Boolean
        Get
            Return _escala
        End Get
        Set(ByVal value As Boolean)
            _escala = value
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

    Private _viaje As BE_Viaje
    Public Property Viaje() As BE_Viaje
        Get
            Return _viaje
        End Get
        Set(ByVal value As BE_Viaje)
            _viaje = value
        End Set
    End Property




End Class
