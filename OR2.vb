Public Class OR2

    Dim quantity As String
    Dim des As String
    Dim price As String
    Dim subs As String
    Dim number As String
    Dim counter As Integer = 1


    Private Sub OR2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadItemstoDatagrid()


       
    End Sub

    Private Sub LoadItemstoDatagrid()
        LoadReceiptInfo()
        PrintDocument1.Print()





    End Sub
    Private Sub LoadReceiptInfo()
        Try
            lblInvoice.Text = frmMain2.lblCashierNo.Text
            lblEmpName.Text = frmMain2.lblCashier.Text
            lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
            lblTime.Text = Date.Now.ToString("hh:mm:ss")
            lblVat.Text = frmMain2.lblVAT.Text
            lblSubtotal.Text = frmMain2.lblSubtotal.Text
            lblTotal.Text = frmMain2.TotalLabel.Text



        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change.Click

    End Sub
End Class