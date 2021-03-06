﻿Public Class BE_Pasajero

    Inherits BE_Master
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _nombreCompleto As String
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Me.Apellido & ", " & Me.Nombre
        End Get

    End Property

    Private _correoelectronico As String
    Public Property CorreoElectronico() As String
        Get
            Return _correoelectronico
        End Get
        Set(ByVal value As String)
            _correoelectronico = value
        End Set
    End Property

    Private _dni As Integer
    Public Property DNI() As Integer
        Get
            Return _dni
        End Get
        Set(ByVal value As Integer)
            _dni = value
        End Set
    End Property


    Private _domicilio As String
    Public Property Domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
        End Set
    End Property

    Private _telefono As Double
    Public Property Telefono() As Double
        Get
            Return _telefono
        End Get
        Set(ByVal value As Double)
            _telefono = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me.NombreCompleto
    End Function

End Class
