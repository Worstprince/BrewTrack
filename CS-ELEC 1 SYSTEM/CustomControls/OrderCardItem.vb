Public Class OrderCardItem

    Public Property OrderID As Integer


    Public Property ItemName As String
        Get
            Return item_name.Text
        End Get
        Set(value As String)
            item_name.Text = value
        End Set
    End Property

    Public Property SubCategory As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property
    Public Property OrderSize As String
        Get
            Return Label3.Text
        End Get
        Set(value As String)
            Label3.Text = value
        End Set
    End Property
    Public Property Sugar As String
        Get
            Return Label5.Text
        End Get
        Set(value As String)
            Label5.Text = value
        End Set
    End Property
    Public Property TotalPrice As Decimal
        Get
            Return total_price.Text
        End Get
        Set(value As Decimal)
            total_price.Text = "$" & value
        End Set
    End Property
    Private _quantity As Integer = 1
    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            If value < 1 Then value = 1
            _quantity = value
            item_quantity.Text = _quantity.ToString()
            UpdateMinusState()
        End Set
    End Property

    Public Event QuantityChanged(ItemCard As OrderCardItem, NewQuantity As Integer)
    Public Event EditClicked(ItemCard As OrderCardItem)
    Public Event DeleteClicked(ItemCard As OrderCardItem)


    Private Sub UpdateMinusState()
        Guna2CircleButton1.Enabled = (_quantity > 1)

    End Sub
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Quantity += 1
        RaiseEvent QuantityChanged(Me, Quantity)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Quantity > 1 Then
            Quantity -= 1
            RaiseEvent QuantityChanged(Me, Quantity)
        End If
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        RaiseEvent DeleteClicked(Me)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RaiseEvent EditClicked(Me)
    End Sub


End Class
