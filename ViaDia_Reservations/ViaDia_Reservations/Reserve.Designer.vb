<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reserve
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
        Me.components = New System.ComponentModel.Container()
        Me.Table_num_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Email_label = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Reserved_label = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Edit_Button = New System.Windows.Forms.Button()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Editor_label = New System.Windows.Forms.Label()
        Me.Editor_TextBox = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Phone_Num_TextBox = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Week_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Week_Label = New System.Windows.Forms.Label()
        Me.Comment_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table_num_TextBox
        '
        Me.Table_num_TextBox.Enabled = False
        Me.Table_num_TextBox.Location = New System.Drawing.Point(82, 31)
        Me.Table_num_TextBox.Name = "Table_num_TextBox"
        Me.Table_num_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Table_num_TextBox.TabIndex = 0
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(26, 38)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(44, 13)
        Me.Name_Label.TabIndex = 1
        Me.Name_Label.Text = "Table #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(82, 64)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Name_TextBox.TabIndex = 2
        '
        'Email_label
        '
        Me.Email_label.AutoSize = True
        Me.Email_label.Location = New System.Drawing.Point(26, 107)
        Me.Email_label.Name = "Email_label"
        Me.Email_label.Size = New System.Drawing.Size(32, 13)
        Me.Email_label.TabIndex = 5
        Me.Email_label.Text = "Email"
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(82, 100)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_TextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Begin Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "End Date"
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(32, 278)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 16
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Reserved_label
        '
        Me.Reserved_label.AutoSize = True
        Me.Reserved_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Reserved_label.Location = New System.Drawing.Point(506, 31)
        Me.Reserved_label.Name = "Reserved_label"
        Me.Reserved_label.Size = New System.Drawing.Size(33, 13)
        Me.Reserved_label.TabIndex = 12
        Me.Reserved_label.Text = "Open"
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(372, 278)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(75, 23)
        Me.Close_Button.TabIndex = 19
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Edit_Button
        '
        Me.Edit_Button.Enabled = False
        Me.Edit_Button.Location = New System.Drawing.Point(144, 278)
        Me.Edit_Button.Name = "Edit_Button"
        Me.Edit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Button.TabIndex = 17
        Me.Edit_Button.Text = "Edit"
        Me.Edit_Button.UseVisualStyleBackColor = True
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(262, 278)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 18
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(321, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2013, 1, 25, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(321, 106)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 12
        Me.DateTimePicker2.Value = New Date(2013, 1, 25, 0, 0, 0, 0)
        '
        'Editor_label
        '
        Me.Editor_label.AutoSize = True
        Me.Editor_label.Location = New System.Drawing.Point(224, 135)
        Me.Editor_label.Name = "Editor_label"
        Me.Editor_label.Size = New System.Drawing.Size(64, 13)
        Me.Editor_label.TabIndex = 15
        Me.Editor_label.Text = "Seller Name"
        '
        'Editor_TextBox
        '
        Me.Editor_TextBox.Location = New System.Drawing.Point(321, 141)
        Me.Editor_TextBox.Name = "Editor_TextBox"
        Me.Editor_TextBox.Size = New System.Drawing.Size(103, 20)
        Me.Editor_TextBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Phone #"
        '
        'Phone_Num_TextBox
        '
        Me.Phone_Num_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Phone_Num_TextBox.Location = New System.Drawing.Point(82, 139)
        Me.Phone_Num_TextBox.Name = "Phone_Num_TextBox"
        Me.Phone_Num_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_Num_TextBox.TabIndex = 6
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(442, 79)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(39, 13)
        Me.label10.TabIndex = 23
        Me.label10.Text = "Week:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Reserved Time"
        '
        'Week_ComboBox
        '
        Me.Week_ComboBox.FormattingEnabled = True
        Me.Week_ComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Week_ComboBox.Location = New System.Drawing.Point(321, 71)
        Me.Week_ComboBox.Name = "Week_ComboBox"
        Me.Week_ComboBox.Size = New System.Drawing.Size(103, 21)
        Me.Week_ComboBox.TabIndex = 10
        '
        'Week_Label
        '
        Me.Week_Label.AutoSize = True
        Me.Week_Label.Location = New System.Drawing.Point(499, 79)
        Me.Week_Label.Name = "Week_Label"
        Me.Week_Label.Size = New System.Drawing.Size(21, 13)
        Me.Week_Label.TabIndex = 26
        Me.Week_Label.Text = "lab"
        '
        'Comment_TextBox
        '
        Me.Comment_TextBox.Location = New System.Drawing.Point(32, 205)
        Me.Comment_TextBox.Multiline = True
        Me.Comment_TextBox.Name = "Comment_TextBox"
        Me.Comment_TextBox.Size = New System.Drawing.Size(392, 54)
        Me.Comment_TextBox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Comments (500 char)"
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 327)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Comment_TextBox)
        Me.Controls.Add(Me.Week_Label)
        Me.Controls.Add(Me.Week_ComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Phone_Num_TextBox)
        Me.Controls.Add(Me.Editor_TextBox)
        Me.Controls.Add(Me.Editor_label)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Edit_Button)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Reserved_label)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Email_label)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Name_Label)
        Me.Controls.Add(Me.Table_num_TextBox)
        Me.Name = "Reserve"
        Me.Text = "Reserve"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Table_num_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_label As System.Windows.Forms.Label
    Friend WithEvents Email_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Reserved_label As System.Windows.Forms.Label
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Edit_Button As System.Windows.Forms.Button
    Friend WithEvents Delete_Button As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Editor_label As System.Windows.Forms.Label
    Friend WithEvents Editor_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Phone_Num_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Week_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Week_Label As System.Windows.Forms.Label
    Friend WithEvents Comment_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
