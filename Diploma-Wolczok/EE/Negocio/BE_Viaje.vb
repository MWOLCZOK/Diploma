Public Class BE_Viaje

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _destino As String ' VER DESTINO
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _origen As String ' VER ORIGEN
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property


    Private _precio As Double
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property


    Private _transporte As String
    Public Property Transporte() As String
        Get
            Return _transporte
        End Get
        Set(ByVal value As String)
            _transporte = value
        End Set
    End Property







End Class
