Public Class BE_Departamento

    Inherits BE_Alojamiento

  
    Private _mascota As Boolean
    Public Property Mascota() As Boolean
        Get
            Return _mascota
        End Get
        Set(ByVal value As Boolean)
            _mascota = value
        End Set
    End Property

    Private _cochera As Boolean
    Public Property Cochera() As Boolean
        Get
            Return _cochera
        End Get
        Set(ByVal value As Boolean)
            _cochera = value
        End Set
    End Property

    Private _amoblado As Boolean
    Public Property Amoblado() As Boolean
        Get
            Return _amoblado
        End Get
        Set(ByVal value As Boolean)
            _amoblado = value
        End Set
    End Property

    Private _cocina As Boolean
    Public Property Cocina() As Boolean
        Get
            Return _cocina
        End Get
        Set(ByVal value As Boolean)
            _cocina = value
        End Set
    End Property




End Class
