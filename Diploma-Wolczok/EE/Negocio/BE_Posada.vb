Public Class BE_Posada

    Inherits BE_Alojamiento

    Private _distanciaciudad As Double
    Public Property DistanciaCiudad() As Double
        Get
            Return _distanciaciudad
        End Get
        Set(ByVal value As Double)
            _distanciaciudad = value
        End Set
    End Property

    Private _hectareasverdes As Double
    Public Property HectareasVerdes() As Double
        Get
            Return _hectareasverdes
        End Get
        Set(ByVal value As Double)
            _hectareasverdes = value
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








End Class
