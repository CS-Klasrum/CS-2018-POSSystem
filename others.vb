Imports MySql.Data.MySqlClient

Module others

    Dim COMMAND As MySqlCommand
    Dim Deleteditem As String

    Dim cmd As MySqlCommand
    Dim date1
    Dim productid As Integer
    Dim productname1
    Dim Quantity As Integer
    Dim price1
    Dim exp1


    'loopingOR
    Public y As Integer
    Dim quantity1 As String
    Dim des As String
    Dim price As String
    Dim subs As String
    Dim number As String



    Public Sub void11()
      
        Dim READER As MySqlDataReader
        Dim item As String
    



        Try
            ConnDB()
            Dim Query As String
            Query = "select * from accountdata where AD_Username ='" & Void1.txtUser.Text & "' and AD_Password = '" & Void1.txtPass.Text & "'"

            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                If READER("AD_Role") = "Admin" Then
                    item = InputBox("Insert Item ID ")


                    For j = frmMain2.DataGridView1.RowCount - 1 To 0 Step -1

                        If frmMain2.DataGridView1(0, j).Value = item Then


                            Deleteditem = frmMain2.DataGridView1(3, j).Value.ToString

                            frmMain2.DataGridView1.Rows.RemoveAt(j)
                            frmMain2.TotalLabel.Text -= Deleteditem
                            subtotal -= Deleteditem
                            MsgBox("done")

                        End If
                    Next

                    frmMain2.Show()

                    Void1.Hide()




                Else

                    MessageBox.Show("Invalid Account sis")
                End If
            End While



            DisconnMy()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub getingTheItemBarcode()


        Dim READER As MySqlDataReader

        OR2.dgw.Rows.Clear()

        For j = frmMain2.DataGridView1.RowCount - 1 To 0 Step -1

            Try
                ConnDB()
                Dim Query As String
                Query = "select * from Productdata where ProductID ='" & frmMain2.DataGridView1(0, j).Value & "'"

                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    date1 = READER("Date")
                    price1 = READER("Price")
                    exp1 = READER("ExpDate")
                    productname1 = READER("ProductName")
                    productid = frmMain2.DataGridView1(0, j).Value
                    Quantity = READER("Quantity") - frmMain2.DataGridView1(2, j).Value
                    If READER("Quantity") > 0 Then
                        savingTheNewQuantity()

                        des = frmMain2.DataGridView1(1, j).Value
                        quantity1 = frmMain2.DataGridView1(2, j).Value
                        price = frmMain2.DataGridView1(3, j).Value
                        subs = frmMain2.DataGridView1(4, j).Value
                        OR2.dgw.Rows.Add(quantity1, des, price, subs)
                        OR2.dgw.Height += 30
                        y += 19
                    End If

                End While


                OR2.Panel2.Location = New Point(11, 290 + y)
                OR2.Panel1.Height += y
                OR2.Height += y


            Catch ex As MySqlException


            End Try
        Next

    End Sub


    Public Sub savingTheNewQuantity()


        Try

            Dim query As String = "UPDATE productdata SET Quantity =@Q WHERE ProductID =@ID "
            'Dim query As String = "UPDATE productdata SET  ProductID =@PID , ProductName = @PN ,Quantity =@Q , Price =@p , ExpDate=@Exp WHERE date =@d "
            ConnDB()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", productid)
            cmd.Parameters.AddWithValue("@Q", Quantity)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub



  
End Module
