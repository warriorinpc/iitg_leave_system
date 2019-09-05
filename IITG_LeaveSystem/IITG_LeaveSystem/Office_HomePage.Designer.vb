<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Office_HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Office_HomePage))
        Me.choice_combo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.loadUser = New System.Windows.Forms.Button()
        Me.heading1 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.approvalButton = New System.Windows.Forms.Button()
        Me.deleteUser = New System.Windows.Forms.Button()
        Me.updateUser = New System.Windows.Forms.Button()
        Me.addUser = New System.Windows.Forms.Button()
        Me.ref_Button = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'choice_combo
        '
        Me.choice_combo.FormattingEnabled = True
        Me.choice_combo.Items.AddRange(New Object() {"Student", "Staff", "Professor", "HOD", "DPPC", "Dean", "Director", "Office"})
        Me.choice_combo.Location = New System.Drawing.Point(268, 62)
        Me.choice_combo.Name = "choice_combo"
        Me.choice_combo.Size = New System.Drawing.Size(176, 24)
        Me.choice_combo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select User Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(268, 92)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(176, 27)
        Me.username_text.TabIndex = 4
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.ForeColor = System.Drawing.Color.PowderBlue
        Me.welcomeLabel.Location = New System.Drawing.Point(25, 20)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(70, 24)
        Me.welcomeLabel.TabIndex = 5
        Me.welcomeLabel.Text = "Label3"
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(28, 141)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(848, 82)
        Me.dgv1.TabIndex = 6
        '
        'loadUser
        '
        Me.loadUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.loadUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadUser.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.loadUser.Location = New System.Drawing.Point(694, 89)
        Me.loadUser.Name = "loadUser"
        Me.loadUser.Size = New System.Drawing.Size(123, 36)
        Me.loadUser.TabIndex = 7
        Me.loadUser.Text = "Load"
        Me.loadUser.UseVisualStyleBackColor = False
        '
        'heading1
        '
        Me.heading1.AutoSize = True
        Me.heading1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heading1.ForeColor = System.Drawing.Color.White
        Me.heading1.Location = New System.Drawing.Point(25, 271)
        Me.heading1.Name = "heading1"
        Me.heading1.Size = New System.Drawing.Size(235, 24)
        Me.heading1.TabIndex = 8
        Me.heading1.Text = "Show Pending Requests :"
        '
        'dgv2
        '
        Me.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.GridColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dgv2.Location = New System.Drawing.Point(28, 298)
        Me.dgv2.MultiSelect = False
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.RowTemplate.Height = 24
        Me.dgv2.Size = New System.Drawing.Size(847, 131)
        Me.dgv2.TabIndex = 9
        '
        'logoutButton
        '
        Me.logoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.logoutButton.Location = New System.Drawing.Point(694, 32)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(123, 38)
        Me.logoutButton.TabIndex = 16
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'DeclineButton
        '
        Me.DeclineButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DeclineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeclineButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeclineButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DeclineButton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.close
        Me.DeclineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeclineButton.Location = New System.Drawing.Point(715, 435)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(146, 43)
        Me.DeclineButton.TabIndex = 15
        Me.DeclineButton.Text = "Decline"
        Me.DeclineButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeclineButton.UseVisualStyleBackColor = False
        '
        'approvalButton
        '
        Me.approvalButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.approvalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.approvalButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approvalButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.approvalButton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.button_round_tick_ok_icon
        Me.approvalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.approvalButton.Location = New System.Drawing.Point(548, 435)
        Me.approvalButton.Name = "approvalButton"
        Me.approvalButton.Size = New System.Drawing.Size(161, 43)
        Me.approvalButton.TabIndex = 14
        Me.approvalButton.Text = "Approve"
        Me.approvalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.approvalButton.UseVisualStyleBackColor = False
        '
        'deleteUser
        '
        Me.deleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteUser.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.deleteUser.Image = Global.IITG_LeaveSystem.My.Resources.Resources.delete_user
        Me.deleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteUser.Location = New System.Drawing.Point(611, 500)
        Me.deleteUser.Name = "deleteUser"
        Me.deleteUser.Size = New System.Drawing.Size(250, 49)
        Me.deleteUser.TabIndex = 13
        Me.deleteUser.Text = "Delete User"
        Me.deleteUser.UseVisualStyleBackColor = False
        '
        'updateUser
        '
        Me.updateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateUser.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.updateUser.Image = Global.IITG_LeaveSystem.My.Resources.Resources.edit_user
        Me.updateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateUser.Location = New System.Drawing.Point(323, 500)
        Me.updateUser.Name = "updateUser"
        Me.updateUser.Size = New System.Drawing.Size(267, 49)
        Me.updateUser.TabIndex = 12
        Me.updateUser.Text = "Update User"
        Me.updateUser.UseVisualStyleBackColor = False
        '
        'addUser
        '
        Me.addUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addUser.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addUser.Image = Global.IITG_LeaveSystem.My.Resources.Resources.user_add
        Me.addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addUser.Location = New System.Drawing.Point(49, 500)
        Me.addUser.Name = "addUser"
        Me.addUser.Size = New System.Drawing.Size(256, 49)
        Me.addUser.TabIndex = 11
        Me.addUser.Text = "Add User"
        Me.addUser.UseVisualStyleBackColor = False
        '
        'ref_Button
        '
        Me.ref_Button.BackColor = System.Drawing.Color.Transparent
        Me.ref_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ref_Button.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ref_Button.Image = Global.IITG_LeaveSystem.My.Resources.Resources.Refresh
        Me.ref_Button.Location = New System.Drawing.Point(734, 229)
        Me.ref_Button.Name = "ref_Button"
        Me.ref_Button.Size = New System.Drawing.Size(83, 63)
        Me.ref_Button.TabIndex = 10
        Me.ref_Button.UseVisualStyleBackColor = False
        '
        'Office_HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 588)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.DeclineButton)
        Me.Controls.Add(Me.approvalButton)
        Me.Controls.Add(Me.deleteUser)
        Me.Controls.Add(Me.updateUser)
        Me.Controls.Add(Me.addUser)
        Me.Controls.Add(Me.ref_Button)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.heading1)
        Me.Controls.Add(Me.loadUser)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.choice_combo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Office_HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office_HomePage"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents choice_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents username_text As System.Windows.Forms.TextBox
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents loadUser As System.Windows.Forms.Button
    Friend WithEvents heading1 As System.Windows.Forms.Label
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents ref_Button As System.Windows.Forms.Button
    Friend WithEvents addUser As System.Windows.Forms.Button
    Friend WithEvents updateUser As System.Windows.Forms.Button
    Friend WithEvents deleteUser As System.Windows.Forms.Button
    Friend WithEvents approvalButton As System.Windows.Forms.Button
    Friend WithEvents DeclineButton As System.Windows.Forms.Button
    Friend WithEvents logoutButton As System.Windows.Forms.Button
End Class
