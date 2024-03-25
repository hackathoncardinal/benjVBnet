Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class RegistrationForm
    Dim con As OleDbConnection
    Dim Command As OleDbCommand
    Private Sub txtRetype_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRetype.TextChanged
        If Not txtpassword.Text = txtRetype.Text Then
            Label5.Visible = True
            Label5.Text = "Password Dismatch"
            Label5.ForeColor() = Color.Red
        Else
            Label5.ForeColor() = Color.Green
            Label5.Text = "Password Match"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(TxtUsername.Text)) = 0 Then
            MessageBox.Show("Erorr You're  Username is Empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("Error You're  Name is Empty ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If

        If rdAdministration.Checked = False And rdGuest.Checked = False Then
            MessageBox.Show("Error Usertype is Empty ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "select * from [Registration] where  Username='" & TxtUsername.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            Dim c As Integer
            c = 0
            While Reader.Read
                c = c + 1
            End While
            If c >= 1 Then
                MessageBox.Show(" UserName IS Already Exist " + vbCrLf + "Please Choose a Unique Username")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try



        '----------------------

        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        '  Dim Reader As SqlDataReader

        Try
            con.Open()
            Dim Query As String

            Query = "insert into [Registration]([Name],[Username],[Password],[User_Type])  VALUES ('" & txtName.Text & "','" & TxtUsername.Text & "','" & txtpassword.Text & "','" & Label6.Text & "')"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            MessageBox.Show("..Data Save")
            con.Close()

            txtName.Clear()
            txtpassword.Clear()
            TxtUsername.Clear()
            txtRetype.Clear()
            rdAdministration.Checked = False
            rdGuest.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message + "")
        End Try
        con.Close()


    End Sub

    Private Sub rdGuest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdGuest.CheckedChanged
        If rdGuest.Checked = True Then
            Label6.Text = rdGuest.Text
        End If
    End Sub

    Private Sub rdAdministration_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAdministration.CheckedChanged
        If rdAdministration.Checked = True Then
            Label6.Text = rdAdministration.Text
        End If
    End Sub
End Class