Public Class FrmFindUserGroup
    Dim idok As Boolean

    Private Sub FrmFindUserGroup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function FindUserGroupParameter(ByRef CUserGroup As CUserGroupParameter) As Boolean
        idok = False
        Me.ShowDialog()

        If idok = True Then
            CUserGroup.GetUserGroupParameter(CUserGroup, DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value)
        End If
        FindUserGroupParameter = idok
    End Function


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
        idok = True
    End Sub


    Private Sub txtUserGroupId_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUserGroupId.KeyDown
        Dim dtSet As New DataSet
        Dim CUserGroup As New CUserGroupParameter
        If e.KeyCode = Keys.Enter Then
            If CUserGroup.FindUserGroupParameter(dtSet, txtUserGroupId.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Id"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Name"))
                Next
            End If
        End If
    End Sub
End Class