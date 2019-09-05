<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ShowPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DirectorRadio = New System.Windows.Forms.RadioButton()
        Me.DeanRadio = New System.Windows.Forms.RadioButton()
        Me.StaffRadio = New System.Windows.Forms.RadioButton()
        Me.HODRadio = New System.Windows.Forms.RadioButton()
        Me.DPPCRadio = New System.Windows.Forms.RadioButton()
        Me.OfficeRadio = New System.Windows.Forms.RadioButton()
        Me.ProfessorRadio = New System.Windows.Forms.RadioButton()
        Me.StudentRadio = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ForgotButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.UsernameLabel.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(169, 153)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(143, 32)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PasswordLabel.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(169, 198)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(133, 32)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(371, 162)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(284, 22)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(371, 207)
        Me.PasswordTextBox.MaxLength = 255
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(284, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'ShowPassCheckBox
        '
        Me.ShowPassCheckBox.AutoSize = True
        Me.ShowPassCheckBox.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCheckBox.ForeColor = System.Drawing.Color.White
        Me.ShowPassCheckBox.Location = New System.Drawing.Point(528, 241)
        Me.ShowPassCheckBox.Name = "ShowPassCheckBox"
        Me.ShowPassCheckBox.Size = New System.Drawing.Size(127, 21)
        Me.ShowPassCheckBox.TabIndex = 4
        Me.ShowPassCheckBox.Text = "Show Password"
        Me.ShowPassCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DirectorRadio)
        Me.GroupBox1.Controls.Add(Me.DeanRadio)
        Me.GroupBox1.Controls.Add(Me.StaffRadio)
        Me.GroupBox1.Controls.Add(Me.HODRadio)
        Me.GroupBox1.Controls.Add(Me.DPPCRadio)
        Me.GroupBox1.Controls.Add(Me.OfficeRadio)
        Me.GroupBox1.Controls.Add(Me.ProfessorRadio)
        Me.GroupBox1.Controls.Add(Me.StudentRadio)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(139, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 84)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'DirectorRadio
        '
        Me.DirectorRadio.AutoSize = True
        Me.DirectorRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectorRadio.Location = New System.Drawing.Point(398, 48)
        Me.DirectorRadio.Name = "DirectorRadio"
        Me.DirectorRadio.Size = New System.Drawing.Size(87, 21)
        Me.DirectorRadio.TabIndex = 7
        Me.DirectorRadio.TabStop = True
        Me.DirectorRadio.Text = "Director"
        Me.DirectorRadio.UseVisualStyleBackColor = True
        '
        'DeanRadio
        '
        Me.DeanRadio.AutoSize = True
        Me.DeanRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeanRadio.Location = New System.Drawing.Point(278, 48)
        Me.DeanRadio.Name = "DeanRadio"
        Me.DeanRadio.Size = New System.Drawing.Size(67, 21)
        Me.DeanRadio.TabIndex = 6
        Me.DeanRadio.TabStop = True
        Me.DeanRadio.Text = "Dean"
        Me.DeanRadio.UseVisualStyleBackColor = True
        '
        'StaffRadio
        '
        Me.StaffRadio.AutoSize = True
        Me.StaffRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffRadio.Location = New System.Drawing.Point(142, 48)
        Me.StaffRadio.Name = "StaffRadio"
        Me.StaffRadio.Size = New System.Drawing.Size(63, 21)
        Me.StaffRadio.TabIndex = 5
        Me.StaffRadio.TabStop = True
        Me.StaffRadio.Text = "Staff"
        Me.StaffRadio.UseVisualStyleBackColor = True
        '
        'HODRadio
        '
        Me.HODRadio.AutoSize = True
        Me.HODRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HODRadio.Location = New System.Drawing.Point(6, 48)
        Me.HODRadio.Name = "HODRadio"
        Me.HODRadio.Size = New System.Drawing.Size(63, 21)
        Me.HODRadio.TabIndex = 4
        Me.HODRadio.TabStop = True
        Me.HODRadio.Text = "HOD"
        Me.HODRadio.UseVisualStyleBackColor = True
        '
        'DPPCRadio
        '
        Me.DPPCRadio.AutoSize = True
        Me.DPPCRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPPCRadio.Location = New System.Drawing.Point(398, 21)
        Me.DPPCRadio.Name = "DPPCRadio"
        Me.DPPCRadio.Size = New System.Drawing.Size(70, 21)
        Me.DPPCRadio.TabIndex = 3
        Me.DPPCRadio.TabStop = True
        Me.DPPCRadio.Text = "DPPC"
        Me.DPPCRadio.UseVisualStyleBackColor = True
        '
        'OfficeRadio
        '
        Me.OfficeRadio.AutoSize = True
        Me.OfficeRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeRadio.Location = New System.Drawing.Point(278, 21)
        Me.OfficeRadio.Name = "OfficeRadio"
        Me.OfficeRadio.Size = New System.Drawing.Size(72, 21)
        Me.OfficeRadio.TabIndex = 2
        Me.OfficeRadio.TabStop = True
        Me.OfficeRadio.Text = "Office"
        Me.OfficeRadio.UseVisualStyleBackColor = True
        '
        'ProfessorRadio
        '
        Me.ProfessorRadio.AutoSize = True
        Me.ProfessorRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfessorRadio.Location = New System.Drawing.Point(142, 21)
        Me.ProfessorRadio.Name = "ProfessorRadio"
        Me.ProfessorRadio.Size = New System.Drawing.Size(99, 21)
        Me.ProfessorRadio.TabIndex = 1
        Me.ProfessorRadio.TabStop = True
        Me.ProfessorRadio.Text = "Professor"
        Me.ProfessorRadio.UseVisualStyleBackColor = True
        '
        'StudentRadio
        '
        Me.StudentRadio.AutoSize = True
        Me.StudentRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentRadio.Location = New System.Drawing.Point(6, 21)
        Me.StudentRadio.Name = "StudentRadio"
        Me.StudentRadio.Size = New System.Drawing.Size(85, 21)
        Me.StudentRadio.TabIndex = 0
        Me.StudentRadio.TabStop = True
        Me.StudentRadio.Text = "Student"
        Me.StudentRadio.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.IITG_LeaveSystem.My.Resources.Resources.password
        Me.PictureBox3.Location = New System.Drawing.Point(139, 198)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IITG_LeaveSystem.My.Resources.Resources.user_icon
        Me.PictureBox2.Location = New System.Drawing.Point(139, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IITG_LeaveSystem.My.Resources.Resources.LeaveSystemIcon
        Me.PictureBox1.Location = New System.Drawing.Point(351, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ForgotButton
        '
        Me.ForgotButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ForgotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForgotButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ForgotButton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.Forgot_Pass
        Me.ForgotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ForgotButton.Location = New System.Drawing.Point(139, 377)
        Me.ForgotButton.Name = "ForgotButton"
        Me.ForgotButton.Size = New System.Drawing.Size(256, 56)
        Me.ForgotButton.TabIndex = 7
        Me.ForgotButton.Text = "Forgot Password"
        Me.ForgotButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ForgotButton.UseVisualStyleBackColor = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LoginButton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.login
        Me.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginButton.Location = New System.Drawing.Point(401, 377)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(254, 56)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 487)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ForgotButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShowPassCheckBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowPassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DirectorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DeanRadio As System.Windows.Forms.RadioButton
    Friend WithEvents StaffRadio As System.Windows.Forms.RadioButton
    Friend WithEvents HODRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DPPCRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OfficeRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ProfessorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents StudentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ForgotButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
