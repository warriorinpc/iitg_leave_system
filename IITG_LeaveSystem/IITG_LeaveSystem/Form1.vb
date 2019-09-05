Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.Mail

Public Class Form1

    Private Sub ShowPassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCheckBox.CheckedChanged
        'If the check box is checked show the password otherwise hide it, change the colour also
        If (ShowPassCheckBox.Checked = False) Then
            ShowPassCheckBox.ForeColor = Color.White
            PasswordTextBox.PasswordChar = "*"
        Else
            ShowPassCheckBox.ForeColor = Color.FromArgb(78, 184, 206)
            PasswordTextBox.PasswordChar = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        'Base Load
        PasswordTextBox.PasswordChar = "*"
        StudentRadio.Select()
        'Login Button fired on hitting enter
        Me.AcceptButton = LoginButton
        UsernameTextBox.Select()

        'Add event handler of colour changing in all the radio buttons
        Dim radio = GroupBox1.Controls.OfType(Of RadioButton)()
        For Each radiobut In radio
            AddHandler radiobut.CheckedChanged, AddressOf changeHighlight
        Next
        StudentRadio.ForeColor = Color.FromArgb(78, 184, 206)

        Try
            'Make a connection
            Dim projDirectory, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
            Dim query As String
            query = "Select * From Leave;"
            'MessageBox.Show(query)

            'Decline all the leaves that are older than today
            con.Open()
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            Dim Leavid As Integer
            Dim Status As String
            Dim StartDate As Date
            Dim Temp As String
            Dim Toda As Date = Today
            While (reader.Read)
                Leavid = reader.GetInt32(0)
                Temp = reader.GetString(2)
                Status = reader.GetString(10)
                Date.TryParseExact(Temp, New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, StartDate)

                If StartDate <= Toda And Status <> "Deleted" Then
                    query = "update Leave set ApprovalStatus = 'Declined' where LeaveID = " & Leavid & " ;"
                    Dim Command As New OleDbCommand(query, con)
                    Command.ExecuteNonQuery()
                    'MessageBox.Show(Leavid & "  " & Status & " " & StartDate)
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim projDirectory, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

            Dim username As String = UsernameTextBox.Text
            Dim password As String = encrypt(PasswordTextBox.Text)
            Dim query As String = ""
            Dim table As String = GroupBox1.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked).Text

            'Check if a valid user
            query = "Select * From " & table & " Where Username = '" & username & "' And Password = '" & password & "'; "
            'MessageBox.Show(query)

            con.Open()
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While
            con.Close()
            If (count <> 1) Then
                'Error Message
                MessageBox.Show("Username or Password is incorrect!")
                Exit Sub
            End If

            'If a correct user then redirect to different forms
            If StudentRadio.Checked = True Then
                Student_HomePage.Username = username
                Student_HomePage.Show()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Select()
            ElseIf OfficeRadio.Checked = True Then
                Office_HomePage.Username = username
                Office_HomePage.con = con
                Office_HomePage.Show()
            ElseIf StaffRadio.Checked = True Or DirectorRadio.Checked = True Then
                Apply_for_leave.Username = username
                Apply_for_leave.Type = table
                Apply_for_leave.Show()
            Else
                Rest_HomePage.Username = username
                Rest_HomePage.Type = table
                Rest_HomePage.Show()
            End If
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function encrypt(p1 As String) As String
        'Function to find md5 hash to encrypt the password
        Dim bytHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(p1))
        'p1 = Convert.ToBase64String(bytHashedData)
        p1 = ""
        For Each b As Byte In bytHashedData
            p1 += b.ToString("x2")
        Next
        Return p1
    End Function

    Private Sub ForgotButton_Click(sender As Object, e As EventArgs) Handles ForgotButton.Click

        'Get the email id of the user and send an email
        Dim projDirectory, databasePath As String
        projDirectory = Directory.GetCurrentDirectory()
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

        Dim username As String = UsernameTextBox.Text
        Dim query As String = ""
        Dim table As String
        Try
            table = GroupBox1.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked).Text

            If table = "" Then
                MessageBox.Show("Select a type!")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        

        query = "Select Email From " & table & " Where Username = '" & username & "'; "
        'MessageBox.Show(query)

        con.Open()
        Dim cmd As New OleDbCommand(query, con)
        Dim email As String
        Try
            email = cmd.ExecuteScalar.ToString
            'MsgBox(email)
        Catch ex As Exception
            MessageBox.Show("Username is incorrect!")
            Exit Sub
        End Try
        con.Close()

        'Generate a new password
        Dim newPass As String = SuggestPassword()
        Dim num As Integer = 0
        num += SendEmail(email, "Hello! Your new password is " & newPass, "New Password for IITG Leave")

        If num = 0 Then
            MsgBox("Service unavailable: Forgot Password not currently available")
        Else
            newPass = encrypt(newPass)
            query = "Update " & table & " Set [Password] = '" & newPass & "' Where Username = '" & username & "'; "
            'MsgBox(query)
            Try
                con.Open()
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("New password has been sent to your email!!")
        End If

    End Sub

    Function SendEmail(ByVal sendto As String, ByVal message As String, ByVal subject As String)
        'Function to send mail through smtp protocol
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("iitgleave@gmail.com", "abcd@1234")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            'Hard coded sender id
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

    Function SuggestPassword()
        'Function to generate a password, Taken from Password Strength Checker Group Aman
        Dim suggestedPassword As String = ""
        Dim Ch As Integer
        Dim UsableSymbols() As String
        Dim Symbols = "`,~,!,@,#,$,%,^,&,*,(,),_,-,=,+,[,{,],},\,|,;,:,',?,/,.,>,<"
        UsableSymbols = Split(Symbols, ",")
        Dim Sym As Char


        ' Generating complex passwords using Rnd() function and taking length of password is 12

        Randomize()

        For i = 1 To 3
            Ch = Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a"))
            suggestedPassword = suggestedPassword & Chr(Ch)
            Ch = Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0"))
            suggestedPassword = suggestedPassword & Chr(Ch)

            Sym = UsableSymbols(Int(30 * Rnd()))
            suggestedPassword = suggestedPassword & Sym
        Next

        Return suggestedPassword
    End Function

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        UsernameLabel.ForeColor = Color.FromArgb(78, 184, 206)
        PasswordLabel.ForeColor = Color.White
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordLabel.ForeColor = Color.FromArgb(78, 184, 206)
        UsernameLabel.ForeColor = Color.White
    End Sub

    Private Sub changeHighlight(sender As Object, e As EventArgs)
        'MessageBox.Show("Change")
        'Change the colour of Radio Buttons
        Dim radio = GroupBox1.Controls.OfType(Of RadioButton)()
        For Each radiobut In radio
            radiobut.ForeColor = Color.White
        Next
        If sender.Checked = True Then
            sender.ForeColor = Color.FromArgb(78, 184, 206)
        End If
    End Sub

End Class
