<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.TimerSliding = New System.Windows.Forms.Timer(Me.components)
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.PictureBoxConnection = New System.Windows.Forms.PictureBox()
        Me.lbl_statusconnect = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.Lbl_Port = New System.Windows.Forms.Label()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.Btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Btn_AboutUs = New FontAwesome.Sharp.IconButton()
        Me.Btn_Tools = New FontAwesome.Sharp.IconButton()
        Me.Btn_Analyze = New FontAwesome.Sharp.IconButton()
        Me.Btn_Acquisition = New FontAwesome.Sharp.IconButton()
        Me.Btn_Calibration = New FontAwesome.Sharp.IconButton()
        Me.Btn_User = New FontAwesome.Sharp.IconButton()
        Me.PanelSlidingMenu = New System.Windows.Forms.Panel()
        Me.BtnMenuBars = New FontAwesome.Sharp.IconButton()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.btn_scanport = New FontAwesome.Sharp.IconButton()
        Me.BtnDisconnect = New FontAwesome.Sharp.IconButton()
        Me.BtnConnect = New FontAwesome.Sharp.IconButton()
        Me.Lbl_Connectivity = New System.Windows.Forms.Label()
        Me.Lbl_BaudRate = New System.Windows.Forms.Label()
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.CmbPortName = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.PanelConnection.SuspendLayout()
        CType(Me.PictureBoxConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelSlidingMenu.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerSliding
        '
        Me.TimerSliding.Interval = 25
        '
        'PanelConnection
        '
        Me.PanelConnection.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelConnection.Controls.Add(Me.PictureBoxConnection)
        Me.PanelConnection.Controls.Add(Me.lbl_statusconnect)
        Me.PanelConnection.Controls.Add(Me.lblFormTitle)
        Me.PanelConnection.Controls.Add(Me.IconCurrentForm)
        Me.PanelConnection.Controls.Add(Me.imgHome)
        Me.PanelConnection.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelConnection.Location = New System.Drawing.Point(250, 0)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(1030, 50)
        Me.PanelConnection.TabIndex = 0
        '
        'PictureBoxConnection
        '
        Me.PictureBoxConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxConnection.Image = Global.RIA_GUI.My.Resources.Resources.red_green
        Me.PictureBoxConnection.Location = New System.Drawing.Point(998, 12)
        Me.PictureBoxConnection.Name = "PictureBoxConnection"
        Me.PictureBoxConnection.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxConnection.TabIndex = 12
        Me.PictureBoxConnection.TabStop = False
        Me.PictureBoxConnection.Visible = False
        '
        'lbl_statusconnect
        '
        Me.lbl_statusconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_statusconnect.AutoSize = True
        Me.lbl_statusconnect.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_statusconnect.Location = New System.Drawing.Point(792, 12)
        Me.lbl_statusconnect.Name = "lbl_statusconnect"
        Me.lbl_statusconnect.Size = New System.Drawing.Size(146, 17)
        Me.lbl_statusconnect.TabIndex = 3
        Me.lbl_statusconnect.Text = "Status : Disconnected"
        Me.lbl_statusconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.AliceBlue
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFormTitle.Location = New System.Drawing.Point(147, 12)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(64, 25)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Lavender
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.DarkBlue
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.DarkBlue
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 37
        Me.IconCurrentForm.Location = New System.Drawing.Point(105, 8)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(37, 41)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'imgHome
        '
        Me.imgHome.BackColor = System.Drawing.Color.AliceBlue
        Me.imgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgHome.Image = Global.RIA_GUI.My.Resources.Resources.logo_batan_baru
        Me.imgHome.Location = New System.Drawing.Point(6, 0)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(74, 47)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'Lbl_Port
        '
        Me.Lbl_Port.AutoSize = True
        Me.Lbl_Port.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Port.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbl_Port.Location = New System.Drawing.Point(47, 88)
        Me.Lbl_Port.Name = "Lbl_Port"
        Me.Lbl_Port.Size = New System.Drawing.Size(173, 38)
        Me.Lbl_Port.TabIndex = 3
        Me.Lbl_Port.Text = "Port Name"
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.Btn_Exit)
        Me.PanelSideMenu.Controls.Add(Me.Btn_AboutUs)
        Me.PanelSideMenu.Controls.Add(Me.Btn_Tools)
        Me.PanelSideMenu.Controls.Add(Me.Btn_Analyze)
        Me.PanelSideMenu.Controls.Add(Me.Btn_Acquisition)
        Me.PanelSideMenu.Controls.Add(Me.Btn_Calibration)
        Me.PanelSideMenu.Controls.Add(Me.Btn_User)
        Me.PanelSideMenu.Controls.Add(Me.PanelSlidingMenu)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 960)
        Me.PanelSideMenu.TabIndex = 1
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Snow
        Me.Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Btn_Exit.IconColor = System.Drawing.Color.White
        Me.Btn_Exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Exit.IconSize = 48
        Me.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exit.Location = New System.Drawing.Point(0, 910)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Exit.Rotation = 0R
        Me.Btn_Exit.Size = New System.Drawing.Size(250, 50)
        Me.Btn_Exit.TabIndex = 6
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Btn_AboutUs
        '
        Me.Btn_AboutUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_AboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AboutUs.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AboutUs.FlatAppearance.BorderSize = 0
        Me.Btn_AboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AboutUs.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_AboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AboutUs.ForeColor = System.Drawing.Color.Snow
        Me.Btn_AboutUs.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.Btn_AboutUs.IconColor = System.Drawing.Color.White
        Me.Btn_AboutUs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_AboutUs.IconSize = 48
        Me.Btn_AboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_AboutUs.Location = New System.Drawing.Point(0, 650)
        Me.Btn_AboutUs.Name = "Btn_AboutUs"
        Me.Btn_AboutUs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_AboutUs.Rotation = 0R
        Me.Btn_AboutUs.Size = New System.Drawing.Size(250, 120)
        Me.Btn_AboutUs.TabIndex = 5
        Me.Btn_AboutUs.Text = "About Us"
        Me.Btn_AboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AboutUs.UseVisualStyleBackColor = False
        '
        'Btn_Tools
        '
        Me.Btn_Tools.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Tools.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Tools.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Tools.FlatAppearance.BorderSize = 0
        Me.Btn_Tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Tools.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Tools.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Tools.ForeColor = System.Drawing.Color.Snow
        Me.Btn_Tools.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.Btn_Tools.IconColor = System.Drawing.Color.White
        Me.Btn_Tools.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Tools.IconSize = 48
        Me.Btn_Tools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Tools.Location = New System.Drawing.Point(0, 530)
        Me.Btn_Tools.Name = "Btn_Tools"
        Me.Btn_Tools.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Tools.Rotation = 0R
        Me.Btn_Tools.Size = New System.Drawing.Size(250, 120)
        Me.Btn_Tools.TabIndex = 4
        Me.Btn_Tools.Text = "Configuration"
        Me.Btn_Tools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Tools.UseVisualStyleBackColor = False
        '
        'Btn_Analyze
        '
        Me.Btn_Analyze.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Analyze.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Analyze.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Analyze.FlatAppearance.BorderSize = 0
        Me.Btn_Analyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Analyze.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Analyze.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Analyze.ForeColor = System.Drawing.Color.Snow
        Me.Btn_Analyze.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.Btn_Analyze.IconColor = System.Drawing.Color.White
        Me.Btn_Analyze.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Analyze.IconSize = 48
        Me.Btn_Analyze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Analyze.Location = New System.Drawing.Point(0, 410)
        Me.Btn_Analyze.Name = "Btn_Analyze"
        Me.Btn_Analyze.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Analyze.Rotation = 0R
        Me.Btn_Analyze.Size = New System.Drawing.Size(250, 120)
        Me.Btn_Analyze.TabIndex = 3
        Me.Btn_Analyze.Text = "Anaylizing"
        Me.Btn_Analyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Analyze.UseVisualStyleBackColor = False
        '
        'Btn_Acquisition
        '
        Me.Btn_Acquisition.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Acquisition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Acquisition.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Acquisition.FlatAppearance.BorderSize = 0
        Me.Btn_Acquisition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Acquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Acquisition.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Acquisition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Acquisition.ForeColor = System.Drawing.Color.Snow
        Me.Btn_Acquisition.IconChar = FontAwesome.Sharp.IconChar.Flask
        Me.Btn_Acquisition.IconColor = System.Drawing.Color.White
        Me.Btn_Acquisition.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Acquisition.IconSize = 48
        Me.Btn_Acquisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Acquisition.Location = New System.Drawing.Point(0, 290)
        Me.Btn_Acquisition.Name = "Btn_Acquisition"
        Me.Btn_Acquisition.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Acquisition.Rotation = 0R
        Me.Btn_Acquisition.Size = New System.Drawing.Size(250, 120)
        Me.Btn_Acquisition.TabIndex = 2
        Me.Btn_Acquisition.Text = "Acquisition"
        Me.Btn_Acquisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Acquisition.UseVisualStyleBackColor = False
        '
        'Btn_Calibration
        '
        Me.Btn_Calibration.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Calibration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Calibration.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Calibration.FlatAppearance.BorderSize = 0
        Me.Btn_Calibration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Calibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Calibration.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Calibration.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Calibration.ForeColor = System.Drawing.Color.Snow
        Me.Btn_Calibration.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.Btn_Calibration.IconColor = System.Drawing.Color.White
        Me.Btn_Calibration.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Calibration.IconSize = 48
        Me.Btn_Calibration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Calibration.Location = New System.Drawing.Point(0, 170)
        Me.Btn_Calibration.Name = "Btn_Calibration"
        Me.Btn_Calibration.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Calibration.Rotation = 0R
        Me.Btn_Calibration.Size = New System.Drawing.Size(250, 120)
        Me.Btn_Calibration.TabIndex = 1
        Me.Btn_Calibration.Text = "Calibration"
        Me.Btn_Calibration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Calibration.UseVisualStyleBackColor = False
        '
        'Btn_User
        '
        Me.Btn_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_User.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_User.FlatAppearance.BorderSize = 0
        Me.Btn_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_User.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_User.ForeColor = System.Drawing.Color.Snow
        Me.Btn_User.IconChar = FontAwesome.Sharp.IconChar.User
        Me.Btn_User.IconColor = System.Drawing.Color.White
        Me.Btn_User.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_User.IconSize = 48
        Me.Btn_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_User.Location = New System.Drawing.Point(0, 50)
        Me.Btn_User.Name = "Btn_User"
        Me.Btn_User.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_User.Rotation = 0R
        Me.Btn_User.Size = New System.Drawing.Size(250, 120)
        Me.Btn_User.TabIndex = 0
        Me.Btn_User.Text = "Operator"
        Me.Btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_User.UseVisualStyleBackColor = False
        '
        'PanelSlidingMenu
        '
        Me.PanelSlidingMenu.Controls.Add(Me.BtnMenuBars)
        Me.PanelSlidingMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSlidingMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSlidingMenu.Name = "PanelSlidingMenu"
        Me.PanelSlidingMenu.Size = New System.Drawing.Size(250, 50)
        Me.PanelSlidingMenu.TabIndex = 12
        '
        'BtnMenuBars
        '
        Me.BtnMenuBars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenuBars.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMenuBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenuBars.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnMenuBars.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnMenuBars.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.BtnMenuBars.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnMenuBars.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMenuBars.IconSize = 44
        Me.BtnMenuBars.Location = New System.Drawing.Point(175, 0)
        Me.BtnMenuBars.Name = "BtnMenuBars"
        Me.BtnMenuBars.Rotation = 0R
        Me.BtnMenuBars.Size = New System.Drawing.Size(75, 50)
        Me.BtnMenuBars.TabIndex = 0
        Me.BtnMenuBars.UseVisualStyleBackColor = True
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.Navy
        Me.Panel_Main.Controls.Add(Me.btn_scanport)
        Me.Panel_Main.Controls.Add(Me.BtnDisconnect)
        Me.Panel_Main.Controls.Add(Me.BtnConnect)
        Me.Panel_Main.Controls.Add(Me.Lbl_Connectivity)
        Me.Panel_Main.Controls.Add(Me.Lbl_BaudRate)
        Me.Panel_Main.Controls.Add(Me.CmbBaudRate)
        Me.Panel_Main.Controls.Add(Me.Lbl_Port)
        Me.Panel_Main.Controls.Add(Me.CmbPortName)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(250, 50)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(1030, 910)
        Me.Panel_Main.TabIndex = 2
        '
        'btn_scanport
        '
        Me.btn_scanport.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_scanport.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scanport.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_scanport.IconColor = System.Drawing.Color.Black
        Me.btn_scanport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_scanport.IconSize = 40
        Me.btn_scanport.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_scanport.Location = New System.Drawing.Point(621, 81)
        Me.btn_scanport.Name = "btn_scanport"
        Me.btn_scanport.Rotation = 0R
        Me.btn_scanport.Size = New System.Drawing.Size(249, 59)
        Me.btn_scanport.TabIndex = 11
        Me.btn_scanport.Text = "Scan"
        Me.btn_scanport.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_scanport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_scanport.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.BackColor = System.Drawing.Color.Crimson
        Me.BtnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisconnect.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconnect.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnDisconnect.IconChar = FontAwesome.Sharp.IconChar.Usb
        Me.BtnDisconnect.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnDisconnect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnDisconnect.IconSize = 58
        Me.BtnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDisconnect.Location = New System.Drawing.Point(308, 250)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Rotation = 0R
        Me.BtnDisconnect.Size = New System.Drawing.Size(277, 95)
        Me.BtnDisconnect.TabIndex = 10
        Me.BtnDisconnect.Text = "Disconnect"
        Me.BtnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDisconnect.UseVisualStyleBackColor = False
        '
        'BtnConnect
        '
        Me.BtnConnect.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConnect.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnect.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnConnect.IconChar = FontAwesome.Sharp.IconChar.Usb
        Me.BtnConnect.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnConnect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnConnect.IconSize = 58
        Me.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConnect.Location = New System.Drawing.Point(308, 250)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Rotation = 0R
        Me.BtnConnect.Size = New System.Drawing.Size(277, 95)
        Me.BtnConnect.TabIndex = 9
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConnect.UseVisualStyleBackColor = False
        '
        'Lbl_Connectivity
        '
        Me.Lbl_Connectivity.AutoSize = True
        Me.Lbl_Connectivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Connectivity.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbl_Connectivity.Location = New System.Drawing.Point(45, 3)
        Me.Lbl_Connectivity.Name = "Lbl_Connectivity"
        Me.Lbl_Connectivity.Size = New System.Drawing.Size(259, 51)
        Me.Lbl_Connectivity.TabIndex = 8
        Me.Lbl_Connectivity.Text = "Connectivity"
        '
        'Lbl_BaudRate
        '
        Me.Lbl_BaudRate.AutoSize = True
        Me.Lbl_BaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BaudRate.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbl_BaudRate.Location = New System.Drawing.Point(47, 150)
        Me.Lbl_BaudRate.Name = "Lbl_BaudRate"
        Me.Lbl_BaudRate.Size = New System.Drawing.Size(171, 38)
        Me.Lbl_BaudRate.TabIndex = 7
        Me.Lbl_BaudRate.Text = "Baud Rate"
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.CmbBaudRate.Location = New System.Drawing.Point(284, 154)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(301, 46)
        Me.CmbBaudRate.TabIndex = 5
        '
        'CmbPortName
        '
        Me.CmbPortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbPortName.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPortName.FormattingEnabled = True
        Me.CmbPortName.Location = New System.Drawing.Point(284, 81)
        Me.CmbPortName.Name = "CmbPortName"
        Me.CmbPortName.Size = New System.Drawing.Size(301, 46)
        Me.CmbPortName.TabIndex = 4
        '
        'SerialPort
        '
        '
        'TimerConnection
        '
        Me.TimerConnection.Interval = 500
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 960)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RIA-Software"
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        CType(Me.PictureBoxConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelSlidingMenu.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerSliding As Timer
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents Btn_User As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_AboutUs As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Tools As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Analyze As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Acquisition As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Calibration As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Lbl_Port As Label
    Friend WithEvents BtnDisconnect As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnConnect As FontAwesome.Sharp.IconButton
    Friend WithEvents Lbl_Connectivity As Label
    Friend WithEvents Lbl_BaudRate As Label
    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents CmbPortName As ComboBox
    Friend WithEvents lbl_statusconnect As Label
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents btn_scanport As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSlidingMenu As Panel
    Friend WithEvents BtnMenuBars As FontAwesome.Sharp.IconButton
    Friend WithEvents TimerConnection As Timer
    Friend WithEvents PictureBoxConnection As PictureBox
End Class
