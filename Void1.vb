Public Class Void1
    Dim pass1 As String
    Dim EncryptionFactor As Integer = 3
    Private Sub Void_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        For Each letter As String In txtPass.Text
            pass1 += Chr(Asc(letter) + EncryptionFactor)
        Next
        txtPass.Text = pass1
        void11()
        pass1 = ""
        txtUser.Text = ""
        txtPass.Text = ""


    End Sub
End Class


