Imports EE
Imports DAL

Public Class BLL_Pasajero


    Dim _dalpasajero As New DAL_Pasajero

    Public Sub Altapasajero(ByVal parampasajero As BE_Pasajero)
        Try
            _dalpasajero.alta(parampasajero)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarPasajero(ByVal parampasajero As BE_Pasajero)
        Try
            _dalpasajero.eliminar(parampasajero)
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificarPasajero(ByVal paramPasajero As BE_Pasajero) As Boolean
        Try
            _dalpasajero.modificar(paramPasajero)
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarPasajeros() As List(Of BE_Pasajero)
        Return _dalpasajero.consultarPasajeros()
    End Function


    Public Function consultarPasajeroporDNI(ByVal paramPasajaero As BE_Pasajero) As List(Of BE_Pasajero)
        Return _dalpasajero.consultarPasajeroporDNI(paramPasajaero)
    End Function

    Public Function consultarPasajero(ByVal paramPasajaero As BE_Pasajero) As BE_Pasajero
        Return _dalpasajero.consultarPasajero(paramPasajaero)
    End Function



End Class
