Public Class BE_Pasajero

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _correoelectronico As String
    Public Property CorreoElectronico() As String
        Get
            Return _correoelectronico
        End Get
        Set(ByVal value As String)
            _correoelectronico = value
        End Set
    End Property

    Private _dni As Integer
    Public Property DNI() As Integer
        Get
            Return _dni
        End Get
        Set(ByVal value As Integer)
            _dni = value
        End Set
    End Property


    Private _domicilio As String
    Public Property Domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
        End Set
    End Property


    Private _puntajealojamiento As Double
    Public Property PuntajeAlojamiento() As Double
        Get
            Return _puntajealojamiento
        End Get
        Set(ByVal value As Double)
            _puntajealojamiento = value
        End Set
    End Property



    Private _puntajeviaje As Double
    Public Property PuntajeViaje() As Double
        Get
            Return _puntajeviaje
        End Get
        Set(ByVal value As Double)
            _puntajeviaje = value
        End Set
    End Property

    Private _telefono As Double
    Public Property Telefono() As Double
        Get
            Return _telefono
        End Get
        Set(ByVal value As Double)
            _telefono = value
        End Set
    End Property

    'Private _reserva As BE_Reserva
    'Public Property Reserva() As BE_Reserva
    '    Get
    '        Return _reserva
    '    End Get
    '    Set(ByVal value As BE_Reserva)
    '        _reserva = value
    '    End Set
    'End Property

    Private _reserva As Integer
    Public Property Reserva() As Integer
        Get
            Return _reserva
        End Get
        Set(ByVal value As Integer)
            _reserva = value
        End Set
    End Property

    'Public Overrides Function ToString() As String
    '    Return Me.Nombre And Me.Apellido
    'End Function

    Public ReadOnly Property NombreApellido As String
        Get
            Return Nombre & " " & Apellido
        End Get
    End Property

End Class
