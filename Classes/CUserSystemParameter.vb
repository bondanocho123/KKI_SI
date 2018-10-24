Imports System.Data
Imports System.Data.SqlClient

Public Class CUserSystemParameter
    Private m_UserId As String = String.Empty
    Private m_UserName As String = String.Empty
    Private m_Password As String = String.Empty

    Public Property szUserId As String
        Get
            szUserId = m_UserId
        End Get
        Set(value As String)
            m_UserId = value
        End Set
    End Property

    Public Property szUserName As String
        Get
            szUserName = m_UserName
        End Get
        Set(value As String)
            m_UserName = value
        End Set
    End Property

    Public Property szPassword As String
        Get
            szPassword = m_Password
        End Get
        Set(value As String)
            m_Password = value
        End Set
    End Property

    Public Function GetLogUserSystemParameter(ByRef CUSysPar As CUserSystemParameter, ByVal UserId As String, ByVal Password As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.Parameters.Add("@szUserName", SqlDbType.VarChar)
            cmd.Parameters.Add("@szPasswords", SqlDbType.VarChar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CUserSystemParameter_GetLogUserSystemParameter"
            cmd.Parameters("@szUserName").Value = UserId
            cmd.Parameters("@szPasswords").Value = Password
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        GetLogUserSystemParameter = bok
    End Function
End Class
