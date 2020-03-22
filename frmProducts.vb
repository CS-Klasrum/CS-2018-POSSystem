Imports MySql.Data.MySqlClient


Public Class frmProducts
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    'kaya naka public pafra ma access din ng ibang form ung nasaloob niyan ng module
    Public PNI1 = ""
    Public PNI2 = ""
    Public PNI3 = ""
    Public PNI4 = ""
    Public PNI5 = ""
    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        frmProdAdd.Show()
    End Sub

    Private Sub ProdDelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdDelToolStripMenuItem.Click
        productDel()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        'product ID
        PNI4 = DataGridView1.Item(1, i).Value
        'product name
        PNI1 = DataGridView1.Item(2, i).Value
        'product quantity
        PNI2 = DataGridView1.Item(3, i).Value
        'product price 
        PNI3 = DataGridView1.Item(4, i).Value
        'category
        PNI5 = DataGridView1.Item(6, i).Value

    End Sub

    Private Sub ProdUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdUpdateToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnAddProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProd.Click


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateProduct.Show()
    End Sub

    Private Sub lblSubtotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        expireditem()
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged

        Select Case cmbRole.SelectedItem.ToString
            Case "Beverages"

                Dim table As New DataTable

                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Beverages" & "' ", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Bread/Bakert"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Bread/Bakert" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table

            Case "Canned/JarredGoods"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Canned/JarredGoods" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Dairy"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Dairy" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Dry/Baking Goods"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Dry/Baking Goods" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Frozen Foods"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Frozen Foods" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Meat"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Meat" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Produce"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Produce" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Paper Goods"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Paper Goods" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Personla Care"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Personla Care" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Others"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Others" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Candys"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Candys" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Condiments/Spices"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Condiments/Spices" & "'", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
            Case "Snacks"
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata Where category = '" & "Snacks" & "' ", conn)
                adapter.Fill(table)
                DataGridView1.DataSource = table
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class