Public Class BE_Provincia

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Private _habitantes As Integer
    Public Property Habitantes() As Integer
        Get
            Return _habitantes
        End Get
        Set(ByVal value As Integer)
            _habitantes = value
        End Set
    End Property

    Private _region As String
    Public Property Region() As String
        Get
            Return _region
        End Get
        Set(ByVal value As String)
            _region = value
        End Set
    End Property


    Private _superficieterrestre As String
    Public Property SuperficieTerrestre() As String
        Get
            Return _superficieterrestre
        End Get
        Set(ByVal value As String)
            _superficieterrestre = value
        End Set
    End Property


    'Private _localidad As BE_Localidad
    'Public Property Localidad() As BE_Localidad
    '    Get
    '        Return _localidad
    '    End Get
    '    Set(ByVal value As BE_Localidad)
    '        _localidad = value
    '    End Set
    'End Property

    Private _paiss As BE_Pais
    Public Property Pais() As BE_Pais
        Get
            Return _paiss
        End Get
        Set(ByVal value As BE_Pais)
            _paiss = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function



End Class
