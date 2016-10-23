Public Class BE_Destino


    Private _tieneaeropuerto As Boolean
    Public Property TieneAeropuerto() As Boolean
        Get
            Return _tieneaeropuerto
        End Get
        Set(ByVal value As Boolean)
            _tieneaeropuerto = value
        End Set
    End Property


    Private _localidad As EE.BE_Localidad
    Public Property Localidad() As EE.BE_Localidad
        Get
            Return _localidad
        End Get
        Set(ByVal value As EE.BE_Localidad)
            _localidad = value
        End Set
    End Property


    Private _nombreCompleto As String
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Me.Localidad.Descripcion & ", " & Me.Localidad.Provincia.Descripcion & ", " & Me.Localidad.Provincia.Pais.Descripcion
        End Get
    End Property

End Class
