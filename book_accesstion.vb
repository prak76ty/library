Imports System.Data.OleDb
Imports System.Data
Public Class book_accesstion
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub book_accesstion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from book_accetion", conn)
        ds = New DataSet
        da.Fill(ds, "book_accetion")


        cmd = New OleDbCommand("select book_id from book_detail", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Combobk_id.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(accetion_no) from book_accetion", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtbk_acc_no.Text = temp.ToString
        dtpbk_acc_date.Text = ""
        Combobk_id.Text = ""
        txtbk_type.Text = ""
        txtbk_name.Text = ""

        txtauther.Text = ""
        txtpublisher.Text = ""
        txtedition.Text = ""
        txtpages.Text = ""
        txtprice.Text = ""
        txtdiscription.Text = ""
        txtstatus.Text = ""


        btnsave.Enabled = True
        btncancel.Enabled = True



        btnnew.Enabled = False
        btnnext.Enabled = False
        btnprev.Enabled = False
        btnlast.Enabled = False
        btnfirst.Enabled = False
        btnexit.Enabled = False


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If (txtdiscription.Text = "") Then
            MessageBox.Show("fill the discription")
            Exit Sub
        End If
        If (txtstatus.Text = "") Then
            MessageBox.Show("fill the status")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into book_accetion values(" & txtbk_acc_no.Text & ",'" & dtpbk_acc_date.Value & "'," & Combobk_id.Text & ",'" & txtbk_name.Text & "','" & txtbk_type.Text & "','" & txtauther.Text & "','" & txtpublisher.Text & "','" & txtedition.Text & "'," & txtpages.Text & "," & txtprice.Text & ",'" & txtdiscription.Text & "'," & txtstatus.Text & ")", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        book_accesstion_Load(sender, e)

        btnsave.Enabled = False
        btncancel.Enabled = False

       
        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True

        btnfirst.Enabled = True

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtbk_acc_no.Text = ""
        dtpbk_acc_date.Text = ""
        Combobk_id.Text = ""
        txtbk_type.Text = ""
        txtbk_name.Text = ""

        txtauther.Text = ""
        txtpublisher.Text = ""
        txtedition.Text = ""
        txtpages.Text = ""
        txtprice.Text = ""
        txtdiscription.Text = ""
        txtstatus.Text = ""

        btnsave.Enabled = False
        btncancel.Enabled = False


        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True

        btnfirst.Enabled = True
    End Sub
    Private Sub acc_record()
        txtbk_acc_no.Text = ds.Tables("book_accetion").Rows(recno).Item(0)
        dtpbk_acc_date.Text = ds.Tables("book_accetion").Rows(recno).Item(1)
        Combobk_id.Text = ds.Tables("book_accetion").Rows(recno).Item(2)

        txtbk_name.Text = ds.Tables("book_accetion").Rows(recno).Item(3)
        txtbk_type.Text = ds.Tables("book_accetion").Rows(recno).Item(4)

        
        
        txtauther.Text = ds.Tables("book_accetion").Rows(recno).Item(5)
        txtpublisher.Text = ds.Tables("book_accetion").Rows(recno).Item(6)
        txtedition.Text = ds.Tables("book_accetion").Rows(recno).Item(7)
        txtpages.Text = ds.Tables("book_accetion").Rows(recno).Item(8)
        txtprice.Text = ds.Tables("book_accetion").Rows(recno).Item(9)
        txtdiscription.Text = ds.Tables("book_accetion").Rows(recno).Item(10)
        txtstatus.Text = ds.Tables("book_accetion").Rows(recno).Item(11)

    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        recno = 0
        acc_record()
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        recno = ds.Tables("book_accetion").Rows.Count - 1
        acc_record()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("book_accetion").Rows.Count) Then
            acc_record()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("book_accetion").Rows.Count) Then
            acc_record()
        Else
            MessageBox.Show("last record")

        End If
    End Sub

    Private Sub txtpages_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpages.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtpages_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpages.TextChanged

    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub txtauther_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtauther.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtauther_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtauther.TextChanged

    End Sub

    Private Sub Combobk_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combobk_id.SelectedIndexChanged
        cmd = New OleDbCommand("select book_name,book_type, author,publisher,edition,pages,price from book_detail where book_id = " & Combobk_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtbk_name.Text = rdr.Item(0).ToString
            txtbk_type.Text = rdr.Item(1).ToString
            txtauther.Text = rdr.Item(2).ToString
            txtpublisher.Text = rdr.Item(3).ToString
            txtedition.Text = rdr.Item(4).ToString
            txtpages.Text = rdr.Item(5).ToString
            txtprice.Text = rdr.Item(6).ToString
        End If

        
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class