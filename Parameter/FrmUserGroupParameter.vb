Public Class FrmUserGroupParameter

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextbox As Integer = 0


    Private Sub FrmUserGroupParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUserGroupId.Text = GenerateCode()
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("UserGroupParameter", "UserGroup_Id='" & iNumber.ToString("00000") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = autoNumber.ToString("00000")
        GenerateCode = result
    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtUserGroupId.Text = GenerateCode()
        intDeleted = 0
        txtUserGroupName.Focus()
    End Sub

    Private Sub fieldClear()
        txtUserGroupId.Clear()
        txtUserGroupName.Clear()
    End Sub

    Private Function fieldChecking() As Boolean
        fieldChecking = True

        If txtUserGroupId.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblUserGroupID.Text, "This field is required", txtUserGroupId)
            txtUserGroupId.Focus()
            GoTo out
        End If

        If txtUserGroupName.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblUserGroupName.Text, "This field is required", txtUserGroupName)
            txtUserGroupName.Focus()
            GoTo out
        End If
out:
    End Function

    Private Sub fieldFill(ByRef CUserGroup As CUserGroupParameter)
        txtUserGroupId.Text = CUserGroup.szUserGroupId
        txtUserGroupName.Text = CUserGroup.szUserGroupName

        If CUserGroup.intBDeleted = 0 Then
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

    Public Sub SaveUserGroupParameter()
        Dim CUserGroup As New CUserGroupParameter
        Dim CUser As New CUserParameter
        Dim CUserGroupAuthor As New CUserGroupAuthorized

        If Not fieldChecking() Then
            GoTo out
        End If

        If CUserGroup.GetUserGroupParameter(CUserGroup, txtUserGroupId.Text) Then
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthor.GetUserGroupAuthorized("Parameter | User Group | Edit", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        Else
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthor.GetUserGroupAuthorized("Parameter | User Group | Add", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        End If

        If Not msgQuestion("Save Data ?", "Save") Then
            GoTo out
        End If

        CUserGroup.szUserGroupId = txtUserGroupId.Text
        CUserGroup.szUserGroupName = txtUserGroupName.Text.ToUpper()

        If lblRecStatus.Visible = True Then
            CUserGroup.intBDeleted = 1
        Else
            CUser.intBdeleted = 0
        End If

        If CUserGroup.SaveUserGroupParameter(CUserGroup) Then
            MsgBoxShow("Saving data successfull", 1)
            If CUserGroup.GetUserGroupParameter(CUserGroup, CUserGroup.szUserGroupId) Then
                fieldFill(CUserGroup)
                GoTo out
            End If
        End If
        
Err:
        MsgBoxShow(g_szError, 0)
out:
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CuserGroup As New CUserGroupParameter

        If FrmFindUserGroup.FindUserGroupParameter(CuserGroup) Then
            fieldFill(CuserGroup)
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveUserGroupParameter()
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

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class