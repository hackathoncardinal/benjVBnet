<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliverySubForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliverySubForm))
        Me.StockBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JdbDataSet1 = New julies.jdbDataSet1()
        Me.ClientFormBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientFormTableAdapter1 = New julies.jdbDataSet1TableAdapters.ClientFormTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientFormBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JdbDataSet2 = New julies.jdbDataSet2()
        Me.ClientFormTableAdapter2 = New julies.jdbDataSet2TableAdapters.ClientFormTableAdapter()
        Me.JdbDataSet5 = New julies.jdbDataSet5()
        Me.ClientFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientFormTableAdapter = New julies.jdbDataSet5TableAdapters.ClientFormTableAdapter()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientFormBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientFormBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JdbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JdbDataSet1
        '
        Me.JdbDataSet1.DataSetName = "jdbDataSet1"
        Me.JdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientFormBindingSource1
        '
        Me.ClientFormBindingSource1.DataMember = "ClientForm"
        Me.ClientFormBindingSource1.DataSource = Me.JdbDataSet1
        '
        'ClientFormTableAdapter1
        '
        Me.ClientFormTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientFormBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(798, 301)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientNoDataGridViewTextBoxColumn
        '
        Me.ClientNoDataGridViewTextBoxColumn.DataPropertyName = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.HeaderText = "ClientNo"
        Me.ClientNoDataGridViewTextBoxColumn.Name = "ClientNoDataGridViewTextBoxColumn"
        Me.ClientNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientFormBindingSource2
        '
        Me.ClientFormBindingSource2.DataMember = "ClientForm"
        Me.ClientFormBindingSource2.DataSource = Me.JdbDataSet2
        '
        'JdbDataSet2
        '
        Me.JdbDataSet2.DataSetName = "jdbDataSet2"
        Me.JdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientFormTableAdapter2
        '
        Me.ClientFormTableAdapter2.ClearBeforeFill = True
        '
        'JdbDataSet5
        '
        Me.JdbDataSet5.DataSetName = "jdbDataSet5"
        Me.JdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientFormBindingSource
        '
        Me.ClientFormBindingSource.DataMember = "ClientForm"
        Me.ClientFormBindingSource.DataSource = Me.JdbDataSet5
        '
        'ClientFormTableAdapter
        '
        Me.ClientFormTableAdapter.ClearBeforeFill = True
        '
        'DeliverySubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 326)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeliverySubForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeliveryCLientForm"
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientFormBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientFormBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JdbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents StockBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents JdbDataSet1 As julies.jdbDataSet1
    Friend WithEvents ClientFormBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientFormTableAdapter1 As julies.jdbDataSet1TableAdapters.ClientFormTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents JdbDataSet2 As julies.jdbDataSet2
    Friend WithEvents ClientFormBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientFormTableAdapter2 As julies.jdbDataSet2TableAdapters.ClientFormTableAdapter
    Friend WithEvents ClientNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JdbDataSet5 As julies.jdbDataSet5
    Friend WithEvents ClientFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientFormTableAdapter As julies.jdbDataSet5TableAdapters.ClientFormTableAdapter
End Class
