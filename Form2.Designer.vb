<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Combobktype = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.txtpages = New System.Windows.Forms.TextBox
        Me.txtedition = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtpublisher = New System.Windows.Forms.TextBox
        Me.txtauther = New System.Windows.Forms.TextBox
        Me.txtbk_name = New System.Windows.Forms.TextBox
        Me.txtbk_id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnfind = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Combobktype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtpages)
        Me.GroupBox1.Controls.Add(Me.txtedition)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtpublisher)
        Me.GroupBox1.Controls.Add(Me.txtauther)
        Me.GroupBox1.Controls.Add(Me.txtbk_name)
        Me.GroupBox1.Controls.Add(Me.txtbk_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(60, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 353)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Detail"
        '
        'Combobktype
        '
        Me.Combobktype.FormattingEnabled = True
        Me.Combobktype.Items.AddRange(New Object() {"Book", "Novel", "Notes", "News paper"})
        Me.Combobktype.Location = New System.Drawing.Point(204, 104)
        Me.Combobktype.Name = "Combobktype"
        Me.Combobktype.Size = New System.Drawing.Size(315, 23)
        Me.Combobktype.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Price"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Location = New System.Drawing.Point(204, 308)
        Me.txtprice.MaxLength = 4
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 21)
        Me.txtprice.TabIndex = 50
        '
        'txtpages
        '
        Me.txtpages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpages.Location = New System.Drawing.Point(204, 265)
        Me.txtpages.MaxLength = 4
        Me.txtpages.Name = "txtpages"
        Me.txtpages.Size = New System.Drawing.Size(100, 21)
        Me.txtpages.TabIndex = 49
        '
        'txtedition
        '
        Me.txtedition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtedition.Location = New System.Drawing.Point(204, 225)
        Me.txtedition.Name = "txtedition"
        Me.txtedition.Size = New System.Drawing.Size(100, 21)
        Me.txtedition.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(80, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Publisher"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(80, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Edition"
        '
        'txtpublisher
        '
        Me.txtpublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpublisher.Location = New System.Drawing.Point(204, 185)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(315, 21)
        Me.txtpublisher.TabIndex = 45
        '
        'txtauther
        '
        Me.txtauther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauther.Location = New System.Drawing.Point(204, 145)
        Me.txtauther.Name = "txtauther"
        Me.txtauther.Size = New System.Drawing.Size(315, 21)
        Me.txtauther.TabIndex = 44
        '
        'txtbk_name
        '
        Me.txtbk_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_name.Location = New System.Drawing.Point(204, 67)
        Me.txtbk_name.Name = "txtbk_name"
        Me.txtbk_name.Size = New System.Drawing.Size(315, 21)
        Me.txtbk_name.TabIndex = 42
        '
        'txtbk_id
        '
        Me.txtbk_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbk_id.Location = New System.Drawing.Point(204, 27)
        Me.txtbk_id.Name = "txtbk_id"
        Me.txtbk_id.ReadOnly = True
        Me.txtbk_id.Size = New System.Drawing.Size(100, 21)
        Me.txtbk_id.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Pages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Book Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Book Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Book Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(234, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Book Master"
        '
        'btnfind
        '
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.ForeColor = System.Drawing.Color.Blue
        Me.btnfind.Location = New System.Drawing.Point(499, 457)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(90, 33)
        Me.btnfind.TabIndex = 60
        Me.btnfind.Text = "Exit"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlast.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.Blue
        Me.btnlast.Location = New System.Drawing.Point(403, 457)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(90, 33)
        Me.btnlast.TabIndex = 59
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnext.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Blue
        Me.btnnext.Location = New System.Drawing.Point(307, 457)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 33)
        Me.btnnext.TabIndex = 58
        Me.btnnext.Text = ">>>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.Color.Blue
        Me.btnprev.Location = New System.Drawing.Point(208, 457)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(90, 33)
        Me.btnprev.TabIndex = 57
        Me.btnprev.Text = "<<<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfirst.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Blue
        Me.btnfirst.Location = New System.Drawing.Point(112, 457)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(90, 33)
        Me.btnfirst.TabIndex = 56
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Blue
        Me.btncancel.Location = New System.Drawing.Point(499, 412)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 36)
        Me.btncancel.TabIndex = 55
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Blue
        Me.btndelete.Location = New System.Drawing.Point(403, 412)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 36)
        Me.btndelete.TabIndex = 54
        Me.btndelete.Text = "Deiete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Blue
        Me.btnupdate.Location = New System.Drawing.Point(307, 412)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 36)
        Me.btnupdate.TabIndex = 53
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.Location = New System.Drawing.Point(208, 412)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.TabIndex = 52
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Blue
        Me.btnnew.Location = New System.Drawing.Point(112, 412)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(90, 36)
        Me.btnnew.TabIndex = 51
        Me.btnnew.Text = "Add New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 511)
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpages As System.Windows.Forms.TextBox
    Friend WithEvents txtedition As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtauther As System.Windows.Forms.TextBox
    Friend WithEvents txtbk_name As System.Windows.Forms.TextBox
    Friend WithEvents txtbk_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Combobktype As System.Windows.Forms.ComboBox
End Class
