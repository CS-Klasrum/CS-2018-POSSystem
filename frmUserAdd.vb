Public Class frmUserAdd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, MyBase.Enter
        Add()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, MyBase.Leave
        Me.Close()
    End Sub

    Private Sub frmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEID.Enabled = False
        txtFullName.Enabled = False
        txtPass.Enabled = False
        txtUsername.Enabled = False
        ComboBox1.Enabled = False

       
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged

        Select Case cmbRole.SelectedItem.ToString
            Case "Admin"
                txtEID.Enabled = False
                txtFullName.Enabled = True
                txtPass.Enabled = True
                txtUsername.Enabled = True
                ComboBox1.Enabled = False

            Case "Cashier"
                txtEID.Enabled = False
                txtFullName.Enabled = True
                txtPass.Enabled = True
                txtUsername.Enabled = True
                ComboBox1.Enabled = True
        End Select
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class