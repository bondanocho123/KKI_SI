Imports System.Data
Imports System.Data.SqlClient

Public Class CCustomerParameter
    Private m_szCustomerCode As String = String.Empty
    Private m_szCustomerName As String = String.Empty
    Private m_szCustomerAddress1 As String = String.Empty
    Private m_szCustomerAddress2 As String = String.Empty
    Private m_szCustomerTelp As String = String.Empty
    Private m_szCustomerNPWP As String = String.Empty
    Private m_intCustomerPKP As String = String.Empty
    Private m_szCustomerSales As String = String.Empty
    Private m_szCustomerVLT As String = String.Empty
    Private m_szTglInput As String = String.Empty
    Private m_szUsername As String = String.Empty
    Private m_intBDeleted As Integer

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

    Public Property szCustomerTelp As String
        Get
            szCustomerTelp = m_szCustomerTelp
        End Get
        Set(value As String)
            m_szCustomerTelp = value
        End Set
    End Property

    Public Property szCustomerNPWP As String
        Get
            szCustomerNPWP = m_szCustomerNPWP
        End Get
        Set(value As String)
            m_szCustomerNPWP = value
        End Set
    End Property

    Public Property intCustomerPKP As Integer
        Get
            intCustomerPKP = m_intCustomerPKP
        End Get
        Set(value As Integer)
            m_intCustomerPKP = value
        End Set
    End Property

    Public Property szCustomerSales As String
        Get
            szCustomerSales = m_szCustomerSales
        End Get
        Set(value As String)
            m_szCustomerSales = value
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

    Public Property szTglInput As String
        Get
            szTglInput = m_szTglInput
        End Get
        Set(value As String)
            m_szTglInput = value
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

    Public Property intBDeleted As Integer
        Get
            intBDeleted = m_intBDeleted
        End Get
        Set(value As Integer)
            m_intBDeleted = value
        End Set
    End Property


    Public Overloads Function GetCustomerParameter(ByRef CCustomer As CCustomerParameter, ByVal CustomerCode As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szCustomerCode", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CCustomerParameter_GetCustomerParameter"
            cmd.Parameters("@szCustomerCode").Value = CustomerCode
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CCustomer.szCustomerCode = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerCode"))
                CCustomer.szCustomerName = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerName"))
                CCustomer.szCustomerAddress1 = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerAddress1"))
                CCustomer.szCustomerAddress2 = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerAddress2"))
                CCustomer.szCustomerTelp = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerTelp"))
                CCustomer.szCustomerNPWP = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerNPWP"))
                CCustomer.intCustomerPKP = Convert.ToInt16(dtSet.Tables(0).Rows(0)("CustomerPKP"))
                CCustomer.szCustomerSales = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerSales"))
                CCustomer.szCustomerVLT = Convert.ToString(dtSet.Tables(0).Rows(0)("CustomerVLT"))

                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CCustomer.intBDeleted = 0
                Else
                    CCustomer.intBDeleted = 1
                End If
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetCustomerParameter = bok
    End Function

    Public Overloads Function GetCustomerParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CCustomerParameter_GetAllCustomerParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetCustomerParameter = bok
    End Function

    Public Function SaveCustomerparameter(ByRef CCustomer As CCustomerParameter) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szCustomerCode", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerName", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerAddress1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerAddress2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerTelp", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerNPWP", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerPKP", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerSales", SqlDbType.VarChar)
            cmd.Parameters.Add("@szCustomerVLT", SqlDbType.VarChar)
            cmd.Parameters.Add("@szTglInput", SqlDbType.VarChar)
            cmd.Parameters.Add("@szUsername", SqlDbType.VarChar)
            cmd.Parameters.Add("@intBDeleted", SqlDbType.Int)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CCustomerParameter_SaveCustomerParameter"
            cmd.Parameters("@szCustomerCode").Value = CCustomer.szCustomerCode
            cmd.Parameters("@szCustomerName").Value = CCustomer.szCustomerName
            cmd.Parameters("@szCustomerAddress1").Value = CCustomer.szCustomerAddress1
            cmd.Parameters("@szCustomerAddress2").Value = CCustomer.szCustomerAddress2
            cmd.Parameters("@szCustomerTelp").Value = CCustomer.szCustomerTelp
            cmd.Parameters("@szCustomerNPWP").Value = CCustomer.szCustomerNPWP
            cmd.Parameters("@szCustomerPKP").Value = CCustomer.intCustomerPKP
            cmd.Parameters("@szCustomerSales").Value = CCustomer.szCustomerSales
            cmd.Parameters("@szCustomerVLT").Value = CCustomer.szCustomerVLT
            cmd.Parameters("@szTglInput").Value = CCustomer.szTglInput
            cmd.Parameters("@szUsername").Value = CCustomer.szUsername
            cmd.Parameters("@intBDeleted").Value = CCustomer.intBDeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        SaveCustomerparameter = bok
    End Function

    Public Function FindCustomerParameter(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
            cmd.CommandText = "CCustomerParameter_FindCustomerParameter"
            cmd.Parameters("@szFind").Value = szFindString
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dataset)


            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        FindCustomerParameter = bok
    End Function


End Class
