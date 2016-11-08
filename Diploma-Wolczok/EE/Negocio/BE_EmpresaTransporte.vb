Public Class BE_EmpresaTransporte

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Private _nombnre As String
    Public Property Nombre() As String
        Get
            Return _nombnre
        End Get
        Set(ByVal value As String)
            _nombnre = value
        End Set
    End Property

    Private _cuil As String
    Public Property CUIL() As String
        Get
            Return _cuil
        End Get
        Set(ByVal value As String)
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
    Public Property Mail() As String
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

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
