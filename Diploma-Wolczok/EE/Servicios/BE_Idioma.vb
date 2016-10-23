Imports System.Globalization


Public Class BE_Idioma

    Private _id_idioma As Integer
    Public Property id_idioma() As Integer
        Get
            Return _id_idioma
        End Get
        Set(ByVal value As Integer)
            _id_idioma = value
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

    Private _editable As Boolean
    Public Property editable() As Boolean
        Get
            Return _editable
        End Get
        Set(ByVal value As Boolean)
            _editable = value
        End Set
    End Property

    Private _palabras As New List(Of BE_Palabras)
    Public Property Palabras() As List(Of BE_Palabras)
        Get
            Return _palabras
        End Get
        Set(ByVal value As List(Of BE_Palabras))
            _palabras = value
        End Set
    End Property

    Private _cultura As CultureInfo
    Public Property Cultura() As CultureInfo
        Get
            Return _cultura
        End Get
        Set(ByVal value As CultureInfo)
            _cultura = value
        End Set
    End Property


    Private _bl As Boolean
    Public Property BL() As Boolean
        Get
            Return _bl
        End Get
        Set(ByVal value As Boolean)
            _bl = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me._nombre
    End Function

End Class
