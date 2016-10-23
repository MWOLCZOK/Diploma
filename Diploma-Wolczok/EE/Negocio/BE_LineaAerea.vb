Public Class BE_LineaAerea

    Private _añofundacion As Date
    Public Property AñoFundacion() As Date
        Get
            Return _añofundacion
        End Get
        Set(ByVal value As Date)
            _añofundacion = value
        End Set
    End Property

    Private _cantidadaviones As Integer
    Public Property CantidadAviones() As Integer
        Get
            Return _cantidadaviones
        End Get
        Set(ByVal value As Integer)
            _cantidadaviones = value
        End Set
    End Property

    Private _cuil As Integer
    Public Property CUIL() As Integer
        Get
            Return _cuil
        End Get
        Set(ByVal value As Integer)
            _cuil = value
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

    Private _telefono As Integer
    Public Property Telefono() As Integer
        Get
            Return _telefono
        End Get
        Set(ByVal value As Integer)
            _telefono = value
        End Set
    End Property

    Private _avion As BE_Avion
    Public Property Avion() As BE_Avion
        Get
            Return _avion
        End Get
        Set(ByVal value As BE_Avion)
            _avion = value
        End Set
    End Property



End Class
