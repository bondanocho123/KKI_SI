Public Class FormMain

    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim CUSysPar As New CUserSystemParameter
        Dim bok As Boolean

        bok = False
        Do
            If FormLogin.Login(CUSysPar) Then
                stUser.Text = CUSysPar.szUserName
                stTime.Text = Convert.ToDateTime(Now).ToString("MM/dd/yyyy")
                bok = True
            Else
                If bExit = True Then
                    GoTo Err
                End If
                bok = False
                MessageBox.Show("Check your contact administrator !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop Until bok = True
        GoTo out
Err:
        Application.Exit()
out:
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim CUSysPar As New CUserSystemParameter
        Dim bok As Boolean

        bok = False
        Do
            If FormLogin.Login(CUSysPar) Then
                stUser.Text = CUSysPar.szUserName
                stTime.Text = Convert.ToDateTime(Now).ToString("MM/dd/yyyy")
                bok = True
            Else
                If bExit = True Then
                    GoTo Err
                End If
                bok = False
                MessageBox.Show("Check your contact administrator !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop Until bok = True
        GoTo out
Err:
        Application.Exit()
out:
    End Sub
End Class
