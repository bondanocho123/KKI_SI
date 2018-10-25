<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserParameter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserParameter))
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
        Me.lblUserGroupName = New System.Windows.Forms.Label()
        Me.txtUserGroupID = New System.Windows.Forms.TextBox()
        Me.lblUserGroupID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNohp2 = New System.Windows.Forms.TextBox()
        Me.txtNohp1 = New System.Windows.Forms.TextBox()
        Me.lblNohp = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.txtAddres = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblUserGroupName)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtUserGroupID)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblUserGroupID)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label7)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNohp2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtNohp1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblNohp)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtemail)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblEmail)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtAddress2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblAddress2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtAddres)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblAddress)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtFullname)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtUserID)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblFullName)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblUserID)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(524, 310)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(524, 360)
        Me.ToolStripContainer1.TabIndex = 2
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
        'lblUserGroupName
        '
        Me.lblUserGroupName.AutoSize = True
        Me.lblUserGroupName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserGroupName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserGroupName.Location = New System.Drawing.Point(231, 261)
        Me.lblUserGroupName.Name = "lblUserGroupName"
        Me.lblUserGroupName.Size = New System.Drawing.Size(85, 15)
        Me.lblUserGroupName.TabIndex = 20
        Me.lblUserGroupName.Text = "lblGroupName"
        Me.lblUserGroupName.Visible = False
        '
        'txtUserGroupID
        '
        Me.txtUserGroupID.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtUserGroupID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserGroupID.Location = New System.Drawing.Point(148, 258)
        Me.txtUserGroupID.MaxLength = 5
        Me.txtUserGroupID.Name = "txtUserGroupID"
        Me.txtUserGroupID.Size = New System.Drawing.Size(77, 23)
        Me.txtUserGroupID.TabIndex = 7
        '
        'lblUserGroupID
        '
        Me.lblUserGroupID.AutoSize = True
        Me.lblUserGroupID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserGroupID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserGroupID.Location = New System.Drawing.Point(22, 258)
        Me.lblUserGroupID.Name = "lblUserGroupID"
        Me.lblUserGroupID.Size = New System.Drawing.Size(80, 15)
        Me.lblUserGroupID.TabIndex = 19
        Me.lblUserGroupID.Text = "User Group ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(304, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "/"
        '
        'txtNohp2
        '
        Me.txtNohp2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNohp2.Location = New System.Drawing.Point(323, 230)
        Me.txtNohp2.MaxLength = 15
        Me.txtNohp2.Name = "txtNohp2"
        Me.txtNohp2.Size = New System.Drawing.Size(171, 23)
        Me.txtNohp2.TabIndex = 6
        '
        'txtNohp1
        '
        Me.txtNohp1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNohp1.Location = New System.Drawing.Point(148, 230)
        Me.txtNohp1.MaxLength = 15
        Me.txtNohp1.Name = "txtNohp1"
        Me.txtNohp1.Size = New System.Drawing.Size(150, 23)
        Me.txtNohp1.TabIndex = 5
        '
        'lblNohp
        '
        Me.lblNohp.AutoSize = True
        Me.lblNohp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNohp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNohp.Location = New System.Drawing.Point(22, 230)
        Me.lblNohp.Name = "lblNohp"
        Me.lblNohp.Size = New System.Drawing.Size(70, 15)
        Me.lblNohp.TabIndex = 15
        Me.lblNohp.Text = "HP Number"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(148, 202)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(346, 23)
        Me.txtemail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmail.Location = New System.Drawing.Point(22, 202)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email"
        '
        'txtAddress2
        '
        Me.txtAddress2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(148, 139)
        Me.txtAddress2.MaxLength = 100
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(346, 57)
        Me.txtAddress2.TabIndex = 3
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAddress2.Location = New System.Drawing.Point(22, 155)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(72, 15)
        Me.lblAddress2.TabIndex = 11
        Me.lblAddress2.Text = "2nd Address"
        '
        'txtAddres
        '
        Me.txtAddres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddres.Location = New System.Drawing.Point(148, 76)
        Me.txtAddres.MaxLength = 100
        Me.txtAddres.Multiline = True
        Me.txtAddres.Name = "txtAddres"
        Me.txtAddres.Size = New System.Drawing.Size(346, 57)
        Me.txtAddres.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAddress.Location = New System.Drawing.Point(22, 92)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(49, 15)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(148, 48)
        Me.txtFullname.MaxLength = 50
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(273, 23)
        Me.txtFullname.TabIndex = 1
        '
        'txtUserID
        '
        Me.txtUserID.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(148, 20)
        Me.txtUserID.MaxLength = 5
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(77, 23)
        Me.txtUserID.TabIndex = 0
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFullName.Location = New System.Drawing.Point(22, 48)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(61, 15)
        Me.lblFullName.TabIndex = 7
        Me.lblFullName.Text = "Full Name"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserID.Location = New System.Drawing.Point(22, 20)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 15)
        Me.lblUserID.TabIndex = 6
        Me.lblUserID.Text = "User ID"
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
        'FrmUserParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 360)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FrmUserParameter"
        Me.Text = "FrmUserParameter"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents lblUserGroupName As System.Windows.Forms.Label
    Friend WithEvents txtUserGroupID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserGroupID As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNohp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNohp1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNohp As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents txtAddres As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsFind As System.Windows.Forms.ToolStripMenuItem
End Class
