Public Class login

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        If (TextBox1.Text = "1" And TextBox2.Text = "1") Then
            MDI.Show()
            Me.Hide()
        Else
            MessageBox.Show("login failed")
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        End
    End Sub
End Class