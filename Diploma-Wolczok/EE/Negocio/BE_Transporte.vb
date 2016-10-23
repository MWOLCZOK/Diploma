Public Class BE_Transporte

    Private _capacidad As Integer
    Public Property Capacidad() As Integer
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Integer)
            _capacidad = value
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

    Private _costo As Double
    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
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



End Class
