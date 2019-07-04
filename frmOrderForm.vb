Imports System.Data.OleDb
Imports System.Data

Public Class frmOrderForm
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Dim tt As Integer
    Dim ss As String

    Private Sub frmOrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        cmd = New OleDbCommand("select supplyer_id from supplyer_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cmbSID.Items.Add(rdr.Item(0).ToString)
        End While

        cmd = New OleDbCommand("select book_id from book_detail", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Combo_bk_id.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub cmbSID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSID.SelectedIndexChanged
        cmd = New OleDbCommand("select supplyer_name from supplyer_master where supplyer_id = " & cmbSID.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_s_name.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub Combo_bk_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_bk_id.SelectedIndexChanged
        cmd = New OleDbCommand("select book_name from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_name.Text = rdr.Item(0).ToString
        End If

        cmd = New OleDbCommand("select book_type from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_type.Text = rdr.Item(0).ToString
        End If

        cmd = New OleDbCommand("select author from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_auther.Text = rdr.Item(0).ToString
        End If

        cmd = New OleDbCommand("select publisher from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_publisher.Text = rdr.Item(0).ToString
        End If

        cmd = New OleDbCommand("select edition from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_edition.Text = rdr.Item(0).ToString
        End If

        cmd = New OleDbCommand("select price from book_detail where book_id = " & Combo_bk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_bk_price.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquantity.TextChanged
        txtamount.Text = (Val(txtquantity.Text) * Val(txt_bk_price.Text))
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_bill_amt.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bill_amt.TextChanged
        txtnet_pay.Text = (Val(txt_bill_amt.Text) - Val(txt_discont.Text))

    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_discont.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_discont.TextChanged
        txtnet_pay.Text = (Val(txt_bill_amt.Text) - Val(txt_discont.Text))

    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnet_pay.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet_pay.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_bk_price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bk_price.TextChanged
        txtamount.Text = (Val(txtquantity.Text) * Val(txt_bk_price.Text))
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(order_no) from order_master", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtorder_no.Text = temp.ToString

        Combo_bk_id.Text = ""
        txt_s_name.Text = ""
        Combo_bk_id.Text = ""
        cmbSID.Text = ""
        txt_bk_price.Text = ""
        txt_bk_auther.Text = ""
        txtnet_pay.Text = ""
        txt_bk_edition.Text = ""
        txt_bk_name.Text = ""
        txt_bk_type.Text = ""
        txt_discont.Text = ""
        txt_bk_publisher.Text = ""
        txtquantity.Text = ""
        txtamount.Text = ""


        btnsave.Enabled = True
        btncancel.Enabled = True

        btnprint.Enabled = False
        btnnew.Enabled = False
        btnexit.Enabled = False
        btnreport.Enabled = False
       


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        DataGridView1.Rows.Add()
        DataGridView1.Item(0, i).Value = (i + 1).ToString
        DataGridView1.Item(1, i).Value = Combo_bk_id.Text
        DataGridView1.Item(2, i).Value = txt_bk_name.Text
        DataGridView1.Item(3, i).Value = txt_bk_type.Text
        DataGridView1.Item(4, i).Value = txt_bk_auther.Text
        DataGridView1.Item(5, i).Value = txt_bk_publisher.Text
        DataGridView1.Item(6, i).Value = txt_bk_edition.Text
        DataGridView1.Item(7, i).Value = txt_bk_price.Text
        DataGridView1.Item(8, i).Value = txtquantity.Text
        DataGridView1.Item(9, i).Value = txtamount.Text


        i = i + 1

        tt = tt + Val(txtamount.Text)
        txt_bill_amt.Text = tt.ToString

        txtquantity.Text = ""

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        cmd = New OleDbCommand("INSERT INTO order_master VALUES (" & txtorder_no.Text & ",'" & DateTimePicker1.Value & "'," & cmbSID.Text & ",'" & txt_s_name.Text & "','" & txt_bill_amt.Text & "'," & txt_discont.Text & "," & txtnet_pay.Text & ")", conn)
        cmd.ExecuteNonQuery()


        cmd = New OleDbCommand("INSERT INTO order_detail(sr_no,order_no,order_date,supplyer_id,book_id,book_name,book_type,author,publisher,edition,price,quantity,amt) VALUES (@sr_no,@order_no,@order_date,@supplyer_id,@book_id,@book_name,@book_type,@author,@publisher,@edition,@price,@quantity,@amt)", conn)

        'this code use for passing the data type values of cammand

        cmd.Parameters.AddWithValue("@sr_no", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@order_no", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@order_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@supplyer_id", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@book_id", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@book_name", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@book_type", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@author", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@publisher", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@edition", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@price", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@quantity", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@amt", OleDbType.Numeric)

        'value save in table 

        For j As Integer = 0 To DataGridView1.Rows.Count - 2
            cmd.Parameters(0).Value = DataGridView1.Rows(j).Cells(0).Value
            cmd.Parameters(1).Value = txtorder_no.Text
            cmd.Parameters(2).Value = DateTimePicker1.Text
            cmd.Parameters(3).Value = cmbSID.Text
            cmd.Parameters(4).Value = DataGridView1.Rows(j).Cells(1).Value
            cmd.Parameters(5).Value = DataGridView1.Rows(j).Cells(2).Value
            cmd.Parameters(6).Value = DataGridView1.Rows(j).Cells(3).Value
            cmd.Parameters(7).Value = DataGridView1.Rows(j).Cells(4).Value
            cmd.Parameters(8).Value = DataGridView1.Rows(j).Cells(5).Value
            cmd.Parameters(9).Value = DataGridView1.Rows(j).Cells(6).Value
            cmd.Parameters(10).Value = DataGridView1.Rows(j).Cells(7).Value
            cmd.Parameters(11).Value = DataGridView1.Rows(j).Cells(8).Value
            cmd.Parameters(12).Value = DataGridView1.Rows(j).Cells(9).Value
           

            cmd.ExecuteNonQuery()

        Next




        MessageBox.Show("Saved Successfuly")


        btnsave.Enabled = False
        btncancel.Enabled = False


        btnnew.Enabled = True
        btnexit.Enabled = True
        btnprint.Enabled = True
        btnreport.Enabled = True


    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtorder_no.Text ="" 

        Combo_bk_id.Text = ""
        txt_s_name.Text = ""
        Combo_bk_id.Text = ""
        cmbSID.Text = ""
        txt_bk_price.Text = ""
        txt_bk_auther.Text = ""
        txtnet_pay.Text = ""
        txt_bk_edition.Text = ""
        txt_bk_name.Text = ""
        txt_bk_type.Text = ""
        txt_discont.Text = ""
        txt_bk_publisher.Text = ""
        txtquantity.Text = ""
        txtamount.Text = ""
        txt_bill_amt.Text = ""


       








        btnsave.Enabled = False
        btncancel.Enabled = False


        btnnew.Enabled = True
        btnexit.Enabled = True
        btnprint.Enabled = True
        btnreport.Enabled = True


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

    End Sub
End Class