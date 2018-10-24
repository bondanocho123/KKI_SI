Public Class FormLogin

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim CUSysPar As New CUserSystemParameter

        If CUSysPar.GetLogUserSystemParameter(CUSysPar, txtUsername.Text, txtPassword.Text) Then
            MsgBox("Selamat Datang Admin")
        Else
            MsgBox("Password Salah !!")
        End If
    End Sub
End Class