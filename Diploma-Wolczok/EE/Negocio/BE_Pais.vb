Public Class BE_Pais

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
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

    Private _idioma As String
    Public Property Idioma() As String
        Get
            Return _idioma
        End Get
        Set(ByVal value As String)
            _idioma = value
        End Set
    End Property

    Private _poblaciontotal As Integer
    Public Property Poblacion_total() As Integer
        Get
            Return _poblaciontotal
        End Get
        Set(ByVal value As Integer)
            _poblaciontotal = value
        End Set
    End Property

    Private _zonahoraria As String
    Public Property Zonahoraria() As String
        Get
            Return _zonahoraria
        End Get
        Set(ByVal value As String)
            _zonahoraria = value
        End Set
    End Property

    Private _provincia As New List(Of BE_Provincia)
    Public Property Provincia() As List(Of BE_Provincia)
        Get
            Return _provincia
        End Get
        Set(ByVal value As List(Of BE_Provincia))
            _provincia = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function



End Class
