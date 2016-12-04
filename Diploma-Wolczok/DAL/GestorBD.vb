Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection


Public Class GestorBD

    Sub New()

    End Sub

    Private _conexion As SqlConnection
    Public ReadOnly Property CX As SqlConnection
        Get
            Return _conexion
        End Get
    End Property

    Private _comando As SqlCommand
    Private _adaptador As SqlDataAdapter

    Public Function existeBD() As Boolean
        Try
            _conexion = New SqlConnection
            _comando = New SqlCommand
            _conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("Casa").ConnectionString ' "casa" es el nombre de "add name" del appconfig
            _conexion.Open()
            _conexion.Close()
            Return True
        Catch ex As Exception
            _conexion.Close()
            Try
                _conexion.ConnectionString = "Data Source=" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("serverName") & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("instanceName") & ";Initial Catalog=MundoTravel;Integrated Security=True" ' Acá reemplazar el Initial Catalog= "Nombre de tu base"
                _conexion.Open()
                _conexion.Close()
            Catch exx As Exception
                Return False
            End Try
            Return True
        End Try
    End Function

    Public Sub CrearBD()
        Dim _assembly As Assembly
        _assembly = Assembly.GetExecutingAssembly
        _conexion = New SqlConnection
        _comando = New SqlCommand
        _conexion.ConnectionString = "Data Source=" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("serverName") & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("instanceName") & ";Initial Catalog=master;Integrated Security=True"
        _comando.Connection = _conexion
        _comando.CommandText = "CREATE DATABASE MundoTravel"
        Try
            _comando.Connection.Open()
            _comando.ExecuteNonQuery()
            Dim sr As New StreamReader(_assembly.GetManifestResourceStream("DAL.Scripparainstalador.sql")) ' Acá Va el nombre de tu scrip "DAL.tuscrip.sql"
            Dim str As String = sr.ReadToEnd
            sr.Close()
            _comando.CommandText = str
            _comando.ExecuteNonQuery()
            _comando.Connection.Close()
        Catch ex As Exception
        Finally
            _comando.Connection.Close()
        End Try
        _conexion.ConnectionString = _conexion.ConnectionString.Replace("master", "MundoTravel") ' aca solo reemplazar "MundoTravel", por el nombre de tu base. 
    End Sub

End Class
