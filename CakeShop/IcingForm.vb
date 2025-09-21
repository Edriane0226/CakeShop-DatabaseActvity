Imports System.Data.SqlClient

Public Class IcingForm

    Dim connString As String =
    "Server=(localdb)\MSSQLLocalDB;Database=Sweet_DelightsDB;Trusted_Connection=True;"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Dim Dash As New Dashboard()
        Dash.Show()
    End Sub

    Private Sub getIcing()
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT * FROM Icing"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                icingDataGrid.DataSource = table
            End Using
        End Using
    End Sub
    Private Sub IcingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getIcing()
    End Sub
End Class