Public Class BE_VoucherAlojamiento

    Inherits BE_Voucher

    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _fechaingreso As Date
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
        End Set
    End Property

    Private _fechasalida As Date
    Public Property FechaSalida() As Date
        Get
            Return _fechasalida
        End Get
        Set(ByVal value As Date)
            _fechasalida = value
        End Set
    End Property

    Private _nombrealojamiento As String
    Public Property NombreAlojamiento() As String
        Get
            Return _nombrealojamiento
        End Get
        Set(ByVal value As String)
            _nombrealojamiento = value
        End Set
    End Property

End Class
