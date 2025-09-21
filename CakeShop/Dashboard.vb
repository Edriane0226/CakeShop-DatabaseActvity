Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Dashboard
    Private Sub MngCustomerBttn_Click(sender As Object, e As EventArgs) Handles MngCustomerBttn.Click
        Me.Hide()
        Dim CustomerForm As New Customers()
        CustomerForm.Show()
    End Sub

    Private Sub MngOrderBttn_Click(sender As Object, e As EventArgs) Handles MngOrderBttn.Click
        Me.Hide()
        Dim Orders As New OrderManagement()
        Orders.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewComboBx.Text = "Select Item"
        ViewComboBx.Items.Add("Cake")
        ViewComboBx.Items.Add("Icing")
        ViewComboBx.Items.Add("Toppings")
    End Sub

    Private Sub ViewComboBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ViewComboBx.SelectedIndexChanged
        If ViewComboBx.SelectedItem.ToString() = "Cake" Then
            Me.Hide()
            Dim CakeForm As New Cake()
            CakeForm.Show()
        ElseIf ViewComboBx.SelectedItem.ToString() = "Icing" Then
            Me.Hide()
            Dim IcingForm As New IcingForm()
            IcingForm.Show()
        ElseIf ViewComboBx.SelectedItem.ToString() = "Toppings" Then
            Me.Hide()
            Dim ToppingForm As New ToppingForm()
            ToppingForm.Show()
        End If
    End Sub
End Class
