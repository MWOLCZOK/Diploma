Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Configuration

Public Class Acceso

    ''Private Shared _objConexion As New SqlConnection("Data Source=9-07880-n\sqlexpress;Initial Catalog=MundoTravel;Integrated Security=True")


    'Public Shared Function ExecuteDataTable(ByVal _paramComando As SqlCommand) As DataTable
    '    Try
    '        Dim _dataTable As New DataTable
    '        Dim _dataAdapter As New SqlDataAdapter(_paramComando)
    '        _dataAdapter.Fill(_dataTable)
    '        Return _dataTable
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Shared Function ExecuteNonQuery(ByVal _paramComando As SqlCommand) As Integer

    '    Try
    '        If _objConexion.State = ConnectionState.Open Then
    '            _objConexion.Close()
    '        End If
    '        _paramComando.Connection = _objConexion
    '        _objConexion.Open()
    '        Return _paramComando.ExecuteNonQuery()
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    Finally
    '        _objConexion.Close()
    '    End Try
    'End Function

    'Shared Function retornaComando(ByVal _paramComando As String) As SqlCommand
    '    Dim _objCommando As New SqlCommand(_paramComando, _objConexion)
    '    _objCommando.CommandType = CommandType.Text
    '    Return _objCommando
    'End Function


    Public Shared Function MiConexionMaster() As SqlConnection
        Dim MiConecction = New SqlConnection(ConfigurationManager.ConnectionStrings("MundotravelMaster").ConnectionString)
        Return MiConecction
    End Function


    Public Shared Function Lectura(command As SqlCommand) As DataTable
        Try
            Dim Da As New SqlDataAdapter(command)
            Dim Dt As New DataTable
            Da.Fill(Dt)
            Return Dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function Scalar(ByVal command As SqlCommand) As Integer

        Try
            command.Connection.Open()
            Return command.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            command.Connection.Close()
            command.Connection.Dispose()
        End Try
    End Function
    Public Shared Function Escritura(command As SqlCommand) As Integer
        Try
            command.Connection.Open()
            Return command.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            command.Connection.Close()
            command.Connection.Dispose()
        End Try
    End Function
    Shared Function MiComando(ByVal consulta As String) As SqlCommand
        Dim objCommando As New SqlCommand(consulta, MiConexion())
        objCommando.CommandType = CommandType.Text
        Try
            objCommando.Connection.Open()
            If objCommando.Connection.State = ConnectionState.Open Then
                objCommando.Connection.Close()
                Return objCommando
            Else
                Dim exc As InvalidOperationException = New InvalidOperationException
                MsgBox("La base de Datos se encuentra sin conectividad. Vuelva a intentarlo nuevamente o consulte al administrador de la Base de Datos.", MsgBoxStyle.Critical, "Error Conexión")
                Throw exc
            End If
        Catch ex As Exception
            Dim exc As InvalidOperationException = New InvalidOperationException
            MsgBox("La base de Datos se encuentra sin conectividad. Vuelva a intentarlo nuevamente o consulte al administrador de la Base de Datos.", MsgBoxStyle.Critical, "Error Conexión")
            Throw exc
        End Try
    End Function
    Public Shared Function MiConexion() As SqlConnection
        Dim MiConecction = New SqlConnection(ConfigurationManager.ConnectionStrings("MundoTravel").ConnectionString)
        'Dim miconecction = New SqlConnection("Data Source=9-07880-n\sqlexpress;Initial Catalog=MundoTravel;Integrated Security=True")
        'Private Shared _objConexion As New SqlConnection("Data Source=9-07880-n\sqlexpress;Initial Catalog=MundoTravel;Integrated Security=True")

        Return MiConecction
    End Function

    'Public Shared Function MiConexionMaster() As SqlConnection
    '    Dim MiConecction = New SqlConnection(ConfigurationManager.ConnectionStrings("MundoTravel").ConnectionString)
    '    Return MiConecction
    'End Function

    Shared Function TraerID(ByRef IDGenerico As String, ByRef TablaGenerica As String) As Integer
        Try
            Dim ID As Integer
            Dim Command As SqlCommand = Acceso.MiComando("select Max(" & IDGenerico & ") as IDretorno from " & TablaGenerica)
            Dim DataTabla = Acceso.Lectura(Command)
            For Each row As DataRow In DataTabla.Rows
                If IsDBNull(row.Item(0)) Then
                    ID = 1
                Else
                    ID = row.Item(0) + 1
                End If
            Next
            Return ID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Shared Function TraerUltimoID(ByRef IDGenerico As String, ByRef TablaGenerica As String) As Integer
        Try
            Dim ID As Integer
            Dim Command As SqlCommand = Acceso.MiComando("select Max(" & IDGenerico & ") as IDretorno from " & TablaGenerica)
            Dim DataTabla = Acceso.Lectura(Command)
            For Each row As DataRow In DataTabla.Rows
                ID = row.Item(0)
            Next
            Return ID
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
