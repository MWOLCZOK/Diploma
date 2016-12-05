Imports EE
Imports DAL
Public Class BLL_Transporte
    Dim _dalTransporte As New DAL_Transporte

    Public Sub altaTransporte(ByVal paramTransporte As BE_Transporte)
        Try
            _dalTransporte.alta(paramTransporte)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub


    Public Function obtenerAsientos(ByVal paramCantidadEj As Integer, ByVal paramCantidadPrem As Integer, ByVal paramcantidadPri As Integer, ByVal paramCantidadTur As Integer, ByVal paramCantidadAsientos As Integer) As List(Of EE.BE_Asiento)
        Dim NumeroAsiento As Integer = 1
        Dim cantidadEjecutiva As Integer = 0
        Dim cantidadPremium As Integer = 0
        Dim cantidadPrimera As Integer = 0
        Dim cantidadTurista As Integer = 0
        Dim cantidadAsientosporFila As Integer = 0
        Dim cantAsientoFila As Integer = 0
        Dim fila As Integer = 1
        cantidadAsientosporFila = paramCantidadAsientos
        cantidadEjecutiva = paramCantidadEj
        cantidadPremium = paramCantidadPrem
        cantidadPrimera = paramcantidadPri
        cantidadTurista = paramCantidadTur
        Dim listaAsientos As New List(Of EE.BE_Asiento)
        'CARGO LOS EJECUTIVOS
        For i = 1 To cantidadEjecutiva
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 1
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            oAsiento.Fila = fila
            cantAsientoFila += 1
            If cantAsientoFila = cantidadAsientosporFila Then
                fila += 1
                cantAsientoFila = 0
            End If
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS PREMIUM
        For i = 1 To cantidadPremium
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 2
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            oAsiento.Fila = fila
            cantAsientoFila += 1
            If cantAsientoFila = cantidadAsientosporFila Then
                fila += 1
                cantAsientoFila = 0
            End If
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS DE PRIMERA
        For i = 1 To cantidadPrimera
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 3
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            oAsiento.Fila = fila
            cantAsientoFila += 1
            If cantAsientoFila = cantidadAsientosporFila Then
                fila += 1
                cantAsientoFila = 0
            End If
            listaAsientos.Add(oAsiento)
        Next
        'CARGO LOS TURISTA
        For i = 1 To cantidadTurista
            Dim oCategoriaAsiento As New BE_CategoriaAsiento
            oCategoriaAsiento.ID = 4
            Dim oAsiento As New BE_Asiento
            oAsiento.CategoriaAsiento = oCategoriaAsiento
            oAsiento.NumeroAsiento = NumeroAsiento
            NumeroAsiento += 1
            oAsiento.Fila = fila
            cantAsientoFila += 1
            If cantAsientoFila = cantidadAsientosporFila Then
                fila += 1
                cantAsientoFila = 0
            End If
            listaAsientos.Add(oAsiento)
        Next
        Return listaAsientos
    End Function


    Public Sub eliminarTransporte(ByVal paramTransporte As BE_Transporte)
        Try
            _dalTransporte.eliminar(paramTransporte)
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificarTransporte(ByVal paramTransporte As BE_Transporte) As Boolean
        Try
            _dalTransporte.modificar(paramTransporte)
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarTransportes() As List(Of BE_Transporte)
        Return _dalTransporte.consultarTransportes()
    End Function

    Public Function consultarTransporte(ByVal paramTransporte As BE_Transporte) As List(Of BE_Transporte)
        Return _dalTransporte.consultarTransportes()
    End Function


End Class
