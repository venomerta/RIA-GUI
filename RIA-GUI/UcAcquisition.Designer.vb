<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcAcquisition
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.TabControlAcquisition = New System.Windows.Forms.TabControl()
        Me.TabCalibrator = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_tc = New System.Windows.Forms.TextBox()
        Me.tb_a = New System.Windows.Forms.TextBox()
        Me.tb_h = New System.Windows.Forms.TextBox()
        Me.tb_b = New System.Windows.Forms.TextBox()
        Me.tb_g = New System.Windows.Forms.TextBox()
        Me.tb_c = New System.Windows.Forms.TextBox()
        Me.tb_f = New System.Windows.Forms.TextBox()
        Me.tb_d = New System.Windows.Forms.TextBox()
        Me.tb_e = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.sample_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.net_cpm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bounding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concentration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TabPasien = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btn_start = New FontAwesome.Sharp.IconButton()
        Me.btn_stop = New FontAwesome.Sharp.IconButton()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.TabControlAcquisition.SuspendLayout()
        Me.TabCalibrator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlAcquisition
        '
        Me.TabControlAcquisition.Controls.Add(Me.TabCalibrator)
        Me.TabControlAcquisition.Controls.Add(Me.TabPasien)
        Me.TabControlAcquisition.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlAcquisition.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAcquisition.Name = "TabControlAcquisition"
        Me.TabControlAcquisition.SelectedIndex = 0
        Me.TabControlAcquisition.Size = New System.Drawing.Size(895, 337)
        Me.TabControlAcquisition.TabIndex = 0
        '
        'TabCalibrator
        '
        Me.TabCalibrator.Controls.Add(Me.GroupBox1)
        Me.TabCalibrator.Controls.Add(Me.DataGridView1)
        Me.TabCalibrator.Controls.Add(Me.CheckedListBox1)
        Me.TabCalibrator.Location = New System.Drawing.Point(4, 22)
        Me.TabCalibrator.Name = "TabCalibrator"
        Me.TabCalibrator.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCalibrator.Size = New System.Drawing.Size(887, 311)
        Me.TabCalibrator.TabIndex = 0
        Me.TabCalibrator.Text = "Calibrator"
        Me.TabCalibrator.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_tc)
        Me.GroupBox1.Controls.Add(Me.tb_a)
        Me.GroupBox1.Controls.Add(Me.tb_h)
        Me.GroupBox1.Controls.Add(Me.tb_b)
        Me.GroupBox1.Controls.Add(Me.tb_g)
        Me.GroupBox1.Controls.Add(Me.tb_c)
        Me.GroupBox1.Controls.Add(Me.tb_f)
        Me.GroupBox1.Controls.Add(Me.tb_d)
        Me.GroupBox1.Controls.Add(Me.tb_e)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(178, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 305)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'tb_tc
        '
        Me.tb_tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tc.Location = New System.Drawing.Point(6, 10)
        Me.tb_tc.Name = "tb_tc"
        Me.tb_tc.Size = New System.Drawing.Size(80, 20)
        Me.tb_tc.TabIndex = 1
        '
        'tb_a
        '
        Me.tb_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_a.Location = New System.Drawing.Point(6, 39)
        Me.tb_a.Name = "tb_a"
        Me.tb_a.Size = New System.Drawing.Size(80, 20)
        Me.tb_a.TabIndex = 1
        '
        'tb_h
        '
        Me.tb_h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_h.Location = New System.Drawing.Point(5, 242)
        Me.tb_h.Name = "tb_h"
        Me.tb_h.Size = New System.Drawing.Size(80, 20)
        Me.tb_h.TabIndex = 1
        '
        'tb_b
        '
        Me.tb_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_b.Location = New System.Drawing.Point(5, 68)
        Me.tb_b.Name = "tb_b"
        Me.tb_b.Size = New System.Drawing.Size(80, 20)
        Me.tb_b.TabIndex = 1
        '
        'tb_g
        '
        Me.tb_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_g.Location = New System.Drawing.Point(5, 213)
        Me.tb_g.Name = "tb_g"
        Me.tb_g.Size = New System.Drawing.Size(80, 20)
        Me.tb_g.TabIndex = 1
        '
        'tb_c
        '
        Me.tb_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_c.Location = New System.Drawing.Point(6, 97)
        Me.tb_c.Name = "tb_c"
        Me.tb_c.Size = New System.Drawing.Size(80, 20)
        Me.tb_c.TabIndex = 1
        '
        'tb_f
        '
        Me.tb_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f.Location = New System.Drawing.Point(5, 184)
        Me.tb_f.Name = "tb_f"
        Me.tb_f.Size = New System.Drawing.Size(80, 20)
        Me.tb_f.TabIndex = 1
        '
        'tb_d
        '
        Me.tb_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d.Location = New System.Drawing.Point(5, 126)
        Me.tb_d.Name = "tb_d"
        Me.tb_d.Size = New System.Drawing.Size(80, 20)
        Me.tb_d.TabIndex = 1
        '
        'tb_e
        '
        Me.tb_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_e.Location = New System.Drawing.Point(5, 155)
        Me.tb_e.Name = "tb_e"
        Me.tb_e.Size = New System.Drawing.Size(80, 20)
        Me.tb_e.TabIndex = 1
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sample_name, Me.Count_1, Me.count_2, Me.count_average, Me.net_cpm, Me.bounding, Me.concentration})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(178, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(706, 305)
        Me.DataGridView1.TabIndex = 2
        '
        'sample_name
        '
        Me.sample_name.HeaderText = "Sample"
        Me.sample_name.Name = "sample_name"
        '
        'Count_1
        '
        Me.Count_1.HeaderText = "Count1"
        Me.Count_1.Name = "Count_1"
        '
        'count_2
        '
        Me.count_2.HeaderText = "Count 2"
        Me.count_2.Name = "count_2"
        '
        'count_average
        '
        Me.count_average.HeaderText = "Count Avrg"
        Me.count_average.Name = "count_average"
        '
        'net_cpm
        '
        Me.net_cpm.HeaderText = "Net CPM"
        Me.net_cpm.Name = "net_cpm"
        '
        'bounding
        '
        Me.bounding.HeaderText = "% Bounding"
        Me.bounding.Name = "bounding"
        '
        'concentration
        '
        Me.concentration.HeaderText = "Concentration"
        Me.concentration.Name = "concentration"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Total Counting", "A", "B", "C", "D", "E", "F", "G", "H"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(175, 305)
        Me.CheckedListBox1.TabIndex = 0
        '
        'TabPasien
        '
        Me.TabPasien.Location = New System.Drawing.Point(4, 22)
        Me.TabPasien.Name = "TabPasien"
        Me.TabPasien.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPasien.Size = New System.Drawing.Size(887, 311)
        Me.TabPasien.TabIndex = 1
        Me.TabPasien.Text = "Pasien"
        Me.TabPasien.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 576)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(892, 39)
        Me.ProgressBar1.TabIndex = 4
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Location = New System.Drawing.Point(0, 342)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(889, 228)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'btn_start
        '
        Me.btn_start.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_start.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.btn_start.IconColor = System.Drawing.Color.Black
        Me.btn_start.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_start.IconSize = 50
        Me.btn_start.Location = New System.Drawing.Point(202, 621)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Rotation = 0R
        Me.btn_start.Size = New System.Drawing.Size(104, 101)
        Me.btn_start.TabIndex = 5
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_stop.IconChar = FontAwesome.Sharp.IconChar.[Stop]
        Me.btn_stop.IconColor = System.Drawing.Color.Black
        Me.btn_stop.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stop.IconSize = 50
        Me.btn_stop.Location = New System.Drawing.Point(397, 621)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Rotation = 0R
        Me.btn_stop.Size = New System.Drawing.Size(110, 101)
        Me.btn_stop.TabIndex = 6
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_save.IconColor = System.Drawing.Color.Black
        Me.btn_save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_save.IconSize = 48
        Me.btn_save.Location = New System.Drawing.Point(577, 621)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Rotation = 0R
        Me.btn_save.Size = New System.Drawing.Size(114, 101)
        Me.btn_save.TabIndex = 7
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'UcAcquisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.TabControlAcquisition)
        Me.Name = "UcAcquisition"
        Me.Size = New System.Drawing.Size(895, 725)
        Me.TabControlAcquisition.ResumeLayout(False)
        Me.TabCalibrator.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlAcquisition As TabControl
    Friend WithEvents TabCalibrator As TabPage
    Friend WithEvents tb_h As TextBox
    Friend WithEvents tb_g As TextBox
    Friend WithEvents tb_f As TextBox
    Friend WithEvents tb_e As TextBox
    Friend WithEvents tb_d As TextBox
    Friend WithEvents tb_c As TextBox
    Friend WithEvents tb_b As TextBox
    Friend WithEvents tb_a As TextBox
    Friend WithEvents tb_tc As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabPasien As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents sample_name As DataGridViewTextBoxColumn
    Friend WithEvents Count_1 As DataGridViewTextBoxColumn
    Friend WithEvents count_2 As DataGridViewTextBoxColumn
    Friend WithEvents count_average As DataGridViewTextBoxColumn
    Friend WithEvents net_cpm As DataGridViewTextBoxColumn
    Friend WithEvents bounding As DataGridViewTextBoxColumn
    Friend WithEvents concentration As DataGridViewTextBoxColumn
    Friend WithEvents btn_start As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stop As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
End Class
