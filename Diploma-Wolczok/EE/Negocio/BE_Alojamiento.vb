Public MustInherit Class BE_Alojamiento

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _categoria As String
    Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
        End Set
    End Property

    Private _conectividadWIFI As String
    Public Property ConectividadWIFI() As String
        Get
            Return _conectividadWIFI
        End Get
        Set(ByVal value As String)
            _conectividadWIFI = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _gimnasio As Boolean
    Public Property Gimnasio() As Boolean
        Get
            Return _gimnasio
        End Get
        Set(ByVal value As Boolean)
            _gimnasio = value
        End Set
    End Property

    Private _mascota As Boolean
    Public Property Mascota() As Boolean
        Get
            Return _mascota
        End Get
        Set(ByVal value As Boolean)
            _mascota = value
        End Set
    End Property

    Private _piscina As Boolean
    Public Property Piscina() As Boolean
        Get
            Return _piscina
        End Get
        Set(ByVal value As Boolean)
            _piscina = value
        End Set
    End Property

    Private _precioalquiler As Double
    Public Property PrecioAlquiler() As Double
        Get
            Return _precioalquiler
        End Get
        Set(ByVal value As Double)
            _precioalquiler = value
        End Set
    End Property

    Private _sauna As Boolean
    Public Property Sauna() As Boolean
        Get
            Return _sauna
        End Get
        Set(ByVal value As Boolean)
            _sauna = value
        End Set
    End Property

    Private _servicioaireacond As Boolean
    Public Property ServicioAireAcond() As Boolean
        Get
            Return _servicioaireacond
        End Get
        Set(ByVal value As Boolean)
            _servicioaireacond = value
        End Set
    End Property

    Private _serviciodesayuno As Boolean
    Public Property Desayuno() As Boolean
        Get
            Return _serviciodesayuno
        End Get
        Set(ByVal value As Boolean)
            _serviciodesayuno = value
        End Set
    End Property

    Private _servicioTV As Boolean
    Public Property ServicioTV() As Boolean
        Get
            Return _servicioTV
        End Get
        Set(ByVal value As Boolean)
            _servicioTV = value
        End Set
    End Property

    Private _TipoAlojamiento As String
    Public Property TipoAlojamiento() As String
        Get
            Return _TipoAlojamiento
        End Get
        Set(ByVal value As String)
            _TipoAlojamiento = value
        End Set
    End Property

    Private _tipocama As String
    Public Property TipoCama() As String
        Get
            Return _tipocama
        End Get
        Set(ByVal value As String)
            _tipocama = value
        End Set
    End Property

    Private _tipohabitacion As String
    Public Property TipoHabitacion() As String
        Get
            Return _tipohabitacion
        End Get
        Set(ByVal value As String)
            _tipohabitacion = value
        End Set
    End Property

    Private _ubicacion As String
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property


    Private _listaHabitaciones As New List(Of BE_Habitacion)
    Public Property ListaHabitaciones() As List(Of BE_Habitacion)
        Get
            Return _listaHabitaciones
        End Get
        Set(ByVal value As List(Of BE_Habitacion))
            _listaHabitaciones = value
        End Set
    End Property

    Private _destino As BE_Destino
    Public Property Destino() As BE_Destino
        Get
            Return _destino
        End Get
        Set(ByVal value As BE_Destino)
            _destino = value
        End Set
    End Property

    Private _tipoAlojamiento As BE_TipoAlojamiento
    Public Property TipoAlojamiento() As BE_TipoAlojamiento
        Get
            Return _TipoAlojamiento
        End Get
        Set(ByVal value As BE_TipoAlojamiento)
            _TipoAlojamiento = value
        End Set
    End Property
End Class
