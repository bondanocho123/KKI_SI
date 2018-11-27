Public Class FrmFindCustomer
    Dim idok As Boolean
    Private Sub FrmFindCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("colCustomerCode").Frozen = True
        DataGridView1.Columns("colCustomerName").Frozen = True
    End Sub

    Public Function FindCustomerParameter(ByRef CCustomer As CCustomerParameter) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CCustomer.GetCustomerParameter(CCustomer, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindCustomerParameter = idok
    End Function

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.CurrentRow.Index = DataGridView1.Rows.Count - 1 Then
            MsgBoxShow("No data you choose!", 0)
        Else
            DialogResult = Windows.Forms.DialogResult.OK
            idok = True
        End If
    End Sub

    Private Sub txtFindString_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFindString.KeyDown
        Dim dtSet As New DataSet
        Dim CCustomer As New CCustomerParameter

        If e.KeyCode = Keys.Enter Then
            If CCustomer.FindCustomerParameter(dtSet, txtFindString.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerCode"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerName"))
                    DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerAddress1"))
                    DataGridView1.Rows(i).Cells(3).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerAddress2"))
                    DataGridView1.Rows(i).Cells(4).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerTelp"))
                    DataGridView1.Rows(i).Cells(5).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerNPWP"))
                    DataGridView1.Rows(i).Cells(6).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("PKP"))
                    DataGridView1.Rows(i).Cells(7).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("SALES"))
                    DataGridView1.Rows(i).Cells(8).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("CustomerVLT"))
                Next
            End If
        End If
    End Sub
End Class