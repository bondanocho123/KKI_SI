Public Class FrmFindWarehouse
    Dim idok As Boolean
    Private Sub FrmFindWarehouse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUserId_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUserId.KeyDown
        Dim dtSet As New DataSet
        Dim CWarehouseA As New Warehouse.CWarehouseParameterA

        If e.KeyCode = Keys.Enter Then
            If CWarehouseA.FindWarehouse(dtSet, txtUserId.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 2
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("WarehouseCode"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("WarehouseName"))
                Next
            End If
        End If
    End Sub

    Public Function FindWarehouseParameter(ByRef CWarehouseA As Warehouse.CWarehouseParameterA) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CWarehouseA.GetWarehouseParameterA(CWarehouseA, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindWarehouseParameter = idok
    End Function

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.CurrentRow.Index = DataGridView1.Rows.Count - 1 Then
            MsgBoxShow("No data you choose!", 0)
        Else
            DialogResult = Windows.Forms.DialogResult.OK
            idok = True
        End If
    End Sub
End Class