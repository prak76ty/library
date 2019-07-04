Imports System.Data.OleDb
Imports System.Data

Public Class Form2
    Dim ss As String
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer




    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from book_detail", conn)
        ds = New DataSet
        da.Fill(ds, "book_detail")





    End Sub
    Private Sub clear()
        txtbk_id.Text = ""
        txtbk_name.Text = ""
        Combobktype.Text = ""
        txtauther.Text = ""
        txtpublisher.Text = ""
        txtedition.Text = ""
        txtpages.Text = ""
        txtprice.Text = ""

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(book_id) from book_detail", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtbk_id.Text = temp.ToString
        txtbk_name.Text = ""
        Combobktype.Text = ""
        txtauther.Text = ""
        txtpublisher.Text = ""
        txtedition.Text = ""
        txtpages.Text = ""
        txtprice.Text = ""

        btnsave.Enabled = True
        btncancel.Enabled = True

        btndelete.Enabled = False
        btnfind.Enabled = False
        btnnew.Enabled = False
        btnnext.Enabled = False
        btnprev.Enabled = False
        btnlast.Enabled = False
        btnupdate.Enabled = False
        btnfirst.Enabled = False





    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If (txtbk_name.Text = "") Then
            MessageBox.Show("fill the name")
            Exit Sub
        End If
        If (Combobktype.Text = "") Then
            MessageBox.Show("fill the type")
            Exit Sub
        End If
        If (txtauther.Text = "") Then
            MessageBox.Show("fill the authername")
            Exit Sub
        End If
        If (txtpublisher.Text = "") Then
            MessageBox.Show("fill the publisher")
            Exit Sub
        End If
        If (txtedition.Text = "") Then
            MessageBox.Show("fill the edition")
            Exit Sub
        End If
        If (txtpages.Text = "") Then
            MessageBox.Show("fill the pages")
            Exit Sub
        End If
        If (txtprice.Text = "") Then
            MessageBox.Show("fill the price")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into book_detail values(" & txtbk_id.Text & ",'" & txtbk_name.Text & "','" & Combobktype.Text & "','" & txtauther.Text & "','" & txtpublisher.Text & "','" & txtedition.Text & "'," & txtpages.Text & "," & txtprice.Text & ")", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        Form2_Load(sender, e)

        btnsave.Enabled = False
        btncancel.Enabled = False

        btndelete.Enabled = True
        btnfind.Enabled = True
        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True
        btnupdate.Enabled = True
        btnfirst.Enabled = True



    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtbk_id.Text = ""
        txtbk_name.Text = ""
        Combobktype.Text = ""
        txtauther.Text = ""
        txtpublisher.Text = ""
        txtedition.Text = ""
        txtpages.Text = ""
        txtprice.Text = ""

        btnsave.Enabled = False
        btncancel.Enabled = False

        btndelete.Enabled = True
        btnfind.Enabled = True
        btnnew.Enabled = True
        btnnext.Enabled = True
        btnprev.Enabled = True
        btnlast.Enabled = True
        btnupdate.Enabled = True
        btnfirst.Enabled = True

    End Sub
    Private Sub bkdetail()
        txtbk_id.Text = ds.Tables("book_detail").Rows(recno).Item(0)
        txtbk_name.Text = ds.Tables("book_detail").Rows(recno).Item(1)
        Combobktype.Text = ds.Tables("book_detail").Rows(recno).Item(2)
        txtauther.Text = ds.Tables("book_detail").Rows(recno).Item(3)
        txtpublisher.Text = ds.Tables("book_detail").Rows(recno).Item(4)
        txtedition.Text = ds.Tables("book_detail").Rows(recno).Item(5)
        txtpages.Text = ds.Tables("book_detail").Rows(recno).Item(6)
        txtprice.Text = ds.Tables("book_detail").Rows(recno).Item(7)


    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        recno = 0
        bkdetail()

    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        recno = ds.Tables("book_detail").Rows.Count - 1
        bkdetail()

    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("book_detail").Rows.Count) Then
            bkdetail()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("book_detail").Rows.Count) Then
            bkdetail()
        Else
            MessageBox.Show("last record")

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        ss = "update book_detail set book_name='" & txtbk_name.Text & "' ,book_type='" & Combobktype.Text & "' ,author='" & txtauther.Text & "',publisher='" & txtpublisher.Text & "',edition='" & txtedition.Text & "',pages=" & txtpages.Text & ",price=" & txtprice.Text & "  where book_id=" & txtbk_id.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated Sucessfully!!!")
        Form2_Load(sender, e)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ss = "delete from book_detail where book_id=" & txtbk_id.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted Sucessfully!!!")
        Call clear()




        Form2_Load(sender, e)
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

    Private Sub txtbk_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbk_name.KeyPress

    End Sub

    Private Sub txtbk_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbk_name.TextChanged

    End Sub

    Private Sub txtauther_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtauther.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtauther_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtauther.TextChanged

    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Me.Close()
    End Sub
End Class