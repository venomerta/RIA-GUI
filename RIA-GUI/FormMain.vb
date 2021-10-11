Imports FontAwesome.Sharp

Public Class Form_Main
    'Fields
    Private currentBtn As IconButton
    Private leftborderBtn As Panel
    Private currentChildForm As Form

    'çonstrutor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftborderBtn = New Panel()
        leftborderBtn.Size = New Size(7, 50)
        PanelSideMenu.Controls.Add(leftborderBtn)
        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        duplo = True



    End Sub




    'metodhs
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form )
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel_Main.Controls.Add(childForm)
        Panel_Main.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftborderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub
    'Events'
    'Reset'
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub


    'Menu buttons Cliks'
    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormOperator)
    End Sub

    Private Sub Btn_Calibration_Click(sender As Object, e As EventArgs) Handles Btn_Calibration.Click
        'ActivateButton(sender, RGBColors.color2)
        'OpenChildForm(New FormCalibration)
    End Sub

    Private Sub Btn_Acquisition_Click(sender As Object, e As EventArgs) Handles Btn_Acquisition.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FormAcquisition)

    End Sub

    Private Sub Btn_Analyze_Click(sender As Object, e As EventArgs) Handles Btn_Analyze.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormAnalyzing)
    End Sub

    Private Sub Btn_Tools_Click(sender As Object, e As EventArgs) Handles Btn_Tools.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FormConfiguration)
    End Sub

    Private Sub Btn_AboutUs_Click(sender As Object, e As EventArgs) Handles Btn_AboutUs.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New FormAboutUs)
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Dim response_exit As Integer

        response_exit = MessageBox.Show("Do you want to exit?", "Exit Aplication", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If response_exit = vbOK Then
            Application.Exit()
        End If
    End Sub

    'Code for Connectivity to USB

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If String.IsNullOrEmpty(CmbPortName.SelectedItem) Then
            BtnConnect.Enabled = False

        Else
            SerialPort.BaudRate = CmbBaudRate.SelectedItem
            SerialPort.PortName = CmbPortName.SelectedItem

            SerialPort.Open()
            TimerConnection.Start()
            PictureBoxConnection.Image = My.Resources.red_green


            BtnDisconnect.Enabled = True
            BtnDisconnect.BringToFront()
        End If
    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()

        SerialPort.Close()
        TimerConnection.Stop()
        PictureBoxConnection.Image = My.Resources.red_circle2
        PictureBoxConnection.Visible = True
        lbl_statusconnect.Text = "Status : Disconnected"

        BtnConnect.Enabled = True
        BtnConnect.BringToFront()
    End Sub

    Private Sub CmbPortName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPortName.SelectedIndexChanged

    End Sub

    Private Sub btn_scanport_Click(sender As Object, e As EventArgs) Handles btn_scanport.Click
        CmbPortName.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPortName.Items.AddRange(myPort)
        i = CmbPortName.Items.Count
        i = i - i
        Try
            CmbPortName.SelectedIndex = i

            CmbPortName.DroppedDown = True
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("Com Port Was Not Detected", "Warning!!!", MessageBoxButtons.OK)
            CmbPortName.Text = ""
            CmbPortName.Items.Clear()
            Call Form_Main_Load(Me, e)
        End Try
        If String.IsNullOrEmpty(CmbPortName.SelectedItem) Then
            BtnConnect.Enabled = False
        Else
            BtnConnect.Enabled = True
            BtnConnect.BringToFront()
        End If
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BtnConnect.Enabled = False
        BtnConnect.BringToFront()

        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()

        CmbBaudRate.SelectedItem = "9600"
    End Sub


    'sliding menu
    Dim slidingMenu As String = "close"

    Sub clearMenuList()
        Btn_User.Text = ""
        Btn_Calibration.Text = ""
        Btn_Acquisition.Text = ""
        Btn_Analyze.Text = ""
        Btn_Tools.Text = ""
        Btn_AboutUs.Text = ""
        Btn_Exit.Text = ""
    End Sub
    Sub setMenuList()
        Btn_User.Text = "Operator"
        Btn_Calibration.Text = "Calibration"
        Btn_Acquisition.Text = "Acquisition"
        Btn_Analyze.Text = "Analyzing"
        Btn_Tools.Text = "Configuration"
        Btn_AboutUs.Text = "About Us"
        Btn_Exit.Text = "Exit"
    End Sub

    Private Sub BtnMenuBars_Click(sender As Object, e As EventArgs) Handles BtnMenuBars.Click
        TimerSliding.Start()
    End Sub

    Private Sub TimerSliding_Tick(sender As Object, e As EventArgs) Handles TimerSliding.Tick
        If slidingMenu = "open" Then
            PanelSideMenu.Width += 25

            If PanelSideMenu.Width >= PubVar.PanelSlidingMenuSize Then
                setMenuList()
                TimerSliding.Stop()
                slidingMenu = "close"
            End If
        Else
            clearMenuList()
            PanelSideMenu.Width -= 25

            If PanelSideMenu.Width <= 75 Then
                TimerSliding.Stop()
                slidingMenu = "open"
            End If
        End If
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick
        If SerialPort.IsOpen = True Then
            lbl_statusconnect.Text = "Status : Connected"
            If PictureBoxConnection.Visible = True Then
                PictureBoxConnection.Visible = False
            ElseIf PictureBoxConnection.Visible = False Then
                PictureBoxConnection.Visible = True

            End If
        Else
            PictureBoxConnection.Visible = False
            lbl_statusconnect.Text = "Status : Disconnected"
        End If


    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim str As String
        str = SerialPort.ReadLine
        sp = str.Split(",")
        flag_terima = 1

    End Sub


End Class
