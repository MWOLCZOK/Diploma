Public Class BE_Micro

    Inherits BE_Transporte

    Private _tipocomidad As String
    Public Property TipoComidad() As String
        Get
            Return _tipocomidad
        End Get
        Set(ByVal value As String)
            _tipocomidad = value
        End Set
    End Property

    Private _tipomicro As String
    Public Property TipoMicro() As String
        Get
            Return _tipomicro
        End Get
        Set(ByVal value As String)
            _tipomicro = value
        End Set
    End Property



 


End Class
