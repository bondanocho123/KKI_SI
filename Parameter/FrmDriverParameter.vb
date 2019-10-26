Public Class FrmDriverParameter

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtDriverCode.Text = GenerateCode()
        intDeleted = 0
        txtDriverName.Focus()
    End Sub

    Private Sub fieldClear()
        txtDriverCode.Clear()
        txtDriverName.Clear()
        txtDriverAddress1.Clear()
        txtDriverAddress2.Clear()
        txtDriverTelp.Clear()
        txtDriverHp.Clear()
        txtVehicleCode.Clear()
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("DriverParameter", "DriverCode='DVR" & iNumber.ToString("00") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "DVR" & autoNumber.ToString("00")
        GenerateCode = result
    End Function

    Private Sub fieldFill(ByRef CDriver As CDriverParameter)
        txtDriverCode.Text = CDriver.szDriverCode
        txtDriverName.Text = CDriver.szDriverName
        txtDriverAddress1.Text = CDriver.szDriverAddress1
        txtDriverAddress2.Text = CDriver.szDriverAddress2
        txtDriverHp.Text = CDriver.szDriverHp
        txtDriverTelp.Text = CDriver.szDriverTelp
        txtVehicleCode.Text = CDriver.szDriverNoPol

        If CDriver.intBDeleted = 0 Then
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
        Dim CDriver As New CDriverParameter

        If FrmFindDriver.FindDriverParameter(CDriver) Then
            fieldFill(CDriver)
        End If
    End Sub

    Public Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CDriver As New CDriverParameter

        If txtDriverCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblDriverCode.Text, "This field is required.", txtDriverCode)
            txtDriverCode.Focus()
            GoTo out
        End If

        If txtDriverName.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblDriverName.Text, "This field is required.", txtDriverName)
            txtDriverName.Focus()
            GoTo out
        End If

        If txtDriverAddress1.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblDriverAddress1.Text, "This field is required.", txtDriverAddress1)
            txtDriverAddress1.Focus()
            GoTo out
        End If

        If txtDriverAddress2.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblDriverAddress2.Text, "This field is required.", txtDriverAddress2)
            txtDriverAddress2.Focus()
            GoTo out
        End If

        If txtDriverHp.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field is required.", txtDriverHp)
            txtDriverHp.Focus()
            GoTo out
        Else
            If Not IsNumeric(txtDriverHp.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric.", txtDriverHp)
                txtDriverHp.Focus()
                GoTo out
            End If
        End If

        If Not IsNumeric(txtDriverTelp.Text) Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric.", txtDriverTelp)
            txtDriverTelp.Focus()
            GoTo out
        End If

        If txtVehicleCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblDriverNoPol.Text, "This field is required.", txtVehicleCode)
            txtVehicleCode.Focus()
            GoTo out
        End If

out:
    End Function

    Public Sub SaveDriverParameter()
        Dim CDriver As New CDriverParameter
        Dim CUserGroupAuthorized As New CUserGroupAuthorized
        Dim CUser As New CUserParameter

        If Not fieldChecking() Then
            GoTo out
        End If

        If CDriver.GetDriverParameter(CDriver, txtDriverCode.Text) Then
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

        CDriver.szDriverCode = txtDriverCode.Text
        CDriver.szDriverName = txtDriverName.Text
        CDriver.szDriverAddress1 = txtDriverAddress1.Text
        CDriver.szDriverAddress2 = txtDriverAddress2.Text
        CDriver.szDriverHp = txtDriverHp.Text
        CDriver.szDriverTelp = txtDriverTelp.Text
        CDriver.szDriverNoPol = txtVehicleCode.Text

        If lblRecStatus.Visible = True Then
            CDriver.intBDeleted = 1
        Else
            CDriver.intBDeleted = 0
        End If

        If CDriver.SaveDriverParameter(CDriver) Then
            MsgBoxShow("Saving data successfull", 1)
            If CDriver.GetDriverParameter(CDriver, txtDriverCode.Text) Then
                fieldFill(CDriver)
                GoTo out
            End If
        End If
Err:
        MsgBoxShow(g_szError, 0)
out:

    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveDriverParameter()
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