Public Class MenuItemCard
    Public Property ItemID As Integer
    Public Property ItemName As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return Label2.Text
        End Get
        Set(value As Decimal)
            Label2.Text = value.ToString()
        End Set
    End Property

    Public Property ItemImage As Image
        Get
            Return Guna2PictureBox1.Image
        End Get
        Set(value As Image)
            Guna2PictureBox1.Image = value
        End Set
    End Property
    Public Property SubCategory As String
        Get
            Return Label4.Text
        End Get
        Set(value As String)
            Label4.Text = value
        End Set
    End Property


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RaiseEvent AddMe(Me)
    End Sub
    Public Event AddMe(sender As MenuItemCard)


End Class
