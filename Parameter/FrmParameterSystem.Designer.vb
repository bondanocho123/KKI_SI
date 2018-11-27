<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParameterSystem
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSetBackSelections = New System.Windows.Forms.Button()
        Me.btnSetBackSelection = New System.Windows.Forms.Button()
        Me.btnSetAllSelected = New System.Windows.Forms.Button()
        Me.btnSetSelected = New System.Windows.Forms.Button()
        Me.lbSelectedAccess = New System.Windows.Forms.ListBox()
        Me.lbSelectionAccess = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbUserGroup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(299, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Selected :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Selection :"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(418, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(337, 305)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 25)
        Me.btnOK.TabIndex = 39
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSetBackSelections
        '
        Me.btnSetBackSelections.Location = New System.Drawing.Point(221, 195)
        Me.btnSetBackSelections.Name = "btnSetBackSelections"
        Me.btnSetBackSelections.Size = New System.Drawing.Size(75, 25)
        Me.btnSetBackSelections.TabIndex = 37
        Me.btnSetBackSelections.Text = "<<"
        Me.btnSetBackSelections.UseVisualStyleBackColor = True
        '
        'btnSetBackSelection
        '
        Me.btnSetBackSelection.Location = New System.Drawing.Point(221, 164)
        Me.btnSetBackSelection.Name = "btnSetBackSelection"
        Me.btnSetBackSelection.Size = New System.Drawing.Size(75, 25)
        Me.btnSetBackSelection.TabIndex = 36
        Me.btnSetBackSelection.Text = "<"
        Me.btnSetBackSelection.UseVisualStyleBackColor = True
        '
        'btnSetAllSelected
        '
        Me.btnSetAllSelected.Location = New System.Drawing.Point(219, 133)
        Me.btnSetAllSelected.Name = "btnSetAllSelected"
        Me.btnSetAllSelected.Size = New System.Drawing.Size(75, 25)
        Me.btnSetAllSelected.TabIndex = 35
        Me.btnSetAllSelected.Text = ">>"
        Me.btnSetAllSelected.UseVisualStyleBackColor = True
        '
        'btnSetSelected
        '
        Me.btnSetSelected.Location = New System.Drawing.Point(219, 102)
        Me.btnSetSelected.Name = "btnSetSelected"
        Me.btnSetSelected.Size = New System.Drawing.Size(75, 25)
        Me.btnSetSelected.TabIndex = 31
        Me.btnSetSelected.Text = ">"
        Me.btnSetSelected.UseVisualStyleBackColor = True
        '
        'lbSelectedAccess
        '
        Me.lbSelectedAccess.FormattingEnabled = True
        Me.lbSelectedAccess.Location = New System.Drawing.Point(302, 61)
        Me.lbSelectedAccess.Name = "lbSelectedAccess"
        Me.lbSelectedAccess.Size = New System.Drawing.Size(191, 238)
        Me.lbSelectedAccess.TabIndex = 34
        '
        'lbSelectionAccess
        '
        Me.lbSelectionAccess.FormattingEnabled = True
        Me.lbSelectionAccess.Location = New System.Drawing.Point(22, 61)
        Me.lbSelectionAccess.Name = "lbSelectionAccess"
        Me.lbSelectionAccess.Size = New System.Drawing.Size(191, 238)
        Me.lbSelectionAccess.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "User Group"
        '
        'cbUserGroup
        '
        Me.cbUserGroup.FormattingEnabled = True
        Me.cbUserGroup.Location = New System.Drawing.Point(91, 10)
        Me.cbUserGroup.Name = "cbUserGroup"
        Me.cbUserGroup.Size = New System.Drawing.Size(402, 21)
        Me.cbUserGroup.TabIndex = 43
        '
        'FrmParameterSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 349)
        Me.Controls.Add(Me.cbUserGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSetBackSelections)
        Me.Controls.Add(Me.btnSetBackSelection)
        Me.Controls.Add(Me.btnSetAllSelected)
        Me.Controls.Add(Me.btnSetSelected)
        Me.Controls.Add(Me.lbSelectedAccess)
        Me.Controls.Add(Me.lbSelectionAccess)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmParameterSystem"
        Me.Text = "FrmParameterSystem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSetBackSelections As System.Windows.Forms.Button
    Friend WithEvents btnSetBackSelection As System.Windows.Forms.Button
    Friend WithEvents btnSetAllSelected As System.Windows.Forms.Button
    Friend WithEvents btnSetSelected As System.Windows.Forms.Button
    Friend WithEvents lbSelectedAccess As System.Windows.Forms.ListBox
    Friend WithEvents lbSelectionAccess As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbUserGroup As System.Windows.Forms.ComboBox
End Class
