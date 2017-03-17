<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class init_config
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(init_config))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vs8 = New System.Windows.Forms.RadioButton()
        Me.vs10 = New System.Windows.Forms.RadioButton()
        Me.vs15_16 = New System.Windows.Forms.RadioButton()
        Me.vs12_13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.vs_no_use = New System.Windows.Forms.RadioButton()
        Me.vs_not_installed = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global._3DNUS_Devkit.My.Resources.Resources.service_manager1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 82)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 24)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Initial Configuration: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(516, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 19)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(104, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Let's begin! "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Which version of Visual Studio Do you use? "
        '
        'vs8
        '
        Me.vs8.AutoSize = True
        Me.vs8.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs8.ForeColor = System.Drawing.Color.White
        Me.vs8.Location = New System.Drawing.Point(21, 212)
        Me.vs8.Name = "vs8"
        Me.vs8.Size = New System.Drawing.Size(115, 19)
        Me.vs8.TabIndex = 5
        Me.vs8.Text = "Visual Studio 2008"
        Me.vs8.UseVisualStyleBackColor = True
        '
        'vs10
        '
        Me.vs10.AutoSize = True
        Me.vs10.Checked = True
        Me.vs10.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs10.ForeColor = System.Drawing.Color.White
        Me.vs10.Location = New System.Drawing.Point(21, 237)
        Me.vs10.Name = "vs10"
        Me.vs10.Size = New System.Drawing.Size(113, 19)
        Me.vs10.TabIndex = 6
        Me.vs10.TabStop = True
        Me.vs10.Text = "Visual Studio 2010"
        Me.vs10.UseVisualStyleBackColor = True
        '
        'vs15_16
        '
        Me.vs15_16.AutoSize = True
        Me.vs15_16.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs15_16.ForeColor = System.Drawing.Color.White
        Me.vs15_16.Location = New System.Drawing.Point(21, 287)
        Me.vs15_16.Name = "vs15_16"
        Me.vs15_16.Size = New System.Drawing.Size(139, 19)
        Me.vs15_16.TabIndex = 8
        Me.vs15_16.Text = "Visual Studio 2015/2016"
        Me.vs15_16.UseVisualStyleBackColor = True
        '
        'vs12_13
        '
        Me.vs12_13.AutoSize = True
        Me.vs12_13.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs12_13.ForeColor = System.Drawing.Color.White
        Me.vs12_13.Location = New System.Drawing.Point(21, 262)
        Me.vs12_13.Name = "vs12_13"
        Me.vs12_13.Size = New System.Drawing.Size(139, 19)
        Me.vs12_13.TabIndex = 7
        Me.vs12_13.Text = "Visual Studio 2012/2013"
        Me.vs12_13.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.ForeColor = System.Drawing.Color.White
        Me.RadioButton5.Location = New System.Drawing.Point(21, 187)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(124, 19)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.Text = "An Anchient Version"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'vs_no_use
        '
        Me.vs_no_use.AutoSize = True
        Me.vs_no_use.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs_no_use.ForeColor = System.Drawing.Color.White
        Me.vs_no_use.Location = New System.Drawing.Point(21, 312)
        Me.vs_no_use.Name = "vs_no_use"
        Me.vs_no_use.Size = New System.Drawing.Size(143, 19)
        Me.vs_no_use.TabIndex = 8
        Me.vs_no_use.Text = "I don't use Visual Studio"
        Me.vs_no_use.UseVisualStyleBackColor = True
        '
        'vs_not_installed
        '
        Me.vs_not_installed.AutoSize = True
        Me.vs_not_installed.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vs_not_installed.ForeColor = System.Drawing.Color.White
        Me.vs_not_installed.Location = New System.Drawing.Point(21, 337)
        Me.vs_not_installed.Name = "vs_not_installed"
        Me.vs_not_installed.Size = New System.Drawing.Size(197, 19)
        Me.vs_not_installed.TabIndex = 10
        Me.vs_not_installed.Text = "I don't have Visual Studio Installed "
        Me.vs_not_installed.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(451, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(355, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Go to Visual Studio Download Site. "
        '
        'init_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(538, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vs_not_installed)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.vs_no_use)
        Me.Controls.Add(Me.vs15_16)
        Me.Controls.Add(Me.vs12_13)
        Me.Controls.Add(Me.vs10)
        Me.Controls.Add(Me.vs8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "init_config"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initial Config"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vs8 As RadioButton
    Friend WithEvents vs10 As RadioButton
    Friend WithEvents vs15_16 As RadioButton
    Friend WithEvents vs12_13 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents vs_no_use As RadioButton
    Friend WithEvents vs_not_installed As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
