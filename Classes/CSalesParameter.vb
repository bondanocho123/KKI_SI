Imports System.Data
Imports System.Data.SqlClient

Public Class CSalesParameter
    Private m_szSalesId As String = String.Empty
    Private m_szSalesName As String = String.Empty
    Private m_szSalesAddress1 As String = String.Empty
    Private m_szSalesAddress2 As String = String.Empty
    Private m_szSalesTelp As String = String.Empty
    Private m_szSalesKtp As String = String.Empty
    Private m_intBDeleted As Integer


    Public Property szSales_Id As String
        Get
            szSales_Id = m_szSalesId
        End Get
        Set(value As String)
            m_szSalesId = value
        End Set
    End Property

    Public Property szSales_Name As String
        Get
            szSales_Name = m_szSalesName
        End Get
        Set(value As String)
            m_szSalesName = value
        End Set
    End Property

    Public Property szSales_Address1 As String
        Get
            szSales_Address1 = m_szSalesAddress1
        End Get
        Set(value As String)
            m_szSalesAddress1 = value
        End Set
    End Property

    Public Property szSales_Address2 As String
        Get
            szSales_Address2 = m_szSalesAddress2
        End Get
        Set(value As String)
            m_szSalesAddress2 = value
        End Set
    End Property

    Public Property szSales_Telp As String
        Get
            szSales_Telp = m_szSalesTelp
        End Get
        Set(value As String)
            m_szSalesTelp = value
        End Set
    End Property

    Public Property szSales_Ktp As String
        Get
            szSales_Ktp = m_szSalesKtp
        End Get
        Set(value As String)
            m_szSalesKtp = value
        End Set
    End Property

    Public Property intBDeleted As Integer
        Get
            intBDeleted = m_intBDeleted
        End Get
        Set(value As Integer)
            m_intBDeleted = value
        End Set
    End Property


    Public Overloads Function GetSalesParameter(ByRef CSales As CSalesParameter, ByVal szSalesId As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szSales_Id", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CSalesParameter_GetSalesParameter"
            cmd.Parameters("@szSales_Id").Value = szSalesId
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CSales.szSales_Id = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Id"))
                CSales.szSales_Name = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Name"))
                CSales.szSales_Address1 = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Address1"))
                CSales.szSales_Address2 = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Address2"))
                CSales.szSales_Telp = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Telp"))
                CSales.szSales_Ktp = Convert.ToString(dtSet.Tables(0).Rows(0)("Sales_Ktp"))

                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CSales.intBDeleted = 0
                Else
                    CSales.intBDeleted = 1
                End If


            End If


        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try

        GetSalesParameter = bok

    End Function

    Public Overloads Function GetSalesParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CSalesParameter_GetAllSalesParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetSalesParameter = bok
    End Function

    Public Function SaveSalesParameter(ByRef CSales As CSalesParameter) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szSales_ID", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSales_Name", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSales_Address1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSales_Address2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSales_Telp", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSales_Ktp", SqlDbType.VarChar)
            cmd.Parameters.Add("@intBdeleted", SqlDbType.VarChar)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CSalesParameter_SaveSalesParameter"
            cmd.Parameters("@szSales_Id").Value = CSales.szSales_Id
            cmd.Parameters("@szSales_Name").Value = CSales.szSales_Name
            cmd.Parameters("@szSales_Address1").Value = CSales.szSales_Address1
            cmd.Parameters("@szSales_Address2").Value = CSales.szSales_Address2
            cmd.Parameters("@szSales_Telp").Value = CSales.szSales_Telp
            cmd.Parameters("@szSales_Ktp").Value = CSales.szSales_Ktp
            cmd.Parameters("@intBdeleted").Value = CSales.intBDeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        SaveSalesParameter = bok
    End Function

    Public Function FindSalesParameter(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
            cmd.CommandText = "CSalesParameteR_FindSalesParameter"
            cmd.Parameters("@szFind").Value = szFindString
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dataset)

            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        FindSalesParameter = bok
    End Function


End Class
