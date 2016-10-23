Public Class BE_ServicioVuelo

    Private _almuerzo As String
    Public Property Almuerzo() As String
        Get
            Return _almuerzo
        End Get
        Set(ByVal value As String)
            _almuerzo = value
        End Set
    End Property

    Private _cafeteria As String
    Public Property Cafeteria() As String
        Get
            Return _cafeteria
        End Get
        Set(ByVal value As String)
            _cafeteria = value
        End Set
    End Property

    Private _cena As String
    Public Property Cena() As String
        Get
            Return _cena
        End Get
        Set(ByVal value As String)
            _cena = value
        End Set
    End Property

    Private _vuelo As BE_Vuelo
    Public Property Vuelo() As BE_Vuelo
        Get
            Return _vuelo
        End Get
        Set(ByVal value As BE_Vuelo)
            _vuelo = value
        End Set
    End Property



End Class
