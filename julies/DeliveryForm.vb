Imports System.Data.OleDb
Imports System.Data
Public Class DeliveryForm

    Dim con As OleDbConnection
    Dim Command As OleDbCommand

    Private Sub DeliveryForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtClientNo.Clear()
        Button5.PerformClick()
        txtContact_number.Clear()
        txtDelivery.Clear()
        txtDirection.Clear()
        Me.Close()
    End Sub

    Private Sub DeliveryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jdb1DataSet1.OrderNumber1' table. You can move, or remove it, as needed.
        Me.OrderNumber1TableAdapter5.Fill(Me.Jdb1DataSet1.OrderNumber1)

        Dim ddd As Date = Now
        txtControlNo.Text = "Crt-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")
        txtOrderNo.Text = "OD-" + ddd.ToString("yyyy") + "00" + ddd.ToString("dd") + ddd.ToString("mm") + ddd.ToString("ss")
        TxtOrderToolStripTextBox.Text = txtOrderNo.Text
        FillByToolStripButton.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeliverySubForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DeliverySubFormItem.ShowDialog()
    End Sub

    Private Sub txtProductPcs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductPcs.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProductPcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductPcs.TextChanged
        If Val(txtProductPcs.Text) <= Val(txtProductStock.Text) Then
            Dim iii As Integer = 0
            Dim iii1 As Integer = 0
            iii = CInt(Val(txtProductPrice.Text) + 0) * CInt(Val(txtProductPcs.Text) + 0) + 0
            txtTotalProductPrice.Text = iii + 0
        Else
            MessageBox.Show("The Item Stock is Only '" & txtProductStock.Text & "' ")
            txtProductPcs.Text = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Clears()
    End Sub
    Sub Clears()
        txtProductID.Clear()
        txtProductName.Clear()
        txtProductPrice.Clear()
        txtProductPcs.Clear()
        txtProductStock.Clear()
        txtTotalProductPrice.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '-----------------------------------------Update Section
        con = New OleDbConnection
        con.ConnectionString = Stock.ConString
        Dim Reader As OleDbDataReader
        Dim Reader1 As OleDbDataReader
        Try
            con.Open()
            Dim Query As String

            Query = "UPDATE [stock] SET [Date]='" & TimeUseDelivery.Text & "',Quantity='" & CInt(Val(txtProductStock.Text + 0) - Val(txtProductPcs.Text + 0)) & "' where ProductID='" & txtProductID.Text & "'"
            Command = New OleDbCommand(Query, con)
            Reader = Command.ExecuteReader
            con.Close()
            MessageBox.Show("Data Update")
            Me.OrderNumber1TableAdapter3.Fill(Me.JdbDataSet5.OrderNumber1)
            con.Open()
            Dim Query1 As String
            Query1 = "insert into [OrderNumber1](OrderNo,ProductID,ProductName,ProductPrice,Pcs,TotalAmount,DateOrder)  VALUES ('" & txtOrderNo.Text & _
                 "','" & txtProductID.Text & "','" & txtProductName.Text & "','" & CInt(txtProductPrice.Text) & "','" & CInt(txtProductPcs.Text) & "','" & CInt(txtTotalProductPrice.Text) & "','" & TimeDelivery.Text & "')"
            Command = New OleDbCommand(Query1, con)
            Reader1 = Command.ExecuteReader
            MessageBox.Show("Data Save '" & txtOrderNo.Text & "'")
            Me.OrderNumber1TableAdapter5.Fill(Me.Jdb1DataSet1.OrderNumber1)
            OrderNoToolStripTextBox11.Text = txtOrderNo.Text
            FillByToolStripButton.PerformClick()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        txtTotalAmount.Text = Val(txtTotalProductPrice.Text) + Val(txtTotalAmount.Text)
        MessageBox.Show("Successfully Update", "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Button5.PerformClick()
    End Sub

    Private Sub FillBy4ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy4ToolStripButton.Click
        '''' revoke
    End Sub

    Private Sub txtProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcess.Click
        'Table name is DeliveryControlNo

        If txtClientNo.Text = Nothing Then
            Beep()
            MsgBox("Youre ClientNo is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If txtContact_Person.Text = Nothing Then
            Beep()
            MsgBox("Youre Contact_Person is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If txtContact_number.Text = Nothing Then
            Beep()
            MsgBox("Youre Contact_Number is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If


        If txtDelivery.Text = Nothing Then
            Beep()
            MsgBox("Youre Delivery is Empty", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If rdFD.Checked = False And rdUPU.Checked = False Then
            Beep()
            MsgBox("Please Enter Youre Terms Of Payment", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        If rdFD.Checked = True Then
            If txtAllPayment.Text = Nothing Then
                Beep()
                MsgBox("Youre Payment is Empty", MsgBoxStyle.Information, "Warning")
                Exit Sub
            End If

            If Val(txtTotalAmount.Text) > Val(txtAllPayment.Text) Then
                Beep()
                MsgBox("Youre insufficient Money ", MsgBoxStyle.Information, "Warning")
                Exit Sub
            End If
        End If
        con.Close()
        '   Try

        If rdFD.Checked = True Then
            Dim Reader2 As OleDbDataReader
            con.Open()
            Dim Query2 As String
            Query2 = "insert into [DeliveryControlNo](ControlNo,ClientNo,OrderNo,ContactPerson,ContactNumber,Deliverto,Direction,Deliverytime,Deliveryuse,TermsOfPayment,TotalAmount,TotalPayment,TotalChange)  VALUES ('" & txtControlNo.Text & _
                 "','" & txtClientNo.Text & "','" & txtOrderNo.Text & "','" & txtContact_Person.Text & "','" & txtContact_number.Text & "','" & txtDelivery.Text & "','" & txtDirection.Text & "','" & TimeDelivery.Text & "','" & TimeUseDelivery.Text & "','" & "Fully_Paid" & "','" & CInt(txtTotalAmount.Text) & "','" & CInt(txtAllPayment.Text) & "','" & CInt(CInt(txtAllPayment.Text + 0) - CInt(txtTotalAmount.Text + 0)) & "')"
            Command = New OleDbCommand(Query2, con)
            Reader2 = Command.ExecuteReader
            MessageBox.Show("Data Process And Save '" & txtControlNo.Text & "'")
            con.Close()
        ElseIf rdUPU.Checked = True Then
            Dim Reader3 As OleDbDataReader
            con.Open()
            Dim Query3 As String
            Query3 = "insert into [DeliveryControlNo](ControlNo,ClientNo,OrderNo,ContactPerson,ContactNumber,Deliverto,Direction,Deliverytime,Deliveryuse,TermsOfPayment,TotalAmount,TotalPayment,TotalChange)  VALUES ('" & txtControlNo.Text & _
                 "','" & txtClientNo.Text & "','" & txtOrderNo.Text & "','" & txtContact_Person.Text & "','" & txtContact_number.Text & "','" & txtDelivery.Text & "','" & txtDirection.Text & "','" & TimeDelivery.Text & "','" & TimeUseDelivery.Text & "','" & "UnPaid" & "','" & CInt(txtTotalAmount.Text) & "','" & CInt(txtAllPayment.Text) & "','" & "0" & "')"
            Command = New OleDbCommand(Query3, con)
            Reader3 = Command.ExecuteReader
            MessageBox.Show(".Data Process And Save '" & txtControlNo.Text & "'")
            con.Close()
            Me.Close()
        End If
        '      Catch ex As Exception
        '    MsgBox(ex.Message + "")
        '      End Try
        Me.Refresh()

    End Sub

    Private Sub rdUPU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUPU.CheckedChanged
        If rdUPU.Checked = True Then
            txtAllPayment.Text = "0"
            Label16.Visible = False
            txtAllPayment.Visible = False
        Else

        End If
    End Sub

    Private Sub rdFD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFD.CheckedChanged
        If rdFD.Checked = True Then
            Label16.Visible = True
            txtAllPayment.Visible = True
        Else
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.OrderNumber1TableAdapter5.FillBy(Me.Jdb1DataSet1.OrderNumber1, OrderNoToolStripTextBox11.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class