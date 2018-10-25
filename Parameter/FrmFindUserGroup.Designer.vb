<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindUserGroup
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
        Me.UserGroup_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserGroup_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUserGroupId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserGroup_Id, Me.UserGroup_Name})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(382, 224)
        Me.DataGridView1.TabIndex = 9
        '
        'UserGroup_Id
        '
        Me.UserGroup_Id.HeaderText = "User Group ID"
        Me.UserGroup_Id.Name = "UserGroup_Id"
        Me.UserGroup_Id.ReadOnly = True
        Me.UserGroup_Id.Width = 130
        '
        'UserGroup_Name
        '
        Me.UserGroup_Name.HeaderText = "User Group Name"
        Me.UserGroup_Name.Name = "UserGroup_Name"
        Me.UserGroup_Name.ReadOnly = True
        Me.UserGroup_Name.Width = 210
        '
        'txtUserGroupId
        '
        Me.txtUserGroupId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserGroupId.Location = New System.Drawing.Point(64, 4)
        Me.txtUserGroupId.MaxLength = 100
        Me.txtUserGroupId.Name = "txtUserGroupId"
        Me.txtUserGroupId.Size = New System.Drawing.Size(306, 23)
        Me.txtUserGroupId.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Find"
        '
        'FrmFindUserGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(382, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtUserGroupId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindUserGroup"
        Me.Text = "FrmFindUserGroup"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UserGroup_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserGroup_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUserGroupId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
