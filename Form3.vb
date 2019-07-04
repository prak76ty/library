Imports System.Data.OleDb
Imports System.Data

Public Class Form3
    Dim ss As String
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from member_master", conn)
        ds = New DataSet
        da.Fill(ds, "member_master")


    End Sub
    Private Sub clear()
        txtmemid.Text = ""
        txtmemname.Text = ""
        Combogender.Text = ""
        txtaddress.Text = ""
        txtpin.Text = ""
        txtemail.Text = ""
        txtroll.Text = ""
        txtcity.Text = ""
        txtclass.Text = ""
        txtstate.Text = ""
        txtcontact.Text = ""
        txtdist.Text = ""
        combomemtype.Text = ""
    End Sub
    Private Sub meminfo()
        txtmemid.Text = ds.Tables("member_master").Rows(recno).Item(0)
        combomemtype.Text = ds.Tables("member_master").Rows(recno).Item(1)
        txtmemname.Text = ds.Tables("member_master").Rows(recno).Item(2)
        Combogender.Text = ds.Tables("member_master").Rows(recno).Item(3)
        txtroll.Text = ds.Tables("member_master").Rows(recno).Item(4)
        txtclass.Text = ds.Tables("member_master").Rows(recno).Item(5)
        txtaddress.Text = ds.Tables("member_master").Rows(recno).Item(6)
        txtcity.Text = ds.Tables("member_master").Rows(recno).Item(7)
        txtdist.Text = ds.Tables("member_master").Rows(recno).Item(8)
        txtstate.Text = ds.Tables("member_master").Rows(recno).Item(9)
        txtpin.Text = ds.Tables("member_master").Rows(recno).Item(10)
        txtcontact.Text = ds.Tables("member_master").Rows(recno).Item(11)
        txtemail.Text = ds.Tables("member_master").Rows(recno).Item(12)

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(member_id) from member_master", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtmemid.Text = temp.ToString
        txtmemname.Text = ""
        Combogender.Text = ""
        txtaddress.Text = ""
        txtpin.Text = ""
        txtemail.Text = ""
        txtroll.Text = ""
        txtcity.Text = ""
        txtclass.Text = ""
        txtstate.Text = ""
        txtcontact.Text = ""
        txtdist.Text = ""
        combomemtype.Text = ""

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
        If (combomemtype.Text = "") Then
            MessageBox.Show("fill the member type")
            Exit Sub
        End If
        If (txtmemname.Text = "") Then
            MessageBox.Show("fill the member name")
            Exit Sub
        End If
        If (Combogender.Text = "") Then
            MessageBox.Show("fill the gender")
            Exit Sub
        End If
        If (txtroll.Text = "") Then
            MessageBox.Show("fill the roll number")
            Exit Sub
        End If
        If (txtclass.Text = "") Then
            MessageBox.Show("fill the class")
            Exit Sub
        End If
        If (txtaddress.Text = "") Then
            MessageBox.Show("fill the address")
            Exit Sub
        End If
        If (txtcity.Text = "") Then
            MessageBox.Show("fill the city")
            Exit Sub
        End If
        If (txtdist.Text = "") Then
            MessageBox.Show("fill the district")
            Exit Sub
        End If
        If (txtstate.Text = "") Then
            MessageBox.Show("fill the state")
            Exit Sub
        End If
        If (txtpin.Text = "") Then
            MessageBox.Show("fill the pin")
            Exit Sub
        End If
        If (txtcontact.Text = "") Then
            MessageBox.Show("fill the contact number")
            Exit Sub
        End If
        If (txtemail.Text = "") Then
            MessageBox.Show("fill the email")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into member_master values(" & txtmemid.Text & ",'" & combomemtype.Text & "','" & txtmemname.Text & "','" & Combogender.Text & "'," & txtroll.Text & ",'" & txtclass.Text & "','" & txtaddress.Text & "','" & txtcity.Text & "','" & txtdist.Text & "','" & txtstate.Text & "'," & txtpin.Text & "," & txtcontact.Text & ",'" & txtemail.Text & "')", conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("saved sccessfully")
        Form3_Load(sender, e)

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
        txtmemid.Text = ""
        txtmemname.Text = ""
        Combogender.Text = ""
        txtaddress.Text = ""
        txtpin.Text = ""
        txtemail.Text = ""
        txtroll.Text = ""
        txtcity.Text = ""
        txtclass.Text = ""
        txtstate.Text = ""
        txtcontact.Text = ""
        txtdist.Text = ""
        combomemtype.Text = ""

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

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        recno = 0
        meminfo()

    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        recno = ds.Tables("member_master").Rows.Count - 1
        meminfo()

    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("member_master").Rows.Count) Then
            meminfo()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("member_master").Rows.Count) Then
            meminfo()
        Else
            MessageBox.Show("last record")

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        ss = "update member_master set member_type='" & combomemtype.Text & "' ,member_name='" & txtmemname.Text & "' ,gender='" & Combogender.Text & "',roll_no=" & txtroll.Text & ",class='" & txtclass.Text & "',address='" & txtaddress.Text & "',city='" & txtcity.Text & "',district='" & txtdist.Text & "',state='" & txtstate.Text & "',pin=" & txtpin.Text & ",contact_no=" & txtcontact.Text & ",email='" & txtemail.Text & "'  where member_id=" & txtmemid.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated Sucessfully!!!")
        Form3_Load(sender, e)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ss = "delete from member_master where member_id=" & txtmemid.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted Sucessfully!!!")
        Call clear()




        Form3_Load(sender, e)
    End Sub

    Private Sub txtmemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmemname.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtmemname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmemname.TextChanged

    End Sub

    Private Sub txtroll_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtroll.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtroll_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtroll.TextChanged

    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub txtdist_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdist.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtdist_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdist.TextChanged

    End Sub

    Private Sub txtstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstate.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtstate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstate.TextChanged

    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Me.Close()
    End Sub
End Class