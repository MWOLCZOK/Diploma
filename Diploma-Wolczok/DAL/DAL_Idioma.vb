Imports EE
Imports System.Data.SqlClient
Imports System.Globalization

Public Class DAL_Idioma

    Private Function formatearIdioma(ByVal paramDataRow As DataRow) As EE.BE_Idioma
        Try
            Dim oIdioma As New EE.BE_Idioma
            oIdioma.id_idioma = paramDataRow.Item("ID_Idioma")
            oIdioma.Nombre = paramDataRow.Item("Nombre")
            oIdioma.editable = paramDataRow.Item("Editable")
            oIdioma.Cultura = CultureInfo.GetCultureInfo(paramDataRow("Cultura"))
            oIdioma.BL = paramDataRow.Item("BL")
            oIdioma.Palabras = Me.TraerPalabras(oIdioma.id_idioma)
            Return oIdioma
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarPorID(ByVal ID_Idioma As Integer) As EE.BE_Idioma
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Idioma where ID_Idioma=@IDIdioma")
            Command.Parameters.Add(New SqlParameter("@IDIdioma", ID_Idioma))
            Dim _dt As DataTable = Acceso.Lectura(Command)
            Dim Miidioma As New BE_Idioma
            If _dt.Rows.Count = 1 Then
                Miidioma = formatearIdioma(_dt.Rows(0))
            Else
                Return Nothing
            End If
            Return Miidioma
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function formatearPalabra(ByVal paramDataRow As DataRow) As EE.BE_Palabras
        Try
            Dim oPalabra As New EE.BE_Palabras
            oPalabra.ID_Control = paramDataRow("ID_Control")
            oPalabra.Codigo = paramDataRow("Nombre")
            oPalabra.Traduccion = paramDataRow("Palabra")
            Return oPalabra
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TraerPalabras(ByRef ID_Idioma As Integer) As List(Of EE.BE_Palabras)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Traduccion INNER JOIN Control on Traduccion.ID_Control = Control.ID_Control where ID_Idioma =@IDIdioma")
            Command.Parameters.Add(New SqlParameter("@IDIdioma", ID_Idioma))
            Dim _dt As DataTable = Acceso.Lectura(Command)
            Dim listaPalabras As List(Of EE.BE_Palabras) = New List(Of EE.BE_Palabras)
            For Each row As DataRow In _dt.Rows
                Dim Palabra As EE.BE_Palabras = formatearPalabra(row)
                listaPalabras.Add(Palabra)
            Next
            Return listaPalabras
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function consultarIdiomas() As List(Of EE.BE_Idioma)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Select * from Idioma where BL=@BL")
            Command.Parameters.Add(New SqlParameter("@BL", False))
            Dim _dt As DataTable = Acceso.Lectura(Command)
            Dim miListaIdioma As New List(Of BE_Idioma)
            For Each miRow As DataRow In _dt.Rows
                miListaIdioma.Add(formatearIdioma(miRow))
            Next
            Return miListaIdioma
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SeleccionarIdioma(ByRef Usuario As BE_Usuario, ByRef ID_Idioma As Integer) As BE_Idioma
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Update Usuario SET ID_Idioma=@ID_Idioma, DVH=@DVH where ID_Usuario=@ID_Usuario")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Idioma", ID_Idioma))
                .Add(New SqlParameter("@ID_Usuario", Usuario.ID))
                .Add(New SqlParameter("@DVH", DAL_DigitoVerificador.CalcularDVH(Usuario.ID & Usuario.NombreUsuario & Usuario.Password & Usuario.Bloqueado & Usuario.Intentos & ID_Idioma & Usuario.Perfil.ID & False)))
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
            Return Me.ConsultarPorID(ID_Idioma)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub altaIdioma(ByRef Idioma As EE.BE_Idioma)
        Try
            Idioma.ID_Idioma = Acceso.TraerID("ID_Idioma", "Idioma")
            Dim Command As SqlCommand = Acceso.MiComando("insert into Idioma values (@ID_Idioma, @Nombre, @Editable, @Cultura , @BL)")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Idioma", Idioma.ID_Idioma))
                .Add(New SqlParameter("@Nombre", Idioma.Nombre))
                .Add(New SqlParameter("@Editable", Idioma.Editable))
                .Add(New SqlParameter("@Cultura", Idioma.Cultura.Name))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()
            Dim Micomando As SqlCommand
            Dim ComandoStr As String = "insert into Traduccion values (@ID_Control, @ID_Idioma, @Palabra)"
            For Each MiPalabra As EE.BE_Palabras In Idioma.Palabras
                Micomando = Acceso.MiComando(ComandoStr)
                With Micomando.Parameters
                    .Add(New SqlParameter("@ID_Control", MiPalabra.ID_Control))
                    .Add(New SqlParameter("@ID_Idioma", Idioma.id_idioma))
                    .Add(New SqlParameter("@Palabra", MiPalabra.Traduccion))

                End With
                Acceso.Escritura(Micomando)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModificarIdioma(ByVal Idioma As EE.BE_Idioma)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Update Idioma set Nombre=@Nombre, Cultura=@Cultura where ID_Idioma = @ID_Idioma")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Idioma", Idioma.id_idioma))
                .Add(New SqlParameter("@Nombre", Idioma.Nombre))
                .Add(New SqlParameter("@Cultura", Idioma.Cultura.Name))
            End With
            Acceso.Escritura(Command)
            Command.Dispose()
            Dim Micomando As SqlCommand

            Dim CommandoEliminador As SqlCommand = Acceso.MiComando("Delete From Traduccion where ID_Idioma = @ID_Idioma")
            CommandoEliminador.Parameters.Add(New SqlParameter("@ID_Idioma", Idioma.id_idioma))
            Acceso.Escritura(CommandoEliminador)

            Dim ComandoStr As String = "insert into Traduccion values (@ID_Control, @ID_Idioma, @Palabra)"
            For Each MiPalabra As EE.BE_Palabras In Idioma.Palabras
                Micomando = Acceso.MiComando(ComandoStr)
                With Micomando.Parameters
                    .Add(New SqlParameter("@ID_Control", MiPalabra.ID_Control))
                    .Add(New SqlParameter("@ID_Idioma", Idioma.id_idioma))
                    .Add(New SqlParameter("@Palabra", MiPalabra.Traduccion))
                End With
                Acceso.Escritura(Micomando)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarIdioma(ByVal Idioma As EE.BE_Idioma)
        Try
            Dim Command As SqlCommand = Acceso.MiComando("Update Idioma set BL=@BL where ID_Idioma = @ID_Idioma;Update Usuario set idioma = 1 where idioma = @ID_Idioma")
            With Command.Parameters
                .Add(New SqlParameter("@ID_Idioma", Idioma.id_idioma))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(Command)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ConsultarNombre(ByVal Idiomas As String) As Boolean
        Try
            Dim _listaidiomas As List(Of EE.BE_Idioma) = New List(Of EE.BE_Idioma)
            Dim Command As SqlCommand = Acceso.MiComando("Select Nombre from Idioma where BL=@BL")
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim _dt As DataTable = Acceso.Lectura(Command)
            For Each _dr As DataRow In _dt.Rows
                Dim _idiom As EE.BE_Idioma = New EE.BE_Idioma
                _idiom.Nombre = _dr("Nombre")
                If Idiomas = _idiom.Nombre Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarIdiomasEditables() As List(Of EE.BE_Idioma)
        Try
            Dim _listaidiomas As New List(Of EE.BE_Idioma)
            Dim Command As SqlCommand
            Command = Acceso.MiComando("Select * from Idioma where Editable = 1 and bl= 0")
            Dim _dt As DataTable = Acceso.Lectura(Command)
            For Each _dr As DataRow In _dt.Rows
                Dim _idiom As EE.BE_Idioma = New EE.BE_Idioma
                _idiom.ID_Idioma = _dr("ID_Idioma")
                _idiom.Nombre = _dr("Nombre")
                _idiom.Editable = _dr("Editable")
                _idiom.Cultura = CultureInfo.GetCultureInfo(_dr("Cultura"))
                _listaidiomas.Add(_idiom)
            Next
            Return _listaidiomas
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
