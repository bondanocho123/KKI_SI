<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindCustomer
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
        Me.colCustomerCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAddress1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerTelp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerNPWP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerPKP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerVLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerCode, Me.colCustomerName, Me.colSalesAddress1, Me.colSalesAddress2, Me.colCustomerTelp, Me.colCustomerNPWP, Me.colCustomerPKP, Me.colCustomerSales, Me.colCustomerVLT})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(737, 337)
        Me.DataGridView1.TabIndex = 21
        '
        'txtFindString
        '
        Me.txtFindString.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindString.Location = New System.Drawing.Point(60, 4)
        Me.txtFindString.MaxLength = 100
        Me.txtFindString.Name = "txtFindString"
        Me.txtFindString.Size = New System.Drawing.Size(656, 23)
        Me.txtFindString.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Find"
        '
        'colCustomerCode
        '
        Me.colCustomerCode.HeaderText = "Customer Code"
        Me.colCustomerCode.Name = "colCustomerCode"
        Me.colCustomerCode.ReadOnly = True
        Me.colCustomerCode.Width = 130
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "Customer Name"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.ReadOnly = True
        Me.colCustomerName.Width = 210
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
        'colCustomerTelp
        '
        Me.colCustomerTelp.HeaderText = "Customer Telp"
        Me.colCustomerTelp.Name = "colCustomerTelp"
        Me.colCustomerTelp.ReadOnly = True
        '
        'colCustomerNPWP
        '
        Me.colCustomerNPWP.HeaderText = "Customer NPWP"
        Me.colCustomerNPWP.Name = "colCustomerNPWP"
        Me.colCustomerNPWP.ReadOnly = True
        '
        'colCustomerPKP
        '
        Me.colCustomerPKP.HeaderText = "Customer PKP"
        Me.colCustomerPKP.Name = "colCustomerPKP"
        Me.colCustomerPKP.ReadOnly = True
        '
        'colCustomerSales
        '
        Me.colCustomerSales.HeaderText = "Customer Sales"
        Me.colCustomerSales.Name = "colCustomerSales"
        Me.colCustomerSales.ReadOnly = True
        '
        'colCustomerVLT
        '
        Me.colCustomerVLT.HeaderText = "Valuta"
        Me.colCustomerVLT.Name = "colCustomerVLT"
        Me.colCustomerVLT.ReadOnly = True
        '
        'FrmFindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(737, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtFindString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFindCustomer"
        Me.Text = "FrmFindCustomer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFindString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colCustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAddress1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAddress2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerTelp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerNPWP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerPKP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerSales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerVLT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
