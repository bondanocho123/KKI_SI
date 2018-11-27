Imports System.Data
Imports System.Data.SqlClient

Public Class CItemParameter
    Private m_szItemCode As String = String.Empty
    Private m_szItemName1 As String = String.Empty
    Private m_szItemName2 As String = String.Empty
    Private m_szItemName3 As String = String.Empty
    Private m_szSTN As String = String.Empty
    Private m_szSTN2 As String = String.Empty
    Private m_dblISI As Double
    Private m_dblItemPrice As Double
    Private m_intBDeleted As Integer

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

    Public Property szItemName3 As String
        Get
            szItemName3 = m_szItemName3
        End Get
        Set(value As String)
            m_szItemName3 = value
        End Set
    End Property

    Public Property szSTN As String
        Get
            szSTN = m_szSTN
        End Get
        Set(value As String)
            m_szSTN = value
        End Set
    End Property

    Public Property szSTN2 As String
        Get
            szSTN2 = m_szSTN2
        End Get
        Set(value As String)
            m_szSTN2 = value
        End Set
    End Property

    Public Property dblISI As Double
        Get
            dblISI = m_dblISI
        End Get
        Set(value As Double)
            m_dblISI = value
        End Set
    End Property

    Public Property dblItemPrice As Double
        Get
            dblItemPrice = m_dblItemPrice
        End Get
        Set(value As Double)
            m_dblItemPrice = value
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

    Public Overloads Function GetItemParameter(ByRef CItem As CItemParameter, ByVal ItemCode As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szItemCode", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CItemParameter_GetItemParameter"
            cmd.Parameters("@szItemCode").Value = ItemCode
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CItem.szItemCode = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemCode"))
                CItem.szItemName1 = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName1"))
                CItem.szItemName2 = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName2"))
                CItem.szItemName3 = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName3"))
                CItem.szSTN = Convert.ToString(dtSet.Tables(0).Rows(0)("STN"))
                CItem.szSTN2 = Convert.ToString(dtSet.Tables(0).Rows(0)("STN2"))
                CItem.dblISI = Convert.ToString(dtSet.Tables(0).Rows(0)("ISI"))
                CItem.dblItemPrice = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemPrice"))

                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CItem.intBDeleted = 0
                Else
                    CItem.intBDeleted = 1
                End If
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetItemParameter = bok
    End Function

    Public Overloads Function GetItemParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean
        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CItemParameter_GetAllItemParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetItemParameter = bok
    End Function

    Public Function SaveItemParameter(ByRef CItem As CItemParameter) As Boolean
        Dim bok As Boolean
        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szItemCode", SqlDbType.VarChar)
            cmd.Parameters.Add("@szItemName1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szItemName2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szItemName3", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSTN", SqlDbType.VarChar)
            cmd.Parameters.Add("@szSTN2", SqlDbType.VarChar)
            cmd.Parameters.Add("@dblISI", SqlDbType.Float)
            cmd.Parameters.Add("@dblItemPrice", SqlDbType.Float)
            cmd.Parameters.Add("@intBDeleted", SqlDbType.Bit)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CItemParameter_SaveItemParameter"
            cmd.Parameters("@szItemCode").Value = CItem.szItemCode
            cmd.Parameters("@szItemName1").Value = CItem.szItemName1
            cmd.Parameters("@szItemName2").Value = CItem.szItemName2
            cmd.Parameters("@szItemName3").Value = CItem.szItemName3
            cmd.Parameters("@szSTN").Value = CItem.szSTN
            cmd.Parameters("@szSTN2").Value = CItem.szSTN2
            cmd.Parameters("@dblISI").Value = CItem.dblISI
            cmd.Parameters("@dblItemPrice").Value = CItem.dblItemPrice
            cmd.Parameters("@intBDeleted").Value = CItem.intBDeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        SaveItemParameter = bok
    End Function

    Public Overloads Function FindItemParameter(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
            cmd.CommandText = "CItemParameter_FindItemParameter"
            cmd.Parameters("@szFind").Value = szFindString
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dataset)


            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        FindItemParameter = bok
    End Function
End Class
