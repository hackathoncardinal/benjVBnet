Imports System.Data.OleDb

Public Class Client_form
    Dim con As OleDbConnection
    Dim Command As OleDbCommand


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(txtClientNo.Text)) = 0 Then
            MessageBox.Show("Please select ClientNo Item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClientNo.Focus()
            Exit Sub
        End If

        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("Please select Name ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If
        If Len(Trim(txt_Address.Text)) = 0 Then
            MessageBox.Show("Please select Address ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Address.Focus()
            Exit Sub
        End If
        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please select ContactNo Item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClientNo.Focus()
            Exit Sub
        End If



        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "insert into [ClientForm](ClientNo,Name,Address,ContactNo,DateCreated)  VALUES ('" & txtClientNo.Text & "','" & txtName.Text & "','" & txt_Address.Text & "','" & txtContactNo.Text & "','" & txtDataCreated.Text & "')"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            MessageBox.Show("ClientNo Data Save")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try

    End Sub

    Private Sub Client_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ddd As Date = Now
        txtClientNo.Text = "CN-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")
    End Sub
End Class