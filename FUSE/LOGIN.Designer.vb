<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitlink = New System.Windows.Forms.LinkLabel()
        Me.passbox = New System.Windows.Forms.TextBox()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.signinlbl = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(531, 293)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 86)
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(531, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'exitlink
        '
        Me.exitlink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.exitlink.AutoSize = True
        Me.exitlink.BackColor = System.Drawing.Color.Transparent
        Me.exitlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitlink.Font = New System.Drawing.Font("Century Schoolbook", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitlink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitlink.Location = New System.Drawing.Point(946, 10)
        Me.exitlink.Name = "exitlink"
        Me.exitlink.Size = New System.Drawing.Size(49, 47)
        Me.exitlink.TabIndex = 44
        Me.exitlink.TabStop = True
        Me.exitlink.Text = "X"
        Me.exitlink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(86, Byte), Integer))
        '
        'passbox
        '
        Me.passbox.Font = New System.Drawing.Font("SimSun-ExtB", 19.8!)
        Me.passbox.Location = New System.Drawing.Point(643, 316)
        Me.passbox.Name = "passbox"
        Me.passbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passbox.Size = New System.Drawing.Size(304, 40)
        Me.passbox.TabIndex = 43
        '
        'userbox
        '
        Me.userbox.Font = New System.Drawing.Font("SimSun-ExtB", 19.8!)
        Me.userbox.Location = New System.Drawing.Point(643, 225)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(304, 40)
        Me.userbox.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SimSun-ExtB", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.Location = New System.Drawing.Point(639, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SimSun-ExtB", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Location = New System.Drawing.Point(639, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "username"
        '
        'signinlbl
        '
        Me.signinlbl.AutoSize = True
        Me.signinlbl.BackColor = System.Drawing.Color.Transparent
        Me.signinlbl.Font = New System.Drawing.Font("Century Schoolbook", 36.0!, System.Drawing.FontStyle.Bold)
        Me.signinlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.signinlbl.Location = New System.Drawing.Point(676, 96)
        Me.signinlbl.Name = "signinlbl"
        Me.signinlbl.Size = New System.Drawing.Size(250, 71)
        Me.signinlbl.TabIndex = 39
        Me.signinlbl.Text = "Sign in"
        '
        'loginbtn
        '
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.loginbtn.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold)
        Me.loginbtn.Location = New System.Drawing.Point(688, 389)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(185, 59)
        Me.loginbtn.TabIndex = 38
        Me.loginbtn.Text = "Log In"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1003, 554)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitlink)
        Me.Controls.Add(Me.passbox)
        Me.Controls.Add(Me.userbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.signinlbl)
        Me.Controls.Add(Me.loginbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitlink As LinkLabel
    Friend WithEvents passbox As TextBox
    Friend WithEvents userbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents signinlbl As Label
    Friend WithEvents loginbtn As Button
End Class
