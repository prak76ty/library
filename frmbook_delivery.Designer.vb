<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbook_delivery
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtp_del_date = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtorder_date = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Comboorder_no = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdel_by_whom = New System.Windows.Forms.TextBox
        Me.txtnet_pay = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtbill_amt = New System.Windows.Forms.TextBox
        Me.txtsupp_name = New System.Windows.Forms.TextBox
        Me.txtsupp_id = New System.Windows.Forms.TextBox
        Me.txtdelvery_no = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtremark)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtp_del_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtorder_date)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Comboorder_no)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdel_by_whom)
        Me.GroupBox1.Controls.Add(Me.txtnet_pay)
        Me.GroupBox1.Controls.Add(Me.txtdiscount)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtbill_amt)
        Me.GroupBox1.Controls.Add(Me.txtsupp_name)
        Me.GroupBox1.Controls.Add(Me.txtsupp_id)
        Me.GroupBox1.Controls.Add(Me.txtdelvery_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 374)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Delivery Detail"
        '
        'txtremark
        '
        Me.txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremark.Location = New System.Drawing.Point(477, 336)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(134, 21)
        Me.txtremark.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(340, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Remark"
        '
        'dtp_del_date
        '
        Me.dtp_del_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_del_date.Location = New System.Drawing.Point(477, 25)
        Me.dtp_del_date.Name = "dtp_del_date"
        Me.dtp_del_date.Size = New System.Drawing.Size(134, 21)
        Me.dtp_del_date.TabIndex = 57
        Me.dtp_del_date.Value = New Date(2014, 2, 8, 19, 46, 16, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(340, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Delivery Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Order Date"
        '
        'txtorder_date
        '
        Me.txtorder_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorder_date.Location = New System.Drawing.Point(172, 97)
        Me.txtorder_date.Name = "txtorder_date"
        Me.txtorder_date.ReadOnly = True
        Me.txtorder_date.Size = New System.Drawing.Size(78, 21)
        Me.txtorder_date.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Delivery No"
        '
        'Comboorder_no
        '
        Me.Comboorder_no.FormattingEnabled = True
        Me.Comboorder_no.Location = New System.Drawing.Point(172, 59)
        Me.Comboorder_no.Name = "Comboorder_no"
        Me.Comboorder_no.Size = New System.Drawing.Size(78, 23)
        Me.Comboorder_no.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Delivery By Whom"
        '
        'txtdel_by_whom
        '
        Me.txtdel_by_whom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdel_by_whom.Location = New System.Drawing.Point(172, 336)
        Me.txtdel_by_whom.Name = "txtdel_by_whom"
        Me.txtdel_by_whom.Size = New System.Drawing.Size(143, 21)
        Me.txtdel_by_whom.TabIndex = 50
        '
        'txtnet_pay
        '
        Me.txtnet_pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnet_pay.Location = New System.Drawing.Point(172, 293)
        Me.txtnet_pay.MaxLength = 6
        Me.txtnet_pay.Name = "txtnet_pay"
        Me.txtnet_pay.ReadOnly = True
        Me.txtnet_pay.Size = New System.Drawing.Size(78, 21)
        Me.txtnet_pay.TabIndex = 49
        '
        'txtdiscount
        '
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Location = New System.Drawing.Point(172, 253)
        Me.txtdiscount.MaxLength = 6
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(78, 21)
        Me.txtdiscount.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Bill Amt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Discount"
        '
        'txtbill_amt
        '
        Me.txtbill_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbill_amt.Location = New System.Drawing.Point(172, 213)
        Me.txtbill_amt.MaxLength = 6
        Me.txtbill_amt.Name = "txtbill_amt"
        Me.txtbill_amt.ReadOnly = True
        Me.txtbill_amt.Size = New System.Drawing.Size(78, 21)
        Me.txtbill_amt.TabIndex = 45
        '
        'txtsupp_name
        '
        Me.txtsupp_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupp_name.Location = New System.Drawing.Point(172, 173)
        Me.txtsupp_name.Name = "txtsupp_name"
        Me.txtsupp_name.ReadOnly = True
        Me.txtsupp_name.Size = New System.Drawing.Size(315, 21)
        Me.txtsupp_name.TabIndex = 44
        '
        'txtsupp_id
        '
        Me.txtsupp_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupp_id.Location = New System.Drawing.Point(172, 132)
        Me.txtsupp_id.Name = "txtsupp_id"
        Me.txtsupp_id.ReadOnly = True
        Me.txtsupp_id.Size = New System.Drawing.Size(78, 21)
        Me.txtsupp_id.TabIndex = 42
        '
        'txtdelvery_no
        '
        Me.txtdelvery_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelvery_no.Location = New System.Drawing.Point(172, 27)
        Me.txtdelvery_no.Name = "txtdelvery_no"
        Me.txtdelvery_no.Size = New System.Drawing.Size(78, 21)
        Me.txtdelvery_no.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Net Payble"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Supplyer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Supplyer Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Order No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(246, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "book delivery"
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(366, 420)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 60
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlast.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.Blue
        Me.btnlast.Location = New System.Drawing.Point(474, 463)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(90, 36)
        Me.btnlast.TabIndex = 59
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfirst.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Blue
        Me.btnfirst.Location = New System.Drawing.Point(154, 463)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 36)
        Me.btnfirst.TabIndex = 58
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(260, 420)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 57
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(155, 420)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 56
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnext.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Blue
        Me.btnnext.Location = New System.Drawing.Point(366, 463)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 36)
        Me.btnnext.TabIndex = 62
        Me.btnnext.Text = ">>>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.Color.Blue
        Me.btnprev.Location = New System.Drawing.Point(259, 463)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(90, 36)
        Me.btnprev.TabIndex = 61
        Me.btnprev.Text = "<<<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Blue
        Me.btnexit.Location = New System.Drawing.Point(475, 420)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 36)
        Me.btnexit.TabIndex = 63
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmbook_delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 511)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "frmbook_delivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmbook_delivery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_del_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorder_date As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Comboorder_no As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdel_by_whom As System.Windows.Forms.TextBox
    Friend WithEvents txtnet_pay As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtbill_amt As System.Windows.Forms.TextBox
    Friend WithEvents txtsupp_name As System.Windows.Forms.TextBox
    Friend WithEvents txtsupp_id As System.Windows.Forms.TextBox
    Friend WithEvents txtdelvery_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
