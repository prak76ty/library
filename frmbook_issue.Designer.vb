<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbook_issue
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Combo_bk_acce_no = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Combo_mem_id = New System.Windows.Forms.ComboBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.txtauthor = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtbk_name = New System.Windows.Forms.TextBox
        Me.txtmem_name = New System.Windows.Forms.TextBox
        Me.txtissue_no = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(298, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Book Issue"
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(323, 446)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 61
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.Blue
        Me.btnprint.Location = New System.Drawing.Point(526, 446)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(45, 36)
        Me.btnprint.TabIndex = 60
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        Me.btnprint.Visible = False
        '
        'btnreport
        '
        Me.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreport.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.Blue
        Me.btnreport.Location = New System.Drawing.Point(444, 446)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(90, 36)
        Me.btnreport.TabIndex = 59
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(209, 446)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 58
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(86, 446)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 57
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Blue
        Me.btnexit.Location = New System.Drawing.Point(580, 446)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 36)
        Me.btnexit.TabIndex = 62
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Combo_bk_acce_no)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Combo_mem_id)
        Me.GroupBox1.Controls.Add(Me.txtremark)
        Me.GroupBox1.Controls.Add(Me.txtauthor)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtbk_name)
        Me.GroupBox1.Controls.Add(Me.txtmem_name)
        Me.GroupBox1.Controls.Add(Me.txtissue_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 368)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Issue Detail"
        '
        'Combo_bk_acce_no
        '
        Me.Combo_bk_acce_no.FormattingEnabled = True
        Me.Combo_bk_acce_no.Location = New System.Drawing.Point(192, 166)
        Me.Combo_bk_acce_no.Name = "Combo_bk_acce_no"
        Me.Combo_bk_acce_no.Size = New System.Drawing.Size(315, 23)
        Me.Combo_bk_acce_no.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(478, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 21)
        Me.DateTimePicker1.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Book Issue Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Book Issue No"
        '
        'Combo_mem_id
        '
        Me.Combo_mem_id.FormattingEnabled = True
        Me.Combo_mem_id.Location = New System.Drawing.Point(192, 91)
        Me.Combo_mem_id.Name = "Combo_mem_id"
        Me.Combo_mem_id.Size = New System.Drawing.Size(315, 23)
        Me.Combo_mem_id.TabIndex = 52
        '
        'txtremark
        '
        Me.txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremark.Location = New System.Drawing.Point(192, 286)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(131, 21)
        Me.txtremark.TabIndex = 49
        '
        'txtauthor
        '
        Me.txtauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauthor.Location = New System.Drawing.Point(192, 246)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(131, 21)
        Me.txtauthor.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Author"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Book Name"
        '
        'txtbk_name
        '
        Me.txtbk_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_name.Location = New System.Drawing.Point(192, 206)
        Me.txtbk_name.Name = "txtbk_name"
        Me.txtbk_name.Size = New System.Drawing.Size(315, 21)
        Me.txtbk_name.TabIndex = 45
        '
        'txtmem_name
        '
        Me.txtmem_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmem_name.Location = New System.Drawing.Point(192, 130)
        Me.txtmem_name.Name = "txtmem_name"
        Me.txtmem_name.Size = New System.Drawing.Size(315, 21)
        Me.txtmem_name.TabIndex = 42
        '
        'txtissue_no
        '
        Me.txtissue_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtissue_no.Location = New System.Drawing.Point(192, 53)
        Me.txtissue_no.Name = "txtissue_no"
        Me.txtissue_no.Size = New System.Drawing.Size(100, 21)
        Me.txtissue_no.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Remark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Book Accessation No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Member Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Member Id"
        '
        'frmbook_issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 520)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmbook_issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmbook_issue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_bk_acce_no As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Combo_mem_id As System.Windows.Forms.ComboBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtbk_name As System.Windows.Forms.TextBox
    Friend WithEvents txtmem_name As System.Windows.Forms.TextBox
    Friend WithEvents txtissue_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
