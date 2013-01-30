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
        Me.Table_num_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Email_label = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bdate_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Edate_TextBox = New System.Windows.Forms.TextBox()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Reseved_label = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Edit_Button = New System.Windows.Forms.Button()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Table_num_TextBox
        '
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
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Begin Date"
        '
        'Bdate_TextBox
        '
        Me.Bdate_TextBox.Location = New System.Drawing.Point(304, 31)
        Me.Bdate_TextBox.Name = "Bdate_TextBox"
        Me.Bdate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bdate_TextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "End Date"
        '
        'Edate_TextBox
        '
        Me.Edate_TextBox.Location = New System.Drawing.Point(304, 64)
        Me.Edate_TextBox.Name = "Edate_TextBox"
        Me.Edate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Edate_TextBox.TabIndex = 8
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(29, 149)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 10
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Reseved_label
        '
        Me.Reseved_label.AutoSize = True
        Me.Reseved_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Reseved_label.Location = New System.Drawing.Point(506, 31)
        Me.Reseved_label.Name = "Reseved_label"
        Me.Reseved_label.Size = New System.Drawing.Size(33, 13)
        Me.Reseved_label.TabIndex = 12
        Me.Reseved_label.Text = "Open"
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(370, 149)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(75, 23)
        Me.Close_Button.TabIndex = 14
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Edit_Button
        '
        Me.Edit_Button.Location = New System.Drawing.Point(145, 149)
        Me.Edit_Button.Name = "Edit_Button"
        Me.Edit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Button.TabIndex = 15
        Me.Edit_Button.Text = "Edit"
        Me.Edit_Button.UseVisualStyleBackColor = True
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(262, 149)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 16
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 327)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Edit_Button)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Reseved_label)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Edate_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bdate_TextBox)
        Me.Controls.Add(Me.Email_label)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Name_Label)
        Me.Controls.Add(Me.Table_num_TextBox)
        Me.Name = "Reserve"
        Me.Text = "Reserve"
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
    Friend WithEvents Bdate_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Edate_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Reseved_label As System.Windows.Forms.Label
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Edit_Button As System.Windows.Forms.Button
    Friend WithEvents Delete_Button As System.Windows.Forms.Button
End Class
