Public Class BE_Hostel

    Inherits BE_Alojamiento

    Private _amoblado As Boolean
    Public Property Amoblado() As Boolean
        Get
            Return _amoblado
        End Get
        Set(ByVal value As Boolean)
            _amoblado = value
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

    Private _habitacionprivada As Boolean
    Public Property HabitacionPrivada() As Boolean
        Get
            Return _habitacionprivada
        End Get
        Set(ByVal value As Boolean)
            _habitacionprivada = value
        End Set
    End Property

    Private _lockers As Boolean
    Public Property Lockers() As Boolean
        Get
            Return _lockers
        End Get
        Set(ByVal value As Boolean)
            _lockers = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


End Class
