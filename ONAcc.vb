Imports MySql.Data.MySqlClient

Public Class ONAcc
    Dim click1 As String

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txtEID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnAddProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProd.Click

        click1 = "Cashier"
        Reset()
        online()

    End Sub

    Private Sub online_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Public Sub online()

        Try
            If click1 = "Cashier" Then
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT `AD_EIN`,`AD_FullName`, `AD_Role`, `AD_CashierNumber`, `AD_Online` FROM `accountdata` WHERE `AD_Online` = 'Online' and `AD_Role`= 'Cashier'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table

            ElseIf click1 = "Admin" Then
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT `AD_EIN`,`AD_FullName`, `AD_Role`, `AD_CashierNumber`, `AD_Online` FROM `accountdata` WHERE `AD_Online` = 'Online' and `AD_Role`= 'Admin'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End If








        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        click1 = "Admin"
        Reset()
        online()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        online()
    End Sub
End Class