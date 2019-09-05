Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class Apply_for_leave

    Public Property Username As String
    Public Property Type As String
    Dim department As String
    Dim firstname As String
    Dim lastname As String
    Dim startdate As Date
    Dim enddate As Date
    Dim days As Integer
    Dim appliedflag As Boolean = False
    Dim con As OleDbConnection

    Private Sub Apply_for_leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        If Type = "Staff" Or Type = "Director" Then
            Button2.Text = "LOG OUT"
        Else
            Button2.Text = "Close"
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

        If Type = "Dean" Or Type = "Director" Then

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
                query = "Select FirstName From " & Type & " Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From " & Type & " Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If Type = "Staff" Then
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
                query = "Select FirstName From " & Type & " Where Username = '" & Username & "'; "
                command.CommandText = query
                firstname = command.ExecuteScalar.ToString
                query = "Select LastName From " & Type & " Where Username = '" & Username & "'; "
                command.CommandText = query
                lastname = command.ExecuteScalar.ToString
                query = "Select Department From " & Type & " Where Username = '" & Username & "'; "
                command.CommandText = query
                department = command.ExecuteScalar.ToString
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        nametextbox.Text = "" & firstname & " " & lastname
        If Type = "Professor" Or Type = "HOD" Then
            positionlabel.Text = "" & Type & ", " & department
        End If
        If Type = "Dean" Or Type = "Director" Then
            positionlabel.Text = "" & Type
        End If
        If Type = "Staff" Then
            positionlabel.Text = "" & department
        End If
    End Sub


    Private Sub applybutton_Click(sender As Object, e As EventArgs) Handles applybutton.Click
        startdate = DateTimePicker1.Text
        enddate = DateTimePicker2.Text
        days = enddate.Subtract(startdate).Days + 1
        Dim currentdate As Date
        currentdate = Date.Today
        Dim flag As Boolean
        flag = True
        If startdate < currentdate Then
            MessageBox.Show("Start Date should be greater than yesterday's date", "Error")
            flag = False
            Exit Sub
        End If
        If enddate < startdate And flag = True Then
            MessageBox.Show("Last Date can't be less than Start Date", "Error")
            flag = False
            Exit Sub
        End If

        'Started: fixing duplicate leaves (applies to everyone except student and office)
        Dim TprojDirectory, TdestinationPath, TdatabasePath As String
        TprojDirectory = Directory.GetCurrentDirectory()
        TdatabasePath = TprojDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
        TdestinationPath = TprojDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
        Dim lastdate As Date = enddate
        Dim connection As New OleDbConnection
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
        connection.Open()
        Dim command1 As New OleDbCommand
        command1.Connection = connection
        Dim query1 As String
        query1 = "Select * From Leave Where Applicant = '" & Username & "'; "
        command1.CommandText = query1
        Dim reader1 As OleDbDataReader
        reader1 = command1.ExecuteReader
        While (reader1.Read() And flag)
            Dim stringtemp As String
            stringtemp = reader1.GetString(10)
            Dim lastdatetemp As Date
            Dim leaveidtemp As Integer = reader1.GetInt32(0)
            Date.TryParseExact(reader1.GetString(3), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, lastdatetemp)
            Dim startdatetemp As Date
            Date.TryParseExact(reader1.GetString(2), New String() {"dd-MM-yyyy"}, Nothing, Globalization.DateTimeStyles.AdjustToUniversal, startdatetemp)
            If ((startdate <= lastdatetemp And startdate >= startdatetemp) Or (lastdate >= startdatetemp And lastdate <= lastdatetemp) Or (startdate <= startdatetemp And lastdate >= lastdatetemp)) And stringtemp <> "Declined" Then
                MessageBox.Show("There is already an applied overlapping leave with LeaveID " & leaveidtemp, "Error")
                flag = False
                Exit Sub
            End If
        End While
        connection.Close()

        'Finished: fixing duplicate leaves (applies to everyone except student and office)

        Dim startdatefinal As String = startdate.ToString("dd-MM-yyyy")
        Dim enddatefinal As String = enddate.ToString("dd-MM-yyyy")

        If Type = "Professor" Or Type = "Staff" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim command As New OleDbCommand
                command.Connection = con
                Dim query As String
                query = "INSERT INTO Leave (Type, StartDate, EndDate, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdatefinal & "', '" & enddatefinal & "', '" & Username & "', 'No', '" & Type & "' , 'office'); "
                'MessageBox.Show(query)
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave request applied")
        End If

        If Type = "HOD" Then
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim command As New OleDbCommand
                command.Connection = con
                Dim query As String
                query = "INSERT INTO Leave (Type, StartDate, EndDate, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdatefinal & "', '" & enddatefinal & "', '" & Username & "', 'No', 'HOD' , 'office'); "
                'MessageBox.Show(query)
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave request applied")
        End If

        If Type = "Dean" Or Type = "Director" Then
            Dim remainingleaves As Integer
            Dim projDirectory, destinationPath, databasePath As String
            projDirectory = Directory.GetCurrentDirectory()
            databasePath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "LeaveSystem.accdb")
            destinationPath = projDirectory.Replace("IITG_LeaveSystem\IITG_LeaveSystem\bin\Debug", "shp_bi\images.jpeg")
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LeaveSystem.accdb")
                con.Open()
                Dim command As New OleDbCommand
                command.Connection = con
                Dim query As String
                query = "INSERT INTO Leave (Type, StartDate, EndDate, Applicant, isExtension, ApplicantType, ApprovalStatus) VALUES ('OL', '" & startdatefinal & "', '" & enddatefinal & "', '" & Username & "', 'No', '" & Type & "' , 'Approved'); "
                command.CommandText = query
                command.ExecuteNonQuery()
                command.Dispose()
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
                query = "Select OrdinaryLeaves From " & Type & " Where Username = '" & Username & "'; "

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
                command2.CommandText = "update " & Type & " set OrdinaryLeaves = '" & remainingleaves & "'  where Username = '" & Username & "' ;"
                command2.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Leave Sanctioned")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Type = "Staff" Or Type = "Director" Then
            Form1.Show()
            Form1.PasswordTextBox.Clear()
            Me.Close()
        Else
            Rest_HomePage.Show()
            Me.Close()
            Rest_HomePage.loadbutton.PerformClick()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        startdatelabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label1.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub nametextbox_TextChanged(sender As Object, e As EventArgs) Handles nametextbox.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        namelabel.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub
End Class