<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registry
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
        Me.surnamebox = New System.Windows.Forms.TextBox()
        Me.firstbox = New System.Windows.Forms.TextBox()
        Me.middlebox = New System.Windows.Forms.TextBox()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.householdbox = New System.Windows.Forms.TextBox()
        Me.contactbox = New System.Windows.Forms.TextBox()
        Me.purokbox = New System.Windows.Forms.ComboBox()
        Me.sexbox = New System.Windows.Forms.ComboBox()
        Me.civilstatusbox = New System.Windows.Forms.ComboBox()
        Me.birthdatepicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.householdmember = New System.Windows.Forms.DataGridView()
        Me.SURNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUFFIX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOUSEHOLD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUROK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPATIONSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.save = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.occupationstatusbox = New System.Windows.Forms.ComboBox()
        Me.suffixbox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'surnamebox
        '
        Me.surnamebox.Location = New System.Drawing.Point(45, 36)
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(118, 20)
        Me.surnamebox.TabIndex = 0
        '
        'firstbox
        '
        Me.firstbox.Location = New System.Drawing.Point(190, 36)
        Me.firstbox.Name = "firstbox"
        Me.firstbox.Size = New System.Drawing.Size(118, 20)
        Me.firstbox.TabIndex = 2
        '
        'middlebox
        '
        Me.middlebox.Location = New System.Drawing.Point(331, 36)
        Me.middlebox.Name = "middlebox"
        Me.middlebox.Size = New System.Drawing.Size(118, 20)
        Me.middlebox.TabIndex = 3
        '
        'addressbox
        '
        Me.addressbox.Cursor = System.Windows.Forms.Cursors.No
        Me.addressbox.Location = New System.Drawing.Point(190, 82)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.ReadOnly = True
        Me.addressbox.Size = New System.Drawing.Size(118, 20)
        Me.addressbox.TabIndex = 5
        Me.addressbox.Text = "Brgy. Masapang, Victory, Laguna"
        '
        'householdbox
        '
        Me.householdbox.Location = New System.Drawing.Point(625, 36)
        Me.householdbox.Name = "householdbox"
        Me.householdbox.Size = New System.Drawing.Size(118, 20)
        Me.householdbox.TabIndex = 6
        '
        'contactbox
        '
        Me.contactbox.Location = New System.Drawing.Point(190, 127)
        Me.contactbox.Name = "contactbox"
        Me.contactbox.Size = New System.Drawing.Size(118, 20)
        Me.contactbox.TabIndex = 9
        '
        'purokbox
        '
        Me.purokbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purokbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.purokbox.FormattingEnabled = True
        Me.purokbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.purokbox.Location = New System.Drawing.Point(45, 81)
        Me.purokbox.Name = "purokbox"
        Me.purokbox.Size = New System.Drawing.Size(121, 21)
        Me.purokbox.TabIndex = 11
        '
        'sexbox
        '
        Me.sexbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sexbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(469, 81)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(121, 21)
        Me.sexbox.TabIndex = 12
        '
        'civilstatusbox
        '
        Me.civilstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.civilstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.civilstatusbox.FormattingEnabled = True
        Me.civilstatusbox.Items.AddRange(New Object() {"Single ", "Married ", "Divorced ", "Separated ", "Widowed "})
        Me.civilstatusbox.Location = New System.Drawing.Point(45, 126)
        Me.civilstatusbox.Name = "civilstatusbox"
        Me.civilstatusbox.Size = New System.Drawing.Size(121, 21)
        Me.civilstatusbox.TabIndex = 13
        '
        'birthdatepicker
        '
        Me.birthdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.birthdatepicker.Location = New System.Drawing.Point(331, 82)
        Me.birthdatepicker.Name = "birthdatepicker"
        Me.birthdatepicker.Size = New System.Drawing.Size(118, 20)
        Me.birthdatepicker.TabIndex = 14
        Me.birthdatepicker.Value = New Date(2023, 4, 29, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "first name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "middle name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "suffix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Household ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "purok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "birthdate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(466, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "sex"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(622, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Occupation Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "civil status "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(187, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "contact no."
        '
        'householdmember
        '
        Me.householdmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.householdmember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SURNAME, Me.FIRSTNAME, Me.LASTNAME, Me.SUFFIX, Me.HOUSEHOLD, Me.PUROK, Me.ADDRESS, Me.BIRTHDATE, Me.SEX, Me.OCCUPATIONSTATUS, Me.CIVILSTATUS, Me.CONTACT})
        Me.householdmember.Location = New System.Drawing.Point(45, 209)
        Me.householdmember.Name = "householdmember"
        Me.householdmember.ReadOnly = True
        Me.householdmember.Size = New System.Drawing.Size(489, 203)
        Me.householdmember.TabIndex = 27
        '
        'SURNAME
        '
        Me.SURNAME.HeaderText = "SURNAME"
        Me.SURNAME.Name = "SURNAME"
        Me.SURNAME.ReadOnly = True
        '
        'FIRSTNAME
        '
        Me.FIRSTNAME.HeaderText = "FIRSTNAME"
        Me.FIRSTNAME.Name = "FIRSTNAME"
        Me.FIRSTNAME.ReadOnly = True
        '
        'LASTNAME
        '
        Me.LASTNAME.HeaderText = "LASTNAME"
        Me.LASTNAME.Name = "LASTNAME"
        Me.LASTNAME.ReadOnly = True
        '
        'SUFFIX
        '
        Me.SUFFIX.HeaderText = "SUFFIX"
        Me.SUFFIX.Name = "SUFFIX"
        Me.SUFFIX.ReadOnly = True
        '
        'HOUSEHOLD
        '
        Me.HOUSEHOLD.HeaderText = "HOUSEHOLD"
        Me.HOUSEHOLD.Name = "HOUSEHOLD"
        Me.HOUSEHOLD.ReadOnly = True
        '
        'PUROK
        '
        Me.PUROK.HeaderText = "PUROK"
        Me.PUROK.Name = "PUROK"
        Me.PUROK.ReadOnly = True
        '
        'ADDRESS
        '
        Me.ADDRESS.HeaderText = "ADDRESS"
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        '
        'BIRTHDATE
        '
        Me.BIRTHDATE.HeaderText = "BIRTHDATE"
        Me.BIRTHDATE.Name = "BIRTHDATE"
        Me.BIRTHDATE.ReadOnly = True
        '
        'SEX
        '
        Me.SEX.HeaderText = "SEX"
        Me.SEX.Name = "SEX"
        Me.SEX.ReadOnly = True
        '
        'OCCUPATIONSTATUS
        '
        Me.OCCUPATIONSTATUS.HeaderText = "OCCUPATIONSTATUS"
        Me.OCCUPATIONSTATUS.Name = "OCCUPATIONSTATUS"
        Me.OCCUPATIONSTATUS.ReadOnly = True
        '
        'CIVILSTATUS
        '
        Me.CIVILSTATUS.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUS.Name = "CIVILSTATUS"
        Me.CIVILSTATUS.ReadOnly = True
        '
        'CONTACT
        '
        Me.CONTACT.HeaderText = "CONTACT"
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.ReadOnly = True
        '
        'save
        '
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.Location = New System.Drawing.Point(608, 256)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(135, 42)
        Me.save.TabIndex = 28
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Location = New System.Drawing.Point(608, 318)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(135, 42)
        Me.clear.TabIndex = 29
        Me.clear.Text = "clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(608, 370)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(135, 42)
        Me.back.TabIndex = 30
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'occupationstatusbox
        '
        Me.occupationstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.occupationstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.occupationstatusbox.FormattingEnabled = True
        Me.occupationstatusbox.Items.AddRange(New Object() {"Pensioner", "Employed", "Unemployed", "Self-employed", "Student"})
        Me.occupationstatusbox.Location = New System.Drawing.Point(622, 85)
        Me.occupationstatusbox.Name = "occupationstatusbox"
        Me.occupationstatusbox.Size = New System.Drawing.Size(121, 21)
        Me.occupationstatusbox.TabIndex = 31
        '
        'suffixbox
        '
        Me.suffixbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suffixbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.suffixbox.FormattingEnabled = True
        Me.suffixbox.Items.AddRange(New Object() {"N/A", "Sr", "Jr", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "Ma."})
        Me.suffixbox.Location = New System.Drawing.Point(469, 36)
        Me.suffixbox.Name = "suffixbox"
        Me.suffixbox.Size = New System.Drawing.Size(121, 21)
        Me.suffixbox.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Household Memeber"
        '
        'registry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.suffixbox)
        Me.Controls.Add(Me.occupationstatusbox)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.householdmember)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.birthdatepicker)
        Me.Controls.Add(Me.civilstatusbox)
        Me.Controls.Add(Me.sexbox)
        Me.Controls.Add(Me.purokbox)
        Me.Controls.Add(Me.contactbox)
        Me.Controls.Add(Me.householdbox)
        Me.Controls.Add(Me.addressbox)
        Me.Controls.Add(Me.middlebox)
        Me.Controls.Add(Me.firstbox)
        Me.Controls.Add(Me.surnamebox)
        Me.Name = "registry"
        Me.Text = "registry"
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents surnamebox As TextBox
    Friend WithEvents firstbox As TextBox
    Friend WithEvents middlebox As TextBox
    Friend WithEvents addressbox As TextBox
    Friend WithEvents householdbox As TextBox
    Friend WithEvents contactbox As TextBox
    Friend WithEvents purokbox As ComboBox
    Friend WithEvents sexbox As ComboBox
    Friend WithEvents civilstatusbox As ComboBox
    Friend WithEvents birthdatepicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents householdmember As DataGridView
    Friend WithEvents save As Button
    Friend WithEvents clear As Button
    Friend WithEvents back As Button
    Friend WithEvents occupationstatusbox As ComboBox
    Friend WithEvents suffixbox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SURNAME As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAME As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAME As DataGridViewTextBoxColumn
    Friend WithEvents SUFFIX As DataGridViewTextBoxColumn
    Friend WithEvents HOUSEHOLD As DataGridViewTextBoxColumn
    Friend WithEvents PUROK As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents SEX As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPATIONSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT As DataGridViewTextBoxColumn
End Class
