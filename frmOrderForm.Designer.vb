<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtnet_pay = New System.Windows.Forms.TextBox
        Me.txt_discont = New System.Windows.Forms.TextBox
        Me.txt_bill_amt = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Sr_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.auther = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.publisher = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.edition = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Combo_bk_id = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbSID = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.txt_bk_price = New System.Windows.Forms.TextBox
        Me.txt_bk_edition = New System.Windows.Forms.TextBox
        Me.txt_bk_publisher = New System.Windows.Forms.TextBox
        Me.txt_bk_auther = New System.Windows.Forms.TextBox
        Me.txt_bk_type = New System.Windows.Forms.TextBox
        Me.txt_s_name = New System.Windows.Forms.TextBox
        Me.txt_bk_name = New System.Windows.Forms.TextBox
        Me.txtorder_no = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(386, 469)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 67
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(271, 469)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 64
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.Blue
        Me.btnprint.Location = New System.Drawing.Point(472, 469)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(51, 33)
        Me.btnprint.TabIndex = 71
        Me.btnprint.Text = "Print Order"
        Me.btnprint.UseVisualStyleBackColor = True
        Me.btnprint.Visible = False
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(151, 469)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 63
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreport.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.Blue
        Me.btnreport.Location = New System.Drawing.Point(529, 469)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(90, 33)
        Me.btnreport.TabIndex = 72
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 19)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Book Order Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnet_pay)
        Me.GroupBox1.Controls.Add(Me.txt_discont)
        Me.GroupBox1.Controls.Add(Me.txt_bill_amt)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Combo_bk_id)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbSID)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtquantity)
        Me.GroupBox1.Controls.Add(Me.txt_bk_price)
        Me.GroupBox1.Controls.Add(Me.txt_bk_edition)
        Me.GroupBox1.Controls.Add(Me.txt_bk_publisher)
        Me.GroupBox1.Controls.Add(Me.txt_bk_auther)
        Me.GroupBox1.Controls.Add(Me.txt_bk_type)
        Me.GroupBox1.Controls.Add(Me.txt_s_name)
        Me.GroupBox1.Controls.Add(Me.txt_bk_name)
        Me.GroupBox1.Controls.Add(Me.txtorder_no)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 422)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Order Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(641, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Net Payble"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Bill Amt"
        '
        'txtnet_pay
        '
        Me.txtnet_pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnet_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnet_pay.Location = New System.Drawing.Point(758, 376)
        Me.txtnet_pay.MaxLength = 6
        Me.txtnet_pay.Name = "txtnet_pay"
        Me.txtnet_pay.Size = New System.Drawing.Size(100, 21)
        Me.txtnet_pay.TabIndex = 131
        '
        'txt_discont
        '
        Me.txt_discont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_discont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discont.Location = New System.Drawing.Point(456, 376)
        Me.txt_discont.MaxLength = 6
        Me.txt_discont.Name = "txt_discont"
        Me.txt_discont.Size = New System.Drawing.Size(100, 21)
        Me.txt_discont.TabIndex = 130
        '
        'txt_bill_amt
        '
        Me.txt_bill_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bill_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bill_amt.Location = New System.Drawing.Point(135, 376)
        Me.txt_bill_amt.MaxLength = 6
        Me.txt_bill_amt.Name = "txt_bill_amt"
        Me.txt_bill_amt.Size = New System.Drawing.Size(100, 21)
        Me.txt_bill_amt.TabIndex = 132
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr_no, Me.book_id, Me.bname, Me.type, Me.auther, Me.publisher, Me.edition, Me.price, Me.quantity, Me.amt})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(883, 165)
        Me.DataGridView1.TabIndex = 129
        '
        'Sr_no
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sr_no.DefaultCellStyle = DataGridViewCellStyle3
        Me.Sr_no.HeaderText = "No."
        Me.Sr_no.Name = "Sr_no"
        Me.Sr_no.Width = 40
        '
        'book_id
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.book_id.DefaultCellStyle = DataGridViewCellStyle4
        Me.book_id.HeaderText = "B Id"
        Me.book_id.Name = "book_id"
        Me.book_id.Width = 70
        '
        'bname
        '
        Me.bname.HeaderText = "Name"
        Me.bname.Name = "bname"
        Me.bname.Width = 180
        '
        'type
        '
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        '
        'auther
        '
        Me.auther.HeaderText = "Auther"
        Me.auther.Name = "auther"
        '
        'publisher
        '
        Me.publisher.HeaderText = "Publisher"
        Me.publisher.Name = "publisher"
        '
        'edition
        '
        Me.edition.HeaderText = "Edition"
        Me.edition.Name = "edition"
        Me.edition.Width = 70
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.Width = 60
        '
        'quantity
        '
        Me.quantity.HeaderText = "Qty."
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 50
        '
        'amt
        '
        Me.amt.HeaderText = "Amt"
        Me.amt.Name = "amt"
        Me.amt.Width = 70
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(824, 143)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 28)
        Me.btnAdd.TabIndex = 128
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Combo_bk_id
        '
        Me.Combo_bk_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_bk_id.FormattingEnabled = True
        Me.Combo_bk_id.Location = New System.Drawing.Point(12, 114)
        Me.Combo_bk_id.Name = "Combo_bk_id"
        Me.Combo_bk_id.Size = New System.Drawing.Size(58, 23)
        Me.Combo_bk_id.TabIndex = 127
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(664, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 16)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "Amt"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(495, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 16)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Qty"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(830, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 119
        Me.Label17.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(721, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 16)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Edition"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(578, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 125
        Me.Label15.Text = "Publisher"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(414, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Auther"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(271, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "BookID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(508, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "S Name"
        '
        'cmbSID
        '
        Me.cmbSID.FormattingEnabled = True
        Me.cmbSID.Location = New System.Drawing.Point(407, 26)
        Me.cmbSID.Name = "cmbSID"
        Me.cmbSID.Size = New System.Drawing.Size(80, 23)
        Me.cmbSID.TabIndex = 116
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(228, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 22)
        Me.DateTimePicker1.TabIndex = 115
        '
        'txtamount
        '
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(709, 148)
        Me.txtamount.MaxLength = 6
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(83, 21)
        Me.txtamount.TabIndex = 108
        '
        'txtquantity
        '
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(542, 148)
        Me.txtquantity.MaxLength = 6
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 21)
        Me.txtquantity.TabIndex = 109
        '
        'txt_bk_price
        '
        Me.txt_bk_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_price.Location = New System.Drawing.Point(804, 114)
        Me.txt_bk_price.Name = "txt_bk_price"
        Me.txt_bk_price.ReadOnly = True
        Me.txt_bk_price.Size = New System.Drawing.Size(91, 21)
        Me.txt_bk_price.TabIndex = 107
        '
        'txt_bk_edition
        '
        Me.txt_bk_edition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_edition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_edition.Location = New System.Drawing.Point(706, 114)
        Me.txt_bk_edition.Name = "txt_bk_edition"
        Me.txt_bk_edition.ReadOnly = True
        Me.txt_bk_edition.Size = New System.Drawing.Size(83, 21)
        Me.txt_bk_edition.TabIndex = 105
        '
        'txt_bk_publisher
        '
        Me.txt_bk_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_publisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_publisher.Location = New System.Drawing.Point(532, 114)
        Me.txt_bk_publisher.Name = "txt_bk_publisher"
        Me.txt_bk_publisher.ReadOnly = True
        Me.txt_bk_publisher.Size = New System.Drawing.Size(158, 21)
        Me.txt_bk_publisher.TabIndex = 106
        '
        'txt_bk_auther
        '
        Me.txt_bk_auther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_auther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_auther.Location = New System.Drawing.Point(356, 114)
        Me.txt_bk_auther.Name = "txt_bk_auther"
        Me.txt_bk_auther.ReadOnly = True
        Me.txt_bk_auther.Size = New System.Drawing.Size(161, 21)
        Me.txt_bk_auther.TabIndex = 112
        '
        'txt_bk_type
        '
        Me.txt_bk_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_type.Location = New System.Drawing.Point(239, 114)
        Me.txt_bk_type.Name = "txt_bk_type"
        Me.txt_bk_type.ReadOnly = True
        Me.txt_bk_type.Size = New System.Drawing.Size(100, 21)
        Me.txt_bk_type.TabIndex = 113
        '
        'txt_s_name
        '
        Me.txt_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_s_name.Location = New System.Drawing.Point(574, 23)
        Me.txt_s_name.Name = "txt_s_name"
        Me.txt_s_name.Size = New System.Drawing.Size(315, 21)
        Me.txt_s_name.TabIndex = 114
        '
        'txt_bk_name
        '
        Me.txt_bk_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bk_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bk_name.Location = New System.Drawing.Point(78, 114)
        Me.txt_bk_name.Name = "txt_bk_name"
        Me.txt_bk_name.ReadOnly = True
        Me.txt_bk_name.Size = New System.Drawing.Size(149, 21)
        Me.txt_bk_name.TabIndex = 110
        '
        'txtorder_no
        '
        Me.txtorder_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorder_no.Location = New System.Drawing.Point(78, 25)
        Me.txtorder_no.Name = "txtorder_no"
        Me.txtorder_no.ReadOnly = True
        Me.txtorder_no.Size = New System.Drawing.Size(87, 21)
        Me.txtorder_no.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "S. ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "O No."
        '
        'btnexit
        '
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Blue
        Me.btnexit.Location = New System.Drawing.Point(640, 469)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 33)
        Me.btnexit.TabIndex = 74
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 517)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Order Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnet_pay As System.Windows.Forms.TextBox
    Friend WithEvents txt_discont As System.Windows.Forms.TextBox
    Friend WithEvents txt_bill_amt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Combo_bk_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSID As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_edition As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_publisher As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_auther As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_s_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_bk_name As System.Windows.Forms.TextBox
    Friend WithEvents txtorder_no As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Sr_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents auther As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents publisher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
