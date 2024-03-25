<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DeliveryControlNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.Button1 = New System.Windows.Forms.Button()

        Me.FillBy3ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TxtPaymentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPaymentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy3ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FillBy1Fully_PaidToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1Fully_PaidToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClientNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelivertoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliverytimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryControlNoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jdb1DataSet1 = New julies.jdb1DataSet1()
        Me.SalesSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_SummaryTableAdapter = New julies.jdb1DataSet1TableAdapters.Sales_SummaryTableAdapter()
        Me.DeliveryControlNoTableAdapter1 = New julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.FillBy3ToolStrip.SuspendLayout()
        Me.FillBy1Fully_PaidToolStrip.SuspendLayout()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Summary"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNoDataGridViewTextBoxColumn, Me.OrderNoDataGridViewTextBoxColumn, Me.ControlNoDataGridViewTextBoxColumn, Me.ContactPersonDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.DelivertoDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.DeliverytimeDataGridViewTextBoxColumn, Me.DeliveryuseDataGridViewTextBoxColumn, Me.TermsOfPaymentDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.TotalPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DeliveryControlNoBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(13, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1296, 591)
        Me.DataGridView1.TabIndex = 1
        '


        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1234, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Export Excel"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False

        '
        'FillBy3ToolStrip
        '
        Me.FillBy3ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtPaymentToolStripLabel, Me.TxtPaymentToolStripTextBox, Me.FillBy3ToolStripButton})
        Me.FillBy3ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy3ToolStrip.Name = "FillBy3ToolStrip"
        Me.FillBy3ToolStrip.Size = New System.Drawing.Size(1329, 25)
        Me.FillBy3ToolStrip.TabIndex = 10
        Me.FillBy3ToolStrip.Text = "FillBy3ToolStrip"
        Me.FillBy3ToolStrip.Visible = False
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
        'FillBy3ToolStripButton
        '
        Me.FillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy3ToolStripButton.Name = "FillBy3ToolStripButton"
        Me.FillBy3ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy3ToolStripButton.Text = "FillBy3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FillBy1Fully_PaidToolStrip
        '
        Me.FillBy1Fully_PaidToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1Fully_PaidToolStripButton})
        Me.FillBy1Fully_PaidToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1Fully_PaidToolStrip.Name = "FillBy1Fully_PaidToolStrip"
        Me.FillBy1Fully_PaidToolStrip.Size = New System.Drawing.Size(1329, 25)
        Me.FillBy1Fully_PaidToolStrip.TabIndex = 11
        Me.FillBy1Fully_PaidToolStrip.Text = "FillBy1Fully_PaidToolStrip"
        Me.FillBy1Fully_PaidToolStrip.Visible = False
        '
        'FillBy1Fully_PaidToolStripButton
        '
        Me.FillBy1Fully_PaidToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1Fully_PaidToolStripButton.Name = "FillBy1Fully_PaidToolStripButton"
        Me.FillBy1Fully_PaidToolStripButton.Size = New System.Drawing.Size(98, 22)
        Me.FillBy1Fully_PaidToolStripButton.Text = "FillBy1Fully_Paid"
        '
        'ClientNoDataGridViewTextBoxColumn
        '
        Me.ClientNoDataGridViewTextBoxColumn.DataPropertyName = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.HeaderText = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.Name = "ClientNoDataGridViewTextBoxColumn"
        Me.ClientNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderNoDataGridViewTextBoxColumn
        '
        Me.OrderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.Name = "OrderNoDataGridViewTextBoxColumn"
        Me.OrderNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ControlNoDataGridViewTextBoxColumn
        '
        Me.ControlNoDataGridViewTextBoxColumn.DataPropertyName = "ControlNo"
        Me.ControlNoDataGridViewTextBoxColumn.HeaderText = "ControlNo"
        Me.ControlNoDataGridViewTextBoxColumn.Name = "ControlNoDataGridViewTextBoxColumn"
        Me.ControlNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactPersonDataGridViewTextBoxColumn
        '
        Me.ContactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson"
        Me.ContactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson"
        Me.ContactPersonDataGridViewTextBoxColumn.Name = "ContactPersonDataGridViewTextBoxColumn"
        Me.ContactPersonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelivertoDataGridViewTextBoxColumn
        '
        Me.DelivertoDataGridViewTextBoxColumn.DataPropertyName = "Deliverto"
        Me.DelivertoDataGridViewTextBoxColumn.HeaderText = "Deliverto"
        Me.DelivertoDataGridViewTextBoxColumn.Name = "DelivertoDataGridViewTextBoxColumn"
        Me.DelivertoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DirectionDataGridViewTextBoxColumn
        '
        Me.DirectionDataGridViewTextBoxColumn.DataPropertyName = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.HeaderText = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.Name = "DirectionDataGridViewTextBoxColumn"
        Me.DirectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeliverytimeDataGridViewTextBoxColumn
        '
        Me.DeliverytimeDataGridViewTextBoxColumn.DataPropertyName = "Deliverytime"
        Me.DeliverytimeDataGridViewTextBoxColumn.HeaderText = "Deliverytime"
        Me.DeliverytimeDataGridViewTextBoxColumn.Name = "DeliverytimeDataGridViewTextBoxColumn"
        Me.DeliverytimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeliveryuseDataGridViewTextBoxColumn
        '
        Me.DeliveryuseDataGridViewTextBoxColumn.DataPropertyName = "Deliveryuse"
        Me.DeliveryuseDataGridViewTextBoxColumn.HeaderText = "Deliveryuse"
        Me.DeliveryuseDataGridViewTextBoxColumn.Name = "DeliveryuseDataGridViewTextBoxColumn"
        Me.DeliveryuseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TermsOfPaymentDataGridViewTextBoxColumn
        '
        Me.TermsOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "TermsOfPayment"
        Me.TermsOfPaymentDataGridViewTextBoxColumn.HeaderText = "TermsOfPayment"
        Me.TermsOfPaymentDataGridViewTextBoxColumn.Name = "TermsOfPaymentDataGridViewTextBoxColumn"
        Me.TermsOfPaymentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPaymentDataGridViewTextBoxColumn
        '
        Me.TotalPaymentDataGridViewTextBoxColumn.DataPropertyName = "TotalPayment"
        Me.TotalPaymentDataGridViewTextBoxColumn.HeaderText = "TotalPayment"
        Me.TotalPaymentDataGridViewTextBoxColumn.Name = "TotalPaymentDataGridViewTextBoxColumn"
        Me.TotalPaymentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeliveryControlNoBindingSource1
        '
        Me.DeliveryControlNoBindingSource1.DataMember = "DeliveryControlNo"
        Me.DeliveryControlNoBindingSource1.DataSource = Me.Jdb1DataSet1
        '
        'Jdb1DataSet1
        '
        Me.Jdb1DataSet1.DataSetName = "jdb1DataSet1"
        Me.Jdb1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesSummaryBindingSource
        '
        Me.SalesSummaryBindingSource.DataMember = "Sales_Summary"
        Me.SalesSummaryBindingSource.DataSource = Me.Jdb1DataSet1
        '
        'Sales_SummaryTableAdapter
        '
        Me.Sales_SummaryTableAdapter.ClearBeforeFill = True
        '
        'DeliveryControlNoTableAdapter1
        '
        Me.DeliveryControlNoTableAdapter1.ClearBeforeFill = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1329, 655)
        Me.Controls.Add(Me.FillBy1Fully_PaidToolStrip)
        Me.Controls.Add(Me.FillBy3ToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.FillBy3ToolStrip.ResumeLayout(False)
        Me.FillBy3ToolStrip.PerformLayout()
        Me.FillBy1Fully_PaidToolStrip.ResumeLayout(False)
        Me.FillBy1Fully_PaidToolStrip.PerformLayout()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Friend WithEvents DeliveryControlNoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ClientNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBy3ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtPaymentToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtPaymentToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy3ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Jdb1DataSet1 As julies.jdb1DataSet1
    Friend WithEvents SalesSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sales_SummaryTableAdapter As julies.jdb1DataSet1TableAdapters.Sales_SummaryTableAdapter
    Friend WithEvents ControlNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelivertoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliverytimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryuseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsOfPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryControlNoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryControlNoTableAdapter1 As julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter
    Friend WithEvents FillBy1Fully_PaidToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1Fully_PaidToolStripButton As System.Windows.Forms.ToolStripButton
End Class
