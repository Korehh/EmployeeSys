<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtempno = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.cmbposition = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee No:"
        '
        'txtempno
        '
        Me.txtempno.Location = New System.Drawing.Point(118, 59)
        Me.txtempno.Name = "txtempno"
        Me.txtempno.Size = New System.Drawing.Size(73, 20)
        Me.txtempno.TabIndex = 1
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(41, 117)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(148, 20)
        Me.txtlastname.TabIndex = 2
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(195, 117)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(190, 20)
        Me.txtfirstname.TabIndex = 3
        '
        'txtmi
        '
        Me.txtmi.Location = New System.Drawing.Point(391, 117)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(29, 20)
        Me.txtmi.TabIndex = 4
        '
        'lv1
        '
        Me.lv1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv1.FullRowSelect = True
        Me.lv1.HideSelection = False
        Me.lv1.Location = New System.Drawing.Point(42, 256)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(372, 264)
        Me.lv1.TabIndex = 5
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'cmbgender
        '
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbgender.Location = New System.Drawing.Point(42, 229)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(82, 21)
        Me.cmbgender.TabIndex = 6
        '
        'cmbposition
        '
        Me.cmbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbposition.FormattingEnabled = True
        Me.cmbposition.Items.AddRange(New Object() {"CEO", "Manager", "Co. Manager"})
        Me.cmbposition.Location = New System.Drawing.Point(293, 228)
        Me.cmbposition.Name = "cmbposition"
        Me.cmbposition.Size = New System.Drawing.Size(121, 21)
        Me.cmbposition.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MI:"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(130, 229)
        Me.txtcontact.MaxLength = 11
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(157, 20)
        Me.txtcontact.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Position:"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(141, 538)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 17
        Me.cmdsave.Text = "ADD NEW"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 538)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(413, 538)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(60, 23)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(42, 168)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(378, 20)
        Me.txtaddress.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 573)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbposition)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtempno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtmi As TextBox
    Friend WithEvents lv1 As ListView
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents cmbposition As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdsave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtempno As TextBox
End Class
