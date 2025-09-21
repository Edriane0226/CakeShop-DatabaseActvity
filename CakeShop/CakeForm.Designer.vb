<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cake
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
        Panel1 = New Panel()
        Label1 = New Label()
        cakeTypeLabel = New Label()
        Label2 = New Label()
        cakeTypeTxtBox = New TextBox()
        priceDropDwn = New NumericUpDown()
        cakeDataGrid = New DataGridView()
        updateBtn = New Button()
        deleteBtn = New Button()
        addBtn = New Button()
        Panel1.SuspendLayout()
        CType(priceDropDwn, ComponentModel.ISupportInitialize).BeginInit()
        CType(cakeDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumTurquoise
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(874, 54)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 38)
        Label1.TabIndex = 0
        Label1.Text = "Cake's"
        ' 
        ' cakeTypeLabel
        ' 
        cakeTypeLabel.AutoSize = True
        cakeTypeLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cakeTypeLabel.Location = New Point(36, 103)
        cakeTypeLabel.Name = "cakeTypeLabel"
        cakeTypeLabel.Size = New Size(92, 23)
        cakeTypeLabel.TabIndex = 1
        cakeTypeLabel.Text = "Cake Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 23)
        Label2.TabIndex = 2
        Label2.Text = "Price"
        ' 
        ' cakeTypeTxtBox
        ' 
        cakeTypeTxtBox.Location = New Point(166, 102)
        cakeTypeTxtBox.Name = "cakeTypeTxtBox"
        cakeTypeTxtBox.Size = New Size(150, 27)
        cakeTypeTxtBox.TabIndex = 3
        ' 
        ' priceDropDwn
        ' 
        priceDropDwn.Location = New Point(166, 155)
        priceDropDwn.Name = "priceDropDwn"
        priceDropDwn.Size = New Size(150, 27)
        priceDropDwn.TabIndex = 4
        ' 
        ' cakeDataGrid
        ' 
        cakeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        cakeDataGrid.Location = New Point(420, 102)
        cakeDataGrid.Name = "cakeDataGrid"
        cakeDataGrid.RowHeadersWidth = 51
        cakeDataGrid.Size = New Size(429, 218)
        cakeDataGrid.TabIndex = 5
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(36, 251)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(94, 41)
        updateBtn.TabIndex = 6
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Location = New Point(222, 251)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(94, 41)
        deleteBtn.TabIndex = 7
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(36, 336)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(280, 41)
        addBtn.TabIndex = 8
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' Cake
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 406)
        Controls.Add(addBtn)
        Controls.Add(deleteBtn)
        Controls.Add(updateBtn)
        Controls.Add(cakeDataGrid)
        Controls.Add(priceDropDwn)
        Controls.Add(cakeTypeTxtBox)
        Controls.Add(Label2)
        Controls.Add(cakeTypeLabel)
        Controls.Add(Panel1)
        Name = "Cake"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cake"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(priceDropDwn, ComponentModel.ISupportInitialize).EndInit()
        CType(cakeDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cakeTypeLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cakeTypeTxtBox As TextBox
    Friend WithEvents priceDropDwn As NumericUpDown
    Friend WithEvents cakeDataGrid As DataGridView
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents addBtn As Button
End Class
