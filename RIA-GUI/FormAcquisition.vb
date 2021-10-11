Public Class FormAcquisition

    Dim data1(60) As Integer
    Dim data2(60) As Integer
    Dim data3(60) As Integer
    Dim timerstart As Integer = 0
    Dim count1 As Integer
    Dim count2 As Integer
    Dim count3 As Integer



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.exponentialgraph.Titles.Add("RIA - IRMA")
        Me.exponentialgraph.ChartAreas.Clear()
        Me.exponentialgraph.ChartAreas.Add("Default")

        With Me.exponentialgraph.ChartAreas("Default")
            .AxisX.Title = "% Bounding"
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Concentration"
        End With
        Me.tb_tc.Enabled = False
        Me.tb_a.Enabled = False
        Me.tb_b.Enabled = False
        Me.tb_c.Enabled = False
        Me.tb_d.Enabled = False
        Me.tb_e.Enabled = False
        Me.tb_f.Enabled = False
        Me.tb_g.Enabled = False
        Me.tb_h.Enabled = False
    End Sub


    Private Sub Timer_background_Tick(sender As Object, e As EventArgs) Handles Timer_background.Tick

        If timerstart = time_count Then
            Timer_background.Stop()
            timerstart = 0
            Dim average_background As Integer
            average_background = (count1 + count2 + count3) / 3
            DataGridView1.Rows.Insert(0, "Background", average_background)

        Else
            For i As Integer = 1 To time_count
                data1(i) = Convert.ToInt32(sp(0))
                count1 = Convert.ToInt32(data1.Average())
            Next
            For j As Integer = 1 To time_count
                data2(j) = Convert.ToInt32(sp(1))
                count2 = Convert.ToInt32(data2.Average())
            Next
            For k As Integer = 1 To time_count
                data3(k) = Convert.ToInt32(sp(2))
                count3 = Convert.ToInt32(data3.Average())
            Next

            timerstart = timerstart + 1


        End If



        ProgressBar1.Value = (timerstart / time_count) * 100
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If timerstart = time_count Then
            Timer.Stop()
            timerstart = 0



            If CheckedListBox1.CheckedItems.Count = 3 Then
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(0), count1)
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(1), count2)
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(2), count3)

            ElseIf CheckedListBox1.CheckedItems.Count = 2 Then
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(0), count1)
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(1), count2)

            ElseIf CheckedListBox1.CheckedItems.Count = 1 Then
                DataGridView1.Rows.Add(CheckedListBox1.CheckedItems(0), count1)
            ElseIf CheckedListBox1.CheckedItems.Count = 0 Then
                MessageBox.Show("MENCACAH SAMPEL")
            End If


        Else
            For i As Integer = 1 To time_count
                data1(i) = Convert.ToInt32(sp(0))
                count1 = Convert.ToInt32(data1.Average())
            Next
            For j As Integer = 1 To time_count
                data2(j) = Convert.ToInt32(sp(1))
                count2 = Convert.ToInt32(data2.Average())
            Next
            For k As Integer = 1 To time_count
                data3(k) = Convert.ToInt32(sp(2))
                count3 = Convert.ToInt32(data3.Average())
            Next
            timerstart = timerstart + 1
        End If
        '/////////////////////////////////////////////////////////////////////


        ProgressBar1.Value = (timerstart / time_count) * 100
    End Sub

    Private Sub btn_background_Click(sender As Object, e As EventArgs)
        If Form_Main.SerialPort.IsOpen = True Then
            Timer_background.Start()
        Else
            MessageBox.Show("Mohon Cek Koneksi")
        End If

    End Sub

    Private Sub clear()
        DataGridView1.Rows.Clear()
        exponentialgraph.Series.Clear()
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_startcount_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub hitung()
        If DataGridView1.Rows(0).Cells(0).Value = "Background" Then
            Dim tb As Double() = {0, tb_tc.Text, tb_a.Text, tb_b.Text, tb_c.Text, tb_d.Text, tb_e.Text, tb_f.Text, tb_g.Text, tb_h.Text}


            For i As Integer = 0 To DataGridView1.RowCount - 2
                DataGridView1.Rows(i).Cells(6).Value = Convert.ToInt32(tb(i))
            Next

            For i As Integer = 1 To DataGridView1.RowCount - 2

                DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(1).Value - DataGridView1.Rows(0).Cells(1).Value
            Next

            For i As Integer = 1 To DataGridView1.RowCount - 2
                Dim persen_bounding As Double
                persen_bounding = ((DataGridView1.Rows(1).Cells(1).Value - DataGridView1.Rows(0).Cells(1).Value) / (DataGridView1.Rows(i).Cells(1).Value - DataGridView1.Rows(0).Cells(1).Value)) * 100
                DataGridView1.Rows(i).Cells(5).Value = Math.Round(persen_bounding, 2)
            Next





            exponentialgraph.Series.Clear()
            exponentialgraph.Series.Add("plot1")
            exponentialgraph.Series("plot1").Color = Color.Red
            exponentialgraph.Series("plot1").ChartType = DataVisualization.Charting.SeriesChartType.Spline

            'Dim n As Integer = 5
            'Dim y As Single
            'For x As Integer = 1 To n Step 1
            '    y = 1 / (x * x)
            '    Chart1.Series("plot1").Points.AddXY(x, y)
            'Next
            Dim n As Integer = DataGridView1.RowCount - 2
            Dim sumbu_x As Integer
            Dim sumbu_y As Integer


            For x As Integer = 2 To n Step 1
                sumbu_x = Convert.ToInt32(DataGridView1.Rows(x).Cells(5).Value)
                sumbu_y = DataGridView1.Rows(x).Cells(6).Value
                exponentialgraph.Series("plot1").Points.AddXY(sumbu_x, sumbu_y)
            Next
        Else
            MessageBox.Show("Ambil Background terlebih dahulu")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Form_Main.SerialPort.IsOpen = True Then
            If CheckedListBox1.CheckedItems().Count <= 3 And CheckedListBox1.CheckedItems().Count > 0 Then
                Timer.Start()

            Else
                MessageBox.Show("Harus Minimal 3 item yang dicentang")
            End If
        Else
            MessageBox.Show("`Mohon Cek Koneksi")
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Me.tb_tc.Enabled = CheckedListBox1.GetItemChecked(0)
        Me.tb_a.Enabled = CheckedListBox1.GetItemChecked(1)
        Me.tb_b.Enabled = CheckedListBox1.GetItemChecked(2)
        Me.tb_c.Enabled = CheckedListBox1.GetItemChecked(3)
        Me.tb_d.Enabled = CheckedListBox1.GetItemChecked(4)
        Me.tb_e.Enabled = CheckedListBox1.GetItemChecked(5)
        Me.tb_f.Enabled = CheckedListBox1.GetItemChecked(6)
        Me.tb_g.Enabled = CheckedListBox1.GetItemChecked(7)
        Me.tb_h.Enabled = CheckedListBox1.GetItemChecked(8)
    End Sub
End Class