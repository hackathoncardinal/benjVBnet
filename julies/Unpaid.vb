Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Imports System.Security.Cryptography
Imports System.Text

Public Class Unpaid

    Dim con As OleDbConnection
    Dim Command As OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 0
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub btn_paid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paid.Click
        If txtControlNo.Text = Nothing Then
            Beep()
            MsgBox("You're ControlNo TextBox is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If txtAllPayment.Text = Nothing Then
            Beep()
            MessageBox.Show("Payment is Empty")
            Exit Sub
        End If

        If CInt(txtTotalAmount.Text) > CInt(txtAllPayment.Text) Then
            MsgBox("Youre insufficient Money ", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If


        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "update [DeliveryControlNo] set [TermsOfPayment]='" & "Fully_Paid" & "',TotalPayment='" & txtAllPayment.Text & "',TotalChange='" & CInt(txtAllPayment.Text) - CInt(txtTotalAmount.Text) & "' where ControlNo='" & txtControlNo.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            MessageBox.Show("Data Update")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        MessageBox.Show("Successfully Update", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear()
    End Sub

    Sub Clear()
        txtAllPayment.Clear()
        txtClientNo.Clear()
        txtControlNo.Clear()
        txtOrderNo.Clear()
        txtTotalAmount.Clear()
    End Sub

    Private Sub Unpaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jdb1DataSet1.DeliveryControlNo' table. You can move, or remove it, as needed.
       ' Me.DeliveryControlNoTableAdapter1.Fill(Me.Jdb1DataSet1.DeliveryControlNo)
        'TODO: This line of code loads data into the 'Jdb1DataSet1.Unpaid' table. You can move, or remove it, as needed.
        Me.UnpaidTableAdapter.Fill(Me.Jdb1DataSet1.Unpaid)
        'TODO: This line of code loads data into the 'JuliesdbDataSet3.DeliveryControlNo' table. You can move, or remove it, as needed.
        TxtPaymentToolStripTextBox.Text = "UnPaid"
        FillByToolStripButton.PerformClick()
    End Sub

 

  

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TxtPaymentToolStripTextBox.Text = "UnPaid"
        FillByToolStripButton.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UnpaidSub.ShowDialog()
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DeliveryControlNoTableAdapter1.FillBy(Me.Jdb1DataSet1.DeliveryControlNo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class