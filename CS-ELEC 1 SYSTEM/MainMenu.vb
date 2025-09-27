Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call LoadMenuItems()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        TemplateContainers.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        FlowLayoutPanel1.Visible = True
    End Sub
End Class
