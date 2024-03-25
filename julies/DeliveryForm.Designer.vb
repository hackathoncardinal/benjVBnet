<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryForm))
        Me.txtProcess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeUseDelivery = New System.Windows.Forms.DateTimePicker()
        Me.TimeDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OrderNumber1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JdbDataSet6 = New julies.jdbDataSet6()
        Me.OrderNumber1BindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.txtControlNo = New System.Windows.Forms.TextBox()
        Me.txtClientNo = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.txtContact_Person = New System.Windows.Forms.TextBox()
        Me.txtContact_number = New System.Windows.Forms.TextBox()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.txtDirection = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdUPU = New System.Windows.Forms.RadioButton()
        Me.rdFD = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductPcs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAllPayment = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.FillBy4ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TxtOrderToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TxtOrderToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy4ToolStripButton = New System.Windows.Forms.ToolStripButton()

        Me.JdbDataSet3 = New julies.jdbDataSet3()
        Me.OrderNumber1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderNumber1TableAdapter1 = New julies.jdbDataSet3TableAdapters.OrderNumber1TableAdapter()
        Me.OrderNumber1TableAdapter2 = New julies.jdbDataSet6TableAdapters.OrderNumber1TableAdapter()
        Me.TableAdapterManager = New julies.jdbDataSet6TableAdapters.TableAdapterManager()
        Me.JdbDataSet5 = New julies.jdbDataSet5()
        Me.OrderNumber1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderNumber1TableAdapter3 = New julies.jdbDataSet5TableAdapters.OrderNumber1TableAdapter()
        Me.TableAdapterManager1 = New julies.jdbDataSet5TableAdapters.TableAdapterManager()
        Me.Jdb1DataSet = New julies.jdb1DataSet()
        Me.OrderNumber1BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderNumber1TableAdapter4 = New julies.jdb1DataSetTableAdapters.OrderNumber1TableAdapter()
        Me.TableAdapterManager2 = New julies.jdb1DataSetTableAdapters.TableAdapterManager()
        Me.OrderNumber1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumber1BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jdb1DataSet1 = New julies.jdb1DataSet1()
        Me.OrderNumber1BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderNumber1TableAdapter5 = New julies.jdb1DataSet1TableAdapters.OrderNumber1TableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OrderNoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.OrderNoToolStripTextBox11 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OrderNumber1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JdbDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.FillBy4ToolStrip.SuspendLayout()
        CType(Me.JdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JdbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNumber1BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProcess
        '
        Me.txtProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess.Location = New System.Drawing.Point(794, 638)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(126, 58)
        Me.txtProcess.TabIndex = 0
        Me.txtProcess.Text = "Process"
        Me.txtProcess.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Order No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Delivery To"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TimeUseDelivery)
        Me.GroupBox1.Controls.Add(Me.TimeDelivery)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(577, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 112)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time"
        '
        'TimeUseDelivery
        '
        Me.TimeUseDelivery.CustomFormat = "dd/MMM/yyyy"
        Me.TimeUseDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeUseDelivery.Location = New System.Drawing.Point(66, 64)
        Me.TimeUseDelivery.Name = "TimeUseDelivery"
        Me.TimeUseDelivery.Size = New System.Drawing.Size(227, 20)
        Me.TimeUseDelivery.TabIndex = 28
        '
        'TimeDelivery
        '
        Me.TimeDelivery.CustomFormat = "dd/MMM/yyyy"
        Me.TimeDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeDelivery.Location = New System.Drawing.Point(66, 34)
        Me.TimeDelivery.Name = "TimeDelivery"
        Me.TimeDelivery.Size = New System.Drawing.Size(227, 20)
        Me.TimeDelivery.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Use"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Delivery"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Person"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contact Number"
        '
        'OrderNumber1BindingSource2
        '
        Me.OrderNumber1BindingSource2.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource2.DataSource = Me.JdbDataSet6
        '
        'JdbDataSet6
        '
        Me.JdbDataSet6.DataSetName = "jdbDataSet6"
        Me.JdbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource
        '
        Me.OrderNumber1BindingSource.DataMember = "OrderNumber1"

        '
  
        'txtControlNo
        '
        Me.txtControlNo.Location = New System.Drawing.Point(95, 29)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.ReadOnly = True
        Me.txtControlNo.Size = New System.Drawing.Size(192, 20)
        Me.txtControlNo.TabIndex = 9
        '
        'txtClientNo
        '
        Me.txtClientNo.Location = New System.Drawing.Point(95, 55)
        Me.txtClientNo.Name = "txtClientNo"
        Me.txtClientNo.ReadOnly = True
        Me.txtClientNo.Size = New System.Drawing.Size(191, 20)
        Me.txtClientNo.TabIndex = 10
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(95, 77)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(191, 20)
        Me.txtOrderNo.TabIndex = 11
        '
        'txtContact_Person
        '
        Me.txtContact_Person.Location = New System.Drawing.Point(96, 100)
        Me.txtContact_Person.Name = "txtContact_Person"
        Me.txtContact_Person.Size = New System.Drawing.Size(289, 20)
        Me.txtContact_Person.TabIndex = 12
        '
        'txtContact_number
        '
        Me.txtContact_number.Location = New System.Drawing.Point(96, 131)
        Me.txtContact_number.MaxLength = 11
        Me.txtContact_number.Name = "txtContact_number"
        Me.txtContact_number.Size = New System.Drawing.Size(191, 20)
        Me.txtContact_number.TabIndex = 13
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(95, 158)
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(428, 20)
        Me.txtDelivery.TabIndex = 14
        '
        'txtDirection
        '
        Me.txtDirection.Location = New System.Drawing.Point(95, 184)
        Me.txtDirection.Name = "txtDirection"
        Me.txtDirection.Size = New System.Drawing.Size(428, 20)
        Me.txtDirection.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Direction "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 21)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdUPU)
        Me.GroupBox2.Controls.Add(Me.rdFD)
        Me.GroupBox2.Location = New System.Drawing.Point(578, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 55)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Term Of Payment"
        '
        'rdUPU
        '
        Me.rdUPU.AutoSize = True
        Me.rdUPU.Location = New System.Drawing.Point(126, 22)
        Me.rdUPU.Name = "rdUPU"
        Me.rdUPU.Size = New System.Drawing.Size(92, 17)
        Me.rdUPU.TabIndex = 1
        Me.rdUPU.TabStop = True
        Me.rdUPU.Text = "Upon Pick Up"
        Me.rdUPU.UseVisualStyleBackColor = True
        '
        'rdFD
        '
        Me.rdFD.AutoSize = True
        Me.rdFD.Location = New System.Drawing.Point(17, 22)
        Me.rdFD.Name = "rdFD"
        Me.rdFD.Size = New System.Drawing.Size(70, 17)
        Me.rdFD.TabIndex = 0
        Me.rdFD.TabStop = True
        Me.rdFD.Text = "Fully Paid"
        Me.rdFD.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTotalProductPrice)
        Me.GroupBox3.Controls.Add(Me.txtProductPcs)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtProductStock)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtProductPrice)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtProductName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtProductID)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 152)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chart Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(83, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Total Amount Of Product = "
        '
        'txtTotalProductPrice
        '
        Me.txtTotalProductPrice.Location = New System.Drawing.Point(225, 121)
        Me.txtTotalProductPrice.MaxLength = 11
        Me.txtTotalProductPrice.Name = "txtTotalProductPrice"
        Me.txtTotalProductPrice.ReadOnly = True
        Me.txtTotalProductPrice.Size = New System.Drawing.Size(253, 20)
        Me.txtTotalProductPrice.TabIndex = 24
        '
        'txtProductPcs
        '
        Me.txtProductPcs.Location = New System.Drawing.Point(86, 95)
        Me.txtProductPcs.MaxLength = 11
        Me.txtProductPcs.Name = "txtProductPcs"
        Me.txtProductPcs.Size = New System.Drawing.Size(166, 20)
        Me.txtProductPcs.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Pcs"
        '
        'txtProductStock
        '
        Me.txtProductStock.Location = New System.Drawing.Point(352, 67)
        Me.txtProductStock.MaxLength = 11
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.ReadOnly = True
        Me.txtProductStock.Size = New System.Drawing.Size(130, 20)
        Me.txtProductStock.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(260, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Quantity Stock"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(86, 68)
        Me.txtProductPrice.MaxLength = 11
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.ReadOnly = True
        Me.txtProductPrice.Size = New System.Drawing.Size(166, 20)
        Me.txtProductPrice.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Product Price"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(86, 42)
        Me.txtProductName.MaxLength = 11
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(396, 20)
        Me.txtProductName.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Product Name"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(86, 14)
        Me.txtProductID.MaxLength = 11
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(396, 20)
        Me.txtProductID.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Product ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtAllPayment)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox4.Location = New System.Drawing.Point(577, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(303, 146)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Amount Bill"
        '
        'txtAllPayment
        '
        Me.txtAllPayment.Location = New System.Drawing.Point(129, 63)
        Me.txtAllPayment.MaxLength = 11
        Me.txtAllPayment.Name = "txtAllPayment"
        Me.txtAllPayment.Size = New System.Drawing.Size(166, 20)
        Me.txtAllPayment.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Enter You're Payment : "
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(11, 32)
        Me.txtTotalAmount.MaxLength = 11
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(284, 20)
        Me.txtTotalAmount.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(508, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 54)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Add " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chart"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(510, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 38)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(510, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 46)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FillBy4ToolStrip
        '
        Me.FillBy4ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtOrderToolStripLabel, Me.TxtOrderToolStripTextBox, Me.FillBy4ToolStripButton})
        Me.FillBy4ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy4ToolStrip.Name = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Size = New System.Drawing.Size(932, 25)
        Me.FillBy4ToolStrip.TabIndex = 24
        Me.FillBy4ToolStrip.Text = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Visible = False
        '
        'TxtOrderToolStripLabel
        '
        Me.TxtOrderToolStripLabel.Name = "TxtOrderToolStripLabel"
        Me.TxtOrderToolStripLabel.Size = New System.Drawing.Size(53, 22)
        Me.TxtOrderToolStripLabel.Text = "txtOrder:"
        '
        'TxtOrderToolStripTextBox
        '
        Me.TxtOrderToolStripTextBox.Name = "TxtOrderToolStripTextBox"
        Me.TxtOrderToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy4ToolStripButton
        '
        Me.FillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy4ToolStripButton.Name = "FillBy4ToolStripButton"
        Me.FillBy4ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy4ToolStripButton.Text = "FillBy4"
        '
        'OrderNumber1TableAdapter
        '

        '
        'JdbDataSet3
        '
        Me.JdbDataSet3.DataSetName = "jdbDataSet3"
        Me.JdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource1
        '
        Me.OrderNumber1BindingSource1.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource1.DataSource = Me.JdbDataSet3
        '
        'OrderNumber1TableAdapter1
        '
        Me.OrderNumber1TableAdapter1.ClearBeforeFill = True
        '
        'OrderNumber1TableAdapter2
        '
        Me.OrderNumber1TableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderNumber1TableAdapter = Me.OrderNumber1TableAdapter2
        Me.TableAdapterManager.UpdateOrder = julies.jdbDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JdbDataSet5
        '
        Me.JdbDataSet5.DataSetName = "jdbDataSet5"
        Me.JdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource3
        '
        Me.OrderNumber1BindingSource3.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource3.DataSource = Me.JdbDataSet5
        '
        'OrderNumber1TableAdapter3
        '
        Me.OrderNumber1TableAdapter3.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientFormTableAdapter = Nothing
        Me.TableAdapterManager1.DeliveryControlNoTableAdapter = Nothing
        Me.TableAdapterManager1.OrderNumber1TableAdapter = Me.OrderNumber1TableAdapter3
        Me.TableAdapterManager1.OrderNumberTableAdapter = Nothing
        Me.TableAdapterManager1.RegAdminTableAdapter = Nothing
        Me.TableAdapterManager1.RegGuestTableAdapter = Nothing
        Me.TableAdapterManager1.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager1.Sales_SummaryTableAdapter = Nothing
        Me.TableAdapterManager1.stockTableAdapter = Nothing
        Me.TableAdapterManager1.UnpaidTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = julies.jdbDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Jdb1DataSet
        '
        Me.Jdb1DataSet.DataSetName = "jdb1DataSet"
        Me.Jdb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource4
        '
        Me.OrderNumber1BindingSource4.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource4.DataSource = Me.Jdb1DataSet
        '
        'OrderNumber1TableAdapter4
        '
        Me.OrderNumber1TableAdapter4.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ClientFormTableAdapter = Nothing
        Me.TableAdapterManager2.DeliveryControlNoTableAdapter = Nothing
        Me.TableAdapterManager2.OrderNumber1TableAdapter = Me.OrderNumber1TableAdapter4
        Me.TableAdapterManager2.OrderNumberTableAdapter = Nothing
        Me.TableAdapterManager2.RegAdminTableAdapter = Nothing
        Me.TableAdapterManager2.RegGuestTableAdapter = Nothing
        Me.TableAdapterManager2.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager2.Sales_SummaryTableAdapter = Nothing
        Me.TableAdapterManager2.stockTableAdapter = Nothing
        Me.TableAdapterManager2.UnpaidTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = julies.jdb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderNumber1DataGridView
        '
        Me.OrderNumber1DataGridView.AllowUserToAddRows = False
        Me.OrderNumber1DataGridView.AllowUserToDeleteRows = False
        Me.OrderNumber1DataGridView.AutoGenerateColumns = False
        Me.OrderNumber1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderNumber1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.OrderNumber1DataGridView.DataSource = Me.OrderNumber1BindingSource6
        Me.OrderNumber1DataGridView.Location = New System.Drawing.Point(2, 377)
        Me.OrderNumber1DataGridView.Name = "OrderNumber1DataGridView"
        Me.OrderNumber1DataGridView.ReadOnly = True
        Me.OrderNumber1DataGridView.Size = New System.Drawing.Size(778, 319)
        Me.OrderNumber1DataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProductPrice"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProductPrice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pcs"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pcs"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TotalAmount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TotalAmount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateOrder"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DateOrder"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'OrderNumber1BindingSource6
        '
        Me.OrderNumber1BindingSource6.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource6.DataSource = Me.Jdb1DataSet1
        '
        'Jdb1DataSet1
        '
        Me.Jdb1DataSet1.DataSetName = "jdb1DataSet1"
        Me.Jdb1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderNumber1BindingSource5
        '
        Me.OrderNumber1BindingSource5.DataMember = "OrderNumber1"
        Me.OrderNumber1BindingSource5.DataSource = Me.Jdb1DataSet1
        '
        'OrderNumber1TableAdapter5
        '
        Me.OrderNumber1TableAdapter5.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderNoToolStripLabel, Me.OrderNoToolStripTextBox11, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(940, 25)
        Me.FillByToolStrip.TabIndex = 26
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'OrderNoToolStripLabel
        '
        Me.OrderNoToolStripLabel.Name = "OrderNoToolStripLabel"
        Me.OrderNoToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.OrderNoToolStripLabel.Text = "OrderNo:"
        '
        'OrderNoToolStripTextBox11
        '
        Me.OrderNoToolStripTextBox11.Name = "OrderNoToolStripTextBox11"
        Me.OrderNoToolStripTextBox11.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'DeliveryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.julies.My.Resources.Resources._27101950596
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 716)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.OrderNumber1DataGridView)
        Me.Controls.Add(Me.FillBy4ToolStrip)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDirection)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDelivery)
        Me.Controls.Add(Me.txtContact_number)
        Me.Controls.Add(Me.txtContact_Person)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.txtClientNo)
        Me.Controls.Add(Me.txtControlNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DeliveryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeliveryForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OrderNumber1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JdbDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.FillBy4ToolStrip.ResumeLayout(False)
        Me.FillBy4ToolStrip.PerformLayout()
        CType(Me.JdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JdbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jdb1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNumber1BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProcess As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtControlNo As System.Windows.Forms.TextBox
    Friend WithEvents txtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents txtContact_Person As System.Windows.Forms.TextBox
    Friend WithEvents txtContact_number As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents txtDirection As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdUPU As System.Windows.Forms.RadioButton
    Friend WithEvents rdFD As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TimeUseDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimeDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProductPcs As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProductStock As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox

    Friend WithEvents OrderNumber1BindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents FillBy4ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtOrderToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtOrderToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy4ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAllPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents JdbDataSet3 As julies.jdbDataSet3
    Friend WithEvents OrderNumber1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter1 As julies.jdbDataSet3TableAdapters.OrderNumber1TableAdapter
    Friend WithEvents JdbDataSet6 As julies.jdbDataSet6
    Friend WithEvents OrderNumber1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter2 As julies.jdbDataSet6TableAdapters.OrderNumber1TableAdapter
    Friend WithEvents TableAdapterManager As julies.jdbDataSet6TableAdapters.TableAdapterManager
    Friend WithEvents JdbDataSet5 As julies.jdbDataSet5
    Friend WithEvents OrderNumber1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter3 As julies.jdbDataSet5TableAdapters.OrderNumber1TableAdapter
    Friend WithEvents TableAdapterManager1 As julies.jdbDataSet5TableAdapters.TableAdapterManager
    Friend WithEvents Jdb1DataSet As julies.jdb1DataSet
    Friend WithEvents OrderNumber1BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter4 As julies.jdb1DataSetTableAdapters.OrderNumber1TableAdapter
    Friend WithEvents TableAdapterManager2 As julies.jdb1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderNumber1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jdb1DataSet1 As julies.jdb1DataSet1
    Friend WithEvents OrderNumber1BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderNumber1TableAdapter5 As julies.jdb1DataSet1TableAdapters.OrderNumber1TableAdapter
    Friend WithEvents OrderNumber1BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OrderNoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OrderNoToolStripTextBox11 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
End Class
