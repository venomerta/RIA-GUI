Public Class UcAcquisition
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.exponentialgraph.Titles.Add("RIA - IRMA")
        'Me.exponentialgraph.ChartAreas.Clear()
        'Me.exponentialgraph.ChartAreas.Add("Default")

        'With Me.exponentialgraph.ChartAreas("Default")
        '    .AxisX.Title = "% Bounding"
        '    .AxisX.MajorGrid.LineColor = Color.SkyBlue
        '    .AxisY.MajorGrid.LineColor = Color.SkyBlue
        '    .AxisY.Title = "Concentration"
        'End With
        'Me.tb_tc.Enabled = False
        'Me.tb_a.Enabled = False
        'Me.tb_b.Enabled = False
        'Me.tb_c.Enabled = False
        'Me.tb_d.Enabled = False
        'Me.tb_e.Enabled = False
        'Me.tb_f.Enabled = False
        'Me.tb_g.Enabled = False
        'Me.tb_h.Enabled = False
    End Sub
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

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
