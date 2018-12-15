Public Class FrmSalesOrder
    Dim intDeleted As Integer = 0
    Dim intMouseDownTextBox As Integer = 0

    Private Sub FrmSalesOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fieldClear()
        txtSalesCode.Clear()
        txtCustomerCode.Clear()
        txtPOCust.Clear()
        txtCustomerVLT.Clear()
        txtOrderName.Clear()
        cbIsTaxable.Checked = False
        DataGridView1.Rows.Clear()
        txtDescription.Clear()
        txtSubTotal.Clear()
        txtDiscount.Clear()
        txtPPN.Clear()
        txtBruto.Clear()
        txtNetto.Clear()
        txtCustomerAddress1.Clear()
        txtCustomerAddress2.Clear()
        lblRecStatus.Visible = False
    End Sub

    Private Function autoNumber() As Integer
        Dim iNumber As Int64 = 0
        Dim result As String = String.Empty
        Dim generate As String = String.Empty
        Dim idok As Boolean = False

        Do
            iNumber += 1
            If Not g_bValidValField("SalesOrderHeader", "SONumber='SO/" & Convert.ToDateTime(Now).ToString("yy") &"/" &iNumber.ToString("0000000") & "'") Then
                idok = True
            End If
        Loop Until idok = True
        autoNumber = iNumber
    End Function

    Private Function GenerateCode() As String
        Dim result As String = "SO/" & Convert.ToDateTime(Now).ToString("yy") & "/" & autoNumber.ToString("0000000")
        GenerateCode = result
    End Function

    Private Sub fieldFillSales(ByRef CSales As CSalesParameter)
        txtSalesCode.Text = CSales.szSales_Id
        lblSalesName.Text = CSales.szSales_Name
    End Sub

    Private Sub fieldFillCustomer(ByRef CCustomer As CCustomerParameter)
        txtCustomerCode.Text = CCustomer.szCustomerCode
        lblCustomerName.Text = CCustomer.szCustomerName
        txtCustomerVLT.Text = CCustomer.szCustomerVLT
        If CCustomer.intCustomerPKP = 0 Then
            cbIsTaxable.Checked = False
        Else
            cbIsTaxable.Checked = True
        End If
        txtCustomerAddress1.Text = CCustomer.szCustomerAddress1
        txtCustomerAddress2.Text = CCustomer.szCustomerAddress2
    End Sub

    Private Sub fieldFill(ByRef CCustomer As CCustomerParameter, ByRef CSales As CSalesParameter, ByRef CSOHeader As SalesOrder.CSalesOrderHeader, ByRef dsCSODetail As DataSet)
        txtSONumber.Text = CSOHeader.szSONumber
        dtSODate.Value = CSOHeader.szInputDate
        txtSalesCode.Text = CSOHeader.szSalesCode
        dtShipDate.Value = CSOHeader.szShipDate
        txtCustomerCode.Text = CSOHeader.szCustomerCode
        lblCustomerName.Text = CSOHeader.szCustomerName
        txtCustomerVLT.Text = CSOHeader.szCustomerVLT

        If CCustomer.GetCustomerParameter(CCustomer, CSOHeader.szCustomerCode) Then
            If CCustomer.intCustomerPKP = 1 Then
                cbIsTaxable.Checked = True
            Else
                cbIsTaxable.Checked = False
            End If
        End If

        txtCustomerAddress1.Text = CSOHeader.szCustomerAddress1
        txtCustomerAddress2.Text = CSOHeader.szCustomerAddress2
        txtPOCust.Text = CSOHeader.szPOCustNumber
        txtOrderName.Text = CSOHeader.szOrderingName

        If dsCSODetail.Tables(0).Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
            For i As Integer = 0 To dsCSODetail.Tables(0).Rows.Count - 2
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = Convert.ToString(dsCSODetail.Tables(0).Rows(0)("ItemCode"))
                DataGridView1.Rows(i).Cells(1).Value = Convert.ToString(dsCSODetail.Tables(0).Rows(0)("ItemName"))

            Next
        End If
    End Sub

    Private Sub txtSalesCode_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtSalesCode.MouseDown
        intMouseDownTextBox = 0
    End Sub



    Private Sub tsFind_Click(sender As Object, e As System.EventArgs) Handles tsFind.Click
        Dim CCustomer As New CCustomerParameter
        Dim CSales As New CSalesParameter

        If intMouseDownTextBox = 0 Then
            If FrmFindSales.FindSalesParameter(CSales) Then
                fieldFillSales(CSales)
            End If
        ElseIf intMouseDownTextBox = 1 Then
            If FrmFindCustomer.FindCustomerParameter(CCustomer) Then
                fieldFillCustomer(CCustomer)
            End If
        End If
    End Sub

    Private Sub txtCustomerCode_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtCustomerCode.MouseDown
        intMouseDownTextBox = 1
    End Sub


End Class