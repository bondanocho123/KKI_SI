<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemParameter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemParameter))
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
        Me.txtNetAmount = New System.Windows.Forms.TextBox()
        Me.lblNetAmount = New System.Windows.Forms.Label()
        Me.txtSmallUnit = New System.Windows.Forms.TextBox()
        Me.lblSmallUnit = New System.Windows.Forms.Label()
        Me.txtItemName3 = New System.Windows.Forms.TextBox()
        Me.lblItemName3 = New System.Windows.Forms.Label()
        Me.txtItemName2 = New System.Windows.Forms.TextBox()
        Me.lblItemName2 = New System.Windows.Forms.Label()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.txtBigUnit = New System.Windows.Forms.TextBox()
        Me.lblBigUnit = New System.Windows.Forms.Label()
        Me.txtItemName1 = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.lblItemName1 = New System.Windows.Forms.Label()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNetAmount)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblNetAmount)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtSmallUnit)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblSmallUnit)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItemName3)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblItemName3)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItemName2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblItemName2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItemPrice)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblItemPrice)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtBigUnit)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblBigUnit)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItemName1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItemCode)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblItemName1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblItemCode)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(527, 298)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(527, 348)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.ToolStripSeparator1, Me.btnSave, Me.btnDelete, Me.ToolStripSeparator2, Me.btnExit, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.lblRecStatus})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(312, 25)
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
        'txtNetAmount
        '
        Me.txtNetAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmount.Location = New System.Drawing.Point(148, 193)
        Me.txtNetAmount.MaxLength = 15
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.Size = New System.Drawing.Size(140, 23)
        Me.txtNetAmount.TabIndex = 26
        '
        'lblNetAmount
        '
        Me.lblNetAmount.AutoSize = True
        Me.lblNetAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNetAmount.Location = New System.Drawing.Point(22, 193)
        Me.lblNetAmount.Name = "lblNetAmount"
        Me.lblNetAmount.Size = New System.Drawing.Size(73, 15)
        Me.lblNetAmount.TabIndex = 27
        Me.lblNetAmount.Text = "Net Amount"
        '
        'txtSmallUnit
        '
        Me.txtSmallUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmallUnit.Location = New System.Drawing.Point(148, 164)
        Me.txtSmallUnit.MaxLength = 15
        Me.txtSmallUnit.Name = "txtSmallUnit"
        Me.txtSmallUnit.Size = New System.Drawing.Size(77, 23)
        Me.txtSmallUnit.TabIndex = 24
        '
        'lblSmallUnit
        '
        Me.lblSmallUnit.AutoSize = True
        Me.lblSmallUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSmallUnit.Location = New System.Drawing.Point(22, 164)
        Me.lblSmallUnit.Name = "lblSmallUnit"
        Me.lblSmallUnit.Size = New System.Drawing.Size(61, 15)
        Me.lblSmallUnit.TabIndex = 25
        Me.lblSmallUnit.Text = "Small Unit"
        '
        'txtItemName3
        '
        Me.txtItemName3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName3.Location = New System.Drawing.Point(148, 106)
        Me.txtItemName3.MaxLength = 25
        Me.txtItemName3.Name = "txtItemName3"
        Me.txtItemName3.Size = New System.Drawing.Size(273, 23)
        Me.txtItemName3.TabIndex = 22
        '
        'lblItemName3
        '
        Me.lblItemName3.AutoSize = True
        Me.lblItemName3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemName3.Location = New System.Drawing.Point(22, 109)
        Me.lblItemName3.Name = "lblItemName3"
        Me.lblItemName3.Size = New System.Drawing.Size(86, 15)
        Me.lblItemName3.TabIndex = 23
        Me.lblItemName3.Text = "3rd Item Name"
        '
        'txtItemName2
        '
        Me.txtItemName2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName2.Location = New System.Drawing.Point(148, 77)
        Me.txtItemName2.MaxLength = 25
        Me.txtItemName2.Name = "txtItemName2"
        Me.txtItemName2.Size = New System.Drawing.Size(273, 23)
        Me.txtItemName2.TabIndex = 20
        '
        'lblItemName2
        '
        Me.lblItemName2.AutoSize = True
        Me.lblItemName2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemName2.Location = New System.Drawing.Point(22, 80)
        Me.lblItemName2.Name = "lblItemName2"
        Me.lblItemName2.Size = New System.Drawing.Size(89, 15)
        Me.lblItemName2.TabIndex = 21
        Me.lblItemName2.Text = "2nd Item Name"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPrice.Location = New System.Drawing.Point(148, 222)
        Me.txtItemPrice.MaxLength = 50
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(123, 23)
        Me.txtItemPrice.TabIndex = 7
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemPrice.Location = New System.Drawing.Point(22, 222)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(60, 15)
        Me.lblItemPrice.TabIndex = 19
        Me.lblItemPrice.Text = "Item Price"
        '
        'txtBigUnit
        '
        Me.txtBigUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBigUnit.Location = New System.Drawing.Point(148, 135)
        Me.txtBigUnit.MaxLength = 15
        Me.txtBigUnit.Name = "txtBigUnit"
        Me.txtBigUnit.Size = New System.Drawing.Size(77, 23)
        Me.txtBigUnit.TabIndex = 6
        '
        'lblBigUnit
        '
        Me.lblBigUnit.AutoSize = True
        Me.lblBigUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBigUnit.Location = New System.Drawing.Point(22, 135)
        Me.lblBigUnit.Name = "lblBigUnit"
        Me.lblBigUnit.Size = New System.Drawing.Size(49, 15)
        Me.lblBigUnit.TabIndex = 15
        Me.lblBigUnit.Text = "Big Unit"
        '
        'txtItemName1
        '
        Me.txtItemName1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName1.Location = New System.Drawing.Point(148, 48)
        Me.txtItemName1.MaxLength = 25
        Me.txtItemName1.Name = "txtItemName1"
        Me.txtItemName1.Size = New System.Drawing.Size(273, 23)
        Me.txtItemName1.TabIndex = 1
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(148, 20)
        Me.txtItemCode.MaxLength = 7
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(77, 23)
        Me.txtItemCode.TabIndex = 0
        '
        'lblItemName1
        '
        Me.lblItemName1.AutoSize = True
        Me.lblItemName1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemName1.Location = New System.Drawing.Point(22, 51)
        Me.lblItemName1.Name = "lblItemName1"
        Me.lblItemName1.Size = New System.Drawing.Size(66, 15)
        Me.lblItemName1.TabIndex = 7
        Me.lblItemName1.Text = "Item Name"
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemCode.Location = New System.Drawing.Point(22, 20)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(62, 15)
        Me.lblItemCode.TabIndex = 6
        Me.lblItemCode.Text = "Item Code"
        '
        'FrmItemParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(527, 348)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FrmItemParameter"
        Me.Text = "FrmItemParameter"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents txtItemName3 As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName3 As System.Windows.Forms.Label
    Friend WithEvents txtItemName2 As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName2 As System.Windows.Forms.Label
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblItemPrice As System.Windows.Forms.Label
    Friend WithEvents txtBigUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblBigUnit As System.Windows.Forms.Label
    Friend WithEvents txtItemName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName1 As System.Windows.Forms.Label
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents txtNetAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblNetAmount As System.Windows.Forms.Label
    Friend WithEvents txtSmallUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblSmallUnit As System.Windows.Forms.Label
End Class
