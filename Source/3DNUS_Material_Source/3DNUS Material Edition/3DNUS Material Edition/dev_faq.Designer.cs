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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dev_label_error = new MaterialSkin.Controls.MaterialLabel();
            this.devtab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.dev_tab_control.Size = new System.Drawing.Size(487, 23);
            this.dev_tab_control.TabIndex = 0;
            this.dev_tab_control.Click += new System.EventHandler(this.dev_tab_control_Click);
            // 
            // devtab
            // 
            this.devtab.Controls.Add(this.tabPage1);
            this.devtab.Controls.Add(this.tabPage3);
            this.devtab.Depth = 0;
            this.devtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devtab.Location = new System.Drawing.Point(0, 23);
            this.devtab.MouseState = MaterialSkin.MouseState.HOVER;
            this.devtab.Name = "devtab";
            this.devtab.SelectedIndex = 0;
            this.devtab.Size = new System.Drawing.Size(487, 435);
            this.devtab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(479, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Offline Faq";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dev_label_error);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(479, 409);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Online Faq";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(479, 409);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // dev_label_error
            // 
            this.dev_label_error.AutoSize = true;
            this.dev_label_error.BackColor = System.Drawing.Color.Transparent;
            this.dev_label_error.Depth = 0;
            this.dev_label_error.Font = new System.Drawing.Font("Roboto", 11F);
            this.dev_label_error.ForeColor = System.Drawing.Color.Red;
            this.dev_label_error.Location = new System.Drawing.Point(8, 10);
            this.dev_label_error.MouseState = MaterialSkin.MouseState.HOVER;
            this.dev_label_error.Name = "dev_label_error";
            this.dev_label_error.Size = new System.Drawing.Size(149, 19);
            this.dev_label_error.TabIndex = 0;
            this.dev_label_error.Text = "Unable to grab URL...";
            // 
            // dev_faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(487, 458);
            this.Controls.Add(this.devtab);
            this.Controls.Add(this.dev_tab_control);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector dev_tab_control;
        private MaterialSkin.Controls.MaterialTabControl devtab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel dev_label_error;
    }
}