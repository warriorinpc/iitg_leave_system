<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rest_HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rest_HomePage))
        Me.welcomelabel = New System.Windows.Forms.Label()
        Me.usernamelabel = New System.Windows.Forms.Label()
        Me.pendingleavesdgv = New System.Windows.Forms.DataGridView()
        Me.pendinglabel = New System.Windows.Forms.Label()
        Me.loadbutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addcommentbox = New System.Windows.Forms.RichTextBox()
        Me.addcommentbutton = New System.Windows.Forms.Button()
        Me.approvebutton = New System.Windows.Forms.Button()
        Me.denybutton = New System.Windows.Forms.Button()
        Me.commentlabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.applyleavebutton = New System.Windows.Forms.Button()
        Me.departmentlabel = New System.Windows.Forms.Label()
        Me.logoutbutton = New System.Windows.Forms.Button()
        CType(Me.pendingleavesdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcomelabel
        '
        Me.welcomelabel.AutoSize = True
        Me.welcomelabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomelabel.ForeColor = System.Drawing.Color.PowderBlue
        Me.welcomelabel.Location = New System.Drawing.Point(25, 15)
        Me.welcomelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.welcomelabel.Name = "welcomelabel"
        Me.welcomelabel.Size = New System.Drawing.Size(170, 24)
        Me.welcomelabel.TabIndex = 0
        Me.welcomelabel.Text = "welcome message"
        '
        'usernamelabel
        '
        Me.usernamelabel.AutoSize = True
        Me.usernamelabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelabel.ForeColor = System.Drawing.Color.PowderBlue
        Me.usernamelabel.Location = New System.Drawing.Point(25, 49)
        Me.usernamelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usernamelabel.Name = "usernamelabel"
        Me.usernamelabel.Size = New System.Drawing.Size(99, 24)
        Me.usernamelabel.TabIndex = 1
        Me.usernamelabel.Text = "username"
        '
        'pendingleavesdgv
        '
        Me.pendingleavesdgv.AllowUserToAddRows = False
        Me.pendingleavesdgv.AllowUserToDeleteRows = False
        Me.pendingleavesdgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pendingleavesdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pendingleavesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pendingleavesdgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pendingleavesdgv.Location = New System.Drawing.Point(8, 48)
        Me.pendingleavesdgv.Margin = New System.Windows.Forms.Padding(4)
        Me.pendingleavesdgv.MultiSelect = False
        Me.pendingleavesdgv.Name = "pendingleavesdgv"
        Me.pendingleavesdgv.ReadOnly = True
        Me.pendingleavesdgv.Size = New System.Drawing.Size(780, 162)
        Me.pendingleavesdgv.TabIndex = 2
        '
        'pendinglabel
        '
        Me.pendinglabel.AutoSize = True
        Me.pendinglabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendinglabel.ForeColor = System.Drawing.Color.White
        Me.pendinglabel.Location = New System.Drawing.Point(4, 9)
        Me.pendinglabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pendinglabel.Name = "pendinglabel"
        Me.pendinglabel.Size = New System.Drawing.Size(167, 24)
        Me.pendinglabel.TabIndex = 3
        Me.pendinglabel.Text = "Pending Leaves :-"
        '
        'loadbutton
        '
        Me.loadbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.loadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadbutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.loadbutton.Location = New System.Drawing.Point(653, 4)
        Me.loadbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.loadbutton.Name = "loadbutton"
        Me.loadbutton.Size = New System.Drawing.Size(134, 36)
        Me.loadbutton.TabIndex = 4
        Me.loadbutton.Text = "Load"
        Me.loadbutton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.addcommentbox)
        Me.Panel1.Controls.Add(Me.addcommentbutton)
        Me.Panel1.Controls.Add(Me.approvebutton)
        Me.Panel1.Controls.Add(Me.denybutton)
        Me.Panel1.Controls.Add(Me.commentlabel)
        Me.Panel1.Controls.Add(Me.pendinglabel)
        Me.Panel1.Controls.Add(Me.loadbutton)
        Me.Panel1.Controls.Add(Me.pendingleavesdgv)
        Me.Panel1.Location = New System.Drawing.Point(17, 77)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 344)
        Me.Panel1.TabIndex = 5
        '
        'addcommentbox
        '
        Me.addcommentbox.BackColor = System.Drawing.Color.LightCyan
        Me.addcommentbox.Location = New System.Drawing.Point(8, 274)
        Me.addcommentbox.Margin = New System.Windows.Forms.Padding(4)
        Me.addcommentbox.Name = "addcommentbox"
        Me.addcommentbox.Size = New System.Drawing.Size(779, 52)
        Me.addcommentbox.TabIndex = 10
        Me.addcommentbox.Text = ""
        '
        'addcommentbutton
        '
        Me.addcommentbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.addcommentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addcommentbutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcommentbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.addcommentbutton.Location = New System.Drawing.Point(307, 229)
        Me.addcommentbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.addcommentbutton.Name = "addcommentbutton"
        Me.addcommentbutton.Size = New System.Drawing.Size(175, 40)
        Me.addcommentbutton.TabIndex = 9
        Me.addcommentbutton.Text = "Add Comment"
        Me.addcommentbutton.UseVisualStyleBackColor = False
        '
        'approvebutton
        '
        Me.approvebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.approvebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.approvebutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approvebutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.approvebutton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.button_round_tick_ok_icon
        Me.approvebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.approvebutton.Location = New System.Drawing.Point(489, 229)
        Me.approvebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.approvebutton.Name = "approvebutton"
        Me.approvebutton.Size = New System.Drawing.Size(155, 40)
        Me.approvebutton.TabIndex = 8
        Me.approvebutton.Text = "Approve"
        Me.approvebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.approvebutton.UseVisualStyleBackColor = False
        '
        'denybutton
        '
        Me.denybutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.denybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.denybutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.denybutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.denybutton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.close
        Me.denybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.denybutton.Location = New System.Drawing.Point(653, 229)
        Me.denybutton.Margin = New System.Windows.Forms.Padding(4)
        Me.denybutton.Name = "denybutton"
        Me.denybutton.Size = New System.Drawing.Size(135, 40)
        Me.denybutton.TabIndex = 7
        Me.denybutton.Text = "Deny"
        Me.denybutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.denybutton.UseVisualStyleBackColor = False
        '
        'commentlabel
        '
        Me.commentlabel.AutoSize = True
        Me.commentlabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentlabel.ForeColor = System.Drawing.Color.White
        Me.commentlabel.Location = New System.Drawing.Point(8, 246)
        Me.commentlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.commentlabel.Name = "commentlabel"
        Me.commentlabel.Size = New System.Drawing.Size(126, 24)
        Me.commentlabel.TabIndex = 0
        Me.commentlabel.Text = "Comments :-"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.applyleavebutton)
        Me.Panel2.Location = New System.Drawing.Point(17, 429)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(565, 61)
        Me.Panel2.TabIndex = 6
        '
        'applyleavebutton
        '
        Me.applyleavebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.applyleavebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.applyleavebutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyleavebutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.applyleavebutton.Location = New System.Drawing.Point(324, 4)
        Me.applyleavebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.applyleavebutton.Name = "applyleavebutton"
        Me.applyleavebutton.Size = New System.Drawing.Size(237, 53)
        Me.applyleavebutton.TabIndex = 0
        Me.applyleavebutton.Text = "Apply For Leave"
        Me.applyleavebutton.UseVisualStyleBackColor = False
        '
        'departmentlabel
        '
        Me.departmentlabel.AutoSize = True
        Me.departmentlabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentlabel.ForeColor = System.Drawing.Color.PowderBlue
        Me.departmentlabel.Location = New System.Drawing.Point(647, 49)
        Me.departmentlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.departmentlabel.Name = "departmentlabel"
        Me.departmentlabel.Size = New System.Drawing.Size(157, 24)
        Me.departmentlabel.TabIndex = 1
        Me.departmentlabel.Text = "departmentlabel"
        '
        'logoutbutton
        '
        Me.logoutbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbutton.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.logoutbutton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.logout
        Me.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutbutton.Location = New System.Drawing.Point(587, 433)
        Me.logoutbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.logoutbutton.Name = "logoutbutton"
        Me.logoutbutton.Size = New System.Drawing.Size(218, 53)
        Me.logoutbutton.TabIndex = 1
        Me.logoutbutton.Text = "LOG OUT"
        Me.logoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.logoutbutton.UseVisualStyleBackColor = False
        '
        'Rest_HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 503)
        Me.Controls.Add(Me.logoutbutton)
        Me.Controls.Add(Me.departmentlabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamelabel)
        Me.Controls.Add(Me.welcomelabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Rest_HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rest_HomePage"
        CType(Me.pendingleavesdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents welcomelabel As System.Windows.Forms.Label
    Friend WithEvents usernamelabel As System.Windows.Forms.Label
    Friend WithEvents pendingleavesdgv As System.Windows.Forms.DataGridView
    Friend WithEvents pendinglabel As System.Windows.Forms.Label
    Friend WithEvents loadbutton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents commentlabel As System.Windows.Forms.Label
    Friend WithEvents applyleavebutton As System.Windows.Forms.Button
    Friend WithEvents departmentlabel As System.Windows.Forms.Label
    Friend WithEvents logoutbutton As System.Windows.Forms.Button
    Friend WithEvents addcommentbutton As System.Windows.Forms.Button
    Friend WithEvents approvebutton As System.Windows.Forms.Button
    Friend WithEvents denybutton As System.Windows.Forms.Button
    Friend WithEvents addcommentbox As System.Windows.Forms.RichTextBox
End Class
