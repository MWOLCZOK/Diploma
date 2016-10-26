Public Class BE_Hotel

    Inherits BE_Alojamiento


    Private _gimnasio As Boolean
    Public Property Gimnasio() As Boolean
        Get
            Return _gimnasio
        End Get
        Set(ByVal value As Boolean)
            _gimnasio = value
        End Set
    End Property


    Private _mascota As Boolean
    Public Property Mascota() As Boolean
        Get
            Return _mascota
        End Get
        Set(ByVal value As Boolean)
            _mascota = value
        End Set
    End Property

    Private _sauna As Boolean
    Public Property Sauna() As Boolean
        Get
            Return _sauna
        End Get
        Set(ByVal value As Boolean)
            _sauna = value
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


End Class
