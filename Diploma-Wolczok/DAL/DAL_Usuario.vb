Imports System.Data.SqlClient
Imports System.Configuration
Imports EE


Public Class DAL_Usuario


#Region "Login / Logout"
    Public Function chequearUsuario(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Try
            Dim consulta As String = "Select * from Usuario where NombreUsuario=@NombreUsuario"
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function chequearBloqueado(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Try
            Dim consuta As String = "Select Bloqueado from usuario where NombreUsuario=@NombreUsuario"
            Dim Command As SqlCommand = Acceso.MiComando(consuta)
            With Command.Parameters
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                '         Dim Usuario As BE_Usuario = formatearUsuario(dt.Rows(0))    '  CORREGIR CON SANTI
                Return CBool(dt.Rows(0).Item("Bloqueado"))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function chequearPassword(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Try
            Dim consulta As String = "Select * from Usuario where NombreUsuario=@NombreUsuario and Password=@Password"
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                .Add(New SqlParameter("@Password", oUsuario.Password))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub actualizarIntentos(ByVal oUsuario As EE.BE_Usuario)
        Try
            Dim Consulta As String = "Update Usuario set Intentos = @Intentos, DVH=@DVH where NombreUsuario=@NombreUsuario"
            Dim Command = Acceso.MiComando(Consulta)
            With Command.Parameters
                .Add(New SqlParameter("@Intentos", oUsuario.Intentos))
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
            End With
            oUsuario = consultarUsuario(oUsuario)
            Command.Parameters.Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & False + oUsuario.Intentos & oUsuario.Perfil.ID & False)))
            Acceso.Escritura(Command)

            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim Datatabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In Datatabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function BloquearUsuario(ByVal oUsuario As EE.BE_Usuario) As Boolean
        Try
            If oUsuario.Bloqueado = True Then
                Dim Consulta As String = "update Usuario set Bloqueo= 'False', DVH =@DVH where NombreUsuario=@NombreUsuario and BL=0"
                Dim Command = Acceso.MiComando(Consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                    .Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & False & oUsuario.Intentos & oUsuario.Perfil.ID & False)))
                End With
                Acceso.Escritura(Command)
                oUsuario.Bloqueado = False
                ResetearIntentos(oUsuario)
                Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
                Dim Datatabla = Acceso.Lectura(CommandVerificador)
                Dim Digitos As String = ""
                For Each row As DataRow In Datatabla.Rows
                    Digitos = Digitos + row.Item("DVH")
                Next
                DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
                Return False
            Else
                Dim Consulta As String = "Update Usuario set Bloqueo = 'True', DVH = @DVH where NombreUsuario=@NombreUsuario and BL=0 "
                Dim Command = Acceso.MiComando(Consulta)
                With Command.Parameters
                    .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                    .Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & False & oUsuario.Intentos & oUsuario.Perfil.ID & False)))
                End With
                Acceso.Escritura(Command)

                Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
                Dim Datatabla = Acceso.Lectura(CommandVerificador)
                Dim Digitos As String = ""
                For Each row As DataRow In Datatabla.Rows
                    Digitos = Digitos + row.Item("DVH")
                Next
                DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ResetearIntentos(ByVal oUsuario As EE.BE_Usuario)
        Try
            Dim Consulta As String = "Update Usuario set intentos = @Intentos, DVH=@DVH where NombreUsuario=@NombreUsuario and BL=0"
            Dim Command = Acceso.MiComando(Consulta)
            With Command.Parameters
                .Add(New SqlParameter("@Intentos", 0))
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                .Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & oUsuario.Bloqueado & oUsuario.Intentos & oUsuario.Perfil.ID & False)))
            End With
            Acceso.Escritura(Command)

            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim Datatabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In Datatabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


    Public Function Modificar(ByRef Usuario As EE.BE_Usuario) As Boolean
        Try
            Dim Command As SqlCommand = Acceso.MiComando("update Usuario set NombreUsuario=@NombreUsuario, Nombre=@Nombre, Apellido=@Apellido, ID_Idioma=@ID_Idioma, ID_Perfil=@ID_Perfil where ID_Usuario=@ID_Usuario")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                .Add(New SqlParameter("@NombreUsuario", Usuario.NombreUsuario))
                .Add(New SqlParameter("@Nombre", Usuario.Nombre))
                .Add(New SqlParameter("@Apellido", Usuario.Apellido))
                .Add(New SqlParameter("@ID_Idioma", Usuario.idioma.id_idioma))
                .Add(New SqlParameter("@ID_Perfil", Usuario.Perfil.ID))
                '.Add(New SqlParameter("@BL", False))
                '              .Add(New SqlParameter("@DVH", DigitoVerificadorDAL.CalcularDVH(Command.Parameters("@ID_Usuario").Value & Command.Parameters("@NombreUsuario").Value & Usuario.Password & Usuario.Bloqueo & Usuario.Intento & Command.Parameters("@Idioma").Value & Command.Parameters("@Perfil").Value & Command.Parameters("@BL").Value)))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()
            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim DataTabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In DataTabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub altaUsuario(ByVal oUsuario As EE.BE_Usuario)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("insert into Usuario values (@ID_Usuario, @NombreUsuario, @Password, @Intentos, @Bloqueado, @Nombre, @Apellido, @ID_Perfil, @BL, @ID_Idioma, @DVH)")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Usuario", Acceso.TraerID("ID_Usuario", "Usuario")))
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                .Add(New SqlParameter("@Password", oUsuario.Password))
                .Add(New SqlParameter("@Intentos", 0))
                .Add(New SqlParameter("@Bloqueado", False))
                .Add(New SqlParameter("@Nombre", oUsuario.Nombre))
                .Add(New SqlParameter("@Apellido", oUsuario.Apellido))
                .Add(New SqlParameter("@ID_Perfil", oUsuario.Perfil.ID))
                .Add(New SqlParameter("@BL", False))
                .Add(New SqlParameter("@ID_Idioma", oUsuario.idioma.id_idioma))
                Command.Parameters.Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & False + oUsuario.Intentos & oUsuario.Perfil.ID & False)))
            End With
            Acceso.Escritura(Command)
            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim DataTabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In DataTabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub bajaUsuario(ByVal oUsuario As EE.BE_Usuario)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("update Usuario set BL=@BL where ID_Usuario=@ID_Usuario")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Usuario", oUsuario.ID))
                .Add(New SqlParameter("@BL", True))
                Command.Parameters.Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(oUsuario.ID & oUsuario.NombreUsuario & oUsuario.Password & False + oUsuario.Intentos & oUsuario.Perfil.ID & False)))
            End With
            Acceso.Escritura(Command)
            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim DataTabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In DataTabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function consultarUsuario(ByVal paramId As Integer) As EE.BE_Usuario
        Try
            Dim consulta As String = ("Select * from usuario where ID_Usuario=@ID_Usuario")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID_Usuario", paramId))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearUsuario(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarUsuarioBitacora(ByVal paramId As Integer) As EE.BE_Usuario
        Try
            Dim consulta As String = ("Select * from usuario where ID_Usuario=@ID_Usuario")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID_Usuario", paramId))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearUsuarioBitacora(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function consultarUsuario(ByVal oUsuario As EE.BE_Usuario) As EE.BE_Usuario
        Try
            Dim consulta As String = ("Select * from usuario where NombreUsuario=@NombreUsuario and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@NombreUsuario", oUsuario.NombreUsuario))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearUsuario(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarUsuarios() As List(Of EE.BE_Usuario)
        Try
            Dim consulta As String = ("Select * from usuario where BL=@BL")
            Dim miListaUsuario As New List(Of EE.BE_Usuario)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaUsuario.Add(Me.formatearUsuario(drow))
            Next
            Return miListaUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearUsuario(ByVal paramDataRow As DataRow) As EE.BE_Usuario
        Try
            Dim oUsuario As New EE.BE_Usuario
            oUsuario.ID = paramDataRow.Item("ID_Usuario")
            oUsuario.NombreUsuario = paramDataRow.Item("NombreUsuario")
            oUsuario.Password = paramDataRow.Item("Password")
            oUsuario.Intentos = paramDataRow.Item("Intentos")
            oUsuario.Bloqueado = paramDataRow.Item("Bloqueado")
            oUsuario.Nombre = paramDataRow.Item("Nombre")
            oUsuario.Apellido = paramDataRow.Item("Apellido")
            oUsuario.BL = paramDataRow.Item("BL")
            Dim oDalPerfil As New DAL.DAL_GestorPermiso
            oUsuario.Perfil = oDalPerfil.ConsultarporID(CInt(paramDataRow.Item("ID_Perfil")))
            Dim oDalIdioma As New DAL.DAL_Idioma
            oUsuario.idioma = oDalIdioma.ConsultarPorID(CInt(paramDataRow.Item("ID_Idioma")))
            Return oUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearUsuarioBitacora(ByVal paramDataRow As DataRow) As EE.BE_Usuario
        Try
            Dim oUsuario As New EE.BE_Usuario
            oUsuario.ID = paramDataRow.Item("ID_Usuario")
            oUsuario.NombreUsuario = paramDataRow.Item("NombreUsuario")
            Return oUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Eliminar(ByRef paramUsuario As EE.BE_Usuario) As Boolean
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Update Usuario set BL=@BL where ID_Usuario = @ID_Usuario")
            With Command.Parameters
                .Add(New SqlParameter("@BL", True))
                .Add(New SqlParameter("@ID_Usuario", paramUsuario.ID))
                '               .Add(New SqlParameter("@DVH", DigitoVerificadorDAL.CalcularDVH(Usuario.ID_Usuario & Usuario.Nombre & Usuario.Password & Usuario.Bloqueo & Usuario.Intento & Usuario.IdiomaEntidad.ID_Idioma & Usuario.Perfil.ID & Command.Parameters("@BL").Value)))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()

            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Usuario")
            Dim DataTabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In DataTabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Usuario")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Integridad() As String
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Usuario")
            Dim DataTabla = Acceso.Lectura(Command)
            Dim DigitosHorizontales As String = ""
            For Each row As DataRow In DataTabla.Rows
                Dim Fila As String = ""
                Fila = Fila & row.Item(0)
                Fila = Fila & row.Item(1)
                Fila = Fila & row.Item(2)
                Fila = Fila & row.Item(3)
                Fila = Fila & row.Item(4)
                Fila = Fila & row.Item(5)
                Fila = Fila & row.Item(6)
                Fila = Fila & row.Item(7)
                Fila = Fila & row.Item(8)
                If Not DAL_DigitoVerificador.CalcularDVH(Fila) = row.Item(9) Then
                    Return Nothing
                End If
                DigitosHorizontales = DigitosHorizontales + row.Item(9)
            Next
            Return DigitosHorizontales
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
