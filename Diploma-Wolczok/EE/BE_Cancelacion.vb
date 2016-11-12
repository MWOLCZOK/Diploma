﻿Public Class BE_Cancelacion

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _reserva As BE_ReservaViaje
    Public Property Reserva() As BE_ReservaViaje
        Get
            Return _reserva
        End Get
        Set(ByVal value As BE_ReservaViaje)
            _reserva = value
        End Set
    End Property

    Private _tiporeserva As BE_Tiporeserva
    Public Property Tiporeserva() As BE_Tiporeserva
        Get
            Return _tiporeserva
        End Get
        Set(ByVal value As BE_Tiporeserva)
            _tiporeserva = value
        End Set
    End Property

    Private _fechacancelacion As Date
    Public Property Fechacancelacion() As Date
        Get
            Return _fechacancelacion
        End Get
        Set(ByVal value As Date)
            _fechacancelacion = value
        End Set
    End Property

    Private _montodevuelvo As Double
    Public Property MontoDevuelto() As Double
        Get
            Return _montodevuelvo
        End Get
        Set(ByVal value As Double)
            _montodevuelvo = value
        End Set
    End Property

    Private _montoretenido As Double
    Public Property MontoRetenido() As Double
        Get
            Return _montoretenido
        End Get
        Set(ByVal value As Double)
            _montoretenido = value
        End Set
    End Property

    Private _montototal As Double
    Public Property MontoTotal() As Double
        Get
            Return _montototal
        End Get
        Set(ByVal value As Double)
            _montototal = value
        End Set
    End Property

    Private _descripcionmotivocancel As String
    Public Property DescripcionMotivoCancelacion() As String
        Get
            Return _descripcionmotivocancel
        End Get
        Set(ByVal value As String)
            _descripcionmotivocancel = value
        End Set
    End Property

    
    Public Overrides Function ToString() As String
        Return Me.DescripcionMotivoCancelacion
    End Function


End Class