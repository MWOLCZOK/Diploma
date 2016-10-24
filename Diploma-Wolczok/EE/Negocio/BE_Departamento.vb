Public Class BE_Departamento

    Inherits BE_Alojamiento

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _cantidadambientes As Integer
    Public Property CantidadAmbientes() As Integer
        Get
            Return _cantidadambientes
        End Get
        Set(ByVal value As Integer)
            _cantidadambientes = value
        End Set
    End Property

    Private _cantidadbaños As Integer
    Public Property CantidadBaños() As Integer
        Get
            Return _cantidadbaños
        End Get
        Set(ByVal value As Integer)
            _cantidadbaños = value
        End Set
    End Property

    Private _cochera As Boolean
    Public Property Cochera() As Boolean
        Get
            Return _cochera
        End Get
        Set(ByVal value As Boolean)
            _cochera = value
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

    Private _tipoedificio As String
    Public Property TipoEdificio() As String
        Get
            Return _tipoedificio
        End Get
        Set(ByVal value As String)
            _tipoedificio = value
        End Set
    End Property





End Class
