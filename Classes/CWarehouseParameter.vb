Imports System.Data
Imports System.Data.SqlClient

Namespace Warehouse
    Public Class CWarehouseParameterA
        Private m_szWarehouseCode As String = String.Empty
        Private m_szWarehouseName As String = String.Empty
        Private m_intBDeleted As Integer

        Public Property szWarehouseCode As String
            Get
                szWarehouseCode = m_szWarehouseCode
            End Get
            Set(value As String)
                m_szWarehouseCode = value
            End Set
        End Property

        Public Property szWarehouseName As String
            Get
                szWarehouseName = m_szWarehouseName
            End Get
            Set(value As String)
                m_szWarehouseName = value
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

        Public Function GetWarehouseParameterA(ByRef CWarehouseA As CWarehouseParameterA, ByVal WarehouseCode As String) As Boolean
            Dim bok As Boolean

            bok = False

            OpenConnection()
            Try
                Dim cmd As New SqlCommand
                Dim dtAdapter As SqlDataAdapter
                Dim dtSet As New DataSet

                cmd.Connection = con
                cmd.Parameters.Add("@szWarehouseCode", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterA_GetWarehouseA"
                cmd.Parameters("@szWarehouseCode").Value = WarehouseCode
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                    CWarehouseA.szWarehouseCode = Convert.ToString(dtSet.Tables(0).Rows(0)("WarehouseCode"))
                    CWarehouseA.szWarehouseName = Convert.ToString(dtSet.Tables(0).Rows(0)("WarehouseName"))

                    If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                        CWarehouseA.intBDeleted = 0
                    Else
                        CWarehouseA.intBDeleted = 1
                    End If
                End If
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetWarehouseParameterA = bok
        End Function

        Public Function SaveWarehouseA(ByRef CWarehouseA As CWarehouseParameterA) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szWarehouseCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szWarehouseName", SqlDbType.VarChar)
                cmd.Parameters.Add("@intBDeleted", SqlDbType.Bit)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterA_SaveWarehouseA"
                cmd.Parameters("@szWarehouseCode").Value = CWarehouseA.szWarehouseCode
                cmd.Parameters("@szWarehouseName").Value = CWarehouseA.szWarehouseName
                cmd.Parameters("@intBDeleted").Value = CWarehouseA.intBDeleted
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                bok = True
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            SaveWarehouseA = bok
        End Function

        Public Function FindWarehouse(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
                cmd.CommandText = "CWarehouseParameter_FindWarehouse"
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
            FindWarehouse = bok
        End Function
    End Class

    Public Class CWarehouseParameterB
        Private m_szWarehouseCode As String = String.Empty
        Private m_szRackCode As String = String.Empty
        Private m_szItemCode As String = String.Empty
        Private m_szItemName As String = String.Empty

        Public Property szWarehouseCode As String
            Get
                szWarehouseCode = m_szWarehouseCode
            End Get
            Set(value As String)
                m_szWarehouseCode = value
            End Set
        End Property

        Public Property szRackCode As String
            Get
                szRackCode = m_szRackCode
            End Get
            Set(value As String)
                m_szRackCode = value
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

        Public Property szItemName As String
            Get
                szItemName = m_szItemName
            End Get
            Set(value As String)
                m_szItemName = value
            End Set
        End Property

        Public Function GetDetailWarehouse(ByRef dtSet As DataSet, ByVal WarehouseCode As String) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim dtAdapter As SqlDataAdapter
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szWarehouseCode", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterB_GetDetailWarehouse"
                cmd.Parameters("@szWarehouseCode").Value = WarehouseCode
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                End If

            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetDetailWarehouse = bok
        End Function

        Public Function SaveWarehouseB(ByRef CWarehouseB As CWarehouseParameterB) As Boolean
            Dim bok As Boolean

            bok = False
            OpenConnection()
            Try
                Dim cmd As New SqlCommand

                cmd.Connection = con
                cmd.Parameters.Add("@szWarehouseCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szRackCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szItemName", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterB_SaveWarehouseB"
                cmd.Parameters("@szWarehouseCode").Value = CWarehouseB.szWarehouseCode
                cmd.Parameters("@szRackCode").Value = CWarehouseB.szRackCode
                cmd.Parameters("@szItemCode").Value = CWarehouseB.szItemCode
                cmd.Parameters("@szItemName").Value = CWarehouseB.szItemName
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                bok = True
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            SaveWarehouseB = bok
        End Function

        Public Function GetWarehouseB(ByRef CWarehouseB As CWarehouseParameterB, ByVal RackCode As String, ByVal WarehouseCode As String) As Boolean
            Dim bok As Boolean

            bok = False

            OpenConnection()
            Try
                Dim cmd As New SqlCommand
                Dim dtAdapter As SqlDataAdapter
                Dim dtSet As New DataSet

                cmd.Connection = con
                cmd.Parameters.Add("@szRackCode", SqlDbType.VarChar)
                cmd.Parameters.Add("@szWarehouseCode", SqlDbType.VarChar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "CWarehouseParameterB_GetWarehouseB"
                cmd.Parameters("@szRackCode").Value = RackCode
                cmd.Parameters("@szWarehouseCode").Value = WarehouseCode
                dtAdapter = New SqlDataAdapter(cmd)
                dtAdapter.Fill(dtSet)

                If dtSet.Tables(0).Rows.Count > 0 Then
                    bok = True
                    CWarehouseB.szRackCode = Convert.ToString(dtSet.Tables(0).Rows(0)("RackCode"))
                    CWarehouseB.szItemCode = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemCode"))
                    CWarehouseB.szItemName = Convert.ToString(dtSet.Tables(0).Rows(0)("ItemName"))
                End If
            Catch ex As Exception
                MsgBoxShow(ex.Message, 0)
            End Try
            GetWarehouseB = bok
        End Function
    End Class



End Namespace

