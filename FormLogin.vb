Public Class FormLogin
    Dim bok As Boolean
    Dim intLoginNotValid As Integer = 0

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim CUSysPar As New CUserSystemParameter

        If CUSysPar.GetLogUserSystemParameter(CUSysPar, txtUsername.Text, txtPassword.Text) Then
            g_szUsername = txtUsername.Text
            g_szUserId = CUSysPar.szUserId
            bok = True
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            bok = False
            intLoginNotValid = 1
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If intLoginNotValid = 0 Then
            bExit = True
        End If

        intLoginNotValid = 0
        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUsername.CharacterCasing = CharacterCasing.Upper
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Public Function Login(ByRef CUSysPar As CUserSystemParameter) As Boolean
        Dim idok As Boolean

        bok = False
        Me.ShowDialog()
        If bok = True Then
            If CUSysPar.GetLogUserSystemParameter(CUSysPar, txtUsername.Text, txtPassword.Text) Then
                idok = True
            End If
        End If

        Login = idok
    End Function

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If msgQuestion("Exit Application ?", "Exit") Then
            Application.Exit()
        End If
    End Sub
End Class