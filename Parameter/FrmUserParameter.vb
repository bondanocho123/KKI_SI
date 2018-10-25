Public Class FrmUserParameter
    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0

    Private Sub fieldFill(ByRef CUser As CUserParameter, ByRef CUserGroup As CUserGroupParameter)
        txtUserID.Text = CUser.szUserId
        txtFullname.Text = CUser.szFullname
        txtAddres.Text = CUser.szAddress1
        txtAddress2.Text = CUser.szAddress2
        txtemail.Text = CUser.szEmail
        txtNohp1.Text = CUser.szPhoneNumber1
        txtNohp2.Text = CUser.szPhoneNumber2
        txtUserGroupID.Text = CUserGroup.szUserGroupId
        lblUserGroupName.Text = CUserGroup.szUserGroupName
        lblUserGroupName.Visible = True

        If CUser.intBdeleted = 0 Then
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = False
            intDeleted = 0
        Else
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = True
            intDeleted = 1
        End If
        btnDelete.Enabled = True
        btnSave.Enabled = True

    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click

    End Sub
End Class