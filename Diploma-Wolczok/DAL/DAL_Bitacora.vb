Imports EE
Imports System.Data.SqlClient

Public Class DAL_Bitacora

    Public Function ConsultarBitacora(Optional ByRef Usuario As BE_Usuario = Nothing, Optional ByRef Tipo As BE_TipoBitacora = Nothing, Optional ByVal FechaInicio As DateTime = Nothing, Optional ByVal FechaFin As DateTime = Nothing) As List(Of BE_Bitacora)
        Try
            Dim Command As SqlCommand
            Dim DataTabla As DataTable
            Dim listabitacora As List(Of BE_Bitacora) = New List(Of BE_Bitacora)
            If IsNothing(Usuario) And Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
                Command = Acceso.MiComando("select * from Bitacora order by Fecha desc")
            ElseIf Not IsNothing(Usuario) And Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
                Command = Acceso.MiComando("select * from Bitacora where ID_Usuario=@ID_Usuario order by Fecha desc")
                Command.Parameters.Add(New SqlParameter("@ID_Usuario", Usuario.ID))
            ElseIf IsNothing(Usuario) And Not Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
                Command = Acceso.MiComando("select * from Bitacora where Codigo=@Codigo order by Fecha desc")
                Command.Parameters.Add(New SqlParameter("@Codigo", Tipo))
            ElseIf Not IsNothing(Usuario) And Not Tipo = 0 And FechaFin = New Date And FechaInicio = New Date Then
                Command = Acceso.MiComando("select * from Bitacora where ID_Usuario=@ID_Usuario and Codigo=@Codigo order by Fecha desc")
                Command.Parameters.Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                Command.Parameters.Add(New SqlParameter("@Codigo", Tipo))
            ElseIf IsNothing(Usuario) And Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
                If FechaInicio.DayOfYear = FechaFin.DayOfYear Then
                    Command = Acceso.MiComando("select * from Bitacora where  CAST(Fecha AS DATE)=@Fecha  order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@Fecha", FechaInicio.Date))
                    End With
                Else
                    Command = Acceso.MiComando("select * from Bitacora where Fecha between @FechaIni and @FechaFin order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@FechaIni", FechaInicio.Date))
                        .Add(New SqlParameter("@FechaFin", FechaFin.Date))
                    End With
                End If
            ElseIf Not IsNothing(Usuario) And Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
                If FechaInicio.DayOfYear = FechaFin.DayOfYear Then
                    Command = Acceso.MiComando("select * from Bitacora where CAST(Fecha AS DATE)=@Fecha and ID_Usuario = @ID_Usuario order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@Fecha", FechaInicio.Date))
                        .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                    End With
                Else
                    Command = Acceso.MiComando("select * from Bitacora where Fecha between @FechaIni and @FechaFin and ID_Usuario = @ID_Usuario order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@FechaIni", FechaInicio.Date))
                        .Add(New SqlParameter("@FechaFin", FechaFin.Date))
                        .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                    End With
                End If
            ElseIf IsNothing(Usuario) And Not Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
                If FechaInicio.DayOfYear = FechaFin.DayOfYear Then
                    Command = Acceso.MiComando("select * from Bitacora where CAST(Fecha AS DATE)=@Fecha and Codigo = @Codigo  order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@Fecha", FechaInicio.Date))
                        .Add(New SqlParameter("@Codigo", Tipo))
                    End With
                Else
                    Command = Acceso.MiComando("select * from Bitacora where Fecha between @FechaIni and @FechaFin and Codigo = @Codigo order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@FechaIni", FechaInicio.Date))
                        .Add(New SqlParameter("@FechaFin", FechaFin.Date))
                        .Add(New SqlParameter("@Codigo", Tipo))
                    End With
                End If
            ElseIf Not IsNothing(Usuario) And Not Tipo = 0 And Not FechaFin = New Date And Not FechaInicio = New Date Then
                If FechaInicio.DayOfYear = FechaFin.DayOfYear Then
                    Command = Acceso.MiComando("select * from Bitacora where CAST(Fecha AS DATE)=@Fecha and ID_Usuario=@ID_Usuario and Codigo = @Codigo  order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@Fecha", FechaInicio.Date))
                        .Add(New SqlParameter("@Codigo", Tipo))
                        .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                    End With
                Else
                    Command = Acceso.MiComando("select * from Bitacora where Fecha between @FechaIni and @FechaFin and ID_Usuario=@ID_Usuario and Codigo = @Codigo order by Fecha desc")
                    With Command.Parameters
                        .Add(New SqlParameter("@FechaIni", FechaInicio.Date))
                        .Add(New SqlParameter("@FechaFin", FechaFin.Date))
                        .Add(New SqlParameter("@Codigo", Tipo))
                        .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                    End With
                End If
            Else
                Throw New Exception
            End If
            DataTabla = Acceso.Lectura(Command)
            For Each row As DataRow In DataTabla.Rows
                listabitacora.Add(Me.formatearbitacora(row))
            Next
            Return listabitacora
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GuardarBitacora(Bitacora As BE_Bitacora)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("insert into Bitacora values (@ID_Bitacora, @Codigo, @Fecha, @Detalle, @ID_Usuario,@DVH)")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Bitacora", Acceso.TraerID("ID_Bitacora", "Bitacora")))
                .Add(New SqlParameter("@Codigo", Bitacora.Codigo))
                .Add(New SqlParameter("@Fecha", Bitacora.Fecha))
                .Add(New SqlParameter("@Detalle", Bitacora.Detalle))
                .Add(New SqlParameter("@ID_Usuario", Bitacora.Usuario.ID))
                .Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(Command.Parameters("@ID_Bitacora").Value & Bitacora.Codigo & Bitacora.Fecha & Bitacora.Detalle & Bitacora.Usuario.ID.ToString)))
            End With
            Acceso.Escritura(Command)

            Dim CommandVerificador As SqlCommand = Acceso.MiComando("Select DVH from Bitacora")
            Dim DataTabla = Acceso.Lectura(CommandVerificador)
            Dim Digitos As String = ""
            For Each row As DataRow In DataTabla.Rows
                Digitos = Digitos + row.Item("DVH")
            Next
            DAL_DigitoVerificador.CalcularDVV(Digitos, "Bitacora")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function formatearbitacora(ByVal paramDataRow As DataRow) As EE.BE_Bitacora
        Try
            Dim oBitacora As New EE.BE_Bitacora
            oBitacora.Codigo = paramDataRow.Item("Codigo")
            oBitacora.Fecha = paramDataRow.Item("Fecha")
            oBitacora.Detalle = paramDataRow.Item("Detalle")
            Dim UsuDAl As DAL_Usuario = New DAL_Usuario
            oBitacora.Usuario = UsuDAl.consultarUsuarioBitacora(CInt(paramDataRow.Item("ID_Usuario")))
            Return oBitacora
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Integridad() As String
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Bitacora")
            Dim DataTabla = Acceso.Lectura(Command)
            Dim DigitosHorizontales As String = ""
            For Each row As DataRow In DataTabla.Rows
                Dim Fila As String = ""
                Fila = Fila & row.Item(0)
                Fila = Fila & row.Item(1)
                Fila = Fila & row.Item(2)
                Fila = Fila & row.Item(3)
                Fila = Fila & row.Item(4)
                If Not DAL_DigitoVerificador.CalcularDVH(Fila) = row.Item(5) Then
                    Return Nothing
                End If
                DigitosHorizontales = DigitosHorizontales & row.Item(5)
            Next
            Return DigitosHorizontales
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
