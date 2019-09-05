'Importing necessary files
Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class Student_HomePage
    'Declaring Global Variables to be used in multiple modules
    Dim connection As OleDbConnection
    Public Property Username As String  'Declaring Username as public property so that it can be set by login form
    Dim firstname As String
    Dim lastname As String
    Dim MedicalLeaves As Integer        'ML Leave LEFT
    Dim OrdinaryLeaves As Integer       'OL Leaves LEFT
    Dim AcademicLeaves As Integer       'AL Leaves LEFT
    Dim ParentalLeaves As Integer       'PL Leaves LEFT
    Dim Course As String                    'PHD/MTech
    Dim roll_number As String
    Dim phone_number As String
    Dim email As String
    Dim department As String
    Dim address As String
    Dim emergency_contact As String
    Dim gender As String
    Dim password As String
    Dim calander_year As Date           'End Date for Current Semester
    Dim DocumentFilePath As String
    Dim extendleaveid As Integer
    Dim ExtendDocumentFilePath As String

    Private Sub Student_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Timer1.Start()                  'Timer for clock display
        ExtendOuterPanel.Hide()         'Hiding non-required panels
        Dim projDirectory, destinationPath, databasePath As String
        'ExtendLeaveInstructionTextBox.ForeColor = Color.Red
        projDirectory = Directory.GetCurrentDirectory()         'Current Directory Path
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")    'Path to MS Access database file stored in S/W folder
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")    'Path to background image folder
        Try
            connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")   'Initialising connection to database
            connection.Open()   'Opening Connection to Database
            Dim query As String
            Dim command As New OleDbCommand
            command.Connection = connection     'Making Query to database to get various info regarding student logged in
            query = "Select FirstName From Student Where Username = '" & Username & "'; "   'Pulling First Name 
            command.CommandText = query
            firstname = command.ExecuteScalar.ToString
            query = "Select LastName From Student Where Username = '" & Username & "'; "    'Pulling Last Name
            command.CommandText = query
            lastname = command.ExecuteScalar.ToString
            query = "Select Phone From Student Where Username = '" & Username & "'; "       'Pulling Contact Number
            command.CommandText = query
            phone_number = command.ExecuteScalar.ToString
            query = "Select Email From Student Where Username = '" & Username & "'; "       'Pulling Email ID
            command.CommandText = query
            email = command.ExecuteScalar.ToString
            query = "Select Department From Student Where Username = '" & Username & "'; "      'Pulling Department
            command.CommandText = query
            department = command.ExecuteScalar.ToString
            query = "Select Address From Student Where Username = '" & Username & "'; "         'Pulling Address
            command.CommandText = query
            address = command.ExecuteScalar.ToString
            query = "Select EmergencyContactNo From Student Where Username = '" & Username & "'; "      'Pulling Emergency Contact no.
            command.CommandText = query
            emergency_contact = command.ExecuteScalar.ToString
            query = "Select Gender From Student Where Username = '" & Username & "'; "      'Pulling Gender
            command.CommandText = query
            gender = command.ExecuteScalar.ToString
            query = "Select MedicalLeaves From Student Where Username = '" & Username & "'; "       'Pulling Medical Leaves LEFT
            command.CommandText = query
            MedicalLeaves = command.ExecuteScalar.ToString
            query = "Select OrdinaryLeaves From Student Where Username = '" & Username & "'; "      'Pulling Ordinary Leaves LEFT
            command.CommandText = query
            OrdinaryLeaves = command.ExecuteScalar.ToString
            query = "Select AcademicLeaves From Student Where Username = '" & Username & "'; "      'Pulling Academic Leaves LEFT
            command.CommandText = query
            AcademicLeaves = command.ExecuteScalar.ToString
            query = "Select ParentalLeaves From Student Where Username = '" & Username & "'; "      'Pulling Paternal Leaves LEFT in case of PHD
            command.CommandText = query
            ParentalLeaves = command.ExecuteScalar.ToString
            query = "Select Course From Student Where Username = '" & Username & "'; "          'Pulling Course
            command.CommandText = query
            Course = command.ExecuteScalar.ToString
            query = "Select RollNumber From Student Where Username = '" & Username & "'; "      'Pulling Roll Number
            command.CommandText = query
            roll_number = command.ExecuteScalar.ToString
            query = "Select Password From Student Where Username = '" & Username & "'; "            'Pulling Encrypted Password
            command.CommandText = query
            password = command.ExecuteScalar.ToString
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)      'IF exception occurs throw a exception message
        End Try
        calander_year = #6/1/2019#  'Last date for current semester
        'MsgBox(calander_year)
        If Course = "MTech" Then        'IF Mtech No need to show Paternal Leaves
            NAParentalLeavesLabel.Hide()
        End If
        'Updating Labels with appropriate text
        NAOrdinaryleavesLabel.Text = "Ordinary Leaves Remaining: " & OrdinaryLeaves
        NAAcademicLeavesLabel.Text = "Academic Leaves Remaining: " & AcademicLeaves
        NAMedicalLeavesLabel.Text = "Medical Leaves Remaining: " & MedicalLeaves
        NAParentalLeavesLabel.Text = "Parental Leaves Remaining: " & ParentalLeaves
        'If Leaves < 0 Then Show them with red fore color as a warning
        If OrdinaryLeaves < 0 Then
            NAOrdinaryleavesLabel.ForeColor = Color.Red
        End If
        If AcademicLeaves < 0 Then
            NAAcademicLeavesLabel.ForeColor = Color.Red
        End If
        If MedicalLeaves < 0 Then
            NAMedicalLeavesLabel.ForeColor = Color.Red
        End If
        If ParentalLeaves < 0 Then
            NAParentalLeavesLabel.ForeColor = Color.Red
        End If
        UsernameLabel.Text = "Welcome: " & Username     'Updating Labels with appropriate text
        DocumentFilePath = ""
        NAGroupBox.Hide()   'Hide NA groupbox at the beginning
        ProfilePanel.Hide() 'Hiding non-required Panels
        ProfilePasswordChangePanel.Hide()   'Hiding non-required Panels
        OldButton.PerformClick()    'Old Panel is shown by default on LOGIN
        NALeaveTypeComboBox.Items.Clear()   'Clearing Items in new application leave type combo box
        'Setting New Application Variables
        NAFirstnameTextBox.Text = firstname
        NALastNameTextBox.Text = lastname
        'Setting Profile Page Variables
        ProfileFirstNameTextBox.Text = firstname
        ProfileLastNameTextBox.Text = lastname
        ProfileUserNameTextBox.Text = Username
        ProfileRollNumberTextBox.Text = roll_number
        ProfileDepartmentTextBox.Text = department
        ProfileGenderTextBox.Text = gender
        ProfileEmailTextBox.Text = email
        ProfileAddressTextBox.Text = address
        ProfileContactNumberTextBox.Text = phone_number
        ProfileEmergencyContactNumberTextBox.Text = emergency_contact
        'Setting Profile Pic
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "ProfilePic\" & Username & ".jpeg")  'Profile PIC of user stored as 'username.jpeg'
        If IO.File.Exists(destinationPath) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(destinationPath, IO.FileMode.Open, IO.FileAccess.Read)
            ProfilePictureBox.Image = System.Drawing.Image.FromStream(fs)
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            fs.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click 'LOGOUT
        Form1.Show()
        Form1.UsernameTextBox.Select()
        Me.Close()
    End Sub


    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click   'PROFILE BUTTON CLICK
        'Hiding and showing appropriate panels and groupboxes
        NAGroupBox.Hide()
        OldPanel.Hide()
        ProfilePanel.Show()
        'Disabling required textboxes and buttons until some specific event
        ProfileAddressTextBox.Enabled = False
        ProfileContactNumberTextBox.Enabled = False
        ProfileEmergencyContactNumberTextBox.Enabled = False
        ProfileSaveProfileButton.Enabled = False
        ProfileEditButton.Enabled = True
    End Sub

    Private Sub NAButton_Click(sender As Object, e As EventArgs) Handles NAButton.Click 'NEW APPLICATION BUTTON CLICK
        'Hiding and showing appropriate panels and groupboxes
        ProfilePanel.Hide()
        OldPanel.Hide()
        ProfilePasswordChangePanel.Hide()
        NAGroupBox.Show()
        NAInstructionTextBox.Text = "pdf only"  'Filling textboxes with appropriate content
        DocumentFilePath = ""   'Initialising Document file path to NULL 
        NAInstructionTextBox.ForeColor = Color.Red  'Changing fore color to red for shown textbox
        'Clearing items in both LeaveType and SuperVisor comboboxes
        NALeaveTypeComboBox.Items.Clear()
        NASupervisorComboBox.Items.Clear()
        'Setting leave type based upon Course
        If Course = "PhD" Then      'PhD
            NALeaveTypeComboBox.Items.Add("Ordinary Leave")
            NALeaveTypeComboBox.Items.Add("Academic Leave")
            NALeaveTypeComboBox.Items.Add("Medical Leave")
            NALeaveTypeComboBox.Items.Add("Paternal Leave")
        Else    'MTech
            NALeaveTypeComboBox.Items.Add("Ordinary Leave")
            NALeaveTypeComboBox.Items.Add("Academic Leave")
            NALeaveTypeComboBox.Items.Add("Medical Leave")
        End If
        Try
            connection.Open()       'Opening Connection
            Dim command As New OleDbCommand
            command.Connection = connection
            Dim query As String
            'Dim firstname, lastname As String
            query = "Select * from Professor Where Department = '" & department & "';"  'selecting all professors of same department as USER
            command.CommandText = query
            Dim reader As OleDbDataReader
            reader = command.ExecuteReader
            Dim usernameprof As String
            While (reader.Read())
                usernameprof = reader.GetString(0)
                NASupervisorComboBox.Items.Add(usernameprof)    'Adding appropriate professors to combobox
            End While
            connection.Close()      'Closing Connection
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OldButton_Click(sender As Object, e As EventArgs) Handles OldButton.Click       'OLD APPLICATIONS BUTTON CLICK
        'Hiding and showing appropriate panels and groupboxes
        NAGroupBox.Hide()
        ProfilePanel.Hide()
        ProfilePasswordChangePanel.Hide()
        OldPanel.Show()
        'Clearing items in past and upcoming/ongoing listbox
        OldPastLeaveListBox.Items.Clear()
        OldUpcomingLeaveListBox.Items.Clear()
        OldCommentsListBox.Items.Clear()
        Try
            connection.Open()   'Opening Connection to database
            Dim command As New OleDbCommand
            command.Connection = connection
            Dim query As String
            query = "Select * From Leave Where Applicant = '" & Username & "'; "    'Selecting all leaves where applicant is USER
            command.CommandText = query
            Dim reader As OleDbDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                'Getting required fields
                Dim LeaveID As Integer = reader.GetInt32(0)
                Dim Type As String = reader.GetString(1)
                Dim StartDate As Date
                Date.TryParseExact(reader.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, StartDate)    'Parsing
                Dim EndDate As Date
                Date.TryParseExact(reader.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, EndDate)  'Parsing
                Dim ApprovalStatus As String = reader.GetString(10)
                Dim currentdate As Date = Date.Today
                Dim data As String
                data = "LeaveID: " & LeaveID & " Type: " & Type & " StartDate: " & StartDate & " EndDate: " & EndDate & " Approval Status: " & ApprovalStatus
                If currentdate > EndDate Then
                    OldPastLeaveListBox.Items.Add(data) 'Adding to OLD Leaves box
                Else
                    OldUpcomingLeaveListBox.Items.Add(data) 'Adding to Upcoming/Ongoing Leaves box
                End If
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProfileEditButton_Click(sender As Object, e As EventArgs) Handles ProfileEditButton.Click   'Profile EDIT Button Click
        'Enabling appropriate textboxes for editing
        ProfileAddressTextBox.Enabled = True
        ProfileContactNumberTextBox.Enabled = True
        ProfileEmergencyContactNumberTextBox.Enabled = True
        ProfileSaveProfileButton.Enabled = True
        ProfileEditButton.Enabled = False
    End Sub


    Private Sub ProfileSaveProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileSaveProfileButton.Click 'PROFILE SAVE Button Click
        'Declaring Variables
        Dim contact_temp As String
        Dim emergency_contact_temp As String
        Dim address_temp As String
        'Initialising with textboxes data
        contact_temp = ProfileContactNumberTextBox.Text
        emergency_contact_temp = ProfileEmergencyContactNumberTextBox.Text
        address_temp = ProfileAddressTextBox.Text
        Dim flag As Boolean 'Indicates whether data is valid or not
        flag = True 'Initialising to TRUE
        If Len(contact_temp) <> 10 Then 'Checking length of contact number (Mobile Number)
            flag = False    'Updating Flag
            MessageBox.Show("Please Enter a valid Contact Number", "Error")     'Showing error and exiting
            ProfileContactNumberTextBox.Text = ""   'Clearing wrong data in textbox
        End If
        If Len(emergency_contact_temp) <> 10 And flag = True Then   'Checking length of Emergency contact number (Mobile Number)
            flag = False    'Updating Flag
            MessageBox.Show("Please Enter a valid Emergency Contact Number", "Error")   'Showing error and exiting
            ProfileEmergencyContactNumberTextBox.Text = ""  'Clearing wrong data in textbox
        End If
        If IsNumeric(contact_temp) = False And flag = True Then     'Checking whether contact number is numeric or not
            flag = False    'Updating Flag
            MessageBox.Show("Please Enter a valid Contact Number", "Error") 'Showing error and exiting
            ProfileContactNumberTextBox.Text = ""   'Clearing wrong data in textbox
        End If
        If IsNumeric(emergency_contact_temp) = False And flag = True Then   'Checking whether contact number is numeric or not
            flag = False    'Updating Flag
            MessageBox.Show("Please Enter a valid Emergency Contact Number", "Error")   'Showing error and exiting
            ProfileEmergencyContactNumberTextBox.Text = ""  'Clearing wrong data in textbox
        End If
        If flag = True And address_temp = "" Then   'Checking if address is provided or not
            flag = False    'Updating Flag
            MessageBox.Show("Please Enter Address", "Error")    'Showing error and exiting
        End If
        If flag = True Then 'If Data is valid
            'Save to database for that student
            Try
                connection.Open()   'Opening Connection
                Dim query As String
                query = "Update Student Set [Phone] = '" & contact_temp & "' Where Username = '" & Username & "'; " 'Updating Phone number
                Dim command As New OleDbCommand
                command.Connection = connection
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                command.Connection = connection
                query = "Update Student Set [Address] = '" & address_temp & "' Where Username = '" & Username & "'; "   'Updating Address
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                command.Connection = connection
                query = "Update Student Set [EmergencyContactNo] = '" & emergency_contact_temp & "' Where Username = '" & Username & "'; "  'Updating Emergency Contact number
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                connection.Close()  'Closing Connection
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Enable/Disable
            'Disabling and enabling appropriate textboxes and buttons
            ProfileSaveProfileButton.Enabled = False
            ProfileAddressTextBox.Enabled = False
            ProfileContactNumberTextBox.Enabled = False
            ProfileEmergencyContactNumberTextBox.Enabled = False
            ProfileEditButton.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ProfileImageChangeButton.Click  'Chenge Profile Picture Button Clicked
        'Variable Declaration
        Dim filepath As String  'Source Path for IMAGE file
        filepath = ""
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory() 'Current directory path
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "ProfilePic\" & Username & ".jpeg")  'Destination path
        'Taking the Source file 
        If ProfileOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = ProfileOpenFileDialog.FileName
        End If

        If filepath <> "" Then  'If its a valid file
            If IO.File.Exists(filepath) Then    'If file exists
                ProfilePictureBox.Image = Nothing
                File.Delete(destinationPath)
                File.Copy(filepath, destinationPath)
                'Do necessary refresh
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(destinationPath, IO.FileMode.Open, IO.FileAccess.Read)
                ProfilePictureBox.Image = System.Drawing.Image.FromStream(fs)
                ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                fs.Close()
                MessageBox.Show("Profile Image Updated", "Success")
            Else
                MessageBox.Show("File Does Not Exist", "Error")
            End If
        Else
            MessageBox.Show("Image File not provided", "Error")
        End If

    End Sub

    Private Sub ProfileChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ProfileChangePasswordButton.Click   'Change Password Button Clicked
        'Hiding and showing appropriate panels and groupboxes
        ProfilePasswordChangePanel.Show()
        ProfilePanel.Hide()
        'Clearing any data in textboxes in the panel
        ProfileOldPasswordTextBox.Text = ""
        ProfileNewPasswordTextBox.Text = ""
        ProfileConfirmNewPasswordTextBox.Text = ""
        'Disabling all the navigation tabs
        OldButton.Enabled = False
        ProfileButton.Enabled = False
        NAButton.Enabled = False
        'Setting Password char as '*'
        ProfileOldPasswordTextBox.PasswordChar = "*"
        ProfileNewPasswordTextBox.PasswordChar = "*"
        ProfileConfirmNewPasswordTextBox.PasswordChar = "*"
    End Sub

    Private Function encrypt(p1 As String) As String    'Encrypt Function based on md5 for encrypting user password
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

    Private Sub NAUploadButton_Click(sender As Object, e As EventArgs) Handles NAUploadButton.Click     'New Application Document upload button Click
        'Variable Declaration
        Dim label = NAInnerPanel.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        NADocumentsLabel.ForeColor = Color.FromArgb(78, 184, 206)
        Dim filepath As String
        filepath = ""
        'Taking the Source file 
        If NAOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = NAOpenFileDialog.FileName
        End If
        DocumentFilePath = filepath
        If DocumentFilePath <> "" Then
            NAInstructionTextBox.Text = DocumentFilePath
            NAInstructionTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub NAApplyButton_Click(sender As Object, e As EventArgs) Handles NAApplyButton.Click   'New Application apply button Click Event
        'Declaring Variables
        Dim startdate As Date
        Dim lastdate As Date
        Dim supervisor As String
        supervisor = NASupervisorComboBox.Text  'Taking value from combobox
        If supervisor = "" Then
            MessageBox.Show("No SuperVisor Selected", "Error")  'Show error and exit
            Exit Sub
        End If
        Dim appliedflag As Boolean = False  'Flag to indicate whether leave is applied or not
        startdate = NAStartDate.Text    'taking value from datetimepicker
        lastdate = NALastDate.Text       'taking value from datetimepicker
        'MsgBox(startdate)
        Dim currentdate As Date
        currentdate = Date.Today    'Storing current date for validation
        Dim flag As Boolean             'Flag for validation of leave application
        flag = True     'Initialising to true
        If startdate <= currentdate Then            'Start date should be greater than current date
            MessageBox.Show("Start Date should be greater than today's date", "Error")  'Show error and update flag -> application rejected
            flag = False
        End If
        If lastdate < startdate And flag = True Then        'Last date should be greater than equal to start date
            MessageBox.Show("Last Date can't be less than Start Date", "Error") 'Show error and update flag -> application rejected
            flag = False
        End If
        If lastdate > calander_year And flag = True Then        'Application period should belong to current semester only
            MessageBox.Show("Leave spans Out of Calander Year", "Error")        'Show error and update flag -> application rejected
            flag = False
        End If
        'Checking for Overlapping Leaves
        Try
            connection.Open()   'Opening Connection
            Dim command1 As New OleDbCommand
            command1.Connection = connection
            Dim query1 As String
            query1 = "Select * From Leave Where Applicant = '" & Username & "'; "   'Selecting all leaves where applicant in USER
            command1.CommandText = query1
            Dim reader1 As OleDbDataReader
            reader1 = command1.ExecuteReader
            While (reader1.Read() And flag)
                'Pulling start date, last date, and leave id
                Dim stringtemp As String
                stringtemp = reader1.GetString(10)
                Dim lastdatetemp As Date
                Dim leaveidtemp As Integer = reader1.GetInt32(0)
                Date.TryParseExact(reader1.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, lastdatetemp)    'Parsing
                Dim startdatetemp As Date
                Date.TryParseExact(reader1.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdatetemp)   'Parsing
                If ((startdate <= lastdatetemp And startdate >= startdatetemp) Or (lastdate >= startdatetemp And lastdate <= lastdatetemp) Or (startdate <= startdatetemp And lastdate >= lastdatetemp)) And stringtemp <> "Declined" Then
                    MessageBox.Show("There is already an applied overlapping leave with LeaveID " & leaveidtemp, "Error")   'Show Error for overlapping leave and update flag -> leave rejected
                    flag = False
                End If
            End While
            connection.Close() 'Closing connection
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim leavetype As String
        Dim days As Integer
        days = lastdate.Subtract(startdate).Days + 1    'Calculating number of days
        leavetype = NALeaveTypeComboBox.Text
        Dim flag2 As Boolean    'Flag2 for indicating whether there is a document upload
        flag2 = False
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory()
        If DocumentFilePath <> "" Then  'if file path is not NULL
            If IO.File.Exists(DocumentFilePath) Then    'IF file exists
                flag2 = True    'Update flag2
            End If

        End If

        Try
            connection.Open()   'Opening Connection
            Dim command As New OleDbCommand
            command.Connection = connection
            Dim query As String
            Dim startdatefinal As String = startdate.ToString("dd-MM-yyyy") 'Formatting start date to appropriate format
            'MsgBox(startdatefinal)
            Dim lastdatefinal As String = lastdate.ToString("dd-MM-yyyy")   'Formatting last date to appropriate format
            If flag = True Then     'If application is valid uptill now
                If leavetype = "Ordinary Leave" Then        'FOR ORDINARY LEAVE
                    'Variables Declaration
                    Dim totaldays As Integer = days
                    Dim count As Integer = 0
                    Dim leaveid1, leaveid2 As Integer
                    Dim command2 As New OleDbCommand
                    command2.Connection = connection
                    Dim query2 As String
                    query2 = "Select * From Leave Where Type = 'OL' and Applicant = '" & Username & "'; "   'Pulling all the Ordinary Leaves  where applicant is USER
                    Dim reader2 As OleDbDataReader
                    command2.CommandText = query2
                    reader2 = command2.ExecuteReader
                    Dim startdatetemp, lastdatetemp As Date
                    While (reader2.Read() And flag)
                        Date.TryParseExact(reader2.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdatetemp)   'Parsing
                        Date.TryParseExact(reader2.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, lastdatetemp)    'Parsing
                        Dim dayscount As Integer = lastdatetemp.Subtract(startdatetemp).Days + 1
                        Dim leaveidtemp As Integer = reader2.GetInt32(0)
                        Dim approvalstatus As String = reader2.GetString(10)
                        If (startdate.Subtract(lastdatetemp).Days = 1 Or startdatetemp.Subtract(lastdate).Days = 1) And approvalstatus <> "Declined" Then   'Checking total days > 5 conidtion for OL
                            count = count + 1
                            totaldays = totaldays + dayscount
                            If count = 1 Then
                                leaveid1 = leaveidtemp
                            End If
                            If count = 2 Then
                                leaveid2 = leaveidtemp
                            End If
                        End If
                    End While
                    If totaldays > 5 Then   'Concatenation with upcoming/ongoing leaves lead to total days > 5
                        flag = False    'Updating flag
                        If count = 0 Then
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days", "Error")
                        End If
                        If count = 1 Then   'CONCATENATION WITH 1 LEAVE FOUND
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days (Concatenating with Upcoming Leave with ID: ) " & leaveid1, "Error")
                        ElseIf count = 2 Then   'CONCATENATION WITH 2 LEAVE FOUND
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days (Concatenating with Upcoming Leave with IDs: ) " & leaveid1 & " and" & leaveid2, "Error")
                        End If
                    End If
                    If days > 5 And flag = True Then

                        MessageBox.Show("Ordinary Leaves can't span more than 5 days", "Error")
                        flag = False
                    ElseIf flag = True Then
                        If OrdinaryLeaves > days Then
                            'Successful Application
                            query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('OL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                                Dim LeaveID As Integer
                                command.Connection = connection
                                query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                                command.CommandText = query
                                LeaveID = Val(command.ExecuteScalar.ToString)
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(DocumentFilePath, destinationPath)
                            End If
                            appliedflag = True

                        Else
                            'Warning for fine
                            Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                            'CODE
                            If ans = DialogResult.Yes Then
                                query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('OL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                                command.CommandText = query
                                command.ExecuteNonQuery()
                                command.Dispose()
                                If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                                    Dim LeaveID As Integer
                                    command.Connection = connection
                                    query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                                    command.CommandText = query
                                    LeaveID = Val(command.ExecuteScalar.ToString)
                                    destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                    If IO.File.Exists(destinationPath) Then
                                        File.Delete(destinationPath)
                                    End If
                                    File.Copy(DocumentFilePath, destinationPath)
                                End If
                                appliedflag = True
                            End If
                        End If
                    End If
                ElseIf leavetype = "Academic Leave" Then    'FOR ACADEMIC LEAVE
                    If AcademicLeaves > days Then
                        'Successful Application
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('AL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                            command.Connection = connection
                            command.CommandText = query
                            Dim temp As String
                            temp = command.ExecuteScalar.ToString
                            LeaveID = Val(temp)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('AL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                                Dim LeaveID As Integer
                                command.Connection = connection
                                query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                                command.Connection = connection
                                command.CommandText = query
                                Dim temp As String
                                temp = command.ExecuteScalar.ToString
                                LeaveID = Val(temp)
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(DocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                ElseIf leavetype = "Medical Leave" Then
                    If MedicalLeaves > days Then
                        'Successful Application
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('ML', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                            command.CommandText = query
                            LeaveID = Val(command.ExecuteScalar.ToString)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('ML', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                                Dim LeaveID As Integer
                                command.Connection = connection
                                query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                                command.CommandText = query
                                LeaveID = Val(command.ExecuteScalar.ToString)
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(DocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                ElseIf leavetype = "Paternal Leave" Then
                    If ParentalLeaves > days Then
                        'Successful Application
                        query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('PL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                            Dim LeaveID As Integer
                            command.Connection = connection
                            query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                            command.CommandText = query
                            LeaveID = Val(command.ExecuteScalar.ToString)
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(DocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "INSERT INTO Leave (Type, StartDate, EndDate, Document, Applicant, isExtension, ApplicantType, ApprovalStatus, SuperVisor) VALUES ('PL', '" & startdatefinal & "', '" & lastdatefinal & "', '" & DocumentFilePath & "', '" & Username & "', 'No', '" & Course & "', '" & supervisor & "', '" & supervisor & "'); "
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then    'IF DOCUMENTS WERE UPLOADED
                                Dim LeaveID As Integer
                                command.Connection = connection
                                query = "Select LeaveID From Leave Where Applicant = '" & Username & "' And EndDate = '" & lastdatefinal & "'; "
                                command.CommandText = query
                                LeaveID = Val(command.ExecuteScalar.ToString)
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(DocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                Else
                    MessageBox.Show("Leave type not selected", "Error")    'If leave type was not selected
                    flag = False
                End If
            End If
            If appliedflag = True Then  'If leave was applied
                MessageBox.Show("Successfully Applied", "New Leave Application")
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProfilePasswordCancelButton_Click(sender As Object, e As EventArgs) Handles ProfilePasswordCancelButton.Click   'Password change Cancel Button Click
        'Clearing textboxes
        ProfileOldPasswordTextBox.Text = ""
        ProfileNewPasswordTextBox.Text = ""
        ProfileConfirmNewPasswordTextBox.Text = ""
        ProfilePasswordCheckBox.Checked = False
        ProfilePasswordChangePanel.Hide()
        OldButton.Enabled = True
        ProfileButton.Enabled = True
        NAButton.Enabled = True
        ProfilePanel.Show()
    End Sub

    Private Sub ProfilePasswordCheckBox_CheckedChanged_1(sender As Object, e As EventArgs) Handles ProfilePasswordCheckBox.CheckedChanged   'Password show Check 
        If (ProfilePasswordCheckBox.Checked = False) Then
            ProfilePasswordCheckBox.ForeColor = Color.White
            ProfileOldPasswordTextBox.PasswordChar = "*"
            ProfileNewPasswordTextBox.PasswordChar = "*"
            ProfileConfirmNewPasswordTextBox.PasswordChar = "*"
        Else
            ProfilePasswordCheckBox.ForeColor = Color.FromArgb(78, 184, 206)
            ProfileOldPasswordTextBox.PasswordChar = ""
            ProfileNewPasswordTextBox.PasswordChar = ""
            ProfileConfirmNewPasswordTextBox.PasswordChar = ""
        End If
    End Sub

    Private Sub ProfilePasswordOkButton_Click(sender As Object, e As EventArgs) Handles ProfilePasswordOkButton.Click   'Password change Ok Button Click
        'Variable Declaration
        Dim old_password As String
        Dim new_password As String
        Dim flag As Boolean
        flag = True     'Flag for indicating whether data is valid 
        old_password = encrypt(ProfileOldPasswordTextBox.Text)

        If ProfileOldPasswordTextBox.Text = "" Or ProfileNewPasswordTextBox.Text = "" Or ProfileConfirmNewPasswordTextBox.Text = "" Then
            MessageBox.Show("One of the fields in empty", "Error")  'Show error and uodate flag
            flag = False
        End If
        If flag = True Then
            If old_password <> password Then    'Password entered is wrong
                MessageBox.Show("Old password is Wrong", "Error")   'Show error and uodate flag
                ProfileOldPasswordTextBox.Text = "" 'Clear the field
                flag = False
            Else        'Right
                new_password = ProfileNewPasswordTextBox.Text
                If new_password <> ProfileConfirmNewPasswordTextBox.Text And flag = True Then   'New and confirm password don't match
                    MessageBox.Show("New Password and Confirm Password fields don't match", "Error")    'Show error and uodate flag
                    ProfileNewPasswordTextBox.Text = ""         'Clear the field
                    ProfileConfirmNewPasswordTextBox.Text = ""          'Clear the field
                    flag = False
                Else
                    'Save password 
                    Dim final_password As String
                    final_password = encrypt(new_password)
                    'Update in database
                    connection.Open()
                    Dim command As New OleDbCommand
                    command.Connection = connection
                    Dim query As String
                    query = "Update Student Set [Password] = '" & final_password & "' Where Username = '" & Username & "'; "    'Updating final password
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    command.Dispose()
                    connection.Close()
                    'CODE
                    password = final_password   'Updating password global variable
                    MessageBox.Show("Password Updated Successfully", "Password Change")
                End If
            End If
        End If
    End Sub

    Private Sub OldPastLeaveListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OldPastLeaveListBox.SelectedIndexChanged     'Shows comments when leave is selected from list box
        'Clear items in comments box
        OldCommentsListBox.Items.Clear()
        Dim command As New OleDbCommand
        command.Connection = connection
        Dim selectedleave As String = OldUpcomingLeaveListBox.SelectedItem
        If selectedleave = "" Then
            Exit Sub
        End If
        Try
            connection.Open()   'Opening connection
            Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Dim leaveid As Integer = Val(words(1))

            Dim query As String = "Select * From Leave Where LeaveID = " & leaveid & "; "
            command.CommandText = query
            Dim reader As OleDbDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim CommSupervisor As String = ""
                Dim CommOffice As String = ""
                Dim CommDPPC As String = ""
                Dim CommHOD As String = ""
                Dim CommDean As String = ""
                Dim CommDirector As String = ""
                If Not reader.IsDBNull(4) Then
                    CommSupervisor = reader.GetString(4)
                End If
                If Not reader.IsDBNull(5) Then
                    CommOffice = reader.GetString(5)

                End If
                If Not reader.IsDBNull(6) Then
                    CommDPPC = reader.GetString(6)

                End If
                If Not reader.IsDBNull(7) Then
                    CommHOD = reader.GetString(7)

                End If
                If Not reader.IsDBNull(8) Then
                    CommDean = reader.GetString(8)

                End If
                If Not reader.IsDBNull(9) Then
                    CommDirector = reader.GetString(9)

                End If
                OldCommentsListBox.Items.Add("CommSupervisor: " & CommSupervisor)
                OldCommentsListBox.Items.Add("CommOffice: " & CommOffice)
                OldCommentsListBox.Items.Add("CommDPPC: " & CommDPPC)
                OldCommentsListBox.Items.Add("CommHOD: " & CommHOD)
                OldCommentsListBox.Items.Add("CommDean: " & CommDean)
                OldCommentsListBox.Items.Add("CommDirector: " & CommDirector)
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OldUpcomingLeaveListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OldUpcomingLeaveListBox.SelectedIndexChanged             'Shows comments when leave is selected from list box
        'Clear items in comments box
        OldCommentsListBox.Items.Clear()
        Dim command As New OleDbCommand
        command.Connection = connection
        Dim selectedleave As String = OldUpcomingLeaveListBox.SelectedItem
        If selectedleave = "" Then
            Exit Sub
        End If
        Try
            connection.Open()   'Opening connection
            Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Dim leaveid As Integer = Val(words(1))

            Dim query As String = "Select * From Leave Where LeaveID = " & leaveid & "; "
            command.CommandText = query
            Dim reader As OleDbDataReader
            reader = command.ExecuteReader
            While (reader.Read())
                Dim CommSupervisor As String = ""
                Dim CommOffice As String = ""
                Dim CommDPPC As String = ""
                Dim CommHOD As String = ""
                Dim CommDean As String = ""
                Dim CommDirector As String = ""
                If Not reader.IsDBNull(4) Then
                    CommSupervisor = reader.GetString(4)
                End If
                If Not reader.IsDBNull(5) Then
                    CommOffice = reader.GetString(5)

                End If
                If Not reader.IsDBNull(6) Then
                    CommDPPC = reader.GetString(6)

                End If
                If Not reader.IsDBNull(7) Then
                    CommHOD = reader.GetString(7)

                End If
                If Not reader.IsDBNull(8) Then
                    CommDean = reader.GetString(8)

                End If
                If Not reader.IsDBNull(9) Then
                    CommDirector = reader.GetString(9)

                End If
                OldCommentsListBox.Items.Add("CommSupervisor: " & CommSupervisor)
                OldCommentsListBox.Items.Add("CommOffice: " & CommOffice)
                OldCommentsListBox.Items.Add("CommDPPC: " & CommDPPC)
                OldCommentsListBox.Items.Add("CommHOD: " & CommHOD)
                OldCommentsListBox.Items.Add("CommDean: " & CommDean)
                OldCommentsListBox.Items.Add("CommDirector: " & CommDirector)
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick   'For showing clock
        Button1.Text = TimeOfDay()
    End Sub

    Private Sub OldDeleteButton_Click(sender As Object, e As EventArgs) Handles OldDeleteButton.Click   'For deleting upcoming non-approved leave
        'Variable declaration
        Dim selectedleave As String
        selectedleave = OldUpcomingLeaveListBox.Text
        Dim flag As Boolean = False 'Flag for indicating whether leave is deleted
        If selectedleave = "" Then
            MessageBox.Show("Kindly Select leave from Upcoming Leaves", "Delete Error") 'Error
        Else
            Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            If CDate(words(5)) <= Date.Today Then
                MessageBox.Show("Ongoing Leave can't be deleted", "Delete Error")   'Error as ongoing leaves can't be deleted
            Else
                Dim approvalstatus As String
                Try
                    connection.Open()   'Opening connection
                    Dim leaveid As Integer = Val(words(1))
                    Dim command As New OleDbCommand
                    command.Connection = connection
                    Dim query As String = "Select ApprovalStatus from Leave Where LeaveID = " & leaveid & ";"
                    command.CommandText = query
                    approvalstatus = command.ExecuteScalar.ToString
                    If approvalstatus = "Approved" Then
                        MessageBox.Show("Can't Delete Approved Leave Application", "Delete Error")
                    Else
                        query = "DELETE from Leave Where LeaveID = " & leaveid & ";"
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        MessageBox.Show("Successfully Deleted", "Success")
                        flag = True
                    End If
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If flag = True Then 'if deleted then refresh
                    OldButton.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub OldExtendLeaveButton_Click(sender As Object, e As EventArgs) Handles OldExtendLeaveButton.Click     'Extend Button click
        'Variable declaration
        Dim selectedleave As String
        selectedleave = OldUpcomingLeaveListBox.Text
        ExtendDocumentFilePath = ""
        Dim flag As Boolean = False
        If selectedleave = "" Then
            MessageBox.Show("Kindly Select leave from Upcoming Leaves", "Delete Error")
        Else
            Dim words As String() = selectedleave.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)   'Getting leave id
            If CDate(words(5)) <= Date.Today Then
                MessageBox.Show("Ongoing Leave can't be deleted", "Delete Error")   'Show error
            Else
                Dim approvalstatus As String
                Try
                    connection.Open()   'Opening connection
                    Dim leaveid As Integer = Val(words(1))
                    extendleaveid = leaveid
                    Dim command As New OleDbCommand
                    command.Connection = connection
                    Dim query As String = "Select ApprovalStatus from Leave Where LeaveID = " & leaveid & ";"
                    command.CommandText = query
                    approvalstatus = command.ExecuteScalar.ToString
                    If approvalstatus = "Approved" Then
                        MessageBox.Show("Can't Delete Approved Leave Application", "Delete Error")  'Approved leave can't be extended

                    Else
                        ExtendOuterPanel.Show() 'Proceed to next panel
                        OldPanel.Hide()
                        NAButton.Enabled = False
                        OldButton.Enabled = False
                        ProfileButton.Enabled = False
                        ExtendLeaveInstructionTextBox.Text = "pdf only"
                    End If
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ExtendLeaveUploadButton_Click(sender As Object, e As EventArgs) Handles ExtendLeaveUploadButton.Click   'Extend Leave Document upload button
        'Variable Declaration
        Dim filepath As String
        filepath = ""
        'Taking the Source file 
        If ExtendOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = ExtendOpenFileDialog.FileName
        End If
        ExtendDocumentFilePath = filepath
        If filepath <> "" Then
            ExtendLeaveInstructionTextBox.Text = filepath
        End If
    End Sub

    Private Sub ExtendLeaveApplyButton_Click(sender As Object, e As EventArgs) Handles ExtendLeaveApplyButton.Click
        'Variable Declaration
        Dim startdate As Date
        Dim lastdate As Date
        Dim leavetype As String
        Dim supervisor As String
        Dim appliedflag As Boolean = False  'Check
        Try
            connection.Open()   'Opening connection
            Dim command3 As New OleDbCommand
            command3.Connection = connection
            Dim query3 As String = "Select StartDate from Leave Where LeaveID = " & extendleaveid & ";"
            command3.CommandText = query3
            Date.TryParseExact(command3.ExecuteScalar.ToString, New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdate)    'Parsing
            query3 = "Select Type from Leave Where LeaveID = " & extendleaveid & ";"
            command3.CommandText = query3
            leavetype = command3.ExecuteScalar.ToString
            query3 = "Select SuperVisor from Leave Where LeaveID = " & extendleaveid & ";"
            command3.CommandText = query3
            supervisor = command3.ExecuteScalar.ToString
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lastdate = ExtendLastDateDateTimePicker.Text
        Dim currentdate As Date = Date.Today
        Dim flag As Boolean
        flag = True
        If lastdate < startdate And flag = True Then
            MessageBox.Show("Last Date can't be less than Start Date", "Error") 'Show error and update flag
            flag = False
        End If
        If lastdate > calander_year And flag = True Then
            MessageBox.Show("Leave spans Out of Calander Year", "Error")    'Show error and update flag
            flag = False
        End If
        Try
            connection.Open()   'opening connection
            Dim command1 As New OleDbCommand
            command1.Connection = connection
            Dim query1 As String
            query1 = "Select * From Leave Where Applicant = '" & Username & "'; "
            command1.CommandText = query1
            Dim reader1 As OleDbDataReader
            reader1 = command1.ExecuteReader
            While (reader1.Read() And flag) 'Overlapping check
                Dim stringtemp As String
                stringtemp = reader1.GetString(10)
                Dim lastdatetemp As Date
                Date.TryParseExact(reader1.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, lastdatetemp)    'Parsing
                Dim leaveidtemp As Integer = reader1.GetInt32(0)
                Dim startdatetemp As Date
                Date.TryParseExact(reader1.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdatetemp)   'Parsing
                If ((startdate <= lastdatetemp And startdate >= startdatetemp) Or (lastdate >= startdatetemp And lastdate <= lastdatetemp) Or (startdate <= startdatetemp And lastdate >= lastdatetemp)) And stringtemp <> "Declined" And leaveidtemp <> extendleaveid Then
                    MessageBox.Show("There is already an applied overlapping leave with LeaveID " & leaveidtemp, "Error")   'Overlap found, update flag
                    flag = False
                End If
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim days As Integer = lastdate.Subtract(startdate).Days + 1
        Dim flag2 As Boolean
        flag2 = False
        Dim projDirectory, destinationPath As String
        projDirectory = Directory.GetCurrentDirectory()
        If ExtendDocumentFilePath <> "" Then
            If IO.File.Exists(ExtendDocumentFilePath) Then
                flag2 = True    'If document was uploaded flag2 = true
            End If
        End If
        'MsgBox(startdate)
        Try
            connection.Open()   'OPENING CONNECTION
            Dim command As New OleDbCommand
            command.Connection = connection
            Dim query As String
            Dim lastdatefinal As String = lastdate.ToString("dd-MM-yyyy")   'Formatting last date to appropriate string for storage to DB
            If flag = True Then
                If leavetype = "OL" Then        'ORDINARY LEAVE
                    Dim totaldays As Integer = days
                    Dim count As Integer = 0
                    Dim leaveid1, leaveid2 As Integer
                    Dim command2 As New OleDbCommand
                    command2.Connection = connection
                    Dim query2 As String
                    query2 = "Select * From Leave Where Type = 'OL' and Applicant = '" & Username & "'; "
                    Dim reader2 As OleDbDataReader
                    command2.CommandText = query2
                    reader2 = command2.ExecuteReader
                    Dim startdatetemp, lastdatetemp As Date
                    While (reader2.Read() And flag)
                        Date.TryParseExact(reader2.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdatetemp)   'Parsing
                        Date.TryParseExact(reader2.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, lastdatetemp)    'Parsing
                        Dim dayscount As Integer = lastdatetemp.Subtract(startdatetemp).Days + 1
                        Dim leaveidtemp As Integer = reader2.GetInt32(0)
                        Dim approvalstatus As String = reader2.GetString(10)
                        If (startdate.Subtract(lastdatetemp).Days = 1 Or startdatetemp.Subtract(lastdate).Days = 1) And approvalstatus <> "Declined" And leaveidtemp <> extendleaveid Then  'Concatenation leading to OL greater than 5 days in a span!
                            count = count + 1
                            totaldays = totaldays + dayscount
                            If count = 1 Then
                                leaveid1 = leaveidtemp
                            End If
                            If count = 2 Then
                                leaveid2 = leaveidtemp
                            End If
                        End If
                    End While
                    If totaldays > 5 Then
                        flag = False    'Update flag
                        If count = 0 Then   'OL spans more than 5 days 
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days", "Error")
                        End If
                        If count = 1 Then   'OL concatenates with another leave and leads to total days being > 5
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days (Concatenating with Upcoming Leave with ID: ) " & leaveid1, "Error")
                        ElseIf count = 2 Then   'OL concatenates with 2 another leave and leads to total days being > 5
                            MessageBox.Show("Ordinary Leaves can't span more than 5 days (Concatenating with Upcoming Leave with IDs: ) " & leaveid1 & " and" & leaveid2, "Error")
                        End If
                    End If
                    If days > 5 And flag = True Then
                        MessageBox.Show("Ordinary Leaves can't span more than 5 days", "Error")
                        flag = False
                    ElseIf flag = True Then
                        If OrdinaryLeaves > days Then
                            'Successful
                            query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then
                                Dim LeaveID As Integer = extendleaveid
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(ExtendDocumentFilePath, destinationPath)
                            End If
                            appliedflag = True

                        Else
                            'Warning for fine
                            Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                            'CODE
                            If ans = DialogResult.Yes Then
                                query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                                command.CommandText = query
                                command.ExecuteNonQuery()
                                command.Dispose()
                                If flag2 = True Then
                                    Dim LeaveID As Integer = extendleaveid
                                    destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                    If IO.File.Exists(destinationPath) Then
                                        File.Delete(destinationPath)
                                    End If
                                    File.Copy(ExtendDocumentFilePath, destinationPath)
                                End If
                                appliedflag = True
                            End If
                        End If
                    End If
                ElseIf leavetype = "AL" Then        'ACADEMIC LEAVE
                    If AcademicLeaves > days Then
                        'Successful Application
                        query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then

                            Dim LeaveID As Integer = extendleaveid
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)

                            End If
                            File.Copy(ExtendDocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then
                                Dim LeaveID As Integer = extendleaveid
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(ExtendDocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                ElseIf leavetype = "ML" Then        'MEDICAL LEAVE
                    If MedicalLeaves > days Then
                        'Successful Application
                        query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer = extendleaveid
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(ExtendDocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then
                                Dim LeaveID As Integer = extendleaveid
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(ExtendDocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                ElseIf leavetype = "PL" Then        'PATERNAL LEAVE
                    If ParentalLeaves > days Then
                        'Successful Application
                        query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        command.Dispose()
                        If flag2 = True Then
                            Dim LeaveID As Integer = extendleaveid
                            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                            If IO.File.Exists(destinationPath) Then
                                File.Delete(destinationPath)
                            End If
                            File.Copy(ExtendDocumentFilePath, destinationPath)
                        End If
                        appliedflag = True
                    Else
                        'Warning for fine
                        Dim ans As DialogResult = MessageBox.Show("Leaves Exceed the permitted amount. May result in fine. Want to Continue?", "Warning", MessageBoxButtons.YesNo)
                        'CODE
                        If ans = DialogResult.Yes Then
                            query = "Update Leave SET EndDate = '" & lastdatefinal & "', isExtension = 'Yes', ApprovalStatus= '" & supervisor & "' where LeaveID = " & extendleaveid & ";"
                            command.CommandText = query
                            command.ExecuteNonQuery()
                            command.Dispose()
                            If flag2 = True Then
                                Dim LeaveID As Integer = extendleaveid
                                destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\" & LeaveID & ".pdf")
                                If IO.File.Exists(destinationPath) Then
                                    File.Delete(destinationPath)
                                End If
                                File.Copy(ExtendDocumentFilePath, destinationPath)
                            End If
                            appliedflag = True
                        End If
                    End If
                Else
                    MessageBox.Show("Wrong Leave Type", "Error")    'this case will never arise!
                    flag = False
                End If
            End If
            If appliedflag = True Then  'Successful application
                MessageBox.Show("Successfully RE-Applied", "Extend Leave Application")
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExtendLeaveCancelButton_Click(sender As Object, e As EventArgs) Handles ExtendLeaveCancelButton.Click
        ExtendDocumentFilePath = ""
        NAButton.Enabled = True
        OldButton.Enabled = True
        ProfileButton.Enabled = True
        ExtendOuterPanel.Hide()
        OldButton.PerformClick()
    End Sub


    Private Sub ProfileContactNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileContactNumberTextBox.TextChanged
        Dim label = ProfileGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileContactNumberLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub ProfileAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileAddressTextBox.TextChanged
        Dim label = ProfileGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileAddressLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub ProfileEmergencyContactNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileEmergencyContactNumberTextBox.TextChanged
        Dim label = ProfileGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileEmergencyContactNumberLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub ProfileOldPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileOldPasswordTextBox.TextChanged
        Dim label = ProfilePasswordChangeGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileOldPasswordLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub ProfileNewPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileNewPasswordTextBox.TextChanged
        Dim label = ProfilePasswordChangeGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileNewPasswordLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub ProfileConfirmNewPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfileConfirmNewPasswordTextBox.TextChanged
        Dim label = ProfilePasswordChangeGroupBox.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        ProfileConfirmNewPasswordLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub


    Private Sub NALeaveTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NALeaveTypeComboBox.SelectedIndexChanged
        Dim label = NAInnerPanel.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        NALeaveTypeLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub NASupervisorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NASupervisorComboBox.SelectedIndexChanged
        Dim label = NAInnerPanel.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        NASupervisorLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub NAStartDate_ValueChanged(sender As Object, e As EventArgs) Handles NAStartDate.ValueChanged
        Dim label = NAInnerPanel.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        NAStartDateLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub NALastDate_ValueChanged(sender As Object, e As EventArgs) Handles NALastDate.ValueChanged
        Dim label = NAInnerPanel.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        NALastDateLabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

End Class