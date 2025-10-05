Public Class OrderCardItem
    Public Property ItemName As String
        Get
            Return item_name.Text
        End Get
        Set(value As String)
            item_name.Text = value
        End Set
    End Property
    Public Property ItemPrice As String
        Get
            Return item_price.Text
        End Get
        Set(value As String)
            item_price.Text = value
        End Set
    End Property
    Public Property TotalPrice As String
        Get
            Return total_price.Text
        End Get
        Set(value As String)
            total_price.Text = value
        End Set
    End Property
    Public Property Quantity As String
        Get
            Return item_quantity.Text
        End Get
        Set(value As String)
            item_quantity.Text = value
        End Set
    End Property
    Public Event DeleteMe(sender As OrderCardItem)

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        RaiseEvent DeleteMe(Me)
    End Sub

    Private Sub OrderCardItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
