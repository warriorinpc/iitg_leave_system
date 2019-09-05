Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class userUpdate

    Public Property con As OleDbConnection

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Try
            If (CStr(choice_combo.SelectedItem) = "") Then
                MessageBox.Show("Select User Type")
                Exit Sub
            End If
            If (CStr(fieldBox.SelectedItem) = "") Then
                MessageBox.Show("Select Field To Edit")
                Exit Sub
            End If

            If val_text.Text = "" Then
                MessageBox.Show("Please enter a value!")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "Phone") And (val_text.Text.Length <> 10) Then
                MessageBox.Show("Enter a valid phone number")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "Email") And (val_text.Text = "") Then
                MessageBox.Show("Enter an e-mail")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "Email") And Not val_text.Text.Contains("@") Then
                MessageBox.Show("Enter a valid email")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "OrdinaryLeaves") And IsNumeric(val_text.Text) = False Then
                MessageBox.Show("Enter a proper value for leave")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "AcademicLeaves") And IsNumeric(val_text.Text) = False Then
                MessageBox.Show("Enter a proper value for leave")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "MedicalLeaves") And IsNumeric(val_text.Text) = False Then
                MessageBox.Show("Enter a proper value for leave")
                Exit Sub
            End If

            If (CStr(fieldBox.SelectedItem) = "ParentalLeaves") And IsNumeric(val_text.Text) = False Then
                MessageBox.Show("Enter a proper value for leave")
                Exit Sub
            End If

            con.Open()

            Dim command1 As OleDbCommand = New OleDbCommand()
            command1.Connection = con
            command1.CommandText = "Select * From " & CStr(choice_combo.SelectedItem) & " Where Username = '" & username_text.Text & "'; "
            Dim reader As OleDbDataReader = command1.ExecuteReader()

            Dim count As Integer = 0
            While (reader.Read)
                count += 1
            End While

            Dim value As String

            If (CStr(fieldBox.SelectedItem) = "Password") Then
                value = encrypt(val_text.Text)
            Else
                value = val_text.Text
            End If

            If (count = 1) Then
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "update " & CStr(choice_combo.SelectedItem) & " set [" & CStr(fieldBox.SelectedItem) & "] = '" & value & "' where Username = '" & username_text.Text & "';"
                'MessageBox.Show(command2.CommandText)
                command2.ExecuteNonQuery()
            Else
                MessageBox.Show("Username does not exist")
                con.Close()
                Exit Sub
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try
        MessageBox.Show("Field Updated!!")
        username_text.Text = ""
        val_text.Text = ""
        fieldBox.Text = ""
        choice_combo.Text = ""

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
            fieldBox.Items.Clear()
            fieldBox.Items.Add("Password")
            fieldBox.Items.Add("Phone")
            fieldBox.Items.Add("Email")
            fieldBox.Items.Add("EmergencyContactNo")
            fieldBox.Items.Add("MedicalLeaves")
            fieldBox.Items.Add("OrdinaryLeaves")
            fieldBox.Items.Add("AcademicLeaves")
            fieldBox.Items.Add("ParentalLeaves")
        Else
            fieldBox.Items.Clear()
            fieldBox.Items.Add("Password")
            fieldBox.Items.Add("Email")
        End If

        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label1.ForeColor = Color.FromArgb(78, 184, 206)

    End Sub

    Private Sub userUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub username_text_TextChanged(sender As Object, e As EventArgs) Handles username_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label2.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub fieldBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldBox.SelectedIndexChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label3.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub val_text_TextChanged(sender As Object, e As EventArgs) Handles val_text.TextChanged
        Dim label = Me.Controls.OfType(Of Label)()
        For Each lab In label
            lab.ForeColor = Color.White
        Next
        Label4.ForeColor = Color.FromArgb(78, 184, 206)
    End Sub
End Class