Imports System.Data.OleDb
Imports System.Data
Public Class frmbook_delivery
    Dim ss As String
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub frmbook_delivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from book_delivery", conn)
        ds = New DataSet
        da.Fill(ds, "book_delivery")

        cmd = New OleDbCommand("select order_no from order_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Comboorder_no.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(delivery_no) from book_delivery", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtdelvery_no.Text = temp.ToString
        dtp_del_date.Text = ""
        Comboorder_no.Text = ""
        txtorder_date.Text = ""
        txtsupp_id.Text = ""
        txtsupp_name.Text = ""
        txtbill_amt.Text = ""
        txtdiscount.Text = ""
        txtnet_pay.Text = ""
        txtdel_by_whom.Text = ""
        txtremark.Text = ""


        btnsave.Enabled = True
        btncancel.Enabled = True

        btnlast.Enabled = False
        btnnew.Enabled = False
        btnnext.Enabled = False
        btnprev.Enabled = False
        btnexit.Enabled = False
        btnfirst.Enabled = False




    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If (dtp_del_date.Text = "") Then
            MessageBox.Show("fill the date")
            Exit Sub
        End If
        If (Comboorder_no.Text = "") Then
            MessageBox.Show("fill the Order number")
            Exit Sub
        End If
        If (txtorder_date.Text = "") Then
            MessageBox.Show("fill the Order Date")
            Exit Sub
        End If
        If (txtsupp_id.Text = "") Then
            MessageBox.Show("fill the supplier id")
            Exit Sub
        End If
        If (txtsupp_name.Text = "") Then
            MessageBox.Show("fill the supplier name")
            Exit Sub
        End If
        If (txtbill_amt.Text = "") Then
            MessageBox.Show("fill the bill amount")
            Exit Sub
        End If
        If (txtdiscount.Text = "") Then
            MessageBox.Show("fill the Discount")
            Exit Sub
        End If
        If (txtnet_pay.Text = "") Then
            MessageBox.Show("fill the net payable")
            Exit Sub
        End If
        If (txtdel_by_whom.Text = "") Then
            MessageBox.Show("fill the Delivery by whom")
            Exit Sub
        End If
        If (txtremark.Text = "") Then
            MessageBox.Show("fill the Remark")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into book_delivery values(" & txtdelvery_no.Text & ",'" & dtp_del_date.Value & "'," & Comboorder_no.Text & ",'" & txtorder_date.Text & "'," & txtsupp_id.Text & ",'" & txtsupp_name.Text & "'," & txtbill_amt.Text & "," & txtdiscount.Text & "," & txtnet_pay.Text & ",'" & txtdel_by_whom.Text & "','" & txtremark.Text & "')", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        frmbook_delivery_Load(sender, e)

        btnsave.Enabled = False
        btncancel.Enabled = False

        
        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True
        btnexit.Enabled = True
        btnfirst.Enabled = True

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtdelvery_no.Text = ""
        dtp_del_date.Text = ""
        Comboorder_no.Text = ""
        txtorder_date.Text = ""
        txtsupp_id.Text = ""
        txtsupp_name.Text = ""
        txtbill_amt.Text = ""
        txtdiscount.Text = ""
        txtnet_pay.Text = ""
        txtdel_by_whom.Text = ""
        txtremark.Text = ""

        btnsave.Enabled = False
        btncancel.Enabled = False


        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True
        btnexit.Enabled = True
        btnfirst.Enabled = True

    End Sub
    Private Sub del_detail()
        txtdelvery_no.Text = ds.Tables("book_delivery").Rows(recno).Item(0)
        dtp_del_date.Text = ds.Tables("book_delivery").Rows(recno).Item(1)
        Comboorder_no.Text = ds.Tables("book_delivery").Rows(recno).Item(2)
        txtorder_date.Text = ds.Tables("book_delivery").Rows(recno).Item(3)
        txtsupp_id.Text = ds.Tables("book_delivery").Rows(recno).Item(4)
        txtsupp_name.Text = ds.Tables("book_delivery").Rows(recno).Item(5)
        txtbill_amt.Text = ds.Tables("book_delivery").Rows(recno).Item(6)
        txtdiscount.Text = ds.Tables("book_delivery").Rows(recno).Item(7)
        txtnet_pay.Text = ds.Tables("book_delivery").Rows(recno).Item(8)
        txtdel_by_whom.Text = ds.Tables("book_delivery").Rows(recno).Item(9)
        txtremark.Text = ds.Tables("book_delivery").Rows(recno).Item(10)
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        recno = 0
        del_detail()

    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("book_delivery").Rows.Count) Then
            del_detail()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("book_delivery").Rows.Count) Then
            del_detail()
        Else
            MessageBox.Show("last record")

        End If
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        recno = ds.Tables("book_delivery").Rows.Count - 1
        del_detail()

    End Sub

    Private Sub txtsupp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsupp_name.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtsupp_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsupp_name.TextChanged

    End Sub

    Private Sub txtdel_by_whom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdel_by_whom.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtdel_by_whom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdel_by_whom.TextChanged

    End Sub

    Private Sub txtbill_amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbill_amt.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtbill_amt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbill_amt.TextChanged

    End Sub

    Private Sub txtdiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiscount.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged

    End Sub

    Private Sub txtnet_pay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnet_pay.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtnet_pay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet_pay.TextChanged

    End Sub

    Private Sub Comboorder_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comboorder_no.SelectedIndexChanged
        cmd = New OleDbCommand("select order_date,supplyer_id,supplyer_name,bill_amt,discount,net_payable from order_master where order_no = " & Comboorder_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtorder_date.Text = rdr.Item(0).ToString
            txtsupp_id.Text = rdr.Item(1).ToString
            txtsupp_name.Text = rdr.Item(2).ToString
            txtbill_amt.Text = rdr.Item(3).ToString
            txtdiscount.Text = rdr.Item(4).ToString
            txtnet_pay.Text = rdr.Item(5).ToString

        End If

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class