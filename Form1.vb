Imports System.Data.OleDb
Imports System.Data


Public Class frm_supp_master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Dim ss As String


    Private Sub frm_supp_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConneDB()
        btnsave.Enabled = False
        btncancel.Enabled = False

        da = New OleDbDataAdapter("select * from supplyer_master", conn)
        ds = New DataSet
        da.Fill(ds, "supplyer_master")
    End Sub
    Private Sub clear()
        txtsuppid.Text = ""
        txtsuppname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtdistrict.Text = ""
        txtstate.Text = ""
        txtpin.Text = ""
        txtcontno.Text = ""
        txtemail.Text = ""
        txtcontperson.Text = ""

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(supplyer_id) from supplyer_master", conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txtsuppid.Text = temp.ToString
        txtsuppname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtdistrict.Text = ""
        txtstate.Text = ""
        txtpin.Text = ""
        txtcontno.Text = ""
        txtemail.Text = ""
        txtcontperson.Text = ""


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
        If (txtsuppname.Text = "") Then
            MessageBox.Show("fill the supplyername")
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
        If (txtdistrict.Text = "") Then
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
        If (txtcontno.Text = "") Then
            MessageBox.Show("fill the pages")
            Exit Sub
        End If
        If (txtemail.Text = "") Then
            MessageBox.Show("fill the email")
            Exit Sub
        End If
        If (txtcontperson.Text = "") Then
            MessageBox.Show("fill the contact person")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into supplyer_master values(" & txtsuppid.Text & ",'" & txtsuppname.Text & "','" & txtaddress.Text & "','" & txtcity.Text & "','" & txtdistrict.Text & "','" & txtstate.Text & "'," & txtpin.Text & "," & txtcontno.Text & ",'" & txtcontperson.Text & "','" & txtemail.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved sccessfully")

        frm_supp_master_Load(sender, e)


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
        txtsuppid.Text = ""
        txtsuppname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtdistrict.Text = ""
        txtstate.Text = ""
        txtpin.Text = ""
        txtcontno.Text = ""
        txtemail.Text = ""
        txtcontperson.Text = ""
        


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
    Private Sub suppinfo()
        txtsuppid.Text = ds.Tables("supplyer_master").Rows(recno).Item(0)
        txtsuppname.Text = ds.Tables("supplyer_master").Rows(recno).Item(1)
        txtaddress.Text = ds.Tables("supplyer_master").Rows(recno).Item(2)
        txtcity.Text = ds.Tables("supplyer_master").Rows(recno).Item(3)
        txtdistrict.Text = ds.Tables("supplyer_master").Rows(recno).Item(4)
        txtstate.Text = ds.Tables("supplyer_master").Rows(recno).Item(5)
        txtpin.Text = ds.Tables("supplyer_master").Rows(recno).Item(6)
        txtcontno.Text = ds.Tables("supplyer_master").Rows(recno).Item(7)
        txtemail.Text = ds.Tables("supplyer_master").Rows(recno).Item(8)
        txtcontperson.Text = ds.Tables("supplyer_master").Rows(recno).Item(9)
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        recno = 0
        suppinfo()
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        recno = ds.Tables("supplyer_master").Rows.Count - 1
        suppinfo()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("supplyer_master").Rows.Count) Then
            suppinfo()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        ss = "update supplyer_master set supplyer_name='" & txtsuppname.Text & "',address='" & txtaddress.Text & "',city='" & txtcity.Text & "',district='" & txtdistrict.Text & "',state='" & txtstate.Text & "',pin=" & txtpin.Text & ",contact_no=" & txtcontno.Text & ",email='" & txtemail.Text & "',contact_person='" & txtcontperson.Text & "'  where supplyer_id=" & txtsuppid.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated Sucessfully!!!")
        frm_supp_master_Load(sender, e)

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ss = "delete from supplyer_master where supplyer_id=" & txtsuppid.Text & ""
        cmd = New OleDbCommand(ss, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted Sucessfully!!!")
        Call clear()
        frm_supp_master_Load(sender, e)

    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("supplyer_master").Rows.Count) Then
            suppinfo()
        Else
            MessageBox.Show("last record")

        End If
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

    Private Sub txtcontno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontno.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            If e.KeyChar = "" Then

                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MessageBox.Show("Only Numbers alloweded")
        End If
    End Sub

    Private Sub txtcontno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontno.TextChanged

    End Sub

    Private Sub txtsuppname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuppname.KeyPress

        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtsuppname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsuppname.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub txtdistrict_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdistrict.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtdistrict_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdistrict.TextChanged

    End Sub

    Private Sub txtstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstate.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtstate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstate.TextChanged

    End Sub

    Private Sub txtcontperson_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontperson.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            MessageBox.Show("Only charecter alloweded")
        End If
    End Sub

    Private Sub txtcontperson_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontperson.TextChanged

    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Me.Close()
    End Sub
End Class