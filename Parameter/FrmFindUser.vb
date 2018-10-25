Public Class FrmFindUser
    Dim idok As Boolean

    Private Sub FrmFindUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("colUserID").Frozen = True
        DataGridView1.Columns("colFullName").Frozen = True
    End Sub

    Private Sub txtUserId_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUserId.KeyDown
        Dim dtSet As New DataSet
        Dim CUser As New CUserParameter

        If e.KeyCode = Keys.Enter Then
            If CUser.FindUserParameter(dtSet, txtUserId.Text) Then
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("User_Id"))
                    DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("FullName"))
                    DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Address1"))
                    DataGridView1.Rows(i).Cells(3).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Address2"))
                    DataGridView1.Rows(i).Cells(4).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("Email"))
                    DataGridView1.Rows(i).Cells(5).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("PhoneNumber1"))
                    DataGridView1.Rows(i).Cells(6).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("PhoneNumber2"))
                    DataGridView1.Rows(i).Cells(7).Value = Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Id"))

                Next
            End If
        End If
    End Sub



    Public Function FindUserParameter(ByRef CUser As CUserParameter) As Boolean
        idok = False
        Me.ShowDialog()
        If idok = True Then
            CUser.GetUserParameter(CUser, Convert.ToString(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value))
        End If
        FindUserParameter = idok
    End Function

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
        idok = True
    End Sub
End Class