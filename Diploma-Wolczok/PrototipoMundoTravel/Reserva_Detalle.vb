Imports EE
Imports BLL
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Reserva_Detalle

    Implements BLL.BLL_Iobservador

    Protected Friend reservaAlojamiento As EE.BE_ReservaAlojamiento
    Protected Friend reservaDestino As EE.BE_Destino
    Protected Friend Alojamiento As EE.BE_Alojamiento


    Sub New(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        iniciar(paramAlojamiento, paramDestino, paramReservaAlojamiento)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub iniciar(ByVal paramAlojamiento As BE_Alojamiento, ByVal paramDestino As BE_Destino, ByVal paramReservaAlojamiento As BE_ReservaAlojamiento)
        Try
            reservaAlojamiento = paramReservaAlojamiento
            reservaDestino = paramDestino
            Alojamiento = paramAlojamiento
            Me.TextBox1.Text = paramAlojamiento.Nombre
            Me.TextBox2.Text = paramReservaAlojamiento.Fecha_Inicio.Date
            Me.TextBox3.Text = paramReservaAlojamiento.Fecha_Fin.Date
            Me.TextBox4.Text = paramDestino.NombreCompleto
            Me.TextBox5.Text = paramReservaAlojamiento.Habitacion.Descripcion
            Me.TextBox6.Text = paramReservaAlojamiento.Habitacion.ID
            Me.txtValorReserva.Text = paramReservaAlojamiento.MontoReserva
        Catch ex As Exception
            MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_126"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnFinalizarCompra.Click
        MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_124"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVolverComprar.Click
        MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_125"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim formulariobuscaralojamiento As New Reserva_Buscar_Alojamiento()
        formulariobuscaralojamiento.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnGenerarPDF.Click
        GenerarPDF()
        MessageBox.Show(ControladorTraductor.TraducirMensaje("Mensaje_127"), ControladorTraductor.TraducirMensaje("Titulo_Mensaje_0"), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub GenerarPDF()
        Dim oReservaAlojamiento As BE_ReservaAlojamiento
        Dim bllReservaAlojamiento As New BLL_Reserva
        oReservaAlojamiento = bllReservaAlojamiento.consultarReservaAlojamientoID(reservaAlojamiento)

        Dim oDoc As New iTextSharp.text.Document(PageSize.A4.Rotate, 0, 0, 50, 20)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        Dim RutaDeaplicacion As String = Application.StartupPath
        Dim NombreArchivo As String = "Comprobante de Reserva -" & oReservaAlojamiento.ID & ".pdf"
        Dim contador As Integer = 0
        Try
            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo,
            FileMode.Create, FileAccess.Write, FileShare.None))
            oDoc.Open()
            oDoc.NewPage()
            Encabezado(pdfw, oDoc)
            Dim tabla As PdfPTable = New PdfPTable(7)
            tabla.AddCell(oReservaAlojamiento.ID)
            tabla.AddCell(oReservaAlojamiento.TipoReserva.ToString)
            tabla.AddCell(oReservaAlojamiento.Fecha_Inicio.ToShortDateString)
            tabla.AddCell(oReservaAlojamiento.Fecha_Fin.ToShortDateString)
            tabla.AddCell(oReservaAlojamiento.Pasajero.NombreCompleto)
            tabla.AddCell(oReservaAlojamiento.MontoReserva)
            tabla.AddCell(oReservaAlojamiento.Habitacion.Descripcion)
            oDoc.Add(tabla)
            contador += 1
            If contador = 12 Then
                oDoc.NewPage()
                Encabezado(pdfw, oDoc)
                contador = 0
            End If
            oDoc.Close()
            Dim EjecutarArchivo = RutaDeaplicacion & "\Comprobante de Reserva -" & oReservaAlojamiento.NumeroReserva & ".pdf"
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

        Dim Celda As New PdfPCell(New Phrase("Identificador de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda2 As New PdfPCell(New Phrase("Tipo de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda2.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda3 As New PdfPCell(New Phrase("Fecha de Check-In", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda3.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda3.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda4 As New PdfPCell(New Phrase("Fecha de Check-Out", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda4.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda4.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda5 As New PdfPCell(New Phrase("Pasajero", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda5.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda5.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda6 As New PdfPCell(New Phrase("Monto de Reserva", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
        Celda6.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Celda6.BackgroundColor = New iTextSharp.text.BaseColor(51, 102, 153)

        Dim Celda7 As New PdfPCell(New Phrase("Habitacion", New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
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

    Private Sub Reserva_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SessionBLL.SesionActual.agregarForm(Me)
        SessionBLL.SesionActual.notificarCambiodeIdioma()
    End Sub

    Private Sub Reserva_Detalle_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested

        Dim RutaDeaplicacion As String = Application.StartupPath & "\Ayuda-MundoTravel.chm"
        Help.ShowHelp(ParentForm, RutaDeaplicacion, HelpNavigator.KeywordIndex, "Alojamiento")
    End Sub
End Class


