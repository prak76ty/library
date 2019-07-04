<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplyerMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookAccesstionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplyerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookIssueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookReturnReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookAccesstionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterFormToolStripMenuItem, Me.TrToolStripMenuItem, Me.ReportToolStripMenuItem, Me.UtilityToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterFormToolStripMenuItem
        '
        Me.MasterFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberMasterToolStripMenuItem, Me.BookMasterToolStripMenuItem, Me.SupplyerMasterToolStripMenuItem, Me.OrderMasterToolStripMenuItem})
        Me.MasterFormToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterFormToolStripMenuItem.Name = "MasterFormToolStripMenuItem"
        Me.MasterFormToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.MasterFormToolStripMenuItem.Text = "Master Forms"
        '
        'MemberMasterToolStripMenuItem
        '
        Me.MemberMasterToolStripMenuItem.Name = "MemberMasterToolStripMenuItem"
        Me.MemberMasterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MemberMasterToolStripMenuItem.Text = "Member Master"
        '
        'BookMasterToolStripMenuItem
        '
        Me.BookMasterToolStripMenuItem.Name = "BookMasterToolStripMenuItem"
        Me.BookMasterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.BookMasterToolStripMenuItem.Text = "Book Master"
        '
        'SupplyerMasterToolStripMenuItem
        '
        Me.SupplyerMasterToolStripMenuItem.Name = "SupplyerMasterToolStripMenuItem"
        Me.SupplyerMasterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SupplyerMasterToolStripMenuItem.Text = "Supplier Master"
        '
        'OrderMasterToolStripMenuItem
        '
        Me.OrderMasterToolStripMenuItem.Name = "OrderMasterToolStripMenuItem"
        Me.OrderMasterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OrderMasterToolStripMenuItem.Text = "Order Master"
        '
        'TrToolStripMenuItem
        '
        Me.TrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookIssueToolStripMenuItem, Me.BookReturnToolStripMenuItem, Me.BookAccesstionToolStripMenuItem, Me.BookDeliveryToolStripMenuItem})
        Me.TrToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrToolStripMenuItem.Name = "TrToolStripMenuItem"
        Me.TrToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TrToolStripMenuItem.Text = "Transaction Forms"
        '
        'BookIssueToolStripMenuItem
        '
        Me.BookIssueToolStripMenuItem.Name = "BookIssueToolStripMenuItem"
        Me.BookIssueToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BookIssueToolStripMenuItem.Text = "Book Issue"
        '
        'BookReturnToolStripMenuItem
        '
        Me.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem"
        Me.BookReturnToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BookReturnToolStripMenuItem.Text = "Book Return"
        '
        'BookAccesstionToolStripMenuItem
        '
        Me.BookAccesstionToolStripMenuItem.Name = "BookAccesstionToolStripMenuItem"
        Me.BookAccesstionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BookAccesstionToolStripMenuItem.Text = "Book Accesstion"
        '
        'BookDeliveryToolStripMenuItem
        '
        Me.BookDeliveryToolStripMenuItem.Name = "BookDeliveryToolStripMenuItem"
        Me.BookDeliveryToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BookDeliveryToolStripMenuItem.Text = "Book Delivery"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterReportToolStripMenuItem, Me.TransactionReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.ReportToolStripMenuItem.Text = "Reports"
        '
        'MasterReportToolStripMenuItem
        '
        Me.MasterReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberReportToolStripMenuItem, Me.BookReportToolStripMenuItem, Me.SupplyerReportToolStripMenuItem, Me.OrderReportToolStripMenuItem})
        Me.MasterReportToolStripMenuItem.Name = "MasterReportToolStripMenuItem"
        Me.MasterReportToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MasterReportToolStripMenuItem.Text = "Master Reports"
        '
        'MemberReportToolStripMenuItem
        '
        Me.MemberReportToolStripMenuItem.Name = "MemberReportToolStripMenuItem"
        Me.MemberReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MemberReportToolStripMenuItem.Text = "Member Report"
        '
        'BookReportToolStripMenuItem
        '
        Me.BookReportToolStripMenuItem.Name = "BookReportToolStripMenuItem"
        Me.BookReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BookReportToolStripMenuItem.Text = "Book Report"
        '
        'SupplyerReportToolStripMenuItem
        '
        Me.SupplyerReportToolStripMenuItem.Name = "SupplyerReportToolStripMenuItem"
        Me.SupplyerReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SupplyerReportToolStripMenuItem.Text = "Supplyer Report"
        '
        'OrderReportToolStripMenuItem
        '
        Me.OrderReportToolStripMenuItem.Name = "OrderReportToolStripMenuItem"
        Me.OrderReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrderReportToolStripMenuItem.Text = "Order Report"
        '
        'TransactionReportToolStripMenuItem
        '
        Me.TransactionReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookIssueReportToolStripMenuItem, Me.BookReturnReportToolStripMenuItem, Me.BookAccesstionReportToolStripMenuItem, Me.DeliveryReportToolStripMenuItem})
        Me.TransactionReportToolStripMenuItem.Name = "TransactionReportToolStripMenuItem"
        Me.TransactionReportToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TransactionReportToolStripMenuItem.Text = "Transaction Reports"
        '
        'BookIssueReportToolStripMenuItem
        '
        Me.BookIssueReportToolStripMenuItem.Name = "BookIssueReportToolStripMenuItem"
        Me.BookIssueReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BookIssueReportToolStripMenuItem.Text = "Book Issue Report"
        '
        'BookReturnReportToolStripMenuItem
        '
        Me.BookReturnReportToolStripMenuItem.Name = "BookReturnReportToolStripMenuItem"
        Me.BookReturnReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BookReturnReportToolStripMenuItem.Text = "Book Return Report"
        '
        'BookAccesstionReportToolStripMenuItem
        '
        Me.BookAccesstionReportToolStripMenuItem.Name = "BookAccesstionReportToolStripMenuItem"
        Me.BookAccesstionReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BookAccesstionReportToolStripMenuItem.Text = "Book Accesstion Report"
        '
        'DeliveryReportToolStripMenuItem
        '
        Me.DeliveryReportToolStripMenuItem.Name = "DeliveryReportToolStripMenuItem"
        Me.DeliveryReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DeliveryReportToolStripMenuItem.Text = "Delivery Report"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(42, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YesToolStripMenuItem.Text = "Yes"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NoToolStripMenuItem.Text = "No"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 413)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplyerMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookAccesstionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookDeliveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplyerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookIssueReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReturnReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookAccesstionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
