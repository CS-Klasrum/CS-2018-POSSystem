Public Class frmProdAdd
    Public category As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, MyBase.Leave
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, MyBase.Enter
        productAdd()

    End Sub

    
    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged


        Dim date2 As String

        date2 = DateTimePicker3.Value.ToString("M-d-yyyy")
        TextBox6.Text = date2
    End Sub

    Private Sub frmProdAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = DateTimePicker1.Value
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged
        Select Case cmbRole.SelectedItem.ToString
            Case "Beverages"
                category = "Beverages"

            Case "Bread/Bakert"
                category = "Bread/Bakert"

            Case "Canned/JarredGoods"
                category = "Canned/JarredGoods"
            Case "Dairy"
                category = "Dairy"
            Case "Dry/Baking Goods"
                category = "Dry/Baking Goods"
            Case "Frozen Foods"
                category = "Frozen Foods"
            Case "Meat"
                category = "Meat"
            Case "Produce"
                category = "Produce"
            Case "Paper Goods"
                category = "Paper Goods"
            Case "Personla Care"
                category = "Personla Care"
            Case "Others"
                category = "Others"
            Case "Candys"
                category = "Candys"
            Case "Condiments/Spices"
                category = "Condiments/Spices"
            Case "Snacks"
                category = "Snacks"
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class