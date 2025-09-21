<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToppingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        addBtn = New Button()
        deleteBtn = New Button()
        updateBtn = New Button()
        tppngDataGrid = New DataGridView()
        tppngPriceDropDwn = New NumericUpDown()
        tppngTypeTxtBox = New TextBox()
        Label2 = New Label()
        cakeTypeLabel = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        CType(tppngDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(tppngPriceDropDwn, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(28, 337)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(287, 41)
        addBtn.TabIndex = 17
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Location = New Point(221, 252)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(94, 41)
        deleteBtn.TabIndex = 16
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(28, 252)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(94, 41)
        updateBtn.TabIndex = 15
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' tppngDataGrid
        ' 
        tppngDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tppngDataGrid.Location = New Point(419, 103)
        tppngDataGrid.Name = "tppngDataGrid"
        tppngDataGrid.RowHeadersWidth = 51
        tppngDataGrid.Size = New Size(429, 218)
        tppngDataGrid.TabIndex = 14
        ' 
        ' tppngPriceDropDwn
        ' 
        tppngPriceDropDwn.Location = New Point(165, 156)
        tppngPriceDropDwn.Name = "tppngPriceDropDwn"
        tppngPriceDropDwn.Size = New Size(150, 27)
        tppngPriceDropDwn.TabIndex = 13
        ' 
        ' tppngTypeTxtBox
        ' 
        tppngTypeTxtBox.Location = New Point(165, 103)
        tppngTypeTxtBox.Name = "tppngTypeTxtBox"
        tppngTypeTxtBox.Size = New Size(150, 27)
        tppngTypeTxtBox.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 23)
        Label2.TabIndex = 11
        Label2.Text = "Price"
        ' 
        ' cakeTypeLabel
        ' 
        cakeTypeLabel.AutoSize = True
        cakeTypeLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cakeTypeLabel.Location = New Point(28, 103)
        cakeTypeLabel.Name = "cakeTypeLabel"
        cakeTypeLabel.Size = New Size(119, 23)
        cakeTypeLabel.TabIndex = 10
        cakeTypeLabel.Text = "Topping Type"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumTurquoise
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(995, 54)
        Panel1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 38)
        Label1.TabIndex = 0
        Label1.Text = "Toppings"
        ' 
        ' ToppingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 406)
        Controls.Add(addBtn)
        Controls.Add(deleteBtn)
        Controls.Add(updateBtn)
        Controls.Add(tppngDataGrid)
        Controls.Add(tppngPriceDropDwn)
        Controls.Add(tppngTypeTxtBox)
        Controls.Add(Label2)
        Controls.Add(cakeTypeLabel)
        Controls.Add(Panel1)
        Name = "ToppingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Topping"
        CType(tppngDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(tppngPriceDropDwn, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents cakeDataGrid As DataGridView
    Friend WithEvents priceDropDwn As NumericUpDown
    Friend WithEvents cakeTypeTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cakeTypeLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tppngPriceDropDwn As NumericUpDown
    Friend WithEvents tppngTypeTxtBox As TextBox
    Friend WithEvents tppngDataGrid As DataGridView
End Class
