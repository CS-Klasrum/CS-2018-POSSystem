Public Class frmMain


    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        With frmSales
            .TopLevel = False
            Panel3.ResumeLayout()
            Panel3.Controls.Add(frmSales)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        With frmProducts
            .TopLevel = False
            Panel3.ResumeLayout()
            Panel3.Controls.Add(frmProducts)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        With frmReport
            .TopLevel = False
            Panel3.ResumeLayout()
            Panel3.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub UserAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem.Click
        With frmUserAcc
            .TopLevel = False
            Panel3.ResumeLayout()
            Panel3.Controls.Add(frmUserAcc)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.txtUser.Focus()
        makeitonline()


    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        With frmHome
            .TopLevel = False
            Panel3.ResumeLayout()


            Panel3.Controls.Add(frmHome)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ONAcc.Show()

    End Sub
End Class