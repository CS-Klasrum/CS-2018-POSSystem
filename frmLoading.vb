Public Class frmLoading

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 10
        Label3.Text += 2
        If RectangleShape2.Width = 510 Then
            Timer1.Stop()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class