Imports EE
Imports BLL
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Reserva_Detalle_Viaje
    Implements BLL.BLL_Iobservador

    Protected Friend viaje As EE.BE_Viaje
    Protected Friend reservaViaje As EE.BE_ReservaViaje
    Protected Friend reservaDestino As EE.BE_Destino
    Protected Friend reservaOrigen As EE.BE_Destino
    Protected Friend reservaTransporte As EE.BE_Transporte

    Sub New(ByVal oViaje As BE_Viaje, ByVal oReservaViaje As BE_ReservaViaje, ByVal oOrigen As BE_Destino, ByVal oDestino As BE_Destino)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        viaje = oViaje
        reservaViaje = oReservaViaje
        reservaDestino = oDestino
        reservaOrigen = oOrigen
        reservaTransporte = oViaje.Transporte
        iniciar()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub iniciar()
        Me.Txtdestino.Text = reservaDestino.NombreCompleto
        Me.Txtempresatrans.Text = viaje.Transporte.Empresa.Nombre
        Me.Txtfechaviaje.Text = viaje.FechaHoraSalida
        Me.Txttipotrans.Text = reservaTransporte.TipoTransporte.ToString
        Me.Txtorigen.Text = reservaOrigen.NombreCompleto
        Me.TextBox1.Text = reservaViaje.Asiento.NumeroAsiento
        Me.txtValorReserva.Text = reservaViaje.MontoReserva
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formulariobuscarviaje As New Reserva_Buscar_Viaje()
        formulariobuscarviaje.Show()
        Me.Close()
    End Sub

    Private Sub btnFinalizarCompra_Click(sender As Object, e As EventArgs) Handles btnFinalizarCompra.Click
        Me.Close()
    End Sub

    Private Sub btnGenerarPDF_Click(sender As Object, e As EventArgs) Handles btnGenerarPDF.Click
        GenerarPDF()
    End Sub


    Private Sub GenerarPDF()
        Dim oReservaViaje As BE_ReservaViaje
        Dim bllReservaAlojamiento As New BLL_Reserva
        oReservaViaje = bllReservaAlojamiento.consultarReservaviajeID(reservaViaje)

        Dim oDoc As New iTextSharp.text.Document(PageSize.A4.Rotate, 0, 0, 50, 20)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        Dim RutaDeaplicacion As String = Application.StartupPath
        Dim NombreArchivo As String = "Comprobante de Reserva -" & oReservaViaje.NumeroReserva & ".pdf"
        Dim contador As Integer = 0
        Try
            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo,
            FileMode.Create, FileAccess.Write, FileShare.None))
            oDoc.Open()
            oDoc.NewPage()
            Encabezado(pdfw, oDoc)
            Dim tabla As PdfPTable = New PdfPTable(7)
            tabla.AddCell(oReservaViaje.NumeroReserva)
            tabla.AddCell(oReservaViaje.TipoReserva.ToString)
            tabla.AddCell(oReservaViaje.viaje.FechaHoraLlegada.ToShortDateString)
            tabla.AddCell(oReservaViaje.viaje.FechaHoraLlegada.ToShortDateString)
            tabla.AddCell(oReservaViaje.Pasajero.NombreCompleto)
            tabla.AddCell(oReservaViaje.MontoReserva)
            tabla.AddCell(oReservaViaje.viaje.Transporte.Descripcion)
            oDoc.Add(tabla)
            contador += 1
            If contador = 12 Then
                oDoc.NewPage()
                Encabezado(pdfw, oDoc)
                contador = 0
            End If
            oDoc.Close()
            Dim EjecutarArchivo = RutaDeaplicacion & "\Comprobante de Reserva -" & oReservaViaje.NumeroReserva & ".pdf"
            'Aparenta anda. Esperemos que ande cuando instalo la aplicacion. 
            psi.FileName = EjecutarArchivo
            Process.Start(psi)
        Catch ex As Exception
        Finally
            pdfw = Nothing
            oDoc = Nothing
        End Try
    End Sub
    Private Sub Encabezado(ByVal writer As iTextSharp.text.pdf.PdfWriter, ByVal odoc As iTextSharp.text.Document)
        Dim cbPie As PdfContentByte
        Dim cbEncabezado As PdfContentByte
        cbEncabezado = writer.DirectContent
        With cbEncabezado
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 20)
            .SetColorFill(iTextSharp.text.BaseColor.BLACK)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Comprobante de Reserva - Mundo Travel", 425, 550, 0)
            .SetWordSpacing(10)
            .EndText()
        End With
        Dim table As PdfPTable = New PdfPTable(7)

        Dim Celda As New PdfPCell(New Phrase("Numero de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda2 As New PdfPCell(New Phrase("Tipo de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda2.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda3 As New PdfPCell(New Phrase("Fecha y Hora de Salida", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda3.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda3.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda4 As New PdfPCell(New Phrase("Fecha y Hora de Llegada", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda4.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda4.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda5 As New PdfPCell(New Phrase("Pasajero", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda5.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda5.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda6 As New PdfPCell(New Phrase("Monto de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda6.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda6.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda7 As New PdfPCell(New Phrase("Transporte", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda7.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda7.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)
        table.AddCell(Celda)
        table.AddCell(Celda2)
        table.AddCell(Celda3)
        table.AddCell(Celda4)
        table.AddCell(Celda5)
        table.AddCell(Celda6)
        table.AddCell(Celda7)

        odoc.Add(table)
        cbPie = writer.DirectContent
        cbPie.BeginText()
        cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 10)
        cbPie.SetColorFill(iTextSharp.text.BaseColor.BLACK)
        cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " & writer.PageNumber, 720, 25, 0)
        cbPie.EndText()
    End Sub

    Public Sub actualizarIdioma(ParamObservador As BLL_SesionObservada) Implements BLL_Iobservador.actualizarIdioma
        Dim MiTraductor As New ControladorTraductor
        MiTraductor.TraducirForm(SessionBLL.SesionActual.ListaForm.Item(SessionBLL.SesionActual.ListaForm.IndexOf(Me)))

    End Sub

    Private Sub Reserva_Detalle_Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub Reserva_Detalle_Viaje_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Vuelos")
    End Sub
End Class