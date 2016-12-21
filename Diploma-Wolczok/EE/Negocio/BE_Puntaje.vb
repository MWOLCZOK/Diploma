Public Class BE_Puntaje

    Inherits BE_Master
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _coeficiente As Double
    Public Property Coeficiente() As Double
        Get
            Return _coeficiente
        End Get
        Set(ByVal value As Double)
            _coeficiente = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Private _bl As Boolean
    Public Property BL() As Boolean
        Get
            Return _bl
        End Get
        Set(ByVal value As Boolean)
            _bl = value
        End Set
    End Property





End Class
