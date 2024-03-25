Public Class UnpaidSub

    Private Sub UnpaidSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jdb1DataSet1.DeliveryControlNo' table. You can move, or remove it, as needed.
        Me.DeliveryControlNoTableAdapter1.Fill(Me.Jdb1DataSet1.DeliveryControlNo)
        'TODO: This line of code loads data into the 'JuliesdbDataSet3.DeliveryControlNo' table. You can move, or remove it, as needed.
        FillByToolStripButton1.PerformClick()

    End Sub

    Private Sub FillBy4ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy4ToolStripButton.Click


    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            '  Stock.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            Unpaid.txtControlNo.Text = dr.Cells(0).Value.ToString()
            Unpaid.txtClientNo.Text = dr.Cells(1).Value.ToString()
            Unpaid.txtOrderNo.Text = dr.Cells(2).Value.ToString()
            Unpaid.txtTotalAmount.Text = dr.Cells(10).Value.ToString()
            Me.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DeliveryControlNoTableAdapter1.FillBy(Me.Jdb1DataSet1.DeliveryControlNo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton1.Click
        Try
            Me.DeliveryControlNoTableAdapter1.FillBy(Me.Jdb1DataSet1.DeliveryControlNo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            FillByToolStripButton1.PerformClick()
        Else
            ContactPersonToolStripTextBox.Text = TextBox1.Text
            SearchName.PerformClick()
        End If
    End Sub

    Private Sub SearchName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchName.Click
        Try
            Me.DeliveryControlNoTableAdapter1.FillBy1(Me.Jdb1DataSet1.DeliveryControlNo, ContactPersonToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class