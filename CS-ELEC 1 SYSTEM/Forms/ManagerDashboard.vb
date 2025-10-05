Public Class ManagerDashboard


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If ItemSubButtonContainer.Visible = False Then
            ItemSubButtonContainer.Visible = True
        Else
            ItemSubButtonContainer.Visible = False
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If CashierSubButtonContainer.Visible = False Then
            CashierSubButtonContainer.Visible = True
        Else
            CashierSubButtonContainer.Visible = False

        End If
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim ItemDetails As New ManagerDashboardItems()
        LoadFormInPanel(ItemDetails, Guna2Panel5)
    End Sub
    Private Sub LoadFormInPanel(frm As Form, container As Panel)
        ' Clear existing controls in the panel
        container.Controls.Clear()

        ' Set the form to behave like a control
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Add to panel
        container.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim CashierDetails As New ManagerDashboardCashiers()
        LoadFormInPanel(CashierDetails, Guna2Panel5)
    End Sub
End Class