<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESIDENTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RESIDENTS))
        Me.exitlink = New System.Windows.Forms.LinkLabel()
        Me.minlink = New System.Windows.Forms.Label()
        Me.maxlink = New System.Windows.Forms.Label()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.returnbtn = New System.Windows.Forms.PictureBox()
        Me.recordview = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUFFIXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOUSEHOLDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUROKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIBLINGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUSEAPPDATABASEDataSetFull = New FUSE.FUSEAPPDATABASEDataSetFull()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.INFOSTableAdapter = New FUSE.FUSEAPPDATABASEDataSetFullTableAdapters.INFOSTableAdapter()
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recordview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUSEAPPDATABASEDataSetFull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.exitlink.Location = New System.Drawing.Point(1312, 9)
        Me.exitlink.Name = "exitlink"
        Me.exitlink.Size = New System.Drawing.Size(53, 50)
        Me.exitlink.TabIndex = 203
        Me.exitlink.TabStop = True
        Me.exitlink.Text = "X"
        Me.exitlink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(43, Byte), Integer))
        '
        'minlink
        '
        Me.minlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minlink.AutoSize = True
        Me.minlink.BackColor = System.Drawing.Color.Transparent
        Me.minlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minlink.Font = New System.Drawing.Font("Century Schoolbook", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minlink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.minlink.Location = New System.Drawing.Point(1209, 0)
        Me.minlink.Name = "minlink"
        Me.minlink.Size = New System.Drawing.Size(50, 59)
        Me.minlink.TabIndex = 204
        Me.minlink.Text = "_"
        '
        'maxlink
        '
        Me.maxlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxlink.AutoSize = True
        Me.maxlink.BackColor = System.Drawing.Color.Transparent
        Me.maxlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maxlink.Font = New System.Drawing.Font("Century Schoolbook", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxlink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.maxlink.Location = New System.Drawing.Point(1255, 9)
        Me.maxlink.Name = "maxlink"
        Me.maxlink.Size = New System.Drawing.Size(63, 59)
        Me.maxlink.TabIndex = 205
        Me.maxlink.Text = "▢"
        '
        'searchbox
        '
        Me.searchbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchbox.BackColor = System.Drawing.Color.Gainsboro
        Me.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbox.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.Location = New System.Drawing.Point(277, 158)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(1043, 41)
        Me.searchbox.TabIndex = 208
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(538, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 50)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "RESIDENTS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("YouYuan", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(153, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 20)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "SEARCH RESIDENT'S SURNAME:"
        '
        'returnbtn
        '
        Me.returnbtn.BackColor = System.Drawing.Color.Transparent
        Me.returnbtn.BackgroundImage = CType(resources.GetObject("returnbtn.BackgroundImage"), System.Drawing.Image)
        Me.returnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnbtn.Location = New System.Drawing.Point(12, 18)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(54, 43)
        Me.returnbtn.TabIndex = 234
        Me.returnbtn.TabStop = False
        '
        'recordview
        '
        Me.recordview.AllowUserToAddRows = False
        Me.recordview.AllowUserToDeleteRows = False
        Me.recordview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordview.AutoGenerateColumns = False
        Me.recordview.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.recordview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recordview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SUFFIXDataGridViewTextBoxColumn, Me.HOUSEHOLDDataGridViewTextBoxColumn, Me.PUROKDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.BIRTHDATEDataGridViewTextBoxColumn, Me.SEXDataGridViewTextBoxColumn, Me.SIBLINGDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn})
        Me.recordview.DataSource = Me.INFOSBindingSource
        Me.recordview.Location = New System.Drawing.Point(53, 245)
        Me.recordview.Name = "recordview"
        Me.recordview.ReadOnly = True
        Me.recordview.RowHeadersWidth = 51
        Me.recordview.RowTemplate.Height = 24
        Me.recordview.Size = New System.Drawing.Size(1267, 411)
        Me.recordview.TabIndex = 235
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDDataGridViewTextBoxColumn.Width = 125
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
        'HOUSEHOLDDataGridViewTextBoxColumn
        '
        Me.HOUSEHOLDDataGridViewTextBoxColumn.DataPropertyName = "HOUSEHOLD"
        Me.HOUSEHOLDDataGridViewTextBoxColumn.HeaderText = "HOUSEHOLD"
        Me.HOUSEHOLDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HOUSEHOLDDataGridViewTextBoxColumn.Name = "HOUSEHOLDDataGridViewTextBoxColumn"
        Me.HOUSEHOLDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HOUSEHOLDDataGridViewTextBoxColumn.Width = 125
        '
        'PUROKDataGridViewTextBoxColumn
        '
        Me.PUROKDataGridViewTextBoxColumn.DataPropertyName = "PUROK"
        Me.PUROKDataGridViewTextBoxColumn.HeaderText = "PUROK"
        Me.PUROKDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PUROKDataGridViewTextBoxColumn.Name = "PUROKDataGridViewTextBoxColumn"
        Me.PUROKDataGridViewTextBoxColumn.ReadOnly = True
        Me.PUROKDataGridViewTextBoxColumn.Width = 125
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ADDRESSDataGridViewTextBoxColumn.Width = 125
        '
        'BIRTHDATEDataGridViewTextBoxColumn
        '
        Me.BIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE"
        Me.BIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE"
        Me.BIRTHDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BIRTHDATEDataGridViewTextBoxColumn.Name = "BIRTHDATEDataGridViewTextBoxColumn"
        Me.BIRTHDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.BIRTHDATEDataGridViewTextBoxColumn.Width = 125
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
        'SIBLINGDataGridViewTextBoxColumn
        '
        Me.SIBLINGDataGridViewTextBoxColumn.DataPropertyName = "SIBLING"
        Me.SIBLINGDataGridViewTextBoxColumn.HeaderText = "SIBLING"
        Me.SIBLINGDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SIBLINGDataGridViewTextBoxColumn.Name = "SIBLINGDataGridViewTextBoxColumn"
        Me.SIBLINGDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIBLINGDataGridViewTextBoxColumn.Width = 125
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
        Me.INFOSBindingSource.DataSource = Me.FUSEAPPDATABASEDataSetFull
        '
        'FUSEAPPDATABASEDataSetFull
        '
        Me.FUSEAPPDATABASEDataSetFull.DataSetName = "FUSEAPPDATABASEDataSetFull"
        Me.FUSEAPPDATABASEDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'delbtn
        '
        Me.delbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.delbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.delbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delbtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.delbtn.ForeColor = System.Drawing.Color.Transparent
        Me.delbtn.Location = New System.Drawing.Point(53, 687)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(220, 70)
        Me.delbtn.TabIndex = 236
        Me.delbtn.Text = "DELETE"
        Me.delbtn.UseVisualStyleBackColor = False
        '
        'viewbtn
        '
        Me.viewbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewbtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.viewbtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.viewbtn.Location = New System.Drawing.Point(1100, 697)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(220, 70)
        Me.viewbtn.TabIndex = 238
        Me.viewbtn.Text = "DISPLAY"
        Me.viewbtn.UseVisualStyleBackColor = False
        '
        'INFOSTableAdapter
        '
        Me.INFOSTableAdapter.ClearBeforeFill = True
        '
        'RESIDENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1377, 791)
        Me.Controls.Add(Me.viewbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.recordview)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.maxlink)
        Me.Controls.Add(Me.exitlink)
        Me.Controls.Add(Me.minlink)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RESIDENTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESIDENTS"
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recordview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUSEAPPDATABASEDataSetFull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitlink As LinkLabel
    Friend WithEvents minlink As Label
    Friend WithEvents maxlink As Label
    Friend WithEvents searchbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents returnbtn As PictureBox
    Friend WithEvents recordview As DataGridView
    Friend WithEvents delbtn As Button
    Friend WithEvents viewbtn As Button
    Friend WithEvents FUSEAPPDATABASEDataSetFull As FUSEAPPDATABASEDataSetFull
    Friend WithEvents INFOSBindingSource As BindingSource
    Friend WithEvents INFOSTableAdapter As FUSEAPPDATABASEDataSetFullTableAdapters.INFOSTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUFFIXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOUSEHOLDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUROKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIBLINGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
