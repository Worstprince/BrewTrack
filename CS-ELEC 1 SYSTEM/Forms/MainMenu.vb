Public Class MainMenu
    Dim OrderedItemsList As New List(Of OrderedItem)

    Private Function ItemAlreadyExists(card As MenuItemCard) As Boolean
        If OrderedItemsList.Any(Function(o) o.ItemID = card.ItemID) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub AddToCart(card As MenuItemCard)
        Dim detailsform As New MenuItemDetails(card)





        detailsform.ShowDialog()

        If detailsform.DialogResult = DialogResult.OK Then
            Dim item As New OrderedItem With {
                .Name = card.ItemName,
                .Size = detailsform.selectedSize,
                .Price = card.Price,
                .SugarLevel = detailsform.selectedSugarLevel,
                .Quantity = detailsform.Quantity,
                .Notes = detailsform.ItemNotes
            }
            item.TotalPrice = item.Price * item.Quantity
            OrderedItemsList.Add(item)
            GenerateOrderedItemCard(item)

        End If

        'Dim item As New OrderCardItem()
        'item.ItemName = card.ItemName
        'item.ItemPrice = card.Price
        'item.TotalPrice = "$320.00"
        'item.Quantity = "5"



        'FlowLayoutPanel2.Controls.Add(item)
    End Sub

    Private Sub GenerateOrderedItemCard(item As OrderedItem)
        Dim ItemOrder As New OrderCardItem()
        ItemOrder.ItemName = item.Name
        ItemOrder.ItemPrice = "$" & item.Price.ToString()
        ItemOrder.TotalPrice = "$" & item.TotalPrice.ToString()
        ItemOrder.Quantity = item.Quantity.ToString()
        FlowLayoutPanel2.Controls.Add(ItemOrder)

    End Sub
    Private Sub GenerateItemCards()
        Dim ItemRepo As New ItemRepository()
        Dim ItemDetailsList As List(Of ItemDetails) = ItemRepo.GetItems()

        For Each item In ItemDetailsList
            Dim ItemCard As New MenuItemCard()
            ItemCard.ItemID = item.ItemID
            ItemCard.ItemName = item.Name
            ItemCard.Price = "$" & item.Price.ToString()
            ItemCard.SubCategory = item.SubCategory
            ItemCard.ItemImage = Image.FromFile(Application.StartupPath & item.ImagePath)
            ItemCard.Margin = New Padding(0, 15, 13, 15)
            AddHandler ItemCard.AddMe, AddressOf AddToCart
            FlowLayoutPanel1.Controls.Add(ItemCard)
        Next
    End Sub


    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenerateItemCards()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FlowLayoutPanel2.Controls.Clear()
    End Sub
End Class
