Public MustInherit Class ExcepcionPersonalizada
    Inherits Exception

    Public MustOverride Function Mensaje() As String
    Public MustOverride Function Titulo() As String

End Class
