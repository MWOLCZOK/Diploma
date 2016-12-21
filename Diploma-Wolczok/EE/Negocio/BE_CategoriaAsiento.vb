Public Class BE_CategoriaAsiento
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


    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
