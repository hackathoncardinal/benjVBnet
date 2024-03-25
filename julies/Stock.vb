Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Stock

    Public ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\jdb\jdb.accdb"
    Dim con As OleDbConnection
    Dim Command As OleDbCommand

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JdbDataSet4.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter2.Fill(Me.JdbDataSet4.stock)
   
        Dim ddd As Date = Now
        txt_productid.Text = "PID-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ddd As Date = Now

        txt_productid.Text = "PID-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")

        If Len(Trim(txt_Item.Text)) = 0 Then
            MessageBox.Show("Please select product Item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Item.Focus()
            Exit Sub
        End If
        If Len(Trim(txt_Name.Text)) = 0 Then
            MessageBox.Show("Please select Name ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Name.Focus()
            Exit Sub
        End If
        If Len(Trim(txt_Price.Text)) = 0 Then
            MessageBox.Show("Please select txt_Price ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Price.Focus()
            Exit Sub
        End If
        If Len(Trim(txt_Quantity.Text)) = 0 Then
            MessageBox.Show("Please select txt_Quantity ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quantity.Focus()
            Exit Sub
        End If
        '------------

        con = New OleDbConnection
        con.ConnectionString = ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "select * from [stock] where  Item='" & txt_Item.Text & "' and Name='" & txt_Name.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            Dim c As Integer
            c = 0
            While Reader.Read
                c = c + 1
            End While
            If c >= 1 Then
                MessageBox.Show("Product Name And Item IS Already Exist " + vbCrLf + "Please Go to Update/Edit Section")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        con = New OleDbConnection
        con.ConnectionString = ConString
        '   Dim Reader As SqlDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "insert into [stock]([ProductID],[Item],[Name],[Price],[Quantity],[Date])  VALUES ('" & txt_productid.Text & "','" & txt_Item.Text & "','" & txt_Name.Text & "','" & CInt(txt_Price.Text) & "','" & CInt(txt_Quantity.Text) & "','" & dtpStockDate.Text & "')"

            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            MessageBox.Show("Data Save")
            Me.StockTableAdapter2.Fill(Me.JdbDataSet4.stock)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        'MessageBox.Show("Successfully saved", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()
        Me.StockTableAdapter2.Fill(Me.JdbDataSet4.stock)
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        StockSubUpdate.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        StockSubDelete.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Len(Trim(txtUItem.Text)) = 0 Then
            MessageBox.Show("Please select product Item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Item.Focus()
            Exit Sub
        End If
        If Len(Trim(TxtUname.Text)) = 0 Then
            MessageBox.Show("Please select Name ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Name.Focus()
            Exit Sub
        End If
        If Len(Trim(txtUprice.Text)) = 0 Then
            MessageBox.Show("Please select txt_Price ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Price.Focus()
            Exit Sub
        End If
        If Len(Trim(txtUQuantity.Text)) = 0 Then
            MessageBox.Show("Please select txt_Quantity ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quantity.Focus()
            Exit Sub
        End If
        If Len(Trim(txtUPID.Text)) = 0 Then
            MessageBox.Show("Please select ProductID ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quantity.Focus()
            Exit Sub
        End If
        '--------------------

        '--------------------
        con = New OleDbConnection
        con.ConnectionString = ConString
        Dim Reader As OleDbDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "UPDATE [stock] SET ProductID='" & txtUPID.Text & "',Item='" & txtUItem.Text & "',Name='" & TxtUname.Text & "',Price='" & txtUprice.Text & "',Quantity='" & txtUQuantity.Text & "' WHERE ProductID='" & txtUPID.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            MessageBox.Show("Data Update")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        MessageBox.Show("Successfully Update", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()
        Me.StockTableAdapter2.Fill(Me.JdbDataSet4.stock)
    End Sub
    Sub clear()
        txt_Item.Clear()
        txt_Name.Clear()
        txt_Price.Clear()
        txt_productid.Clear()
        txt_Quantity.Clear()
        txtDitem.Clear()
        txtDName.Clear()
        txtDPID.Clear()
        txtDPrice.Clear()
        txtDQuantity.Clear()
        txtUItem.Clear()
        TxtUname.Clear()
        txtUPID.Clear()
        txtUprice.Clear()
        txtUQuantity.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Len(Trim(txtDPID.Text)) = 0 Then
            MessageBox.Show("Please select ProductID ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDPID.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDName.Text)) = 0 Then
            MessageBox.Show("Please select Name ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDPrice.Text)) = 0 Then
            MessageBox.Show("Please select txt_Price ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDPrice.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDitem.Text)) = 0 Then
            MessageBox.Show("Please select product Item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDitem.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDQuantity.Text)) = 0 Then
            MessageBox.Show("Please select Quantity ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDQuantity.Focus()
            Exit Sub
        End If

        '--------------------

        If MsgBox("Do you Want To Delete This Product *'" & txtDPID.Text & "'*", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            con = New OleDbConnection
            con.ConnectionString = ConString
            Dim Reader As OleDbDataReader
            Try
                con.Open()
                Dim Query As String
                '  Query = "insert into stock(ProductID,Item,Name,Price,Quantity,Date)  VALUES ('" & txt_productid.Text & "','" & txt_Item.Text & "','" & txt_Name.Text & "','" & CInt(txt_Price.Text) & "','" & CInt(txt_Quantity.Text) & "','" & dtpStockDate.Text & "')"
                ' Query = "update stock set Date='" & txtUDate.Text & "',Item='" & txtUItem.Text & "',Name='" & TxtUname.Text & "',Price='" & CInt(txtUprice.Text) & "',Quantity='" & CInt(txtUQuantity.Text) & "' where ProductID='" & txtUPID.Text & "'"
                Query = "delete from [stock] where ProductID='" & txtDPID.Text & "'"
                Command = New OleDbCommand(Query, con)
                Reader = Command.ExecuteReader
                MessageBox.Show("Data Delete")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            MessageBox.Show("Successfully Deleted", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        Me.StockTableAdapter2.Fill(Me.JdbDataSet4.stock)
    End Sub

    Private Sub txt_Price_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Quantity.KeyPress, txt_Price.KeyPress, txtUQuantity.KeyPress, txtUprice.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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
End Class