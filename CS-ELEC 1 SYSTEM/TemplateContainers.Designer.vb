<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TemplateContainers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateContainers))
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2TileButton9 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
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
        Me.Guna2Transition1.Interval = 15
        Me.Guna2Transition1.MaxAnimationTime = 300
        Me.Guna2Transition1.TimeStep = 0.03!
        '
        'Guna2TileButton9
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2TileButton9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TileButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2TileButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2TileButton9.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TileButton9.ForeColor = System.Drawing.Color.Black
        Me.Guna2TileButton9.Image = CType(resources.GetObject("Guna2TileButton9.Image"), System.Drawing.Image)
        Me.Guna2TileButton9.ImageOffset = New System.Drawing.Point(0, 25)
        Me.Guna2TileButton9.ImageSize = New System.Drawing.Size(175, 200)
        Me.Guna2TileButton9.Location = New System.Drawing.Point(12, 12)
        Me.Guna2TileButton9.Name = "Guna2TileButton9"
        Me.Guna2TileButton9.Size = New System.Drawing.Size(200, 244)
        Me.Guna2TileButton9.TabIndex = 1
        Me.Guna2TileButton9.Text = "Frappucino Assasino Frapuccino WasWasino Pramunino"
        Me.Guna2TileButton9.TextOffset = New System.Drawing.Point(0, 5)
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'TemplateContainers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 592)
        Me.Controls.Add(Me.Guna2TileButton9)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "TemplateContainers"
        Me.Text = "TemplateContainers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TileButton9 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Timer1 As Timer
End Class
