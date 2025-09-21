Imports System.Data.SqlClient

Public Class OrderManagement

    Dim connString As String =
        "Server=(localdb)\MSSQLLocalDB;Database=Sweet_DelightsDB;Trusted_Connection=True;"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Dim DashForm As New Dashboard()
        DashForm.Show()
    End Sub

    Private Sub OrderManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCustomer()
        getCake()
        getIcing()
        getToppings()
        setupOrderGrid()
    End Sub

    Private Sub getCustomer()
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT CustomerID, FirstName FROM Customer"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                CstmrComboBx.DisplayMember = "FirstName"
                CstmrComboBx.ValueMember = "CustomerID"
                CstmrComboBx.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading customers: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getCake()
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT CakeID, CakeType, Price FROM Cake"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cakeComboBx.DisplayMember = "CakeType"
                cakeComboBx.ValueMember = "CakeID"
                cakeComboBx.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading cakes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getIcing()
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT IcingID, IcingType, Price FROM Icing"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                icingComboBx.DisplayMember = "IcingType"
                icingComboBx.ValueMember = "IcingID"
                icingComboBx.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading icings: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getToppings()
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT ToppingID, ToppingType, Price FROM Topping"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                tppngsComboBx.DisplayMember = "ToppingType"
                tppngsComboBx.ValueMember = "ToppingID"
                tppngsComboBx.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading toppings: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub setupOrderGrid()
        orderGrid.Columns.Clear()
        orderGrid.Columns.Add("CakeID", "CakeID")
        orderGrid.Columns.Add("Cake", "Cake")
        orderGrid.Columns.Add("CakePrc", "Cake Price")
        orderGrid.Columns.Add("Icing", "Icing")
        orderGrid.Columns.Add("IcingPrc", "Icing Price")
        orderGrid.Columns.Add("Topping", "Topping")
        orderGrid.Columns.Add("ToppingPrc", "Topping Price")
        orderGrid.Columns.Add("Qty", "Qty")
    End Sub

    Private Sub addOrdBttn_Click(sender As Object, e As EventArgs) Handles addOrdBttn.Click
        Dim cake As DataRowView = CType(cakeComboBx.SelectedItem, DataRowView)
        Dim icing As DataRowView = CType(icingComboBx.SelectedItem, DataRowView)
        Dim topping As DataRowView = CType(tppngsComboBx.SelectedItem, DataRowView)

        Dim cakePrice As Decimal = CDec(cake("Price"))
        Dim icingPrice As Decimal = CDec(icing("Price"))
        Dim toppingPrice As Decimal = CDec(topping("Price"))

        Dim qty As Integer = Convert.ToInt32(qtyNumBar.Value)

        orderGrid.Rows.Add(cake("CakeID"),
                           cake("CakeType"), cakePrice.ToString("F2"),
                           icing("IcingType"), icingPrice.ToString("F2"),
                           topping("ToppingType"), toppingPrice.ToString("F2"),
                           qty)

        updateTotals()
    End Sub

    Private Sub updateTotals()
        Dim cakeTotal As Decimal = 0
        Dim icingTotal As Decimal = 0
        Dim toppingTotal As Decimal = 0

        For Each row As DataGridViewRow In orderGrid.Rows
            If Not row.IsNewRow Then
                Dim qty As Integer = Convert.ToInt32(row.Cells("Qty").Value)

                cakeTotal += Convert.ToDecimal(row.Cells("CakePrc").Value) * qty
                icingTotal += Convert.ToDecimal(row.Cells("IcingPrc").Value) * qty
                toppingTotal += Convert.ToDecimal(row.Cells("ToppingPrc").Value) * qty
            End If
        Next

        Dim overallTotal As Decimal = cakeTotal + icingTotal + toppingTotal

        cakeTotalTxt.Text = cakeTotal.ToString("F2")
        icingTotalTxt.Text = icingTotal.ToString("F2")
        tppngsTotalTxt.Text = toppingTotal.ToString("F2")
        overAllTxt.Text = overallTotal.ToString("F2")
    End Sub

    Private Sub rmvItemBttn_Click(sender As Object, e As EventArgs) Handles rmvItemBttn.Click
        If orderGrid.SelectedRows.Count > 0 Then
            orderGrid.Rows.Remove(orderGrid.SelectedRows(0))
            updateTotals()
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
    End Sub

    Private Sub placeOrdsBttn_Click(sender As Object, e As EventArgs) Handles placeOrdsBttn.Click
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim tran As SqlTransaction = conn.BeginTransaction()

            Try
                Dim insertOrder As String =
                "INSERT INTO [Order_] (CustomerID, OrderDate, OrderType, TotalAmount, Status_) 
                 OUTPUT INSERTED.OrderID
                 VALUES (@CustomerID, @OrderDate, @OrderType, @TotalAmount, @Status_)"

                Dim orderId As Integer
                Using cmdOrder As New SqlCommand(insertOrder, conn, tran)
                    cmdOrder.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(CstmrComboBx.SelectedValue))
                    cmdOrder.Parameters.AddWithValue("@OrderDate", Date.Now)
                    cmdOrder.Parameters.AddWithValue("@OrderType", delivieryTypeTxt.Text)
                    cmdOrder.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(overAllTxt.Text))
                    cmdOrder.Parameters.AddWithValue("@Status_", "Pending")
                    orderId = Convert.ToInt32(cmdOrder.ExecuteScalar())
                End Using

                For Each row As DataGridViewRow In orderGrid.Rows
                    If row.IsNewRow Then Continue For

                    Dim insertDetail As String =
                    "INSERT INTO OrderDetails (OrderID, CakeID, Quantity, Subtotal)
                     VALUES (@OrderID, @CakeID, @Quantity, @Subtotal)"

                    Using cmdDetail As New SqlCommand(insertDetail, conn, tran)
                        cmdDetail.Parameters.AddWithValue("@OrderID", orderId)
                        cmdDetail.Parameters.AddWithValue("@CakeID", Convert.ToInt32(row.Cells("CakeID").Value))
                        cmdDetail.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells("Qty").Value))
                        cmdDetail.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(row.Cells("CakePrc").Value) +
                                                             Convert.ToDecimal(row.Cells("IcingPrc").Value) +
                                                             Convert.ToDecimal(row.Cells("ToppingPrc").Value))
                        cmdDetail.ExecuteNonQuery()
                    End Using
                Next

                Dim insertBilling As String =
                "INSERT INTO Billing (OrderID, PaymentMethod, AmountPaid, PaymentDate)
                 VALUES (@OrderID, @PaymentMethod, @AmountPaid, @PaymentDate)"

                Using cmdBilling As New SqlCommand(insertBilling, conn, tran)
                    cmdBilling.Parameters.AddWithValue("@OrderID", orderId)
                    cmdBilling.Parameters.AddWithValue("@PaymentMethod", "Cash")
                    cmdBilling.Parameters.AddWithValue("@AmountPaid", Convert.ToDecimal(overAllTxt.Text))
                    cmdBilling.Parameters.AddWithValue("@PaymentDate", Date.Now)
                    cmdBilling.ExecuteNonQuery()
                End Using

                Dim custStreet As String = ""
                Dim custBarangay As String = ""
                Dim custCity As String = ""

                Dim custQry As String = "SELECT StreetAddress, Barangay, City FROM Customer WHERE CustomerID=@CustomerID"
                Using cmdCust As New SqlCommand(custQry, conn, tran)
                    cmdCust.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(CstmrComboBx.SelectedValue))
                    Using rdr As SqlDataReader = cmdCust.ExecuteReader()
                        If rdr.Read() Then
                            custStreet = rdr("StreetAddress").ToString()
                            custBarangay = rdr("Barangay").ToString()
                            custCity = rdr("City").ToString()
                        End If
                    End Using
                End Using

                Dim insertDelivery As String =
                "INSERT INTO Delivery (OrderID, DeliverType, DeliveryDate, DeliveryTime, StreetAddress, Barangay, City) 
                 VALUES (@OrderID, @DeliverType, @DeliveryDate, @DeliveryTime, @StreetAddress, @Barangay, @City)"

                Using cmdDelivery As New SqlCommand(insertDelivery, conn, tran)
                    cmdDelivery.Parameters.AddWithValue("@OrderID", orderId)
                    cmdDelivery.Parameters.AddWithValue("@DeliverType", delivieryTypeTxt.Text)
                    cmdDelivery.Parameters.AddWithValue("@DeliveryDate", Date.Now.Date)
                    cmdDelivery.Parameters.AddWithValue("@DeliveryTime", Date.Now.TimeOfDay)
                    cmdDelivery.Parameters.AddWithValue("@StreetAddress", custStreet)
                    cmdDelivery.Parameters.AddWithValue("@Barangay", custBarangay)
                    cmdDelivery.Parameters.AddWithValue("@City", custCity)
                    cmdDelivery.ExecuteNonQuery()
                End Using

                tran.Commit()
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show("Error placing order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
