<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindDriver
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
        Me.colDriverCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverAddress1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverTelp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDriverNoPol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFindString = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDriverCode, Me.colDriverName, Me.colDriverAddress1, Me.colDriverAddress2, Me.colDriverTelp, Me.colDriverHp, Me.colDriverNoPol})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(737, 337)
        Me.DataGridView1.TabIndex = 15
        '
        'colDriverCode
        '
        Me.colDriverCode.HeaderText = "Driver Code"
        Me.colDriverCode.Name = "colDriverCode"
        Me.colDriverCode.ReadOnly = True
        Me.colDriverCode.Width = 130
        '
        'colDriverName
        '
        Me.colDriverName.HeaderText = "Driver Name"
        Me.colDriverName.Name = "colDriverName"
        Me.colDriverName.ReadOnly = True
        Me.colDriverName.Width = 210
        '
        'colDriverAddress1
        '
        Me.colDriverAddress1.HeaderText = "Address"
        Me.colDriverAddress1.Name = "colDriverAddress1"
        Me.colDriverAddress1.ReadOnly = True
        Me.colDriverAddress1.Width = 250
        '
        'colDriverAddress2
        '
        Me.colDriverAddress2.HeaderText = "2nd Address"
        Me.colDriverAddress2.Name = "colDriverAddress2"
        Me.colDriverAddress2.ReadOnly = True
        Me.colDriverAddress2.Width = 250
        '
        'colDriverTelp
        '
        Me.colDriverTelp.HeaderText = "Driver Telp"
        Me.colDriverTelp.Name = "colDriverTelp"
        Me.colDriverTelp.ReadOnly = True
        Me.colDriverTelp.Width = 150
        '
        'colDriverHp
        '
        Me.colDriverHp.HeaderText = "Driver HP"
        Me.colDriverHp.Name = "colDriverHp"
        Me.colDriverHp.ReadOnly = True
        '
        'colDriverNoPol
        '
        Me.colDriverNoPol.HeaderText = "Vehicle Code"
        Me.colDriverNoPol.Name = "colDriverNoPol"
        Me.colDriverNoPol.ReadOnly = True
        '
        'txtFindString
        '
        Me.txtFindString.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindString.Location = New System.Drawing.Point(64, 4)
        Me.txtFindString.MaxLength = 100
        Me.txtFindString.Name = "txtFindString"
        Me.txtFindString.Size = New System.Drawing.Size(656, 23)
        Me.txtFindString.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Find"
        '
        'FrmFindDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(737, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtFindString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindDriver"
        Me.Text = "FrmFindDriver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFindString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colDriverCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverAddress1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverAddress2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverTelp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverHp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDriverNoPol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
