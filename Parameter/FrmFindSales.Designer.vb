<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindSales
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
        Me.txtFindString = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colSalesCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAddress1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesKTP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSalesCode, Me.colSalesName, Me.colSalesAddress1, Me.colSalesAddress2, Me.colSalesHp, Me.colSalesKTP})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(737, 337)
        Me.DataGridView1.TabIndex = 18
        '
        'txtFindString
        '
        Me.txtFindString.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindString.Location = New System.Drawing.Point(60, 8)
        Me.txtFindString.MaxLength = 100
        Me.txtFindString.Name = "txtFindString"
        Me.txtFindString.Size = New System.Drawing.Size(656, 23)
        Me.txtFindString.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Find"
        '
        'colSalesCode
        '
        Me.colSalesCode.HeaderText = "Sales Code"
        Me.colSalesCode.Name = "colSalesCode"
        Me.colSalesCode.ReadOnly = True
        Me.colSalesCode.Width = 130
        '
        'colSalesName
        '
        Me.colSalesName.HeaderText = "Sales Name"
        Me.colSalesName.Name = "colSalesName"
        Me.colSalesName.ReadOnly = True
        Me.colSalesName.Width = 210
        '
        'colSalesAddress1
        '
        Me.colSalesAddress1.HeaderText = "Address"
        Me.colSalesAddress1.Name = "colSalesAddress1"
        Me.colSalesAddress1.ReadOnly = True
        Me.colSalesAddress1.Width = 250
        '
        'colSalesAddress2
        '
        Me.colSalesAddress2.HeaderText = "2nd Address"
        Me.colSalesAddress2.Name = "colSalesAddress2"
        Me.colSalesAddress2.ReadOnly = True
        Me.colSalesAddress2.Width = 250
        '
        'colSalesHp
        '
        Me.colSalesHp.HeaderText = " Sales HP"
        Me.colSalesHp.Name = "colSalesHp"
        Me.colSalesHp.ReadOnly = True
        '
        'colSalesKTP
        '
        Me.colSalesKTP.HeaderText = "Personal Number"
        Me.colSalesKTP.Name = "colSalesKTP"
        Me.colSalesKTP.ReadOnly = True
        '
        'FrmFindSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(737, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtFindString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindSales"
        Me.Text = "FrmFindSales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFindString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colSalesCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAddress1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAddress2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesHp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesKTP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
