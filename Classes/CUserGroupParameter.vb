Imports System.Data
Imports System.Data.SqlClient

Public Class CUserGroupParameter
    Private m_UserGroupId As String = String.Empty
    Private m_UserGroupName As String = String.Empty
    Private m_bDeleted As Integer

    Public Property szUserGroupId As String
        Get
            szUserGroupId = m_UserGroupId
        End Get
        Set(value As String)
            m_UserGroupId = value
        End Set
    End Property

    Public Property szUserGroupName As String
        Get
            szUserGroupName = m_UserGroupName
        End Get
        Set(value As String)
            m_UserGroupName = value
        End Set
    End Property

    Public Property intBDeleted As Integer
        Get
            intBDeleted = m_bDeleted
        End Get
        Set(value As Integer)
            m_bDeleted = value
        End Set
    End Property

    Public Overloads Function GetUserGroupParameter(ByRef CUserGroup As CUserGroupParameter, ByVal UserGroupId As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szUserGroup_Id", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserGroupParameter_GetUserGroupParameter"
            cmd.Parameters("@szUserGroup_Id").Value = szUserGroupId
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CUserGroup.szUserGroupId = Convert.ToString(dtSet.Tables(0).Rows(0)("UserGroup_Id"))
                CUserGroup.szUserGroupName = Convert.ToString(dtSet.Tables(0).Rows(0)("UserGroup_Name"))
                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CUserGroup.intBDeleted = 0
                Else
                    CUserGroup.intBDeleted = 1
                End If

            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetUserGroupParameter = bok
    End Function

    Public Overloads Function GetUserGroupParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserGroupParameter_GetAllUserGroupParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try

        GetUserGroupParameter = bok
    End Function

    Public Function SaveUserGroupParameter(ByRef CUserGroup As CUserGroupParameter) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szUserGroup_Id", SqlDbType.VarChar)
            cmd.Parameters.Add("@szUserGroup_Name", SqlDbType.VarChar)
            cmd.Parameters.Add("intbDeleted", SqlDbType.Int)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserGroupParameter_SaveUserGroupParameter"
            cmd.Parameters("@szUserGroup_Id").Value = CUserGroup.szUserGroupId
            cmd.Parameters("@szUserGroup_Name").Value = CUserGroup.szUserGroupName
            cmd.Parameters("@intbDeleted").Value = CUserGroup.intBDeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        SaveUserGroupParameter = bok
    End Function


    Public Function FindUserGroupParameter(ByRef dtSet As DataSet, ByRef szFind As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            dtSet = New DataSet
            Dim dtAdapter As SqlDataAdapter

            cmd.Connection = con
            cmd.Parameters.Add("@szFind", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserGroupParameter_FindUserGroupParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)
            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try

        FindUserGroupParameter = bok
    End Function


End Class
