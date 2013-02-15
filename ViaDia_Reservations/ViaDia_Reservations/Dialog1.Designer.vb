<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comment_TextBox = New System.Windows.Forms.TextBox()
        Me.Week_Label = New System.Windows.Forms.Label()
        Me.Week_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Phone_Num_TextBox = New System.Windows.Forms.TextBox()
        Me.Editor_TextBox = New System.Windows.Forms.TextBox()
        Me.Editor_label = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Edit_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Reserved_label = New System.Windows.Forms.Label()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Email_label = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Table_num_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Comments (500 char)"
        '
        'Comment_TextBox
        '
        Me.Comment_TextBox.Location = New System.Drawing.Point(19, 138)
        Me.Comment_TextBox.Multiline = True
        Me.Comment_TextBox.Name = "Comment_TextBox"
        Me.Comment_TextBox.Size = New System.Drawing.Size(392, 54)
        Me.Comment_TextBox.TabIndex = 52
        '
        'Week_Label
        '
        Me.Week_Label.AutoSize = True
        Me.Week_Label.Location = New System.Drawing.Point(520, 109)
        Me.Week_Label.Name = "Week_Label"
        Me.Week_Label.Size = New System.Drawing.Size(21, 13)
        Me.Week_Label.TabIndex = 51
        Me.Week_Label.Text = "lab"
        '
        'Week_ComboBox
        '
        Me.Week_ComboBox.Enabled = False
        Me.Week_ComboBox.FormattingEnabled = True
        Me.Week_ComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Week_ComboBox.Location = New System.Drawing.Point(293, 42)
        Me.Week_ComboBox.Name = "Week_ComboBox"
        Me.Week_ComboBox.Size = New System.Drawing.Size(103, 21)
        Me.Week_ComboBox.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Reserved Time"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(406, 50)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(39, 13)
        Me.label10.TabIndex = 50
        Me.label10.Text = "Week:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Phone #"
        '
        'Phone_Num_TextBox
        '
        Me.Phone_Num_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Phone_Num_TextBox.Location = New System.Drawing.Point(69, 104)
        Me.Phone_Num_TextBox.Name = "Phone_Num_TextBox"
        Me.Phone_Num_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_Num_TextBox.TabIndex = 35
        '
        'Editor_TextBox
        '
        Me.Editor_TextBox.Enabled = False
        Me.Editor_TextBox.Location = New System.Drawing.Point(293, 112)
        Me.Editor_TextBox.Name = "Editor_TextBox"
        Me.Editor_TextBox.Size = New System.Drawing.Size(103, 20)
        Me.Editor_TextBox.TabIndex = 44
        '
        'Editor_label
        '
        Me.Editor_label.AutoSize = True
        Me.Editor_label.Location = New System.Drawing.Point(196, 106)
        Me.Editor_label.Name = "Editor_label"
        Me.Editor_label.Size = New System.Drawing.Size(64, 13)
        Me.Editor_label.TabIndex = 45
        Me.Editor_label.Text = "Seller Name"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(293, 77)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 41
        Me.DateTimePicker2.Value = New Date(2013, 1, 25, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(293, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 37
        Me.DateTimePicker1.Value = New Date(2013, 1, 25, 0, 0, 0, 0)
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(283, 308)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 48
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Edit_Button
        '
        Me.Edit_Button.Enabled = False
        Me.Edit_Button.Location = New System.Drawing.Point(165, 308)
        Me.Edit_Button.Name = "Edit_Button"
        Me.Edit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Button.TabIndex = 47
        Me.Edit_Button.Text = "Edit"
        Me.Edit_Button.UseVisualStyleBackColor = True
        Me.Edit_Button.Visible = False
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(393, 308)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(75, 23)
        Me.Close_Button.TabIndex = 49
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        Me.Close_Button.Visible = False
        '
        'Reserved_label
        '
        Me.Reserved_label.AutoSize = True
        Me.Reserved_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Reserved_label.Location = New System.Drawing.Point(527, 61)
        Me.Reserved_label.Name = "Reserved_label"
        Me.Reserved_label.Size = New System.Drawing.Size(33, 13)
        Me.Reserved_label.TabIndex = 42
        Me.Reserved_label.Text = "Open"
        Me.Reserved_label.Visible = False
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(53, 308)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 46
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        Me.Save_Button.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Begin Date"
        '
        'Email_label
        '
        Me.Email_label.AutoSize = True
        Me.Email_label.Location = New System.Drawing.Point(13, 72)
        Me.Email_label.Name = "Email_label"
        Me.Email_label.Size = New System.Drawing.Size(32, 13)
        Me.Email_label.TabIndex = 34
        Me.Email_label.Text = "Email"
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(69, 65)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_TextBox.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Name"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(69, 29)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Name_TextBox.TabIndex = 31
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(13, 10)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(44, 13)
        Me.Name_Label.TabIndex = 30
        Me.Name_Label.Text = "Table #"
        '
        'Table_num_TextBox
        '
        Me.Table_num_TextBox.Enabled = False
        Me.Table_num_TextBox.Location = New System.Drawing.Point(69, 3)
        Me.Table_num_TextBox.Name = "Table_num_TextBox"
        Me.Table_num_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Table_num_TextBox.TabIndex = 29
        '
        'Dialog1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 220)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Comment_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Week_Label As System.Windows.Forms.Label
    Friend WithEvents Week_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Phone_Num_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Editor_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Editor_label As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Delete_Button As System.Windows.Forms.Button
    Friend WithEvents Edit_Button As System.Windows.Forms.Button
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Reserved_label As System.Windows.Forms.Label
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Email_label As System.Windows.Forms.Label
    Friend WithEvents Email_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Table_num_TextBox As System.Windows.Forms.TextBox

End Class
