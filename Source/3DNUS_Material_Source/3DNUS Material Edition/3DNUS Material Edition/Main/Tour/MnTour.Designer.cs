namespace _3DNUS_Material_Edition
{
    partial class dev_tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_tour));
            this.b_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // b_next
            // 
            this.b_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_next.AutoSize = true;
            this.b_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_next.BackColor = System.Drawing.Color.Transparent;
            this.b_next.Depth = 0;
            this.b_next.Icon = null;
            this.b_next.Location = new System.Drawing.Point(522, 413);
            this.b_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_next.Name = "b_next";
            this.b_next.Primary = false;
            this.b_next.Size = new System.Drawing.Size(55, 36);
            this.b_next.TabIndex = 1;
            this.b_next.Text = "next";
            this.b_next.UseVisualStyleBackColor = false;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(579, 108);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Welcome to 3DNUS: ";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_body
            // 
            this.lbl_body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_body.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(0, 108);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(579, 100);
            this.lbl_body.TabIndex = 3;
            this.lbl_body.Text = "To start you off, we\'ll show you some New Features, and get you setup.\r\n\r\nPlease " +
    "click on the Next Button to Continue, or you may skip this Tour Entirely.";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::_3DNUS_Material_Edition.Properties.Resources.new_3dnus_logo_128;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_logo.Location = new System.Drawing.Point(0, 211);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(579, 240);
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            // 
            // dev_tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 451);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.pb_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Tour ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton b_next;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}