Public Class FrmCustomerParameter

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtCustomerCode.Text = GenerateCode()
        intDeleted = 0
        txtCustomerName.Focus()
    End Sub

    Private Sub fieldClear()
        txtCustomerCode.Clear()
        txtCustomerName.Clear()
        txtCustomerAddress1.Clear()
        txtCutomerAddress2.Clear()
        txtCustomerTelp.Clear()
        txtCustomerNPWP.Clear()
        cbCustomerPKP.Checked = False
        txtSalesCode.Clear()
        txtCustomerVLT.Clear()
        lblRecStatus.Visible = False
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("CustomerParameter", "CustomerCode='CSR" & iNumber.ToString("0000000") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "CSR" & autoNumber.ToString("0000000")
        GenerateCode = result
    End Function

    Private Sub fieldFill(ByRef CCustomer As CCustomerParameter, ByRef CSales As CSalesParameter)
        txtCustomerCode.Text = CCustomer.szCustomerCode
        txtCustomerName.Text = CCustomer.szCustomerName
        txtCustomerAddress1.Text = CCustomer.szCustomerAddress1
        txtCutomerAddress2.Text = CCustomer.szCustomerAddress2
        txtCustomerTelp.Text = CCustomer.szCustomerTelp
        txtCustomerNPWP.Text = CCustomer.szCustomerNPWP

        If CCustomer.intCustomerPKP = 0 Then
            cbCustomerPKP.Checked = False
        Else
            cbCustomerPKP.Checked = True
        End If

        txtSalesCode.Text = CSales.szSales_Id
        lblSalesName.Text = CSales.szSales_Name
        txtCustomerVLT.Text = CCustomer.szCustomerVLT

        If CCustomer.intBDeleted = 0 Then
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

    Private Sub fieldFillSales(ByRef CSales As CSalesParameter)
        txtSalesCode.Text = CSales.szSales_Id
        lblSalesName.Text = CSales.szSales_Name
        lblSalesName.Visible = True
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CCustomer As New CCustomerParameter
        Dim CSales As New CSalesParameter
        If FrmFindCustomer.FindCustomerParameter(CCustomer) Then
            If CSales.GetSalesParameter(CSales, CCustomer.szCustomerSales) Then
                fieldFill(CCustomer, CSales)
            End If
        End If

    End Sub

    Private Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CSales As New CSalesParameter

        If txtCustomerCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerCode.Text, "This field is required.", txtCustomerCode)
            txtCustomerCode.Focus()
            GoTo out
        End If

        If txtCustomerName.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerName.Text, "This field is required.", txtCustomerName)
            txtCustomerName.Focus()
            GoTo out
        End If

        If txtCustomerAddress1.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerAddress1.Text, "This field is required.", txtCustomerAddress1)
            txtCustomerAddress1.Focus()
            GoTo out
        End If


        If txtCutomerAddress2.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerAddress2.Text, "This field is required.", txtCutomerAddress2)
            txtCutomerAddress2.Focus()
            GoTo out
        End If

        If txtCustomerTelp.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field is required.", txtCustomerTelp)
            txtCustomerTelp.Focus()
            GoTo out
        Else
            If Not IsNumeric(txtCustomerTelp.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblNohp.Text, "This field must be numeric.", txtCustomerTelp)
                txtCustomerTelp.Focus()
                GoTo out
            End If
        End If

        If txtCustomerNPWP.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerNPWP.Text, "This field is required.", txtCustomerNPWP)
            txtCustomerNPWP.Focus()
            GoTo out
        Else
            If Not IsNumeric(txtCustomerNPWP.Text) Then
                fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerNPWP.Text, "This field must be numeric.", txtCustomerNPWP)
                txtCustomerNPWP.Focus()
                GoTo out
            End If
        End If

        
        If Not CSales.GetSalesParameter(CSales, txtSalesCode.Text) Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblSalesCode.Text, "This field is invalid", txtSalesCode)
            txtSalesCode.Focus()
        End If

        If txtCustomerVLT.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblCustomerVLT.Text, "This field is required.", txtCustomerVLT)
            txtCustomerVLT.Focus()
            GoTo out
        End If

out:
    End Function

    Private Sub SaveCustomerParameter()
        Dim CUser As New CUserParameter
        Dim CUserGroupAuthorized As New CUserGroupAuthorized
        Dim CCustomer As New CCustomerParameter
        Dim CSales As New CSalesParameter

        If Not fieldChecking() Then
            GoTo out
        End If

        If CCustomer.GetCustomerParameter(CCustomer, txtCustomerCode.Text) Then
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Customer | Edit", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        Else
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Customer | Add", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        End If

        If Not msgQuestion("Save Data ?", "Save") Then
            GoTo out
        End If

        CCustomer.szCustomerCode = txtCustomerCode.Text
        CCustomer.szCustomerName = txtCustomerName.Text
        CCustomer.szCustomerAddress1 = txtCustomerAddress1.Text
        CCustomer.szCustomerAddress2 = txtCutomerAddress2.Text
        CCustomer.szCustomerTelp = txtCustomerTelp.Text
        CCustomer.szCustomerNPWP = txtCustomerNPWP.Text

        If cbCustomerPKP.Checked = True Then
            CCustomer.intCustomerPKP = 1
        Else
            CCustomer.intCustomerPKP = 0
        End If
        CCustomer.szCustomerSales = txtSalesCode.Text
        CCustomer.szCustomerVLT = txtCustomerVLT.Text
        CCustomer.szTglInput = Convert.ToDateTime(Now).ToString("yyyy-MM-dd hh:mm:ss")
        CCustomer.szUsername = g_szUsername
        If lblRecStatus.Visible = True Then
            CCustomer.intBDeleted = 1
        Else
            CCustomer.intBDeleted = 0
        End If

        If CCustomer.SaveCustomerparameter(CCustomer) Then
            MsgBoxShow("Saving data successfull", 1)
            If CCustomer.GetCustomerParameter(CCustomer, txtCustomerCode.Text) Then
                If CSales.GetSalesParameter(CSales, CCustomer.szCustomerSales) Then
                    fieldFill(CCustomer, CSales)
                    GoTo out
                End If
            End If
        End If
        GoTo out
Err:
        MsgBoxShow(g_szError, 0)
out:
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveCustomerParameter()
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

    Private Sub FrmCustomerParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsFind_Click(sender As Object, e As System.EventArgs) Handles tsFind.Click
        Dim CSales As New CSalesParameter
        
        If intMouseDownTextBox = 1 Then
            If FrmFindSales.FindSalesParameter(CSales) Then
                fieldFillSales(CSales)
            End If
        End If
    End Sub

    Private Sub txtSalesCode_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtSalesCode.MouseDown
        intMouseDownTextBox = 1
    End Sub
End Class