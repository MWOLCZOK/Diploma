Public Class BE_BackupRestore

    Sub New()

    End Sub

    'restore
    Sub New(ByVal paramdirectorio As String)
        Me.Directorio = paramdirectorio
    End Sub

    'backup
    Sub New(ByVal paramdirectorio As String, ByVal paramDescripcion As String)
        Me.Directorio = paramdirectorio
        Me.Descripcion = paramDescripcion
    End Sub

    Private _Directorio As String
    Public Property Directorio() As String
        Get
            Return _Directorio
        End Get
        Set(ByVal value As String)
            _Directorio = value
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


    Private _nombre As String
    Public ReadOnly Property Nombre() As String
        Get
            Return Now.Day.ToString("D2") & Now.Month.ToString("D2") & Now.Year & Now.Hour.ToString("D2") & Now.Minute.ToString("D2") & Now.Second.ToString("D2")
        End Get
    End Property





End Class
