Public Class MenuItemDetails
    Public Property selectedSize As String
    Public Property selectedSugarLevel As String
    Public Property Quantity As Integer
    Public Property ItemNotes As String

    Public EditMode As Boolean
    Public Sub New(card As MenuItemCard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label1.Text = card.ItemName
    End Sub
    Private Function CheckOrderCompletion() As Boolean

        If Not String.IsNullOrEmpty(selectedSize) AndAlso Not String.IsNullOrEmpty(selectedSugarLevel) _
            AndAlso Quantity > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub SetButtonStates()
        ' --- Size selection ---
        Select Case selectedSize
            Case "Small" : Small.Checked = True
            Case "Medium" : Medium.Checked = True
            Case "Large" : Large.Checked = True
            Case "Extra Large" : ExtraLarge.Checked = True
        End Select

        ' --- Sugar Level selection ---
        Select Case selectedSugarLevel
            Case "0%" : Zero.Checked = True
            Case "25%" : TwentyFive.Checked = True
            Case "50%" : Fifty.Checked = True
            Case "75%" : SeventyFive.Checked = True
            Case "100%" : OneHundred.Checked = True
        End Select
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub AddToCart_Click(sender As Object, e As EventArgs) Handles AddToCart.Click

        ItemNotes = Notes.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub MenuItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EditMode = True Then
            Call SetButtonStates()
            QuantityLabel.Text = Quantity
            Notes.Text = ItemNotes
            AddToCart.Enabled = CheckOrderCompletion()
        End If
        Label1.Left = (Guna2Panel1.Width - Label1.Width) \ 2
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Quantity += 1
        QuantityLabel.Text = Quantity
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Quantity > 0 Then
            Quantity -= 1
            QuantityLabel.Text = Quantity
            AddToCart.Enabled = CheckOrderCompletion()
        End If
    End Sub

    Private Sub Small_Click(sender As Object, e As EventArgs) Handles Small.Click
        Small.Checked = True
        Medium.Checked = False
        Large.Checked = False
        ExtraLarge.Checked = False
        selectedSize = "Small"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub Medium_Click(sender As Object, e As EventArgs) Handles Medium.Click
        Small.Checked = False
        Medium.Checked = True
        Large.Checked = False
        ExtraLarge.Checked = False
        selectedSize = "Medium"
    End Sub

    Private Sub Large_Click(sender As Object, e As EventArgs) Handles Large.Click
        Small.Checked = False
        Medium.Checked = False
        Large.Checked = True
        ExtraLarge.Checked = False
        selectedSize = "Large"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub
    Private Sub ExtraLarge_Click(sender As Object, e As EventArgs) Handles ExtraLarge.Click
        Small.Checked = False
        Medium.Checked = False
        Large.Checked = False
        ExtraLarge.Checked = True
        selectedSize = "Extra Large"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub Zero_Click(sender As Object, e As EventArgs) Handles Zero.Click
        Zero.Checked = True
        TwentyFive.Checked = False
        Fifty.Checked = False
        SeventyFive.Checked = False
        OneHundred.Checked = False
        selectedSugarLevel = "0%"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub TwentyFive_Click(sender As Object, e As EventArgs) Handles TwentyFive.Click
        Zero.Checked = False
        TwentyFive.Checked = True
        Fifty.Checked = False
        SeventyFive.Checked = False
        OneHundred.Checked = False
        selectedSugarLevel = "25%"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub Fifty_Click(sender As Object, e As EventArgs) Handles Fifty.Click
        Zero.Checked = False
        TwentyFive.Checked = False
        Fifty.Checked = True
        SeventyFive.Checked = False
        OneHundred.Checked = False
        selectedSugarLevel = "50%"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub SeventyFive_Click(sender As Object, e As EventArgs) Handles SeventyFive.Click
        Zero.Checked = False
        TwentyFive.Checked = False
        Fifty.Checked = False
        SeventyFive.Checked = True
        OneHundred.Checked = False
        selectedSugarLevel = "75%"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub

    Private Sub OneHundred_Click(sender As Object, e As EventArgs) Handles OneHundred.Click
        Zero.Checked = False
        TwentyFive.Checked = False
        Fifty.Checked = False
        SeventyFive.Checked = False
        OneHundred.Checked = True
        selectedSugarLevel = "100%"
        AddToCart.Enabled = CheckOrderCompletion()
    End Sub


End Class