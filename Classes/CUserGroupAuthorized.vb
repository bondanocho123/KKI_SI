Imports System.Data
Imports System.Data.SqlClient

Public Class CUserGroupAuthorized
    Private m_UserGroupId As String = String.Empty
    Private m_UserGroupAuthorized As String = String.Empty

    Public Property szUserGroupId As String
        Get
            szUserGroupId = m_UserGroupId
        End Get
        Set(value As String)
            m_UserGroupId = value
        End Set
    End Property

    Public Property szUserGroupAuthorized As String
        Get
            szUserGroupAuthorized = m_UserGroupAuthorized
        End Get
        Set(value As String)
            m_UserGroupAuthorized = value
        End Set
    End Property

    Public Function GetUserGroupAuthorized(ByVal szAuthorized As String, ByVal szUserGroupId As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szAuthorized", SqlDbType.VarChar)
            cmd.Parameters.Add("@szUserGroupId", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserGroupAuthorized_GetUserGroupAuthorized"
            cmd.Parameters("@szAuthorized").Value = szAuthorized
            cmd.Parameters("@szUserGroupId").Value = szUserGroupId
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        GetUserGroupAuthorized = bok
    End Function
End Class
