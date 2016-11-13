Public Class BE_Asiento

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _transporte As BE_Transporte
    Public Property Transporte() As BE_Transporte
        Get
            Return _transporte
        End Get
        Set(ByVal value As BE_Transporte)
            _transporte = value
        End Set
    End Property

    Private _fila As String
    Public Property Fila() As String
        Get
            Return _fila
        End Get
        Set(ByVal value As String)
            _fila = value
        End Set
    End Property

    Private _numeroAsiento As String
    Public Property NumeroAsiento() As String
        Get
            Return _numeroAsiento
        End Get
        Set(ByVal value As String)
            _numeroAsiento = value
        End Set
    End Property

    Private _categoriaAsiento As BE_CategoriaAsiento
    Public Property CategoriaAsiento() As BE_CategoriaAsiento
        Get
            Return _categoriaAsiento
        End Get
        Set(ByVal value As BE_CategoriaAsiento)
            _categoriaAsiento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return NumeroAsiento
    End Function

End Class
