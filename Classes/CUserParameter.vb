Imports System.Data
Imports System.Data.SqlClient

Public Class CUserParameter
    Private m_UserId As String = String.Empty
    Private m_Fullname As String = String.Empty
    Private m_Address1 As String = String.Empty
    Private m_Address2 As String = String.Empty
    Private m_Email As String = String.Empty
    Private m_PhoneNumber1 As String = String.Empty
    Private m_PhoneNumber2 As String = String.Empty
    Private m_UserGroupId As String = String.Empty
    Private m_BDeleted As Integer = 0

    Public Property szUserId As String
        Get
            szUserId = m_UserId
        End Get
        Set(value As String)
            m_UserId = value
        End Set
    End Property

    Public Property szFullname As String
        Get
            szFullname = m_Fullname
        End Get
        Set(value As String)
            m_Fullname = value
        End Set
    End Property

    Public Property szAddress1 As String
        Get
            szAddress1 = m_Address1
        End Get
        Set(value As String)
            m_Address1 = value
        End Set
    End Property

    Public Property szAddress2 As String
        Get
            szAddress2 = m_Address2
        End Get
        Set(value As String)
            m_Address2 = value
        End Set
    End Property

    Public Property szEmail As String
        Get
            szEmail = m_Email
        End Get
        Set(value As String)
            m_Email = value
        End Set
    End Property

    Public Property szPhoneNumber1 As String
        Get
            szPhoneNumber1 = m_PhoneNumber1
        End Get
        Set(value As String)
            m_PhoneNumber1 = value
        End Set
    End Property

    Public Property szPhoneNumber2 As String
        Get
            szPhoneNumber2 = m_PhoneNumber2
        End Get
        Set(value As String)
            m_PhoneNumber2 = value
        End Set
    End Property
    Public Property szUserGroup_Id As String
        Get
            szUserGroup_Id = m_UserGroupId
        End Get
        Set(value As String)
            m_UserGroupId = value
        End Set
    End Property

    Public Property intBdeleted As Integer
        Get
            intBdeleted = m_BDeleted
        End Get
        Set(value As Integer)
            m_BDeleted = value
        End Set
    End Property

    Public Overloads Function GetUserParameter(ByRef CUser As CUserParameter, ByVal szUserId As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As New SqlDataAdapter
            Dim dtSet As New DataSet
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szUser_Id", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserParameter_GetUserParameter"
            cmd.Parameters("@szUser_Id").Value = szUserId
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
                CUser.szUserId = Convert.ToString(dtSet.Tables(0).Rows(0)("User_Id"))
                CUser.szFullname = Convert.ToString(dtSet.Tables(0).Rows(0)("Fullname"))
                CUser.szAddress1 = Convert.ToString(dtSet.Tables(0).Rows(0)("Address1"))
                CUser.szAddress2 = Convert.ToString(dtSet.Tables(0).Rows(0)("Address2"))
                CUser.szEmail = Convert.ToString(dtSet.Tables(0).Rows(0)("Email"))
                CUser.szPhoneNumber1 = Convert.ToString(dtSet.Tables(0).Rows(0)("PhoneNumber1"))
                CUser.szPhoneNumber2 = Convert.ToString(dtSet.Tables(0).Rows(0)("PhoneNumber2"))
                CUser.szUserGroup_Id = Convert.ToString(dtSet.Tables(0).Rows(0)("UserGroup_Id"))
                If Convert.ToString(dtSet.Tables(0).Rows(0)("bDeleted")) = False Then
                    CUser.intBdeleted = 0
                Else
                    CUser.intBdeleted = 1
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GetUserParameter = bok
    End Function

    Public Overloads Function GetUserParameter(ByRef dtSet As DataSet) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            dtSet = New DataSet
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserParameter_GetAllUserParameter"
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            bok = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GetUserParameter = bok
    End Function

    Public Function SaveUserParameter(ByRef CUser As CUserParameter) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.Parameters.Add("@szUser_Id", SqlDbType.VarChar)
            cmd.Parameters.Add("@szFullName", SqlDbType.VarChar)
            cmd.Parameters.Add("@szAddress1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szAddress2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szEmail", SqlDbType.VarChar)
            cmd.Parameters.Add("@szPhoneNumber1", SqlDbType.VarChar)
            cmd.Parameters.Add("@szPhoneNumber2", SqlDbType.VarChar)
            cmd.Parameters.Add("@szUserGroup_Id", SqlDbType.VarChar)
            cmd.Parameters.Add("@intBdeleted", SqlDbType.Int)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserParameter_SaveUserParameter"
            cmd.Parameters("@szUser_Id").Value = CUser.szUserId
            cmd.Parameters("@szFullName").Value = CUser.szFullname
            cmd.Parameters("@szAddress1").Value = CUser.szAddress1
            cmd.Parameters("@szAddress2").Value = CUser.szAddress2
            cmd.Parameters("@szEmail").Value = CUser.szEmail
            cmd.Parameters("@szPhoneNumber1").Value = CUser.szPhoneNumber1
            cmd.Parameters("@szPhoneNumber2").Value = CUser.szPhoneNumber2
            cmd.Parameters("@szUserGroup_Id").Value = CUser.szUserGroup_Id
            cmd.Parameters("@intBdeleted").Value = CUser.intBdeleted
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            bok = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SaveUserParameter = bok
    End Function

    Public Function FindUserParameter(ByRef dataset As DataSet, ByVal szFindString As String) As Boolean
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
            cmd.CommandText = "CUserParameter_FindUserParameter"
            cmd.Parameters("@szFind").Value = szFindString
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dataset)

            If dataset.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        FindUserParameter = bok
    End Function

End Class
