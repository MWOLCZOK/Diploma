Public Class BE_Habitacion

    Private _cantidadcamas As Integer
    Public Property CantidadCamas() As Integer
        Get
            Return _cantidadcamas
        End Get
        Set(ByVal value As Integer)
            _cantidadcamas = value
        End Set
    End Property

    Private _cantidadpersonas As Integer
    Public Property CantidadPersonas() As Integer
        Get
            Return _cantidadpersonas
        End Get
        Set(ByVal value As Integer)
            _cantidadpersonas = value
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

    Private _escritorio As Boolean
    Public Property Escritorio() As Boolean
        Get
            Return _escritorio
        End Get
        Set(ByVal value As Boolean)
            _escritorio = value
        End Set
    End Property

    Private _frigobar As Boolean
    Public Property Frigobar() As Boolean
        Get
            Return _frigobar
        End Get
        Set(ByVal value As Boolean)
            _frigobar = value
        End Set
    End Property

    Private _mesa As Boolean
    Public Property Mesa() As Boolean
        Get
            Return _mesa
        End Get
        Set(ByVal value As Boolean)
            _mesa = value
        End Set
    End Property

End Class
