Imports System.Drawing.Printing
Public Class FormAnalyzing

    Private Sub FormAnalyzing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintPreviewBtn_Click(sender As Object, e As EventArgs) Handles PrintPreviewBtn.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        Dim pagesetup As New PageSettings
        With pagesetup
            .Margins.Left = 30
            .Margins.Right = 20
            .Margins.Top = 30
            .Margins.Bottom = 20
            .Landscape = False
        End With

        'If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

        '    Dim pagesetup As New PageSettings
        '    With pagesetup
        '        .Margins.Left = 30
        '        .Margins.Right = 20
        '        .Margins.Top = 30
        '        .Margins.Bottom = 20
        '        .Landscape = False

        '    End With
        '    PrintDocument1.DefaultPageSettings = pagesetup
        'End If

        PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Far

        Dim f12 As New Font("Times New Roman", 12, FontStyle.Regular)
        Dim f18 As New Font("Times New Roman", 18, FontStyle.Regular)
        Dim f12b As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim f18b As New Font("Times New Roman", 18, FontStyle.Bold)

        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width - 50
        Dim topmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim bottommargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Height

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        Dim justify As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center
        Dim rect As New Rectangle(leftmargin, topmargin + 160, rightmargin - leftmargin, bottommargin - topmargin)


        e.Graphics.DrawString("HASIL ANALISIS", f18b, Brushes.Black, centermargin, topmargin, tengah)
        e.Graphics.DrawString("Tanggal : " + Date_Analisis.Text, f12b, Brushes.Black, leftmargin, topmargin + 80)
        e.Graphics.DrawString("Nama Dokter : " + tb_namadok.Text, f12b, Brushes.Black, leftmargin, topmargin + 100)
        e.Graphics.DrawString("Hasil : ", f12b, Brushes.Black, leftmargin, topmargin + 140)
        e.Graphics.DrawString(RTB_analisis.Text, f12, Brushes.Black, rect, StringFormat.GenericDefault)




    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Left = 30
                .Margins.Right = 20
                .Margins.Top = 30
                .Margins.Bottom = 20
                .Landscape = False

            End With
            PrintDocument1.DefaultPageSettings = pagesetup
        End If
    End Sub
End Class