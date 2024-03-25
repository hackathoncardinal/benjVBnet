Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class LoginForm
    Dim con As OleDbConnection
    Dim Command As OleDbCommand
    Dim warning As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Erorr You're  Username is Empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Erorr You're  Password is Empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If

        If rdAdministration.Checked = False And rdGuest.Checked = False Then
            MessageBox.Show("User type Is Uncheck")
            Exit Sub
        End If

        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "select * from [Registration] where  Username='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' and User_Type='" & Label6.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            Dim c As Integer
            c = 0
            While Reader.Read
                c = c + 1
            End While

            If c = 1 Then
                warning = 0
                MessageBox.Show("Access Granted" + vbCrLf + "")
                MainForm.Show()
                Me.Close()
            Else

                warning = warning + 1
                Beep()
                MessageBox.Show("3 attentication Program Will Shutdown")
                If warning = 3 Then
                    MsgBox("3 Attempt Failed Force ShutDown", MsgBoxStyle.Critical, "Program Close")
                    Me.Close()
                End If
                MessageBox.Show("Access Denied" + TextBox1.Text + TextBox2.Text + Label6.Text)
                TextBox2.Clear()
                TextBox1.Focus()
                rdAdministration.Checked = False
                rdGuest.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
