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

    Private Sub txtUserGroupID_GotFocus(sender As Object, e As System.EventArgs) Handles txtUserGroupID.GotFocus
        intMouseDownTextBox = 1
    End Sub

    Private Sub txtUserGroupID_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtUserGroupID.MouseDown
        intMouseDownTextBox = 1
    End Sub

    Private Sub FrmUserParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUserID.Text = GenerateCode()
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
        txtUserID.Text = GenerateCode()
        intDeleted = 0
        txtFullname.Focus()
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


        If Not emailFieldChecking(txtemail.Text) Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblEmail.Text, "Please check your email", txtemail)
            txtemail.Focus()
        End If

        If txtNohp1.Text.Trim.Length <> 0 Then
            If Not IsNumeric(txtNohp1.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric", txtNohp1)
                txtNohp1.Clear()
                txtNohp1.Focus()
            End If
        Else
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field is required", txtNohp1)
            txtNohp1.Focus()
        End If

        If txtNohp2.Text.Trim.Length <> 0 Then
            If Not IsNumeric(txtNohp2.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric", txtNohp2)
                txtNohp2.Clear()
                txtNohp2.Focus()
            End If
        End If



        If Not CUserGroup.GetUserGroupParameter(CUserGroup, txtUserGroupID.Text) Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblUserGroupID.Text, "This field is invalid", txtUserGroupID)
            txtUserGroupID.Focus()
        End If

out:
    End Function

    Public Sub SaveUserParameter()
        Dim CUser As New CUserParameter
        Dim CUserGroup As New CUserGroupParameter
        Dim CUserGroupAuthorized As New CUserGroupAuthorized

        If Not fieldChecking() Then
            GoTo out
        End If

        If CUser.GetUserParameter(CUser, txtUserID.Text) Then
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | User | Edit", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
            
        Else
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | User | Add", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        End If

        If Not msgQuestion("Save Data ?", "Save") Then
            GoTo out
        End If

        CUser.szUserId = txtUserID.Text
        CUser.szFullname = txtFullname.Text
        CUser.szEmail = txtemail.Text
        CUser.szAddress1 = txtAddres.Text
        CUser.szAddress2 = txtAddress2.Text
        CUser.szPhoneNumber1 = txtNohp1.Text
        CUser.szPhoneNumber2 = txtNohp2.Text
        CUser.szUserGroup_Id = txtUserGroupID.Text

        If lblRecStatus.Visible = True Then
            CUser.intBdeleted = 1
        Else
            CUser.intBdeleted = 0
        End If

        If CUser.SaveUserParameter(CUser) Then
            MsgBoxShow("Saving data successfull", 1)
            If CUserGroup.GetUserGroupParameter(CUserGroup, CUser.szUserGroup_Id) Then
                fieldFill(CUser, CUserGroup)
                GoTo out
            End If
        End If
Err:
        MsgBoxShow(g_szError, 0)
out:
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveUserParameter()
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("UserParameter", "User_Id='USR" & iNumber.ToString("00") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "USR" & autoNumber.ToString("00")
        GenerateCode = result
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class