Public Class BE_Permiso
    Inherits BE_PermisoBase

    Public Overrides Function agregarHijo(Perm As BE_PermisoBase) As Boolean
        Return False
    End Function

    Public Overrides Function obtenerHijos() As List(Of BE_PermisoBase)
        Return Nothing
    End Function

    Public Overrides Function tieneHijos() As Boolean
        Return False
    End Function

    Public Overrides Function esValido(nombrePermiso As String) As Boolean
        Return Me.Nombre.Equals(nombrePermiso)
    End Function

    Public Overrides Function quitarHijo(permiso As BE_PermisoBase) As Boolean
        Return False
    End Function

    Public Overrides Sub BorrarHijos()

    End Sub



End Class
