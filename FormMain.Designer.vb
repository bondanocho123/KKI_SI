<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriverListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUserStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTimeStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStoreStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stStoreName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserGgroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ReportToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1145, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem, Me.KToolStripMenuItem})
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "System"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Logo - Out"
        '
        'KToolStripMenuItem
        '
        Me.KToolStripMenuItem.Image = CType(resources.GetObject("KToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KToolStripMenuItem.Name = "KToolStripMenuItem"
        Me.KToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.KToolStripMenuItem.Text = "Exit"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceToolStripMenuItem, Me.OrderToolStripMenuItem})
        Me.SalesToolStripMenuItem.Image = CType(resources.GetObject("SalesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem, Me.WarehouseToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.SalesToolStripMenuItem1, Me.DriverToolStripMenuItem, Me.UserGgroupToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ReportToolStripMenuItem.Text = "Master"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'WarehouseToolStripMenuItem
        '
        Me.WarehouseToolStripMenuItem.Name = "WarehouseToolStripMenuItem"
        Me.WarehouseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WarehouseToolStripMenuItem.Text = "Warehouse"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'SalesToolStripMenuItem1
        '
        Me.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1"
        Me.SalesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SalesToolStripMenuItem1.Text = "Sales"
        '
        'DriverToolStripMenuItem
        '
        Me.DriverToolStripMenuItem.Name = "DriverToolStripMenuItem"
        Me.DriverToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DriverToolStripMenuItem.Text = "Driver"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceListToolStripMenuItem, Me.WarehouseListToolStripMenuItem, Me.CustomerListToolStripMenuItem, Me.SalesListToolStripMenuItem, Me.DriverListToolStripMenuItem})
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'InvoiceListToolStripMenuItem
        '
        Me.InvoiceListToolStripMenuItem.Name = "InvoiceListToolStripMenuItem"
        Me.InvoiceListToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.InvoiceListToolStripMenuItem.Text = "Invoice List"
        '
        'WarehouseListToolStripMenuItem
        '
        Me.WarehouseListToolStripMenuItem.Name = "WarehouseListToolStripMenuItem"
        Me.WarehouseListToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.WarehouseListToolStripMenuItem.Text = "Warehouse List"
        '
        'CustomerListToolStripMenuItem
        '
        Me.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem"
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CustomerListToolStripMenuItem.Text = "Customer List"
        '
        'SalesListToolStripMenuItem
        '
        Me.SalesListToolStripMenuItem.Name = "SalesListToolStripMenuItem"
        Me.SalesListToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SalesListToolStripMenuItem.Text = "Sales List"
        '
        'DriverListToolStripMenuItem
        '
        Me.DriverListToolStripMenuItem.Name = "DriverListToolStripMenuItem"
        Me.DriverListToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DriverListToolStripMenuItem.Text = "Driver List"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualBookToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManualBookToolStripMenuItem
        '
        Me.ManualBookToolStripMenuItem.Name = "ManualBookToolStripMenuItem"
        Me.ManualBookToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualBookToolStripMenuItem.Text = "Manual Book"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUserStatus, Me.stUser, Me.lblTimeStatus, Me.stTime, Me.lblStoreStatus, Me.stStoreName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1145, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUserStatus
        '
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblUserStatus.Text = "User : "
        '
        'stUser
        '
        Me.stUser.Name = "stUser"
        Me.stUser.Size = New System.Drawing.Size(0, 17)
        '
        'lblTimeStatus
        '
        Me.lblTimeStatus.Name = "lblTimeStatus"
        Me.lblTimeStatus.Size = New System.Drawing.Size(43, 17)
        Me.lblTimeStatus.Text = "Time : "
        '
        'stTime
        '
        Me.stTime.Name = "stTime"
        Me.stTime.Size = New System.Drawing.Size(10, 17)
        Me.stTime.Text = " "
        '
        'lblStoreStatus
        '
        Me.lblStoreStatus.Name = "lblStoreStatus"
        Me.lblStoreStatus.Size = New System.Drawing.Size(40, 17)
        Me.lblStoreStatus.Text = "Store :"
        '
        'stStoreName
        '
        Me.stStoreName.Name = "stStoreName"
        Me.stStoreName.Size = New System.Drawing.Size(10, 17)
        Me.stStoreName.Text = " "
        '
        'UserGgroupToolStripMenuItem
        '
        Me.UserGgroupToolStripMenuItem.Name = "UserGgroupToolStripMenuItem"
        Me.UserGgroupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserGgroupToolStripMenuItem.Text = "User Group"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1145, 476)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Main [Erasoft Sales Invoice]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarehouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarehouseListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriverListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUserStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTimeStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStoreStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stStoreName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserGgroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
