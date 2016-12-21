Public Class BE_Cancelacion
    Inherits BE_Master

    Private _reserva As BE_Reserva
    Public Property Reserva() As BE_Reserva
        Get
            Return _reserva
        End Get
        Set(ByVal value As BE_Reserva)
            _reserva = value
        End Set
    End Property

    Private _tiporeserva As TipoReserva
    Public Property Tiporeserva() As TipoReserva
        Get
            Return _tiporeserva
        End Get
        Set(ByVal value As TipoReserva)
            _tiporeserva = value
        End Set
    End Property

    Private _fechacancelacion As Date
    Public Property Fechacancelacion() As Date
        Get
            Return _fechacancelacion
        End Get
        Set(ByVal value As Date)
            _fechacancelacion = value
        End Set
    End Property

    Private _montodevuelvo As Double
    Public Property MontoDevuelto() As Double
        Get
            Return _montodevuelvo
        End Get
        Set(ByVal value As Double)
            _montodevuelvo = value
        End Set
    End Property

    Private _montoretenido As Double
    Public Property MontoRetenido() As Double
        Get
            Return _montoretenido
        End Get
        Set(ByVal value As Double)
            _montoretenido = value
        End Set
    End Property

    Private _montototal As Double
    Public Property MontoTotal() As Double
        Get
            Return _montototal
        End Get
        Set(ByVal value As Double)
            _montototal = value
        End Set
    End Property

    Private _porcentajeRetencion As Double
    Public Property PorcentajeRetencion() As Double
        Get
            Return _porcentajeRetencion
        End Get
        Set(ByVal value As Double)
            _porcentajeRetencion = value
        End Set
    End Property



    Private _descripcionmotivocancel As String
    Public Property DescripcionMotivoCancelacion() As String
        Get
            Return _descripcionmotivocancel
        End Get
        Set(ByVal value As String)
            _descripcionmotivocancel = value
        End Set
    End Property

    
    Public Overrides Function ToString() As String
        Return Me.DescripcionMotivoCancelacion
    End Function


End Class
