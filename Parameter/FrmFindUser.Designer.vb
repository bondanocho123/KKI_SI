<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindUser
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhoneNumber2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUserID, Me.colFullName, Me.Address, Me.colAddress2, Me.colEmail, Me.colPhoneNumber, Me.colPhoneNumber2, Me.colUserGroup})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(737, 337)
        Me.DataGridView1.TabIndex = 12
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(64, 8)
        Me.txtUserId.MaxLength = 100
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(656, 23)
        Me.txtUserId.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Find"
        '
        'colUserID
        '
        Me.colUserID.HeaderText = "User ID"
        Me.colUserID.Name = "colUserID"
        Me.colUserID.ReadOnly = True
        Me.colUserID.Width = 130
        '
        'colFullName
        '
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Width = 210
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 250
        '
        'colAddress2
        '
        Me.colAddress2.HeaderText = "2nd Address"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.ReadOnly = True
        Me.colAddress2.Width = 250
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        '
        'colPhoneNumber
        '
        Me.colPhoneNumber.HeaderText = "Phone Number"
        Me.colPhoneNumber.Name = "colPhoneNumber"
        Me.colPhoneNumber.ReadOnly = True
        Me.colPhoneNumber.Width = 150
        '
        'colPhoneNumber2
        '
        Me.colPhoneNumber2.HeaderText = "2nd Phone Number"
        Me.colPhoneNumber2.Name = "colPhoneNumber2"
        Me.colPhoneNumber2.ReadOnly = True
        Me.colPhoneNumber2.Width = 150
        '
        'colUserGroup
        '
        Me.colUserGroup.HeaderText = "User Group ID"
        Me.colUserGroup.Name = "colUserGroup"
        Me.colUserGroup.ReadOnly = True
        '
        'FrmFindUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(737, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindUser"
        Me.Text = "FrmFindUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colUserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhoneNumber2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUserGroup As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
