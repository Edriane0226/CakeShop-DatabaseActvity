<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderManagement
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
        Panel2 = New Panel()
        delivieryTypeTxt = New TextBox()
        dlvryMethodLabel = New Label()
        Label2 = New Label()
        CstmrComboBx = New ComboBox()
        orderGrid = New DataGridView()
        Panel3 = New Panel()
        placeOrdsBttn = New Button()
        rmvItemBttn = New Button()
        tppngsComboBx = New ComboBox()
        Label6 = New Label()
        icingComboBx = New ComboBox()
        Label5 = New Label()
        addOrdBttn = New Button()
        Label4 = New Label()
        qtyNumBar = New NumericUpDown()
        cakeComboBx = New ComboBox()
        Label3 = New Label()
        Panel4 = New Panel()
        tppngsTotalTxt = New TextBox()
        icingTotalTxt = New TextBox()
        cakeTotalTxt = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        overAllTxt = New TextBox()
        Label10 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(orderGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(qtyNumBar, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Violet
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1317, 60)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 38)
        Label1.TabIndex = 0
        Label1.Text = "Orders"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(delivieryTypeTxt)
        Panel2.Controls.Add(dlvryMethodLabel)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(CstmrComboBx)
        Panel2.Location = New Point(30, 127)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(408, 157)
        Panel2.TabIndex = 1
        ' 
        ' delivieryTypeTxt
        ' 
        delivieryTypeTxt.Location = New Point(229, 81)
        delivieryTypeTxt.Name = "delivieryTypeTxt"
        delivieryTypeTxt.Size = New Size(125, 27)
        delivieryTypeTxt.TabIndex = 10
        ' 
        ' dlvryMethodLabel
        ' 
        dlvryMethodLabel.AutoSize = True
        dlvryMethodLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dlvryMethodLabel.Location = New Point(247, 36)
        dlvryMethodLabel.Name = "dlvryMethodLabel"
        dlvryMethodLabel.Size = New Size(92, 28)
        dlvryMethodLabel.TabIndex = 3
        dlvryMethodLabel.Text = "Delivery"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 28)
        Label2.TabIndex = 1
        Label2.Text = "Customer"
        ' 
        ' CstmrComboBx
        ' 
        CstmrComboBx.FormattingEnabled = True
        CstmrComboBx.Location = New Point(30, 81)
        CstmrComboBx.Name = "CstmrComboBx"
        CstmrComboBx.Size = New Size(151, 28)
        CstmrComboBx.TabIndex = 0
        ' 
        ' orderGrid
        ' 
        orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        orderGrid.Location = New Point(479, 127)
        orderGrid.Name = "orderGrid"
        orderGrid.RowHeadersWidth = 51
        orderGrid.Size = New Size(804, 363)
        orderGrid.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(placeOrdsBttn)
        Panel3.Controls.Add(rmvItemBttn)
        Panel3.Controls.Add(tppngsComboBx)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(icingComboBx)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(addOrdBttn)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(qtyNumBar)
        Panel3.Controls.Add(cakeComboBx)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(30, 312)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(408, 390)
        Panel3.TabIndex = 3
        ' 
        ' placeOrdsBttn
        ' 
        placeOrdsBttn.Location = New Point(14, 307)
        placeOrdsBttn.Name = "placeOrdsBttn"
        placeOrdsBttn.Size = New Size(356, 52)
        placeOrdsBttn.TabIndex = 12
        placeOrdsBttn.Text = "Place Order"
        placeOrdsBttn.UseVisualStyleBackColor = True
        ' 
        ' rmvItemBttn
        ' 
        rmvItemBttn.Location = New Point(201, 225)
        rmvItemBttn.Name = "rmvItemBttn"
        rmvItemBttn.Size = New Size(169, 52)
        rmvItemBttn.TabIndex = 11
        rmvItemBttn.Text = "Remove"
        rmvItemBttn.UseVisualStyleBackColor = True
        ' 
        ' tppngsComboBx
        ' 
        tppngsComboBx.FormattingEnabled = True
        tppngsComboBx.Location = New Point(32, 150)
        tppngsComboBx.Name = "tppngsComboBx"
        tppngsComboBx.Size = New Size(151, 28)
        tppngsComboBx.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(60, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 28)
        Label6.TabIndex = 9
        Label6.Text = "Toppings"
        ' 
        ' icingComboBx
        ' 
        icingComboBx.FormattingEnabled = True
        icingComboBx.Location = New Point(219, 64)
        icingComboBx.Name = "icingComboBx"
        icingComboBx.Size = New Size(151, 28)
        icingComboBx.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(262, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 28)
        Label5.TabIndex = 7
        Label5.Text = "Icing"
        ' 
        ' addOrdBttn
        ' 
        addOrdBttn.Location = New Point(14, 225)
        addOrdBttn.Name = "addOrdBttn"
        addOrdBttn.Size = New Size(169, 52)
        addOrdBttn.TabIndex = 6
        addOrdBttn.Text = "Add"
        addOrdBttn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(244, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 28)
        Label4.TabIndex = 5
        Label4.Text = "Qauntity"
        ' 
        ' qtyNumBar
        ' 
        qtyNumBar.Location = New Point(220, 151)
        qtyNumBar.Name = "qtyNumBar"
        qtyNumBar.Size = New Size(150, 27)
        qtyNumBar.TabIndex = 4
        ' 
        ' cakeComboBx
        ' 
        cakeComboBx.FormattingEnabled = True
        cakeComboBx.Location = New Point(32, 64)
        cakeComboBx.Name = "cakeComboBx"
        cakeComboBx.Size = New Size(151, 28)
        cakeComboBx.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(84, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 28)
        Label3.TabIndex = 2
        Label3.Text = "Cake"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(tppngsTotalTxt)
        Panel4.Controls.Add(icingTotalTxt)
        Panel4.Controls.Add(cakeTotalTxt)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(479, 522)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 180)
        Panel4.TabIndex = 4
        ' 
        ' tppngsTotalTxt
        ' 
        tppngsTotalTxt.Location = New Point(398, 97)
        tppngsTotalTxt.Name = "tppngsTotalTxt"
        tppngsTotalTxt.Size = New Size(150, 27)
        tppngsTotalTxt.TabIndex = 11
        ' 
        ' icingTotalTxt
        ' 
        icingTotalTxt.Location = New Point(214, 97)
        icingTotalTxt.Name = "icingTotalTxt"
        icingTotalTxt.Size = New Size(125, 27)
        icingTotalTxt.TabIndex = 10
        ' 
        ' cakeTotalTxt
        ' 
        cakeTotalTxt.Location = New Point(30, 97)
        cakeTotalTxt.Name = "cakeTotalTxt"
        cakeTotalTxt.Size = New Size(125, 27)
        cakeTotalTxt.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(398, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(150, 28)
        Label9.TabIndex = 8
        Label9.Text = "Toppings Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(228, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 28)
        Label8.TabIndex = 7
        Label8.Text = "Icing Total"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(45, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 28)
        Label7.TabIndex = 6
        Label7.Text = "Cake Total"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(overAllTxt)
        Panel5.Controls.Add(Label10)
        Panel5.Location = New Point(1103, 522)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(180, 180)
        Panel5.TabIndex = 5
        ' 
        ' overAllTxt
        ' 
        overAllTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        overAllTxt.Location = New Point(24, 90)
        overAllTxt.Name = "overAllTxt"
        overAllTxt.Size = New Size(133, 34)
        overAllTxt.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(24, 24)
        Label10.Name = "Label10"
        Label10.Size = New Size(133, 28)
        Label10.TabIndex = 9
        Label10.Text = "Overall Total"
        ' 
        ' OrderManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 740)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(orderGrid)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "OrderManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OrderManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(orderGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(qtyNumBar, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents orderGrid As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CstmrComboBx As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cakeComboBx As ComboBox
    Friend WithEvents tppngsComboBx As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents icingComboBx As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents addOrdBttn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents qtyNumBar As NumericUpDown
    Friend WithEvents placeOrdsBttn As Button
    Friend WithEvents rmvItemBttn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents tppngsTotalTxt As TextBox
    Friend WithEvents icingTotalTxt As TextBox
    Friend WithEvents cakeTotalTxt As TextBox
    Friend WithEvents overAllTxt As TextBox
    Friend WithEvents dlvryMethodLabel As Label
    Friend WithEvents delivieryTypeTxt As TextBox
End Class
