Module Functions
    Public counter As Integer = 1
    Public Sub LoadMenuItems()
        Dim template As Guna.UI2.WinForms.Guna2TileButton = TemplateContainers.Guna2TileButton9
        Dim Fpath As String = Application.StartupPath & "\Pictures\frappe.jpg"
        Dim TileBtn As New Guna.UI2.WinForms.Guna2TileButton With
            {
         .Name = "Btn" & CStr(counter),
        .Text = "Frappucino Assasino Frapuccino WasWasino Pramunino",
        .Size = New Size(TemplateContainers.Guna2TileButton9.Size),
        .Font = New Font("Segoe UI", 9, FontStyle.Bold),
        .TextAlign = HorizontalAlignment.Center,
        .TextOffset = New Point(0, 5),
        .FillColor = Color.Transparent,
        .ForeColor = Color.Black,
        .ImageSize = New Size(175, 200),
        .ImageOffset = New Point(0, 25),
        .ImageAlign = HorizontalAlignment.Center,
        .Margin = New Padding(3),
        .Padding = New Padding(0),
        .BorderRadius = 0,
        .BorderThickness = 0,
        .CustomBorderColor = Color.Transparent,
        .ShadowDecoration = template.ShadowDecoration
        }
        ' .Name = "Btn" & CStr(counter),
        '.Text = "Frappuccino Assasino",
        '.Size = template.Size,
        '.Font = template.Font,
        '.TextAlign = template.TextAlign,
        '.TextOffset = template.TextOffset,
        '.FillColor = template.FillColor,
        '.ForeColor = template.ForeColor,
        '.ImageSize = template.ImageSize,
        '.ImageOffset = template.ImageOffset,
        '.ImageAlign = template.ImageAlign,
        '.Margin = template.Margin,
        '.Padding = template.Padding,
        '.BorderRadius = template.BorderRadius,
        '.BorderThickness = template.BorderThickness,
        '.CustomBorderColor = template.CustomBorderColor,
        '.ShadowDecoration = template.ShadowDecoration



        '.ShadowDecoration { .BorderRadius = 6, .CustomizableEdges = New Boolean(True)}

        TileBtn.Image = Image.FromFile(Fpath)
        AddHandler TileBtn.Click, AddressOf TemplateContainers.Guna2TileButton9_Click
        MainMenu.FlowLayoutPanel1.Controls.Add(TileBtn)
        counter += 1

    End Sub
End Module
