<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book_accesstion
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
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtstatus = New System.Windows.Forms.TextBox
        Me.txtdiscription = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpbk_acc_date = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtbk_acc_no = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Combobk_id = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.txtpages = New System.Windows.Forms.TextBox
        Me.txtedition = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtpublisher = New System.Windows.Forms.TextBox
        Me.txtauther = New System.Windows.Forms.TextBox
        Me.txtbk_name = New System.Windows.Forms.TextBox
        Me.txtbk_type = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.txtdiscription)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpbk_acc_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtbk_acc_no)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Combobk_id)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtpages)
        Me.GroupBox1.Controls.Add(Me.txtedition)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtpublisher)
        Me.GroupBox1.Controls.Add(Me.txtauther)
        Me.GroupBox1.Controls.Add(Me.txtbk_name)
        Me.GroupBox1.Controls.Add(Me.txtbk_type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 366)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Accession Detail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(355, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Status"
        '
        'txtstatus
        '
        Me.txtstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstatus.Location = New System.Drawing.Point(458, 336)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(125, 21)
        Me.txtstatus.TabIndex = 60
        '
        'txtdiscription
        '
        Me.txtdiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscription.Location = New System.Drawing.Point(458, 294)
        Me.txtdiscription.Name = "txtdiscription"
        Me.txtdiscription.Size = New System.Drawing.Size(125, 21)
        Me.txtdiscription.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(355, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Discription"
        '
        'dtpbk_acc_date
        '
        Me.dtpbk_acc_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbk_acc_date.Location = New System.Drawing.Point(458, 25)
        Me.dtpbk_acc_date.Name = "dtpbk_acc_date"
        Me.dtpbk_acc_date.Size = New System.Drawing.Size(125, 21)
        Me.dtpbk_acc_date.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(297, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Book Accession Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Book Id"
        '
        'txtbk_acc_no
        '
        Me.txtbk_acc_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_acc_no.Location = New System.Drawing.Point(172, 27)
        Me.txtbk_acc_no.Name = "txtbk_acc_no"
        Me.txtbk_acc_no.Size = New System.Drawing.Size(100, 21)
        Me.txtbk_acc_no.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Book Accession No"
        '
        'Combobk_id
        '
        Me.Combobk_id.FormattingEnabled = True
        Me.Combobk_id.Location = New System.Drawing.Point(172, 59)
        Me.Combobk_id.Name = "Combobk_id"
        Me.Combobk_id.Size = New System.Drawing.Size(100, 23)
        Me.Combobk_id.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Price"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Location = New System.Drawing.Point(172, 336)
        Me.txtprice.MaxLength = 4
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 21)
        Me.txtprice.TabIndex = 50
        '
        'txtpages
        '
        Me.txtpages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpages.Location = New System.Drawing.Point(172, 293)
        Me.txtpages.MaxLength = 4
        Me.txtpages.Name = "txtpages"
        Me.txtpages.Size = New System.Drawing.Size(100, 21)
        Me.txtpages.TabIndex = 49
        '
        'txtedition
        '
        Me.txtedition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtedition.Location = New System.Drawing.Point(172, 253)
        Me.txtedition.Name = "txtedition"
        Me.txtedition.Size = New System.Drawing.Size(100, 21)
        Me.txtedition.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Publisher"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Edition"
        '
        'txtpublisher
        '
        Me.txtpublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpublisher.Location = New System.Drawing.Point(172, 213)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(315, 21)
        Me.txtpublisher.TabIndex = 45
        '
        'txtauther
        '
        Me.txtauther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauther.Location = New System.Drawing.Point(172, 173)
        Me.txtauther.Name = "txtauther"
        Me.txtauther.Size = New System.Drawing.Size(315, 21)
        Me.txtauther.TabIndex = 44
        '
        'txtbk_name
        '
        Me.txtbk_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_name.Location = New System.Drawing.Point(172, 95)
        Me.txtbk_name.Name = "txtbk_name"
        Me.txtbk_name.Size = New System.Drawing.Size(315, 21)
        Me.txtbk_name.TabIndex = 42
        '
        'txtbk_type
        '
        Me.txtbk_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_type.Location = New System.Drawing.Point(172, 134)
        Me.txtbk_type.Name = "txtbk_type"
        Me.txtbk_type.Size = New System.Drawing.Size(315, 21)
        Me.txtbk_type.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Pages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Book Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Book Accession"
        '
        'btnexit
        '
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Blue
        Me.btnexit.Location = New System.Drawing.Point(463, 414)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 36)
        Me.btnexit.TabIndex = 71
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnext.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Blue
        Me.btnnext.Location = New System.Drawing.Point(354, 457)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 36)
        Me.btnnext.TabIndex = 70
        Me.btnnext.Text = ">>>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.Color.Blue
        Me.btnprev.Location = New System.Drawing.Point(247, 457)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(90, 36)
        Me.btnprev.TabIndex = 69
        Me.btnprev.Text = "<<<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(354, 414)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 68
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlast.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.Blue
        Me.btnlast.Location = New System.Drawing.Point(462, 457)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(90, 36)
        Me.btnlast.TabIndex = 67
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfirst.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Blue
        Me.btnfirst.Location = New System.Drawing.Point(142, 457)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 36)
        Me.btnfirst.TabIndex = 66
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(143, 414)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 64
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(248, 414)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 65
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'book_accesstion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 499)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "book_accesstion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "book_accesstion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtpages As System.Windows.Forms.TextBox
    Friend WithEvents txtedition As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtauther As System.Windows.Forms.TextBox
    Friend WithEvents txtbk_name As System.Windows.Forms.TextBox
    Friend WithEvents txtbk_type As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbk_acc_no As System.Windows.Forms.TextBox
    Friend WithEvents Combobk_id As System.Windows.Forms.ComboBox
    Friend WithEvents dtpbk_acc_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscription As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
