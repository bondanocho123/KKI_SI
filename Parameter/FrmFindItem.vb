Public Class FrmFindItem
    Dim idok As Boolean

    Private Sub FrmFindItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("colItemCode").Frozen = True
        DataGridView1.Columns("colItemName").Frozen = True
    End Sub

    Public Function FindItemParameter(ByRef CItem As CItemParameter) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CItem.GetItemParameter(CItem, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindItemParameter = idok
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
        Dim CItem As New CItemParameter

        If e.KeyCode = Keys.Enter Then
            If CItem.FindItemParameter(dtSet, txtFindString.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ItemCode"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ItemName1"))
                    DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ItemName2"))
                    DataGridView1.Rows(i).Cells(3).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ItemName3"))
                    DataGridView1.Rows(i).Cells(4).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("STN"))
                    DataGridView1.Rows(i).Cells(5).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("STN2"))
                    DataGridView1.Rows(i).Cells(6).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ISI"))
                    DataGridView1.Rows(i).Cells(7).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("ItemPrice"))
                Next
            End If
        End If
    End Sub
End Class