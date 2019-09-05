<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apply_for_leave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Apply_for_leave))
        Me.namelabel = New System.Windows.Forms.Label()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.startdatelabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.positionlabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.applybutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel.ForeColor = System.Drawing.Color.White
        Me.namelabel.Location = New System.Drawing.Point(188, 57)
        Me.namelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(81, 24)
        Me.namelabel.TabIndex = 0
        Me.namelabel.Text = "Name :-"
        '
        'nametextbox
        '
        Me.nametextbox.Location = New System.Drawing.Point(334, 57)
        Me.nametextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.ReadOnly = True
        Me.nametextbox.Size = New System.Drawing.Size(245, 22)
        Me.nametextbox.TabIndex = 1
        '
        'startdatelabel
        '
        Me.startdatelabel.AutoSize = True
        Me.startdatelabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startdatelabel.ForeColor = System.Drawing.Color.White
        Me.startdatelabel.Location = New System.Drawing.Point(188, 170)
        Me.startdatelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.startdatelabel.Name = "startdatelabel"
        Me.startdatelabel.Size = New System.Drawing.Size(118, 24)
        Me.startdatelabel.TabIndex = 2
        Me.startdatelabel.Text = "Start Date :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "End Date :-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(332, 170)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(245, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(332, 226)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(245, 22)
        Me.DateTimePicker2.TabIndex = 5
        '
        'positionlabel
        '
        Me.positionlabel.AutoSize = True
        Me.positionlabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionlabel.ForeColor = System.Drawing.Color.White
        Me.positionlabel.Location = New System.Drawing.Point(388, 118)
        Me.positionlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.positionlabel.Name = "positionlabel"
        Me.positionlabel.Size = New System.Drawing.Size(138, 24)
        Me.positionlabel.TabIndex = 8
        Me.positionlabel.Text = "Position Label"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button2.Image = Global.IITG_LeaveSystem.My.Resources.Resources.close
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(396, 294)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'applybutton
        '
        Me.applybutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.applybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.applybutton.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applybutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.applybutton.Image = Global.IITG_LeaveSystem.My.Resources.Resources.button_round_tick_ok_icon
        Me.applybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.applybutton.Location = New System.Drawing.Point(192, 294)
        Me.applybutton.Margin = New System.Windows.Forms.Padding(4)
        Me.applybutton.Name = "applybutton"
        Me.applybutton.Size = New System.Drawing.Size(176, 44)
        Me.applybutton.TabIndex = 6
        Me.applybutton.Text = "Apply"
        Me.applybutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.applybutton.UseVisualStyleBackColor = False
        '
        'Apply_for_leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 394)
        Me.Controls.Add(Me.positionlabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.applybutton)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startdatelabel)
        Me.Controls.Add(Me.nametextbox)
        Me.Controls.Add(Me.namelabel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Apply_for_leave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apply For Leave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents nametextbox As System.Windows.Forms.TextBox
    Friend WithEvents startdatelabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents applybutton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents positionlabel As System.Windows.Forms.Label
End Class
