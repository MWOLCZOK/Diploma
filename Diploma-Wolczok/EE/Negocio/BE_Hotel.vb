Public Class BE_Hotel

    Inherits BE_Alojamiento


    Private _actividadesfamiliares As String
    Public Property ActividadesFamiliares() As String
        Get
            Return _actividadesfamiliares
        End Get
        Set(ByVal value As String)
            _actividadesfamiliares = value
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


    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _tipohotel As String
    Public Property TipoHotel() As String
        Get
            Return _tipohotel
        End Get
        Set(ByVal value As String)
            _tipohotel = value
        End Set
    End Property



End Class
