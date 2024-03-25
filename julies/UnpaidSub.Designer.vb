<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnpaidSub
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ControlNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DeliveryControlNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      
        Me.FillBy4ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TxtPaymentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPaymentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy4ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeliveryControlNoTableAdapter1 = New julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolsForSearch = New System.Windows.Forms.ToolStrip()
        Me.ContactPersonToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ContactPersonToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchName = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.FillBy4ToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillByToolStrip1.SuspendLayout()
        Me.ToolsForSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ControlNoDataGridViewTextBoxColumn, Me.ClientNoDataGridViewTextBoxColumn, Me.OrderNoDataGridViewTextBoxColumn, Me.ContactPersonDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.DelivertoDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.DeliverytimeDataGridViewTextBoxColumn, Me.DeliveryuseDataGridViewTextBoxColumn, Me.TermsOfPaymentDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.TotalPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DeliveryControlNoBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(3, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1318, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'ControlNoDataGridViewTextBoxColumn
        '
        Me.ControlNoDataGridViewTextBoxColumn.DataPropertyName = "ControlNo"
        Me.ControlNoDataGridViewTextBoxColumn.HeaderText = "ControlNo"
        Me.ControlNoDataGridViewTextBoxColumn.Name = "ControlNoDataGridViewTextBoxColumn"
        Me.ControlNoDataGridViewTextBoxColumn.ReadOnly = True
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
 
        '
        'FillBy4ToolStrip
        '
        Me.FillBy4ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtPaymentToolStripLabel, Me.TxtPaymentToolStripTextBox, Me.FillBy4ToolStripButton})
        Me.FillBy4ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy4ToolStrip.Name = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Size = New System.Drawing.Size(1323, 25)
        Me.FillBy4ToolStrip.TabIndex = 1
        Me.FillBy4ToolStrip.Text = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Visible = False
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
        'FillBy4ToolStripButton
        '
        Me.FillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy4ToolStripButton.Name = "FillBy4ToolStripButton"
        Me.FillBy4ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy4ToolStripButton.Text = "FillBy4"
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
        Me.FillByToolStrip.Size = New System.Drawing.Size(1321, 25)
        Me.FillByToolStrip.TabIndex = 2
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
        'FillByToolStrip1
        '
        Me.FillByToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton1})
        Me.FillByToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip1.Name = "FillByToolStrip1"
        Me.FillByToolStrip1.Size = New System.Drawing.Size(1323, 25)
        Me.FillByToolStrip1.TabIndex = 3
        Me.FillByToolStrip1.Text = "FillByToolStrip1"
        Me.FillByToolStrip1.Visible = False
        '
        'FillByToolStripButton1
        '
        Me.FillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton1.Name = "FillByToolStripButton1"
        Me.FillByToolStripButton1.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton1.Text = "FillBy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(77, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 26)
        Me.TextBox1.TabIndex = 5
        '
        'ToolsForSearch
        '
        Me.ToolsForSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactPersonToolStripLabel, Me.ContactPersonToolStripTextBox, Me.SearchName})
        Me.ToolsForSearch.Location = New System.Drawing.Point(0, 0)
        Me.ToolsForSearch.Name = "ToolsForSearch"
        Me.ToolsForSearch.Size = New System.Drawing.Size(1323, 25)
        Me.ToolsForSearch.TabIndex = 6
        Me.ToolsForSearch.Text = "FillBy1ToolStrip"
        Me.ToolsForSearch.Visible = False
        '
        'ContactPersonToolStripLabel
        '
        Me.ContactPersonToolStripLabel.Name = "ContactPersonToolStripLabel"
        Me.ContactPersonToolStripLabel.Size = New System.Drawing.Size(88, 22)
        Me.ContactPersonToolStripLabel.Text = "ContactPerson:"
        '
        'ContactPersonToolStripTextBox
        '
        Me.ContactPersonToolStripTextBox.Name = "ContactPersonToolStripTextBox"
        Me.ContactPersonToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SearchName
        '
        Me.SearchName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(78, 22)
        Me.SearchName.Text = "SearchName"
        '
        'UnpaidSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1323, 430)
        Me.Controls.Add(Me.ToolsForSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FillBy4ToolStrip)
        Me.Controls.Add(Me.FillByToolStrip1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UnpaidSub"
        Me.Text = "UnpaidSub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.FillBy4ToolStrip.ResumeLayout(False)
        Me.FillBy4ToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillByToolStrip1.ResumeLayout(False)
        Me.FillByToolStrip1.PerformLayout()
        Me.ToolsForSearch.ResumeLayout(False)
        Me.ToolsForSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

    Friend WithEvents DeliveryControlNoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ControlNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelivertoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliverytimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryuseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsOfPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBy4ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtPaymentToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtPaymentToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy4ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Jdb1DataSet1 As julies.jdb1DataSet1
    Friend WithEvents DeliveryControlNoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryControlNoTableAdapter1 As julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolsForSearch As System.Windows.Forms.ToolStrip
    Friend WithEvents ContactPersonToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContactPersonToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchName As System.Windows.Forms.ToolStripButton
End Class
