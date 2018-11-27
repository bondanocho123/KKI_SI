Imports FunctionSQL.BNDNBUILDER
Imports System.Data
Imports System.Data.SqlClient

Public Class FrmParameterSystem
    Dim DBSQL As New DatabaseSQL
    Dim DBValid As New Validator
    Dim sSelection As String = String.Empty

    Private Sub FrmParameterSystem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillCbUserGroup()
        cbUserGroup.SelectedIndex = 0
        fillSelected()
        fillSelection()




    End Sub

    Private Sub fillSelection()
        Dim dtSet As New DataSet

        dtSet = DBSQL.GetDataset(ConnectionString, "UserGroupAuthorized", "SELECT DISTINCT(UserGroup_Authorized) FROM UserGroupAuthorized")
        lbSelectionAccess.Items.Clear()
        For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
            lbSelectionAccess.Items.Add(Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Authorized")))
        Next

    End Sub

    Private Sub fillSelected()
        Dim dtSet As New DataSet

        dtSet = DBSQL.GetDataset(ConnectionString, "UserGroupAuthorized", "SELECT DISTINCT(UserGroup_Authorized),* FROM UserGroupAuthorized UGA inner join UserGroupParameter UGP  ON UGA.UserGroup_Id=UGP.UserGroup_Id WHERE UGP.UserGroup_Name = '" & cbUserGroup.Text & "'")
        lbSelectedAccess.Items.Clear()
        For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
            lbSelectedAccess.Items.Add(Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Authorized")))
        Next
    End Sub

    Private Sub fillCbUserGroup()
        Dim dtSet As New DataSet

        dtSet = DBSQL.GetDataset(ConnectionString, "UserGroupParameter", "SELECT UserGroup_Name FROM UserGroupParameter")

        For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
            cbUserGroup.Items.Add(Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Name")))
        Next
    End Sub

    Private Sub btnGetSelected_Click(sender As System.Object, e As System.EventArgs) Handles btnSetSelected.Click
        Dim sSQL As String = "SELECT * FROM UserGroupAuthorized UGA inner join UserGroupParameter UGP  ON UGA.UserGroup_Id=UGP.UserGroup_Id WHERE UGP.UserGroup_Name = '" & cbUserGroup.Text & "' AND UGA.UserGroup_Authorized='" & sSelection & "'"
        If Not String.IsNullOrEmpty(sSelection) Then
            If DBValid.bValidFieldValue(ConnectionString, "UserGroupAuthorized", sSQL) Then
                MsgBoxShow("Duplicated value", 0)
            Else
                DBSQL.ExecuteSQL(ConnectionString, CommandType.Text, "INSERT INTO UserGroupAuthorized(UserGroup_Id, UserGroup_Authorized) VALUES ('" & DBSQL.GetFieldValue(ConnectionString, "UserGroupParameter", "UserGroup_Name='" & cbUserGroup.Text & "'", "UserGroup_Id") & "','" & sSelection & "')")
            End If
        End If
        fillSelected()
    End Sub


    Private Sub btnGetsSelected_Click(sender As System.Object, e As System.EventArgs) Handles btnSetAllSelected.Click
        Dim dtSet As New DataSet
        Dim sSQL As String

        dtSet = DBSQL.GetDataset(ConnectionString, "UserGroupAuthorized", "SELECT * FROM UserGroupAuthorized")


        If dtSet.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To dtSet.Tables(0).Rows.Count - 1
                sSQL = "SELECT * FROM UserGroupAuthorized UGA inner join UserGroupParameter UGP  ON UGA.UserGroup_Id=UGP.UserGroup_Id WHERE UGP.UserGroup_Name = '" & cbUserGroup.Text & "' AND UGA.UserGroup_Authorized='" & Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Authorized")) & "'"

                If Not DBValid.bValidFieldValue(ConnectionString, "UserGroupAuthorized", sSQL) Then
                    DBSQL.ExecuteSQL(ConnectionString, CommandType.Text, "INSERT INTO UserGroupAuthorized(UserGroup_Id, UserGroup_Authorized) VALUES ('" & DBSQL.GetFieldValue(ConnectionString, "UserGroupParameter", "UserGroup_Name='" & cbUserGroup.Text & "'", "UserGroup_Id") & "','" & Convert.ToString(dtSet.Tables(0).Rows(i)("UserGroup_Authorized")) & "')")
                End If
            Next
        End If

        fillSelected()



    End Sub

    Private Sub lbSelectionAccess_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lbSelectionAccess.SelectedValueChanged
        sSelection = lbSelectionAccess.GetItemText(lbSelectionAccess.SelectedItem)
    End Sub

    Private Sub cbUserGroup_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbUserGroup.SelectedValueChanged
        fillSelected()
    End Sub
End Class