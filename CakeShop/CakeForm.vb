Imports Microsoft.Data.SqlClient

Public Class Cake

    Dim connString As String =
    "Server=(localdb)\MSSQLLocalDB;Database=Sweet_DelightsDB;Trusted_Connection=True;"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Dim Dash As New Dashboard()
        Dash.Show()
    End Sub

    Private Sub getCake()
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT * FROM Cake"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                cakeDataGrid.DataSource = table
            End Using
        End Using
    End Sub
    Private Sub CakeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        priceDropDwn.Maximum = 1000000
        getCake()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "INSERT INTO Cake 
                                   VALUES (@CakeType, @Price)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@CakeType", cakeTypeTxtBox.Text)
            cmd.Parameters.AddWithValue("@Price", priceDropDwn.Value)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cake Added!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        getCake()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If cakeDataGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim id As Integer = CInt(cakeDataGrid.SelectedRows(0).Cells("CakeID").Value)

        Using conn As New SqlConnection(connString)
            Dim query As String = "UPDATE Cake
                                   SET CakeType=@CakeType, Price=@Price
                                   WHERE CakeID=@CakeID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CakeID", id)
                cmd.Parameters.AddWithValue("@CakeType", cakeTypeTxtBox.Text)
                cmd.Parameters.AddWithValue("@Price", priceDropDwn.Value)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cake updated!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        getCake()
    End Sub

    Private Sub cakeDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cakeDataGrid.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = cakeDataGrid.Rows(e.RowIndex)
            cakeTypeTxtBox.Text = row.Cells("CakeType").Value.ToString()
            priceDropDwn.Value = Convert.ToDecimal(row.Cells("Price").Value)
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If cakeDataGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim id As Integer = CInt(cakeDataGrid.SelectedRows(0).Cells("CakeID").Value)

        Using conn As New SqlConnection(connString)
            Dim query As String = "Delete FROM Cake
                                   WHERE CakeType=@CakeType"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CakeType", cakeTypeTxtBox.Text)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Cake Deleted!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        getCake()
    End Sub
End Class