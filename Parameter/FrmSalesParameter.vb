Imports FunctionSQL.BNDNBUILDER

Public Class FrmSalesParameter

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0
    Dim BV As Validator
    Private Sub FrmSalesParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fieldClear()
        txtSalesCode.Clear()
        txtSalesName.Clear()
        txtSalesAddress1.Clear()
        txtSalesAddress2.Clear()
        txtSalesHp.Clear()
        txtSalesPersonalNumber.Clear()
        lblRecStatus.Visible = False
    End Sub


    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            Dim i As String = "Sales_Id='SLS" & iNumber.ToString("0000") & "'"
            If Not g_bValidValField("SalesParameter", i) Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "SLS" & autoNumber.ToString("0000")
        GenerateCode = result
    End Function

    Private Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CSales As New CSalesParameter

        If txtSalesCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesCode.Text, "This field is required", txtSalesCode)
            GoTo out
        End If

        If txtSalesName.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesName.Text, "This field is required", txtSalesName)
            GoTo out
        End If

        If txtSalesAddress1.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesAddress1.Text, "This field is required", txtSalesAddress1)
            GoTo out
        End If

        If txtSalesAddress2.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesAddress2.Text, "This field is required", txtSalesAddress2)
            GoTo out
        End If

        If txtSalesHp.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field is required", txtSalesHp)
            GoTo out
        Else
            If Not IsNumeric(txtSalesHp.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric.", txtSalesHp)
                txtSalesHp.Focus()
                GoTo out
            End If
        End If

        If txtSalesPersonalNumber.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesKTP.Text, "This field is required", txtSalesPersonalNumber)
            GoTo out
        Else
            If Not IsNumeric(txtSalesPersonalNumber.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesKTP.Text, "This field must be numeric.", txtSalesPersonalNumber)
                txtSalesPersonalNumber.Focus()
                GoTo out
            End If
        End If

out:

    End Function


    Private Sub fieldFill(ByRef CSales As CSalesParameter)
        txtSalesCode.Text = CSales.szSales_Id
        txtSalesName.Text = CSales.szSales_Name
        txtSalesAddress1.Text = CSales.szSales_Address1
        txtSalesAddress2.Text = CSales.szSales_Address2
        txtSalesHp.Text = CSales.szSales_Telp
        txtSalesPersonalNumber.Text = CSales.szSales_Ktp
        If CSales.intBDeleted = 0 Then
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

    Public Sub SaveSalesParameter()
        Dim CSales As New CSalesParameter
        Dim CUserGroupAuthorized As New CUserGroupAuthorized
        Dim CUser As New CUserParameter

        If Not fieldChecking() Then
            GoTo out
        End If

        If CSales.GetSalesParameter(CSales, txtSalesCode.Text) Then
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Sales | Edit", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        Else
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Sales | Add", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        End If

        If Not msgQuestion("Save Data ?", "Save") Then
            GoTo out
        End If

        CSales.szSales_Id = txtSalesCode.Text
        CSales.szSales_Name = txtSalesName.Text
        CSales.szSales_Address1 = txtSalesAddress1.Text
        CSales.szSales_Address2 = txtSalesAddress2.Text
        CSales.szSales_Telp = txtSalesHp.Text
        CSales.szSales_Ktp = txtSalesPersonalNumber.Text

        If lblRecStatus.Visible = True Then
            CSales.intBDeleted = 1
        Else
            CSales.intBDeleted = 0
        End If

        If CSales.SaveSalesParameter(CSales) Then
            MsgBoxShow("Saving data successfull", 1)
            If CSales.GetSalesParameter(CSales, txtSalesCode.Text) Then
                fieldFill(CSales)
                GoTo out
            End If
        End If
        GoTo out


Err:
        MsgBoxShow(g_szError, 0)

out:
    End Sub




    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtSalesCode.Text = GenerateCode()
        intDeleted = 0
        txtSalesName.Focus()
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CSales As New CSalesParameter

        If FrmFindSales.FindSalesParameter(CSales) Then
            fieldFill(CSales)
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveSalesParameter()
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

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As System.Object, e As System.EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub
End Class