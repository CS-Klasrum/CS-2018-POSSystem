Imports MySql.Data.MySqlClient

Module CDproduct

    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim count1 As Integer

    Public Sub product()

        Try

            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata", conn)
            adapter.Fill(table)
            frmProducts.DataGridView1.DataSource = table







        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
   
    Public Sub productDel()
       
        Dim Str As String


        Try
            If frmProducts.PNI1 = "" Then
                MsgBox("You cant delete a product now , Try again later ")
            Else
                If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                    Str = "DELETE FROM data.productdata WHERE ProductName = '" & frmProducts.PNI1 & "' "
                    ConnDB()
                    Dim mysc As New MySqlCommand(Str, conn)
                    mysc.ExecuteNonQuery()
                    MsgBox("Data Deleted!", MsgBoxStyle.Information)
                    DisconnMy()
                    product()
                    Reset()
                    ResetIt()
                    frmProducts.PNI1 = ""

                End If
            End If
           
        Catch ex As Exception
            MsgBox("Invalid Product ID", MsgBoxStyle.Critical)
            DisconnMy()

        End Try




    End Sub

    Public Sub productAdd()
       
        Dim READER As MySqlDataReader
        Dim date1, date2 As String
        date1 = frmProdAdd.DateTimePicker1.Value.ToString("M-d-yyyy")
        date2 = frmProdAdd.DateTimePicker3.Value.ToString("M-d-yyyy")
        Try
            ConnDB()
            Dim Query As String
            Query = "INSERT INTO data.productdata (Date, ProductID, ProductName, Quantity , Price, ExpDate,category) VALUES ('" & date1 & "', '" & frmProdAdd.TextBox2.Text & "', '" & frmProdAdd.TextBox3.Text & "', '" & frmProdAdd.TextBox4.Text & "', '" & frmProdAdd.TextBox5.Text & "', '" & date2 & "', '" & frmProdAdd.category & "')"
            COMMAND = New MySqlCommand(Query, conn)

            READER = COMMAND.ExecuteReader
            DisconnMy()
            ConnDB()
            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter("SELECT * FROM data.productdata", conn)
            adapter.Fill(table)
            frmProducts.DataGridView1.DataSource = table

            DisconnMy()
            frmProdAdd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    'reset the datagrid 
    Public Sub Resetproduct()
        dbDataSet.Columns.Clear()
        dbDataSet.Rows.Clear()


    End Sub


    '===================================================================================================================================================
    '===================================================================================================================================================
    'Sales

    Public Sub salesView()

        Try

            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter("SELECT `Date`,`CashierNumber`,`EIN`, SUM(`TotalSale`) AS total FROM salerecord GROUP BY date ORDER BY date  ", conn)
            adapter.Fill(table)
            frmSales.DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Public Sub update11()
        Try

            Dim query As String = "UPDATE productdata SET ProductName =@N , Quantity =@Q , Price = @P ,category =@C WHERE ProductID =@ID "
            'Dim query As String = "UPDATE productdata SET  ProductID =@PID , ProductName = @PN ,Quantity =@Q , Price =@p , ExpDate=@Exp WHERE date =@d "
            ConnDB()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", UpdateProduct.PD.Text)
            cmd.Parameters.AddWithValue("@Q", UpdateProduct.q.Text)
            cmd.Parameters.AddWithValue("@N", UpdateProduct.IT.Text)
            cmd.Parameters.AddWithValue("@P", UpdateProduct.p.Text)
            cmd.Parameters.AddWithValue("@C", UpdateProduct.category1)
            cmd.ExecuteNonQuery()
            MsgBox("Product Updated")
            UpdateProduct.Hide()

            product()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    ' d pa tapos ang hirap eh .. 
    Public Sub expireditem()

        Dim pro As String



              

        For j = frmProducts.DataGridView1.RowCount - 1 To 0 Step -1

            If frmProducts.DataGridView1(5, j).Value <= Date.Now.ToString("MM/dd/yyyy") Then
                pro = frmProducts.DataGridView1(5, j).Value
                MsgBox("Change is " & pro)

                frmProducts.lblSubtotal.Text += 1


            End If
        Next



        'Dim table As New DataTable
        'Dim adapter As New MySqlDataAdapter("SELECT ExpDate,ProductName,ProductID,Quantity,Price FROM data.productdata Where Expdate <= '" & date11 & "' ", conn)
        'adapter.Fill(table)
        'frmProducts.DataGridView1.DataSource = table





    End Sub

End Module
