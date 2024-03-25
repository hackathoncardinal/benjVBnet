Public Class MainForm

    Private Sub btn_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Registration.Click
        PictureBox2.Visible = False
        RegistrationForm.ShowDialog()
    End Sub

    Private Sub btn_Invoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client.Click
        PictureBox2.Visible = False
        Client_form.ShowDialog()
    End Sub

    Private Sub btn_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stock.Click
        PictureBox2.Visible = False
        Stock.ShowDialog()
    End Sub

    Private Sub btn_unpaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_unpaid.Click
        PictureBox2.Visible = False
        Unpaid.ShowDialog()
    End Sub

    Private Sub btn_SalesSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalesSummary.Click
        PictureBox2.Visible = False
        Sales.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        PictureBox2.Visible = False
        Beep()
        If MsgBox("Oops", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Delivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delivery.Click
        PictureBox2.Visible = False
        DeliveryForm.ShowDialog()
    End Sub

    Private Sub btn_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_about.Click
        PictureBox2.Visible = False
        AboutForm.Show()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PictureBox2.Visible = False
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        'TODO: This line of code loads data into the 'Jdb1DataSet1.DeliveryControlNo' table. You can move, or remove it, as needed.
        Me.DeliveryControlNoTableAdapter1.Fill(Me.Jdb1DataSet1.DeliveryControlNo)
        'TODO: This line of code loads data into the 'Jdb1DataSet1.Unpaid' table. You can move, or remove it, as needed.
        Me.UnpaidTableAdapter.Fill(Me.Jdb1DataSet1.Unpaid)
        'TODO: This line of code loads data into the 'Jdb1DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.Jdb1DataSet1.stock)
        'TODO: This line of code loads data into the 'JuliesdbDataSet.stock' table. You can move, or remove it, as needed.

        tsUser.Text = "Login As : " + LoginForm.Label6.Text
        tsUsername.Text = "Name : " + LoginForm.TextBox1.Text

        If tsUser.Text = "Login As : " + "Guest" Then
            btn_Registration.Enabled = False
            '--------------deliveryform
            DeliveryForm.Button3.Enabled = False
            DeliveryForm.Button4.Enabled = False
            DeliveryForm.txtProcess.Enabled = False
            DeliveryForm.Button2.Enabled = False
            '--------------deliveryform
        End If
        If tsUser.Text = "Login As : " + "Admin" Then
            btn_Registration.Enabled = True
        End If

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        FillByToolStripButton.PerformClick()
    End Sub

    Private Sub btn_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home.Click
        PictureBox2.Visible = True
    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click


    End Sub


    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DeliveryControlNoTableAdapter1.FillBy(Me.Jdb1DataSet1.DeliveryControlNo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class