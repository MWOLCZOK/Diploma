Public Class BE_Localidad

    Inherits BE_Master

    Private _cantidadbarrios As Integer
    Public Property CantidadBarrios() As Integer
        Get
            Return _cantidadbarrios
        End Get
        Set(ByVal value As Integer)
            _cantidadbarrios = value
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

    Private _provincia As EE.BE_Provincia
    Public Property Provincia() As BE_Provincia
        Get
            Return _provincia
        End Get
        Set(ByVal value As BE_Provincia)
            _provincia = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Me.Descripcion & ", " & Me.Provincia.Descripcion & ", " & Me.Provincia.Pais.Descripcion
        End Get
    End Property






End Class
