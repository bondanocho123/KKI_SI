Public Class FrmFindDriver
    Dim idok As Boolean

    Private Sub FrmFindDriver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("colDriverCode").Frozen = True
        DataGridView1.Columns("colDriverName").Frozen = True
    End Sub

    Public Function FindDriverParameter(ByRef CDriver As CDriverParameter) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CDriver.GetDriverParameter(CDriver, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindDriverParameter = idok
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
        Dim CDriver As New CDriverParameter

        If e.KeyCode = Keys.Enter Then
            If CDriver.FindDriverParameter(dtSet, txtFindString.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverCode"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverName"))
                    DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverAddress1"))
                    DataGridView1.Rows(i).Cells(3).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverAddress2"))
                    DataGridView1.Rows(i).Cells(4).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverTelp"))
                    DataGridView1.Rows(i).Cells(5).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverHp"))
                    DataGridView1.Rows(i).Cells(6).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("DriverNoPol"))

                Next
            End If
        End If
    End Sub
End Class