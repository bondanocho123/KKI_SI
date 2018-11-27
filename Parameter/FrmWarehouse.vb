Public Class FrmWarehouse

    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0
    Dim intRowIndex As Integer
    Private Sub FrmWarehouse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("WarehouseParameterA", "WarehouseCode='WH" & iNumber.ToString("00") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "WH" & autoNumber.ToString("00")
        GenerateCode = result
    End Function

    Private Sub fieldClear()
        txtWarehouseCode.Clear()
        txtWarehouseName.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub fieldFill(ByRef CWarehouseA As Warehouse.CWarehouseParameterA, ByRef dtWarehouseB As DataSet)
        txtWarehouseCode.Text = CWarehouseA.szWarehouseCode
        txtWarehouseName.Text = CWarehouseA.szWarehouseName

        If CWarehouseA.intBDeleted = 0 Then
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = False
            intDeleted = 0
        Else
            lblRecStatus.Text = "Deleted"
            lblRecStatus.Visible = True
            intDeleted = 1
        End If

        If dtWarehouseB.Tables(0).Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
            For i As Integer = 0 To dtWarehouseB.Tables(0).Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dtWarehouseB.Tables(0).Rows(i)("RackCode"))
                DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dtWarehouseB.Tables(0).Rows(i)("ItemCode"))
                DataGridView1.Rows(i).Cells(2).Value = Convert.ToString(dtWarehouseB.Tables(0).Rows(i)("ItemName"))
            Next
        End If
    End Sub

    Private Sub fieldFillItem(ByRef CItem As CItemParameter, ByVal RowIndex As Integer)
        DataGridView1.Rows(RowIndex).Cells(1).Value = CItem.szItemCode
        DataGridView1.Rows(RowIndex).Cells(2).Value = CItem.szItemName1

    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim CWarehouseA As New Warehouse.CWarehouseParameterA
        Dim CWarehouseB As New Warehouse.CWarehouseParameterB
        Dim dtSet As New DataSet
        If FrmFindWarehouse.FindWarehouseParameter(CWarehouseA) Then
            If CWarehouseA.GetWarehouseParameterA(CWarehouseA, CWarehouseA.szWarehouseCode) Then
                If CWarehouseB.GetDetailWarehouse(dtSet, CWarehouseA.szWarehouseCode) Then
                    fieldFill(CWarehouseA, dtSet)
                End If
            End If
        End If
    End Sub

    Private Function fieldChecking() As Boolean
        fieldChecking = True
        Dim CItem As New CItemParameter
        Dim CWarehouseB As New Warehouse.CWarehouseParameterB

        If txtWarehouseCode.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblWarehouseCode.Text, "This field is required.", txtWarehouseCode)
            txtWarehouseCode.Focus()
            GoTo out
        End If

        If txtWarehouseName.Text.Trim.Length = 0 Then
            fieldChecking = Not g_toolTip(ToolTipIcon.Info, lblWarehouseCode.Text, "This field is required.", txtWarehouseName)
            txtWarehouseName.Focus()
            GoTo out
        End If

        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            If DataGridView1.Rows(i).Cells(0).Value = "" Then
                ErrorProvider1.SetError(DataGridView1, "This field is required. (" & colRackCode.HeaderText & ")")
                fieldChecking = False
                GoTo out
            End If

            If CWarehouseB.GetWarehouseB(CWarehouseB, DataGridView1.Rows(i).Cells(0).Value) Then
                ErrorProvider1.SetError(DataGridView1, "This field has been duplicated. (" & colRackCode.HeaderText & ")")
                fieldChecking = False
                GoTo out
            End If

            If Not CItem.GetItemParameter(CItem, DataGridView1.Rows(i).Cells(1).Value) Then
                ErrorProvider1.SetError(DataGridView1, "This field is invalid.")
                fieldChecking = False
                GoTo out
            End If
        Next
out:
    End Function

    Private Sub SaveWarehouseParameter()
        Dim CWarehouseA As New Warehouse.CWarehouseParameterA
        Dim CWarehouseB As New Warehouse.CWarehouseParameterB
        Dim CUserGroupAuthorized As New CUserGroupAuthorized
        Dim CUser As New CUserParameter
        Dim dtSet As New DataSet

        If Not fieldChecking() Then
            GoTo out
        End If

        If CWarehouseA.GetWarehouseParameterA(CWarehouseA, txtWarehouseCode.Text) Then
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Warehouse | Edit", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        Else
            If CUser.GetUserParameter(CUser, g_szUserId) Then
                If Not CUserGroupAuthorized.GetUserGroupAuthorized("Parameter | Warehouse | Add", CUser.szUserGroup_Id) Then
                    g_szError = "You are not authorized." & vbCrLf & "Check your administrator"
                    GoTo Err
                End If
            End If
        End If

        If Not msgQuestion("Save Data ?", "Save") Then
            GoTo out
        End If

        CWarehouseA.szWarehouseCode = txtWarehouseCode.Text
        CWarehouseA.szWarehouseName = txtWarehouseName.Text

        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            CWarehouseB.szWarehouseCode = txtWarehouseCode.Text
            CWarehouseB.szRackCode = DataGridView1.Rows(i).Cells(0).Value
            CWarehouseB.szItemCode = DataGridView1.Rows(i).Cells(1).Value
            CWarehouseB.szItemName = DataGridView1.Rows(i).Cells(2).Value
            If CWarehouseB.SaveWarehouseB(CWarehouseB) Then
            End If
        Next

        If lblRecStatus.Visible = True Then
            CWarehouseA.intBDeleted = 1
        Else
            CWarehouseA.intBDeleted = 0
        End If

        If CWarehouseA.SaveWarehouseA(CWarehouseA) Then
            MsgBoxShow("Saving data successfull", 1)
            If CWarehouseA.GetWarehouseParameterA(CWarehouseA, txtWarehouseCode.Text) Then
                If CWarehouseB.GetDetailWarehouse(dtSet, txtWarehouseCode.Text) Then
                    fieldFill(CWarehouseA, dtSet)
                End If
            End If
        End If

        GoTo out
Err:
        MsgBoxShow(g_szError, 0)
out:
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveWarehouseParameter()
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

    Private Sub tsFind_Click(sender As Object, e As System.EventArgs) Handles tsFind.Click
        Dim CItem As New CItemParameter
        If FrmFindItem.FindItemParameter(CItem) Then
            fieldFillItem(CItem, intRowIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        intRowIndex = DataGridView1.CurrentRow.Index
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        fieldClear()
        txtWarehouseCode.Text = GenerateCode()
        intDeleted = 0
        txtWarehouseName.Focus()
    End Sub

    
End Class