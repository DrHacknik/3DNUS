namespace _3DNUS_Material_Edition
{
    partial class MnAbout
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.btn_ok = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_usage = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_3DNUS_Material_Edition.Properties.Resources.new_3dnus_logo_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(120, 92);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(375, 36);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "%ver%";
            // 
            // lbl_body
            // 
            this.lbl_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(122, 138);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(375, 341);
            this.lbl_body.TabIndex = 4;
            this.lbl_body.Text = "%body%";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.AutoSize = true;
            this.btn_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ok.Depth = 0;
            this.btn_ok.Icon = null;
            this.btn_ok.Location = new System.Drawing.Point(465, 485);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Primary = false;
            this.btn_ok.Size = new System.Drawing.Size(39, 36);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_usage
            // 
            this.btn_usage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_usage.AutoSize = true;
            this.btn_usage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_usage.Depth = 0;
            this.btn_usage.Icon = null;
            this.btn_usage.Location = new System.Drawing.Point(393, 485);
            this.btn_usage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_usage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_usage.Name = "btn_usage";
            this.btn_usage.Primary = false;
            this.btn_usage.Size = new System.Drawing.Size(64, 36);
            this.btn_usage.TabIndex = 6;
            this.btn_usage.Text = "Usage";
            this.btn_usage.UseVisualStyleBackColor = true;
            this.btn_usage.Click += new System.EventHandler(this.btn_usage_Click);
            // 
            // MnAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btn_usage);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MnAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Information: ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MnAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_body;
        private MaterialSkin.Controls.MaterialFlatButton btn_ok;
        private MaterialSkin.Controls.MaterialFlatButton btn_usage;
    }
}