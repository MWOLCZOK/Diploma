Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection


Public Class GestorBD

    Sub New()

    End Sub

    Private Shared _instancia As GestorBD
    Public Shared Function ObtenerInstancia() As GestorBD
        If _instancia Is Nothing Then
            _instancia = New GestorBD
        End If
        Return _instancia
    End Function

    Private _conexion As SqlConnection
    Public ReadOnly Property CX As SqlConnection
        Get
            Return _conexion
        End Get
    End Property

    Private _comando As SqlCommand
    Private _adaptador As SqlDataAdapter

    Public Sub ConfiguracionInicial()
        _conexion = New SqlConnection
        _comando = New SqlCommand
        '_adaptador = New SqlDataAdapter
        testearConexionBaseDatos()
        '_comando.CommandType = CommandType.StoredProcedure
        '_comando.Connection = _conexion
        '_adaptador.SelectCommand = _comando
    End Sub

    Private Sub testearConexionBaseDatos()
        'prueba de conectarse a la base por default cargada en el app.config
        Try
            _conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("Casa").ConnectionString ' "casa" es el nombre de "add name" del appconfig
            _conexion.Open()
            _conexion.Close()
        Catch ex As Exception
            _conexion.Close()
            Try
                'prueba si ya cree la BD en la instancia actual y de ser así la uso.
                '_conexion.ConnectionString = "Data Source=" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("serverName") & "\" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("instanceName") & ";Initial Catalog=MundoTravel;Integrated Security=True"
                _conexion.ConnectionString = "Data Source=" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("serverName") & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("instanceName") & ";Initial Catalog=MundoTravel;Integrated Security=True" ' Acá reemplazar el Initial Catalog= "Nombre de tu base"
                _conexion.Open()
                _conexion.Close()
            Catch exx As Exception
                CrearBD()
            End Try
        End Try
    End Sub

    Private Sub CrearBD()
        'busca el primer server sql disponible en el equipo, se conecta y crea nuestra BD usando la Master.
        'Continua ejecutando el script de la BD para crear tablas, SPs y datos.
        'El script está cargado como un recurso del proyecto, lo leo usando Reflection.
        Dim _assembly As Assembly
        _assembly = Assembly.GetExecutingAssembly

        '_conexion.ConnectionString = "Data Source=" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("serverName") & "\" & SqlDataSourceEnumerator.Instance.GetDataSources().Rows(0)("instanceName") & ";Initial Catalog=master;Integrated Security=True"
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
        ' para que la primera vez, cuando se crea ya se pueda seguir usando el sistema.
        _conexion.ConnectionString = _conexion.ConnectionString.Replace("master", "MundoTravel") ' aca solo reemplazar "MundoTravel", por el nombre de tu base. 

    End Sub

End Class
