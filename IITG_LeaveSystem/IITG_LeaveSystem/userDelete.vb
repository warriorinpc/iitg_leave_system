Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class userDelete

    Public Property con As OleDbConnection

    Private Sub userDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.AutoSize = True
        'Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
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

            If (count = 1) Then
                Dim command2 As OleDbCommand = New OleDbCommand()
                command2.Connection = con
                command2.CommandText = "delete from " & CStr(choice_combo.SelectedItem) & " where Username='" & username_text.Text & "';"
                command2.ExecuteNonQuery()

                'Also Update Leave Table
                Dim command3 As OleDbCommand = New OleDbCommand()
                command3.CommandText = "Select LeaveId From Leave Where Applicant = '" & username_text.Text & "'; "
                command3.Connection = con
                Dim reader2 As OleDbDataReader = command3.ExecuteReader()
                Dim leavenum As Integer
                While (reader2.Read)
                    leavenum = (reader2.GetInt32(0))
                    'MessageBox.Show(leavenum)
                    Dim command4 As OleDbCommand = New OleDbCommand()
                    command4.Connection = con
                    command4.CommandText = "update Leave set ApprovalStatus = 'Deleted' where LeaveId=" & leavenum & ";"
                    'MessageBox.Show(command2.CommandText)
                    command4.ExecuteNonQuery()
                End While
            Else
                MessageBox.Show("Username not found")
                con.Close()
                Exit Sub
            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Exit Sub
        End Try

        MessageBox.Show("User Deleted along with all the leave requests")
        username_text.Text = ""
        choice_combo.Text = ""
    End Sub

    Private Sub choice_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choice_combo.SelectedIndexChanged
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
End Class