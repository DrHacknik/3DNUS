namespace _3DNUS_Material_Edition
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.b_download = new MaterialSkin.Controls.MaterialFlatButton();
            this.c_cia = new MaterialSkin.Controls.MaterialCheckBox();
            this.prog_main = new MaterialSkin.Controls.MaterialProgressBar();
            this.t_titleid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_log = new System.Windows.Forms.TextBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.extensionManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.check_noerr = new MaterialSkin.Controls.MaterialCheckBox();
            this.prog_sub = new MaterialSkin.Controls.MaterialProgressBar();
            this.panel_ctl = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1.SuspendLayout();
            this.panel_ctl.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_download
            // 
            this.b_download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_download.AutoSize = true;
            this.b_download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_download.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_download.Depth = 0;
            this.b_download.Location = new System.Drawing.Point(161, 385);
            this.b_download.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_download.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_download.Name = "b_download";
            this.b_download.Primary = false;
            this.b_download.Size = new System.Drawing.Size(130, 36);
            this.b_download.TabIndex = 0;
            this.b_download.Text = "Begin Download";
            this.b_download.UseVisualStyleBackColor = false;
            this.b_download.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // c_cia
            // 
            this.c_cia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_cia.AutoSize = true;
            this.c_cia.BackColor = System.Drawing.Color.Transparent;
            this.c_cia.Checked = true;
            this.c_cia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c_cia.Depth = 0;
            this.c_cia.Font = new System.Drawing.Font("Roboto", 10F);
            this.c_cia.Location = new System.Drawing.Point(73, 0);
            this.c_cia.Margin = new System.Windows.Forms.Padding(0);
            this.c_cia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.c_cia.MouseState = MaterialSkin.MouseState.HOVER;
            this.c_cia.Name = "c_cia";
            this.c_cia.Ripple = true;
            this.c_cia.Size = new System.Drawing.Size(104, 30);
            this.c_cia.TabIndex = 1;
            this.c_cia.Text = "Pack as CIA";
            this.c_cia.UseVisualStyleBackColor = false;
            // 
            // prog_main
            // 
            this.prog_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prog_main.Depth = 0;
            this.prog_main.Location = new System.Drawing.Point(12, 433);
            this.prog_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.prog_main.Name = "prog_main";
            this.prog_main.Size = new System.Drawing.Size(441, 5);
            this.prog_main.TabIndex = 2;
            // 
            // t_titleid
            // 
            this.t_titleid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_titleid.Depth = 0;
            this.t_titleid.Hint = "Title/Firmware";
            this.t_titleid.Location = new System.Drawing.Point(12, 81);
            this.t_titleid.MaxLength = 32767;
            this.t_titleid.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_titleid.Name = "t_titleid";
            this.t_titleid.PasswordChar = '\0';
            this.t_titleid.SelectedText = "";
            this.t_titleid.SelectionLength = 0;
            this.t_titleid.SelectionStart = 0;
            this.t_titleid.Size = new System.Drawing.Size(441, 23);
            this.t_titleid.TabIndex = 3;
            this.t_titleid.TabStop = false;
            this.t_titleid.UseSystemPasswordChar = false;
            // 
            // t_log
            // 
            this.t_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_log.BackColor = System.Drawing.Color.Gainsboro;
            this.t_log.Location = new System.Drawing.Point(12, 167);
            this.t_log.Multiline = true;
            this.t_log.Name = "t_log";
            this.t_log.ReadOnly = true;
            this.t_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_log.Size = new System.Drawing.Size(441, 209);
            this.t_log.TabIndex = 4;
            this.t_log.Text = "Console: ";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extensionManagerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            // 
            // extensionManagerToolStripMenuItem
            // 
            this.extensionManagerToolStripMenuItem.Name = "extensionManagerToolStripMenuItem";
            this.extensionManagerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.extensionManagerToolStripMenuItem.Text = "Extension Manager";
            this.extensionManagerToolStripMenuItem.Click += new System.EventHandler(this.extensionManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(185, -1);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(85, 30);
            this.materialRadioButton1.TabIndex = 6;
            this.materialRadioButton1.Text = "New 3DS";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Checked = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(278, -1);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(78, 30);
            this.materialRadioButton2.TabIndex = 7;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Old 3DS";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-2, 454);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Stable Build";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(2, 140);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(462, 2);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // check_noerr
            // 
            this.check_noerr.AutoSize = true;
            this.check_noerr.Depth = 0;
            this.check_noerr.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_noerr.Location = new System.Drawing.Point(0, 0);
            this.check_noerr.Margin = new System.Windows.Forms.Padding(0);
            this.check_noerr.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_noerr.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_noerr.Name = "check_noerr";
            this.check_noerr.Ripple = true;
            this.check_noerr.Size = new System.Drawing.Size(65, 30);
            this.check_noerr.TabIndex = 10;
            this.check_noerr.Text = "Silent";
            this.check_noerr.UseVisualStyleBackColor = true;
            // 
            // prog_sub
            // 
            this.prog_sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prog_sub.Depth = 0;
            this.prog_sub.Location = new System.Drawing.Point(12, 444);
            this.prog_sub.MouseState = MaterialSkin.MouseState.HOVER;
            this.prog_sub.Name = "prog_sub";
            this.prog_sub.Size = new System.Drawing.Size(441, 5);
            this.prog_sub.TabIndex = 2;
            // 
            // panel_ctl
            // 
            this.panel_ctl.BackColor = System.Drawing.Color.White;
            this.panel_ctl.Controls.Add(this.c_cia);
            this.panel_ctl.Controls.Add(this.materialRadioButton1);
            this.panel_ctl.Controls.Add(this.check_noerr);
            this.panel_ctl.Controls.Add(this.materialRadioButton2);
            this.panel_ctl.Location = new System.Drawing.Point(53, 110);
            this.panel_ctl.Name = "panel_ctl";
            this.panel_ctl.Size = new System.Drawing.Size(363, 24);
            this.panel_ctl.TabIndex = 11;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(445, 68);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(19, 36);
            this.materialFlatButton1.TabIndex = 12;
            this.materialFlatButton1.Text = "?";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 471);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panel_ctl);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.t_log);
            this.Controls.Add(this.t_titleid);
            this.Controls.Add(this.prog_sub);
            this.Controls.Add(this.prog_main);
            this.Controls.Add(this.b_download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_ResizeEnd);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.panel_ctl.ResumeLayout(false);
            this.panel_ctl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton b_download;
        private MaterialSkin.Controls.MaterialCheckBox c_cia;
        private MaterialSkin.Controls.MaterialProgressBar prog_main;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_titleid;
        private System.Windows.Forms.TextBox t_log;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extensionManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox check_noerr;
        private MaterialSkin.Controls.MaterialProgressBar prog_sub;
        private System.Windows.Forms.Panel panel_ctl;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

