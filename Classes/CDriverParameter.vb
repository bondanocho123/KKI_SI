Imports System.Data
Imports System.Data.SqlClient

Public Class CDriverParameter
    Private m_szDriverCode As String = String.Empty
    Private m_szDriverName As String = String.Empty
    Private m_szDriverAddress1 As String = String.Empty
    Private m_szDriverAddress2 As String = String.Empty
    Private m_szDriverTelp As String = String.Empty
    Private m_szDriverHp As String = String.Empty
    Private m_szDriverNoPol As String = String.Empty
    Private m_intBDeleted As String = String.Empty

    Public Property szDriverCode As String
        Get
            szDriverCode = m_szDriverCode
        End Get
        Set(value As String)
            m_szDriverCode = value
        End Set
    End Property

    Public Property szDriverName As String
        Get
            szDriverName = m_szDriverName
        End Get
        Set(value As String)
            m_szDriverName = value
        End Set
    End Property

    Public Property szDriverAddress1 As String
        Get
            szDriverAddress1 = m_szDriverAddress1
        End Get
        Set(value As String)
            m_szDriverAddress1 = value
        End Set
    End Property

    Public Property szDriverAddress2 As String
        Get
            szDriverAddress2 = m_szDriverAddress2
        End Get
        Set(value As String)
            m_szDriverAddress2 = value
        End Set
    End Property

    Public Property szDriverTelp As String
        Get
            szDriverTelp = m_szDriverTelp
        End Get
        Set(value As String)
            m_szDriverTelp = value
        End Set
    End Property

    Public Property szDriverHp As String
        Get
            szDriverHp = m_szDriverHp
        End Get
        Set(value As String)
            m_szDriverHp = value
        End Set
    End Property

    Public Property szDriverNoPol As String
        Get
            szDriverNoPol = m_szDriverNoPol
        End Get
        Set(value As String)
            m_szDriverNoPol = value
        End Set
    End Property

    Public Property intBDeleted As String
        Get
            intBDeleted = m_intBDeleted
        End Get
        Set(value As String)
            m_intBDeleted = value
        End Set
    End Property

    Public Overloads Function GetDriverParameter(ByRef CDriver As CDriverParameter, ByVal szDriverCode As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szDriverCode", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CDriverParameter_GetDriverParameter"
            cmd.Parameters("@szDriverCode").Value = szDriverCode
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CDriver.szDriverCode = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverCode"))
                CDriver.szDriverName = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverName"))
                CDriver.szDriverAddress1 = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverAddress1"))
                CDriver.szDriverAddress2 = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverAddress2"))
                CDriver.szDriverTelp = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverTelp"))
                CDriver.szDriverHp = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverHp"))
                CDriver.szDriverNoPol = Convert.ToString(dtSet.Tables(0).Rows(0)("DriverNoPol"))
                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CDriver.intBDeleted = 0
                Else
                    CDriver.intBDeleted = 1
                End If
            End If

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetDriverParameter = bok
    End Function

    Public Overloads Function GetDriverParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CDriver_GetAllDriverParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetDriverParameter = bok
    End Function


    Public Function SaveDriverParameter(ByRef CDriver As CDriverParameter) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szDriverCode", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverName", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverAddress1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverAddress2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverTelp", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverHp", SqlDbType.VarChar)
            cmd.Parameters.Add("@szDriverNoPol", SqlDbType.VarChar)
            cmd.Parameters.Add("@intBdeleted", SqlDbType.Int)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CDriverParameter_SaveDriverParameter"
            cmd.Parameters("@szDriverCode").Value = CDriver.szDriverCode
            cmd.Parameters("@szDriverName").Value = CDriver.szDriverName
            cmd.Parameters("@szDriverAddress1").Value = CDriver.m_szDriverAddress1
            cmd.Parameters("@szDriverAddress2").Value = CDriver.szDriverAddress2
            cmd.Parameters("@szDriverTelp").Value = CDriver.szDriverTelp
            cmd.Parameters("@szDriverHp").Value = CDriver.szDriverHp
            cmd.Parameters("@szDriverNoPol").Value = CDriver.szDriverNoPol
            cmd.Parameters("@intBdeleted").Value = CDriver.intBDeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        SaveDriverParameter = bok
    End Function

    Public Function FindDriverParameter(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
            cmd.CommandText = "CDriverParameter_FindDriverParameter"
            cmd.Parameters("@szFind").Value = szFindString
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dataset)

            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        FindDriverParameter = bok
    End Function
End Class
