<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_Stock = New System.Windows.Forms.Button()
        Me.btn_Home = New System.Windows.Forms.Button()
        Me.btn_Client = New System.Windows.Forms.Button()
        Me.btn_Registration = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_unpaid = New System.Windows.Forms.Button()
        Me.btn_SalesSummary = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jdb1DataSet1 = New julies.jdb1DataSet1()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Delivery = New System.Windows.Forms.Button()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ClientNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsOfPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryControlNoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryControlNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TxtPaymentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPaymentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StockTableAdapter1 = New julies.jdb1DataSet1TableAdapters.stockTableAdapter()
        Me.UnpaidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnpaidTableAdapter = New julies.jdb1DataSet1TableAdapters.UnpaidTableAdapter()
        Me.DeliveryControlNoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryControlNoTableAdapter1 = New julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnpaidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Stock
        '
        Me.btn_Stock.Location = New System.Drawing.Point(373, 19)
        Me.btn_Stock.Name = "btn_Stock"
        Me.btn_Stock.Size = New System.Drawing.Size(75, 50)
        Me.btn_Stock.TabIndex = 0
        Me.btn_Stock.Text = "Stock"
        Me.btn_Stock.UseVisualStyleBackColor = True
        '
        'btn_Home
        '
        Me.btn_Home.Location = New System.Drawing.Point(17, 19)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Size = New System.Drawing.Size(107, 50)
        Me.btn_Home.TabIndex = 1
        Me.btn_Home.Text = "Home"
        Me.btn_Home.UseVisualStyleBackColor = True
        '
        'btn_Client
        '
        Me.btn_Client.Location = New System.Drawing.Point(292, 19)
        Me.btn_Client.Name = "btn_Client"
        Me.btn_Client.Size = New System.Drawing.Size(75, 50)
        Me.btn_Client.TabIndex = 2
        Me.btn_Client.Text = "Client"
        Me.btn_Client.UseVisualStyleBackColor = True
        '
        'btn_Registration
        '
        Me.btn_Registration.Location = New System.Drawing.Point(130, 19)
        Me.btn_Registration.Name = "btn_Registration"
        Me.btn_Registration.Size = New System.Drawing.Size(75, 50)
        Me.btn_Registration.TabIndex = 3
        Me.btn_Registration.Text = "Registration"
        Me.btn_Registration.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(697, 19)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 50)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_unpaid
        '
        Me.btn_unpaid.Location = New System.Drawing.Point(454, 19)
        Me.btn_unpaid.Name = "btn_unpaid"
        Me.btn_unpaid.Size = New System.Drawing.Size(75, 50)
        Me.btn_unpaid.TabIndex = 5
        Me.btn_unpaid.Text = "Unpaid"
        Me.btn_unpaid.UseVisualStyleBackColor = True
        '
        'btn_SalesSummary
        '
        Me.btn_SalesSummary.Location = New System.Drawing.Point(535, 19)
        Me.btn_SalesSummary.Name = "btn_SalesSummary"
        Me.btn_SalesSummary.Size = New System.Drawing.Size(75, 50)
        Me.btn_SalesSummary.TabIndex = 6
        Me.btn_SalesSummary.Text = "Sales Summary"
        Me.btn_SalesSummary.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(772, 493)
        Me.DataGridView1.TabIndex = 7
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "Item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        Me.ItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockBindingSource1
        '
        Me.StockBindingSource1.DataMember = "stock"
        Me.StockBindingSource1.DataSource = Me.Jdb1DataSet1
        '
        'Jdb1DataSet1
        '
        Me.Jdb1DataSet1.DataSetName = "jdb1DataSet1"
        Me.Jdb1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Stock In"
        '
        'btn_Delivery
        '
        Me.btn_Delivery.Location = New System.Drawing.Point(211, 19)
        Me.btn_Delivery.Name = "btn_Delivery"
        Me.btn_Delivery.Size = New System.Drawing.Size(75, 50)
        Me.btn_Delivery.TabIndex = 9
        Me.btn_Delivery.Text = "Delivery"
        Me.btn_Delivery.UseVisualStyleBackColor = True
        '
        'btn_about
        '
        Me.btn_about.Location = New System.Drawing.Point(616, 19)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(75, 50)
        Me.btn_about.TabIndex = 10
        Me.btn_about.Text = "About"
        Me.btn_about.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUser, Me.tsUsername})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 638)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1355, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsUser
        '
        Me.tsUser.Name = "tsUser"
        Me.tsUser.Size = New System.Drawing.Size(30, 17)
        Me.tsUser.Text = "User"
        '
        'tsUsername
        '
        Me.tsUsername.Name = "tsUsername"
        Me.tsUsername.Size = New System.Drawing.Size(80, 17)
        Me.tsUsername.Text = "Administrator"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNoDataGridViewTextBoxColumn, Me.ControlNo, Me.ClientNo, Me.TermsOfPayment, Me.OrderNoDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DeliveryControlNoBindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(778, 142)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(577, 493)
        Me.DataGridView2.TabIndex = 12
        '
        'ClientNoDataGridViewTextBoxColumn
        '
        Me.ClientNoDataGridViewTextBoxColumn.DataPropertyName = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.HeaderText = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.Name = "ClientNoDataGridViewTextBoxColumn"
        Me.ClientNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientNoDataGridViewTextBoxColumn.Width = 72
        '
        'ControlNo
        '
        Me.ControlNo.DataPropertyName = "ControlNo"
        Me.ControlNo.HeaderText = "ControlNo"
        Me.ControlNo.Name = "ControlNo"
        Me.ControlNo.ReadOnly = True
        Me.ControlNo.Width = 79
        '
        'ClientNo
        '
        Me.ClientNo.DataPropertyName = "ClientNo"
        Me.ClientNo.HeaderText = "ClientNo"
        Me.ClientNo.Name = "ClientNo"
        Me.ClientNo.ReadOnly = True
        Me.ClientNo.Width = 72
        '
        'TermsOfPayment
        '
        Me.TermsOfPayment.DataPropertyName = "TermsOfPayment"
        Me.TermsOfPayment.HeaderText = "TermsOfPayment"
        Me.TermsOfPayment.Name = "TermsOfPayment"
        Me.TermsOfPayment.ReadOnly = True
        Me.TermsOfPayment.Width = 113
        '
        'OrderNoDataGridViewTextBoxColumn
        '
        Me.OrderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.Name = "OrderNoDataGridViewTextBoxColumn"
        Me.OrderNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderNoDataGridViewTextBoxColumn.Width = 72
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 92
        '
        'DeliveryControlNoBindingSource2
        '
        Me.DeliveryControlNoBindingSource2.DataMember = "DeliveryControlNo"
        Me.DeliveryControlNoBindingSource2.DataSource = Me.Jdb1DataSet1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(778, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "&UnPaid Delivery Details   / Upon Pick Up"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtPaymentToolStripLabel, Me.TxtPaymentToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1355, 25)
        Me.FillBy1ToolStrip.TabIndex = 14
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
        '
        'TxtPaymentToolStripLabel
        '
        Me.TxtPaymentToolStripLabel.Name = "TxtPaymentToolStripLabel"
        Me.TxtPaymentToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.TxtPaymentToolStripLabel.Text = "txtPayment:"
        '
        'TxtPaymentToolStripTextBox
        '
        Me.TxtPaymentToolStripTextBox.Name = "TxtPaymentToolStripTextBox"
        Me.TxtPaymentToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.julies.My.Resources.Resources.julies
        Me.PictureBox1.Location = New System.Drawing.Point(778, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(557, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(142, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'UnpaidBindingSource
        '
        Me.UnpaidBindingSource.DataMember = "Unpaid"
        Me.UnpaidBindingSource.DataSource = Me.Jdb1DataSet1
        '
        'UnpaidTableAdapter
        '
        Me.UnpaidTableAdapter.ClearBeforeFill = True
        '
        'DeliveryControlNoBindingSource1
        '
        Me.DeliveryControlNoBindingSource1.DataMember = "DeliveryControlNo"
        Me.DeliveryControlNoBindingSource1.DataSource = Me.Jdb1DataSet1
        '
        'DeliveryControlNoTableAdapter1
        '
        Me.DeliveryControlNoTableAdapter1.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1355, 25)
        Me.FillByToolStrip.TabIndex = 17
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.julies.My.Resources.Resources._27101950596
        Me.ClientSize = New System.Drawing.Size(1355, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.btn_Delivery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_SalesSummary)
        Me.Controls.Add(Me.btn_unpaid)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_Registration)
        Me.Controls.Add(Me.btn_Client)
        Me.Controls.Add(Me.btn_Home)
        Me.Controls.Add(Me.btn_Stock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnpaidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Stock As System.Windows.Forms.Button
    Friend WithEvents btn_Home As System.Windows.Forms.Button
    Friend WithEvents btn_Client As System.Windows.Forms.Button
    Friend WithEvents btn_Registration As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_unpaid As System.Windows.Forms.Button
    Friend WithEvents btn_SalesSummary As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Delivery As System.Windows.Forms.Button
    Friend WithEvents btn_about As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUsername As System.Windows.Forms.ToolStripStatusLabel

    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label

    Friend WithEvents DeliveryControlNoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtPaymentToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtPaymentToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Jdb1DataSet1 As julies.jdb1DataSet1
    Friend WithEvents StockBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter1 As julies.jdb1DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents UnpaidBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnpaidTableAdapter As julies.jdb1DataSet1TableAdapters.UnpaidTableAdapter
    Friend WithEvents DeliveryControlNoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryControlNoTableAdapter1 As julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter
    Friend WithEvents ClientNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsOfPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryControlNoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
End Class
