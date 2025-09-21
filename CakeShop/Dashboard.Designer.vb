<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        MngOrderBttn = New Button()
        MngCustomerBttn = New Button()
        GroupBox2 = New GroupBox()
        ViewComboBx = New ComboBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 40)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MngOrderBttn)
        GroupBox1.Controls.Add(MngCustomerBttn)
        GroupBox1.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(31, 91)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 252)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Manage"
        ' 
        ' MngOrderBttn
        ' 
        MngOrderBttn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MngOrderBttn.Location = New Point(59, 144)
        MngOrderBttn.Name = "MngOrderBttn"
        MngOrderBttn.Size = New Size(129, 39)
        MngOrderBttn.TabIndex = 1
        MngOrderBttn.Text = "Orders"
        MngOrderBttn.UseVisualStyleBackColor = True
        ' 
        ' MngCustomerBttn
        ' 
        MngCustomerBttn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MngCustomerBttn.Location = New Point(59, 73)
        MngCustomerBttn.Name = "MngCustomerBttn"
        MngCustomerBttn.Size = New Size(129, 39)
        MngCustomerBttn.TabIndex = 0
        MngCustomerBttn.Text = "Customers"
        MngCustomerBttn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ViewComboBx)
        GroupBox2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(500, 91)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 252)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "View"
        ' 
        ' ViewComboBx
        ' 
        ViewComboBx.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewComboBx.FormattingEnabled = True
        ViewComboBx.Location = New Point(57, 115)
        ViewComboBx.Name = "ViewComboBx"
        ViewComboBx.Size = New Size(151, 31)
        ViewComboBx.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cake Shop"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MngOrderBttn As Button
    Friend WithEvents MngCustomerBttn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ViewComboBx As ComboBox

End Class
