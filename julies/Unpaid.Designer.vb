<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unpaid
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
        Me.DeliveryControlNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_paid = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtControlNo = New System.Windows.Forms.TextBox()
        Me.ClientNo = New System.Windows.Forms.Label()
        Me.txtClientNo = New System.Windows.Forms.TextBox()
        Me.txtAllPayment = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FillBy4ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TxtPaymentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPaymentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy4ToolStripButton = New System.Windows.Forms.ToolStripButton()

        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClientNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelivertoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliverytimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryControlNoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jdb1DataSet1 = New julies.jdb1DataSet1()
        Me.UnpaidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnpaidTableAdapter = New julies.jdb1DataSet1TableAdapters.UnpaidTableAdapter()
        Me.DeliveryControlNoTableAdapter1 = New julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.GroupBox1.SuspendLayout()
        Me.FillBy4ToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnpaidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNoDataGridViewTextBoxColumn, Me.OrderNoDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.ControlNoDataGridViewTextBoxColumn, Me.ContactPersonDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.DelivertoDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.DeliverytimeDataGridViewTextBoxColumn, Me.DeliveryuseDataGridViewTextBoxColumn, Me.TermsOfPaymentDataGridViewTextBoxColumn, Me.TotalPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DeliveryControlNoBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1033, 304)
        Me.DataGridView1.TabIndex = 0
        '
    
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unpaid Delivery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1140, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Control #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_paid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtControlNo)
        Me.GroupBox1.Controls.Add(Me.ClientNo)
        Me.GroupBox1.Controls.Add(Me.txtClientNo)
        Me.GroupBox1.Controls.Add(Me.txtAllPayment)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrderNo)
        Me.GroupBox1.Location = New System.Drawing.Point(1051, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 259)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btn_paid
        '
        Me.btn_paid.Location = New System.Drawing.Point(158, 230)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(91, 23)
        Me.btn_paid.TabIndex = 35
        Me.btn_paid.Text = "Paid"
        Me.btn_paid.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Control Number"
        '
        'txtControlNo
        '
        Me.txtControlNo.Location = New System.Drawing.Point(11, 32)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.ReadOnly = True
        Me.txtControlNo.Size = New System.Drawing.Size(238, 20)
        Me.txtControlNo.TabIndex = 33
        '
        'ClientNo
        '
        Me.ClientNo.AutoSize = True
        Me.ClientNo.Location = New System.Drawing.Point(107, 102)
        Me.ClientNo.Name = "ClientNo"
        Me.ClientNo.Size = New System.Drawing.Size(47, 13)
        Me.ClientNo.TabIndex = 32
        Me.ClientNo.Text = "ClientNo"
        '
        'txtClientNo
        '
        Me.txtClientNo.Location = New System.Drawing.Point(18, 118)
        Me.txtClientNo.Name = "txtClientNo"
        Me.txtClientNo.ReadOnly = True
        Me.txtClientNo.Size = New System.Drawing.Size(223, 20)
        Me.txtClientNo.TabIndex = 31
        '
        'txtAllPayment
        '
        Me.txtAllPayment.Location = New System.Drawing.Point(18, 204)
        Me.txtAllPayment.MaxLength = 11
        Me.txtAllPayment.Name = "txtAllPayment"
        Me.txtAllPayment.Size = New System.Drawing.Size(231, 20)
        Me.txtAllPayment.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(80, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Enter You're Payment : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Amount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(18, 164)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(223, 20)
        Me.txtTotalAmount.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Order No."
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(11, 78)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(238, 20)
        Me.txtOrderNo.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(970, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Export Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1143, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FillBy4ToolStrip
        '
        Me.FillBy4ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtPaymentToolStripLabel, Me.TxtPaymentToolStripTextBox, Me.FillBy4ToolStripButton})
        Me.FillBy4ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy4ToolStrip.Name = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Size = New System.Drawing.Size(1332, 25)
        Me.FillBy4ToolStrip.TabIndex = 37
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

        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1332, 25)
        Me.FillByToolStrip.TabIndex = 38
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
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
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
        'UnpaidBindingSource
        '
        Me.UnpaidBindingSource.DataMember = "Unpaid"
        Me.UnpaidBindingSource.DataSource = Me.Jdb1DataSet1
        '
        'UnpaidTableAdapter
        '
        Me.UnpaidTableAdapter.ClearBeforeFill = True
        '
        'DeliveryControlNoTableAdapter1
        '
        Me.DeliveryControlNoTableAdapter1.ClearBeforeFill = True
        '
        'Unpaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 379)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.FillBy4ToolStrip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Unpaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unpaid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryControlNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FillBy4ToolStrip.ResumeLayout(False)
        Me.FillBy4ToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.DeliveryControlNoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnpaidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAllPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_paid As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtControlNo As System.Windows.Forms.TextBox
    Friend WithEvents ClientNo As System.Windows.Forms.Label
    Friend WithEvents txtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

    Friend WithEvents DeliveryControlNoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ClientNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBy4ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtPaymentToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtPaymentToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy4ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Jdb1DataSet1 As julies.jdb1DataSet1
    Friend WithEvents UnpaidBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnpaidTableAdapter As julies.jdb1DataSet1TableAdapters.UnpaidTableAdapter
    Friend WithEvents ControlNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelivertoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliverytimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryuseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsOfPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryControlNoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryControlNoTableAdapter1 As julies.jdb1DataSet1TableAdapters.DeliveryControlNoTableAdapter
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
End Class
