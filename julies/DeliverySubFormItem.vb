Public Class DeliverySubFormItem

    Private Sub DeliverySubFormItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JdbDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.JdbDataSet.stock)

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            DeliveryForm.txtProductID.Text = dr.Cells(0).Value.ToString()
            DeliveryForm.txtProductName.Text = dr.Cells(1).Value.ToString() + " ; " + dr.Cells(2).Value.ToString()
            DeliveryForm.txtProductPrice.Text = dr.Cells(3).Value.ToString()
            DeliveryForm.txtProductStock.Text = dr.Cells(4).Value.ToString()
           
            Me.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


End Class