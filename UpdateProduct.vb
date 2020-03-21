Public Class UpdateProduct
    Public category1 As String
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IT.TextChanged

    End Sub

    Private Sub QU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QU.Click

    End Sub

    Private Sub UpdateProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PD.Text = frmProducts.PNI4
        IT.Text = frmProducts.PNI1
        q.Text = frmProducts.PNI2
        p.Text = frmProducts.PNI3
        cmbRole.Text = frmProducts.PNI5
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        update11()
        frmProducts.PNI4 = ""
        frmProducts.PNI1 = ""
        frmProducts.PNI2 = ""
        frmProducts.PNI3 = ""
        frmProducts.PNI5 = ""
        Me.Close()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged
        Select Case cmbRole.SelectedItem.ToString
            Case "Beverages"
                category1 = "Beverages"

            Case "Bread/Bakert"
                category1 = "Bread/Bakert"

            Case "Canned/JarredGoods"
                category1 = "Canned/JarredGoods"
            Case "Dairy"
                category1 = "Dairy"
            Case "Dry/Baking Goods"
                category1 = "Dry/Baking Goods"
            Case "Frozen Foods"
                category1 = "Frozen Foods"
            Case "Meat"
                category1 = "Meat"
            Case "Produce"
                category1 = "Produce"
            Case "Paper Goods"
                category1 = "Paper Goods"
            Case "Personla Care"
                category1 = "Personla Care"
            Case "Others"
                category1 = "Others"
            Case "Candys"
                category1 = "Candys"
            Case "Condiments/Spices"
                category1 = "Condiments/Spices"
            Case "Snacks"
                category1 = "Snacks"
        End Select
    End Sub
End Class