<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        redirectLabel = New Label()
        addBttn = New Button()
        refreshBttn = New Button()
        delBttn = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        brgyTxt = New TextBox()
        cityTxt = New TextBox()
        streetTxt = New TextBox()
        emailTxt = New TextBox()
        contactNumTxt = New TextBox()
        lastNameTxt = New TextBox()
        frstNameTxt = New TextBox()
        custmrTable = New DataGridView()
        updtBttn = New Button()
        Panel1.SuspendLayout()
        CType(custmrTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Violet
        Panel1.Controls.Add(redirectLabel)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1531, 60)
        Panel1.TabIndex = 0
        ' 
        ' redirectLabel
        ' 
        redirectLabel.AutoSize = True
        redirectLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        redirectLabel.ForeColor = SystemColors.Desktop
        redirectLabel.Location = New Point(11, 9)
        redirectLabel.Name = "redirectLabel"
        redirectLabel.Size = New Size(155, 38)
        redirectLabel.TabIndex = 0
        redirectLabel.Text = "Customers"
        ' 
        ' addBttn
        ' 
        addBttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addBttn.Location = New Point(21, 519)
        addBttn.Name = "addBttn"
        addBttn.Size = New Size(152, 46)
        addBttn.TabIndex = 3
        addBttn.Text = "Add"
        addBttn.UseVisualStyleBackColor = True
        ' 
        ' refreshBttn
        ' 
        refreshBttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        refreshBttn.Location = New Point(244, 594)
        refreshBttn.Name = "refreshBttn"
        refreshBttn.Size = New Size(152, 46)
        refreshBttn.TabIndex = 4
        refreshBttn.Text = "Refresh"
        refreshBttn.UseVisualStyleBackColor = True
        ' 
        ' delBttn
        ' 
        delBttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        delBttn.Location = New Point(24, 594)
        delBttn.Name = "delBttn"
        delBttn.Size = New Size(152, 46)
        delBttn.TabIndex = 5
        delBttn.Text = "Delete"
        delBttn.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 399)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 28)
        Label8.TabIndex = 27
        Label8.Text = "Barangay"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 454)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 28)
        Label7.TabIndex = 26
        Label7.Text = "City"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 28)
        Label6.TabIndex = 25
        Label6.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 341)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 28)
        Label5.TabIndex = 24
        Label5.Text = "Street"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 28)
        Label4.TabIndex = 23
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 28)
        Label3.TabIndex = 22
        Label3.Text = "Contact Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 21
        Label2.Text = "First Name"
        ' 
        ' brgyTxt
        ' 
        brgyTxt.Location = New Point(171, 400)
        brgyTxt.Name = "brgyTxt"
        brgyTxt.Size = New Size(225, 27)
        brgyTxt.TabIndex = 20
        ' 
        ' cityTxt
        ' 
        cityTxt.Location = New Point(171, 455)
        cityTxt.Name = "cityTxt"
        cityTxt.Size = New Size(225, 27)
        cityTxt.TabIndex = 19
        ' 
        ' streetTxt
        ' 
        streetTxt.Location = New Point(171, 342)
        streetTxt.Name = "streetTxt"
        streetTxt.Size = New Size(225, 27)
        streetTxt.TabIndex = 18
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(171, 289)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(225, 27)
        emailTxt.TabIndex = 17
        ' 
        ' contactNumTxt
        ' 
        contactNumTxt.Location = New Point(171, 242)
        contactNumTxt.Name = "contactNumTxt"
        contactNumTxt.Size = New Size(225, 27)
        contactNumTxt.TabIndex = 16
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.Location = New Point(171, 186)
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(225, 27)
        lastNameTxt.TabIndex = 15
        ' 
        ' frstNameTxt
        ' 
        frstNameTxt.Location = New Point(171, 133)
        frstNameTxt.Name = "frstNameTxt"
        frstNameTxt.Size = New Size(225, 27)
        frstNameTxt.TabIndex = 14
        ' 
        ' custmrTable
        ' 
        custmrTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        custmrTable.Location = New Point(457, 133)
        custmrTable.Name = "custmrTable"
        custmrTable.RowHeadersWidth = 51
        custmrTable.Size = New Size(1053, 507)
        custmrTable.TabIndex = 28
        ' 
        ' updtBttn
        ' 
        updtBttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updtBttn.Location = New Point(244, 519)
        updtBttn.Name = "updtBttn"
        updtBttn.Size = New Size(152, 46)
        updtBttn.TabIndex = 29
        updtBttn.Text = "Update"
        updtBttn.UseVisualStyleBackColor = True
        ' 
        ' Customers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1530, 664)
        Controls.Add(updtBttn)
        Controls.Add(custmrTable)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(brgyTxt)
        Controls.Add(cityTxt)
        Controls.Add(streetTxt)
        Controls.Add(emailTxt)
        Controls.Add(contactNumTxt)
        Controls.Add(lastNameTxt)
        Controls.Add(frstNameTxt)
        Controls.Add(delBttn)
        Controls.Add(refreshBttn)
        Controls.Add(addBttn)
        Controls.Add(Panel1)
        Name = "Customers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(custmrTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents redirectLabel As Label
    Friend WithEvents addBttn As Button
    Friend WithEvents refreshBttn As Button
    Friend WithEvents delBttn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents brgyTxt As TextBox
    Friend WithEvents cityTxt As TextBox
    Friend WithEvents streetTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents contactNumTxt As TextBox
    Friend WithEvents lastNameTxt As TextBox
    Friend WithEvents frstNameTxt As TextBox
    Friend WithEvents custmrTable As DataGridView
    Friend WithEvents updtBttn As Button
End Class
