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

    Private Sub fieldFillUserGroup(ByRef CUserGroup As CUserGroupParameter)
        txtUserGroupID.Text = CUserGroup.szUserGroupId
        lblUserGroupName.Text = CUserGroup.szUserGroupName
        lblUserGroupName.Visible = True
    End Sub

    Private Sub fieldClear()
        txtUserID.Clear()
        txtFullname.Clear()
        txtAddres.Clear()
        txtAddress2.Clear()
        txtemail.Clear()
        txtNohp1.Clear()
        txtNohp2.Clear()
        txtUserGroupID.Clear()
        lblUserGroupName.Text = ""
        lblRecStatus.Visible = False
    End Sub


    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CUser As New CUserParameter
        Dim CUserGroup As New CUserGroupParameter

        If FrmFindUser.FindUserParameter(CUser) Then
            If CUserGroup.GetUserGroupParameter(CUserGroup, CUser.szUserGroup_Id) Then
                fieldFill(CUser, CUserGroup)
            End If
        End If
    End Sub

    Private Sub txtUserID_Leave(sender As Object, e As System.EventArgs) Handles txtUserID.Leave
        Dim CUser As New CUserParameter
        Dim CUserGroup As New CUserGroupParameter

        If CUser.GetUserParameter(CUser, txtUserID.Text) Then
            If CUserGroup.GetUserGroupParameter(CUserGroup, CUser.szUserGroup_Id) Then
                fieldFill(CUser, CUserGroup)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        intDeleted += 1
        If intDeleted Mod 2 = 0 Then
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = False
            intDeleted = 0
        Else
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = True
            intDeleted = 1
        End If
    End Sub

    Private Sub txtUserID_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtUserID.MouseDown
        intMouseDownTextBox = 0
    End Sub

    Private Sub txtUserGroupID_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtUserGroupID.MouseDown
        intMouseDownTextBox = 1
    End Sub

    Private Sub FrmUserParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsFind_Click(sender As Object, e As System.EventArgs) Handles tsFind.Click
        Dim CUser As New CUserParameter
        Dim CUserGroup As New CUserGroupParameter

        Select Case intMouseDownTextBox
            Case 0
                If FrmFindUser.FindUserParameter(CUser) Then
                    If CUserGroup.GetUserGroupParameter(CUserGroup, CUser.szUserGroup_Id) Then
                        fieldFill(CUser, CUserGroup)
                    End If
                End If
            Case 1
                If FrmFindUserGroup.FindUserGroupParameter(CUserGroup) Then
                    fieldFillUserGroup(CUserGroup)
                End If
        End Select
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtUserID.Focus()
        intDeleted = 0
    End Sub

    Private Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CUserGroup As New CUserGroupParameter

        If txtUserID.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblUserID.Text, "This field is required.", txtUserID)
            txtUserID.Focus()
            GoTo out
        End If

        If txtFullname.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblFullName.Text, "This field is required.", txtFullname)
            txtFullname.Focus()
            GoTo out
        End If

        If txtAddres.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblAddress.Text, "This field is required.", txtAddres)
            txtAddres.Focus()
            GoTo out
        End If

        If txtAddress2.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblAddress2.Text, "This field is required.", txtAddress2)
            txtAddress2.Focus()
            GoTo out
        End If

        If Not emailFieldChecking(txtemail.Text) Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblEmail.Text, )
        End If
out:
    End Function
End Class