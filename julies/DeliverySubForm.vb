Public Class DeliverySubForm

    Private Sub DeliverySubForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JdbDataSet5.ClientForm' table. You can move, or remove it, as needed.
        Me.ClientFormTableAdapter.Fill(Me.JdbDataSet5.ClientForm)

    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            DeliveryForm.txtClientNo.Text = dr.Cells(0).Value.ToString()
            DeliveryForm.txtContact_Person.Text = dr.Cells(1).Value.ToString()
            DeliveryForm.txtDelivery.Text = dr.Cells(2).Value.ToString()
            DeliveryForm.txtContact_number.Text = dr.Cells(3).Value.ToString()

            Me.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class