Imports System.Data
Imports System.Data.SqlClient

Module GlobalModule

    Public con As SqlConnection = Nothing
    Public cmd As SqlCommand = Nothing
    Public dtAdapter As SqlDataAdapter = Nothing
    Public dtSet As DataSet = Nothing
    Public g_szUsername As String = String.Empty
    Public g_szUserId As String = String.Empty
    Public g_szError As String = String.Empty
    Public bExit As Boolean = False

    Public Sub OpenConnection()
        Try
            Dim szConnectionString As String = "Data Source=DESKTOP-P1VAVQG;Initial Catalog=SI;Integrated Security=True"

            con = New SqlConnection(szConnectionString)
            con.Open()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function msgQuestion(ByVal MsgStr As String, ByVal captionType As String) As Boolean
        Dim res As DialogResult
        Dim bok As Boolean

        res = MessageBox.Show(MsgStr, captionType, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Select Case res
            Case vbOK
                bok = True
            Case vbCancel
                bok = False
        End Select

        msgQuestion = bok
    End Function


    Public Sub ShowForm(ByRef objFormName As Form, ByVal szAuthorizedForm As String, ByRef objMain As Form)
        Dim CUser As New CUserParameter
        Dim CUserGRoup As New CUserGroupParameter
        Dim CUserGroupAuthor As New CUserGroupAuthorized
        Dim frmname() As String = szAuthorizedForm.Split(" ")

        If CUser.GetUserParameter(CUser, g_szUserId) Then
            If CUserGroupAuthor.GetUserGroupAuthorized(szAuthorizedForm, CUser.szUserGroup_Id) Then
                objFormName.MdiParent = objMain
                objFormName.Text = "Form " & frmname(frmname.Count - 1)

                objFormName.Show()
            Else
                MessageBox.Show("You are not authorized : " & vbCrLf & "Check your contact administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        
    End Sub

    Public Sub MsgBoxShow(ByVal szMsg As String, ByVal Type As Integer)
        Select Case Type
            Case 0 'case error message
                MessageBox.Show(szMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1 'case information
                MessageBox.Show(szMsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select

    End Sub

    Public Function g_toolTip(ByVal Icon As ToolTipIcon, ByVal szTitle As String, ByVal MsgStr As String, ByVal obj As Object) As Boolean
        Dim TTmenu As New ToolTip

        g_toolTip = True
        TTmenu.IsBalloon = True
        TTmenu.ToolTipIcon = Icon
        TTmenu.ToolTipTitle = szTitle

        TTmenu.SetToolTip(obj, MsgStr)
        TTmenu.Show(MsgStr, obj, 1500)
    End Function

    Public Function replaceQuote(ByVal szChar As String) As String
        Dim resChar As String = String.Empty
        Dim arrChar(szChar.Count - 1) As String

        For i As Integer = 0 To szChar.Trim.Count - 1
            arrChar(i) = Mid(szChar, i + 1, 1)
            If arrChar(i) = "'" Then
                arrChar(i) = "`"
            End If
            resChar += arrChar(i)
        Next
        replaceQuote = resChar
    End Function

    Public Function ConvertToDateTime(ByVal szDateTime As String) As String
        Dim resDateTime As String = String.Empty

        resDateTime = Convert.ToDateTime(szDateTime).ToString("yyyy-MM-dd hh:mm:ss")

        ConvertToDateTime = resDateTime

    End Function

    Public Function emailFieldChecking(ByVal email As String) As Boolean
        Dim bok As Boolean
        Dim arrEmail(email.Trim.Length - 1) As String
        bok = False
        For i As Integer = 0 To email.Trim.Length - 1
            arrEmail(i) = Mid(email, i + 1, 1)

            If arrEmail(i) = "@" Then
                bok = True
                GoTo out
            End If
        Next

out:
        emailFieldChecking = bok
    End Function

    Public Function g_GetDataset(ByVal tableName As String, ByVal Querys As String) As DataSet
        Dim dtSet As New DataSet
        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand

            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Querys
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        g_GetDataset = dtSet
    End Function

    Public Function g_getValueField(ByVal tableName As String, ByVal whereQuerys As String, ByVal fieldName As String) As String
        Dim result As String = String.Empty

        OpenConnection()
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim cmd As New SqlCommand
            Dim dtSet As New DataSet
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT " & fieldName & " FROM " & tableName & " WHERE " & whereQuerys
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                result = Convert.ToString(dtSet.Tables(0).Rows(0)(0))
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        g_getValueField = result
    End Function

    Public Function g_bValidValField(ByVal tableName As String, ByVal whereQuerys As String) As Boolean
        Dim bok As Boolean

        bok = False
        OpenConnection()
        Try
            Dim cmd As New SqlCommand
            Dim dtAdapter As SqlDataAdapter
            Dim dtSet As New DataSet

            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM " & tableName & " WHERE " & whereQuerys
            dtAdapter = New SqlDataAdapter(cmd)
            dtAdapter.Fill(dtSet)

            If dtSet.Tables(0).Rows.Count > 0 Then
                bok = True
            End If
        Catch ex As Exception
            MsgBoxShow(ex.Message, 0)
        End Try
        g_bValidValField = bok
    End Function
End Module
