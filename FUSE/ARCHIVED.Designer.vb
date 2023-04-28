<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARCHIVED
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARCHIVED))
        Me.recordview2 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.returnbtn = New System.Windows.Forms.PictureBox()
        Me.maxlink = New System.Windows.Forms.Label()
        Me.exitlink = New System.Windows.Forms.LinkLabel()
        Me.minlink = New System.Windows.Forms.Label()
        Me.FUSEAPPDATABASEDataSetFull = New FUSE.FUSEAPPDATABASEDataSetFull()
        Me.FUSEAPPDATABASEDataSetFullBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFOSTableAdapter = New FUSE.FUSEAPPDATABASEDataSetFullTableAdapters.INFOSTableAdapter()
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
        CType(Me.recordview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUSEAPPDATABASEDataSetFull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUSEAPPDATABASEDataSetFullBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'recordview2
        '
        Me.recordview2.AllowUserToAddRows = False
        Me.recordview2.AllowUserToDeleteRows = False
        Me.recordview2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordview2.AutoGenerateColumns = False
        Me.recordview2.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.recordview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recordview2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SUFFIXDataGridViewTextBoxColumn, Me.HOUSEHOLDDataGridViewTextBoxColumn, Me.PUROKDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.BIRTHDATEDataGridViewTextBoxColumn, Me.SEXDataGridViewTextBoxColumn, Me.SIBLINGDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn})
        Me.recordview2.DataSource = Me.INFOSBindingSource
        Me.recordview2.Location = New System.Drawing.Point(36, 148)
        Me.recordview2.Name = "recordview2"
        Me.recordview2.ReadOnly = True
        Me.recordview2.RowHeadersWidth = 51
        Me.recordview2.RowTemplate.Height = 24
        Me.recordview2.Size = New System.Drawing.Size(1268, 454)
        Me.recordview2.TabIndex = 236
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(409, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(530, 50)
        Me.Label5.TabIndex = 237
        Me.Label5.Text = "ARCHIVED RECORDS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'returnbtn
        '
        Me.returnbtn.BackColor = System.Drawing.Color.Transparent
        Me.returnbtn.BackgroundImage = CType(resources.GetObject("returnbtn.BackgroundImage"), System.Drawing.Image)
        Me.returnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnbtn.Location = New System.Drawing.Point(20, 27)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(54, 43)
        Me.returnbtn.TabIndex = 241
        Me.returnbtn.TabStop = False
        '
        'maxlink
        '
        Me.maxlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxlink.AutoSize = True
        Me.maxlink.BackColor = System.Drawing.Color.Transparent
        Me.maxlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maxlink.Font = New System.Drawing.Font("Century Schoolbook", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxlink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.maxlink.Location = New System.Drawing.Point(1232, 4)
        Me.maxlink.Name = "maxlink"
        Me.maxlink.Size = New System.Drawing.Size(63, 59)
        Me.maxlink.TabIndex = 240
        Me.maxlink.Text = "▢"
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
        Me.exitlink.Location = New System.Drawing.Point(1289, 4)
        Me.exitlink.Name = "exitlink"
        Me.exitlink.Size = New System.Drawing.Size(53, 50)
        Me.exitlink.TabIndex = 238
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
        Me.minlink.Location = New System.Drawing.Point(1186, -5)
        Me.minlink.Name = "minlink"
        Me.minlink.Size = New System.Drawing.Size(50, 59)
        Me.minlink.TabIndex = 239
        Me.minlink.Text = "_"
        '
        'FUSEAPPDATABASEDataSetFull
        '
        Me.FUSEAPPDATABASEDataSetFull.DataSetName = "FUSEAPPDATABASEDataSetFull"
        Me.FUSEAPPDATABASEDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FUSEAPPDATABASEDataSetFullBindingSource
        '
        Me.FUSEAPPDATABASEDataSetFullBindingSource.DataSource = Me.FUSEAPPDATABASEDataSetFull
        Me.FUSEAPPDATABASEDataSetFullBindingSource.Position = 0
        '
        'INFOSBindingSource
        '
        Me.INFOSBindingSource.DataMember = "INFOS"
        Me.INFOSBindingSource.DataSource = Me.FUSEAPPDATABASEDataSetFullBindingSource
        '
        'INFOSTableAdapter
        '
        Me.INFOSTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
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
        'ARCHIVED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1340, 676)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.maxlink)
        Me.Controls.Add(Me.exitlink)
        Me.Controls.Add(Me.minlink)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.recordview2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ARCHIVED"
        CType(Me.recordview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUSEAPPDATABASEDataSetFull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUSEAPPDATABASEDataSetFullBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents recordview2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents returnbtn As PictureBox
    Friend WithEvents maxlink As Label
    Friend WithEvents exitlink As LinkLabel
    Friend WithEvents minlink As Label
    Friend WithEvents FUSEAPPDATABASEDataSetFullBindingSource As BindingSource
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
