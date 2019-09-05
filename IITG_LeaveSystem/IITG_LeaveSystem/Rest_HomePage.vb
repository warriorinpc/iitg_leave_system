Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Net.Mail
Public Class Rest_HomePage

    Public Property Username As String
    Public Property Type As String
    Dim firstname As String
    Dim lastname As String
    Dim department As String
    Dim con As OleDbConnection


    Private Sub Rest_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        pendingleavesdgv.DefaultCellStyle.BackColor = Color.LightCyan
        If Type = "DPPC" Then

            applyleavebutton.Enabled = False
            Panel2.Hide()

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select Department From DPPC Where Username = '" & Username & "'; "
                command.CommandText = query
                department = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Type = "HOD" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select FirstName From HOD Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From HOD Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                query = "Select Department From HOD Where Username = '" & Username & "'; "
                command.CommandText = query
                department = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If Type = "Dean" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select FirstName From Dean Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From Dean Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If Type = "Professor" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select FirstName From Professor Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From Professor Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                query = "Select Department From Professor Where Username = '" & Username & "'; "
                command.CommandText = query
                department = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        welcomelabel.Text = "Welcome " & firstname & " " & lastname
        usernamelabel.Text = "Username: " & Username
        If Type = "Dean" Then
            departmentlabel.Hide()
        Else
            departmentlabel.Text = "Department: " & department
        End If
    End Sub

    Private Sub loadbutton_Click(sender As Object, e As EventArgs) Handles loadbutton.Click
        If Type = "DPPC" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

                con.Open()
                Dim query As String
                query = "Select * From Leave Where ApprovalStatus = '" & Username & "';"
                Dim command1 As OleDbCommand = New OleDbCommand(query, con)


                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                pendingleavesdgv.DataSource = dt

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If Type = "HOD" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

                con.Open()
                Dim query As String
                query = "Select * From Leave Where ApprovalStatus = '" & Username & "';"
                Dim command1 As OleDbCommand = New OleDbCommand(query, con)


                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                pendingleavesdgv.DataSource = dt

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If Type = "Dean" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

                con.Open()
                Dim query As String
                query = "Select * From Leave Where ApprovalStatus = '" & Username & "';"
                Dim command1 As OleDbCommand = New OleDbCommand(query, con)


                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                pendingleavesdgv.DataSource = dt

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If Type = "Professor" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")

                con.Open()
                Dim query As String
                query = "Select * From Leave Where ApprovalStatus = '" & Username & "';"
                Dim command1 As OleDbCommand = New OleDbCommand(query, con)


                Dim da As OleDbDataAdapter = New OleDbDataAdapter(command1)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)
                pendingleavesdgv.DataSource = dt

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Form1.Show()
        Form1.UsernameTextBox.Select()
        Form1.PasswordTextBox.Clear()
        Me.Close()
    End Sub

    Private Sub applyleavebutton_Click(sender As Object, e As EventArgs) Handles applyleavebutton.Click
        Apply_for_leave.Username = Username
        Apply_for_leave.Type = Type
        Apply_for_leave.Show()
        Me.Hide()
    End Sub

    Private Sub approvebutton_Click(sender As Object, e As EventArgs) Handles approvebutton.Click
        Dim startdate As Date
        Dim enddate As Date
        Dim sdate As Date
        Dim edate As Date
        Dim typeofleave As String
        Dim leaveapplicant As String
        Dim leaveapplicanttype As String
        Dim remainingleaves As Integer
        Dim LeaveId As Integer
        Dim emailID As String
        Try
            Dim row As Integer = pendingleavesdgv.CurrentRow.Index
            LeaveId = pendingleavesdgv.Item(0, row).Value
            'Exit Sub
        Catch ex As Exception
            MessageBox.Show("Select a row first!")
            Exit Sub
        End Try

        Dim projDirectory, destinationPath, databasePath As String
        projDirectory = Directory.GetCurrentDirectory()
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
        Try
            'MsgBox("Came Here")
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
            con.Open()
            Dim query As String
            Dim command As New OleDbCommand
            command.Connection = con
            query = "Select StartDate From Leave Where LeaveID = " & LeaveId & "; "
            'MessageBox.Show(query)
            command.CommandText = query
            Date.TryParseExact(command.ExecuteScalar.ToString, New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, sdate)
            'MsgBox(sdate)
            query = "Select EndDate From Leave Where LeaveID = " & LeaveId & "; "
            command.CommandText = query
            Date.TryParseExact(command.ExecuteScalar.ToString, New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, edate)
            'MsgBox(edate)
            query = "Select Type From Leave Where LeaveID = " & LeaveId & "; "
            command.CommandText = query
            typeofleave = command.ExecuteScalar.ToString
            query = "Select Applicant From Leave Where LeaveID = " & LeaveId & "; "
            command.CommandText = query
            leaveapplicant = command.ExecuteScalar.ToString
            query = "Select ApplicantType From Leave Where LeaveID = " & LeaveId & "; "
            command.CommandText = query
            leaveapplicanttype = command.ExecuteScalar.ToString
            Dim table As String = leaveapplicanttype
            If table = "MTech" Or table = "PhD" Then
                table = "Student"
            End If
            query = "Select Email From " & table & " Where Username = '" & leaveapplicant & "'; "
            command.CommandText = query
            emailID = command.ExecuteScalar.ToString
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        'MsgBox(sdate)
        startdate = sdate
        enddate = edate
        Dim days As Integer = enddate.Subtract(startdate).Days + 1

        If Type = "Professor" Then
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set ApprovalStatus = 'office'  where LeaveID = " & LeaveId & " ;"
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave request sent to office for approval")
        End If

        If Type = "DPPC" And days < 9 Then
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set ApprovalStatus = 'Approved'  where LeaveID = " & LeaveId & " ;"
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If typeofleave = "ML" Then
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim query As String
                    Dim command As New OleDbCommand
                    command.Connection = con
                    query = "Select MedicalLeaves From Student Where Username = '" & leaveapplicant & "'; "

                    'MessageBox.Show(query)
                    command.CommandText = query
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read
                        remainingleaves = reader.GetInt32(0)
                    End While
                    con.Close()
                    remainingleaves = remainingleaves - days
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim command2 As OleDbCommand = New OleDbCommand()
                    command2.Connection = con
                    command2.CommandText = "update Student set MedicalLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                    command2.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If typeofleave = "OL" Then
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim query As String
                    Dim command As New OleDbCommand
                    command.Connection = con
                    query = "Select OrdinaryLeaves From Student Where Username = '" & leaveapplicant & "'; "

                    'MessageBox.Show(query)
                    command.CommandText = query
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read
                        remainingleaves = reader.GetInt32(0)
                    End While
                    con.Close()
                    remainingleaves = remainingleaves - days
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim command2 As OleDbCommand = New OleDbCommand()
                    command2.Connection = con
                    command2.CommandText = "update Student set OrdinaryLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                    command2.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If typeofleave = "AL" Then
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim query As String
                    Dim command As New OleDbCommand
                    command.Connection = con
                    query = "Select AcademicLeaves From Student Where Username = '" & leaveapplicant & "'; "

                    'MessageBox.Show(query)
                    command.CommandText = query
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read
                        remainingleaves = reader.GetInt32(0)
                    End While
                    con.Close()
                    remainingleaves = remainingleaves - days
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim command2 As OleDbCommand = New OleDbCommand()
                    command2.Connection = con
                    command2.CommandText = "update Student set AcademicLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                    command2.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If typeofleave = "PL" Then
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim query As String
                    Dim command As New OleDbCommand
                    command.Connection = con
                    query = "Select ParentalLeaves From Student Where Username = '" & leaveapplicant & "'; "

                    'MessageBox.Show(query)
                    command.CommandText = query
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read
                        remainingleaves = reader.GetInt32(0)
                    End While
                    con.Close()
                    remainingleaves = remainingleaves - days
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim command2 As OleDbCommand = New OleDbCommand()
                    command2.Connection = con
                    command2.CommandText = "update Student set ParentalLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                    command2.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            MessageBox.Show("Leave Sanctioned")
            SendEmail(emailID, "Your leave request has been approved by DPPC.", "Leave Approval")
        End If

        If Type = "DPPC" And days >= 9 Then
            Dim department As String
            Dim hodusername As String

            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select Department From Student Where Username = '" & leaveapplicant & "'; "
                command.CommandText = query
                department = command.ExecuteScalar.ToString
                query = "Select Username From HOD Where Department = '" & department & "'; "
                command.CommandText = query
                hodusername = command.ExecuteScalar.ToString

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con

                command2.CommandText = "update Leave set ApprovalStatus = '" & hodusername & "' where LeaveID = " & LeaveId & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Number of leaves greater than 8, approval request is sent to HOD")
        End If
        If Type = "HOD" Then
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set ApprovalStatus = 'Approved'  where LeaveID = " & LeaveId & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If leaveapplicanttype = "MTech" Or leaveapplicanttype = "PhD" Then
                If typeofleave = "ML" Then
                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim query As String
                        Dim command As New OleDbCommand
                        command.Connection = con
                        query = "Select MedicalLeaves From Student Where Username = '" & leaveapplicant & "'; "

                        'MessageBox.Show(query)
                        command.CommandText = query
                        Dim reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read
                            remainingleaves = reader.GetInt32(0)
                        End While
                        con.Close()
                        remainingleaves = remainingleaves - days
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim command2 As OleDbCommand = New OleDbCommand()
                        command2.Connection = con
                        command2.CommandText = "update Student set MedicalLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                        command2.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If typeofleave = "OL" Then
                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim query As String
                        Dim command As New OleDbCommand
                        command.Connection = con
                        query = "Select OrdinaryLeaves From Student Where Username = '" & leaveapplicant & "'; "

                        'MessageBox.Show(query)
                        command.CommandText = query
                        Dim reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read
                            remainingleaves = reader.GetInt32(0)
                        End While
                        con.Close()
                        remainingleaves = remainingleaves - days
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim command2 As OleDbCommand = New OleDbCommand()
                        command2.Connection = con
                        command2.CommandText = "update Student set OrdinaryLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                        command2.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If typeofleave = "AL" Then
                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim query As String
                        Dim command As New OleDbCommand
                        command.Connection = con
                        query = "Select AcademicLeaves From Student Where Username = '" & leaveapplicant & "'; "

                        'MessageBox.Show(query)
                        command.CommandText = query
                        Dim reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read
                            remainingleaves = reader.GetInt32(0)
                        End While
                        con.Close()
                        remainingleaves = remainingleaves - days
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim command2 As OleDbCommand = New OleDbCommand()
                        command2.Connection = con
                        command2.CommandText = "update Student set AcademicLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                        command2.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If typeofleave = "PL" Then
                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim query As String
                        Dim command As New OleDbCommand
                        command.Connection = con
                        query = "Select ParentalLeaves From Student Where Username = '" & leaveapplicant & "'; "

                        'MessageBox.Show(query)
                        command.CommandText = query
                        Dim reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read
                            remainingleaves = reader.GetInt32(0)
                        End While
                        con.Close()
                        remainingleaves = remainingleaves - days
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                        con.Open()
                        Dim command2 As OleDbCommand = New OleDbCommand()
                        command2.Connection = con
                        command2.CommandText = "update Student set ParentalLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                        command2.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim query As String
                    Dim command As New OleDbCommand
                    command.Connection = con
                    query = "Select OrdinaryLeaves From " & leaveapplicanttype & " Where Username = '" & leaveapplicant & "'; "

                    'MessageBox.Show(query)
                    command.CommandText = query
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read
                        remainingleaves = reader.GetInt32(0)
                    End While
                    con.Close()
                    remainingleaves = remainingleaves - days
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                    con.Open()
                    Dim command2 As OleDbCommand = New OleDbCommand()
                    command2.Connection = con
                    command2.CommandText = "update " & leaveapplicanttype & " set OrdinaryLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                    command2.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            MessageBox.Show("Leave Sanctioned")
            SendEmail(emailID, "Your leave request has been approved by HOD", "Leave Approval")
        End If

        If Type = "Dean" Then
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set ApprovalStatus = 'Approved'  where LeaveID = " & LeaveId & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim query As String
                Dim command As New OleDbCommand
                command.Connection = con
                query = "Select OrdinaryLeaves From HOD Where Username = '" & leaveapplicant & "'; "

                'MessageBox.Show(query)
                command.CommandText = query
                Dim reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read
                    remainingleaves = reader.GetInt32(0)
                End While
                con.Close()
                remainingleaves = remainingleaves - days
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update HOD set OrdinaryLeaves = '" & remainingleaves & "'  where Username = '" & leaveapplicant & "' ;"
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave Sanctioned")
        End If
        loadbutton.PerformClick()
    End Sub



    Private Sub addcommentbutton_Click(sender As Object, e As EventArgs) Handles addcommentbutton.Click

        Dim LeaveID As Integer
        Try
            Dim row As Integer = pendingleavesdgv.CurrentRow.Index
            LeaveID = pendingleavesdgv.Item(0, row).Value
            'Exit Sub
        Catch ex As Exception
            MessageBox.Show("Select a leave first!")
            Exit Sub
        End Try

        If Type = "Professor" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set CommSupervisor = '" & addcommentbox.Text & "'  where LeaveID = " & LeaveID & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Type = "DPPC" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set CommDPPC = '" & addcommentbox.Text & "'  where LeaveID = " & LeaveID & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Type = "HOD" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set CommHOD = '" & addcommentbox.Text & "'  where LeaveID = " & LeaveID & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Type = "Dean" Then

            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con.Open()
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update Leave set CommDean = '" & addcommentbox.Text & "'  where LeaveID = " & LeaveID & " ;"

                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        MessageBox.Show("Comment added to selected leave request")
        addcommentbox.Clear()
        loadbutton.PerformClick()
        'addcommentbutton.Enabled = False
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
    Private Sub denybutton_Click(sender As Object, e As EventArgs) Handles denybutton.Click

        Dim LeaveID As Integer
        Try
            Dim row As Integer = pendingleavesdgv.CurrentRow.Index
            LeaveID = pendingleavesdgv.Item(0, row).Value
            'Exit Sub
        Catch ex As Exception
            MessageBox.Show("Select a row first!")
            Exit Sub
        End Try

        Dim projDirectory, destinationPath, databasePath As String
        projDirectory = Directory.GetCurrentDirectory()
        databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
        Try
            con.Open()
            Dim command2 As OleDbCommand = New OleDbCommand()
            command2.Connection = con
            command2.CommandText = "update Leave set ApprovalStatus = 'Declined'  where LeaveID = " & LeaveID & " ;"

            'MessageBox.Show(command2.CommandText)
            command2.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("Leave request denied")
        loadbutton.PerformClick()
    End Sub

    Private Sub pendingleavesdgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles pendingleavesdgv.CellMouseDoubleClick
        'MessageBox.Show("Upper")
        Try
            Dim selectedCellCount As Integer = pendingleavesdgv.GetCellCount(DataGridViewElementStates.Selected)
            If selectedCellCount = 1 Then
                Dim col As Integer = pendingleavesdgv.CurrentCell.ColumnIndex
                Dim row As Integer = pendingleavesdgv.CurrentCell.RowIndex
                Dim Leavid As Integer = 0
                Dim Doc As String
                Dim projDirectory, docPath As String
                projDirectory = Directory.GetCurrentDirectory()
                docPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "Documents\")
                If col = 11 Then
                    'MessageBox.Show(row)
                    Leavid = pendingleavesdgv.Item(0, row).Value
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