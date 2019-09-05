<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userDelete))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.choice_combo = New System.Windows.Forms.ComboBox()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select User Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username:"
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Delete.Image = Global.IITG_LeaveSystem.My.Resources.Resources.delete_user
        Me.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete.Location = New System.Drawing.Point(196, 163)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(225, 52)
        Me.Delete.TabIndex = 9
        Me.Delete.Text = "Delete"
        Me.Delete.UseMnemonic = False
        Me.Delete.UseVisualStyleBackColor = False
        '
        'choice_combo
        '
        Me.choice_combo.FormattingEnabled = True
        Me.choice_combo.Items.AddRange(New Object() {"Student", "Staff", "Professor", "HOD", "DPPC", "Dean", "Director", "Office"})
        Me.choice_combo.Location = New System.Drawing.Point(330, 55)
        Me.choice_combo.Name = "choice_combo"
        Me.choice_combo.Size = New System.Drawing.Size(176, 24)
        Me.choice_combo.TabIndex = 10
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(330, 102)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(176, 27)
        Me.username_text.TabIndex = 11
        '
        'userDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 238)
        Me.Controls.Add(Me.username_text)
        Me.Controls.Add(Me.choice_combo)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "userDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents choice_combo As System.Windows.Forms.ComboBox
    Friend WithEvents username_text As System.Windows.Forms.TextBox
End Class
