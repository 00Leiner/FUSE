<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEMOGRAPHICS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DEMOGRAPHICS))
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.civilbtn = New System.Windows.Forms.Button()
        Me.purokbtn = New System.Windows.Forms.Button()
        Me.agebtn = New System.Windows.Forms.Button()
        Me.oldcnt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oldbox = New System.Windows.Forms.PictureBox()
        Me.adcnt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adbox = New System.Windows.Forms.PictureBox()
        Me.adocnt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adobox = New System.Windows.Forms.PictureBox()
        Me.childcnt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.childbox = New System.Windows.Forms.PictureBox()
        Me.hmbtn = New System.Windows.Forms.PictureBox()
        Me.overbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oldbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adobox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hmbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox6.Location = New System.Drawing.Point(42, 22)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(209, 207)
        Me.PictureBox6.TabIndex = 69
        Me.PictureBox6.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(272, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(536, 50)
        Me.Label5.TabIndex = 238
        Me.Label5.Text = "POPULATION BY AGE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(315, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(923, 574)
        Me.PictureBox1.TabIndex = 239
        Me.PictureBox1.TabStop = False
        '
        'civilbtn
        '
        Me.civilbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.civilbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.civilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.civilbtn.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.civilbtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.civilbtn.Location = New System.Drawing.Point(-5, 456)
        Me.civilbtn.Name = "civilbtn"
        Me.civilbtn.Size = New System.Drawing.Size(293, 70)
        Me.civilbtn.TabIndex = 243
        Me.civilbtn.Text = "POPULATION BY CIVIL STATUS"
        Me.civilbtn.UseVisualStyleBackColor = False
        '
        'purokbtn
        '
        Me.purokbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.purokbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purokbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purokbtn.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purokbtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.purokbtn.Location = New System.Drawing.Point(-5, 358)
        Me.purokbtn.Name = "purokbtn"
        Me.purokbtn.Size = New System.Drawing.Size(293, 73)
        Me.purokbtn.TabIndex = 242
        Me.purokbtn.Text = "POPULATION BY PUROK"
        Me.purokbtn.UseVisualStyleBackColor = False
        '
        'agebtn
        '
        Me.agebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.agebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agebtn.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agebtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.agebtn.Location = New System.Drawing.Point(-5, 266)
        Me.agebtn.Name = "agebtn"
        Me.agebtn.Size = New System.Drawing.Size(293, 70)
        Me.agebtn.TabIndex = 240
        Me.agebtn.Text = "POPULATION BY AGE"
        Me.agebtn.UseVisualStyleBackColor = False
        '
        'oldcnt
        '
        Me.oldcnt.AutoSize = True
        Me.oldcnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.oldcnt.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldcnt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.oldcnt.Location = New System.Drawing.Point(852, 500)
        Me.oldcnt.Name = "oldcnt"
        Me.oldcnt.Size = New System.Drawing.Size(25, 31)
        Me.oldcnt.TabIndex = 255
        Me.oldcnt.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(804, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 24)
        Me.Label4.TabIndex = 254
        Me.Label4.Text = "AGES 66 and OVER"
        '
        'oldbox
        '
        Me.oldbox.BackgroundImage = CType(resources.GetObject("oldbox.BackgroundImage"), System.Drawing.Image)
        Me.oldbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.oldbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.oldbox.Location = New System.Drawing.Point(787, 391)
        Me.oldbox.Name = "oldbox"
        Me.oldbox.Size = New System.Drawing.Size(376, 228)
        Me.oldbox.TabIndex = 253
        Me.oldbox.TabStop = False
        '
        'adcnt
        '
        Me.adcnt.AutoSize = True
        Me.adcnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.adcnt.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adcnt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.adcnt.Location = New System.Drawing.Point(463, 504)
        Me.adcnt.Name = "adcnt"
        Me.adcnt.Size = New System.Drawing.Size(25, 31)
        Me.adcnt.TabIndex = 252
        Me.adcnt.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(399, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "AGES 18 to 65"
        '
        'adbox
        '
        Me.adbox.BackgroundImage = CType(resources.GetObject("adbox.BackgroundImage"), System.Drawing.Image)
        Me.adbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.adbox.Location = New System.Drawing.Point(382, 391)
        Me.adbox.Name = "adbox"
        Me.adbox.Size = New System.Drawing.Size(376, 228)
        Me.adbox.TabIndex = 250
        Me.adbox.TabStop = False
        '
        'adocnt
        '
        Me.adocnt.AutoSize = True
        Me.adocnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.adocnt.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adocnt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.adocnt.Location = New System.Drawing.Point(852, 235)
        Me.adocnt.Name = "adocnt"
        Me.adocnt.Size = New System.Drawing.Size(25, 31)
        Me.adocnt.TabIndex = 249
        Me.adocnt.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(804, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = "AGES 13 to 17"
        '
        'adobox
        '
        Me.adobox.BackgroundImage = CType(resources.GetObject("adobox.BackgroundImage"), System.Drawing.Image)
        Me.adobox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adobox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.adobox.Location = New System.Drawing.Point(787, 140)
        Me.adobox.Name = "adobox"
        Me.adobox.Size = New System.Drawing.Size(376, 228)
        Me.adobox.TabIndex = 247
        Me.adobox.TabStop = False
        '
        'childcnt
        '
        Me.childcnt.AutoSize = True
        Me.childcnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.childcnt.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childcnt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.childcnt.Location = New System.Drawing.Point(463, 235)
        Me.childcnt.Name = "childcnt"
        Me.childcnt.Size = New System.Drawing.Size(25, 31)
        Me.childcnt.TabIndex = 246
        Me.childcnt.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(399, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 24)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "AGES 12 and UNDER"
        '
        'childbox
        '
        Me.childbox.BackgroundImage = CType(resources.GetObject("childbox.BackgroundImage"), System.Drawing.Image)
        Me.childbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.childbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.childbox.Location = New System.Drawing.Point(383, 140)
        Me.childbox.Name = "childbox"
        Me.childbox.Size = New System.Drawing.Size(376, 228)
        Me.childbox.TabIndex = 244
        Me.childbox.TabStop = False
        '
        'hmbtn
        '
        Me.hmbtn.BackgroundImage = CType(resources.GetObject("hmbtn.BackgroundImage"), System.Drawing.Image)
        Me.hmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hmbtn.Location = New System.Drawing.Point(1168, 12)
        Me.hmbtn.Name = "hmbtn"
        Me.hmbtn.Size = New System.Drawing.Size(70, 66)
        Me.hmbtn.TabIndex = 101
        Me.hmbtn.TabStop = False
        '
        'overbtn
        '
        Me.overbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.overbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.overbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overbtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.overbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.overbtn.Location = New System.Drawing.Point(-5, 550)
        Me.overbtn.Name = "overbtn"
        Me.overbtn.Size = New System.Drawing.Size(293, 70)
        Me.overbtn.TabIndex = 256
        Me.overbtn.Text = "OVERVIEW"
        Me.overbtn.UseVisualStyleBackColor = False
        '
        'DEMOGRAPHICS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1263, 693)
        Me.Controls.Add(Me.overbtn)
        Me.Controls.Add(Me.oldcnt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.oldbox)
        Me.Controls.Add(Me.adcnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adbox)
        Me.Controls.Add(Me.adocnt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.adobox)
        Me.Controls.Add(Me.childcnt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.childbox)
        Me.Controls.Add(Me.civilbtn)
        Me.Controls.Add(Me.purokbtn)
        Me.Controls.Add(Me.agebtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hmbtn)
        Me.Controls.Add(Me.PictureBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DEMOGRAPHICS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oldbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adobox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hmbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents civilbtn As Button
    Friend WithEvents purokbtn As Button
    Friend WithEvents agebtn As Button
    Friend WithEvents oldcnt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents oldbox As PictureBox
    Friend WithEvents adcnt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents adbox As PictureBox
    Friend WithEvents adocnt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents adobox As PictureBox
    Friend WithEvents childcnt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents childbox As PictureBox
    Friend WithEvents hmbtn As PictureBox
    Friend WithEvents overbtn As Button
End Class
