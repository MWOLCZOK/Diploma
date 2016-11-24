Imports System.IO
Imports Newtonsoft.Json
Imports EE
Public Class SerializadorJSON(Of T)
    Public Sub Serializar(que As T)
        Dim fs As FileStream
        Dim pasajeros As New List(Of BE_Pasajero)
        If que.GetType.Equals(pasajeros.GetType) Then
            fs = New FileStream("Pasajeros" & Now.Date.Month & "-" & Now.Date.Year & ".JSON", FileMode.Append)
        Else
            fs = New FileStream("Objetos.JSON", FileMode.Append)
        End If
        Dim writer As TextWriter
        writer = New StreamWriter(fs)
        Dim serializer As New JsonSerializer
        Using writer
            serializer.Serialize(writer, que)
        End Using
        writer.Close()
        fs.Close()
    End Sub

    Public Function Deserializar(str As Stream, obj As T) As Object
        Dim serializer As New JsonSerializer()
        Dim tr As TextReader = New StreamReader(str)
        Dim o As T = serializer.Deserialize(tr, GetType(T))
        tr.Close()
        Return o
    End Function

End Class
