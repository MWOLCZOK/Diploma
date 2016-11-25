Imports DAL
Imports System.Security.Cryptography
Imports EE
Imports System.Text
Imports BLL
Imports System.Threading

Public Class BLL_DigitoVerificador

    Public Shared Function Integridad() As Boolean
        Try
            Thread.CurrentThread.CurrentCulture = SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Cultura
            Thread.CurrentThread.CurrentUICulture = SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Cultura
            Dim gestorusuario As DAL_Usuario = New DAL_Usuario
            Dim gestorbitacora As DAL_Bitacora = New DAL_Bitacora
            Dim DHUsuario As String = ""
            Dim DHbitacora As String = ""
            DHUsuario = gestorusuario.Integridad
            DHbitacora = gestorbitacora.Integridad
            If Not IsNothing(DHbitacora) Then
                If Not IsNothing(DHUsuario) Then
                    Dim DataTabla = (New DAL_DigitoVerificador).VerificarIntegridad
                    For Each row As DataRow In DataTabla.Rows
                        If row.Item(0) = "Usuario" And DAL_DigitoVerificador.CalcularDVH(DHUsuario) = row.Item(1) Then
                        Else
                            Return False
                        End If
                    Next
                    Return True
                Else
                    Throw New Exception
                End If
            End If

            Return False
        Catch ex As Exception
            BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora("El Metodo " & ex.TargetSite.ToString & " generó un error. Su mensaje es: " & ex.Message, BE_TipoBitacora.Errores, SessionBLL.SesionActual.ObtenerUsuarioActual))
            'BLL_Bitacora.CrearBitacora(New EE.BE_Bitacora(midetalle:=("asd"), micodigo:=BE_TipoBitacora.Errores, miusuario:=SessionBLL.SesionActual.ObtenerUsuarioActual))
            Throw ex
        End Try
    End Function

    Public Function ProbarConectividad() As Boolean
        Return (New DAL_DigitoVerificador).ProbarConectividad
    End Function


End Class
