Public Class BE_Habitacion

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


    Private _Alojamiento As BE_Alojamiento
    Public Property Alojamiento() As BE_Alojamiento
        Get
            Return _Alojamiento
        End Get
        Set(ByVal value As BE_Alojamiento)
            _Alojamiento = value
        End Set
    End Property


End Class
