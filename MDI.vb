Public Class MDI

    Private Sub SupplyerMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplyerMasterToolStripMenuItem.Click
        frm_supp_master.MdiParent = Me
        frm_supp_master.Show()
    End Sub

    Private Sub MemberMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberMasterToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub BookMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookMasterToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()

    End Sub

    Private Sub OrderMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderMasterToolStripMenuItem.Click
        frmOrderForm.MdiParent = Me
        frmOrderForm.Show()
    End Sub

    Private Sub BookIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookIssueToolStripMenuItem.Click
        frmbook_issue.MdiParent = Me
        frmbook_issue.Show()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReturnToolStripMenuItem.Click
        frmbook_return.MdiParent = Me
        frmbook_return.Show()
    End Sub

    Private Sub BookAccesstionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookAccesstionToolStripMenuItem.Click
        book_accesstion.MdiParent = Me
        book_accesstion.Show()
    End Sub

    Private Sub BookDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookDeliveryToolStripMenuItem.Click
        frmbook_delivery.MdiParent = Me
        frmbook_delivery.Show()
    End Sub

    Private Sub MemberReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberReportToolStripMenuItem.Click
        frmrptmember_master.MdiParent = Me
        frmrptmember_master.Show()
    End Sub

    Private Sub BookReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReportToolStripMenuItem.Click
        frmrptbook_master.MdiParent = Me
        frmrptbook_master.Show()
    End Sub

    Private Sub SupplyerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplyerReportToolStripMenuItem.Click
        frmrpt_supplyer_detail.MdiParent = Me
        frmrpt_supplyer_detail.Show()
    End Sub

    Private Sub OrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderReportToolStripMenuItem.Click
        frm_rpt_book_order.MdiParent = Me
        frm_rpt_book_order.Show()
    End Sub

    Private Sub BookIssueReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookIssueReportToolStripMenuItem.Click
        frm_rpt_book_issue.MdiParent = Me
        frm_rpt_book_issue.Show()
    End Sub

    Private Sub BookReturnReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReturnReportToolStripMenuItem.Click
        frm_rpt_book_return.MdiParent = Me
        frm_rpt_book_return.Show()
    End Sub

    Private Sub BookAccesstionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookAccesstionReportToolStripMenuItem.Click
        frm_rpt_book_acce.MdiParent = Me
        frm_rpt_book_acce.Show()
    End Sub

    Private Sub DeliveryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryReportToolStripMenuItem.Click
        frm_rpt_book_delivery.MdiParent = Me
        frm_rpt_book_delivery.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub YesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToolStripMenuItem.Click
        End
    End Sub
End Class