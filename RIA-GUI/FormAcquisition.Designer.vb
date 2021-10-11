<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcquisition
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sampel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column_count1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column_count2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetCPM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersenBound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concentration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_background = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_stop = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_d = New System.Windows.Forms.TextBox()
        Me.tb_e = New System.Windows.Forms.TextBox()
        Me.tb_c = New System.Windows.Forms.TextBox()
        Me.tb_f = New System.Windows.Forms.TextBox()
        Me.tb_b = New System.Windows.Forms.TextBox()
        Me.tb_g = New System.Windows.Forms.TextBox()
        Me.tb_a = New System.Windows.Forms.TextBox()
        Me.tb_h = New System.Windows.Forms.TextBox()
        Me.tb_tc = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.exponentialgraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl_Acquisition = New System.Windows.Forms.TabControl()
        Me.TabPage_Calibrator = New System.Windows.Forms.TabPage()
        Me.TabPage_Patient = New System.Windows.Forms.TabPage()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.exponentialgraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_Acquisition.SuspendLayout()
        Me.TabPage_Calibrator.SuspendLayout()
        Me.TabPage_Patient.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sampel, Me.column_count1, Me.column_count2, Me.Average, Me.NetCPM, Me.PersenBound, Me.Concentration})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(343, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1202, 346)
        Me.DataGridView1.TabIndex = 1
        '
        'Sampel
        '
        Me.Sampel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Sampel.Frozen = True
        Me.Sampel.HeaderText = "Sampel"
        Me.Sampel.MinimumWidth = 6
        Me.Sampel.Name = "Sampel"
        Me.Sampel.ReadOnly = True
        Me.Sampel.Width = 99
        '
        'column_count1
        '
        Me.column_count1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column_count1.Frozen = True
        Me.column_count1.HeaderText = "Count1"
        Me.column_count1.MinimumWidth = 6
        Me.column_count1.Name = "column_count1"
        Me.column_count1.ReadOnly = True
        Me.column_count1.Width = 95
        '
        'column_count2
        '
        Me.column_count2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column_count2.Frozen = True
        Me.column_count2.HeaderText = "Count2"
        Me.column_count2.MinimumWidth = 6
        Me.column_count2.Name = "column_count2"
        Me.column_count2.ReadOnly = True
        Me.column_count2.Width = 95
        '
        'Average
        '
        Me.Average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Average.Frozen = True
        Me.Average.HeaderText = "Average"
        Me.Average.MinimumWidth = 6
        Me.Average.Name = "Average"
        Me.Average.ReadOnly = True
        Me.Average.Width = 106
        '
        'NetCPM
        '
        Me.NetCPM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NetCPM.Frozen = True
        Me.NetCPM.HeaderText = "Net CPM"
        Me.NetCPM.MinimumWidth = 6
        Me.NetCPM.Name = "NetCPM"
        Me.NetCPM.ReadOnly = True
        Me.NetCPM.Width = 110
        '
        'PersenBound
        '
        Me.PersenBound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PersenBound.Frozen = True
        Me.PersenBound.HeaderText = "% Bounding"
        Me.PersenBound.MinimumWidth = 6
        Me.PersenBound.Name = "PersenBound"
        Me.PersenBound.ReadOnly = True
        Me.PersenBound.Width = 137
        '
        'Concentration
        '
        Me.Concentration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Concentration.Frozen = True
        Me.Concentration.HeaderText = "Concentration"
        Me.Concentration.MinimumWidth = 6
        Me.Concentration.Name = "Concentration"
        Me.Concentration.ReadOnly = True
        Me.Concentration.Width = 152
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Timer_background
        '
        Me.Timer_background.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 378)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1556, 29)
        Me.ProgressBar1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.btn_stop)
        Me.GroupBox1.Controls.Add(Me.IconButton1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 723)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1556, 161)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel Kontrol"
        '
        'btn_stop
        '
        Me.btn_stop.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_stop.IconChar = FontAwesome.Sharp.IconChar.[Stop]
        Me.btn_stop.IconColor = System.Drawing.Color.Black
        Me.btn_stop.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stop.IconSize = 48
        Me.btn_stop.Location = New System.Drawing.Point(369, 56)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Rotation = 0R
        Me.btn_stop.Size = New System.Drawing.Size(131, 103)
        Me.btn_stop.TabIndex = 4
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.RoyalBlue
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 60
        Me.IconButton1.Location = New System.Drawing.Point(157, 56)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(135, 103)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_tc)
        Me.GroupBox2.Controls.Add(Me.tb_h)
        Me.GroupBox2.Controls.Add(Me.tb_a)
        Me.GroupBox2.Controls.Add(Me.tb_g)
        Me.GroupBox2.Controls.Add(Me.tb_b)
        Me.GroupBox2.Controls.Add(Me.tb_f)
        Me.GroupBox2.Controls.Add(Me.tb_c)
        Me.GroupBox2.Controls.Add(Me.tb_e)
        Me.GroupBox2.Controls.Add(Me.tb_d)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(234, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(109, 346)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'tb_d
        '
        Me.tb_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d.Location = New System.Drawing.Point(4, 137)
        Me.tb_d.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_d.Name = "tb_d"
        Me.tb_d.Size = New System.Drawing.Size(76, 35)
        Me.tb_d.TabIndex = 1
        Me.tb_d.Text = "50"
        '
        'tb_e
        '
        Me.tb_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_e.Location = New System.Drawing.Point(4, 170)
        Me.tb_e.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_e.Name = "tb_e"
        Me.tb_e.Size = New System.Drawing.Size(76, 35)
        Me.tb_e.TabIndex = 1
        Me.tb_e.Text = "42.5"
        '
        'tb_c
        '
        Me.tb_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_c.Location = New System.Drawing.Point(4, 105)
        Me.tb_c.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_c.Name = "tb_c"
        Me.tb_c.Size = New System.Drawing.Size(76, 35)
        Me.tb_c.TabIndex = 1
        Me.tb_c.Text = "62.5"
        '
        'tb_f
        '
        Me.tb_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f.Location = New System.Drawing.Point(4, 202)
        Me.tb_f.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_f.Name = "tb_f"
        Me.tb_f.Size = New System.Drawing.Size(76, 35)
        Me.tb_f.TabIndex = 1
        Me.tb_f.Text = "37.5"
        '
        'tb_b
        '
        Me.tb_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_b.Location = New System.Drawing.Point(4, 72)
        Me.tb_b.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_b.Name = "tb_b"
        Me.tb_b.Size = New System.Drawing.Size(76, 35)
        Me.tb_b.TabIndex = 1
        Me.tb_b.Text = "75"
        '
        'tb_g
        '
        Me.tb_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_g.Location = New System.Drawing.Point(4, 235)
        Me.tb_g.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_g.Name = "tb_g"
        Me.tb_g.Size = New System.Drawing.Size(76, 35)
        Me.tb_g.TabIndex = 1
        Me.tb_g.Text = "25"
        '
        'tb_a
        '
        Me.tb_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_a.Location = New System.Drawing.Point(4, 41)
        Me.tb_a.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_a.Name = "tb_a"
        Me.tb_a.Size = New System.Drawing.Size(76, 35)
        Me.tb_a.TabIndex = 1
        Me.tb_a.Text = "82.5"
        '
        'tb_h
        '
        Me.tb_h.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_h.Location = New System.Drawing.Point(4, 267)
        Me.tb_h.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_h.Name = "tb_h"
        Me.tb_h.Size = New System.Drawing.Size(76, 35)
        Me.tb_h.TabIndex = 1
        Me.tb_h.Text = "12.5"
        '
        'tb_tc
        '
        Me.tb_tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tc.Location = New System.Drawing.Point(4, 11)
        Me.tb_tc.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_tc.Name = "tb_tc"
        Me.tb_tc.Size = New System.Drawing.Size(76, 35)
        Me.tb_tc.TabIndex = 1
        Me.tb_tc.Text = "100"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Total Counting", "A", "B", "C", "D", "E", "F", "G", "H"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(231, 346)
        Me.CheckedListBox1.TabIndex = 0
        '
        'exponentialgraph
        '
        ChartArea4.Name = "ChartArea1"
        Me.exponentialgraph.ChartAreas.Add(ChartArea4)
        Me.exponentialgraph.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Me.exponentialgraph.Legends.Add(Legend4)
        Me.exponentialgraph.Location = New System.Drawing.Point(0, 378)
        Me.exponentialgraph.Margin = New System.Windows.Forms.Padding(2)
        Me.exponentialgraph.Name = "exponentialgraph"
        Me.exponentialgraph.Size = New System.Drawing.Size(1556, 345)
        Me.exponentialgraph.TabIndex = 3
        Me.exponentialgraph.Text = "exponentialgraph"
        '
        'TabControl_Acquisition
        '
        Me.TabControl_Acquisition.Controls.Add(Me.TabPage_Calibrator)
        Me.TabControl_Acquisition.Controls.Add(Me.TabPage_Patient)
        Me.TabControl_Acquisition.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl_Acquisition.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Acquisition.Name = "TabControl_Acquisition"
        Me.TabControl_Acquisition.SelectedIndex = 0
        Me.TabControl_Acquisition.Size = New System.Drawing.Size(1556, 378)
        Me.TabControl_Acquisition.TabIndex = 6
        '
        'TabPage_Calibrator
        '
        Me.TabPage_Calibrator.Controls.Add(Me.DataGridView1)
        Me.TabPage_Calibrator.Controls.Add(Me.GroupBox2)
        Me.TabPage_Calibrator.Controls.Add(Me.CheckedListBox1)
        Me.TabPage_Calibrator.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Calibrator.Name = "TabPage_Calibrator"
        Me.TabPage_Calibrator.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Calibrator.Size = New System.Drawing.Size(1548, 352)
        Me.TabPage_Calibrator.TabIndex = 0
        Me.TabPage_Calibrator.Text = "Calibrator"
        Me.TabPage_Calibrator.UseVisualStyleBackColor = True
        '
        'TabPage_Patient
        '
        Me.TabPage_Patient.Controls.Add(Me.GroupBox3)
        Me.TabPage_Patient.Controls.Add(Me.DataGridView2)
        Me.TabPage_Patient.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Patient.Name = "TabPage_Patient"
        Me.TabPage_Patient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Patient.Size = New System.Drawing.Size(1548, 352)
        Me.TabPage_Patient.TabIndex = 1
        Me.TabPage_Patient.Text = "Patient"
        Me.TabPage_Patient.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_save.IconColor = System.Drawing.Color.Black
        Me.btn_save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_save.IconSize = 48
        Me.btn_save.Location = New System.Drawing.Point(567, 56)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Rotation = 0R
        Me.btn_save.Size = New System.Drawing.Size(131, 103)
        Me.btn_save.TabIndex = 5
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(34, 87)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(770, 242)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1542, 88)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number Of Sample"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(237, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 32)
        Me.TextBox1.TabIndex = 1
        '
        'FormAcquisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1556, 884)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.exponentialgraph)
        Me.Controls.Add(Me.TabControl_Acquisition)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAcquisition"
        Me.Text = "Acquisition"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.exponentialgraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_Acquisition.ResumeLayout(False)
        Me.TabPage_Calibrator.ResumeLayout(False)
        Me.TabPage_Patient.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer As Timer
    Friend WithEvents Timer_background As Timer
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Sampel As DataGridViewTextBoxColumn
    Friend WithEvents column_count1 As DataGridViewTextBoxColumn
    Friend WithEvents column_count2 As DataGridViewTextBoxColumn
    Friend WithEvents Average As DataGridViewTextBoxColumn
    Friend WithEvents NetCPM As DataGridViewTextBoxColumn
    Friend WithEvents PersenBound As DataGridViewTextBoxColumn
    Friend WithEvents Concentration As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stop As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_tc As TextBox
    Friend WithEvents tb_h As TextBox
    Friend WithEvents tb_a As TextBox
    Friend WithEvents tb_g As TextBox
    Friend WithEvents tb_b As TextBox
    Friend WithEvents tb_f As TextBox
    Friend WithEvents tb_c As TextBox
    Friend WithEvents tb_e As TextBox
    Friend WithEvents tb_d As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents exponentialgraph As DataVisualization.Charting.Chart
    Friend WithEvents TabControl_Acquisition As TabControl
    Friend WithEvents TabPage_Calibrator As TabPage
    Friend WithEvents TabPage_Patient As TabPage
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
