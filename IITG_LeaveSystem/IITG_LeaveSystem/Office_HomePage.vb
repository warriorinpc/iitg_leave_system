Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.Mail
Public Class Office_HomePage

    Public Property Username As String
    Public Property con As OleDbConnection


    Private Sub Office_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        welcomeLabel.Text = "Logged in as " & Username
        dgv2.DefaultCellStyle.BackColor = Color.LightCyan
        dgv1.DefaultCellStyle.BackColor = Color.LightCyan
    End Sub

    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        add_User.con = con
        add_User.ShowDialog()


    End Sub

    Private Sub updateUser_Click(sender As Object, e As EventArgs) Handles updateUser.Click
        userUpdate.con = con
        userUpdate.ShowDialog()
    End Sub

    Private Sub deleteUser_Click(sender As Object, e As EventArgs) Handles deleteUser.Click
        userDelete.con = con
        userDelete.ShowDialog()
    End Sub

    Private Sub ref_Button_Click(sender As Object, e As EventArgs) Handles ref_Button.Click
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select * From Leave Where ApprovalStatus = 'office';"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            dgv2.DataSource = dt


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub loadUser_Click(sender As Object, e As EventArgs) Handles loadUser.Click
        If CStr(choice_combo.SelectedItem) = "" Then
            MessageBox.Show("Enter a type first")
            Exit Sub
        End If
        Try
            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select * From " & CStr(choice_combo.SelectedItem) & " Where Username = '" & username_text.Text & "'; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()


            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While
            reader.Close()

            If (count = 1) Then
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                dgv1.DataSource = dt

            Else
                MessageBox.Show("Username does not exist")
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub approvalButton_Click(sender As Object, e As EventArgs) Handles approvalButton.Click
        Dim comment As String
        Dim Leaveid As Integer
        Dim row As Integer
        Try
            row = dgv2.CurrentRow.Index
            Leaveid = dgv2.Item(0, row).Value
        Catch ex As Exception
            MessageBox.Show("Select a leave first")
            Exit Sub
        End Try
        comment = InputBox("Any Comments?", "Comments", "Add Comments here")

        Dim Applicantname As String = ""
        Dim email As String = ""
        Dim table As String = ""
        Try
            con.Open()
            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select Applicant From Leave where LeaveId = " & Leaveid & ";"
            Dim reader As OleDbDataReader = command1.ExecuteReader()
            While (reader.Read)
                Applicantname = reader.GetString(0)
            End While
            reader.Close()
            'MessageBox.Show(Applicantname)

            Dim command3 As OleDbCommand = New OleDbCommand()
            command3.Connection = con
            command3.CommandText = "Select ApplicantType From Leave where LeaveId = " & Leaveid & ";"
            Dim reader3 As OleDbDataReader = command3.ExecuteReader()
            While (reader3.Read)
                table = reader3.GetString(0)
            End While
            reader3.Close()

            If table = "MTech" Or table = "PhD" Then
                table = "Student"
            End If
            'MessageBox.Show(table)

            Dim command2 As OleDbCommand = New OleDbCommand()
            command2.Connection = con
            command2.CommandText = "Select Email From " & table & " where Username = '" & Applicantname & "';"
            'MessageBox.Show(command2.CommandText)
            Dim reader2 As OleDbDataReader = command2.ExecuteReader()
            While (reader2.Read)
                email = reader2.GetString(0)
            End While
            reader2.Close()
            'MessageBox.Show(email)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        'Applicant Type, Name and email, comments are available here.
        Dim Status As String
        If table = "Student" Then
            Status = getDppc(Applicantname)
        ElseIf table = "Professor" Or table = "Staff" Then
            Status = getHOD(Applicantname, table)
        ElseIf table = "HOD" Then
            Status = "dean"
        Else
            Status = "Approved"
        End If

        'Add the status
        Try
            con.Open()
            Dim command As OleDbCommand = New OleDbCommand()
            command.Connection = con
            command.CommandText = "update Leave Set ApprovalStatus = '" & Status & "' where LeaveId = " & Leaveid & ";"
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        'Add the comment
        Try
            con.Open()
            Dim command As OleDbCommand = New OleDbCommand()
            command.Connection = con
            command.CommandText = "update Leave Set CommOffice = '" & comment & "' where LeaveId = " & Leaveid & ";"
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        MessageBox.Show("Leave Approved")
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs) Handles DeclineButton.Click
        Dim comment As String
        Dim Leaveid As Integer
        Dim row As Integer
        Try
            row = dgv2.CurrentRow.Index
            Leaveid = dgv2.Item(0, row).Value
        Catch ex As Exception
            MessageBox.Show("Select a leave first")
            Exit Sub
        End Try
        comment = InputBox("Any Comments?", "Comments", "Add Comments here")

        Try
            con.Open()
            Dim command As OleDbCommand = New OleDbCommand()
            command.Connection = con
            command.CommandText = "update Leave Set ApprovalStatus = 'Declined' where LeaveId = " & Leaveid & ";"
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        Try
            con.Open()
            Dim command As OleDbCommand = New OleDbCommand()
            command.Connection = con
            command.CommandText = "update Leave Set CommOffice = '" & comment & "' where LeaveId = " & Leaveid & ";"
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        Dim Applicantname As String = ""
        Dim email As String = ""
        Dim table As String = ""
        Try
            con.Open()
            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select Applicant From Leave where LeaveId = " & Leaveid & ";"
            Dim reader As OleDbDataReader = command1.ExecuteReader()
            While (reader.Read)
                Applicantname = reader.GetString(0)
            End While
            reader.Close()
            'MessageBox.Show(Applicantname)

            Dim command3 As OleDbCommand = New OleDbCommand()
            command3.Connection = con
            command3.CommandText = "Select ApplicantType From Leave where LeaveId = " & Leaveid & ";"
            Dim reader3 As OleDbDataReader = command3.ExecuteReader()
            While (reader3.Read)
                table = reader3.GetString(0)
            End While
            reader3.Close()

            If table = "MTech" Or table = "PhD" Then
                table = "Student"
            End If
            'MessageBox.Show(table)

            Dim command2 As OleDbCommand = New OleDbCommand()
            command2.Connection = con
            command2.CommandText = "Select Email From " & table & " where Username = '" & Applicantname & "';"
            'MessageBox.Show(command2.CommandText)
            Dim reader2 As OleDbDataReader = command2.ExecuteReader()
            While (reader2.Read)
                email = reader2.GetString(0)
            End While
            reader2.Close()
            'MessageBox.Show(email)
            SendEmail(email, "Your Leave Request no. " & Leaveid & " has been rejected by the office. Kindly take notice.", "Leave Rejected")

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        MessageBox.Show("Leave Rejected")
    End Sub

    Function SendEmail(ByVal sendto As String, ByVal message As String, ByVal subject As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("iitgleave@gmail.com", "abcd@1234")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("iitgleave@gmail.com")
            e_mail.To.Add(sendto)
            e_mail.Subject = subject
            e_mail.IsBodyHtml = False
            e_mail.Body = message
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")
            Return 1
        Catch error_t As Exception
            'MsgBox(error_t.Message)
            Return 0
        End Try
    End Function

    Private Function getDppc(Applicantname As String) As String
        Try
            con.Open()
            Dim department As String = ""
            Dim command2 As OleDbCommand = New OleDbCommand()
            command2.Connection = con
            command2.CommandText = "Select Department From Student where Username = '" & Applicantname & "';"
            'MessageBox.Show(command2.CommandText)
            Dim reader2 As OleDbDataReader = command2.ExecuteReader()
            While (reader2.Read)
                department = reader2.GetString(0)
            End While
            reader2.Close()
            department = department.ToLower()
            Dim dppc As String = "dppc_" & department
            con.Close()
            Return dppc
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Return ""
        End Try
    End Function

    
    Private Function getHOD(Applicantname As String, table As String) As String
        Try
            con.Open()
            Dim department As String = ""
            Dim command2 As OleDbCommand = New OleDbCommand()
            command2.Connection = con
            command2.CommandText = "Select Department From " & table & " where Username = '" & Applicantname & "';"
            'MessageBox.Show(command2.CommandText)
            Dim reader2 As OleDbDataReader = command2.ExecuteReader()
            While (reader2.Read)
                department = reader2.GetString(0)
            End While
            reader2.Close()
            department = department.ToLower()
            Dim hod As String = "hod_" & department
            con.Close()
            Return hod
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Return ""
        End Try
    End Function

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Form1.Show()
        Form1.UsernameTextBox.Select()
        Form1.PasswordTextBox.Clear()
        Me.Close()
    End Sub

    Private Sub choice_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choice_combo.SelectedIndexChanged
        Label1.ForeColor = Color.FromArgb(78, 184, 206)
        Label2.ForeColor = Color.White
    End Sub

    Private Sub username_text_TextChanged(sender As Object, e As EventArgs) Handles username_text.TextChanged
        Label2.ForeColor = Color.FromArgb(78, 184, 206)
        Label1.ForeColor = Color.White
    End Sub

    Private Sub dgv2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseDoubleClick
        Try
            Dim selectedCellCount As Integer = dgv2.GetCellCount(DataGridViewElementStates.Selected)
            If selectedCellCount = 1 Then
                Dim col As Integer = dgv2.CurrentCell.ColumnIndex
                Dim row As Integer = dgv2.CurrentCell.RowIndex
                Dim Leavid As Integer = 0
                Dim Doc As String
                Dim projDirectory, docPath As String
                projDirectory = Directory.GetCurrentDirectory()
                docPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\")
                If col = 11 Then
                    'MessageBox.Show(row)
                    Leavid = dgv2.Item(0, row).Value
                    Doc = docPath & Leavid & ".pdf"
                    'MessageBox.Show(Doc)
                    If File.Exists(Doc) Then
                        System.Diagnostics.Process.Start(Doc)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class