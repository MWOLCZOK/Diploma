Public Class BE_Asiento

    Private _fila As Integer
    Public Property Fila() As Integer
        Get
            Return _fila
        End Get
        Set(ByVal value As Integer)
            _fila = value
        End Set
    End Property

    Private _nroasiento As Integer
    Public Property NroAsiento() As Integer
        Get
            Return _nroasiento
        End Get
        Set(ByVal value As Integer)
            _nroasiento = value
        End Set
    End Property


    Private _categoriaasiento As BE_CategoriaAsiento
    Public Property CategoriaAsiento() As BE_CategoriaAsiento
        Get
            Return _categoriaasiento
        End Get
        Set(ByVal value As BE_CategoriaAsiento)
            _categoriaasiento = value
        End Set
    End Property






End Class
