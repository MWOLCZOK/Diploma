Public Class BE_CategoriaAsiento

    Private _claseejecutiva As Boolean
    Public Property ClaseEjecutiva() As Boolean
        Get
            Return _claseejecutiva
        End Get
        Set(ByVal value As Boolean)
            _claseejecutiva = value
        End Set
    End Property

    Private _clasepremium As Boolean
    Public Property ClasePremium() As Boolean
        Get
            Return _clasepremium
        End Get
        Set(ByVal value As Boolean)
            _clasepremium = value
        End Set
    End Property

    Private _claseprimera As Boolean
    Public Property ClasePrimera() As Boolean
        Get
            Return _claseprimera
        End Get
        Set(ByVal value As Boolean)
            _claseprimera = value
        End Set
    End Property

    Private _claseturista As Boolean
    Public Property ClaseTurista() As Boolean
        Get
            Return _claseturista
        End Get
        Set(ByVal value As Boolean)
            _claseturista = value
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








End Class
