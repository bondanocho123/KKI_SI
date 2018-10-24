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
End Module
