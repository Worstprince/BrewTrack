Imports MySql.Data.MySqlClient
Module Functions
    Public PicItemNames() As String = {"coffee_ice_cream_frappe_frappuccino_feat", "starbucks_iced_matcha_latte_8"}
    Public ItemNames() As String = {"Frappuccino", "Matcha Latte"}
    Public ItemPrices() As String = {"₱60.00", "₱50.00"}
    Public counter As Integer = 1


    Public Class Database
        Private Shared ReadOnly connectionString As String = Configuration.ConfigurationManager.ConnectionStrings("CS_ELEC_1_SYSTEM.My.MySettings.brewtrackConnectionString").ConnectionString

        Public Shared Function GetConnection() As MySqlConnection
            Return New MySqlConnection(connectionString)
        End Function
    End Class
#Region "Reusable Classes"
    Public Class UserDetails
        Public Property UserID As Integer
        Public Property UserName As String
        Public Property UserPassword As String
        Public Property UserRoles As String

    End Class

    Public Class ItemDetails
        Public Property ItemID As Integer
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Category As String
        Public Property SubCategory As String
        Public Property ImagePath As String

    End Class

    Public Class OrderedItem
        Public Property OrderID As Integer
        Public Property Name As String
        Public Property Category As String
        Public Property Subcategory As String
        Public Property Size As String

        Public Property SugarLevel As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Property Notes As String
        Public Property TotalPrice As Decimal


    End Class
#End Region

#Region "repositories"
    Public Class UserRepository

        Public Function ValidateLogin(username As String, password As String) As UserDetails
            Using con As MySqlConnection = Database.GetConnection()
                con.Open()
                Dim query As String = "SELECT UserID, Username, UserPassword, Roles FROM usercredentials
                                       INNER JOIN userroles ON usercredentials.UserRolesID = userroles.UserRolesID
                                       WHERE Username = @user AND UserPassword = @pass"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim CurrentUser As New UserDetails()
                            CurrentUser.UserID = CInt(reader("UserID"))
                            CurrentUser.UserName = reader("Username").ToString()
                            CurrentUser.UserPassword = reader("UserPassword").ToString()
                            CurrentUser.UserRoles = reader("Roles").ToString()
                            Return CurrentUser
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        End Function
    End Class

    Public Class ItemRepository
        Public Function GetItems() As List(Of ItemDetails)
            Dim items As New List(Of ItemDetails)
            Using con As MySqlConnection = Database.GetConnection()
                con.Open()
                Dim query As String = "SELECT MenuItemsID, ItemName, ItemPrice, ImagePath, Available, SubCategoryName, CategoryName FROM menuitems
                                       INNER JOIN availability ON  menuitems.AvailabilityID = availability.AvailabilityID
                                       INNER JOIN subcategories ON menuitems.SubCategoryID = subcategories.SubCategoriesID
                                       INNER JOIN categories ON subcategories.CategoryID = categories.CategoryID
                                       WHERE Available = 'True'"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ItemDetails()
                            item.ItemID = CInt(reader("MenuItemsID"))
                            item.Name = reader("ItemName")
                            item.Price = reader("ItemPrice")
                            item.ImagePath = reader("ImagePath")
                            item.SubCategory = reader("SubCategoryName")
                            item.Category = reader("CategoryName")
                            items.Add(item)
                        End While

                    End Using

                End Using
            End Using
            Return items
        End Function
    End Class
#End Region
    'Public Sub LoadMenuItems()
    '    For i = 0 To UBound(ItemNames)
    '        Dim card As New MenuItemCard()
    '        card.ItemName = ItemNames(i)
    '        card.Price = ItemPrices(i)
    '        card.ItemImage = CType(My.Resources.ResourceManager.GetObject(PicItemNames(i)), Image)
    '        card.Margin = New Padding(0, 15, 13, 15)

    '        AddHandler card.AddMe, AddressOf AddToCart
    '        MainMenu.FlowLayoutPanel1.Controls.Add(card)
    '    Next



    'End Sub



    Public Sub RemoveOrderItem(card As OrderCardItem)
        MainMenu.FlowLayoutPanel1.Controls.Remove(card)
        card.Dispose()
    End Sub


End Module
