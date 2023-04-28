<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRY
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRY))
        Me.sexbox = New System.Windows.Forms.ComboBox()
        Me.civilbox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fmemview = New System.Windows.Forms.DataGridView()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUFFIXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUSEDataSetFamMember = New FUSE.FUSEDataSetFamMember()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.siblingbox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.householdbox = New System.Windows.Forms.TextBox()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.contactbox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dobpick = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.suffixbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.middlebox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.firstbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.surnamebox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuseAppBDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.purokbox = New System.Windows.Forms.ComboBox()
        Me.returnbtn = New System.Windows.Forms.PictureBox()
        Me.INFOSTableAdapter = New FUSE.FUSEDataSetFamMemberTableAdapters.INFOSTableAdapter()
        Me.minlink = New System.Windows.Forms.Label()
        Me.exitlink = New System.Windows.Forms.LinkLabel()
        CType(Me.fmemview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUSEDataSetFamMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuseAppBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sexbox
        '
        Me.sexbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(401, 346)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(200, 35)
        Me.sexbox.TabIndex = 230
        '
        'civilbox
        '
        Me.civilbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.civilbox.FormattingEnabled = True
        Me.civilbox.Items.AddRange(New Object() {"SINGLE", "MARRIED", "SEPARATED", "WIDOWED"})
        Me.civilbox.Location = New System.Drawing.Point(837, 343)
        Me.civilbox.Name = "civilbox"
        Me.civilbox.Size = New System.Drawing.Size(218, 35)
        Me.civilbox.TabIndex = 231
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(17, 429)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 27)
        Me.Label13.TabIndex = 229
        Me.Label13.Text = "Family Members"
        '
        'fmemview
        '
        Me.fmemview.AllowUserToAddRows = False
        Me.fmemview.AllowUserToDeleteRows = False
        Me.fmemview.AllowUserToOrderColumns = True
        Me.fmemview.AutoGenerateColumns = False
        Me.fmemview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fmemview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.fmemview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fmemview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SURNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SUFFIXDataGridViewTextBoxColumn, Me.SEXDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn})
        Me.fmemview.DataSource = Me.INFOSBindingSource
        Me.fmemview.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fmemview.Location = New System.Drawing.Point(118, 469)
        Me.fmemview.Name = "fmemview"
        Me.fmemview.ReadOnly = True
        Me.fmemview.RowHeadersWidth = 51
        Me.fmemview.RowTemplate.Height = 24
        Me.fmemview.Size = New System.Drawing.Size(967, 198)
        Me.fmemview.TabIndex = 228
        '
        'SURNAMEDataGridViewTextBoxColumn
        '
        Me.SURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SURNAMEDataGridViewTextBoxColumn.Name = "SURNAMEDataGridViewTextBoxColumn"
        Me.SURNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SURNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'MIDDLENAMEDataGridViewTextBoxColumn
        '
        Me.MIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Name = "MIDDLENAMEDataGridViewTextBoxColumn"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Width = 125
        '
        'SUFFIXDataGridViewTextBoxColumn
        '
        Me.SUFFIXDataGridViewTextBoxColumn.DataPropertyName = "SUFFIX"
        Me.SUFFIXDataGridViewTextBoxColumn.HeaderText = "SUFFIX"
        Me.SUFFIXDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUFFIXDataGridViewTextBoxColumn.Name = "SUFFIXDataGridViewTextBoxColumn"
        Me.SUFFIXDataGridViewTextBoxColumn.ReadOnly = True
        Me.SUFFIXDataGridViewTextBoxColumn.Width = 125
        '
        'SEXDataGridViewTextBoxColumn
        '
        Me.SEXDataGridViewTextBoxColumn.DataPropertyName = "SEX"
        Me.SEXDataGridViewTextBoxColumn.HeaderText = "SEX"
        Me.SEXDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SEXDataGridViewTextBoxColumn.Name = "SEXDataGridViewTextBoxColumn"
        Me.SEXDataGridViewTextBoxColumn.ReadOnly = True
        Me.SEXDataGridViewTextBoxColumn.Width = 125
        '
        'CIVILSTATUSDataGridViewTextBoxColumn
        '
        Me.CIVILSTATUSDataGridViewTextBoxColumn.DataPropertyName = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Name = "CIVILSTATUSDataGridViewTextBoxColumn"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Width = 125
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
        Me.CONTACTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CONTACTDataGridViewTextBoxColumn.Width = 125
        '
        'INFOSBindingSource
        '
        Me.INFOSBindingSource.DataMember = "INFOS"
        Me.INFOSBindingSource.DataSource = Me.FUSEDataSetFamMember
        '
        'FUSEDataSetFamMember
        '
        Me.FUSEDataSetFamMember.DataSetName = "FUSEDataSetFamMember"
        Me.FUSEDataSetFamMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.savebtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.savebtn.Location = New System.Drawing.Point(1148, 482)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(210, 70)
        Me.savebtn.TabIndex = 227
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.clearbtn.Location = New System.Drawing.Point(1149, 569)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(210, 70)
        Me.clearbtn.TabIndex = 226
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'siblingbox
        '
        Me.siblingbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.siblingbox.Location = New System.Drawing.Point(631, 342)
        Me.siblingbox.Name = "siblingbox"
        Me.siblingbox.Size = New System.Drawing.Size(173, 36)
        Me.siblingbox.TabIndex = 225
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(628, 310)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 18)
        Me.Label17.TabIndex = 224
        Me.Label17.Text = "No. of Siblings"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(59, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 18)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "Household No."
        '
        'householdbox
        '
        Me.householdbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.householdbox.Location = New System.Drawing.Point(61, 257)
        Me.householdbox.Name = "householdbox"
        Me.householdbox.Size = New System.Drawing.Size(153, 36)
        Me.householdbox.TabIndex = 221
        '
        'addressbox
        '
        Me.addressbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addressbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.addressbox.Location = New System.Drawing.Point(401, 256)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.Size = New System.Drawing.Size(966, 36)
        Me.addressbox.TabIndex = 220
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(398, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 219
        Me.Label11.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(241, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 18)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "Purok"
        '
        'contactbox
        '
        Me.contactbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.contactbox.Location = New System.Drawing.Point(1090, 343)
        Me.contactbox.Name = "contactbox"
        Me.contactbox.Size = New System.Drawing.Size(277, 36)
        Me.contactbox.TabIndex = 217
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(1087, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 18)
        Me.Label14.TabIndex = 216
        Me.Label14.Text = "Contact No."
        '
        'dobpick
        '
        Me.dobpick.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.dobpick.Location = New System.Drawing.Point(61, 346)
        Me.dobpick.Name = "dobpick"
        Me.dobpick.Size = New System.Drawing.Size(306, 36)
        Me.dobpick.TabIndex = 215
        Me.dobpick.Value = New Date(2001, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(834, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Civil Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(398, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 18)
        Me.Label8.TabIndex = 213
        Me.Label8.Text = "Sex"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(58, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 212
        Me.Label9.Text = "Date of Birth"
        '
        'suffixbox
        '
        Me.suffixbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.suffixbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.suffixbox.Location = New System.Drawing.Point(1113, 166)
        Me.suffixbox.Name = "suffixbox"
        Me.suffixbox.Size = New System.Drawing.Size(254, 36)
        Me.suffixbox.TabIndex = 211
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(1125, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "Suffix"
        '
        'middlebox
        '
        Me.middlebox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.middlebox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.middlebox.Location = New System.Drawing.Point(775, 166)
        Me.middlebox.Name = "middlebox"
        Me.middlebox.Size = New System.Drawing.Size(310, 36)
        Me.middlebox.TabIndex = 209
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(772, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Middle Name"
        '
        'firstbox
        '
        Me.firstbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firstbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.firstbox.Location = New System.Drawing.Point(401, 166)
        Me.firstbox.Name = "firstbox"
        Me.firstbox.Size = New System.Drawing.Size(347, 36)
        Me.firstbox.TabIndex = 207
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(398, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "First Name"
        '
        'surnamebox
        '
        Me.surnamebox.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnamebox.Location = New System.Drawing.Point(59, 167)
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(308, 36)
        Me.surnamebox.TabIndex = 205
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(56, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(17, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 27)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Personal Information"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(497, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 39)
        Me.Label5.TabIndex = 200
        Me.Label5.Text = "PUBLIC ADMISSION"
        '
        'DETAILSBindingSource
        '
        Me.DETAILSBindingSource.DataMember = "DETAILS"
        '
        'purokbox
        '
        Me.purokbox.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.purokbox.FormattingEnabled = True
        Me.purokbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.purokbox.Location = New System.Drawing.Point(244, 258)
        Me.purokbox.Name = "purokbox"
        Me.purokbox.Size = New System.Drawing.Size(123, 35)
        Me.purokbox.TabIndex = 232
        '
        'returnbtn
        '
        Me.returnbtn.BackColor = System.Drawing.Color.Transparent
        Me.returnbtn.BackgroundImage = CType(resources.GetObject("returnbtn.BackgroundImage"), System.Drawing.Image)
        Me.returnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnbtn.Location = New System.Drawing.Point(22, 11)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(54, 43)
        Me.returnbtn.TabIndex = 233
        Me.returnbtn.TabStop = False
        '
        'INFOSTableAdapter
        '
        Me.INFOSTableAdapter.ClearBeforeFill = True
        '
        'minlink
        '
        Me.minlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minlink.AutoSize = True
        Me.minlink.BackColor = System.Drawing.Color.Transparent
        Me.minlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minlink.Font = New System.Drawing.Font("Century Schoolbook", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minlink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.minlink.Location = New System.Drawing.Point(1286, 5)
        Me.minlink.Name = "minlink"
        Me.minlink.Size = New System.Drawing.Size(50, 59)
        Me.minlink.TabIndex = 202
        Me.minlink.Text = "_"
        '
        'exitlink
        '
        Me.exitlink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.exitlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitlink.AutoSize = True
        Me.exitlink.BackColor = System.Drawing.Color.Transparent
        Me.exitlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitlink.Font = New System.Drawing.Font("Century Schoolbook", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitlink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.exitlink.Location = New System.Drawing.Point(1333, 9)
        Me.exitlink.Name = "exitlink"
        Me.exitlink.Size = New System.Drawing.Size(54, 51)
        Me.exitlink.TabIndex = 201
        Me.exitlink.TabStop = True
        Me.exitlink.Text = "X"
        Me.exitlink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(43, Byte), Integer))
        '
        'REGISTRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1399, 701)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.purokbox)
        Me.Controls.Add(Me.sexbox)
        Me.Controls.Add(Me.civilbox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.fmemview)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.siblingbox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.householdbox)
        Me.Controls.Add(Me.addressbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.contactbox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dobpick)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.suffixbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.middlebox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.firstbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.surnamebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitlink)
        Me.Controls.Add(Me.minlink)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "REGISTRY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.fmemview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUSEDataSetFamMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuseAppBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FuseAppBDDataSetBindingSource As BindingSource
    Friend WithEvents sexbox As ComboBox
    Friend WithEvents civilbox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents fmemview As DataGridView
    Friend WithEvents DETAILSBindingSource As BindingSource
    Friend WithEvents savebtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents siblingbox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents householdbox As TextBox
    Friend WithEvents addressbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents contactbox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dobpick As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents suffixbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents middlebox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents firstbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents surnamebox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents purokbox As ComboBox
    Friend WithEvents returnbtn As PictureBox
    Friend WithEvents FUSEDataSetFamMember As FUSEDataSetFamMember
    Friend WithEvents INFOSBindingSource As BindingSource
    Friend WithEvents INFOSTableAdapter As FUSEDataSetFamMemberTableAdapters.INFOSTableAdapter
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUFFIXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents minlink As Label
    Friend WithEvents exitlink As LinkLabel
End Class
