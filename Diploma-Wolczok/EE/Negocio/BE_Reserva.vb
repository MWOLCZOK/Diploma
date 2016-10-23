Public Class BE_Reserva

    Private _detalle As String
    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property


    Private _estado As Boolean
    Public Property Estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property

    Private _fecha_fin As Date
    Public Property Fecha_Fin() As Date
        Get
            Return _fecha_fin
        End Get
        Set(ByVal value As Date)
            _fecha_fin = value
        End Set
    End Property

    Private _fecha_inicio As Date
    Public Property Fecha_Inicio() As Date
        Get
            Return _fecha_inicio
        End Get
        Set(ByVal value As Date)
            _fecha_inicio = value
        End Set
    End Property

    Private _nro_reserva As Integer
    Public Property Nro_Reserva() As Integer
        Get
            Return _nro_reserva
        End Get
        Set(ByVal value As Integer)
            _nro_reserva = value
        End Set
    End Property





End Class
