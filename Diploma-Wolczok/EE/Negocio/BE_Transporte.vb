﻿Public Class BE_Transporte

    Inherits BE_Master
    Private _empresa As BE_EmpresaTransporte
    Public Property Empresa() As BE_EmpresaTransporte
        Get
            Return _empresa
        End Get
        Set(ByVal value As BE_EmpresaTransporte)
            _empresa = value
        End Set
    End Property

    Private _tipoTransporte As BE_TipoTransporte
    Public Property TipoTransporte() As be_TipoTransporte
        Get
            Return _tipoTransporte
        End Get
        Set(ByVal value As be_TipoTransporte)
            _tipoTransporte = value
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

    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    Private _listaAsientos As New List(Of EE.BE_Asiento)
    Public Property Asientos() As List(Of EE.BE_Asiento)
        Get
            Return _listaAsientos
        End Get
        Set(ByVal value As List(Of EE.BE_Asiento))
            _listaAsientos = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
