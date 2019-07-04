<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_supp_master
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnfind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtstate = New System.Windows.Forms.TextBox
        Me.txtpin = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdistrict = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtsuppname = New System.Windows.Forms.TextBox
        Me.txtsuppid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcontperson = New System.Windows.Forms.TextBox
        Me.txtcontno = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(210, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier Master"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(354, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-mail"
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(96, 435)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 16
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(192, 435)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 17
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Blue
        Me.btnupdate.Location = New System.Drawing.Point(291, 435)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 36)
        Me.btnupdate.TabIndex = 18
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Blue
        Me.btndelete.Location = New System.Drawing.Point(387, 435)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 36)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Deiete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(483, 435)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfirst.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Blue
        Me.btnfirst.Location = New System.Drawing.Point(96, 480)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 33)
        Me.btnfirst.TabIndex = 21
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.Color.Blue
        Me.btnprev.Location = New System.Drawing.Point(192, 480)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(90, 33)
        Me.btnprev.TabIndex = 22
        Me.btnprev.Text = "<<<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnext.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Blue
        Me.btnnext.Location = New System.Drawing.Point(291, 480)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 33)
        Me.btnnext.TabIndex = 23
        Me.btnnext.Text = ">>>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlast.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.Blue
        Me.btnlast.Location = New System.Drawing.Point(387, 480)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(90, 33)
        Me.btnlast.TabIndex = 24
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.ForeColor = System.Drawing.Color.Blue
        Me.btnfind.Location = New System.Drawing.Point(483, 480)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(90, 33)
        Me.btnfind.TabIndex = 25
        Me.btnfind.Text = "Exit"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtstate)
        Me.GroupBox1.Controls.Add(Me.txtpin)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdistrict)
        Me.GroupBox1.Controls.Add(Me.txtcity)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtsuppname)
        Me.GroupBox1.Controls.Add(Me.txtsuppid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 256)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Detail"
        '
        'txtstate
        '
        Me.txtstate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstate.Location = New System.Drawing.Point(419, 227)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(100, 21)
        Me.txtstate.TabIndex = 49
        '
        'txtpin
        '
        Me.txtpin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpin.Location = New System.Drawing.Point(419, 190)
        Me.txtpin.MaxLength = 6
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(100, 21)
        Me.txtpin.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(77, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "District"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(346, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Pin"
        '
        'txtdistrict
        '
        Me.txtdistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdistrict.Location = New System.Drawing.Point(204, 227)
        Me.txtdistrict.Name = "txtdistrict"
        Me.txtdistrict.Size = New System.Drawing.Size(100, 21)
        Me.txtdistrict.TabIndex = 45
        '
        'txtcity
        '
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcity.Location = New System.Drawing.Point(204, 190)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(100, 21)
        Me.txtcity.TabIndex = 44
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(204, 94)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(315, 78)
        Me.txtaddress.TabIndex = 43
        '
        'txtsuppname
        '
        Me.txtsuppname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsuppname.Location = New System.Drawing.Point(204, 57)
        Me.txtsuppname.Name = "txtsuppname"
        Me.txtsuppname.Size = New System.Drawing.Size(315, 21)
        Me.txtsuppname.TabIndex = 42
        '
        'txtsuppid
        '
        Me.txtsuppid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsuppid.Location = New System.Drawing.Point(204, 22)
        Me.txtsuppid.Name = "txtsuppid"
        Me.txtsuppid.ReadOnly = True
        Me.txtsuppid.Size = New System.Drawing.Size(100, 21)
        Me.txtsuppid.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Supplier Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Supplier Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtcontperson)
        Me.GroupBox2.Controls.Add(Me.txtcontno)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(54, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 113)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Detail"
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Location = New System.Drawing.Point(204, 82)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(315, 21)
        Me.txtemail.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Contact Person"
        '
        'txtcontperson
        '
        Me.txtcontperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontperson.Location = New System.Drawing.Point(204, 53)
        Me.txtcontperson.Name = "txtcontperson"
        Me.txtcontperson.Size = New System.Drawing.Size(315, 21)
        Me.txtcontperson.TabIndex = 18
        '
        'txtcontno
        '
        Me.txtcontno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontno.Location = New System.Drawing.Point(204, 22)
        Me.txtcontno.MaxLength = 15
        Me.txtcontno.Name = "txtcontno"
        Me.txtcontno.Size = New System.Drawing.Size(157, 21)
        Me.txtcontno.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "E-mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Contact No."
        '
        'frm_supp_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(630, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frm_supp_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "supplier_master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdistrict As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtsuppname As System.Windows.Forms.TextBox
    Friend WithEvents txtsuppid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcontperson As System.Windows.Forms.TextBox
    Friend WithEvents txtcontno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox

End Class
