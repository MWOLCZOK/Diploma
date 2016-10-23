Public Class BE_Avion

    Inherits BE_Transporte


    Private _escala As Boolean
    Public Property Escala() As Boolean
        Get
            Return _escala
        End Get
        Set(ByVal value As Boolean)
            _escala = value
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

    Private list As List(Of BE_Asiento)



End Class
