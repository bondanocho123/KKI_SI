Public Class FrmFindSales
    Dim idok As Boolean
    Private Sub FrmFindSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("colSalesCode").Frozen = True
        DataGridView1.Columns("colSalesName").Frozen = True
    End Sub

    Public Function FindSalesParameter(ByRef CSales As CSalesParameter) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CSales.GetSalesParameter(CSales, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindSalesParameter = idok
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
        Dim CSales As New CSalesParameter

        If e.KeyCode = Keys.Enter Then
            If CSales.FindSalesParameter(dtSet, txtFindString.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Id"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Name"))
                    DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Address1"))
                    DataGridView1.Rows(i).Cells(3).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Address2"))
                    DataGridView1.Rows(i).Cells(4).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Telp"))
                    DataGridView1.Rows(i).Cells(5).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Sales_Ktp"))

                Next
            End If
        End If
    End Sub
End Class