<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesOrder))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblRecStatus = New System.Windows.Forms.ToolStripLabel()
        Me.txtNetto = New System.Windows.Forms.TextBox()
        Me.lblNetto = New System.Windows.Forms.Label()
        Me.txtBruto = New System.Windows.Forms.TextBox()
        Me.lblBruto = New System.Windows.Forms.Label()
        Me.txtNilaiPPN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPPN = New System.Windows.Forms.TextBox()
        Me.lblPPN = New System.Windows.Forms.Label()
        Me.txtNilaiDiscount = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemSatuan = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNilaiHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSalesName = New System.Windows.Forms.Label()
        Me.txtSalesCode = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSalesCode = New System.Windows.Forms.Label()
        Me.lblShipDate = New System.Windows.Forms.Label()
        Me.dtShipDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPOCust = New System.Windows.Forms.TextBox()
        Me.lblPOCustomer = New System.Windows.Forms.Label()
        Me.lblSODate = New System.Windows.Forms.Label()
        Me.dtSODate = New System.Windows.Forms.DateTimePicker()
        Me.txtSONumber = New System.Windows.Forms.TextBox()
        Me.lblSONumber = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerAddress2 = New System.Windows.Forms.TextBox()
        Me.lblCustomerAddress2 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress1 = New System.Windows.Forms.TextBox()
        Me.lblCustomerAddress1 = New System.Windows.Forms.Label()
        Me.txtOrderName = New System.Windows.Forms.TextBox()
        Me.lblOrderName = New System.Windows.Forms.Label()
        Me.cbIsTaxable = New System.Windows.Forms.CheckBox()
        Me.txtCustomerVLT = New System.Windows.Forms.TextBox()
        Me.lblCustomerVLT = New System.Windows.Forms.Label()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.lblCustomerCode = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNetto)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblNetto)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtBruto)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblBruto)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNilaiPPN)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label14)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtPPN)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblPPN)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNilaiDiscount)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtSubTotal)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblSubtotal)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label12)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtDiscount)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblDiscount)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtDescription)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblDescription)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1062, 556)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1062, 606)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.ToolStripSeparator1, Me.btnSave, Me.btnDelete, Me.ToolStripSeparator2, Me.btnExit, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.lblRecStatus})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(193, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "Status : "
        '
        'lblRecStatus
        '
        Me.lblRecStatus.Name = "lblRecStatus"
        Me.lblRecStatus.Size = New System.Drawing.Size(88, 22)
        Me.lblRecStatus.Text = "ToolStripLabel2"
        Me.lblRecStatus.Visible = False
        '
        'txtNetto
        '
        Me.txtNetto.Enabled = False
        Me.txtNetto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetto.Location = New System.Drawing.Point(720, 483)
        Me.txtNetto.MaxLength = 7
        Me.txtNetto.Name = "txtNetto"
        Me.txtNetto.Size = New System.Drawing.Size(182, 23)
        Me.txtNetto.TabIndex = 73
        '
        'lblNetto
        '
        Me.lblNetto.AutoSize = True
        Me.lblNetto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNetto.Location = New System.Drawing.Point(647, 486)
        Me.lblNetto.Name = "lblNetto"
        Me.lblNetto.Size = New System.Drawing.Size(37, 15)
        Me.lblNetto.TabIndex = 74
        Me.lblNetto.Text = "Netto"
        '
        'txtBruto
        '
        Me.txtBruto.Enabled = False
        Me.txtBruto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(720, 454)
        Me.txtBruto.MaxLength = 7
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.Size = New System.Drawing.Size(182, 23)
        Me.txtBruto.TabIndex = 71
        '
        'lblBruto
        '
        Me.lblBruto.AutoSize = True
        Me.lblBruto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBruto.Location = New System.Drawing.Point(647, 457)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(36, 15)
        Me.lblBruto.TabIndex = 72
        Me.lblBruto.Text = "Bruto"
        '
        'txtNilaiPPN
        '
        Me.txtNilaiPPN.Enabled = False
        Me.txtNilaiPPN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilaiPPN.Location = New System.Drawing.Point(477, 509)
        Me.txtNilaiPPN.MaxLength = 7
        Me.txtNilaiPPN.Name = "txtNilaiPPN"
        Me.txtNilaiPPN.Size = New System.Drawing.Size(116, 23)
        Me.txtNilaiPPN.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(440, 515)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 15)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "%  ="
        '
        'txtPPN
        '
        Me.txtPPN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPN.Location = New System.Drawing.Point(385, 509)
        Me.txtPPN.MaxLength = 7
        Me.txtPPN.Name = "txtPPN"
        Me.txtPPN.Size = New System.Drawing.Size(38, 23)
        Me.txtPPN.TabIndex = 67
        '
        'lblPPN
        '
        Me.lblPPN.AutoSize = True
        Me.lblPPN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPPN.Location = New System.Drawing.Point(311, 515)
        Me.lblPPN.Name = "lblPPN"
        Me.lblPPN.Size = New System.Drawing.Size(30, 15)
        Me.lblPPN.TabIndex = 68
        Me.lblPPN.Text = "PPN"
        '
        'txtNilaiDiscount
        '
        Me.txtNilaiDiscount.Enabled = False
        Me.txtNilaiDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilaiDiscount.Location = New System.Drawing.Point(477, 480)
        Me.txtNilaiDiscount.MaxLength = 7
        Me.txtNilaiDiscount.Name = "txtNilaiDiscount"
        Me.txtNilaiDiscount.Size = New System.Drawing.Size(116, 23)
        Me.txtNilaiDiscount.TabIndex = 66
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(385, 451)
        Me.txtSubTotal.MaxLength = 7
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(208, 23)
        Me.txtSubTotal.TabIndex = 64
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSubtotal.Location = New System.Drawing.Point(311, 457)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(56, 15)
        Me.lblSubtotal.TabIndex = 65
        Me.lblSubtotal.Text = "Sub Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(440, 486)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "%  ="
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(385, 480)
        Me.txtDiscount.MaxLength = 7
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(38, 23)
        Me.txtDiscount.TabIndex = 59
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiscount.Location = New System.Drawing.Point(311, 486)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(54, 15)
        Me.lblDiscount.TabIndex = 62
        Me.lblDiscount.Text = "Discount"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(87, 451)
        Me.txtDescription.MaxLength = 7
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(210, 60)
        Me.txtDescription.TabIndex = 60
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescription.Location = New System.Drawing.Point(14, 454)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(67, 15)
        Me.lblDescription.TabIndex = 61
        Me.lblDescription.Text = "Description"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemCode, Me.colItemName, Me.colItemSatuan, Me.colItemPrice, Me.colQty, Me.colNilaiHarga})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(884, 207)
        Me.DataGridView1.TabIndex = 58
        '
        'colItemCode
        '
        Me.colItemCode.FillWeight = 120.0!
        Me.colItemCode.HeaderText = "Item Code"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.ReadOnly = True
        Me.colItemCode.Width = 120
        '
        'colItemName
        '
        Me.colItemName.HeaderText = "Item Name"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Width = 200
        '
        'colItemSatuan
        '
        Me.colItemSatuan.HeaderText = "Unit"
        Me.colItemSatuan.Name = "colItemSatuan"
        '
        'colItemPrice
        '
        Me.colItemPrice.FillWeight = 150.0!
        Me.colItemPrice.HeaderText = "Item Price"
        Me.colItemPrice.Name = "colItemPrice"
        Me.colItemPrice.ReadOnly = True
        Me.colItemPrice.Width = 150
        '
        'colQty
        '
        Me.colQty.FillWeight = 120.0!
        Me.colQty.HeaderText = "Quantity"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 120
        '
        'colNilaiHarga
        '
        Me.colNilaiHarga.FillWeight = 150.0!
        Me.colNilaiHarga.HeaderText = "Amount"
        Me.colNilaiHarga.Name = "colNilaiHarga"
        Me.colNilaiHarga.ReadOnly = True
        Me.colNilaiHarga.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSalesName)
        Me.GroupBox1.Controls.Add(Me.txtSalesCode)
        Me.GroupBox1.Controls.Add(Me.lblSalesCode)
        Me.GroupBox1.Controls.Add(Me.lblShipDate)
        Me.GroupBox1.Controls.Add(Me.dtShipDate)
        Me.GroupBox1.Controls.Add(Me.lblSODate)
        Me.GroupBox1.Controls.Add(Me.dtSODate)
        Me.GroupBox1.Controls.Add(Me.txtSONumber)
        Me.GroupBox1.Controls.Add(Me.lblSONumber)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1037, 227)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Transaksi"
        '
        'lblSalesName
        '
        Me.lblSalesName.AutoSize = True
        Me.lblSalesName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSalesName.Location = New System.Drawing.Point(278, 76)
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Size = New System.Drawing.Size(104, 15)
        Me.lblSalesName.TabIndex = 20
        Me.lblSalesName.Text = "lblCustomerName"
        '
        'txtSalesCode
        '
        Me.txtSalesCode.BackColor = System.Drawing.Color.Pink
        Me.txtSalesCode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtSalesCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesCode.Location = New System.Drawing.Point(110, 73)
        Me.txtSalesCode.MaxLength = 7
        Me.txtSalesCode.Name = "txtSalesCode"
        Me.txtSalesCode.Size = New System.Drawing.Size(166, 23)
        Me.txtSalesCode.TabIndex = 18
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFind})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(98, 26)
        '
        'tsFind
        '
        Me.tsFind.Name = "tsFind"
        Me.tsFind.Size = New System.Drawing.Size(97, 22)
        Me.tsFind.Text = "Find"
        '
        'lblSalesCode
        '
        Me.lblSalesCode.AutoSize = True
        Me.lblSalesCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSalesCode.Location = New System.Drawing.Point(19, 76)
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Size = New System.Drawing.Size(64, 15)
        Me.lblSalesCode.TabIndex = 19
        Me.lblSalesCode.Text = "Sales Code"
        '
        'lblShipDate
        '
        Me.lblShipDate.AutoSize = True
        Me.lblShipDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblShipDate.Location = New System.Drawing.Point(715, 14)
        Me.lblShipDate.Name = "lblShipDate"
        Me.lblShipDate.Size = New System.Drawing.Size(57, 15)
        Me.lblShipDate.TabIndex = 17
        Me.lblShipDate.Text = "Ship Date"
        '
        'dtShipDate
        '
        Me.dtShipDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtShipDate.Location = New System.Drawing.Point(806, 12)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(225, 22)
        Me.dtShipDate.TabIndex = 16
        '
        'txtPOCust
        '
        Me.txtPOCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOCust.Location = New System.Drawing.Point(778, 16)
        Me.txtPOCust.MaxLength = 7
        Me.txtPOCust.Name = "txtPOCust"
        Me.txtPOCust.Size = New System.Drawing.Size(225, 23)
        Me.txtPOCust.TabIndex = 14
        '
        'lblPOCustomer
        '
        Me.lblPOCustomer.AutoSize = True
        Me.lblPOCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPOCustomer.Location = New System.Drawing.Point(687, 19)
        Me.lblPOCustomer.Name = "lblPOCustomer"
        Me.lblPOCustomer.Size = New System.Drawing.Size(78, 15)
        Me.lblPOCustomer.TabIndex = 15
        Me.lblPOCustomer.Text = "PO Customer"
        '
        'lblSODate
        '
        Me.lblSODate.AutoSize = True
        Me.lblSODate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSODate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSODate.Location = New System.Drawing.Point(19, 47)
        Me.lblSODate.Name = "lblSODate"
        Me.lblSODate.Size = New System.Drawing.Size(49, 15)
        Me.lblSODate.TabIndex = 10
        Me.lblSODate.Text = "SO Date"
        '
        'dtSODate
        '
        Me.dtSODate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSODate.Location = New System.Drawing.Point(110, 45)
        Me.dtSODate.Name = "dtSODate"
        Me.dtSODate.Size = New System.Drawing.Size(225, 22)
        Me.dtSODate.TabIndex = 9
        '
        'txtSONumber
        '
        Me.txtSONumber.Enabled = False
        Me.txtSONumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSONumber.Location = New System.Drawing.Point(110, 16)
        Me.txtSONumber.MaxLength = 7
        Me.txtSONumber.Name = "txtSONumber"
        Me.txtSONumber.Size = New System.Drawing.Size(166, 23)
        Me.txtSONumber.TabIndex = 7
        '
        'lblSONumber
        '
        Me.lblSONumber.AutoSize = True
        Me.lblSONumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSONumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSONumber.Location = New System.Drawing.Point(19, 19)
        Me.lblSONumber.Name = "lblSONumber"
        Me.lblSONumber.Size = New System.Drawing.Size(69, 15)
        Me.lblSONumber.TabIndex = 8
        Me.lblSONumber.Text = "SO Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCustomerAddress2)
        Me.GroupBox2.Controls.Add(Me.lblCustomerAddress2)
        Me.GroupBox2.Controls.Add(Me.txtCustomerAddress1)
        Me.GroupBox2.Controls.Add(Me.lblCustomerAddress1)
        Me.GroupBox2.Controls.Add(Me.txtOrderName)
        Me.GroupBox2.Controls.Add(Me.cbIsTaxable)
        Me.GroupBox2.Controls.Add(Me.txtCustomerVLT)
        Me.GroupBox2.Controls.Add(Me.lblOrderName)
        Me.GroupBox2.Controls.Add(Me.lblCustomerVLT)
        Me.GroupBox2.Controls.Add(Me.txtPOCust)
        Me.GroupBox2.Controls.Add(Me.lblPOCustomer)
        Me.GroupBox2.Controls.Add(Me.txtCustomerCode)
        Me.GroupBox2.Controls.Add(Me.lblCustomerCode)
        Me.GroupBox2.Controls.Add(Me.lblCustomerName)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1009, 116)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'txtCustomerAddress2
        '
        Me.txtCustomerAddress2.Enabled = False
        Me.txtCustomerAddress2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress2.Location = New System.Drawing.Point(372, 48)
        Me.txtCustomerAddress2.MaxLength = 7
        Me.txtCustomerAddress2.Name = "txtCustomerAddress2"
        Me.txtCustomerAddress2.Size = New System.Drawing.Size(306, 23)
        Me.txtCustomerAddress2.TabIndex = 25
        '
        'lblCustomerAddress2
        '
        Me.lblCustomerAddress2.AutoSize = True
        Me.lblCustomerAddress2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerAddress2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerAddress2.Location = New System.Drawing.Point(281, 51)
        Me.lblCustomerAddress2.Name = "lblCustomerAddress2"
        Me.lblCustomerAddress2.Size = New System.Drawing.Size(72, 15)
        Me.lblCustomerAddress2.TabIndex = 26
        Me.lblCustomerAddress2.Text = "2nd Address"
        '
        'txtCustomerAddress1
        '
        Me.txtCustomerAddress1.Enabled = False
        Me.txtCustomerAddress1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress1.Location = New System.Drawing.Point(372, 16)
        Me.txtCustomerAddress1.MaxLength = 7
        Me.txtCustomerAddress1.Name = "txtCustomerAddress1"
        Me.txtCustomerAddress1.Size = New System.Drawing.Size(306, 23)
        Me.txtCustomerAddress1.TabIndex = 23
        '
        'lblCustomerAddress1
        '
        Me.lblCustomerAddress1.AutoSize = True
        Me.lblCustomerAddress1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerAddress1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerAddress1.Location = New System.Drawing.Point(281, 19)
        Me.lblCustomerAddress1.Name = "lblCustomerAddress1"
        Me.lblCustomerAddress1.Size = New System.Drawing.Size(49, 15)
        Me.lblCustomerAddress1.TabIndex = 24
        Me.lblCustomerAddress1.Text = "Address"
        '
        'txtOrderName
        '
        Me.txtOrderName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderName.Location = New System.Drawing.Point(778, 48)
        Me.txtOrderName.MaxLength = 7
        Me.txtOrderName.Name = "txtOrderName"
        Me.txtOrderName.Size = New System.Drawing.Size(166, 23)
        Me.txtOrderName.TabIndex = 21
        '
        'lblOrderName
        '
        Me.lblOrderName.AutoSize = True
        Me.lblOrderName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOrderName.Location = New System.Drawing.Point(687, 51)
        Me.lblOrderName.Name = "lblOrderName"
        Me.lblOrderName.Size = New System.Drawing.Size(89, 15)
        Me.lblOrderName.TabIndex = 22
        Me.lblOrderName.Text = "Ordering Name"
        '
        'cbIsTaxable
        '
        Me.cbIsTaxable.AutoSize = True
        Me.cbIsTaxable.Enabled = False
        Me.cbIsTaxable.Location = New System.Drawing.Point(96, 89)
        Me.cbIsTaxable.Name = "cbIsTaxable"
        Me.cbIsTaxable.Size = New System.Drawing.Size(101, 17)
        Me.cbIsTaxable.TabIndex = 17
        Me.cbIsTaxable.Text = "Cust. is Taxable"
        Me.cbIsTaxable.UseVisualStyleBackColor = True
        '
        'txtCustomerVLT
        '
        Me.txtCustomerVLT.Enabled = False
        Me.txtCustomerVLT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerVLT.Location = New System.Drawing.Point(96, 60)
        Me.txtCustomerVLT.MaxLength = 7
        Me.txtCustomerVLT.Name = "txtCustomerVLT"
        Me.txtCustomerVLT.Size = New System.Drawing.Size(58, 23)
        Me.txtCustomerVLT.TabIndex = 14
        '
        'lblCustomerVLT
        '
        Me.lblCustomerVLT.AutoSize = True
        Me.lblCustomerVLT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerVLT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerVLT.Location = New System.Drawing.Point(5, 63)
        Me.lblCustomerVLT.Name = "lblCustomerVLT"
        Me.lblCustomerVLT.Size = New System.Drawing.Size(81, 15)
        Me.lblCustomerVLT.TabIndex = 15
        Me.lblCustomerVLT.Text = "Customer VLT"
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.BackColor = System.Drawing.Color.Pink
        Me.txtCustomerCode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtCustomerCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(96, 16)
        Me.txtCustomerCode.MaxLength = 7
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(166, 23)
        Me.txtCustomerCode.TabIndex = 11
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.AutoSize = True
        Me.lblCustomerCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerCode.Location = New System.Drawing.Point(5, 19)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(90, 15)
        Me.lblCustomerCode.TabIndex = 12
        Me.lblCustomerCode.Text = "Customer Code"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerName.Location = New System.Drawing.Point(93, 42)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(104, 15)
        Me.lblCustomerName.TabIndex = 13
        Me.lblCustomerName.Text = "lblCustomerName"
        '
        'FrmSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1062, 606)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FrmSalesOrder"
        Me.Text = "FrmSalesOrder"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblRecStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNetto As System.Windows.Forms.TextBox
    Friend WithEvents lblNetto As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents lblBruto As System.Windows.Forms.Label
    Friend WithEvents txtNilaiPPN As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPPN As System.Windows.Forms.TextBox
    Friend WithEvents lblPPN As System.Windows.Forms.Label
    Friend WithEvents txtNilaiDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIsTaxable As System.Windows.Forms.CheckBox
    Friend WithEvents txtCustomerVLT As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerVLT As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrderName As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderName As System.Windows.Forms.Label
    Friend WithEvents lblSalesName As System.Windows.Forms.Label
    Friend WithEvents txtSalesCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesCode As System.Windows.Forms.Label
    Friend WithEvents lblShipDate As System.Windows.Forms.Label
    Friend WithEvents dtShipDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPOCust As System.Windows.Forms.TextBox
    Friend WithEvents lblPOCustomer As System.Windows.Forms.Label
    Friend WithEvents lblSODate As System.Windows.Forms.Label
    Friend WithEvents dtSODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSONumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSONumber As System.Windows.Forms.Label
    Friend WithEvents txtCustomerAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerAddress2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerAddress1 As System.Windows.Forms.Label
    Friend WithEvents colItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemSatuan As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNilaiHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsFind As System.Windows.Forms.ToolStripMenuItem
End Class
