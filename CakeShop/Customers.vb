Imports Microsoft.Data.SqlClient

Public Class Customers

    Dim connString As String =
    "Server=(localdb)\MSSQLLocalDB;Database=Sweet_DelightsDB;Trusted_Connection=True;"

    Private Sub addBttn_Click(sender As Object, e As EventArgs) Handles addBttn.Click

        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "INSERT INTO Customer 
                                   VALUES (@FirstName, @LastName, @ContactNumber, @Email, @StreetAddress, @Barangay, @City)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FirstName", frstNameTxt.Text)
            cmd.Parameters.AddWithValue("@LastName", lastNameTxt.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", contactNumTxt.Text)
            cmd.Parameters.AddWithValue("@Email", emailTxt.Text)
            cmd.Parameters.AddWithValue("@StreetAddress", streetTxt.Text)
            cmd.Parameters.AddWithValue("@Barangay", brgyTxt.Text)
            cmd.Parameters.AddWithValue("@City", cityTxt.Text)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer added successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        ClearForm()
        getCustomer()
    End Sub

    Private Sub ClearForm()
        frstNameTxt.Clear()
        lastNameTxt.Clear()
        contactNumTxt.Clear()
        emailTxt.Clear()
        streetTxt.Clear()
        brgyTxt.Clear()
        cityTxt.Clear()
    End Sub

    Private Sub getCustomer()
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT * FROM Customer"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                custmrTable.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub updtBttn_Click_1(sender As Object, e As EventArgs) Handles updtBttn.Click
        If custmrTable.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim id As Integer = CInt(custmrTable.SelectedRows(0).Cells("CustomerID").Value)

        Using conn As New SqlConnection(connString)
            Dim query As String = "UPDATE Customer 
                                   SET FirstName=@FirstName, LastName=@LastName, ContactNumber=@ContactNumber, 
                                       Email=@Email, StreetAddress=@StreetAddress, Barangay=@Barangay, City=@City
                                   WHERE CustomerID=@CustomerID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CustomerID", id)
                cmd.Parameters.AddWithValue("@FirstName", frstNameTxt.Text)
                cmd.Parameters.AddWithValue("@LastName", lastNameTxt.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumTxt.Text)
                cmd.Parameters.AddWithValue("@Email", emailTxt.Text)
                cmd.Parameters.AddWithValue("@StreetAddress", streetTxt.Text)
                cmd.Parameters.AddWithValue("@Barangay", brgyTxt.Text)
                cmd.Parameters.AddWithValue("@City", cityTxt.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer updated successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        getCustomer()
    End Sub

    Private Sub delBttn_Click(sender As Object, e As EventArgs) Handles delBttn.Click
        If custmrTable.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim id As Integer = CInt(custmrTable.SelectedRows(0).Cells("CustomerID").Value)

        Using conn As New SqlConnection(connString)
            Dim query As String = "DELETE FROM Customer WHERE CustomerID=@CustomerID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CustomerID", id)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer deleted successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        getCustomer()
    End Sub

    Private Sub refreshBttn_Click(sender As Object, e As EventArgs) Handles refreshBttn.Click
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT * FROM Customer"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                custmrTable.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub custmrTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles custmrTable.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = custmrTable.Rows(e.RowIndex)
            frstNameTxt.Text = row.Cells("FirstName").Value.ToString()
            lastNameTxt.Text = row.Cells("LastName").Value.ToString()
            contactNumTxt.Text = row.Cells("ContactNumber").Value.ToString()
            emailTxt.Text = row.Cells("Email").Value.ToString()
            streetTxt.Text = row.Cells("StreetAddress").Value.ToString()
            brgyTxt.Text = row.Cells("Barangay").Value.ToString()
            cityTxt.Text = row.Cells("City").Value.ToString()
        End If
    End Sub

    Private Sub redirectLabel_Click(sender As Object, e As EventArgs) Handles redirectLabel.Click
        Me.Hide()
        Dim Dash As New Dashboard()
        Dash.Show()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCustomer()
    End Sub
End Class