Public Class BE_RerservaAlojamiento

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

    Private _cantidadestrellas As Integer
    Public Property CantidadEstrellas() As Integer
        Get
            Return _cantidadestrellas
        End Get
        Set(ByVal value As Integer)
            _cantidadestrellas = value
        End Set
    End Property

    Private _codigo_reserva_alojamiento As Integer
    Public Property CodigoReservaAlojamiento() As Integer
        Get
            Return _codigo_reserva_alojamiento
        End Get
        Set(ByVal value As Integer)
            _codigo_reserva_alojamiento = value
        End Set
    End Property

    Private _nombrealojamiento As String
    Public Property NombreAlojamiento() As String
        Get
            Return _nombrealojamiento
        End Get
        Set(ByVal value As String)
            _nombrealojamiento = value
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


    Private _habitacion As EE.BE_Habitacion
    Public Property Habitacion() As EE.BE_Habitacion
        Get
            Return _habitacion
        End Get
        Set(ByVal value As EE.BE_Habitacion)
            _habitacion = value
        End Set
    End Property

End Class
