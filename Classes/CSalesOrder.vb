Imports System.Data
Imports System.Data.SqlClient

Namespace SalesOrder

    Public Class CSalesOrderHeader
        Private m_szSONumber As String = String.Empty
        Private m_szInputDate As String = String.Empty
        Private m_szShipDate As String = String.Empty
        Private m_szPOCustNumber As String = String.Empty
        Private m_szOrderingName As String = String.Empty
        Private m_szCustomerCode As String = String.Empty
        Private m_szCustomerName As String = String.Empty
        Private m_szCustomerAddress1 As String = String.Empty
        Private m_szCustomerAddress2 As String = String.Empty
        Private m_szCustomerVLT As String = String.Empty
        Private m_szSalesCode As String = String.Empty
        Private m_flDiscount As Double
        Private m_flAmountDiscount As Double
        Private m_flPpn As Double
        Private m_flAmountPpn As Double
        Private m_flBruto As Double
        Private m_flNetto As Double
        Private m_szUsername As String = String.Empty
        Private m_flDownPayment As Double

        Public Property szSONumber As String
            Get
                szSONumber = m_szSONumber
            End Get
            Set(value As String)
                m_szSONumber = value
            End Set
        End Property

        Public Property szInputDate As String
            Get
                szInputDate = m_szInputDate
            End Get
            Set(value As String)
                m_szInputDate = value
            End Set
        End Property

        Public Property szShipDate As String
            Get
                szShipDate = m_szShipDate
            End Get
            Set(value As String)
                m_szShipDate = value
            End Set
        End Property

        Public Property szPOCustNumber As String
            Get
                szPOCustNumber = m_szPOCustNumber
            End Get
            Set(value As String)
                m_szPOCustNumber = value
            End Set
        End Property

        Public Property szCustomerCode As String
            Get
                szCustomerCode = m_szCustomerCode
            End Get
            Set(value As String)
                m_szCustomerCode = value
            End Set
        End Property

        Public Property szCustomerName As String
            Get
                szCustomerName = m_szCustomerName
            End Get
            Set(value As String)
                m_szCustomerName = value
            End Set
        End Property

        Public Property szCustomerAddress1 As String
            Get
                szCustomerAddress1 = m_szCustomerAddress1
            End Get
            Set(value As String)
                m_szCustomerAddress1 = value
            End Set
        End Property

        Public Property szCustomerAddress2 As String
            Get
                szCustomerAddress2 = m_szCustomerAddress2
            End Get
            Set(value As String)
                m_szCustomerAddress2 = value
            End Set
        End Property

        Public Property szCustomerVLT As String
            Get
                szCustomerVLT = m_szCustomerVLT
            End Get
            Set(value As String)
                m_szCustomerVLT = value
            End Set
        End Property

        Public Property szSalesCode As String
            Get
                szSalesCode = m_szSalesCode
            End Get
            Set(value As String)
                m_szSalesCode = value
            End Set
        End Property

        Public Property flDiscount As Double
            Get
                flDiscount = m_flDiscount
            End Get
            Set(value As Double)
                m_flDiscount = value
            End Set
        End Property

        Public Property flAmountDiscount As Double
            Get
                flAmountDiscount = m_flAmountDiscount
            End Get
            Set(value As Double)
                m_flAmountDiscount = value
            End Set
        End Property

        Public Property flPpn As Double
            Get
                flPpn = m_flPpn
            End Get
            Set(value As Double)
                m_flPpn = value
            End Set
        End Property

        Public Property flAmountPpn As Double
            Get
                flAmountPpn = m_flPpn
            End Get
            Set(value As Double)
                m_flPpn = value
            End Set
        End Property

        Public Property flBruto As Double
            Get
                flBruto = m_flBruto
            End Get
            Set(value As Double)
                m_flBruto = value
            End Set
        End Property

        Public Property flNetto As Double
            Get
                flNetto = m_flNetto
            End Get
            Set(value As Double)
                m_flNetto = value
            End Set
        End Property

        Public Property szUsername As String
            Get
                szUsername = m_szUsername
            End Get
            Set(value As String)
                m_szUsername = value
            End Set
        End Property

        Public Property flDownPayment As Double
            Get
                flDownPayment = m_flDownPayment
            End Get
            Set(value As Double)
                m_flDownPayment = value
            End Set
        End Property

        Public Property szOrderingName As String
            Get
                szOrderingName = m_szOrderingName
            End Get
            Set(value As String)
                m_szOrderingName = value
            End Set
        End Property

        Public Function GetSalesOrderHeader(ByRef CSOHeader As CSalesOrderHeader, ByVal SONumber As String)
            Dim bok As Boolean
            bok = False

            OpenConnection()
            Try
                Dim cmd As New SqlCommand
                Dim dtAdapter As SqlDataAdapter
                Dim dtSet As New DataSet

                cmd.Connection = con
                cmd.Parameters.Add("@szSONumber", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CSalesOrderHeader_GetSalesOrderHeader"
                cmd.Parameters("@szSONumber").Value = SONumber
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                    CSOHeader.szSONumber = Convert.ToString(dtSet.Tables(0).Rows(0)("SONumber"))
                    CSOHeader.szInputDate = Convert.ToString(dtSet.Tables(0).Rows(0)("InputDate"))
                    CSOHeader.szShipDate = Convert.ToString(dtSet.Tables(0).Rows(0)("ShipDate"))
                    CSOHeader.szPOCustNumber = Convert.ToString(dtSet.Tables(0).Rows(0)("POCustNumber"))
                    CSOHeader.szCustomerCode = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerCode"))
                    CSOHeader.szCustomerName = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerName"))
                    CSOHeader.szCustomerAddress1 = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerAddress1"))
                    CSOHeader.szCustomerAddress2 = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerAddress2"))
                    CSOHeader.szCustomerVLT = Convert.ToString(dtSet.Tables(0).Rows(0)("VLT"))
                    CSOHeader.szSalesCode = Convert.ToString(dtSet.Tables(0).Rows(0)("SalesCode"))
                    CSOHeader.flDiscount = Convert.ToDouble(dtSet.Tables(0).Rows(0)("Discount"))
                    CSOHeader.flAmountDiscount = Convert.ToDouble(dtSet.Tables(0).Rows(0)("AmountDiscount"))
                    CSOHeader.flPpn = Convert.ToDouble(dtSet.Tables(0).Rows(0)("Ppn"))
                    CSOHeader.flAmountPpn = Convert.ToDouble(dtSet.Tables(0).Rows(0)("AmountPpn"))
                    CSOHeader.flBruto = Convert.ToDouble(dtSet.Tables(0).Rows(0)("Bruto"))
                    CSOHeader.flNetto = Convert.ToDouble(dtSet.Tables(0).Rows(0)("Netto"))
                    CSOHeader.szUsername = Convert.ToDouble(dtSet.Tables(0).Rows(0)("Username"))
                    CSOHeader.flDownPayment = Convert.ToDouble(dtSet.Tables(0).Rows(0)("DownPayment"))
                    CSOHeader.szOrderingName = Convert.ToString(dtSet.Tables(0).Rows(0)("OrderingName"))
                End If
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetSalesOrderHeader = bok
        End Function

        Public Function SaveSalesOrderHeader(ByRef CSOHeader As CSalesOrderHeader) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szSONumber", SqlDbType.VarChar)
                cmd.Parameters.Add("@szInputDate", SqlDbType.VarChar)
                cmd.Parameters.Add("@szShipDate", SqlDbType.VarChar)
                cmd.Parameters.Add("@szPOCustNumber", SqlDbType.VarChar)
                cmd.Parameters.Add("@szCustomerCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szCustomerName", SqlDbType.VarChar)
                cmd.Parameters.Add("@szCustomerAddress1", SqlDbType.VarChar)
                cmd.Parameters.Add("@szCustomerAddress2", SqlDbType.VarChar)
                cmd.Parameters.Add("@szCustomerVLT", SqlDbType.VarChar)
                cmd.Parameters.Add("@szSalesCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@flDiscount", SqlDbType.Float)
                cmd.Parameters.Add("@flAmountDiscount", SqlDbType.Float)
                cmd.Parameters.Add("@flPpn", SqlDbType.Float)
                cmd.Parameters.Add("@flAmountPpn", SqlDbType.Float)
                cmd.Parameters.Add("@@flBruto", SqlDbType.Float)
                cmd.Parameters.Add("@flNetto", SqlDbType.Float)
                cmd.Parameters.Add("@szUsername", SqlDbType.VarChar)
                cmd.Parameters.Add("@flDownPayment", SqlDbType.Float)
                cmd.Parameters.Add("@szOrderingName", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CSalesOrderHeader_SaveSalesOrderHeader"
                cmd.Parameters("@szSONumber").Value = CSOHeader.szSONumber
                cmd.Parameters("@szInputDate").Value = CSOHeader.szInputDate
                cmd.Parameters("@szShipDate").Value = CSOHeader.szShipDate
                cmd.Parameters("@szPOCustNumber").Value = CSOHeader.szPOCustNumber
                cmd.Parameters("@szCustomerCode").Value = CSOHeader.szCustomerCode
                cmd.Parameters("@szCustomerName").Value = CSOHeader.szCustomerName
                cmd.Parameters("@szCustomerAddress1").Value = CSOHeader.szCustomerAddress1
                cmd.Parameters("@szCustomerAddress2").Value = CSOHeader.szCustomerAddress2
                cmd.Parameters("@szCustomerVLT").Value = CSOHeader.szCustomerVLT
                cmd.Parameters("@szSalesCode").Value = CSOHeader.szSalesCode
                cmd.Parameters("@flDiscount").Value = CSOHeader.flDiscount
                cmd.Parameters("@flAmountDiscount").Value = CSOHeader.flAmountDiscount
                cmd.Parameters("@flPpn").Value = CSOHeader.flPpn
                cmd.Parameters("@flAmountPpn").Value = CSOHeader.flAmountPpn
                cmd.Parameters("@flBruto").Value = CSOHeader.flBruto
                cmd.Parameters("@flNetto").Value = CSOHeader.flNetto
                cmd.Parameters("@szUsername").Value = CSOHeader.szUsername
                cmd.Parameters("@flDownPayment").Value = CSOHeader.flDownPayment
                cmd.Parameters("@szOrderingName").Value = CSOHeader.szOrderingName
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                bok = True
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            SaveSalesOrderHeader = bok
        End Function

        Public Function FindSalesOrder(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim cmd As New SqlCommand
                dataset = New DataSet
                Dim dtAdapter As SqlDataAdapter

                cmd.Connection = con
                cmd.Parameters.Add("@szFind", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CSalesOrder_FindSalesOrder"
                cmd.Parameters("@szFind").Value = szFindString
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dataset)


                If dataset.Tables(0).Rows.Count > 0 Then
                    bok = True
                End If
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
            FindSalesOrder = bok
        End Function
    End Class

    Public Class CSalesOrderDetail
        Private m_szSONumber As String = String.Empty
        Private m_intNoUrut As Int64
        Private m_szItemCode As String = String.Empty
        Private m_szItemName1 As String = String.Empty
        Private m_szItemName2 As String = String.Empty
        Private m_intUnit As Integer
        Private m_intQty As Integer
        Private m_flItemPrice As Double
        Private m_szUsername As String = String.Empty
        Private m_szInputDate As String = String.Empty
        Private m_szShipDate As String = String.Empty

        Public Property szSONumber As String
            Get
                szSONumber = m_szSONumber
            End Get
            Set(value As String)
                m_szSONumber = value
            End Set
        End Property

        Public Property szItemCode As String
            Get
                szItemCode = m_szItemCode
            End Get
            Set(value As String)
                m_szItemCode = value
            End Set
        End Property

        Public Property szItemName1 As String
            Get
                szItemName1 = m_szItemName1
            End Get
            Set(value As String)
                m_szItemName1 = value
            End Set
        End Property

        Public Property szItemName2 As String
            Get
                szItemName2 = m_szItemName2
            End Get
            Set(value As String)
                m_szItemName2 = value
            End Set
        End Property

        Public Property intUnit As Integer
            Get
                intUnit = m_intUnit
            End Get
            Set(value As Integer)
                m_intUnit = value
            End Set
        End Property

        Public Property intQty As Integer
            Get
                intQty = m_intQty
            End Get
            Set(value As Integer)
                m_intQty = value
            End Set
        End Property

        Public Property flItemPrice As Double
            Get
                flItemPrice = m_flItemPrice
            End Get
            Set(value As Double)
                m_flItemPrice = value
            End Set
        End Property

        Public Property szUsername As String
            Get
                szUsername = m_szUsername
            End Get
            Set(value As String)
                m_szUsername = value
            End Set
        End Property

        Public Property szInputDate As String
            Get
                szInputDate = m_szInputDate
            End Get
            Set(value As String)
                m_szInputDate = value
            End Set
        End Property

        Public Property szShipDate As String
            Get
                szShipDate = m_szShipDate
            End Get
            Set(value As String)
                m_szShipDate = value
            End Set
        End Property


        Public Function GetDetailSalesOrder(ByRef dtSet As DataSet, ByVal SONumber As String) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim dtAdapter As SqlDataAdapter
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szSONumber", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CSalesOrderDetail_GetDetailSalesOrderDetail"
                cmd.Parameters("@szSONumber").Value = SONumber
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                End If

            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetDetailSalesOrder = bok
        End Function

        Public Function SaveSalesOrderDetail(ByRef CSODetail As CSalesOrderDetail) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szSONumber", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemName1", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemName2", SqlDbType.VarChar)
                cmd.Parameters.Add("@intUnit", SqlDbType.Int)
                cmd.Parameters.Add("@intQty", SqlDbType.Int)
                cmd.Parameters.Add("@flItemPrice", SqlDbType.Float)
                cmd.Parameters.Add("@szUsername", SqlDbType.VarChar)
                cmd.Parameters.Add("@szInputDate", SqlDbType.VarChar)
                cmd.Parameters.Add("@szShipDate", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterB_SaveWarehouseB"
                cmd.Parameters("@szSONumber").Value = CSODetail.szSONumber
                cmd.Parameters("@szItemCode").Value = CSODetail.szItemCode
                cmd.Parameters("@szItemName1").Value = CSODetail.szItemName1
                cmd.Parameters("@szItemName2").Value = CSODetail.szItemName2
                cmd.Parameters("@intUnit").Value = CSODetail.intUnit
                cmd.Parameters("@intQty").Value = CSODetail.intQty
                cmd.Parameters("@flItemPrice").Value = CSODetail.flItemPrice
                cmd.Parameters("@szUsername").Value = CSODetail.szUsername
                cmd.Parameters("@szInputDate").Value = CSODetail.szInputDate
                cmd.Parameters("@szShipDate").Value = CSODetail.szShipDate
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                bok = True
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            SaveSalesOrderDetail = bok
        End Function

        Public Function GetSalesOrderDetail(ByRef CSODetail As CSalesOrderDetail, ByVal SONumber As String, ByVal ItemCode As String) As Boolean
            Dim bok As Boolean

            bok = False

            OpenConnection()
            Try
                Dim cmd As New SqlCommand
                Dim dtAdapter As SqlDataAdapter
                Dim dtSet As New DataSet

                cmd.Connection = con
                cmd.Parameters.Add("@szSONumber", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemCode", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CSalesOrderDetail_GetSalesOrderDetail"
                cmd.Parameters("@szSONumber").Value = SONumber
                cmd.Parameters("@szItemCode").Value = ItemCode
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                    CSODetail.szSONumber = Convert.ToString(dtSet.Tables(0).Rows(0)("SONumber"))
                    CSODetail.szItemCode = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemCode"))
                    CSODetail.szItemName1 = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName1"))
                    CSODetail.szItemName2 = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName2"))
                    CSODetail.intUnit = Convert.ToString(dtSet.Tables(0).Rows(0)("Unit"))
                    CSODetail.intQty = Convert.ToString(dtSet.Tables(0).Rows(0)("Qty"))
                    CSODetail.flItemPrice = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemPrice"))
                    CSODetail.szUsername = Convert.ToString(dtSet.Tables(0).Rows(0)("Username"))
                    CSODetail.szInputDate = Convert.ToString(dtSet.Tables(0).Rows(0)("InputDate"))
                    CSODetail.szShipDate = Convert.ToString(dtSet.Tables(0).Rows(0)("ShipDate"))
                End If
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetSalesOrderDetail = bok
        End Function


    End Class
End Namespace



