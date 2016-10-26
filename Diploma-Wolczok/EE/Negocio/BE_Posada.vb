Public Class BE_Posada

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

End Class
