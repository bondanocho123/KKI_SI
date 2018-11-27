Public Class FrmItemParameter

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0

    Private Sub FrmItemParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fieldClear()
        txtItemCode.Clear()
        txtItemName1.Clear()
        txtItemName2.Clear()
        txtItemName3.Clear()
        txtBigUnit.Clear()
        txtSmallUnit.Clear()
        txtNetAmount.Clear()
        txtItemPrice.Clear()
        lblRecStatus.Visible = False
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("ItemParameter", "ItemCode='BRG" & iNumber.ToString("0000000") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "BRG" & autoNumber.ToString("0000000")
        GenerateCode = result
    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtItemCode.Text = GenerateCode()
        intDeleted = 0
        txtItemName1.Focus()
    End Sub

    Private Sub fieldFill(ByRef CItem As CItemParameter)
        txtItemCode.Text = CItem.szItemCode
        txtItemName1.Text = CItem.szItemName1
        txtItemName2.Text = CItem.szItemName2
        txtItemName3.Text = CItem.szItemName3
        txtBigUnit.Text = CItem.szSTN
        txtSmallUnit.Text = CItem.szSTN2
        txtNetAmount.Text = CItem.dblISI
        txtItemPrice.Text = CItem.dblItemPrice

        If CItem.intBDeleted = 0 Then
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


    Private Sub btnOpen_Click(sender As Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CItem As New CItemParameter

        If FrmFindItem.FindItemParameter(CItem) Then
            fieldFill(CItem)
        End If
    End Sub

    Private Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CItem As New CItemParameter

        If txtItemCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblItemCode.Text, "This field is required.", txtItemCode)
            txtItemCode.Focus()
            GoTo out
        End If

        If txtItemName1.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblItemName1.Text, "This field is required.", txtItemName1)
            txtItemName1.Focus()
            GoTo out
        End If

        If txtItemName2.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblItemName2.Text, "This field is required.", txtItemName2)
            txtItemName2.Focus()
            GoTo out
        End If

        If txtItemName3.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblItemName3.Text, "This field is required.", txtItemName3)
            txtItemName3.Focus()
            GoTo out
        End If

        If txtBigUnit.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblBigUnit.Text, "This field is required.", txtBigUnit)
            txtBigUnit.Focus()
            GoTo out
        End If

        If txtSmallUnit.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSmallUnit.Text, "This field is required.", txtSmallUnit)
            txtSmallUnit.Focus()
            GoTo out
        End If

        If txtNetAmount.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNetAmount.Text, "This field is required.", txtNetAmount)
            txtNetAmount.Focus()
            GoTo out
        End If

        If txtItemPrice.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblItemPrice.Text, "This field is required.", txtItemPrice)
            txtItemPrice.Focus()
            GoTo out
        End If


out:
    End Function

    Public Sub SaveItemParameter()
        Dim CItem As New CItemParameter
        Dim CUserGroupAuthorized As New CUserGroupAuthorized
        Dim CUser As New CUserParameter

        If Not fieldChecking() Then
            GoTo out
        End If

        If CItem.GetItemParameter(CItem, txtItemCode.Text) Then
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

        CItem.szItemCode = txtItemCode.Text
        CItem.szItemName1 = txtItemName1.Text
        CItem.szItemName2 = txtItemName2.Text
        CItem.szItemName3 = txtItemName3.Text
        CItem.szSTN = txtBigUnit.Text
        CItem.szSTN2 = txtSmallUnit.Text
        CItem.dblISI = txtNetAmount.Text
        CItem.dblItemPrice = txtItemPrice.Text

        If lblRecStatus.Visible = True Then
            CItem.intBDeleted = 1
        Else
            CItem.intBDeleted = 0
        End If

        If CItem.SaveItemParameter(CItem) Then
            MsgBoxShow("Saving data successfull", 1)
            If CItem.GetItemParameter(CItem, txtItemCode.Text) Then
                fieldFill(CItem)
                GoTo out
            End If
        End If
        GoTo out
Err:
        MsgBoxShow(g_szError, 0)
out:
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveItemParameter()
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