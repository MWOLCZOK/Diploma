Public Class BE_Usuario

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombreUsuario As String
    Public Property NombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
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

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _intentos As Integer
    Public Property Intentos() As Integer
        Get
            Return _intentos
        End Get
        Set(ByVal value As Integer)
            _intentos = value
        End Set
    End Property

    Private _bloqueado As Boolean
    Public Property Bloqueado() As Boolean
        Get
            Return _bloqueado
        End Get
        Set(ByVal value As Boolean)
            _bloqueado = value
        End Set
    End Property

    Private _perfil As BE_GrupoPermiso
    Public Property Perfil() As BE_GrupoPermiso
        Get
            Return _perfil
        End Get
        Set(ByVal value As BE_GrupoPermiso)
            _perfil = value
        End Set
    End Property

    Private _bl As Boolean
    Public Property BL() As Boolean
        Get
            Return _bl
        End Get
        Set(ByVal value As Boolean)
            _bl = value
        End Set
    End Property

    Private _idioma As BE_Idioma
    Public Property idioma() As BE_Idioma
        Get
            Return _idioma
        End Get
        Set(ByVal value As BE_Idioma)
            _idioma = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.NombreUsuario
    End Function

End Class
