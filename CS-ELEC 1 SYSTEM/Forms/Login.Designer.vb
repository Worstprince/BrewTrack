<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LoginContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Roles = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginContainer
        '
        Me.LoginContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoginContainer.BorderColor = System.Drawing.Color.Transparent
        Me.LoginContainer.Controls.Add(Me.Roles)
        Me.LoginContainer.Controls.Add(Me.Showpass)
        Me.LoginContainer.Controls.Add(Me.LoginBtn)
        Me.LoginContainer.Controls.Add(Me.Password)
        Me.LoginContainer.Controls.Add(Me.Username)
        Me.LoginContainer.Location = New System.Drawing.Point(38, 89)
        Me.LoginContainer.Name = "LoginContainer"
        Me.LoginContainer.Size = New System.Drawing.Size(300, 300)
        Me.LoginContainer.TabIndex = 0
        '
        'Roles
        '
        Me.Roles.BackColor = System.Drawing.Color.Transparent
        Me.Roles.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Roles.BorderRadius = 8
        Me.Roles.BorderThickness = 2
        Me.Roles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Roles.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Roles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Roles.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Roles.ItemHeight = 30
        Me.Roles.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.Roles.Location = New System.Drawing.Point(28, 144)
        Me.Roles.Name = "Roles"
        Me.Roles.Size = New System.Drawing.Size(250, 36)
        Me.Roles.StartIndex = 0
        Me.Roles.TabIndex = 3
        '
        'Showpass
        '
        Me.Showpass.AutoSize = True
        Me.Showpass.Checked = True
        Me.Showpass.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.Showpass.CheckedState.BorderRadius = 0
        Me.Showpass.CheckedState.BorderThickness = 0
        Me.Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Showpass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Showpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Showpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Showpass.Location = New System.Drawing.Point(35, 116)
        Me.Showpass.Name = "Showpass"
        Me.Showpass.Size = New System.Drawing.Size(152, 22)
        Me.Showpass.TabIndex = 2
        Me.Showpass.Text = "Show Password"
        Me.Showpass.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.Showpass.UncheckedState.BorderRadius = 0
        Me.Showpass.UncheckedState.BorderThickness = 0
        Me.Showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'LoginBtn
        '
        Me.LoginBtn.BorderColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BorderRadius = 8
        Me.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(28, 186)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(250, 50)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "LOGIN"
        '
        'Password
        '
        Me.Password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Password.BorderRadius = 8
        Me.Password.BorderThickness = 2
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(31, 68)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Password.Name = "Password"
        Me.Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Password.PlaceholderText = "Password.."
        Me.Password.SelectedText = ""
        Me.Password.Size = New System.Drawing.Size(247, 40)
        Me.Password.TabIndex = 1
        '
        'Username
        '
        Me.Username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Username.BorderRadius = 8
        Me.Username.BorderThickness = 2
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(31, 18)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Username.Name = "Username"
        Me.Username.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Username.PlaceholderText = "Username.."
        Me.Username.SelectedText = ""
        Me.Username.Size = New System.Drawing.Size(247, 40)
        Me.Username.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me.LoginContainer
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BrewTrack"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 5
        Me.Guna2Elipse2.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(180, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "v1.0.0"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(339, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exit"
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 453)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.LoginContainer.ResumeLayout(False)
        Me.LoginContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Roles As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label3 As Label
End Class
