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
                MsgBoxShow("Check contact your administrator !!", 0)
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
                MsgBoxShow("Check contact your administrator !!", 0)
            End If
        Loop Until bok = True
        GoTo out
Err:
        Application.Exit()
out:
    End Sub

    Private Sub KToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KToolStripMenuItem.Click
        If msgQuestion("Exit Application ?", "Exit") Then
            Application.Exit()
        End If
    End Sub

    Private Sub UserGgroupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserGgroupToolStripMenuItem.Click
        ShowForm(FrmUserGroupParameter, "Parameter | User Group", Me)
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserToolStripMenuItem.Click
        ShowForm(FrmUserParameter, "Parameter | User", Me)
    End Sub

    Private Sub DriverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DriverToolStripMenuItem.Click
        ShowForm(FrmDriverParameter, "Parameter | Driver", Me)
    End Sub
End Class
