namespace _3DNUS_Material_Edition
{
    partial class dev_faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_faq));
            this.dev_tab_control = new MaterialSkin.Controls.MaterialTabSelector();
            this.devtab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dev_label_error = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_prep = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_type = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rch_debug = new System.Windows.Forms.RichTextBox();
            this.txt_user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.devtab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dev_tab_control
            // 
            this.dev_tab_control.BaseTabControl = this.devtab;
            this.dev_tab_control.Depth = 0;
            this.dev_tab_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.dev_tab_control.Location = new System.Drawing.Point(0, 0);
            this.dev_tab_control.MouseState = MaterialSkin.MouseState.HOVER;
            this.dev_tab_control.Name = "dev_tab_control";
            this.dev_tab_control.Size = new System.Drawing.Size(580, 23);
            this.dev_tab_control.TabIndex = 0;
            this.dev_tab_control.Click += new System.EventHandler(this.dev_tab_control_Click);
            // 
            // devtab
            // 
            this.devtab.Controls.Add(this.tabPage1);
            this.devtab.Controls.Add(this.tabPage3);
            this.devtab.Controls.Add(this.tabPage2);
            this.devtab.Depth = 0;
            this.devtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devtab.Location = new System.Drawing.Point(0, 23);
            this.devtab.MouseState = MaterialSkin.MouseState.HOVER;
            this.devtab.Name = "devtab";
            this.devtab.SelectedIndex = 0;
            this.devtab.Size = new System.Drawing.Size(580, 490);
            this.devtab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(572, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Offline Faq";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(572, 464);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dev_label_error);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(572, 464);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Online Faq";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dev_label_error
            // 
            this.dev_label_error.AutoSize = true;
            this.dev_label_error.BackColor = System.Drawing.Color.Transparent;
            this.dev_label_error.Depth = 0;
            this.dev_label_error.Font = new System.Drawing.Font("Roboto", 11F);
            this.dev_label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dev_label_error.Location = new System.Drawing.Point(8, 10);
            this.dev_label_error.MouseState = MaterialSkin.MouseState.HOVER;
            this.dev_label_error.Name = "dev_label_error";
            this.dev_label_error.Size = new System.Drawing.Size(149, 19);
            this.dev_label_error.TabIndex = 0;
            this.dev_label_error.Text = "Unable to grab URL...";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btn_prep);
            this.tabPage2.Controls.Add(this.lbl_info);
            this.tabPage2.Controls.Add(this.txt_type);
            this.tabPage2.Controls.Add(this.rch_debug);
            this.tabPage2.Controls.Add(this.txt_user);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(572, 464);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Report a Bug ";
            // 
            // btn_prep
            // 
            this.btn_prep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prep.AutoSize = true;
            this.btn_prep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prep.Depth = 0;
            this.btn_prep.Location = new System.Drawing.Point(437, 45);
            this.btn_prep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prep.Name = "btn_prep";
            this.btn_prep.Primary = false;
            this.btn_prep.Size = new System.Drawing.Size(126, 36);
            this.btn_prep.TabIndex = 6;
            this.btn_prep.Text = "Prepare Report";
            this.btn_prep.UseVisualStyleBackColor = true;
            this.btn_prep.Click += new System.EventHandler(this.btn_prep_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(8, 68);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(150, 13);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "Ex: \"Crash, JIT Error, or other\"";
            // 
            // txt_type
            // 
            this.txt_type.Depth = 0;
            this.txt_type.Hint = "Type of Bug";
            this.txt_type.Location = new System.Drawing.Point(8, 42);
            this.txt_type.MaxLength = 32767;
            this.txt_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_type.Name = "txt_type";
            this.txt_type.PasswordChar = '\0';
            this.txt_type.SelectedText = "";
            this.txt_type.SelectionLength = 0;
            this.txt_type.SelectionStart = 0;
            this.txt_type.Size = new System.Drawing.Size(234, 23);
            this.txt_type.TabIndex = 3;
            this.txt_type.TabStop = false;
            this.txt_type.UseSystemPasswordChar = false;
            // 
            // rch_debug
            // 
            this.rch_debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rch_debug.Location = new System.Drawing.Point(7, 153);
            this.rch_debug.Name = "rch_debug";
            this.rch_debug.Size = new System.Drawing.Size(556, 303);
            this.rch_debug.TabIndex = 2;
            this.rch_debug.Text = "//";
            // 
            // txt_user
            // 
            this.txt_user.Depth = 0;
            this.txt_user.Hint = "Your name ";
            this.txt_user.Location = new System.Drawing.Point(8, 13);
            this.txt_user.MaxLength = 32767;
            this.txt_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.Size = new System.Drawing.Size(234, 23);
            this.txt_user.TabIndex = 1;
            this.txt_user.TabStop = false;
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // dev_faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(580, 513);
            this.Controls.Add(this.devtab);
            this.Controls.Add(this.dev_tab_control);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_faq";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Faq";
            this.Load += new System.EventHandler(this.dev_faq_Load);
            this.devtab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector dev_tab_control;
        private MaterialSkin.Controls.MaterialTabControl devtab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel dev_label_error;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_info;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_type;
        private System.Windows.Forms.RichTextBox rch_debug;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_user;
        private MaterialSkin.Controls.MaterialFlatButton btn_prep;
    }
}