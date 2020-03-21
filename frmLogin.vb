Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic


Public Class frmLogin
    Dim pass1 As String
    Dim connection As String
    Dim EncryptionFactor As Integer = 3
    Public MysqlConn As New MySqlConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click



        Try

            For Each letter As String In txtPass.Text
                pass1 += Chr(Asc(letter) + EncryptionFactor)
            Next
            txtPass.Text = pass1
            LoginChecker()
            pass1 = ""
            txtUser.Text = ""
            txtPass.Text = ""
        Catch ex As Exception

            MsgBox("contact you admin to connect it to the server")
        End Try

    End Sub
    Sub connect()

        Try
            conn.Open()


            Label6.ForeColor = Color.SpringGreen
            Label6.Text = "● Online"

        Catch ex As Exception
            Label6.ForeColor = Color.Silver
            Label6.Text = "● Offline"
        End Try

    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MsgBox("Thank you.", 64, "Info")
        Me.Close()
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled = False
            Case 48 To 57

                e.Handled = False
            Case Else
                e.Handled = True

                MsgBox("Letters & numbers only")

        End Select
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled = False
            Case 48 To 57

                e.Handled = False
            Case Else
                e.Handled = True

                MsgBox("Letters & numbers only")

        End Select
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        txtPass.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        txtPass.PasswordChar = "●"
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        SQLconnect.Show()


    End Sub
End Class
