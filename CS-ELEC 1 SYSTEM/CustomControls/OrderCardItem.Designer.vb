<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderCardItem
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
        Me.item_name = New System.Windows.Forms.Label()
        Me.item_price = New System.Windows.Forms.Label()
        Me.item_quantity = New System.Windows.Forms.Label()
        Me.total_price = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'item_name
        '
        Me.item_name.AutoSize = True
        Me.item_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name.Location = New System.Drawing.Point(3, 20)
        Me.item_name.Name = "item_name"
        Me.item_name.Size = New System.Drawing.Size(115, 25)
        Me.item_name.TabIndex = 0
        Me.item_name.Text = "Item Name"
        '
        'item_price
        '
        Me.item_price.AutoSize = True
        Me.item_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_price.Location = New System.Drawing.Point(135, 25)
        Me.item_price.Name = "item_price"
        Me.item_price.Size = New System.Drawing.Size(49, 20)
        Me.item_price.TabIndex = 1
        Me.item_price.Text = "$5.00"
        '
        'item_quantity
        '
        Me.item_quantity.AutoSize = True
        Me.item_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_quantity.Location = New System.Drawing.Point(44, 70)
        Me.item_quantity.Name = "item_quantity"
        Me.item_quantity.Size = New System.Drawing.Size(23, 25)
        Me.item_quantity.TabIndex = 3
        Me.item_quantity.Text = "0"
        '
        'total_price
        '
        Me.total_price.AutoSize = True
        Me.total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_price.Location = New System.Drawing.Point(218, 72)
        Me.total_price.Name = "total_price"
        Me.total_price.Size = New System.Drawing.Size(82, 24)
        Me.total_price.TabIndex = 0
        Me.total_price.Text = "$320.00"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackgroundImage = Global.CS_ELEC_1_SYSTEM.My.Resources.Resources.icons8_trash_48
        Me.Guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(267, 15)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(50, 30)
        Me.Guna2Button2.TabIndex = 2
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackgroundImage = Global.CS_ELEC_1_SYSTEM.My.Resources.Resources.icons8_edit_48
        Me.Guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(211, 15)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(50, 30)
        Me.Guna2Button1.TabIndex = 2
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackgroundImage = Global.CS_ELEC_1_SYSTEM.My.Resources.Resources.icons8_minus_30_new_default
        Me.Guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(8, 67)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2CircleButton1.TabIndex = 5
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.BackgroundImage = Global.CS_ELEC_1_SYSTEM.My.Resources.Resources.icons8_add_30_new_default
        Me.Guna2CircleButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(73, 67)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(30, 30)
        Me.Guna2CircleButton2.TabIndex = 5
        '
        'OrderCardItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.item_quantity)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.item_price)
        Me.Controls.Add(Me.total_price)
        Me.Controls.Add(Me.item_name)
        Me.Name = "OrderCardItem"
        Me.Size = New System.Drawing.Size(320, 100)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents item_name As Label
    Friend WithEvents item_price As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents item_quantity As Label
    Friend WithEvents total_price As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
End Class
