<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnalyzing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnalyzing))
        Me.tb_namadok = New System.Windows.Forms.TextBox()
        Me.Label_NamaDoc = New System.Windows.Forms.Label()
        Me.Label_analisis = New System.Windows.Forms.Label()
        Me.RTB_analisis = New System.Windows.Forms.RichTextBox()
        Me.Date_Analisis = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.PrintPreviewBtn = New FontAwesome.Sharp.IconButton()
        Me.PrintBtn = New FontAwesome.Sharp.IconButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'tb_namadok
        '
        Me.tb_namadok.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_namadok.Location = New System.Drawing.Point(307, 52)
        Me.tb_namadok.Name = "tb_namadok"
        Me.tb_namadok.Size = New System.Drawing.Size(542, 45)
        Me.tb_namadok.TabIndex = 0
        '
        'Label_NamaDoc
        '
        Me.Label_NamaDoc.AutoSize = True
        Me.Label_NamaDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaDoc.ForeColor = System.Drawing.Color.White
        Me.Label_NamaDoc.Location = New System.Drawing.Point(49, 58)
        Me.Label_NamaDoc.Name = "Label_NamaDoc"
        Me.Label_NamaDoc.Size = New System.Drawing.Size(210, 38)
        Me.Label_NamaDoc.TabIndex = 1
        Me.Label_NamaDoc.Text = "Nama Dokter"
        '
        'Label_analisis
        '
        Me.Label_analisis.AutoSize = True
        Me.Label_analisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_analisis.ForeColor = System.Drawing.Color.White
        Me.Label_analisis.Location = New System.Drawing.Point(49, 175)
        Me.Label_analisis.Name = "Label_analisis"
        Me.Label_analisis.Size = New System.Drawing.Size(130, 38)
        Me.Label_analisis.TabIndex = 2
        Me.Label_analisis.Text = "Analisis"
        '
        'RTB_analisis
        '
        Me.RTB_analisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_analisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_analisis.Location = New System.Drawing.Point(47, 228)
        Me.RTB_analisis.Name = "RTB_analisis"
        Me.RTB_analisis.Size = New System.Drawing.Size(989, 657)
        Me.RTB_analisis.TabIndex = 3
        Me.RTB_analisis.Text = ""
        '
        'Date_Analisis
        '
        Me.Date_Analisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Analisis.Location = New System.Drawing.Point(307, 112)
        Me.Date_Analisis.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.Date_Analisis.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.Date_Analisis.Name = "Date_Analisis"
        Me.Date_Analisis.Size = New System.Drawing.Size(542, 45)
        Me.Date_Analisis.TabIndex = 4
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.AutoSize = True
        Me.lbl_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal.ForeColor = System.Drawing.Color.White
        Me.lbl_tanggal.Location = New System.Drawing.Point(49, 118)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(134, 38)
        Me.lbl_tanggal.TabIndex = 1
        Me.lbl_tanggal.Text = "Tanggal"
        '
        'PrintPreviewBtn
        '
        Me.PrintPreviewBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.PrintPreviewBtn.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.PrintPreviewBtn.IconColor = System.Drawing.Color.Black
        Me.PrintPreviewBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PrintPreviewBtn.IconSize = 48
        Me.PrintPreviewBtn.Location = New System.Drawing.Point(855, 52)
        Me.PrintPreviewBtn.Name = "PrintPreviewBtn"
        Me.PrintPreviewBtn.Rotation = 0R
        Me.PrintPreviewBtn.Size = New System.Drawing.Size(99, 101)
        Me.PrintPreviewBtn.TabIndex = 5
        Me.PrintPreviewBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.PrintBtn.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.PrintBtn.IconColor = System.Drawing.Color.Black
        Me.PrintBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PrintBtn.IconSize = 48
        Me.PrintBtn.Location = New System.Drawing.Point(961, 52)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Rotation = 0R
        Me.PrintBtn.Size = New System.Drawing.Size(93, 101)
        Me.PrintBtn.TabIndex = 6
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'FormAnalyzing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 910)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.PrintPreviewBtn)
        Me.Controls.Add(Me.Date_Analisis)
        Me.Controls.Add(Me.RTB_analisis)
        Me.Controls.Add(Me.Label_analisis)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.Label_NamaDoc)
        Me.Controls.Add(Me.tb_namadok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAnalyzing"
        Me.Text = "Analyzing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_namadok As TextBox
    Friend WithEvents Label_NamaDoc As Label
    Friend WithEvents Label_analisis As Label
    Friend WithEvents RTB_analisis As RichTextBox
    Friend WithEvents Date_Analisis As DateTimePicker
    Friend WithEvents lbl_tanggal As Label
    Friend WithEvents PrintPreviewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
