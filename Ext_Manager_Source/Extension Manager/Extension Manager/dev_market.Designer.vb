<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dev_market
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dev_market))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_download_status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.downloads = New System.Windows.Forms.PictureBox()
        Me.refresh = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dl_progress = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.downloads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dl_progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(830, 606)
        Me.WebBrowser1.TabIndex = 6
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Extension_Manager.My.Resources.Resources.Preloader_2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(830, 526)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Extension_Manager.My.Resources.Resources.main_bar
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lb_download_status)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.downloads)
        Me.Panel2.Controls.Add(Me.refresh)
        Me.Panel2.Controls.Add(Me.home)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 56)
        Me.Panel2.TabIndex = 4
        '
        'lb_download_status
        '
        Me.lb_download_status.AutoSize = True
        Me.lb_download_status.BackColor = System.Drawing.Color.Transparent
        Me.lb_download_status.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_download_status.ForeColor = System.Drawing.Color.White
        Me.lb_download_status.Location = New System.Drawing.Point(774, 3)
        Me.lb_download_status.Name = "lb_download_status"
        Me.lb_download_status.Size = New System.Drawing.Size(44, 13)
        Me.lb_download_status.TabIndex = 3
        Me.lb_download_status.Text = "%DL#%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(96, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Extension Market"
        '
        'downloads
        '
        Me.downloads.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.downloads.BackColor = System.Drawing.Color.Transparent
        Me.downloads.BackgroundImage = CType(resources.GetObject("downloads.BackgroundImage"), System.Drawing.Image)
        Me.downloads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.downloads.Location = New System.Drawing.Point(785, 3)
        Me.downloads.Name = "downloads"
        Me.downloads.Size = New System.Drawing.Size(42, 33)
        Me.downloads.TabIndex = 1
        Me.downloads.TabStop = False
        '
        'refresh
        '
        Me.refresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.refresh.BackColor = System.Drawing.Color.Transparent
        Me.refresh.BackgroundImage = CType(resources.GetObject("refresh.BackgroundImage"), System.Drawing.Image)
        Me.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.refresh.Location = New System.Drawing.Point(48, 3)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(42, 33)
        Me.refresh.TabIndex = 2
        Me.refresh.TabStop = False
        '
        'home
        '
        Me.home.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.BackgroundImage = CType(resources.GetObject("home.BackgroundImage"), System.Drawing.Image)
        Me.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home.Location = New System.Drawing.Point(0, 3)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(42, 33)
        Me.home.TabIndex = 0
        Me.home.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImage = Global.Extension_Manager.My.Resources.Resources.bar
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 24)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Text = "3DNUS: dev_market"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Extension_Manager.My.Resources.Resources.Close1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(808, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 19)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.dl_progress)
        Me.Panel3.Location = New System.Drawing.Point(785, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(42, 5)
        Me.Panel3.TabIndex = 8
        '
        'dl_progress
        '
        Me.dl_progress.BackColor = System.Drawing.Color.DodgerBlue
        Me.dl_progress.Location = New System.Drawing.Point(0, -1)
        Me.dl_progress.Name = "dl_progress"
        Me.dl_progress.Size = New System.Drawing.Size(1, 10)
        Me.dl_progress.TabIndex = 0
        Me.dl_progress.TabStop = False
        Me.dl_progress.Visible = False
        '
        'dev_market
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(830, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dev_market"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dev_market"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.downloads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dl_progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents home As PictureBox
    Friend WithEvents downloads As PictureBox
    Friend WithEvents refresh As PictureBox
    Friend WithEvents lb_download_status As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dl_progress As PictureBox
End Class
