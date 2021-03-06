﻿Option Compare Text
Imports System.Windows
Imports EE

Public Class ControladorTraductor
    Public Sub TraducirForm(ByVal paramForm As Form)
        Try
            Dim MiListaPalabras = BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Palabras
            For Each MiPalabra As EE.BE_Palabras In MiListaPalabras
                If paramForm.Name = MiPalabra.Codigo Then
                    paramForm.Text = MiPalabra.Traduccion
                End If
                For Each MiControl As Control In paramForm.Controls

                    If MiControl.Name = MiPalabra.Codigo Then
                        MiControl.Text = MiPalabra.Traduccion
                    End If

                    If MiControl.GetType Is GetType(GroupBox) Then
                        For Each Groupboxcontrol As Control In MiControl.Controls
                            If Groupboxcontrol.Name = MiPalabra.Codigo Then
                                Groupboxcontrol.Text = MiPalabra.Traduccion
                            End If
                        Next
                    End If



                    If MiControl.GetType() Is GetType(MenuStrip) Then
                        Dim MiMenu As MenuStrip = MiControl
                        For Each MiItem As ToolStripMenuItem In MiMenu.Items
                            If MiItem.Name = MiPalabra.Codigo Then
                                MiItem.Text = MiPalabra.Traduccion
                            End If
                            For Each misubitem As ToolStripMenuItem In MiItem.DropDownItems
                                If misubitem.Name = MiPalabra.Codigo Then
                                    misubitem.Text = MiPalabra.Traduccion
                                End If
                                For Each misubsubitem As ToolStripMenuItem In misubitem.DropDownItems
                                    If misubsubitem.Name = MiPalabra.Codigo Then
                                        misubsubitem.Text = MiPalabra.Traduccion
                                    End If
                                Next
                            Next
                        Next

                    End If

                    If MiControl.GetType Is GetType(DataGridView) Then
                        Dim MiDataGrid As DataGridView = MiControl
                        For Each MiColumna As DataGridViewColumn In MiDataGrid.Columns
                            If MiColumna.Name = MiPalabra.Codigo Then
                                MiColumna.HeaderText = MiPalabra.Traduccion
                            End If
                        Next
                    End If
                Next
            Next
        Catch FalloConexion As InvalidOperationException
            Throw FalloConexion
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Shared Function TraducirMensaje(ByVal paramCodigo As String) As String
        Dim MiPalabra As New EE.BE_Palabras
        MiPalabra.Codigo = paramCodigo
        For Each MiTraduccion As EE.BE_Palabras In BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Palabras
            If MiTraduccion.Codigo = paramCodigo Then
                Return MiTraduccion.Traduccion
            End If
        Next
        Return "Mensaje Sin Traducción"
    End Function

End Class
