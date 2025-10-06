Public Class MainMenu
    Dim OrderedItemsList As New List(Of OrderedItem)
    Public counter As Integer = 1
    Private Sub UpdateTotalOrderPrice()
        Dim FinalTotalPrice As Decimal = 0
        For Each ord In OrderedItemsList
            FinalTotalPrice += ord.TotalPrice
        Next
        TotalOrderPrice.Text = "$" + FinalTotalPrice.ToString()
    End Sub
    Private Sub RefreshOrderUI()
        FlowLayoutPanel2.Controls.Clear()
        For Each ord In OrderedItemsList
            Dim itemcard As New OrderCardItem()
            itemcard.OrderID = ord.OrderID
            itemcard.ItemName = ord.Name
            itemcard.SubCategory = ord.Subcategory
            itemcard.OrderSize = ord.Size
            itemcard.Sugar = ord.SugarLevel
            itemcard.TotalPrice = ord.TotalPrice
            itemcard.Quantity = ord.Quantity

            AddHandler itemcard.QuantityChanged, AddressOf Card_QuantityChanged
            AddHandler itemcard.EditClicked, AddressOf Card_EditClicked
            AddHandler itemcard.DeleteClicked, AddressOf Card_DeleteClicked

            UpdateTotalOrderPrice()
            FlowLayoutPanel2.Controls.Add(itemcard)
        Next
    End Sub
    Private Sub Card_QuantityChanged(ItemCard As OrderCardItem, newQty As Integer)
        'find matching ordereditem in list (use orderid Or unique key)
        Dim ord = OrderedItemsList.Find(Function(o) o.OrderID = ItemCard.OrderID)
        If ord IsNot Nothing Then
            ord.Quantity = newQty
            ord.TotalPrice = ord.Quantity * ord.Price
            MsgBox(ord.Name + " " + ord.TotalPrice.ToString() + " " + ord.Quantity.ToString())
            RefreshOrderUI()
            'updatetotalsui() ' update cart totals / subtotal / tax / etc.
        End If
    End Sub
    Private Sub Card_EditClicked(ItemCard As OrderCardItem)
        ' Open MenuItemDetails to edit options; pass order item. When done, update object then RefreshOrderUI().
        Dim ord = OrderedItemsList.Find(Function(o) o.OrderID = ItemCard.OrderID)
        If ord IsNot Nothing Then
            Dim card As New MenuItemCard()
            card.ItemName = ord.Name


            Dim detailsform As New MenuItemDetails(card)
            detailsform.EditMode = True
            detailsform.selectedSize = ord.Size
            detailsform.selectedSugarLevel = ord.SugarLevel
            detailsform.Quantity = ord.Quantity
            detailsform.ItemNotes = ord.Notes
            detailsform.ShowDialog()

            If detailsform.DialogResult = DialogResult.OK Then
                ord.Size = detailsform.selectedSize
                ord.SugarLevel = detailsform.selectedSugarLevel
                ord.Quantity = detailsform.Quantity
                ord.Notes = detailsform.ItemNotes
                MsgBox(ord.Size + " " + ord.SugarLevel + " " + ord.Quantity.ToString() + " " + ord.Notes)
                RefreshOrderUI()
            End If
        End If
    End Sub
    Private Sub Card_DeleteClicked(ItemCard As OrderCardItem)
        Dim ord = OrderedItemsList.Find(Function(o) o.OrderID = ItemCard.OrderID)
        If ord IsNot Nothing Then
            OrderedItemsList.Remove(ord)
            RefreshOrderUI()
        End If
    End Sub

    Public Sub AddToCart(card As MenuItemCard)
        Dim detailsform As New MenuItemDetails(card)
        detailsform.ShowDialog()

        If detailsform.DialogResult = DialogResult.OK Then
            Dim item As New OrderedItem With {
                .OrderID = counter,
                .Name = card.ItemName,
                .Category = card.Category,
                .Subcategory = card.SubCategory,
                .Size = detailsform.selectedSize,
                .Price = card.Price,
                .SugarLevel = detailsform.selectedSugarLevel,
                .Quantity = detailsform.Quantity,
                .Notes = detailsform.ItemNotes
            }
            item.TotalPrice = item.Price * item.Quantity
            counter += 1
            OrderedItemsList.Add(item)
            RefreshOrderUI()

        End If

    End Sub

    'Private Sub GenerateOrderedItemCard(item As OrderedItem)
    '    Dim ItemOrder As New OrderCardItem()
    '    ItemOrder.ItemName = item.Name
    '    ItemOrder.TotalPrice = "$" & item.TotalPrice.ToString()
    '    ItemOrder.Quantity = item.Quantity.ToString()
    '    FlowLayoutPanel2.Controls.Add(ItemOrder)

    'End Sub
    Private Sub GenerateItemCards()
        Dim ItemRepo As New ItemRepository()
        Dim ItemDetailsList As List(Of ItemDetails) = ItemRepo.GetItems()

        For Each item In ItemDetailsList
            Dim ItemCard As New MenuItemCard()
            ItemCard.ItemID = item.ItemID
            ItemCard.ItemName = item.Name
            ItemCard.Price = item.Price
            ItemCard.Category = item.Category
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
