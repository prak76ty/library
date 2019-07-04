Imports System.Data.OleDb
Imports System.Data
Public Class frmbook_return
    Dim ss As String
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet



    Private Sub frmbook_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from book_return", conn)
        ds = New DataSet
        da.Fill(ds, "book_return")

        cmd = New OleDbCommand("select issue_no from book_issue", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Comboissue_no.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(return_no) from book_return", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtbk_return_no.Text = temp.ToString
        DateTimePicker1.Text = ""
        Comboissue_no.Text = ""
        txtissue_date.Text = ""
        txtmem_id.Text = ""
        txtmem_name.Text = ""
        txt_acce_no.Text = ""
        txtbk_name.Text = ""
        txtauthor.Text = ""
        txtremark.Text = ""
        txt_fine.Text = ""


        btnsave.Enabled = True
        btncancel.Enabled = True

        btnprint.Enabled = False
        btnnew.Enabled = False
        btnreport.Enabled = False
        'btnprintfine.Enabled = False
        btnexit.Enabled = False




    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If (DateTimePicker1.Text = "") Then
            MessageBox.Show("fill the return date")
            Exit Sub
        End If
        If (Comboissue_no.Text = "") Then
            MessageBox.Show("fill the issue number")
            Exit Sub
        End If
        If (txtissue_date.Text = "") Then
            MessageBox.Show("fill the issue date")
            Exit Sub
        End If
        If (txtmem_id.Text = "") Then
            MessageBox.Show("fill the member id")
            Exit Sub
        End If
        If (txtmem_name.Text = "") Then
            MessageBox.Show("fill the member name")
            Exit Sub
        End If
        If (txt_acce_no.Text = "") Then
            MessageBox.Show("fill the accession number")
            Exit Sub
        End If
        If (txtbk_name.Text = "") Then
            MessageBox.Show("fill the book name")
            Exit Sub
        End If
        If (txtauthor.Text = "") Then
            MessageBox.Show("fill the author")
            Exit Sub
        End If
        If (txtremark.Text = "") Then
            MessageBox.Show("fill the remark")
            Exit Sub
        End If
        If (txt_fine.Text = "") Then
            MessageBox.Show("fill the fine")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into book_return values(" & txtbk_return_no.Text & ",'" & DateTimePicker1.Value & "'," & Comboissue_no.Text & "," & Convert.ToDateTime(txtissue_date.Text) & "," & txtmem_id.Text & ",'" & txtmem_name.Text & "'," & txt_acce_no.Text & ",'" & txtbk_name.Text & "','" & txtauthor.Text & "','" & txtremark.Text & "'," & txt_fine.Text & ")", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        frmbook_return_Load(sender, e)

        btnsave.Enabled = False
        btncancel.Enabled = False


        btnprint.Enabled = True
        btnnew.Enabled = True
        btnreport.Enabled = True
        'btnprintfine.Enabled = True
        btnexit.Enabled = True


    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtbk_return_no.Text = ""
        DateTimePicker1.Text = ""
        Comboissue_no.Text = ""
        txtissue_date.Text = ""
        txtmem_id.Text = ""
        txtmem_name.Text = ""
        txt_acce_no.Text = ""
        txtbk_name.Text = ""
        txtauthor.Text = ""
        txtremark.Text = ""
        txt_fine.Text = ""

        btnsave.Enabled = False
        btncancel.Enabled = False


        btnprint.Enabled = True
        btnnew.Enabled = True
        btnreport.Enabled = True
        'btnprintfine.Enabled = True
        btnexit.Enabled = True

    End Sub

    Private Sub txtmem_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmem_name.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtmem_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmem_name.TextChanged

    End Sub

    Private Sub txtauthor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtauthor.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtauthor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtauthor.TextChanged

    End Sub

    Private Sub txt_fine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fine.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txt_fine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fine.TextChanged

    End Sub

    Private Sub txt_acce_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_acce_no.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txt_acce_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_acce_no.TextChanged

    End Sub

    Private Sub Comboissue_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comboissue_no.SelectedIndexChanged
        cmd = New OleDbCommand("select issue_date,member_id,member_name,accetion_no,book_name,author from book_issue where issue_no = " & Comboissue_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtissue_date.Text = rdr.Item(0).ToString
            txtmem_id.Text = rdr.Item(1).ToString
            txtmem_name.Text = rdr.Item(2).ToString
            txt_acce_no.Text = rdr.Item(3).ToString

            txtbk_name.Text = rdr.Item(4).ToString

            txtauthor.Text = rdr.Item(5).ToString


        End If

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class