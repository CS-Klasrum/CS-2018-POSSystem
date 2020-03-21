Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Module Module1

    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim role As String
    Dim item As String
    Dim cmd As MySqlCommand
    Dim count1 As Integer
    Public subtotal As Integer
    Dim EIN As String
    Dim payment As Integer
    Dim quantity As Integer
    Dim subprice As Integer
    Dim sukli As Integer

    'this is for log in 
    Dim on_off As String


    'this will help you to add new admin or cashier (Admin)
    Public Sub Add()

        Dim READER As MySqlDataReader
        Dim EncryptionFactor As Integer = 3

        'converting the item into encrytionform 
        For Each letter As String In frmUserAdd.txtPass.Text
            item += Chr(Asc(letter) + EncryptionFactor)
        Next

        frmUserAdd.txtPass.Text = item

        Select Case frmUserAdd.cmbRole.SelectedItem.ToString

            Case "Admin"

                Try
                    ConnDB()
                    Dim Query As String
                    Query = "INSERT INTO data.accountdata (AD_Role, AD_EIN, AD_Username, AD_Password, AD_FullName,AD_Online) VALUES ('" & frmUserAdd.cmbRole.Text & "', '" & frmUserAdd.txtEID.Text & "', '" & frmUserAdd.txtUsername.Text & "', '" & item & "', '" & frmUserAdd.txtFullName.Text & "', '" & "Offline" & " ')"
                    COMMAND = New MySqlCommand(Query, conn)





                    READER = COMMAND.ExecuteReader
                    item = ""
                    MessageBox.Show("New Admin saved ")
                    DisconnMy()
                    frmUserAdd.Close()
                    Reset()
                    ResetIt()
                    viewTheAccount()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case "Cashier"
                Try
                    ConnDB()

                    Dim Query As String
                    Query = "INSERT INTO data.accountdata (AD_Role, AD_EIN, AD_Username, AD_Password, AD_FullName, AD_CashierNumber,AD_Online) VALUES ('" & frmUserAdd.cmbRole.Text & "', '" & frmUserAdd.txtEID.Text & "', '" & frmUserAdd.txtUsername.Text & "', '" & item & "', '" & frmUserAdd.txtFullName.Text & "', '" & frmUserAdd.ComboBox1.Text & "','" & "Offline" & " ')"
                    COMMAND = New MySqlCommand(Query, conn)





                    READER = COMMAND.ExecuteReader
                    item = ""
                    MessageBox.Show("New Cashier saved ")
                    DisconnMy()
                    frmUserAdd.Close()
                    Reset()
                    ResetIt()
                    viewTheAccount()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select



    End Sub
    'update the database of account
    Public Sub UpdateAccount1()

        InstacheckV2()
        Try

            Dim query As String = "UPDATE accountdata SET  AD_Username =@Username , AD_Password =@Password , AD_FullName =@FullName , AD_Role =@Role WHERE AD_EIN =@EIN "
            ConnDB()


            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@EIN", frmUserAcc.txtEID.Text)
            cmd.Parameters.AddWithValue("@Username", frmUserAcc.txtFullName.Text)
            cmd.Parameters.AddWithValue("@Password", item)
            cmd.Parameters.AddWithValue("@FullName", frmUserAcc.txtPass.Text)
            cmd.Parameters.AddWithValue("@Role", frmUserAcc.cmbRole.Text)
            cmd.ExecuteNonQuery()
            Reset()
            ResetIt()
            viewTheAccount()

            item = ""
            MessageBox.Show("Data saved.")
            DisconnMy()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'deleting account 
    Public Sub Del()
      
        Dim Str As String


        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Str = "DELETE FROM `accountdata` WHERE `AD_EIN` = '" & frmUserAcc.txtEID.Text & "' "
                ConnDB()
                Dim mysc As New MySqlCommand(Str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Data Deleted!", MsgBoxStyle.Information)
                DisconnMy()
                Reset()
                ResetIt()
                viewTheAccount()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            DisconnMy()
        End Try
    End Sub
    'viewing the list of account
    Public Sub viewTheAccount()
       
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            ConnDB()
            Dim Query As String
            Query = "SELECT AD_EIN, AD_Username, AD_Password, AD_FullName,AD_Role FROM data.accountdata"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            frmUserAcc.DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            DisconnMy()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    'reset the datagrid 
    Public Sub Reset()

        dbDataSet.Columns.Clear()
        dbDataSet.Rows.Clear()








    End Sub

    ' this will help us to check the user data
    Public Sub LoginChecker()
        'connString = New MySqlConnection
        'connString.ConnectionString = "server=localhost;username=root;password=;database=data"

        Dim READER As MySqlDataReader


        Try
            ConnDB()
            Dim Query As String
            Query = "select * from accountdata where AD_Username ='" & frmLogin.txtUser.Text & "' and AD_Password = '" & frmLogin.txtPass.Text & "'"

            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                role = READER("AD_Role")


                If role = "Admin" Then

                    frmMain.Label2.Text = READER("AD_FullName")
                    
                    EIN = READER("AD_EIN")
                    on_off = READER("AD_Online")

                ElseIf role = "Cashier" Then
                    frmMain2.lblCashier.Text = READER("AD_FullName")
                    frmMain2.lblCashierNo.Text = READER("AD_CashierNumber")
                    EIN = READER("AD_EIN")
                    frmMain2.txtSearch.Focus()
                    on_off = READER("AD_Online")

                End If

            End While

            If count = 1 Then


                If READER("AD_Online") = "Offline" Then
                    If role = "Admin" Then
                        frmMain.Show()
                        role = ""
                        makeitonline()
                        on_off = "Online"

                    ElseIf role = "Cashier" Then
                        frmMain2.Show()
                        role = ""
                        makeitonline()
                        on_off = "Online"
                    End If
                ElseIf READER("AD_Online") = "Online" Then
                    MsgBox("Your Account Is Already Log in")
                End If





            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are not correct")

            End If

            DisconnMy()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    'converting the password into normal ( password in admin and cashier form )
    Public Sub Instacheck()

        Dim EncryptionFactor As Integer = 3
        For Each letter As String In frmUserAcc.txtUsername.Text
            item += Chr(Asc(letter) - EncryptionFactor)
        Next

        frmUserAcc.txtUsername.Text = item
        item = ""

    End Sub
    'converting the item into encrytionform ( password in admin and cashier form )
    Public Sub InstacheckV2()

        Dim EncryptionFactor As Integer = 3
        For Each letter As String In frmUserAcc.txtUsername.Text
            item += Chr(Asc(letter) + EncryptionFactor)
        Next

        frmUserAcc.txtUsername.Text = item


    End Sub
    ' just reset the value in the text ( admin and cashier )
    Public Sub ResetIt()
        frmUserAcc.txtUsername.Text = ""
        frmUserAcc.txtEID.Text = ""
        frmUserAcc.txtFullName.Text = ""
        frmUserAcc.txtPass.Text = ""
        frmUserAcc.cmbRole.ResetText()

    End Sub


    '==============================================================================================================================
    '==============================================================================================================================
    'Code for cashier
    Dim table As DataTable


    Public Sub searchitems()
     
        Dim READER As MySqlDataReader
       


        Try
            ConnDB()
            Dim Query As String

            Query = "select * from productdata where ProductID ='" & frmMain2.txtSearch.Text & "'"

            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader




            While READER.Read
                If READER("Quantity") > 0 Then
                    quantity = 1
                    subprice = quantity * READER("Price")
                    Dim itemAdd() As String = {READER("ProductID"), READER("ProductName"), quantity, READER("Price"), subprice}
                    frmMain2.DataGridView1.Rows.Add(itemAdd)
                    count1 = count1 + 1
                ElseIf READER("Quantity") < 0 Then
                    MsgBox("out of stack", MsgBoxStyle.Critical)
                End If

              


            End While
            If count1 = 1 Then
                subtotal += subprice
                frmMain2.TotalLabel.Text = subtotal

                count1 = 0


            ElseIf count1 > 1 Then
                MessageBox.Show("Invalid Code")
            Else
                MessageBox.Show("IvalidCode")

            End If

        Catch ex As Exception

        End Try
        DisconnMy()
    End Sub


    Public Sub Checkout()
      
        Dim READER As MySqlDataReader
        Dim date1 As String
        date1 = frmMain2.DateTimePicker1.Value.ToString("M-d-yyyy")



        Try
            If frmMain2.TotalLabel.Text > 0 Then
                payment = InputBox("Payment")
                'kasama to sa OR ==============
                OR2.lblCash.Text = payment
                '=============================
                If payment >= frmMain2.TotalLabel.Text Then
                    ConnDB()
                    sukli = payment - subtotal

                    'kasama to sa OR ==============
                    OR2.lblChange.Text = sukli
                    '=============================
                    MsgBox("Change is " & sukli)

                    Dim Query As String
                    Query = "INSERT INTO data.salerecord (Date, EIN, CashierNumber, TotalSale) VALUES ('" & date1 & "', '" & EIN & "', '" & frmMain2.lblCashierNo.Text & "', '" & frmMain2.TotalLabel.Text & "')"
                    COMMAND = New MySqlCommand(Query, conn)

                    READER = COMMAND.ExecuteReader

                    report()
                    OR2.Show()


                    MessageBox.Show("Thank you")
                    DisconnMy()
                    subtotal = 0
                    frmMain2.DataGridView1.Rows.Clear()
                    frmMain2.TotalLabel.Text = "0.00"


                ElseIf payment < frmMain2.TotalLabel.Text Then
                    MsgBox("you cant check out any data on this, time try again late", MsgBoxStyle.Information)
                Else
                    MsgBox("you cant check out any data on this, time try again late", MsgBoxStyle.Information)
                End If
            ElseIf frmMain2.TotalLabel.Text < 0 Then
                MsgBox("you cant check out any data on this, time try again late", MsgBoxStyle.Information)
            Else
                MsgBox("you cant check out any data on this, time try again late", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub report()
        DisconnMy()
        Dim READER As MySqlDataReader
        Dim date1 = Date.Now.ToString("MM/dd/yyyy")
        Dim time1 = Date.Now.ToString("hh:mm:ss")


        Try
            ConnDB()
            Dim Query As String
            Query = "INSERT INTO `accountreport`( `Date`, `CashierNo`, `CashierEIN`, `TotalSale`, `CSPayment`, `CSChange`)  VALUES ('" & date1 & "', '" & frmMain2.lblCashierNo.Text & "', '" & EIN & "', '" & frmMain2.TotalLabel.Text & "', '" & payment & "','" & sukli & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            DisconnMy()
            viewTherecord()

           
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'viewing the records
    Public Sub viewTherecord()
       Try

            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter("SELECT `Date`,`CashierNo`,`CashierEIN`, SUM(`TotalSale`) AS total FROM accountreport GROUP BY date ORDER BY date ", conn)
            adapter.Fill(table)
            frmReport.DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub makeitonline()


        Try

            Dim query As String = "UPDATE accountdata SET AD_Online =@Q WHERE AD_EIN =@ID "
            'Dim query As String = "UPDATE productdata SET  ProductID =@PID , ProductName = @PN ,Quantity =@Q , Price =@p , ExpDate=@Exp WHERE date =@d "
            ConnDB()
            If on_off = "Offline" Then
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", EIN)
                cmd.Parameters.AddWithValue("@Q", "Online")

                cmd.ExecuteNonQuery()
            ElseIf on_off = "Online" Then
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", EIN)
                cmd.Parameters.AddWithValue("@Q", "Offline")

                cmd.ExecuteNonQuery()
                on_off = ""
            End If
          


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


   
End Module
