<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.SidebarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PrimaryContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LogoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SecondaryContainer = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.TotalOrderPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProfileInfoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProfilePictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SidebarPanel.SuspendLayout()
        Me.PrimaryContainer.SuspendLayout()
        Me.LogoPanel.SuspendLayout()
        Me.SecondaryContainer.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.ProfileInfoPanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(142, 149)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(822, 543)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'SidebarPanel
        '
        Me.SidebarPanel.BackColor = System.Drawing.Color.Transparent
        Me.SidebarPanel.Controls.Add(Me.Guna2Button2)
        Me.SidebarPanel.Controls.Add(Me.Label2)
        Me.SidebarPanel.Controls.Add(Me.Guna2Button1)
        Me.Guna2Transition1.SetDecoration(Me.SidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarPanel.ForeColor = System.Drawing.Color.Transparent
        Me.SidebarPanel.Location = New System.Drawing.Point(0, 103)
        Me.SidebarPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SidebarPanel.Name = "SidebarPanel"
        Me.SidebarPanel.Size = New System.Drawing.Size(134, 593)
        Me.SidebarPanel.TabIndex = 2
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 211)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Size = New System.Drawing.Size(100, 103)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "Menu"
        Me.Guna2Button2.Tile = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Menu"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 85)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Size = New System.Drawing.Size(100, 103)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Home"
        Me.Guna2Button1.Tile = True
        '
        'PrimaryContainer
        '
        Me.PrimaryContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.PrimaryContainer.Controls.Add(Me.Guna2TextBox1)
        Me.PrimaryContainer.Controls.Add(Me.Guna2ComboBox1)
        Me.PrimaryContainer.Controls.Add(Me.SidebarPanel)
        Me.PrimaryContainer.Controls.Add(Me.FlowLayoutPanel1)
        Me.PrimaryContainer.Controls.Add(Me.LogoPanel)
        Me.Guna2Transition1.SetDecoration(Me.PrimaryContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PrimaryContainer.Location = New System.Drawing.Point(12, 12)
        Me.PrimaryContainer.Name = "PrimaryContainer"
        Me.PrimaryContainer.Size = New System.Drawing.Size(968, 696)
        Me.PrimaryContainer.TabIndex = 3
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconLeft = CType(resources.GetObject("Guna2TextBox1.IconLeft"), System.Drawing.Image)
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(6, 0)
        Me.Guna2TextBox1.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(271, 109)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PlaceholderText = "Search.."
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(197, 36)
        Me.Guna2TextBox1.TabIndex = 4
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 17
        Me.Guna2ComboBox1.BorderThickness = 0
        Me.Guna2Transition1.SetDecoration(Me.Guna2ComboBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Latte", "Cold Brew"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(142, 110)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(123, 36)
        Me.Guna2ComboBox1.TabIndex = 3
        '
        'LogoPanel
        '
        Me.LogoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.LogoPanel.Controls.Add(Me.Label1)
        Me.Guna2Transition1.SetDecoration(Me.LogoPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(968, 103)
        Me.LogoPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BrewTrack"
        '
        'SecondaryContainer
        '
        Me.SecondaryContainer.BackColor = System.Drawing.Color.Transparent
        Me.SecondaryContainer.Controls.Add(Me.Guna2Panel2)
        Me.SecondaryContainer.Controls.Add(Me.ProfileInfoPanel)
        Me.SecondaryContainer.Controls.Add(Me.FlowLayoutPanel2)
        Me.Guna2Transition1.SetDecoration(Me.SecondaryContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SecondaryContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondaryContainer.Location = New System.Drawing.Point(988, 12)
        Me.SecondaryContainer.Name = "SecondaryContainer"
        Me.SecondaryContainer.Size = New System.Drawing.Size(331, 696)
        Me.SecondaryContainer.TabIndex = 4
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel2.Controls.Add(Me.TotalOrderPrice)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 601)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(331, 95)
        Me.Guna2Panel2.TabIndex = 2
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button4.Location = New System.Drawing.Point(8, 29)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(320, 62)
        Me.Guna2Button4.TabIndex = 2
        Me.Guna2Button4.Text = "Place Order"
        '
        'TotalOrderPrice
        '
        Me.TotalOrderPrice.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.TotalOrderPrice, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TotalOrderPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOrderPrice.Location = New System.Drawing.Point(70, 1)
        Me.TotalOrderPrice.Name = "TotalOrderPrice"
        Me.TotalOrderPrice.Size = New System.Drawing.Size(78, 25)
        Me.TotalOrderPrice.TabIndex = 1
        Me.TotalOrderPrice.Text = "$60.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total:"
        '
        'ProfileInfoPanel
        '
        Me.ProfileInfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ProfileInfoPanel.Controls.Add(Me.Guna2Panel1)
        Me.ProfileInfoPanel.Controls.Add(Me.Label4)
        Me.ProfileInfoPanel.Controls.Add(Me.Label3)
        Me.ProfileInfoPanel.Controls.Add(Me.ProfilePictureBox)
        Me.Guna2Transition1.SetDecoration(Me.ProfileInfoPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProfileInfoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProfileInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfileInfoPanel.Name = "ProfileInfoPanel"
        Me.ProfileInfoPanel.Size = New System.Drawing.Size(331, 146)
        Me.ProfileInfoPanel.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 103)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(331, 43)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(226, 5)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(95, 30)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "Clear All"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Current Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cashier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 50)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Prince Froilan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Domingo"
        '
        'ProfilePictureBox
        '
        Me.Guna2Transition1.SetDecoration(Me.ProfilePictureBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProfilePictureBox.FillColor = System.Drawing.Color.Transparent
        Me.ProfilePictureBox.Image = CType(resources.GetObject("ProfilePictureBox.Image"), System.Drawing.Image)
        Me.ProfilePictureBox.ImageRotate = 0!
        Me.ProfilePictureBox.Location = New System.Drawing.Point(3, 16)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(80, 80)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePictureBox.TabIndex = 0
        Me.ProfilePictureBox.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 149)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(350, 450)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1320, 720)
        Me.Controls.Add(Me.SecondaryContainer)
        Me.Controls.Add(Me.PrimaryContainer)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SidebarPanel.ResumeLayout(False)
        Me.SidebarPanel.PerformLayout()
        Me.PrimaryContainer.ResumeLayout(False)
        Me.LogoPanel.ResumeLayout(False)
        Me.LogoPanel.PerformLayout()
        Me.SecondaryContainer.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ProfileInfoPanel.ResumeLayout(False)
        Me.ProfileInfoPanel.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents SidebarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PrimaryContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SecondaryContainer As Panel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ProfileInfoPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProfilePictureBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TotalOrderPrice As Label
    Friend WithEvents Label6 As Label
End Class
