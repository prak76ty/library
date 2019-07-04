Imports System.Data.OleDb
Imports System.Data
Public Class frmbook_issue
    Dim ss As String
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub frmbook_issue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from book_issue", conn)
        ds = New DataSet
        da.Fill(ds, "book_issue")

        cmd = New OleDbCommand("select member_id from member_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Combo_mem_id.Items.Add(rdr.Item(0).ToString)
        End While

        cmd = New OleDbCommand("select accetion_no from book_accetion", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Combo_bk_acce_no.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(issue_no) from book_issue", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtissue_no.Text = temp.ToString
        DateTimePicker1.Text = ""
        Combo_mem_id.Text = ""
        txtmem_name.Text = ""
        Combo_bk_acce_no.Text = ""
        txtbk_name.Text = ""
        txtauthor.Text = ""
        txtremark.Text = ""
        

        btnsave.Enabled = True
        btncancel.Enabled = True

        btnprint.Enabled = False
        btnnew.Enabled = False
        btnreport.Enabled = False

        btnexit.Enabled = False





    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If (DateTimePicker1.Text = "") Then
            MessageBox.Show("fill the date")
            Exit Sub
        End If
        If (Combo_mem_id.Text = "") Then
            MessageBox.Show("fill the member id")
            Exit Sub
        End If
        If (txtmem_name.Text = "") Then
            MessageBox.Show("fill the member name")
            Exit Sub
        End If
        If (Combo_bk_acce_no.Text = "") Then
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
        
        cmd = New OleDbCommand("insert into book_issue values(" & txtissue_no.Text & ",'" & DateTimePicker1.Value & "'," & Combo_mem_id.Text & ",'" & txtmem_name.Text & "'," & Combo_bk_acce_no.Text & ",'" & txtbk_name.Text & "','" & txtauthor.Text & "','" & txtremark.Text & "')", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        frmbook_issue_Load(sender, e)

        btnsave.Enabled = False
        btncancel.Enabled = False


        btnprint.Enabled = True

        btnnew.Enabled = True
        btnreport.Enabled = True

        btnexit.Enabled = True

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtissue_no.Text = ""
        DateTimePicker1.Text = ""
        Combo_mem_id.Text = ""
        txtmem_name.Text = ""
        Combo_bk_acce_no.Text = ""
        txtbk_name.Text = ""
        txtauthor.Text = ""
        txtremark.Text = ""


        btnsave.Enabled = False
        btncancel.Enabled = False


        btnprint.Enabled = True

        btnnew.Enabled = True
        btnreport.Enabled = True

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

    Private Sub Combo_mem_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_mem_id.SelectedIndexChanged
        cmd = New OleDbCommand("select member_name from member_master where member_id = " & Combo_mem_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtmem_name.Text = rdr.Item(0).ToString
           
        End If


    End Sub

    Private Sub Combo_bk_acce_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_bk_acce_no.SelectedIndexChanged
        cmd = New OleDbCommand("select book_name,author from book_accetion where accetion_no = " & Combo_bk_acce_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtbk_name.Text = rdr.Item(0).ToString

            txtauthor.Text = rdr.Item(1).ToString

            
        End If


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class