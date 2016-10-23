Public Class BE_EmpresaMicro

    Private _añofundacion As Integer
    Public Property AñoFundacion() As Integer
        Get
            Return _añofundacion
        End Get
        Set(ByVal value As Integer)
            _añofundacion = value
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

    Private _mailcontacto As String
    Public Property MailContacto() As String
        Get
            Return _mailcontacto
        End Get
        Set(ByVal value As String)
            _mailcontacto = value
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

    Private _micro As BE_Micro
    Public Property Micro() As BE_Micro
        Get
            Return _micro
        End Get
        Set(ByVal value As BE_Micro)
            _micro = value
        End Set
    End Property



End Class
