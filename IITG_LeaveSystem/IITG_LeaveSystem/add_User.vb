Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class add_User

    Public Property con As OleDbConnection


    Private Sub add_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If CStr(choice_combo.SelectedItem) = "" Then
            MessageBox.Show("Select a Type")
            Exit Sub
        End If

        If CStr(dept_combo.SelectedItem) = "" Then
            MessageBox.Show("Select a Department")
            Exit Sub
        End If

        If (CStr(choice_combo.SelectedItem) = "Student" And gender_combo.SelectedItem = "") Then
            MessageBox.Show("Select a Gender")
            Exit Sub
        End If

        If (CStr(choice_combo.SelectedItem) = "Student" And course_combo.SelectedItem = "") Then
            MessageBox.Show("Select a Course")
            Exit Sub
        End If

        If (CStr(choice_combo.SelectedItem) = "Student" And (IsNumeric(RollNumber_text.Text) = False Or RollNumber_text.Text.Length <> 9)) Then
            MessageBox.Show("Enter a Valid RollNumber")
            Exit Sub
        End If

        If username_text.Text = "" Then
            MessageBox.Show("Enter a valid username")
            Exit Sub
        End If
        If firstname_text.Text = "" Then
            MessageBox.Show("Enter a valid firstname")
            Exit Sub
        End If
        Dim y As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("^[a-zA-Z]{1,}$")

        If y.IsMatch(firstname_text.Text) = False Then
            MessageBox.Show("Enter a valid firstname")
            Exit Sub
        End If

        If y.IsMatch(lastname_text.Text) = False Then
            MessageBox.Show("Enter a valid lastname")
            Exit Sub
        End If

        If password_text.Text = "" Then
            MessageBox.Show("Enter a valid password")
            Exit Sub
        End If

        If Phone_text.Text.Length < 7 Or IsNumeric(Phone_text.Text) = False Then
            MessageBox.Show("Enter a Valid Phone Number")
            Exit Sub
        End If

        If Email_Text.Text = "" Then
            MessageBox.Show("Enter an email")
            Exit Sub
        End If

        If Not Email_Text.Text.Contains("@") Then
            MessageBox.Show("Enter a valid email")
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

            If (count <> 0) Then
                MessageBox.Show("Username already exists")
                con.Close()
                Exit Sub
            End If
            Dim pare As Integer = 0
            If CStr(course_combo.SelectedItem) = "PhD" Then
                If CStr(gender_combo.SelectedItem) = "Male" Then
                    pare = 15
                Else
                    pare = 90
                End If
            End If

            If choice_combo.SelectedItem = "Student" Then
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "INSERT INTO " & CStr(choice_combo.SelectedItem) & " (Username,[Password], FirstName, LastName,Phone, Email, Department, MedicalLeaves, OrdinaryLeaves, AcademicLeaves, ParentalLeaves, Gender, Course, RollNumber) VALUES ('" & username_text.Text & "','" & CStr(encrypt(password_text.Text)) & "','" & firstname_text.Text & "','" & lastname_text.Text & "','" & Phone_text.Text & "','" & Email_Text.Text & "','" & CStr(dept_combo.SelectedItem) & "',15,30,30," & pare & ",'" & CStr(gender_combo.SelectedItem) & "','" & CStr(course_combo.SelectedItem) & "','" & RollNumber_text.Text & "');"
                'username_text.Text = (command2.CommandText)
                command2.ExecuteNonQuery()
                MessageBox.Show("User Added!!")
                username_text.Text = ""
                password_text.Text = ""
                firstname_text.Text = ""
                lastname_text.Text = ""
                Email_Text.Text = ""
                RollNumber_text.Text = ""
                Phone_text.Text = ""
                choice_combo.Text = ""
                gender_combo.Text = ""
                course_combo.Text = ""
                dept_combo.Text = ""
            Else
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "INSERT INTO " & CStr(choice_combo.SelectedItem) & " (Username,[Password], FirstName, LastName,Phone, Email, Department, MedicalLeaves, OrdinaryLeaves) VALUES ('" & username_text.Text & "','" & CStr(encrypt(password_text.Text)) & "','" & firstname_text.Text & "','" & lastname_text.Text & "','" & Phone_text.Text & "','" & Email_Text.Text & "','" & CStr(dept_combo.SelectedItem) & "',15,30);"
                'username_text.Text = (command2.CommandText)
                command2.ExecuteNonQuery()
                MessageBox.Show("User Added!!")
                username_text.Text = ""
                password_text.Text = ""
                firstname_text.Text = ""
                lastname_text.Text = ""
                Email_Text.Text = ""
                RollNumber_text.Text = ""
                Phone_text.Text = ""
                choice_combo.Text = ""
                gender_combo.Text = ""
                course_combo.Text = ""
                dept_combo.Text = ""
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub


    Private Function encrypt(p1 As String) As String
        Dim bytHashedData As Byte()
        Dim encoder As New utf8encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(p1))
        'p1 = Convert.ToBase64String(bytHashedData)
        p1 = ""
        For Each b As Byte In bytHashedData
            p1 += b.ToString("x2")
        Next
        Return p1
    End Function

    Private Sub choice_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choice_combo.SelectedIndexChanged
        If CStr(choice_combo.SelectedItem) = "Student" Then
            Label10.Visible = True
            Label11.Visible = True
            Label9.Visible = True
            RollNumber_text.Visible = True
            gender_combo.Visible = True
            course_combo.Visible = True
        Else
            Label10.Visible = False
            Label11.Visible = False
            Label9.Visible = False
            RollNumber_text.Visible = False
            gender_combo.Visible = False
            course_combo.Visible = False
        End If

        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label1.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    
    Private Sub username_text_TextChanged(sender As Object, e As EventArgs) Handles username_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label2.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub firstname_text_TextChanged(sender As Object, e As EventArgs) Handles firstname_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label6.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub password_text_TextChanged(sender As Object, e As EventArgs) Handles password_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label3.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub lastname_text_TextChanged(sender As Object, e As EventArgs) Handles lastname_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label5.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub Phone_text_TextChanged(sender As Object, e As EventArgs) Handles Phone_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label4.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub Email_Text_TextChanged(sender As Object, e As EventArgs) Handles Email_Text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label7.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub dept_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dept_combo.SelectedIndexChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label8.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub gender_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender_combo.SelectedIndexChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label10.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub course_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course_combo.SelectedIndexChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label9.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub RollNumber_text_TextChanged(sender As Object, e As EventArgs) Handles RollNumber_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label11.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

End Class