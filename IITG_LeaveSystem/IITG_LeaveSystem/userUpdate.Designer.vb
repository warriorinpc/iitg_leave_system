<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userUpdate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.choice_combo = New System.Windows.Forms.ComboBox()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.fieldBox = New System.Windows.Forms.ComboBox()
        Me.update_button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.val_text = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(119, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select User Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Field to update:"
        '
        'choice_combo
        '
        Me.choice_combo.FormattingEnabled = True
        Me.choice_combo.Items.AddRange(New Object() {"Student", "Staff", "Professor", "HOD", "DPPC", "Dean", "Director", "Office"})
        Me.choice_combo.Location = New System.Drawing.Point(352, 62)
        Me.choice_combo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.choice_combo.Name = "choice_combo"
        Me.choice_combo.Size = New System.Drawing.Size(176, 24)
        Me.choice_combo.TabIndex = 7
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(352, 103)
        Me.username_text.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(176, 27)
        Me.username_text.TabIndex = 8
        '
        'fieldBox
        '
        Me.fieldBox.FormattingEnabled = True
        Me.fieldBox.Items.AddRange(New Object() {"Department", "Password", "Leave"})
        Me.fieldBox.Location = New System.Drawing.Point(352, 146)
        Me.fieldBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fieldBox.Name = "fieldBox"
        Me.fieldBox.Size = New System.Drawing.Size(176, 24)
        Me.fieldBox.TabIndex = 9
        '
        'update_button
        '
        Me.update_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_button.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.update_button.Image = Global.IITG_LeaveSystem.My.Resources.Resources.edit_user
        Me.update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_button.Location = New System.Drawing.Point(220, 261)
        Me.update_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.update_button.Name = "update_button"
        Me.update_button.Size = New System.Drawing.Size(241, 52)
        Me.update_button.TabIndex = 10
        Me.update_button.Text = "Update"
        Me.update_button.UseMnemonic = False
        Me.update_button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(119, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Enter Value:"
        '
        'val_text
        '
        Me.val_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val_text.Location = New System.Drawing.Point(352, 186)
        Me.val_text.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.val_text.Name = "val_text"
        Me.val_text.Size = New System.Drawing.Size(176, 27)
        Me.val_text.TabIndex = 12
        '
        'userUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(659, 352)
        Me.Controls.Add(Me.val_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.update_button)
        Me.Controls.Add(Me.fieldBox)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.choice_combo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "userUpdate"
        Me.Text = "Update User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents choice_combo As System.Windows.Forms.ComboBox
    Friend WithEvents username_text As System.Windows.Forms.TextBox
    Friend WithEvents fieldBox As System.Windows.Forms.ComboBox
    Friend WithEvents update_button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents val_text As System.Windows.Forms.TextBox
End Class
