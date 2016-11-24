Public Class BE_Usuario_Control_Cambios
    Inherits BE_Usuario

    Private _idCambio As Integer
    Public Property ID_Cambio() As Integer
        Get
            Return _idCambio
        End Get
        Set(ByVal value As Integer)
            _idCambio = value
        End Set
    End Property

    Private _tipoCambio As tipoCambio
    Public Property tipoCambio() As tipoCambio
        Get
            Return _tipoCambio
        End Get
        Set(ByVal value As tipoCambio)
            _tipoCambio = value
        End Set
    End Property

    Private _tipoValor As tipoValor
    Public Property tipoValor() As tipoValor
        Get
            Return _tipoValor
        End Get
        Set(ByVal value As tipoValor)
            _tipoValor = value
        End Set
    End Property

    Private _fechaCambio As Date
    Public Property fechaCambio() As Date
        Get
            Return _fechaCambio
        End Get
        Set(ByVal value As Date)
            _fechaCambio = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.ID_Cambio & "-" & Me._tipoCambio.ToString
    End Function

End Class


Public Enum tipoCambio
    Alta = 1
    Modificacion = 2
    Baja = 3
End Enum

Public Enum tipoValor
    Anterior = 1
    Posterior = 2
    Nuevo = 3
End Enum